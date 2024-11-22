
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelationBL
 表名:cc_WorkStuRelation(01120145)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:41
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
public static class  clscc_WorkStuRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelationEN GetObj(this K_IdWorkStuRelation_cc_WorkStuRelation myKey)
{
clscc_WorkStuRelationEN objcc_WorkStuRelationEN = clscc_WorkStuRelationBL.cc_WorkStuRelationDA.GetObjByIdWorkStuRelation(myKey.Value);
return objcc_WorkStuRelationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_WorkStuRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],题目Id = [{1}],学生流水号 = [{2}]的数据已经存在!(in clscc_WorkStuRelationBL.AddNewRecord)", objcc_WorkStuRelationEN.IdCurrEduCls,objcc_WorkStuRelationEN.QuestionId,objcc_WorkStuRelationEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
bool bolResult = clscc_WorkStuRelationBL.cc_WorkStuRelationDA.AddNewRecordBySQL2(objcc_WorkStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationBL.ReFreshCache();

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsNeedCheckUniqueness = true)
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
objcc_WorkStuRelationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_WorkStuRelationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班流水号(IdCurrEduCls)=[{0}],题目Id(QuestionId)=[{1}],学生流水号(IdStudentInfo)=[{2}])已经存在,不能重复!", objcc_WorkStuRelationEN.IdCurrEduCls, objcc_WorkStuRelationEN.QuestionId, objcc_WorkStuRelationEN.IdStudentInfo);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objcc_WorkStuRelationEN.AddNewRecord();
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
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_WorkStuRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],题目Id = [{1}],学生流水号 = [{2}]的数据已经存在!(in clscc_WorkStuRelationBL.AddNewRecordWithReturnKey)", objcc_WorkStuRelationEN.IdCurrEduCls,objcc_WorkStuRelationEN.QuestionId,objcc_WorkStuRelationEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
string strKey = clscc_WorkStuRelationBL.cc_WorkStuRelationDA.AddNewRecordBySQL2WithReturnKey(objcc_WorkStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationBL.ReFreshCache();

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIdWorkStuRelation(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, long lngIdWorkStuRelation, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IdWorkStuRelation = lngIdWorkStuRelation; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IdWorkStuRelation) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IdWorkStuRelation, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IdWorkStuRelation] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIdCurrEduCls(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, concc_WorkStuRelation.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, concc_WorkStuRelation.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, concc_WorkStuRelation.IdCurrEduCls);
}
objcc_WorkStuRelationEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IdCurrEduCls) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IdCurrEduCls, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IdCurrEduCls] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetQuestionId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, long lngQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngQuestionId, concc_WorkStuRelation.QuestionId);
objcc_WorkStuRelationEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.QuestionId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.QuestionId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.QuestionId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetScores(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, double? dblScores, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.Scores) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.Scores, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.Scores] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetSpecifyCompletionDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, concc_WorkStuRelation.SpecifyCompletionDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, concc_WorkStuRelation.SpecifyCompletionDate);
}
objcc_WorkStuRelationEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.SpecifyCompletionDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.SpecifyCompletionDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.SpecifyCompletionDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIdStudentInfo(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, concc_WorkStuRelation.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, concc_WorkStuRelation.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, concc_WorkStuRelation.IdStudentInfo);
}
objcc_WorkStuRelationEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IdStudentInfo) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IdStudentInfo, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IdStudentInfo] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerModeId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, concc_WorkStuRelation.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, concc_WorkStuRelation.AnswerModeId);
}
objcc_WorkStuRelationEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerModeId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerModeId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerModeId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerOptionId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, concc_WorkStuRelation.AnswerOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, concc_WorkStuRelation.AnswerOptionId);
}
objcc_WorkStuRelationEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerOptionId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerOptionId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerOptionId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerMultiOptions(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, concc_WorkStuRelation.AnswerMultiOptions);
}
objcc_WorkStuRelationEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerMultiOptions) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerMultiOptions, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerMultiOptions] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerBoolResult(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolAnswerBoolResult, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.AnswerBoolResult = bolAnswerBoolResult; //答案布尔结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerBoolResult) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerBoolResult, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerBoolResult] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetStuAnswerText(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strStuAnswerText, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.StuAnswerText) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.StuAnswerText, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.StuAnswerText] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsPublish(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsPublish, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsPublish) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsPublish, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsPublish] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsLook(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsLook, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsLook) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsLook, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsLook] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsSave(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsSave, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsSave) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsSave, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsSave] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsSubmit(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsSubmit, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsSubmit) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsSubmit, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsSubmit] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetApplySendBackDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strApplySendBackDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, concc_WorkStuRelation.ApplySendBackDate);
}
objcc_WorkStuRelationEN.ApplySendBackDate = strApplySendBackDate; //申请退回日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.ApplySendBackDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.ApplySendBackDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.ApplySendBackDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsApplySendBack(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsApplySendBack, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsApplySendBack = bolIsApplySendBack; //是否申请退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsApplySendBack) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsApplySendBack, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsApplySendBack] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetRealFinishDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strRealFinishDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, concc_WorkStuRelation.RealFinishDate);
}
objcc_WorkStuRelationEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.RealFinishDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.RealFinishDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.RealFinishDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetOperateTime(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strOperateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperateTime, 14, concc_WorkStuRelation.OperateTime);
}
objcc_WorkStuRelationEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.OperateTime) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.OperateTime, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.OperateTime] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetScore(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, double? dblScore, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.Score) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.Score, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.Score] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetComment(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strComment, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.Comment) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.Comment, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.Comment] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsMarking(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsMarking, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsMarking) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsMarking, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsMarking] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetMarkerId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, concc_WorkStuRelation.MarkerId);
}
objcc_WorkStuRelationEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.MarkerId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.MarkerId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.MarkerId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetMarkDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strMarkDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkDate, 14, concc_WorkStuRelation.MarkDate);
}
objcc_WorkStuRelationEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.MarkDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.MarkDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.MarkDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsSendBack(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsSendBack, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsSendBack) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsSendBack, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsSendBack] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsInErrorQuestion(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsInErrorQuestion) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsInErrorQuestion, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsInErrorQuestion] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetWorkTypeId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, concc_WorkStuRelation.WorkTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, concc_WorkStuRelation.WorkTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, concc_WorkStuRelation.WorkTypeId);
}
objcc_WorkStuRelationEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.WorkTypeId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.WorkTypeId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.WorkTypeId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerIP(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerIP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, concc_WorkStuRelation.AnswerIP);
}
objcc_WorkStuRelationEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerIP) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerIP, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerIP] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, concc_WorkStuRelation.AnswerDate);
}
objcc_WorkStuRelationEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerTime(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, concc_WorkStuRelation.AnswerTime);
}
objcc_WorkStuRelationEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerTime) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerTime, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerTime] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetCourseExamPaperId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_WorkStuRelation.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_WorkStuRelation.CourseExamPaperId);
}
objcc_WorkStuRelationEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.CourseExamPaperId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsRight(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsRight, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsRight) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsRight, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsRight] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsAccessKnowledge(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsAccessKnowledge) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsAccessKnowledge, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsAccessKnowledge] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsNotProcessTimeout(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsNotProcessTimeout) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsNotProcessTimeout, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsNotProcessTimeout] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetSchoolYear(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, concc_WorkStuRelation.SchoolYear);
}
objcc_WorkStuRelationEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.SchoolYear) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.SchoolYear, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.SchoolYear] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetSchoolTerm(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, concc_WorkStuRelation.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, concc_WorkStuRelation.SchoolTerm);
}
objcc_WorkStuRelationEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.SchoolTerm) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.SchoolTerm, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.SchoolTerm] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetErrMsg(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 200, concc_WorkStuRelation.ErrMsg);
}
objcc_WorkStuRelationEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.ErrMsg) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.ErrMsg, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.ErrMsg] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetCourseId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_WorkStuRelation.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_WorkStuRelation.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_WorkStuRelation.CourseId);
}
objcc_WorkStuRelationEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.CourseId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.CourseId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.CourseId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetUpdDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_WorkStuRelation.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_WorkStuRelation.UpdDate);
}
objcc_WorkStuRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.UpdDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.UpdDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.UpdDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetUpdUserId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_WorkStuRelation.UpdUserId);
}
objcc_WorkStuRelationEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.UpdUserId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.UpdUserId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.UpdUserId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelationEN SetMemo(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_WorkStuRelation.Memo);
}
objcc_WorkStuRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.Memo) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.Memo, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.Memo] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_WorkStuRelationEN.CheckPropertyNew();
clscc_WorkStuRelationEN objcc_WorkStuRelationCond = new clscc_WorkStuRelationEN();
string strCondition = objcc_WorkStuRelationCond
.SetIdWorkStuRelation(objcc_WorkStuRelationEN.IdWorkStuRelation, "<>")
.SetIdCurrEduCls(objcc_WorkStuRelationEN.IdCurrEduCls, "=")
.SetQuestionId(objcc_WorkStuRelationEN.QuestionId, "=")
.SetIdStudentInfo(objcc_WorkStuRelationEN.IdStudentInfo, "=")
.GetCombineCondition();
objcc_WorkStuRelationEN._IsCheckProperty = true;
bool bolIsExist = clscc_WorkStuRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_CurrEduCls_QuestionID_id_StudentInfo)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_WorkStuRelationEN.Update();
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
 /// <param name = "objcc_WorkStuRelation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_WorkStuRelationEN objcc_WorkStuRelation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_WorkStuRelationEN objcc_WorkStuRelationCond = new clscc_WorkStuRelationEN();
