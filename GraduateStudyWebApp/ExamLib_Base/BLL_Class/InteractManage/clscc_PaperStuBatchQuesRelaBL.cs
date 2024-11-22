
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PaperStuBatchQuesRelaBL
 表名:cc_PaperStuBatchQuesRela(01120240)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clscc_PaperStuBatchQuesRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PaperStuBatchQuesRelaEN GetObj(this K_IdPaperStuBatchQuesRela_cc_PaperStuBatchQuesRela myKey)
{
clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.GetObjByIdPaperStuBatchQuesRela(myKey.Value);
return objcc_PaperStuBatchQuesRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_PaperStuBatchQuesRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],学生试卷批次流水号 = [{1}]的数据已经存在!(in clscc_PaperStuBatchQuesRelaBL.AddNewRecord)", objcc_PaperStuBatchQuesRelaEN.QuestionId,objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch);
throw new Exception(strMsg);
}
try
{
bool bolResult = clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.AddNewRecordBySQL2(objcc_PaperStuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objcc_PaperStuBatchQuesRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_PaperStuBatchQuesRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(题目Id(QuestionId)=[{0}],学生试卷批次流水号(IdPaperStuBatch)=[{1}])已经存在,不能重复!", objcc_PaperStuBatchQuesRelaEN.QuestionId, objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objcc_PaperStuBatchQuesRelaEN.AddNewRecord();
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_PaperStuBatchQuesRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],学生试卷批次流水号 = [{1}]的数据已经存在!(in clscc_PaperStuBatchQuesRelaBL.AddNewRecordWithReturnKey)", objcc_PaperStuBatchQuesRelaEN.QuestionId,objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch);
throw new Exception(strMsg);
}
try
{
string strKey = clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.AddNewRecordBySQL2WithReturnKey(objcc_PaperStuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIdPaperStuBatchQuesRela(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, long lngIdPaperStuBatchQuesRela, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = lngIdPaperStuBatchQuesRela; //学生批次题目关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIdPaperStuBatch(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strIdPaperStuBatch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPaperStuBatch, concc_PaperStuBatchQuesRela.IdPaperStuBatch);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPaperStuBatch, 10, concc_PaperStuBatchQuesRela.IdPaperStuBatch);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPaperStuBatch, 10, concc_PaperStuBatchQuesRela.IdPaperStuBatch);
}
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = strIdPaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IdPaperStuBatch) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IdPaperStuBatch, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IdPaperStuBatch] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetQuestionId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, long? lngQuestionId, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.QuestionId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.QuestionId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.QuestionId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetQuestionIndex4Batch(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, int? intQuestionIndex4Batch, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = intQuestionIndex4Batch; //题序号4批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.QuestionIndex4Batch) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.QuestionIndex4Batch, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetScores(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, double? dblScores, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.Scores) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.Scores, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Scores] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetScore(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, double? dblScore, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.Score) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.Score, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Score] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetStuAnswerText(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strStuAnswerText, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.StuAnswerText) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.StuAnswerText, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.StuAnswerText] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerDate(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, concc_PaperStuBatchQuesRela.AnswerDate);
}
objcc_PaperStuBatchQuesRelaEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerDate) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerDate, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerDate] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerIP(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerIP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, concc_PaperStuBatchQuesRela.AnswerIP);
}
objcc_PaperStuBatchQuesRelaEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerIP) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerIP, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerIP] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerModeId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, concc_PaperStuBatchQuesRela.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, concc_PaperStuBatchQuesRela.AnswerModeId);
}
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerModeId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerModeId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerModeId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerMultiOptions(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, concc_PaperStuBatchQuesRela.AnswerMultiOptions);
}
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerMultiOptions) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerMultiOptions, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerMultiOptions] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerOptionId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, concc_PaperStuBatchQuesRela.AnswerOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, concc_PaperStuBatchQuesRela.AnswerOptionId);
}
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerOptionId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerOptionId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerOptionId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerTime(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, concc_PaperStuBatchQuesRela.AnswerTime);
}
objcc_PaperStuBatchQuesRelaEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerTime) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerTime, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerTime] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetApplySendBackDate(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strApplySendBackDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, concc_PaperStuBatchQuesRela.ApplySendBackDate);
}
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = strApplySendBackDate; //申请退回日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.ApplySendBackDate) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.ApplySendBackDate, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.ApplySendBackDate] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetComment(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strComment, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.Comment) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.Comment, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Comment] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsAccessKnowledge(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsAccessKnowledge) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsAccessKnowledge, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsAccessKnowledge] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsApplySendBack(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsApplySendBack, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = bolIsApplySendBack; //是否申请退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsApplySendBack) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsApplySendBack, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsApplySendBack] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsInErrorQuestion(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsInErrorQuestion) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsInErrorQuestion, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsInErrorQuestion] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsLook(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsLook, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsLook) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsLook, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsLook] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsMarking(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsMarking, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsMarking) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsMarking, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsMarking] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsNotProcessTimeout(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsNotProcessTimeout) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsNotProcessTimeout, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsNotProcessTimeout] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsPublish(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsPublish, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsPublish) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsPublish, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsPublish] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsRight(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsRight, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsRight) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsRight, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsRight] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsSave(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsSave, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsSave) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsSave, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsSave] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsSendBack(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsSendBack, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsSendBack) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsSendBack, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsSendBack] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsSubmit(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsSubmit) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsSubmit, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsSubmit] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetMarkDate(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strMarkDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkDate, 14, concc_PaperStuBatchQuesRela.MarkDate);
}
objcc_PaperStuBatchQuesRelaEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.MarkDate) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.MarkDate, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.MarkDate] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetMarkerId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, concc_PaperStuBatchQuesRela.MarkerId);
}
objcc_PaperStuBatchQuesRelaEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.MarkerId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.MarkerId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.MarkerId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetOperateTime(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strOperateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperateTime, 14, concc_PaperStuBatchQuesRela.OperateTime);
}
objcc_PaperStuBatchQuesRelaEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.OperateTime) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.OperateTime, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.OperateTime] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetRealFinishDate(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strRealFinishDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, concc_PaperStuBatchQuesRela.RealFinishDate);
}
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.RealFinishDate) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.RealFinishDate, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.RealFinishDate] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetWorkTypeId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strWorkTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, concc_PaperStuBatchQuesRela.WorkTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, concc_PaperStuBatchQuesRela.WorkTypeId);
}
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.WorkTypeId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.WorkTypeId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.WorkTypeId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetSchoolYear(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, concc_PaperStuBatchQuesRela.SchoolYear);
}
objcc_PaperStuBatchQuesRelaEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.SchoolYear) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.SchoolYear, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.SchoolYear] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetSchoolTerm(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, concc_PaperStuBatchQuesRela.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, concc_PaperStuBatchQuesRela.SchoolTerm);
}
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.SchoolTerm) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.SchoolTerm, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.SchoolTerm] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetErrMsg(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 200, concc_PaperStuBatchQuesRela.ErrMsg);
}
objcc_PaperStuBatchQuesRelaEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.ErrMsg) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.ErrMsg, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.ErrMsg] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetCourseId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_PaperStuBatchQuesRela.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_PaperStuBatchQuesRela.CourseId);
}
objcc_PaperStuBatchQuesRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.CourseId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.CourseId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.CourseId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetUpdDate(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_PaperStuBatchQuesRela.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_PaperStuBatchQuesRela.UpdDate);
}
objcc_PaperStuBatchQuesRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.UpdDate) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.UpdDate, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.UpdDate] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetUpdUserId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_PaperStuBatchQuesRela.UpdUserId);
}
objcc_PaperStuBatchQuesRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.UpdUserId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.UpdUserId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.UpdUserId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetMemo(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_PaperStuBatchQuesRela.Memo);
}
objcc_PaperStuBatchQuesRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.Memo) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.Memo, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Memo] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_PaperStuBatchQuesRelaEN.CheckPropertyNew();
clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaCond = new clscc_PaperStuBatchQuesRelaEN();
string strCondition = objcc_PaperStuBatchQuesRelaCond
.SetIdPaperStuBatchQuesRela(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, "<>")
.SetQuestionId(objcc_PaperStuBatchQuesRelaEN.QuestionId, "=")
.SetIdPaperStuBatch(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch, "=")
.GetCombineCondition();
objcc_PaperStuBatchQuesRelaEN._IsCheckProperty = true;
bool bolIsExist = clscc_PaperStuBatchQuesRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionID_Id_PaperStuBatch)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_PaperStuBatchQuesRelaEN.Update();
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
 /// <param name = "objcc_PaperStuBatchQuesRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaCond = new clscc_PaperStuBatchQuesRelaEN();