string strCondition = objcc_WorkStuRelationCond
.SetIdCurrEduCls(objcc_WorkStuRelation.IdCurrEduCls, "=")
.SetQuestionId(objcc_WorkStuRelation.QuestionId, "=")
.SetIdStudentInfo(objcc_WorkStuRelation.IdStudentInfo, "=")
.GetCombineCondition();
objcc_WorkStuRelation._IsCheckProperty = true;
bool bolIsExist = clscc_WorkStuRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_WorkStuRelation.IdWorkStuRelation = clscc_WorkStuRelationBL.GetFirstID_S(strCondition);
objcc_WorkStuRelation.UpdateWithCondition(strCondition);
}
else
{
objcc_WorkStuRelation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
 if (objcc_WorkStuRelationEN.IdWorkStuRelation == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_WorkStuRelationBL.cc_WorkStuRelationDA.UpdateBySql2(objcc_WorkStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationBL.ReFreshCache();

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_WorkStuRelationEN.IdWorkStuRelation == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_WorkStuRelationBL.cc_WorkStuRelationDA.UpdateBySql2(objcc_WorkStuRelationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationBL.ReFreshCache();

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strWhereCond)
{
try
{
bool bolResult = clscc_WorkStuRelationBL.cc_WorkStuRelationDA.UpdateBySqlWithCondition(objcc_WorkStuRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationBL.ReFreshCache();

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_WorkStuRelationBL.cc_WorkStuRelationDA.UpdateBySqlWithConditionTransaction(objcc_WorkStuRelationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationBL.ReFreshCache();

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
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
 /// <param name = "lngIdWorkStuRelation">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
try
{
int intRecNum = clscc_WorkStuRelationBL.cc_WorkStuRelationDA.DelRecord(objcc_WorkStuRelationEN.IdWorkStuRelation);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationBL.ReFreshCache();

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelationENS">源对象</param>
 /// <param name = "objcc_WorkStuRelationENT">目标对象</param>
 public static void CopyTo(this clscc_WorkStuRelationEN objcc_WorkStuRelationENS, clscc_WorkStuRelationEN objcc_WorkStuRelationENT)
{
try
{
objcc_WorkStuRelationENT.IdWorkStuRelation = objcc_WorkStuRelationENS.IdWorkStuRelation; //流水号
objcc_WorkStuRelationENT.IdCurrEduCls = objcc_WorkStuRelationENS.IdCurrEduCls; //教学班流水号
objcc_WorkStuRelationENT.QuestionId = objcc_WorkStuRelationENS.QuestionId; //题目Id
objcc_WorkStuRelationENT.Scores = objcc_WorkStuRelationENS.Scores; //分值
objcc_WorkStuRelationENT.SpecifyCompletionDate = objcc_WorkStuRelationENS.SpecifyCompletionDate; //指定完成日期
objcc_WorkStuRelationENT.IdStudentInfo = objcc_WorkStuRelationENS.IdStudentInfo; //学生流水号
objcc_WorkStuRelationENT.AnswerModeId = objcc_WorkStuRelationENS.AnswerModeId; //答案模式Id
objcc_WorkStuRelationENT.AnswerOptionId = objcc_WorkStuRelationENS.AnswerOptionId; //回答选项Id
objcc_WorkStuRelationENT.AnswerMultiOptions = objcc_WorkStuRelationENS.AnswerMultiOptions; //多选项答案
objcc_WorkStuRelationENT.AnswerBoolResult = objcc_WorkStuRelationENS.AnswerBoolResult; //答案布尔结果
objcc_WorkStuRelationENT.StuAnswerText = objcc_WorkStuRelationENS.StuAnswerText; //学生回答文本
objcc_WorkStuRelationENT.IsPublish = objcc_WorkStuRelationENS.IsPublish; //是否发布
objcc_WorkStuRelationENT.IsLook = objcc_WorkStuRelationENS.IsLook; //是否查看
objcc_WorkStuRelationENT.IsSave = objcc_WorkStuRelationENS.IsSave; //是否保存
objcc_WorkStuRelationENT.IsSubmit = objcc_WorkStuRelationENS.IsSubmit; //是否提交
objcc_WorkStuRelationENT.ApplySendBackDate = objcc_WorkStuRelationENS.ApplySendBackDate; //申请退回日期
objcc_WorkStuRelationENT.IsApplySendBack = objcc_WorkStuRelationENS.IsApplySendBack; //是否申请退回
objcc_WorkStuRelationENT.RealFinishDate = objcc_WorkStuRelationENS.RealFinishDate; //实际完成日期
objcc_WorkStuRelationENT.OperateTime = objcc_WorkStuRelationENS.OperateTime; //操作时间
objcc_WorkStuRelationENT.Score = objcc_WorkStuRelationENS.Score; //得分
objcc_WorkStuRelationENT.Comment = objcc_WorkStuRelationENS.Comment; //批注
objcc_WorkStuRelationENT.IsMarking = objcc_WorkStuRelationENS.IsMarking; //是否批阅
objcc_WorkStuRelationENT.MarkerId = objcc_WorkStuRelationENS.MarkerId; //打分者
objcc_WorkStuRelationENT.MarkDate = objcc_WorkStuRelationENS.MarkDate; //打分日期
objcc_WorkStuRelationENT.IsSendBack = objcc_WorkStuRelationENS.IsSendBack; //是否退回
objcc_WorkStuRelationENT.IsInErrorQuestion = objcc_WorkStuRelationENS.IsInErrorQuestion; //是否进入错题
objcc_WorkStuRelationENT.WorkTypeId = objcc_WorkStuRelationENS.WorkTypeId; //作业类型Id
objcc_WorkStuRelationENT.AnswerIP = objcc_WorkStuRelationENS.AnswerIP; //回答IP
objcc_WorkStuRelationENT.AnswerDate = objcc_WorkStuRelationENS.AnswerDate; //回答日期
objcc_WorkStuRelationENT.AnswerTime = objcc_WorkStuRelationENS.AnswerTime; //回答时间
objcc_WorkStuRelationENT.CourseExamPaperId = objcc_WorkStuRelationENS.CourseExamPaperId; //考卷流水号
objcc_WorkStuRelationENT.IsRight = objcc_WorkStuRelationENS.IsRight; //是否正确
objcc_WorkStuRelationENT.IsAccessKnowledge = objcc_WorkStuRelationENS.IsAccessKnowledge; //是否处理知识点
objcc_WorkStuRelationENT.IsNotProcessTimeout = objcc_WorkStuRelationENS.IsNotProcessTimeout; //是否不处理超时
objcc_WorkStuRelationENT.SchoolYear = objcc_WorkStuRelationENS.SchoolYear; //学年
objcc_WorkStuRelationENT.SchoolTerm = objcc_WorkStuRelationENS.SchoolTerm; //学期
objcc_WorkStuRelationENT.ErrMsg = objcc_WorkStuRelationENS.ErrMsg; //错误信息
objcc_WorkStuRelationENT.CourseId = objcc_WorkStuRelationENS.CourseId; //课程Id
objcc_WorkStuRelationENT.UpdDate = objcc_WorkStuRelationENS.UpdDate; //修改日期
objcc_WorkStuRelationENT.UpdUserId = objcc_WorkStuRelationENS.UpdUserId; //修改用户Id
objcc_WorkStuRelationENT.Memo = objcc_WorkStuRelationENS.Memo; //备注
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
 /// <param name = "objcc_WorkStuRelationENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkStuRelationEN:objcc_WorkStuRelationENT</returns>
 public static clscc_WorkStuRelationEN CopyTo(this clscc_WorkStuRelationEN objcc_WorkStuRelationENS)
{
try
{
 clscc_WorkStuRelationEN objcc_WorkStuRelationENT = new clscc_WorkStuRelationEN()
{
IdWorkStuRelation = objcc_WorkStuRelationENS.IdWorkStuRelation, //流水号
IdCurrEduCls = objcc_WorkStuRelationENS.IdCurrEduCls, //教学班流水号
QuestionId = objcc_WorkStuRelationENS.QuestionId, //题目Id
Scores = objcc_WorkStuRelationENS.Scores, //分值
SpecifyCompletionDate = objcc_WorkStuRelationENS.SpecifyCompletionDate, //指定完成日期
IdStudentInfo = objcc_WorkStuRelationENS.IdStudentInfo, //学生流水号
AnswerModeId = objcc_WorkStuRelationENS.AnswerModeId, //答案模式Id
AnswerOptionId = objcc_WorkStuRelationENS.AnswerOptionId, //回答选项Id
AnswerMultiOptions = objcc_WorkStuRelationENS.AnswerMultiOptions, //多选项答案
AnswerBoolResult = objcc_WorkStuRelationENS.AnswerBoolResult, //答案布尔结果
StuAnswerText = objcc_WorkStuRelationENS.StuAnswerText, //学生回答文本
IsPublish = objcc_WorkStuRelationENS.IsPublish, //是否发布
IsLook = objcc_WorkStuRelationENS.IsLook, //是否查看
IsSave = objcc_WorkStuRelationENS.IsSave, //是否保存
IsSubmit = objcc_WorkStuRelationENS.IsSubmit, //是否提交
ApplySendBackDate = objcc_WorkStuRelationENS.ApplySendBackDate, //申请退回日期
IsApplySendBack = objcc_WorkStuRelationENS.IsApplySendBack, //是否申请退回
RealFinishDate = objcc_WorkStuRelationENS.RealFinishDate, //实际完成日期
OperateTime = objcc_WorkStuRelationENS.OperateTime, //操作时间
Score = objcc_WorkStuRelationENS.Score, //得分
Comment = objcc_WorkStuRelationENS.Comment, //批注
IsMarking = objcc_WorkStuRelationENS.IsMarking, //是否批阅
MarkerId = objcc_WorkStuRelationENS.MarkerId, //打分者
MarkDate = objcc_WorkStuRelationENS.MarkDate, //打分日期
IsSendBack = objcc_WorkStuRelationENS.IsSendBack, //是否退回
IsInErrorQuestion = objcc_WorkStuRelationENS.IsInErrorQuestion, //是否进入错题
WorkTypeId = objcc_WorkStuRelationENS.WorkTypeId, //作业类型Id
AnswerIP = objcc_WorkStuRelationENS.AnswerIP, //回答IP
AnswerDate = objcc_WorkStuRelationENS.AnswerDate, //回答日期
AnswerTime = objcc_WorkStuRelationENS.AnswerTime, //回答时间
CourseExamPaperId = objcc_WorkStuRelationENS.CourseExamPaperId, //考卷流水号
IsRight = objcc_WorkStuRelationENS.IsRight, //是否正确
IsAccessKnowledge = objcc_WorkStuRelationENS.IsAccessKnowledge, //是否处理知识点
IsNotProcessTimeout = objcc_WorkStuRelationENS.IsNotProcessTimeout, //是否不处理超时
SchoolYear = objcc_WorkStuRelationENS.SchoolYear, //学年
SchoolTerm = objcc_WorkStuRelationENS.SchoolTerm, //学期
ErrMsg = objcc_WorkStuRelationENS.ErrMsg, //错误信息
CourseId = objcc_WorkStuRelationENS.CourseId, //课程Id
UpdDate = objcc_WorkStuRelationENS.UpdDate, //修改日期
UpdUserId = objcc_WorkStuRelationENS.UpdUserId, //修改用户Id
Memo = objcc_WorkStuRelationENS.Memo, //备注
};
 return objcc_WorkStuRelationENT;
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
public static void CheckPropertyNew(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
 clscc_WorkStuRelationBL.cc_WorkStuRelationDA.CheckPropertyNew(objcc_WorkStuRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
 clscc_WorkStuRelationBL.cc_WorkStuRelationDA.CheckProperty4Condition(objcc_WorkStuRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkStuRelationEN objcc_WorkStuRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IdWorkStuRelation) == true)
{
string strComparisonOpIdWorkStuRelation = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.IdWorkStuRelation];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation.IdWorkStuRelation, objcc_WorkStuRelationCond.IdWorkStuRelation, strComparisonOpIdWorkStuRelation);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.IdCurrEduCls, objcc_WorkStuRelationCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.QuestionId) == true)
{
string strComparisonOpQuestionId = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation.QuestionId, objcc_WorkStuRelationCond.QuestionId, strComparisonOpQuestionId);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.Scores) == true)
{
string strComparisonOpScores = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation.Scores, objcc_WorkStuRelationCond.Scores, strComparisonOpScores);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.SpecifyCompletionDate) == true)
{
string strComparisonOpSpecifyCompletionDate = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.SpecifyCompletionDate, objcc_WorkStuRelationCond.SpecifyCompletionDate, strComparisonOpSpecifyCompletionDate);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.IdStudentInfo, objcc_WorkStuRelationCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerModeId, objcc_WorkStuRelationCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.AnswerOptionId) == true)
{
string strComparisonOpAnswerOptionId = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerOptionId, objcc_WorkStuRelationCond.AnswerOptionId, strComparisonOpAnswerOptionId);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.AnswerMultiOptions) == true)
{
string strComparisonOpAnswerMultiOptions = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerMultiOptions, objcc_WorkStuRelationCond.AnswerMultiOptions, strComparisonOpAnswerMultiOptions);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.AnswerBoolResult) == true)
{
if (objcc_WorkStuRelationCond.AnswerBoolResult == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.AnswerBoolResult);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.AnswerBoolResult);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IsPublish) == true)
{
if (objcc_WorkStuRelationCond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsPublish);
}
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IsLook) == true)
{
if (objcc_WorkStuRelationCond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsLook);
}
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IsSave) == true)
{
if (objcc_WorkStuRelationCond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsSave);
}
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IsSubmit) == true)
{
if (objcc_WorkStuRelationCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsSubmit);
}
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.ApplySendBackDate) == true)
{
string strComparisonOpApplySendBackDate = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.ApplySendBackDate, objcc_WorkStuRelationCond.ApplySendBackDate, strComparisonOpApplySendBackDate);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IsApplySendBack) == true)
{
if (objcc_WorkStuRelationCond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsApplySendBack);
}
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.RealFinishDate) == true)
{
string strComparisonOpRealFinishDate = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.RealFinishDate, objcc_WorkStuRelationCond.RealFinishDate, strComparisonOpRealFinishDate);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.OperateTime) == true)
{
string strComparisonOpOperateTime = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.OperateTime, objcc_WorkStuRelationCond.OperateTime, strComparisonOpOperateTime);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.Score) == true)
{
string strComparisonOpScore = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.Score];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation.Score, objcc_WorkStuRelationCond.Score, strComparisonOpScore);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IsMarking) == true)
{
if (objcc_WorkStuRelationCond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsMarking);
}
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.MarkerId) == true)
{
string strComparisonOpMarkerId = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.MarkerId, objcc_WorkStuRelationCond.MarkerId, strComparisonOpMarkerId);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.MarkDate) == true)
{
string strComparisonOpMarkDate = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.MarkDate, objcc_WorkStuRelationCond.MarkDate, strComparisonOpMarkDate);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IsSendBack) == true)
{
if (objcc_WorkStuRelationCond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsSendBack);
}
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IsInErrorQuestion) == true)
{
if (objcc_WorkStuRelationCond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsInErrorQuestion);
}
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.WorkTypeId) == true)
{
string strComparisonOpWorkTypeId = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.WorkTypeId, objcc_WorkStuRelationCond.WorkTypeId, strComparisonOpWorkTypeId);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.AnswerIP) == true)
{
string strComparisonOpAnswerIP = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerIP, objcc_WorkStuRelationCond.AnswerIP, strComparisonOpAnswerIP);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.AnswerDate) == true)
{
string strComparisonOpAnswerDate = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerDate, objcc_WorkStuRelationCond.AnswerDate, strComparisonOpAnswerDate);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.AnswerTime) == true)
{
string strComparisonOpAnswerTime = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerTime, objcc_WorkStuRelationCond.AnswerTime, strComparisonOpAnswerTime);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.CourseExamPaperId, objcc_WorkStuRelationCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IsRight) == true)
{
if (objcc_WorkStuRelationCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsRight);
}
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IsAccessKnowledge) == true)
{
if (objcc_WorkStuRelationCond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsAccessKnowledge);
}
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.IsNotProcessTimeout) == true)
{
if (objcc_WorkStuRelationCond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsNotProcessTimeout);
}
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.SchoolYear, objcc_WorkStuRelationCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.SchoolTerm, objcc_WorkStuRelationCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.ErrMsg) == true)
{
string strComparisonOpErrMsg = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.ErrMsg, objcc_WorkStuRelationCond.ErrMsg, strComparisonOpErrMsg);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.CourseId) == true)
{
string strComparisonOpCourseId = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.CourseId, objcc_WorkStuRelationCond.CourseId, strComparisonOpCourseId);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.UpdDate, objcc_WorkStuRelationCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.UpdUserId, objcc_WorkStuRelationCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_WorkStuRelationCond.IsUpdated(concc_WorkStuRelation.Memo) == true)
{
string strComparisonOpMemo = objcc_WorkStuRelationCond.dicFldComparisonOp[concc_WorkStuRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.Memo, objcc_WorkStuRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_WorkStuRelation(作业与学生关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_CurrEduCls_QuestionID_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkStuRelationEN == null) return true;
if (objcc_WorkStuRelationEN.IdWorkStuRelation == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_WorkStuRelationEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_WorkStuRelationEN.QuestionId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelationEN.IdStudentInfo);
if (clscc_WorkStuRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdWorkStuRelation !=  {0}", objcc_WorkStuRelationEN.IdWorkStuRelation);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_WorkStuRelationEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_WorkStuRelationEN.QuestionId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelationEN.IdStudentInfo);
if (clscc_WorkStuRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_WorkStuRelation(作业与学生关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_CurrEduCls_QuestionID_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkStuRelationEN == null) return "";
if (objcc_WorkStuRelationEN.IdWorkStuRelation == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_WorkStuRelationEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_WorkStuRelationEN.QuestionId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelationEN.IdStudentInfo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdWorkStuRelation !=  {0}", objcc_WorkStuRelationEN.IdWorkStuRelation);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_WorkStuRelationEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_WorkStuRelationEN.QuestionId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelationEN.IdStudentInfo);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_WorkStuRelation
{
public virtual bool UpdRelaTabDate(long lngIdWorkStuRelation, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 作业与学生关系(cc_WorkStuRelation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkStuRelationBL
{
public static RelatedActions_cc_WorkStuRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_WorkStuRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_WorkStuRelationDA cc_WorkStuRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_WorkStuRelationDA();
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
 public clscc_WorkStuRelationBL()
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
if (string.IsNullOrEmpty(clscc_WorkStuRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_WorkStuRelationEN._ConnectString);
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
public static DataTable GetDataTable_cc_WorkStuRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_WorkStuRelationDA.GetDataTable_cc_WorkStuRelation(strWhereCond);
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
objDT = cc_WorkStuRelationDA.GetDataTable(strWhereCond);
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
objDT = cc_WorkStuRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_WorkStuRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_WorkStuRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_WorkStuRelationDA.GetDataTable_Top(objTopPara);
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
objDT = cc_WorkStuRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_WorkStuRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_WorkStuRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdWorkStuRelationLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_WorkStuRelationEN> GetObjLstByIdWorkStuRelationLst(List<long> arrIdWorkStuRelationLst)
{
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdWorkStuRelationLst);
 string strWhereCond = string.Format("IdWorkStuRelation in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdWorkStuRelationLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_WorkStuRelationEN> GetObjLstByIdWorkStuRelationLstCache(List<long> arrIdWorkStuRelationLst)
{
string strKey = string.Format("{0}", clscc_WorkStuRelationEN._CurrTabName);
List<clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLst_Sel =
arrcc_WorkStuRelationObjLstCache
.Where(x => arrIdWorkStuRelationLst.Contains(x.IdWorkStuRelation));
return arrcc_WorkStuRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelationEN> GetObjLst(string strWhereCond)
{
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelationEN);
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
public static List<clscc_WorkStuRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_WorkStuRelationEN> GetSubObjLstCache(clscc_WorkStuRelationEN objcc_WorkStuRelationCond)
{
List<clscc_WorkStuRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkStuRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_WorkStuRelation.AttributeName)
{
if (objcc_WorkStuRelationCond.IsUpdated(strFldName) == false) continue;
if (objcc_WorkStuRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelationCond[strFldName].ToString());
}
else
{
if (objcc_WorkStuRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_WorkStuRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_WorkStuRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelationCond[strFldName]));
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
public static List<clscc_WorkStuRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelationEN);
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
public static List<clscc_WorkStuRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelationEN);
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
List<clscc_WorkStuRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_WorkStuRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_WorkStuRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
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
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelationEN);
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
public static List<clscc_WorkStuRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_WorkStuRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_WorkStuRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelationEN);
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
public static List<clscc_WorkStuRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_WorkStuRelationEN> arrObjLst = new List<clscc_WorkStuRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
try
{
objcc_WorkStuRelationEN.IdWorkStuRelation = Int32.Parse(objRow[concc_WorkStuRelation.IdWorkStuRelation].ToString().Trim()); //流水号
objcc_WorkStuRelationEN.IdCurrEduCls = objRow[concc_WorkStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelationEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelationEN.Scores = objRow[concc_WorkStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Scores].ToString().Trim()); //分值
objcc_WorkStuRelationEN.SpecifyCompletionDate = objRow[concc_WorkStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_WorkStuRelationEN.IdStudentInfo = objRow[concc_WorkStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelationEN.AnswerModeId = objRow[concc_WorkStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_WorkStuRelationEN.AnswerOptionId = objRow[concc_WorkStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_WorkStuRelationEN.AnswerMultiOptions = objRow[concc_WorkStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_WorkStuRelationEN.AnswerBoolResult = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.AnswerBoolResult].ToString().Trim()); //答案布尔结果
objcc_WorkStuRelationEN.StuAnswerText = objRow[concc_WorkStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_WorkStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_WorkStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_WorkStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_WorkStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_WorkStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_WorkStuRelationEN.ApplySendBackDate = objRow[concc_WorkStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_WorkStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_WorkStuRelationEN.RealFinishDate = objRow[concc_WorkStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_WorkStuRelationEN.OperateTime = objRow[concc_WorkStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_WorkStuRelationEN.Score = objRow[concc_WorkStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation.Score].ToString().Trim()); //得分
objcc_WorkStuRelationEN.Comment = objRow[concc_WorkStuRelation.Comment] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Comment].ToString().Trim(); //批注
objcc_WorkStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_WorkStuRelationEN.MarkerId = objRow[concc_WorkStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_WorkStuRelationEN.MarkDate = objRow[concc_WorkStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_WorkStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_WorkStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_WorkStuRelationEN.WorkTypeId = objRow[concc_WorkStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_WorkStuRelationEN.AnswerIP = objRow[concc_WorkStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_WorkStuRelationEN.AnswerDate = objRow[concc_WorkStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_WorkStuRelationEN.AnswerTime = objRow[concc_WorkStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_WorkStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_WorkStuRelationEN.CourseExamPaperId = objRow[concc_WorkStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_WorkStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_WorkStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_WorkStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_WorkStuRelationEN.SchoolYear = objRow[concc_WorkStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelationEN.SchoolTerm = objRow[concc_WorkStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelationEN.ErrMsg = objRow[concc_WorkStuRelation.ErrMsg] == DBNull.Value ? null : objRow[concc_WorkStuRelation.ErrMsg].ToString().Trim(); //错误信息
objcc_WorkStuRelationEN.CourseId = objRow[concc_WorkStuRelation.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelationEN.UpdDate = objRow[concc_WorkStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelationEN.UpdUserId = objRow[concc_WorkStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelationEN.Memo = objRow[concc_WorkStuRelation.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelationEN.IdWorkStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_WorkStuRelation(ref clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
bool bolResult = cc_WorkStuRelationDA.Getcc_WorkStuRelation(ref objcc_WorkStuRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelationEN GetObjByIdWorkStuRelation(long lngIdWorkStuRelation)
{
clscc_WorkStuRelationEN objcc_WorkStuRelationEN = cc_WorkStuRelationDA.GetObjByIdWorkStuRelation(lngIdWorkStuRelation);
return objcc_WorkStuRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_WorkStuRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_WorkStuRelationEN objcc_WorkStuRelationEN = cc_WorkStuRelationDA.GetFirstObj(strWhereCond);
 return objcc_WorkStuRelationEN;
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
public static clscc_WorkStuRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_WorkStuRelationEN objcc_WorkStuRelationEN = cc_WorkStuRelationDA.GetObjByDataRow(objRow);
 return objcc_WorkStuRelationEN;
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
public static clscc_WorkStuRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_WorkStuRelationEN objcc_WorkStuRelationEN = cc_WorkStuRelationDA.GetObjByDataRow(objRow);
 return objcc_WorkStuRelationEN;
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
 /// <param name = "lngIdWorkStuRelation">所给的关键字</param>
 /// <param name = "lstcc_WorkStuRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkStuRelationEN GetObjByIdWorkStuRelationFromList(long lngIdWorkStuRelation, List<clscc_WorkStuRelationEN> lstcc_WorkStuRelationObjLst)
{
foreach (clscc_WorkStuRelationEN objcc_WorkStuRelationEN in lstcc_WorkStuRelationObjLst)
{
if (objcc_WorkStuRelationEN.IdWorkStuRelation == lngIdWorkStuRelation)
{
return objcc_WorkStuRelationEN;
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
 long lngIdWorkStuRelation;
 try
 {
 lngIdWorkStuRelation = new clscc_WorkStuRelationDA().GetFirstID(strWhereCond);
 return lngIdWorkStuRelation;
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
 arrList = cc_WorkStuRelationDA.GetID(strWhereCond);
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
bool bolIsExist = cc_WorkStuRelationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdWorkStuRelation)
{
//检测记录是否存在
bool bolIsExist = cc_WorkStuRelationDA.IsExist(lngIdWorkStuRelation);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdWorkStuRelation">流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdWorkStuRelation, string strOpUser)
{
clscc_WorkStuRelationEN objcc_WorkStuRelationEN = clscc_WorkStuRelationBL.GetObjByIdWorkStuRelation(lngIdWorkStuRelation);
objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_WorkStuRelationEN.UpdUserId = strOpUser;
return clscc_WorkStuRelationBL.UpdateBySql2(objcc_WorkStuRelationEN);
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
 bolIsExist = clscc_WorkStuRelationDA.IsExistTable();
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
 bolIsExist = cc_WorkStuRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_WorkStuRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],题目Id = [{1}],学生流水号 = [{2}]的数据已经存在!(in clscc_WorkStuRelationBL.AddNewRecordBySql2)", objcc_WorkStuRelationEN.IdCurrEduCls,objcc_WorkStuRelationEN.QuestionId,objcc_WorkStuRelationEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
bool bolResult = cc_WorkStuRelationDA.AddNewRecordBySQL2(objcc_WorkStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationBL.ReFreshCache();

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_WorkStuRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],题目Id = [{1}],学生流水号 = [{2}]的数据已经存在!(in clscc_WorkStuRelationBL.AddNewRecordBySql2WithReturnKey)", objcc_WorkStuRelationEN.IdCurrEduCls,objcc_WorkStuRelationEN.QuestionId,objcc_WorkStuRelationEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
string strKey = cc_WorkStuRelationDA.AddNewRecordBySQL2WithReturnKey(objcc_WorkStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationBL.ReFreshCache();

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
try
{
bool bolResult = cc_WorkStuRelationDA.Update(objcc_WorkStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationBL.ReFreshCache();

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
 if (objcc_WorkStuRelationEN.IdWorkStuRelation == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_WorkStuRelationDA.UpdateBySql2(objcc_WorkStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationBL.ReFreshCache();

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
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
 /// <param name = "lngIdWorkStuRelation">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdWorkStuRelation)
{
try
{
 clscc_WorkStuRelationEN objcc_WorkStuRelationEN = clscc_WorkStuRelationBL.GetObjByIdWorkStuRelation(lngIdWorkStuRelation);

if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelationEN.IdWorkStuRelation, objcc_WorkStuRelationEN.UpdUserId);
}
if (objcc_WorkStuRelationEN != null)
{
int intRecNum = cc_WorkStuRelationDA.DelRecord(lngIdWorkStuRelation);
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
/// <param name="lngIdWorkStuRelation">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdWorkStuRelation )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
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
//删除与表:[cc_WorkStuRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_WorkStuRelation.IdWorkStuRelation,
//lngIdWorkStuRelation);
//        clscc_WorkStuRelationBL.Delcc_WorkStuRelationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_WorkStuRelationBL.DelRecord(lngIdWorkStuRelation, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_WorkStuRelationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdWorkStuRelation, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdWorkStuRelation">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdWorkStuRelation, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_WorkStuRelationBL.relatedActions != null)
{
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(lngIdWorkStuRelation, "UpdRelaTabDate");
}
bool bolResult = cc_WorkStuRelationDA.DelRecord(lngIdWorkStuRelation,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdWorkStuRelationLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_WorkStuRelations(List<string> arrIdWorkStuRelationLst)
{
if (arrIdWorkStuRelationLst.Count == 0) return 0;
try
{
if (clscc_WorkStuRelationBL.relatedActions != null)
{
foreach (var strIdWorkStuRelation in arrIdWorkStuRelationLst)
{
long lngIdWorkStuRelation = long.Parse(strIdWorkStuRelation);
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(lngIdWorkStuRelation, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_WorkStuRelationDA.Delcc_WorkStuRelation(arrIdWorkStuRelationLst);
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
public static int Delcc_WorkStuRelationsByCond(string strWhereCond)
{
try
{
if (clscc_WorkStuRelationBL.relatedActions != null)
{
List<string> arrIdWorkStuRelation = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdWorkStuRelation in arrIdWorkStuRelation)
{
long lngIdWorkStuRelation = long.Parse(strIdWorkStuRelation);
clscc_WorkStuRelationBL.relatedActions.UpdRelaTabDate(lngIdWorkStuRelation, "UpdRelaTabDate");
}
}
int intRecNum = cc_WorkStuRelationDA.Delcc_WorkStuRelation(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_WorkStuRelation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdWorkStuRelation">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdWorkStuRelation)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_WorkStuRelationDA.GetSpecSQLObj();
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
//删除与表:[cc_WorkStuRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_WorkStuRelationBL.DelRecord(lngIdWorkStuRelation, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_WorkStuRelationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdWorkStuRelation, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_WorkStuRelationENS">源对象</param>
 /// <param name = "objcc_WorkStuRelationENT">目标对象</param>
 public static void CopyTo(clscc_WorkStuRelationEN objcc_WorkStuRelationENS, clscc_WorkStuRelationEN objcc_WorkStuRelationENT)
{
try
{
objcc_WorkStuRelationENT.IdWorkStuRelation = objcc_WorkStuRelationENS.IdWorkStuRelation; //流水号
objcc_WorkStuRelationENT.IdCurrEduCls = objcc_WorkStuRelationENS.IdCurrEduCls; //教学班流水号
objcc_WorkStuRelationENT.QuestionId = objcc_WorkStuRelationENS.QuestionId; //题目Id
objcc_WorkStuRelationENT.Scores = objcc_WorkStuRelationENS.Scores; //分值
objcc_WorkStuRelationENT.SpecifyCompletionDate = objcc_WorkStuRelationENS.SpecifyCompletionDate; //指定完成日期
objcc_WorkStuRelationENT.IdStudentInfo = objcc_WorkStuRelationENS.IdStudentInfo; //学生流水号
objcc_WorkStuRelationENT.AnswerModeId = objcc_WorkStuRelationENS.AnswerModeId; //答案模式Id
objcc_WorkStuRelationENT.AnswerOptionId = objcc_WorkStuRelationENS.AnswerOptionId; //回答选项Id
objcc_WorkStuRelationENT.AnswerMultiOptions = objcc_WorkStuRelationENS.AnswerMultiOptions; //多选项答案
objcc_WorkStuRelationENT.AnswerBoolResult = objcc_WorkStuRelationENS.AnswerBoolResult; //答案布尔结果
objcc_WorkStuRelationENT.StuAnswerText = objcc_WorkStuRelationENS.StuAnswerText; //学生回答文本
objcc_WorkStuRelationENT.IsPublish = objcc_WorkStuRelationENS.IsPublish; //是否发布
objcc_WorkStuRelationENT.IsLook = objcc_WorkStuRelationENS.IsLook; //是否查看
objcc_WorkStuRelationENT.IsSave = objcc_WorkStuRelationENS.IsSave; //是否保存
objcc_WorkStuRelationENT.IsSubmit = objcc_WorkStuRelationENS.IsSubmit; //是否提交
objcc_WorkStuRelationENT.ApplySendBackDate = objcc_WorkStuRelationENS.ApplySendBackDate; //申请退回日期
objcc_WorkStuRelationENT.IsApplySendBack = objcc_WorkStuRelationENS.IsApplySendBack; //是否申请退回
objcc_WorkStuRelationENT.RealFinishDate = objcc_WorkStuRelationENS.RealFinishDate; //实际完成日期
objcc_WorkStuRelationENT.OperateTime = objcc_WorkStuRelationENS.OperateTime; //操作时间
objcc_WorkStuRelationENT.Score = objcc_WorkStuRelationENS.Score; //得分
objcc_WorkStuRelationENT.Comment = objcc_WorkStuRelationENS.Comment; //批注
objcc_WorkStuRelationENT.IsMarking = objcc_WorkStuRelationENS.IsMarking; //是否批阅
objcc_WorkStuRelationENT.MarkerId = objcc_WorkStuRelationENS.MarkerId; //打分者
objcc_WorkStuRelationENT.MarkDate = objcc_WorkStuRelationENS.MarkDate; //打分日期
objcc_WorkStuRelationENT.IsSendBack = objcc_WorkStuRelationENS.IsSendBack; //是否退回
objcc_WorkStuRelationENT.IsInErrorQuestion = objcc_WorkStuRelationENS.IsInErrorQuestion; //是否进入错题
objcc_WorkStuRelationENT.WorkTypeId = objcc_WorkStuRelationENS.WorkTypeId; //作业类型Id
objcc_WorkStuRelationENT.AnswerIP = objcc_WorkStuRelationENS.AnswerIP; //回答IP
objcc_WorkStuRelationENT.AnswerDate = objcc_WorkStuRelationENS.AnswerDate; //回答日期
objcc_WorkStuRelationENT.AnswerTime = objcc_WorkStuRelationENS.AnswerTime; //回答时间
objcc_WorkStuRelationENT.CourseExamPaperId = objcc_WorkStuRelationENS.CourseExamPaperId; //考卷流水号
objcc_WorkStuRelationENT.IsRight = objcc_WorkStuRelationENS.IsRight; //是否正确
objcc_WorkStuRelationENT.IsAccessKnowledge = objcc_WorkStuRelationENS.IsAccessKnowledge; //是否处理知识点
objcc_WorkStuRelationENT.IsNotProcessTimeout = objcc_WorkStuRelationENS.IsNotProcessTimeout; //是否不处理超时
objcc_WorkStuRelationENT.SchoolYear = objcc_WorkStuRelationENS.SchoolYear; //学年
objcc_WorkStuRelationENT.SchoolTerm = objcc_WorkStuRelationENS.SchoolTerm; //学期
objcc_WorkStuRelationENT.ErrMsg = objcc_WorkStuRelationENS.ErrMsg; //错误信息
objcc_WorkStuRelationENT.CourseId = objcc_WorkStuRelationENS.CourseId; //课程Id
objcc_WorkStuRelationENT.UpdDate = objcc_WorkStuRelationENS.UpdDate; //修改日期
objcc_WorkStuRelationENT.UpdUserId = objcc_WorkStuRelationENS.UpdUserId; //修改用户Id
objcc_WorkStuRelationENT.Memo = objcc_WorkStuRelationENS.Memo; //备注
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
 /// <param name = "objcc_WorkStuRelationEN">源简化对象</param>
 public static void SetUpdFlag(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
try
{
objcc_WorkStuRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_WorkStuRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_WorkStuRelation.IdWorkStuRelation, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IdWorkStuRelation = objcc_WorkStuRelationEN.IdWorkStuRelation; //流水号
}
if (arrFldSet.Contains(concc_WorkStuRelation.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IdCurrEduCls = objcc_WorkStuRelationEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(concc_WorkStuRelation.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.QuestionId = objcc_WorkStuRelationEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(concc_WorkStuRelation.Scores, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.Scores = objcc_WorkStuRelationEN.Scores; //分值
}
if (arrFldSet.Contains(concc_WorkStuRelation.SpecifyCompletionDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.SpecifyCompletionDate = objcc_WorkStuRelationEN.SpecifyCompletionDate; //指定完成日期
}
if (arrFldSet.Contains(concc_WorkStuRelation.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IdStudentInfo = objcc_WorkStuRelationEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(concc_WorkStuRelation.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.AnswerModeId = objcc_WorkStuRelationEN.AnswerModeId == "[null]" ? null :  objcc_WorkStuRelationEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(concc_WorkStuRelation.AnswerOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.AnswerOptionId = objcc_WorkStuRelationEN.AnswerOptionId == "[null]" ? null :  objcc_WorkStuRelationEN.AnswerOptionId; //回答选项Id
}
if (arrFldSet.Contains(concc_WorkStuRelation.AnswerMultiOptions, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.AnswerMultiOptions = objcc_WorkStuRelationEN.AnswerMultiOptions == "[null]" ? null :  objcc_WorkStuRelationEN.AnswerMultiOptions; //多选项答案
}
if (arrFldSet.Contains(concc_WorkStuRelation.AnswerBoolResult, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.AnswerBoolResult = objcc_WorkStuRelationEN.AnswerBoolResult; //答案布尔结果
}
if (arrFldSet.Contains(concc_WorkStuRelation.StuAnswerText, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.StuAnswerText = objcc_WorkStuRelationEN.StuAnswerText == "[null]" ? null :  objcc_WorkStuRelationEN.StuAnswerText; //学生回答文本
}
if (arrFldSet.Contains(concc_WorkStuRelation.IsPublish, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IsPublish = objcc_WorkStuRelationEN.IsPublish; //是否发布
}
if (arrFldSet.Contains(concc_WorkStuRelation.IsLook, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IsLook = objcc_WorkStuRelationEN.IsLook; //是否查看
}
if (arrFldSet.Contains(concc_WorkStuRelation.IsSave, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IsSave = objcc_WorkStuRelationEN.IsSave; //是否保存
}
if (arrFldSet.Contains(concc_WorkStuRelation.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IsSubmit = objcc_WorkStuRelationEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(concc_WorkStuRelation.ApplySendBackDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.ApplySendBackDate = objcc_WorkStuRelationEN.ApplySendBackDate == "[null]" ? null :  objcc_WorkStuRelationEN.ApplySendBackDate; //申请退回日期
}
if (arrFldSet.Contains(concc_WorkStuRelation.IsApplySendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IsApplySendBack = objcc_WorkStuRelationEN.IsApplySendBack; //是否申请退回
}
if (arrFldSet.Contains(concc_WorkStuRelation.RealFinishDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.RealFinishDate = objcc_WorkStuRelationEN.RealFinishDate == "[null]" ? null :  objcc_WorkStuRelationEN.RealFinishDate; //实际完成日期
}
if (arrFldSet.Contains(concc_WorkStuRelation.OperateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.OperateTime = objcc_WorkStuRelationEN.OperateTime == "[null]" ? null :  objcc_WorkStuRelationEN.OperateTime; //操作时间
}
if (arrFldSet.Contains(concc_WorkStuRelation.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.Score = objcc_WorkStuRelationEN.Score; //得分
}
if (arrFldSet.Contains(concc_WorkStuRelation.Comment, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.Comment = objcc_WorkStuRelationEN.Comment == "[null]" ? null :  objcc_WorkStuRelationEN.Comment; //批注
}
if (arrFldSet.Contains(concc_WorkStuRelation.IsMarking, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IsMarking = objcc_WorkStuRelationEN.IsMarking; //是否批阅
}
if (arrFldSet.Contains(concc_WorkStuRelation.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.MarkerId = objcc_WorkStuRelationEN.MarkerId == "[null]" ? null :  objcc_WorkStuRelationEN.MarkerId; //打分者
}
if (arrFldSet.Contains(concc_WorkStuRelation.MarkDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.MarkDate = objcc_WorkStuRelationEN.MarkDate == "[null]" ? null :  objcc_WorkStuRelationEN.MarkDate; //打分日期
}
if (arrFldSet.Contains(concc_WorkStuRelation.IsSendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IsSendBack = objcc_WorkStuRelationEN.IsSendBack; //是否退回
}
if (arrFldSet.Contains(concc_WorkStuRelation.IsInErrorQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IsInErrorQuestion = objcc_WorkStuRelationEN.IsInErrorQuestion; //是否进入错题
}
if (arrFldSet.Contains(concc_WorkStuRelation.WorkTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.WorkTypeId = objcc_WorkStuRelationEN.WorkTypeId; //作业类型Id
}
if (arrFldSet.Contains(concc_WorkStuRelation.AnswerIP, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.AnswerIP = objcc_WorkStuRelationEN.AnswerIP == "[null]" ? null :  objcc_WorkStuRelationEN.AnswerIP; //回答IP
}
if (arrFldSet.Contains(concc_WorkStuRelation.AnswerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.AnswerDate = objcc_WorkStuRelationEN.AnswerDate == "[null]" ? null :  objcc_WorkStuRelationEN.AnswerDate; //回答日期
}
if (arrFldSet.Contains(concc_WorkStuRelation.AnswerTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.AnswerTime = objcc_WorkStuRelationEN.AnswerTime == "[null]" ? null :  objcc_WorkStuRelationEN.AnswerTime; //回答时间
}
if (arrFldSet.Contains(concc_WorkStuRelation.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.CourseExamPaperId = objcc_WorkStuRelationEN.CourseExamPaperId == "[null]" ? null :  objcc_WorkStuRelationEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(concc_WorkStuRelation.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IsRight = objcc_WorkStuRelationEN.IsRight; //是否正确
}
if (arrFldSet.Contains(concc_WorkStuRelation.IsAccessKnowledge, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IsAccessKnowledge = objcc_WorkStuRelationEN.IsAccessKnowledge; //是否处理知识点
}
if (arrFldSet.Contains(concc_WorkStuRelation.IsNotProcessTimeout, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.IsNotProcessTimeout = objcc_WorkStuRelationEN.IsNotProcessTimeout; //是否不处理超时
}
if (arrFldSet.Contains(concc_WorkStuRelation.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.SchoolYear = objcc_WorkStuRelationEN.SchoolYear == "[null]" ? null :  objcc_WorkStuRelationEN.SchoolYear; //学年
}
if (arrFldSet.Contains(concc_WorkStuRelation.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.SchoolTerm = objcc_WorkStuRelationEN.SchoolTerm == "[null]" ? null :  objcc_WorkStuRelationEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(concc_WorkStuRelation.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.ErrMsg = objcc_WorkStuRelationEN.ErrMsg == "[null]" ? null :  objcc_WorkStuRelationEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(concc_WorkStuRelation.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.CourseId = objcc_WorkStuRelationEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_WorkStuRelation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.UpdDate = objcc_WorkStuRelationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_WorkStuRelation.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.UpdUserId = objcc_WorkStuRelationEN.UpdUserId == "[null]" ? null :  objcc_WorkStuRelationEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_WorkStuRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelationEN.Memo = objcc_WorkStuRelationEN.Memo == "[null]" ? null :  objcc_WorkStuRelationEN.Memo; //备注
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
 /// <param name = "objcc_WorkStuRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
try
{
if (objcc_WorkStuRelationEN.AnswerModeId == "[null]") objcc_WorkStuRelationEN.AnswerModeId = null; //答案模式Id
if (objcc_WorkStuRelationEN.AnswerOptionId == "[null]") objcc_WorkStuRelationEN.AnswerOptionId = null; //回答选项Id
if (objcc_WorkStuRelationEN.AnswerMultiOptions == "[null]") objcc_WorkStuRelationEN.AnswerMultiOptions = null; //多选项答案
if (objcc_WorkStuRelationEN.StuAnswerText == "[null]") objcc_WorkStuRelationEN.StuAnswerText = null; //学生回答文本
if (objcc_WorkStuRelationEN.ApplySendBackDate == "[null]") objcc_WorkStuRelationEN.ApplySendBackDate = null; //申请退回日期
if (objcc_WorkStuRelationEN.RealFinishDate == "[null]") objcc_WorkStuRelationEN.RealFinishDate = null; //实际完成日期
if (objcc_WorkStuRelationEN.OperateTime == "[null]") objcc_WorkStuRelationEN.OperateTime = null; //操作时间
if (objcc_WorkStuRelationEN.Comment == "[null]") objcc_WorkStuRelationEN.Comment = null; //批注
if (objcc_WorkStuRelationEN.MarkerId == "[null]") objcc_WorkStuRelationEN.MarkerId = null; //打分者
if (objcc_WorkStuRelationEN.MarkDate == "[null]") objcc_WorkStuRelationEN.MarkDate = null; //打分日期
if (objcc_WorkStuRelationEN.AnswerIP == "[null]") objcc_WorkStuRelationEN.AnswerIP = null; //回答IP
if (objcc_WorkStuRelationEN.AnswerDate == "[null]") objcc_WorkStuRelationEN.AnswerDate = null; //回答日期
if (objcc_WorkStuRelationEN.AnswerTime == "[null]") objcc_WorkStuRelationEN.AnswerTime = null; //回答时间
if (objcc_WorkStuRelationEN.CourseExamPaperId == "[null]") objcc_WorkStuRelationEN.CourseExamPaperId = null; //考卷流水号
if (objcc_WorkStuRelationEN.SchoolYear == "[null]") objcc_WorkStuRelationEN.SchoolYear = null; //学年
if (objcc_WorkStuRelationEN.SchoolTerm == "[null]") objcc_WorkStuRelationEN.SchoolTerm = null; //学期
if (objcc_WorkStuRelationEN.ErrMsg == "[null]") objcc_WorkStuRelationEN.ErrMsg = null; //错误信息
if (objcc_WorkStuRelationEN.UpdUserId == "[null]") objcc_WorkStuRelationEN.UpdUserId = null; //修改用户Id
if (objcc_WorkStuRelationEN.Memo == "[null]") objcc_WorkStuRelationEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
 cc_WorkStuRelationDA.CheckPropertyNew(objcc_WorkStuRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
 cc_WorkStuRelationDA.CheckProperty4Condition(objcc_WorkStuRelationEN);
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
if (clscc_WorkStuRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelationBL没有刷新缓存机制(clscc_WorkStuRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdWorkStuRelation");
//if (arrcc_WorkStuRelationObjLstCache == null)
//{
//arrcc_WorkStuRelationObjLstCache = cc_WorkStuRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdWorkStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkStuRelationEN GetObjByIdWorkStuRelationCache(long lngIdWorkStuRelation)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_WorkStuRelationEN._CurrTabName);
List<clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLst_Sel =
arrcc_WorkStuRelationObjLstCache
.Where(x=> x.IdWorkStuRelation == lngIdWorkStuRelation 
);
if (arrcc_WorkStuRelationObjLst_Sel.Count() == 0)
{
   clscc_WorkStuRelationEN obj = clscc_WorkStuRelationBL.GetObjByIdWorkStuRelation(lngIdWorkStuRelation);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_WorkStuRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkStuRelationEN> GetAllcc_WorkStuRelationObjLstCache()
{
//获取缓存中的对象列表
List<clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLstCache = GetObjLstCache(); 
return arrcc_WorkStuRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkStuRelationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_WorkStuRelationEN._CurrTabName);
List<clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_WorkStuRelationObjLstCache;
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
string strKey = string.Format("{0}", clscc_WorkStuRelationEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_WorkStuRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_WorkStuRelationEN._RefreshTimeLst.Count == 0) return "";
return clscc_WorkStuRelationEN._RefreshTimeLst[clscc_WorkStuRelationEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_WorkStuRelationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_WorkStuRelationEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_WorkStuRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_WorkStuRelationBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_WorkStuRelation(作业与学生关系)
 /// 唯一性条件:id_CurrEduCls_QuestionID_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
//检测记录是否存在
string strResult = cc_WorkStuRelationDA.GetUniCondStr(objcc_WorkStuRelationEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdWorkStuRelation)
{
if (strInFldName != concc_WorkStuRelation.IdWorkStuRelation)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_WorkStuRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_WorkStuRelation.AttributeName));
throw new Exception(strMsg);
}
var objcc_WorkStuRelation = clscc_WorkStuRelationBL.GetObjByIdWorkStuRelationCache(lngIdWorkStuRelation);
if (objcc_WorkStuRelation == null) return "";
return objcc_WorkStuRelation[strOutFldName].ToString();
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
int intRecCount = clscc_WorkStuRelationDA.GetRecCount(strTabName);
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
int intRecCount = clscc_WorkStuRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_WorkStuRelationDA.GetRecCount();
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
int intRecCount = clscc_WorkStuRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_WorkStuRelationEN objcc_WorkStuRelationCond)
{
List<clscc_WorkStuRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkStuRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_WorkStuRelation.AttributeName)
{
if (objcc_WorkStuRelationCond.IsUpdated(strFldName) == false) continue;
if (objcc_WorkStuRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelationCond[strFldName].ToString());
}
else
{
if (objcc_WorkStuRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_WorkStuRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_WorkStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_WorkStuRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelationCond[strFldName]));
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
 List<string> arrList = clscc_WorkStuRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_WorkStuRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_WorkStuRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_WorkStuRelationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelationDA.SetFldValue(clscc_WorkStuRelationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_WorkStuRelationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_WorkStuRelation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**流水号*/ 
 strCreateTabCode.Append(" IdWorkStuRelation bigint primary key identity, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint not Null, "); 
 // /**分值*/ 
 strCreateTabCode.Append(" Scores decimal(8,2) Null, "); 
 // /**指定完成日期*/ 
 strCreateTabCode.Append(" SpecifyCompletionDate varchar(14) not Null, "); 
 // /**学生流水号*/ 
 strCreateTabCode.Append(" IdStudentInfo char(8) not Null, "); 
 // /**答案模式Id*/ 
 strCreateTabCode.Append(" AnswerModeId char(4) Null, "); 
 // /**回答选项Id*/ 
 strCreateTabCode.Append(" AnswerOptionId char(8) Null, "); 
 // /**多选项答案*/ 
 strCreateTabCode.Append(" AnswerMultiOptions varchar(300) Null, "); 
 // /**答案布尔结果*/ 
 strCreateTabCode.Append(" AnswerBoolResult bit Null, "); 
 // /**学生回答文本*/ 
 strCreateTabCode.Append(" StuAnswerText text Null, "); 
 // /**是否发布*/ 
 strCreateTabCode.Append(" IsPublish bit Null, "); 
 // /**是否查看*/ 
 strCreateTabCode.Append(" IsLook bit Null, "); 
 // /**是否保存*/ 
 strCreateTabCode.Append(" IsSave bit Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**申请退回日期*/ 
 strCreateTabCode.Append(" ApplySendBackDate varchar(14) Null, "); 
 // /**是否申请退回*/ 
 strCreateTabCode.Append(" IsApplySendBack bit Null, "); 
 // /**实际完成日期*/ 
 strCreateTabCode.Append(" RealFinishDate varchar(14) Null, "); 
 // /**操作时间*/ 
 strCreateTabCode.Append(" OperateTime varchar(14) Null, "); 
 // /**得分*/ 
 strCreateTabCode.Append(" Score decimal(6,1) Null, "); 
 // /**批注*/ 
 strCreateTabCode.Append(" Comment text Null, "); 
 // /**是否批阅*/ 
 strCreateTabCode.Append(" IsMarking bit Null, "); 
 // /**打分者*/ 
 strCreateTabCode.Append(" MarkerId varchar(20) Null, "); 
 // /**打分日期*/ 
 strCreateTabCode.Append(" MarkDate varchar(14) Null, "); 
 // /**是否退回*/ 
 strCreateTabCode.Append(" IsSendBack bit Null, "); 
 // /**是否进入错题*/ 
 strCreateTabCode.Append(" IsInErrorQuestion bit Null, "); 
 // /**作业类型Id*/ 
 strCreateTabCode.Append(" WorkTypeId char(2) not Null, "); 
 // /**回答IP*/ 
 strCreateTabCode.Append(" AnswerIP varchar(30) Null, "); 
 // /**回答日期*/ 
 strCreateTabCode.Append(" AnswerDate varchar(8) Null, "); 
 // /**回答时间*/ 
 strCreateTabCode.Append(" AnswerTime varchar(10) Null, "); 
 // /**考卷流水号*/ 
 strCreateTabCode.Append(" CourseExamPaperId char(8) Null, "); 
 // /**是否正确*/ 
 strCreateTabCode.Append(" IsRight bit Null, "); 
 // /**是否处理知识点*/ 
 strCreateTabCode.Append(" IsAccessKnowledge bit Null, "); 
 // /**是否不处理超时*/ 
 strCreateTabCode.Append(" IsNotProcessTimeout bit Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(200) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
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
 /// 作业与学生关系(cc_WorkStuRelation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_WorkStuRelation : clsCommFun4BL
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
clscc_WorkStuRelationBL.ReFreshThisCache();
}
}

}