string strCondition = objcc_PaperStuBatchQuesRelaCond
.SetQuestionId(objcc_PaperStuBatchQuesRela.QuestionId, "=")
.SetIdPaperStuBatch(objcc_PaperStuBatchQuesRela.IdPaperStuBatch, "=")
.GetCombineCondition();
objcc_PaperStuBatchQuesRela._IsCheckProperty = true;
bool bolIsExist = clscc_PaperStuBatchQuesRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela = clscc_PaperStuBatchQuesRelaBL.GetFirstID_S(strCondition);
objcc_PaperStuBatchQuesRela.UpdateWithCondition(strCondition);
}
else
{
objcc_PaperStuBatchQuesRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.UpdateBySql2(objcc_PaperStuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.UpdateBySql2(objcc_PaperStuBatchQuesRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strWhereCond)
{
try
{
bool bolResult = clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.UpdateBySqlWithCondition(objcc_PaperStuBatchQuesRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.UpdateBySqlWithConditionTransaction(objcc_PaperStuBatchQuesRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "lngIdPaperStuBatchQuesRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
try
{
int intRecNum = clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.DelRecord(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaENS">源对象</param>
 /// <param name = "objcc_PaperStuBatchQuesRelaENT">目标对象</param>
 public static void CopyTo(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENS, clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENT)
{
try
{
objcc_PaperStuBatchQuesRelaENT.IdPaperStuBatchQuesRela = objcc_PaperStuBatchQuesRelaENS.IdPaperStuBatchQuesRela; //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaENT.IdPaperStuBatch = objcc_PaperStuBatchQuesRelaENS.IdPaperStuBatch; //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaENT.QuestionId = objcc_PaperStuBatchQuesRelaENS.QuestionId; //题目Id
objcc_PaperStuBatchQuesRelaENT.QuestionIndex4Batch = objcc_PaperStuBatchQuesRelaENS.QuestionIndex4Batch; //题序号4批次
objcc_PaperStuBatchQuesRelaENT.Scores = objcc_PaperStuBatchQuesRelaENS.Scores; //分值
objcc_PaperStuBatchQuesRelaENT.Score = objcc_PaperStuBatchQuesRelaENS.Score; //得分
objcc_PaperStuBatchQuesRelaENT.StuAnswerText = objcc_PaperStuBatchQuesRelaENS.StuAnswerText; //学生回答文本
objcc_PaperStuBatchQuesRelaENT.AnswerDate = objcc_PaperStuBatchQuesRelaENS.AnswerDate; //回答日期
objcc_PaperStuBatchQuesRelaENT.AnswerIP = objcc_PaperStuBatchQuesRelaENS.AnswerIP; //回答IP
objcc_PaperStuBatchQuesRelaENT.AnswerModeId = objcc_PaperStuBatchQuesRelaENS.AnswerModeId; //答案模式Id
objcc_PaperStuBatchQuesRelaENT.AnswerMultiOptions = objcc_PaperStuBatchQuesRelaENS.AnswerMultiOptions; //多选项答案
objcc_PaperStuBatchQuesRelaENT.AnswerOptionId = objcc_PaperStuBatchQuesRelaENS.AnswerOptionId; //回答选项Id
objcc_PaperStuBatchQuesRelaENT.AnswerTime = objcc_PaperStuBatchQuesRelaENS.AnswerTime; //回答时间
objcc_PaperStuBatchQuesRelaENT.ApplySendBackDate = objcc_PaperStuBatchQuesRelaENS.ApplySendBackDate; //申请退回日期
objcc_PaperStuBatchQuesRelaENT.Comment = objcc_PaperStuBatchQuesRelaENS.Comment; //批注
objcc_PaperStuBatchQuesRelaENT.IsAccessKnowledge = objcc_PaperStuBatchQuesRelaENS.IsAccessKnowledge; //是否处理知识点
objcc_PaperStuBatchQuesRelaENT.IsApplySendBack = objcc_PaperStuBatchQuesRelaENS.IsApplySendBack; //是否申请退回
objcc_PaperStuBatchQuesRelaENT.IsInErrorQuestion = objcc_PaperStuBatchQuesRelaENS.IsInErrorQuestion; //是否进入错题
objcc_PaperStuBatchQuesRelaENT.IsLook = objcc_PaperStuBatchQuesRelaENS.IsLook; //是否查看
objcc_PaperStuBatchQuesRelaENT.IsMarking = objcc_PaperStuBatchQuesRelaENS.IsMarking; //是否批阅
objcc_PaperStuBatchQuesRelaENT.IsNotProcessTimeout = objcc_PaperStuBatchQuesRelaENS.IsNotProcessTimeout; //是否不处理超时
objcc_PaperStuBatchQuesRelaENT.IsPublish = objcc_PaperStuBatchQuesRelaENS.IsPublish; //是否发布
objcc_PaperStuBatchQuesRelaENT.IsRight = objcc_PaperStuBatchQuesRelaENS.IsRight; //是否正确
objcc_PaperStuBatchQuesRelaENT.IsSave = objcc_PaperStuBatchQuesRelaENS.IsSave; //是否保存
objcc_PaperStuBatchQuesRelaENT.IsSendBack = objcc_PaperStuBatchQuesRelaENS.IsSendBack; //是否退回
objcc_PaperStuBatchQuesRelaENT.IsSubmit = objcc_PaperStuBatchQuesRelaENS.IsSubmit; //是否提交
objcc_PaperStuBatchQuesRelaENT.MarkDate = objcc_PaperStuBatchQuesRelaENS.MarkDate; //打分日期
objcc_PaperStuBatchQuesRelaENT.MarkerId = objcc_PaperStuBatchQuesRelaENS.MarkerId; //打分者
objcc_PaperStuBatchQuesRelaENT.OperateTime = objcc_PaperStuBatchQuesRelaENS.OperateTime; //操作时间
objcc_PaperStuBatchQuesRelaENT.RealFinishDate = objcc_PaperStuBatchQuesRelaENS.RealFinishDate; //实际完成日期
objcc_PaperStuBatchQuesRelaENT.WorkTypeId = objcc_PaperStuBatchQuesRelaENS.WorkTypeId; //作业类型Id
objcc_PaperStuBatchQuesRelaENT.SchoolYear = objcc_PaperStuBatchQuesRelaENS.SchoolYear; //学年
objcc_PaperStuBatchQuesRelaENT.SchoolTerm = objcc_PaperStuBatchQuesRelaENS.SchoolTerm; //学期
objcc_PaperStuBatchQuesRelaENT.ErrMsg = objcc_PaperStuBatchQuesRelaENS.ErrMsg; //错误信息
objcc_PaperStuBatchQuesRelaENT.CourseId = objcc_PaperStuBatchQuesRelaENS.CourseId; //课程Id
objcc_PaperStuBatchQuesRelaENT.UpdDate = objcc_PaperStuBatchQuesRelaENS.UpdDate; //修改日期
objcc_PaperStuBatchQuesRelaENT.UpdUserId = objcc_PaperStuBatchQuesRelaENS.UpdUserId; //修改用户Id
objcc_PaperStuBatchQuesRelaENT.Memo = objcc_PaperStuBatchQuesRelaENS.Memo; //备注
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
 /// <param name = "objcc_PaperStuBatchQuesRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_PaperStuBatchQuesRelaEN:objcc_PaperStuBatchQuesRelaENT</returns>
 public static clscc_PaperStuBatchQuesRelaEN CopyTo(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENS)
{
try
{
 clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENT = new clscc_PaperStuBatchQuesRelaEN()
{
IdPaperStuBatchQuesRela = objcc_PaperStuBatchQuesRelaENS.IdPaperStuBatchQuesRela, //学生批次题目关系流水号
IdPaperStuBatch = objcc_PaperStuBatchQuesRelaENS.IdPaperStuBatch, //学生试卷批次流水号
QuestionId = objcc_PaperStuBatchQuesRelaENS.QuestionId, //题目Id
QuestionIndex4Batch = objcc_PaperStuBatchQuesRelaENS.QuestionIndex4Batch, //题序号4批次
Scores = objcc_PaperStuBatchQuesRelaENS.Scores, //分值
Score = objcc_PaperStuBatchQuesRelaENS.Score, //得分
StuAnswerText = objcc_PaperStuBatchQuesRelaENS.StuAnswerText, //学生回答文本
AnswerDate = objcc_PaperStuBatchQuesRelaENS.AnswerDate, //回答日期
AnswerIP = objcc_PaperStuBatchQuesRelaENS.AnswerIP, //回答IP
AnswerModeId = objcc_PaperStuBatchQuesRelaENS.AnswerModeId, //答案模式Id
AnswerMultiOptions = objcc_PaperStuBatchQuesRelaENS.AnswerMultiOptions, //多选项答案
AnswerOptionId = objcc_PaperStuBatchQuesRelaENS.AnswerOptionId, //回答选项Id
AnswerTime = objcc_PaperStuBatchQuesRelaENS.AnswerTime, //回答时间
ApplySendBackDate = objcc_PaperStuBatchQuesRelaENS.ApplySendBackDate, //申请退回日期
Comment = objcc_PaperStuBatchQuesRelaENS.Comment, //批注
IsAccessKnowledge = objcc_PaperStuBatchQuesRelaENS.IsAccessKnowledge, //是否处理知识点
IsApplySendBack = objcc_PaperStuBatchQuesRelaENS.IsApplySendBack, //是否申请退回
IsInErrorQuestion = objcc_PaperStuBatchQuesRelaENS.IsInErrorQuestion, //是否进入错题
IsLook = objcc_PaperStuBatchQuesRelaENS.IsLook, //是否查看
IsMarking = objcc_PaperStuBatchQuesRelaENS.IsMarking, //是否批阅
IsNotProcessTimeout = objcc_PaperStuBatchQuesRelaENS.IsNotProcessTimeout, //是否不处理超时
IsPublish = objcc_PaperStuBatchQuesRelaENS.IsPublish, //是否发布
IsRight = objcc_PaperStuBatchQuesRelaENS.IsRight, //是否正确
IsSave = objcc_PaperStuBatchQuesRelaENS.IsSave, //是否保存
IsSendBack = objcc_PaperStuBatchQuesRelaENS.IsSendBack, //是否退回
IsSubmit = objcc_PaperStuBatchQuesRelaENS.IsSubmit, //是否提交
MarkDate = objcc_PaperStuBatchQuesRelaENS.MarkDate, //打分日期
MarkerId = objcc_PaperStuBatchQuesRelaENS.MarkerId, //打分者
OperateTime = objcc_PaperStuBatchQuesRelaENS.OperateTime, //操作时间
RealFinishDate = objcc_PaperStuBatchQuesRelaENS.RealFinishDate, //实际完成日期
WorkTypeId = objcc_PaperStuBatchQuesRelaENS.WorkTypeId, //作业类型Id
SchoolYear = objcc_PaperStuBatchQuesRelaENS.SchoolYear, //学年
SchoolTerm = objcc_PaperStuBatchQuesRelaENS.SchoolTerm, //学期
ErrMsg = objcc_PaperStuBatchQuesRelaENS.ErrMsg, //错误信息
CourseId = objcc_PaperStuBatchQuesRelaENS.CourseId, //课程Id
UpdDate = objcc_PaperStuBatchQuesRelaENS.UpdDate, //修改日期
UpdUserId = objcc_PaperStuBatchQuesRelaENS.UpdUserId, //修改用户Id
Memo = objcc_PaperStuBatchQuesRelaENS.Memo, //备注
};
 return objcc_PaperStuBatchQuesRelaENT;
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
public static void CheckPropertyNew(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
 clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.CheckPropertyNew(objcc_PaperStuBatchQuesRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
 clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.CheckProperty4Condition(objcc_PaperStuBatchQuesRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela) == true)
{
string strComparisonOpIdPaperStuBatchQuesRela = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaCond.IdPaperStuBatchQuesRela, strComparisonOpIdPaperStuBatchQuesRela);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IdPaperStuBatch) == true)
{
string strComparisonOpIdPaperStuBatch = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IdPaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.IdPaperStuBatch, objcc_PaperStuBatchQuesRelaCond.IdPaperStuBatch, strComparisonOpIdPaperStuBatch);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.QuestionId) == true)
{
string strComparisonOpQuestionId = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela.QuestionId, objcc_PaperStuBatchQuesRelaCond.QuestionId, strComparisonOpQuestionId);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.QuestionIndex4Batch) == true)
{
string strComparisonOpQuestionIndex4Batch = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.QuestionIndex4Batch];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela.QuestionIndex4Batch, objcc_PaperStuBatchQuesRelaCond.QuestionIndex4Batch, strComparisonOpQuestionIndex4Batch);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.Scores) == true)
{
string strComparisonOpScores = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela.Scores, objcc_PaperStuBatchQuesRelaCond.Scores, strComparisonOpScores);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.Score) == true)
{
string strComparisonOpScore = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela.Score, objcc_PaperStuBatchQuesRelaCond.Score, strComparisonOpScore);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerDate) == true)
{
string strComparisonOpAnswerDate = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerDate, objcc_PaperStuBatchQuesRelaCond.AnswerDate, strComparisonOpAnswerDate);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerIP) == true)
{
string strComparisonOpAnswerIP = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerIP, objcc_PaperStuBatchQuesRelaCond.AnswerIP, strComparisonOpAnswerIP);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerModeId, objcc_PaperStuBatchQuesRelaCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerMultiOptions) == true)
{
string strComparisonOpAnswerMultiOptions = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerMultiOptions, objcc_PaperStuBatchQuesRelaCond.AnswerMultiOptions, strComparisonOpAnswerMultiOptions);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerOptionId) == true)
{
string strComparisonOpAnswerOptionId = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerOptionId, objcc_PaperStuBatchQuesRelaCond.AnswerOptionId, strComparisonOpAnswerOptionId);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerTime) == true)
{
string strComparisonOpAnswerTime = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerTime, objcc_PaperStuBatchQuesRelaCond.AnswerTime, strComparisonOpAnswerTime);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.ApplySendBackDate) == true)
{
string strComparisonOpApplySendBackDate = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.ApplySendBackDate, objcc_PaperStuBatchQuesRelaCond.ApplySendBackDate, strComparisonOpApplySendBackDate);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IsAccessKnowledge) == true)
{
if (objcc_PaperStuBatchQuesRelaCond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsAccessKnowledge);
}
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IsApplySendBack) == true)
{
if (objcc_PaperStuBatchQuesRelaCond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsApplySendBack);
}
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IsInErrorQuestion) == true)
{
if (objcc_PaperStuBatchQuesRelaCond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsInErrorQuestion);
}
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IsLook) == true)
{
if (objcc_PaperStuBatchQuesRelaCond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsLook);
}
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IsMarking) == true)
{
if (objcc_PaperStuBatchQuesRelaCond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsMarking);
}
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IsNotProcessTimeout) == true)
{
if (objcc_PaperStuBatchQuesRelaCond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsNotProcessTimeout);
}
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IsPublish) == true)
{
if (objcc_PaperStuBatchQuesRelaCond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsPublish);
}
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IsRight) == true)
{
if (objcc_PaperStuBatchQuesRelaCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsRight);
}
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IsSave) == true)
{
if (objcc_PaperStuBatchQuesRelaCond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsSave);
}
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IsSendBack) == true)
{
if (objcc_PaperStuBatchQuesRelaCond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsSendBack);
}
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.IsSubmit) == true)
{
if (objcc_PaperStuBatchQuesRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsSubmit);
}
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.MarkDate) == true)
{
string strComparisonOpMarkDate = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.MarkDate, objcc_PaperStuBatchQuesRelaCond.MarkDate, strComparisonOpMarkDate);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.MarkerId) == true)
{
string strComparisonOpMarkerId = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.MarkerId, objcc_PaperStuBatchQuesRelaCond.MarkerId, strComparisonOpMarkerId);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.OperateTime) == true)
{
string strComparisonOpOperateTime = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.OperateTime, objcc_PaperStuBatchQuesRelaCond.OperateTime, strComparisonOpOperateTime);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.RealFinishDate) == true)
{
string strComparisonOpRealFinishDate = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.RealFinishDate, objcc_PaperStuBatchQuesRelaCond.RealFinishDate, strComparisonOpRealFinishDate);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.WorkTypeId) == true)
{
string strComparisonOpWorkTypeId = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.WorkTypeId, objcc_PaperStuBatchQuesRelaCond.WorkTypeId, strComparisonOpWorkTypeId);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.SchoolYear, objcc_PaperStuBatchQuesRelaCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.SchoolTerm, objcc_PaperStuBatchQuesRelaCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.ErrMsg) == true)
{
string strComparisonOpErrMsg = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.ErrMsg, objcc_PaperStuBatchQuesRelaCond.ErrMsg, strComparisonOpErrMsg);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.CourseId) == true)
{
string strComparisonOpCourseId = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.CourseId, objcc_PaperStuBatchQuesRelaCond.CourseId, strComparisonOpCourseId);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.UpdDate, objcc_PaperStuBatchQuesRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.UpdUserId, objcc_PaperStuBatchQuesRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(concc_PaperStuBatchQuesRela.Memo) == true)
{
string strComparisonOpMemo = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.Memo, objcc_PaperStuBatchQuesRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_PaperStuBatchQuesRela(学生批次题目关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionID_Id_PaperStuBatch
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_PaperStuBatchQuesRelaEN == null) return true;
if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_PaperStuBatchQuesRelaEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null", objcc_PaperStuBatchQuesRelaEN.QuestionId);
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_PaperStuBatchQuesRelaEN.QuestionId);
}
 sbCondition.AppendFormat(" and IdPaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch);
if (clscc_PaperStuBatchQuesRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdPaperStuBatchQuesRela !=  {0}", objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_PaperStuBatchQuesRelaEN.QuestionId);
 sbCondition.AppendFormat(" and IdPaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch);
if (clscc_PaperStuBatchQuesRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_PaperStuBatchQuesRela(学生批次题目关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionID_Id_PaperStuBatch
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_PaperStuBatchQuesRelaEN == null) return "";
if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_PaperStuBatchQuesRelaEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null", objcc_PaperStuBatchQuesRelaEN.QuestionId);
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_PaperStuBatchQuesRelaEN.QuestionId);
}
 sbCondition.AppendFormat(" and IdPaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdPaperStuBatchQuesRela !=  {0}", objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_PaperStuBatchQuesRelaEN.QuestionId);
 sbCondition.AppendFormat(" and IdPaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_PaperStuBatchQuesRela
{
public virtual bool UpdRelaTabDate(long lngIdPaperStuBatchQuesRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学生批次题目关系(cc_PaperStuBatchQuesRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_PaperStuBatchQuesRelaBL
{
public static RelatedActions_cc_PaperStuBatchQuesRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_PaperStuBatchQuesRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_PaperStuBatchQuesRelaDA cc_PaperStuBatchQuesRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_PaperStuBatchQuesRelaDA();
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
 public clscc_PaperStuBatchQuesRelaBL()
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
if (string.IsNullOrEmpty(clscc_PaperStuBatchQuesRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_PaperStuBatchQuesRelaEN._ConnectString);
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
public static DataTable GetDataTable_cc_PaperStuBatchQuesRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_PaperStuBatchQuesRelaDA.GetDataTable_cc_PaperStuBatchQuesRela(strWhereCond);
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
objDT = cc_PaperStuBatchQuesRelaDA.GetDataTable(strWhereCond);
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
objDT = cc_PaperStuBatchQuesRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_PaperStuBatchQuesRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_PaperStuBatchQuesRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_PaperStuBatchQuesRelaDA.GetDataTable_Top(objTopPara);
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
objDT = cc_PaperStuBatchQuesRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_PaperStuBatchQuesRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_PaperStuBatchQuesRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPaperStuBatchQuesRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstByIdPaperStuBatchQuesRelaLst(List<long> arrIdPaperStuBatchQuesRelaLst)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPaperStuBatchQuesRelaLst);
 string strWhereCond = string.Format("IdPaperStuBatchQuesRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = Int32.Parse(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPaperStuBatchQuesRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_PaperStuBatchQuesRelaEN> GetObjLstByIdPaperStuBatchQuesRelaLstCache(List<long> arrIdPaperStuBatchQuesRelaLst)
{
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRelaEN._CurrTabName);
List<clscc_PaperStuBatchQuesRelaEN> arrcc_PaperStuBatchQuesRelaObjLstCache = GetObjLstCache();
IEnumerable <clscc_PaperStuBatchQuesRelaEN> arrcc_PaperStuBatchQuesRelaObjLst_Sel =
arrcc_PaperStuBatchQuesRelaObjLstCache
.Where(x => arrIdPaperStuBatchQuesRelaLst.Contains(x.IdPaperStuBatchQuesRela));
return arrcc_PaperStuBatchQuesRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLst(string strWhereCond)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = Int32.Parse(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = Int32.Parse(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_PaperStuBatchQuesRelaEN> GetSubObjLstCache(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaCond)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_PaperStuBatchQuesRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_PaperStuBatchQuesRela.AttributeName)
{
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(strFldName) == false) continue;
if (objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PaperStuBatchQuesRelaCond[strFldName].ToString());
}
else
{
if (objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PaperStuBatchQuesRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_PaperStuBatchQuesRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_PaperStuBatchQuesRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_PaperStuBatchQuesRelaCond[strFldName]));
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = Int32.Parse(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = Int32.Parse(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
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
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PaperStuBatchQuesRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
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
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = Int32.Parse(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = Int32.Parse(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = Int32.Parse(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = Int32.Parse(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = new List<clscc_PaperStuBatchQuesRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = new clscc_PaperStuBatchQuesRelaEN();
try
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = Int32.Parse(objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaEN.QuestionId = objRow[concc_PaperStuBatchQuesRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objcc_PaperStuBatchQuesRelaEN.Scores = objRow[concc_PaperStuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Scores].ToString().Trim()); //分值
objcc_PaperStuBatchQuesRelaEN.Score = objRow[concc_PaperStuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela.Score].ToString().Trim()); //得分
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objRow[concc_PaperStuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objRow[concc_PaperStuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objRow[concc_PaperStuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objRow[concc_PaperStuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objRow[concc_PaperStuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objRow[concc_PaperStuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_PaperStuBatchQuesRelaEN.Comment = objRow[concc_PaperStuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Comment].ToString().Trim(); //批注
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_PaperStuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objcc_PaperStuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_PaperStuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objcc_PaperStuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objcc_PaperStuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objcc_PaperStuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objcc_PaperStuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_PaperStuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objcc_PaperStuBatchQuesRelaEN.MarkDate = objRow[concc_PaperStuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objcc_PaperStuBatchQuesRelaEN.MarkerId = objRow[concc_PaperStuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objcc_PaperStuBatchQuesRelaEN.OperateTime = objRow[concc_PaperStuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objRow[concc_PaperStuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objRow[concc_PaperStuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objRow[concc_PaperStuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objcc_PaperStuBatchQuesRelaEN.CourseId = objRow[concc_PaperStuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objcc_PaperStuBatchQuesRelaEN.UpdDate = objRow[concc_PaperStuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRelaEN.Memo = objRow[concc_PaperStuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_PaperStuBatchQuesRela(ref clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
bool bolResult = cc_PaperStuBatchQuesRelaDA.Getcc_PaperStuBatchQuesRela(ref objcc_PaperStuBatchQuesRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PaperStuBatchQuesRelaEN GetObjByIdPaperStuBatchQuesRela(long lngIdPaperStuBatchQuesRela)
{
clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = cc_PaperStuBatchQuesRelaDA.GetObjByIdPaperStuBatchQuesRela(lngIdPaperStuBatchQuesRela);
return objcc_PaperStuBatchQuesRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_PaperStuBatchQuesRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = cc_PaperStuBatchQuesRelaDA.GetFirstObj(strWhereCond);
 return objcc_PaperStuBatchQuesRelaEN;
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
public static clscc_PaperStuBatchQuesRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = cc_PaperStuBatchQuesRelaDA.GetObjByDataRow(objRow);
 return objcc_PaperStuBatchQuesRelaEN;
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
public static clscc_PaperStuBatchQuesRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = cc_PaperStuBatchQuesRelaDA.GetObjByDataRow(objRow);
 return objcc_PaperStuBatchQuesRelaEN;
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
 /// <param name = "lngIdPaperStuBatchQuesRela">所给的关键字</param>
 /// <param name = "lstcc_PaperStuBatchQuesRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_PaperStuBatchQuesRelaEN GetObjByIdPaperStuBatchQuesRelaFromList(long lngIdPaperStuBatchQuesRela, List<clscc_PaperStuBatchQuesRelaEN> lstcc_PaperStuBatchQuesRelaObjLst)
{
foreach (clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN in lstcc_PaperStuBatchQuesRelaObjLst)
{
if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela == lngIdPaperStuBatchQuesRela)
{
return objcc_PaperStuBatchQuesRelaEN;
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
 long lngIdPaperStuBatchQuesRela;
 try
 {
 lngIdPaperStuBatchQuesRela = new clscc_PaperStuBatchQuesRelaDA().GetFirstID(strWhereCond);
 return lngIdPaperStuBatchQuesRela;
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
 arrList = cc_PaperStuBatchQuesRelaDA.GetID(strWhereCond);
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
bool bolIsExist = cc_PaperStuBatchQuesRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdPaperStuBatchQuesRela)
{
//检测记录是否存在
bool bolIsExist = cc_PaperStuBatchQuesRelaDA.IsExist(lngIdPaperStuBatchQuesRela);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdPaperStuBatchQuesRela">学生批次题目关系流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdPaperStuBatchQuesRela, string strOpUser)
{
clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = clscc_PaperStuBatchQuesRelaBL.GetObjByIdPaperStuBatchQuesRela(lngIdPaperStuBatchQuesRela);
objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_PaperStuBatchQuesRelaEN.UpdUserId = strOpUser;
return clscc_PaperStuBatchQuesRelaBL.UpdateBySql2(objcc_PaperStuBatchQuesRelaEN);
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
 bolIsExist = clscc_PaperStuBatchQuesRelaDA.IsExistTable();
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
 bolIsExist = cc_PaperStuBatchQuesRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_PaperStuBatchQuesRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],学生试卷批次流水号 = [{1}]的数据已经存在!(in clscc_PaperStuBatchQuesRelaBL.AddNewRecordBySql2)", objcc_PaperStuBatchQuesRelaEN.QuestionId,objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch);
throw new Exception(strMsg);
}
try
{
bool bolResult = cc_PaperStuBatchQuesRelaDA.AddNewRecordBySQL2(objcc_PaperStuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_PaperStuBatchQuesRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],学生试卷批次流水号 = [{1}]的数据已经存在!(in clscc_PaperStuBatchQuesRelaBL.AddNewRecordBySql2WithReturnKey)", objcc_PaperStuBatchQuesRelaEN.QuestionId,objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch);
throw new Exception(strMsg);
}
try
{
string strKey = cc_PaperStuBatchQuesRelaDA.AddNewRecordBySQL2WithReturnKey(objcc_PaperStuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
try
{
bool bolResult = cc_PaperStuBatchQuesRelaDA.Update(objcc_PaperStuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
 if (objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_PaperStuBatchQuesRelaDA.UpdateBySql2(objcc_PaperStuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "lngIdPaperStuBatchQuesRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdPaperStuBatchQuesRela)
{
try
{
 clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = clscc_PaperStuBatchQuesRelaBL.GetObjByIdPaperStuBatchQuesRela(lngIdPaperStuBatchQuesRela);

if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela, objcc_PaperStuBatchQuesRelaEN.UpdUserId);
}
if (objcc_PaperStuBatchQuesRelaEN != null)
{
int intRecNum = cc_PaperStuBatchQuesRelaDA.DelRecord(lngIdPaperStuBatchQuesRela);
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
/// <param name="lngIdPaperStuBatchQuesRela">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdPaperStuBatchQuesRela )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
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
//删除与表:[cc_PaperStuBatchQuesRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela,
//lngIdPaperStuBatchQuesRela);
//        clscc_PaperStuBatchQuesRelaBL.Delcc_PaperStuBatchQuesRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_PaperStuBatchQuesRelaBL.DelRecord(lngIdPaperStuBatchQuesRela, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_PaperStuBatchQuesRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdPaperStuBatchQuesRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdPaperStuBatchQuesRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdPaperStuBatchQuesRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(lngIdPaperStuBatchQuesRela, "UpdRelaTabDate");
}
bool bolResult = cc_PaperStuBatchQuesRelaDA.DelRecord(lngIdPaperStuBatchQuesRela,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdPaperStuBatchQuesRelaLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_PaperStuBatchQuesRelas(List<string> arrIdPaperStuBatchQuesRelaLst)
{
if (arrIdPaperStuBatchQuesRelaLst.Count == 0) return 0;
try
{
if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
foreach (var strIdPaperStuBatchQuesRela in arrIdPaperStuBatchQuesRelaLst)
{
long lngIdPaperStuBatchQuesRela = long.Parse(strIdPaperStuBatchQuesRela);
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(lngIdPaperStuBatchQuesRela, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_PaperStuBatchQuesRelaDA.Delcc_PaperStuBatchQuesRela(arrIdPaperStuBatchQuesRelaLst);
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
public static int Delcc_PaperStuBatchQuesRelasByCond(string strWhereCond)
{
try
{
if (clscc_PaperStuBatchQuesRelaBL.relatedActions != null)
{
List<string> arrIdPaperStuBatchQuesRela = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdPaperStuBatchQuesRela in arrIdPaperStuBatchQuesRela)
{
long lngIdPaperStuBatchQuesRela = long.Parse(strIdPaperStuBatchQuesRela);
clscc_PaperStuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(lngIdPaperStuBatchQuesRela, "UpdRelaTabDate");
}
}
int intRecNum = cc_PaperStuBatchQuesRelaDA.Delcc_PaperStuBatchQuesRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_PaperStuBatchQuesRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdPaperStuBatchQuesRela">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdPaperStuBatchQuesRela)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_PaperStuBatchQuesRelaDA.GetSpecSQLObj();
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
//删除与表:[cc_PaperStuBatchQuesRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_PaperStuBatchQuesRelaBL.DelRecord(lngIdPaperStuBatchQuesRela, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_PaperStuBatchQuesRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdPaperStuBatchQuesRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_PaperStuBatchQuesRelaENS">源对象</param>
 /// <param name = "objcc_PaperStuBatchQuesRelaENT">目标对象</param>
 public static void CopyTo(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENS, clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENT)
{
try
{
objcc_PaperStuBatchQuesRelaENT.IdPaperStuBatchQuesRela = objcc_PaperStuBatchQuesRelaENS.IdPaperStuBatchQuesRela; //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaENT.IdPaperStuBatch = objcc_PaperStuBatchQuesRelaENS.IdPaperStuBatch; //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaENT.QuestionId = objcc_PaperStuBatchQuesRelaENS.QuestionId; //题目Id
objcc_PaperStuBatchQuesRelaENT.QuestionIndex4Batch = objcc_PaperStuBatchQuesRelaENS.QuestionIndex4Batch; //题序号4批次
objcc_PaperStuBatchQuesRelaENT.Scores = objcc_PaperStuBatchQuesRelaENS.Scores; //分值
objcc_PaperStuBatchQuesRelaENT.Score = objcc_PaperStuBatchQuesRelaENS.Score; //得分
objcc_PaperStuBatchQuesRelaENT.StuAnswerText = objcc_PaperStuBatchQuesRelaENS.StuAnswerText; //学生回答文本
objcc_PaperStuBatchQuesRelaENT.AnswerDate = objcc_PaperStuBatchQuesRelaENS.AnswerDate; //回答日期
objcc_PaperStuBatchQuesRelaENT.AnswerIP = objcc_PaperStuBatchQuesRelaENS.AnswerIP; //回答IP
objcc_PaperStuBatchQuesRelaENT.AnswerModeId = objcc_PaperStuBatchQuesRelaENS.AnswerModeId; //答案模式Id
objcc_PaperStuBatchQuesRelaENT.AnswerMultiOptions = objcc_PaperStuBatchQuesRelaENS.AnswerMultiOptions; //多选项答案
objcc_PaperStuBatchQuesRelaENT.AnswerOptionId = objcc_PaperStuBatchQuesRelaENS.AnswerOptionId; //回答选项Id
objcc_PaperStuBatchQuesRelaENT.AnswerTime = objcc_PaperStuBatchQuesRelaENS.AnswerTime; //回答时间
objcc_PaperStuBatchQuesRelaENT.ApplySendBackDate = objcc_PaperStuBatchQuesRelaENS.ApplySendBackDate; //申请退回日期
objcc_PaperStuBatchQuesRelaENT.Comment = objcc_PaperStuBatchQuesRelaENS.Comment; //批注
objcc_PaperStuBatchQuesRelaENT.IsAccessKnowledge = objcc_PaperStuBatchQuesRelaENS.IsAccessKnowledge; //是否处理知识点
objcc_PaperStuBatchQuesRelaENT.IsApplySendBack = objcc_PaperStuBatchQuesRelaENS.IsApplySendBack; //是否申请退回
objcc_PaperStuBatchQuesRelaENT.IsInErrorQuestion = objcc_PaperStuBatchQuesRelaENS.IsInErrorQuestion; //是否进入错题
objcc_PaperStuBatchQuesRelaENT.IsLook = objcc_PaperStuBatchQuesRelaENS.IsLook; //是否查看
objcc_PaperStuBatchQuesRelaENT.IsMarking = objcc_PaperStuBatchQuesRelaENS.IsMarking; //是否批阅
objcc_PaperStuBatchQuesRelaENT.IsNotProcessTimeout = objcc_PaperStuBatchQuesRelaENS.IsNotProcessTimeout; //是否不处理超时
objcc_PaperStuBatchQuesRelaENT.IsPublish = objcc_PaperStuBatchQuesRelaENS.IsPublish; //是否发布
objcc_PaperStuBatchQuesRelaENT.IsRight = objcc_PaperStuBatchQuesRelaENS.IsRight; //是否正确
objcc_PaperStuBatchQuesRelaENT.IsSave = objcc_PaperStuBatchQuesRelaENS.IsSave; //是否保存
objcc_PaperStuBatchQuesRelaENT.IsSendBack = objcc_PaperStuBatchQuesRelaENS.IsSendBack; //是否退回
objcc_PaperStuBatchQuesRelaENT.IsSubmit = objcc_PaperStuBatchQuesRelaENS.IsSubmit; //是否提交
objcc_PaperStuBatchQuesRelaENT.MarkDate = objcc_PaperStuBatchQuesRelaENS.MarkDate; //打分日期
objcc_PaperStuBatchQuesRelaENT.MarkerId = objcc_PaperStuBatchQuesRelaENS.MarkerId; //打分者
objcc_PaperStuBatchQuesRelaENT.OperateTime = objcc_PaperStuBatchQuesRelaENS.OperateTime; //操作时间
objcc_PaperStuBatchQuesRelaENT.RealFinishDate = objcc_PaperStuBatchQuesRelaENS.RealFinishDate; //实际完成日期
objcc_PaperStuBatchQuesRelaENT.WorkTypeId = objcc_PaperStuBatchQuesRelaENS.WorkTypeId; //作业类型Id
objcc_PaperStuBatchQuesRelaENT.SchoolYear = objcc_PaperStuBatchQuesRelaENS.SchoolYear; //学年
objcc_PaperStuBatchQuesRelaENT.SchoolTerm = objcc_PaperStuBatchQuesRelaENS.SchoolTerm; //学期
objcc_PaperStuBatchQuesRelaENT.ErrMsg = objcc_PaperStuBatchQuesRelaENS.ErrMsg; //错误信息
objcc_PaperStuBatchQuesRelaENT.CourseId = objcc_PaperStuBatchQuesRelaENS.CourseId; //课程Id
objcc_PaperStuBatchQuesRelaENT.UpdDate = objcc_PaperStuBatchQuesRelaENS.UpdDate; //修改日期
objcc_PaperStuBatchQuesRelaENT.UpdUserId = objcc_PaperStuBatchQuesRelaENS.UpdUserId; //修改用户Id
objcc_PaperStuBatchQuesRelaENT.Memo = objcc_PaperStuBatchQuesRelaENS.Memo; //备注
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">源简化对象</param>
 public static void SetUpdFlag(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
try
{
objcc_PaperStuBatchQuesRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_PaperStuBatchQuesRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatchQuesRela; //学生批次题目关系流水号
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IdPaperStuBatch, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch = objcc_PaperStuBatchQuesRelaEN.IdPaperStuBatch; //学生试卷批次流水号
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.QuestionId = objcc_PaperStuBatchQuesRelaEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.QuestionIndex4Batch, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch; //题序号4批次
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.Scores, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.Scores = objcc_PaperStuBatchQuesRelaEN.Scores; //分值
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.Score = objcc_PaperStuBatchQuesRelaEN.Score; //得分
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.StuAnswerText, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = objcc_PaperStuBatchQuesRelaEN.StuAnswerText == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.StuAnswerText; //学生回答文本
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.AnswerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.AnswerDate = objcc_PaperStuBatchQuesRelaEN.AnswerDate == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.AnswerDate; //回答日期
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.AnswerIP, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.AnswerIP = objcc_PaperStuBatchQuesRelaEN.AnswerIP == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.AnswerIP; //回答IP
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = objcc_PaperStuBatchQuesRelaEN.AnswerModeId == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.AnswerMultiOptions, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions; //多选项答案
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.AnswerOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = objcc_PaperStuBatchQuesRelaEN.AnswerOptionId == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.AnswerOptionId; //回答选项Id
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.AnswerTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.AnswerTime = objcc_PaperStuBatchQuesRelaEN.AnswerTime == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.AnswerTime; //回答时间
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.ApplySendBackDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate; //申请退回日期
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.Comment, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.Comment = objcc_PaperStuBatchQuesRelaEN.Comment == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.Comment; //批注
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IsAccessKnowledge, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge; //是否处理知识点
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IsApplySendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = objcc_PaperStuBatchQuesRelaEN.IsApplySendBack; //是否申请退回
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IsInErrorQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion; //是否进入错题
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IsLook, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IsLook = objcc_PaperStuBatchQuesRelaEN.IsLook; //是否查看
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IsMarking, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IsMarking = objcc_PaperStuBatchQuesRelaEN.IsMarking; //是否批阅
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IsNotProcessTimeout, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout; //是否不处理超时
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IsPublish, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IsPublish = objcc_PaperStuBatchQuesRelaEN.IsPublish; //是否发布
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IsRight = objcc_PaperStuBatchQuesRelaEN.IsRight; //是否正确
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IsSave, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IsSave = objcc_PaperStuBatchQuesRelaEN.IsSave; //是否保存
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IsSendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IsSendBack = objcc_PaperStuBatchQuesRelaEN.IsSendBack; //是否退回
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.IsSubmit = objcc_PaperStuBatchQuesRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.MarkDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.MarkDate = objcc_PaperStuBatchQuesRelaEN.MarkDate == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.MarkDate; //打分日期
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.MarkerId = objcc_PaperStuBatchQuesRelaEN.MarkerId == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.MarkerId; //打分者
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.OperateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.OperateTime = objcc_PaperStuBatchQuesRelaEN.OperateTime == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.OperateTime; //操作时间
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.RealFinishDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = objcc_PaperStuBatchQuesRelaEN.RealFinishDate == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.RealFinishDate; //实际完成日期
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.WorkTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = objcc_PaperStuBatchQuesRelaEN.WorkTypeId == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.WorkTypeId; //作业类型Id
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.SchoolYear = objcc_PaperStuBatchQuesRelaEN.SchoolYear == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.SchoolYear; //学年
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = objcc_PaperStuBatchQuesRelaEN.SchoolTerm == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.ErrMsg = objcc_PaperStuBatchQuesRelaEN.ErrMsg == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.CourseId = objcc_PaperStuBatchQuesRelaEN.CourseId == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.UpdDate = objcc_PaperStuBatchQuesRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.UpdUserId = objcc_PaperStuBatchQuesRelaEN.UpdUserId == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRelaEN.Memo = objcc_PaperStuBatchQuesRelaEN.Memo == "[null]" ? null :  objcc_PaperStuBatchQuesRelaEN.Memo; //备注
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
try
{
if (objcc_PaperStuBatchQuesRelaEN.StuAnswerText == "[null]") objcc_PaperStuBatchQuesRelaEN.StuAnswerText = null; //学生回答文本
if (objcc_PaperStuBatchQuesRelaEN.AnswerDate == "[null]") objcc_PaperStuBatchQuesRelaEN.AnswerDate = null; //回答日期
if (objcc_PaperStuBatchQuesRelaEN.AnswerIP == "[null]") objcc_PaperStuBatchQuesRelaEN.AnswerIP = null; //回答IP
if (objcc_PaperStuBatchQuesRelaEN.AnswerModeId == "[null]") objcc_PaperStuBatchQuesRelaEN.AnswerModeId = null; //答案模式Id
if (objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions == "[null]") objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = null; //多选项答案
if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId == "[null]") objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = null; //回答选项Id
if (objcc_PaperStuBatchQuesRelaEN.AnswerTime == "[null]") objcc_PaperStuBatchQuesRelaEN.AnswerTime = null; //回答时间
if (objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate == "[null]") objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = null; //申请退回日期
if (objcc_PaperStuBatchQuesRelaEN.Comment == "[null]") objcc_PaperStuBatchQuesRelaEN.Comment = null; //批注
if (objcc_PaperStuBatchQuesRelaEN.MarkDate == "[null]") objcc_PaperStuBatchQuesRelaEN.MarkDate = null; //打分日期
if (objcc_PaperStuBatchQuesRelaEN.MarkerId == "[null]") objcc_PaperStuBatchQuesRelaEN.MarkerId = null; //打分者
if (objcc_PaperStuBatchQuesRelaEN.OperateTime == "[null]") objcc_PaperStuBatchQuesRelaEN.OperateTime = null; //操作时间
if (objcc_PaperStuBatchQuesRelaEN.RealFinishDate == "[null]") objcc_PaperStuBatchQuesRelaEN.RealFinishDate = null; //实际完成日期
if (objcc_PaperStuBatchQuesRelaEN.WorkTypeId == "[null]") objcc_PaperStuBatchQuesRelaEN.WorkTypeId = null; //作业类型Id
if (objcc_PaperStuBatchQuesRelaEN.SchoolYear == "[null]") objcc_PaperStuBatchQuesRelaEN.SchoolYear = null; //学年
if (objcc_PaperStuBatchQuesRelaEN.SchoolTerm == "[null]") objcc_PaperStuBatchQuesRelaEN.SchoolTerm = null; //学期
if (objcc_PaperStuBatchQuesRelaEN.ErrMsg == "[null]") objcc_PaperStuBatchQuesRelaEN.ErrMsg = null; //错误信息
if (objcc_PaperStuBatchQuesRelaEN.CourseId == "[null]") objcc_PaperStuBatchQuesRelaEN.CourseId = null; //课程Id
if (objcc_PaperStuBatchQuesRelaEN.UpdUserId == "[null]") objcc_PaperStuBatchQuesRelaEN.UpdUserId = null; //修改用户Id
if (objcc_PaperStuBatchQuesRelaEN.Memo == "[null]") objcc_PaperStuBatchQuesRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
 cc_PaperStuBatchQuesRelaDA.CheckPropertyNew(objcc_PaperStuBatchQuesRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
 cc_PaperStuBatchQuesRelaDA.CheckProperty4Condition(objcc_PaperStuBatchQuesRelaEN);
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
if (clscc_PaperStuBatchQuesRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperStuBatchQuesRelaBL没有刷新缓存机制(clscc_PaperStuBatchQuesRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPaperStuBatchQuesRela");
//if (arrcc_PaperStuBatchQuesRelaObjLstCache == null)
//{
//arrcc_PaperStuBatchQuesRelaObjLstCache = cc_PaperStuBatchQuesRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_PaperStuBatchQuesRelaEN GetObjByIdPaperStuBatchQuesRelaCache(long lngIdPaperStuBatchQuesRela)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRelaEN._CurrTabName);
List<clscc_PaperStuBatchQuesRelaEN> arrcc_PaperStuBatchQuesRelaObjLstCache = GetObjLstCache();
IEnumerable <clscc_PaperStuBatchQuesRelaEN> arrcc_PaperStuBatchQuesRelaObjLst_Sel =
arrcc_PaperStuBatchQuesRelaObjLstCache
.Where(x=> x.IdPaperStuBatchQuesRela == lngIdPaperStuBatchQuesRela 
);
if (arrcc_PaperStuBatchQuesRelaObjLst_Sel.Count() == 0)
{
   clscc_PaperStuBatchQuesRelaEN obj = clscc_PaperStuBatchQuesRelaBL.GetObjByIdPaperStuBatchQuesRela(lngIdPaperStuBatchQuesRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_PaperStuBatchQuesRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_PaperStuBatchQuesRelaEN> GetAllcc_PaperStuBatchQuesRelaObjLstCache()
{
//获取缓存中的对象列表
List<clscc_PaperStuBatchQuesRelaEN> arrcc_PaperStuBatchQuesRelaObjLstCache = GetObjLstCache(); 
return arrcc_PaperStuBatchQuesRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRelaEN._CurrTabName);
List<clscc_PaperStuBatchQuesRelaEN> arrcc_PaperStuBatchQuesRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_PaperStuBatchQuesRelaObjLstCache;
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
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_PaperStuBatchQuesRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_PaperStuBatchQuesRelaEN._RefreshTimeLst.Count == 0) return "";
return clscc_PaperStuBatchQuesRelaEN._RefreshTimeLst[clscc_PaperStuBatchQuesRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_PaperStuBatchQuesRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_PaperStuBatchQuesRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_PaperStuBatchQuesRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_PaperStuBatchQuesRela(学生批次题目关系)
 /// 唯一性条件:QuestionID_Id_PaperStuBatch
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
//检测记录是否存在
string strResult = cc_PaperStuBatchQuesRelaDA.GetUniCondStr(objcc_PaperStuBatchQuesRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdPaperStuBatchQuesRela)
{
if (strInFldName != concc_PaperStuBatchQuesRela.IdPaperStuBatchQuesRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_PaperStuBatchQuesRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_PaperStuBatchQuesRela.AttributeName));
throw new Exception(strMsg);
}
var objcc_PaperStuBatchQuesRela = clscc_PaperStuBatchQuesRelaBL.GetObjByIdPaperStuBatchQuesRelaCache(lngIdPaperStuBatchQuesRela);
if (objcc_PaperStuBatchQuesRela == null) return "";
return objcc_PaperStuBatchQuesRela[strOutFldName].ToString();
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
int intRecCount = clscc_PaperStuBatchQuesRelaDA.GetRecCount(strTabName);
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
int intRecCount = clscc_PaperStuBatchQuesRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_PaperStuBatchQuesRelaDA.GetRecCount();
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
int intRecCount = clscc_PaperStuBatchQuesRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaCond)
{
List<clscc_PaperStuBatchQuesRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_PaperStuBatchQuesRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_PaperStuBatchQuesRela.AttributeName)
{
if (objcc_PaperStuBatchQuesRelaCond.IsUpdated(strFldName) == false) continue;
if (objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PaperStuBatchQuesRelaCond[strFldName].ToString());
}
else
{
if (objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_PaperStuBatchQuesRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PaperStuBatchQuesRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_PaperStuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_PaperStuBatchQuesRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_PaperStuBatchQuesRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_PaperStuBatchQuesRelaCond[strFldName]));
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
 List<string> arrList = clscc_PaperStuBatchQuesRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_PaperStuBatchQuesRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_PaperStuBatchQuesRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_PaperStuBatchQuesRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_PaperStuBatchQuesRelaDA.SetFldValue(clscc_PaperStuBatchQuesRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_PaperStuBatchQuesRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_PaperStuBatchQuesRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_PaperStuBatchQuesRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_PaperStuBatchQuesRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_PaperStuBatchQuesRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**学生批次题目关系流水号*/ 
 strCreateTabCode.Append(" IdPaperStuBatchQuesRela bigint primary key identity, "); 
 // /**学生试卷批次流水号*/ 
 strCreateTabCode.Append(" IdPaperStuBatch char(10) not Null, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint Null, "); 
 // /**题序号4批次*/ 
 strCreateTabCode.Append(" QuestionIndex4Batch int Null, "); 
 // /**分值*/ 
 strCreateTabCode.Append(" Scores decimal(8,2) Null, "); 
 // /**得分*/ 
 strCreateTabCode.Append(" Score decimal(6,1) Null, "); 
 // /**学生回答文本*/ 
 strCreateTabCode.Append(" StuAnswerText text Null, "); 
 // /**回答日期*/ 
 strCreateTabCode.Append(" AnswerDate varchar(8) Null, "); 
 // /**回答IP*/ 
 strCreateTabCode.Append(" AnswerIP varchar(30) Null, "); 
 // /**答案模式Id*/ 
 strCreateTabCode.Append(" AnswerModeId char(4) Null, "); 
 // /**多选项答案*/ 
 strCreateTabCode.Append(" AnswerMultiOptions varchar(300) Null, "); 
 // /**回答选项Id*/ 
 strCreateTabCode.Append(" AnswerOptionId char(8) Null, "); 
 // /**回答时间*/ 
 strCreateTabCode.Append(" AnswerTime varchar(10) Null, "); 
 // /**申请退回日期*/ 
 strCreateTabCode.Append(" ApplySendBackDate varchar(14) Null, "); 
 // /**批注*/ 
 strCreateTabCode.Append(" Comment text Null, "); 
 // /**是否处理知识点*/ 
 strCreateTabCode.Append(" IsAccessKnowledge bit Null, "); 
 // /**是否申请退回*/ 
 strCreateTabCode.Append(" IsApplySendBack bit Null, "); 
 // /**是否进入错题*/ 
 strCreateTabCode.Append(" IsInErrorQuestion bit Null, "); 
 // /**是否查看*/ 
 strCreateTabCode.Append(" IsLook bit Null, "); 
 // /**是否批阅*/ 
 strCreateTabCode.Append(" IsMarking bit Null, "); 
 // /**是否不处理超时*/ 
 strCreateTabCode.Append(" IsNotProcessTimeout bit Null, "); 
 // /**是否发布*/ 
 strCreateTabCode.Append(" IsPublish bit Null, "); 
 // /**是否正确*/ 
 strCreateTabCode.Append(" IsRight bit Null, "); 
 // /**是否保存*/ 
 strCreateTabCode.Append(" IsSave bit Null, "); 
 // /**是否退回*/ 
 strCreateTabCode.Append(" IsSendBack bit Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**打分日期*/ 
 strCreateTabCode.Append(" MarkDate varchar(14) Null, "); 
 // /**打分者*/ 
 strCreateTabCode.Append(" MarkerId varchar(20) Null, "); 
 // /**操作时间*/ 
 strCreateTabCode.Append(" OperateTime varchar(14) Null, "); 
 // /**实际完成日期*/ 
 strCreateTabCode.Append(" RealFinishDate varchar(14) Null, "); 
 // /**作业类型Id*/ 
 strCreateTabCode.Append(" WorkTypeId char(2) Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(200) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
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
 /// 学生批次题目关系(cc_PaperStuBatchQuesRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_PaperStuBatchQuesRela : clsCommFun4BL
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
clscc_PaperStuBatchQuesRelaBL.ReFreshThisCache();
}
}

}