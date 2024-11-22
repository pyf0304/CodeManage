
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperStuRelationBL
 表名:cc_ExamPaperStuRelation(01120235)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:42
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
public static class  clscc_ExamPaperStuRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdExamPaperStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperStuRelationEN GetObj(this K_IdExamPaperStuRelation_cc_ExamPaperStuRelation myKey)
{
clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = clscc_ExamPaperStuRelationBL.cc_ExamPaperStuRelationDA.GetObjByIdExamPaperStuRelation(myKey.Value);
return objcc_ExamPaperStuRelationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_ExamPaperStuRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],学生流水号 = [{1}],教学班流水号 = [{2}]的数据已经存在!(in clscc_ExamPaperStuRelationBL.AddNewRecord)", objcc_ExamPaperStuRelationEN.CourseExamPaperId,objcc_ExamPaperStuRelationEN.IdStudentInfo,objcc_ExamPaperStuRelationEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
bool bolResult = clscc_ExamPaperStuRelationBL.cc_ExamPaperStuRelationDA.AddNewRecordBySQL2(objcc_ExamPaperStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationBL.ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsNeedCheckUniqueness = true)
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
objcc_ExamPaperStuRelationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_ExamPaperStuRelationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(考卷流水号(CourseExamPaperId)=[{0}],学生流水号(IdStudentInfo)=[{1}],教学班流水号(IdCurrEduCls)=[{2}])已经存在,不能重复!", objcc_ExamPaperStuRelationEN.CourseExamPaperId, objcc_ExamPaperStuRelationEN.IdStudentInfo, objcc_ExamPaperStuRelationEN.IdCurrEduCls);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objcc_ExamPaperStuRelationEN.AddNewRecord();
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_ExamPaperStuRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],学生流水号 = [{1}],教学班流水号 = [{2}]的数据已经存在!(in clscc_ExamPaperStuRelationBL.AddNewRecordWithReturnKey)", objcc_ExamPaperStuRelationEN.CourseExamPaperId,objcc_ExamPaperStuRelationEN.IdStudentInfo,objcc_ExamPaperStuRelationEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
string strKey = clscc_ExamPaperStuRelationBL.cc_ExamPaperStuRelationDA.AddNewRecordBySQL2WithReturnKey(objcc_ExamPaperStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationBL.ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIdExamPaperStuRelation(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, long lngIdExamPaperStuRelation, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = lngIdExamPaperStuRelation; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IdExamPaperStuRelation) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IdExamPaperStuRelation, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IdExamPaperStuRelation] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetCourseExamPaperId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_ExamPaperStuRelation.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_ExamPaperStuRelation.CourseExamPaperId);
}
objcc_ExamPaperStuRelationEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.CourseExamPaperId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIdCurrEduCls(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, concc_ExamPaperStuRelation.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, concc_ExamPaperStuRelation.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, concc_ExamPaperStuRelation.IdCurrEduCls);
}
objcc_ExamPaperStuRelationEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IdCurrEduCls) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IdCurrEduCls, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IdCurrEduCls] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetScores(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, double? dblScores, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.Scores) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.Scores, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.Scores] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetSpecifyCompletionDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, concc_ExamPaperStuRelation.SpecifyCompletionDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, concc_ExamPaperStuRelation.SpecifyCompletionDate);
}
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.SpecifyCompletionDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.SpecifyCompletionDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.SpecifyCompletionDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIdStudentInfo(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, concc_ExamPaperStuRelation.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, concc_ExamPaperStuRelation.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, concc_ExamPaperStuRelation.IdStudentInfo);
}
objcc_ExamPaperStuRelationEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IdStudentInfo) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IdStudentInfo, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IdStudentInfo] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerModeId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, concc_ExamPaperStuRelation.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, concc_ExamPaperStuRelation.AnswerModeId);
}
objcc_ExamPaperStuRelationEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerModeId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerModeId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerModeId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerOptionId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, concc_ExamPaperStuRelation.AnswerOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, concc_ExamPaperStuRelation.AnswerOptionId);
}
objcc_ExamPaperStuRelationEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerOptionId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerOptionId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerOptionId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerMultiOptions(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, concc_ExamPaperStuRelation.AnswerMultiOptions);
}
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerMultiOptions) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerMultiOptions, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerMultiOptions] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetStuAnswerText(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strStuAnswerText, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.StuAnswerText) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.StuAnswerText, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.StuAnswerText] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsPublish(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsPublish, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsPublish) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsPublish, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsPublish] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsLook(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsLook, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsLook) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsLook, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsLook] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsSave(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsSave, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsSave) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsSave, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsSave] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsSubmit(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsSubmit, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsSubmit) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsSubmit, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsSubmit] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetApplySendBackDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strApplySendBackDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, concc_ExamPaperStuRelation.ApplySendBackDate);
}
objcc_ExamPaperStuRelationEN.ApplySendBackDate = strApplySendBackDate; //申请退回日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.ApplySendBackDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.ApplySendBackDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.ApplySendBackDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsApplySendBack(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsApplySendBack, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsApplySendBack = bolIsApplySendBack; //是否申请退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsApplySendBack) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsApplySendBack, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsApplySendBack] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetRealFinishDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strRealFinishDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, concc_ExamPaperStuRelation.RealFinishDate);
}
objcc_ExamPaperStuRelationEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.RealFinishDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.RealFinishDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.RealFinishDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetOperateTime(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strOperateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperateTime, 14, concc_ExamPaperStuRelation.OperateTime);
}
objcc_ExamPaperStuRelationEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.OperateTime) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.OperateTime, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.OperateTime] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetScore(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, double? dblScore, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.Score) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.Score, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.Score] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetComment(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strComment, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.Comment) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.Comment, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.Comment] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsMarking(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsMarking, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsMarking) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsMarking, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsMarking] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetMarkerId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, concc_ExamPaperStuRelation.MarkerId);
}
objcc_ExamPaperStuRelationEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.MarkerId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.MarkerId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.MarkerId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetMarkDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strMarkDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkDate, 14, concc_ExamPaperStuRelation.MarkDate);
}
objcc_ExamPaperStuRelationEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.MarkDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.MarkDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.MarkDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsSendBack(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsSendBack, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsSendBack) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsSendBack, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsSendBack] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsInErrorQuestion(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsInErrorQuestion) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsInErrorQuestion, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsInErrorQuestion] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetWorkTypeId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, concc_ExamPaperStuRelation.WorkTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, concc_ExamPaperStuRelation.WorkTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, concc_ExamPaperStuRelation.WorkTypeId);
}
objcc_ExamPaperStuRelationEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.WorkTypeId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.WorkTypeId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.WorkTypeId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerIP(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerIP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, concc_ExamPaperStuRelation.AnswerIP);
}
objcc_ExamPaperStuRelationEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerIP) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerIP, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerIP] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, concc_ExamPaperStuRelation.AnswerDate);
}
objcc_ExamPaperStuRelationEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetAnswerTime(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strAnswerTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, concc_ExamPaperStuRelation.AnswerTime);
}
objcc_ExamPaperStuRelationEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.AnswerTime) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.AnswerTime, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerTime] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsRight(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsRight, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsRight) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsRight, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsRight] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsAccessKnowledge(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsAccessKnowledge) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsAccessKnowledge, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsAccessKnowledge] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetIsNotProcessTimeout(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.IsNotProcessTimeout) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.IsNotProcessTimeout, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.IsNotProcessTimeout] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetSchoolYear(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, concc_ExamPaperStuRelation.SchoolYear);
}
objcc_ExamPaperStuRelationEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.SchoolYear) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.SchoolYear, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.SchoolYear] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetSchoolTerm(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, concc_ExamPaperStuRelation.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, concc_ExamPaperStuRelation.SchoolTerm);
}
objcc_ExamPaperStuRelationEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.SchoolTerm) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.SchoolTerm, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.SchoolTerm] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetUpdDate(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_ExamPaperStuRelation.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_ExamPaperStuRelation.UpdDate);
}
objcc_ExamPaperStuRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.UpdDate) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.UpdDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.UpdDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetUpdUserId(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_ExamPaperStuRelation.UpdUserId);
}
objcc_ExamPaperStuRelationEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.UpdUserId) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.UpdUserId, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.UpdUserId] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuRelationEN SetMemo(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_ExamPaperStuRelation.Memo);
}
objcc_ExamPaperStuRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuRelation.Memo) == false)
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(concc_ExamPaperStuRelation.Memo, strComparisonOp);
}
else
{
objcc_ExamPaperStuRelationEN.dicFldComparisonOp[concc_ExamPaperStuRelation.Memo] = strComparisonOp;
}
}
return objcc_ExamPaperStuRelationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_ExamPaperStuRelationEN.CheckPropertyNew();
clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationCond = new clscc_ExamPaperStuRelationEN();
string strCondition = objcc_ExamPaperStuRelationCond
.SetIdExamPaperStuRelation(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, "<>")
.SetCourseExamPaperId(objcc_ExamPaperStuRelationEN.CourseExamPaperId, "=")
.SetIdStudentInfo(objcc_ExamPaperStuRelationEN.IdStudentInfo, "=")
.SetIdCurrEduCls(objcc_ExamPaperStuRelationEN.IdCurrEduCls, "=")
.GetCombineCondition();
objcc_ExamPaperStuRelationEN._IsCheckProperty = true;
bool bolIsExist = clscc_ExamPaperStuRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CourseExamPaperId_id_StudentInfo_id_CurrEduCls)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_ExamPaperStuRelationEN.Update();
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
 /// <param name = "objcc_ExamPaperStuRelation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationCond = new clscc_ExamPaperStuRelationEN();
string strCondition = objcc_ExamPaperStuRelationCond
.SetCourseExamPaperId(objcc_ExamPaperStuRelation.CourseExamPaperId, "=")
.SetIdStudentInfo(objcc_ExamPaperStuRelation.IdStudentInfo, "=")
.SetIdCurrEduCls(objcc_ExamPaperStuRelation.IdCurrEduCls, "=")
.GetCombineCondition();
objcc_ExamPaperStuRelation._IsCheckProperty = true;
bool bolIsExist = clscc_ExamPaperStuRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_ExamPaperStuRelation.IdExamPaperStuRelation = clscc_ExamPaperStuRelationBL.GetFirstID_S(strCondition);
objcc_ExamPaperStuRelation.UpdateWithCondition(strCondition);
}
else
{
objcc_ExamPaperStuRelation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
 if (objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_ExamPaperStuRelationBL.cc_ExamPaperStuRelationDA.UpdateBySql2(objcc_ExamPaperStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationBL.ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_ExamPaperStuRelationBL.cc_ExamPaperStuRelationDA.UpdateBySql2(objcc_ExamPaperStuRelationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationBL.ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strWhereCond)
{
try
{
bool bolResult = clscc_ExamPaperStuRelationBL.cc_ExamPaperStuRelationDA.UpdateBySqlWithCondition(objcc_ExamPaperStuRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationBL.ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_ExamPaperStuRelationBL.cc_ExamPaperStuRelationDA.UpdateBySqlWithConditionTransaction(objcc_ExamPaperStuRelationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationBL.ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
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
 /// <param name = "lngIdExamPaperStuRelation">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
try
{
int intRecNum = clscc_ExamPaperStuRelationBL.cc_ExamPaperStuRelationDA.DelRecord(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationBL.ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuRelationENS">源对象</param>
 /// <param name = "objcc_ExamPaperStuRelationENT">目标对象</param>
 public static void CopyTo(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationENS, clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationENT)
{
try
{
objcc_ExamPaperStuRelationENT.IdExamPaperStuRelation = objcc_ExamPaperStuRelationENS.IdExamPaperStuRelation; //流水号
objcc_ExamPaperStuRelationENT.CourseExamPaperId = objcc_ExamPaperStuRelationENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperStuRelationENT.IdCurrEduCls = objcc_ExamPaperStuRelationENS.IdCurrEduCls; //教学班流水号
objcc_ExamPaperStuRelationENT.Scores = objcc_ExamPaperStuRelationENS.Scores; //分值
objcc_ExamPaperStuRelationENT.SpecifyCompletionDate = objcc_ExamPaperStuRelationENS.SpecifyCompletionDate; //指定完成日期
objcc_ExamPaperStuRelationENT.IdStudentInfo = objcc_ExamPaperStuRelationENS.IdStudentInfo; //学生流水号
objcc_ExamPaperStuRelationENT.AnswerModeId = objcc_ExamPaperStuRelationENS.AnswerModeId; //答案模式Id
objcc_ExamPaperStuRelationENT.AnswerOptionId = objcc_ExamPaperStuRelationENS.AnswerOptionId; //回答选项Id
objcc_ExamPaperStuRelationENT.AnswerMultiOptions = objcc_ExamPaperStuRelationENS.AnswerMultiOptions; //多选项答案
objcc_ExamPaperStuRelationENT.StuAnswerText = objcc_ExamPaperStuRelationENS.StuAnswerText; //学生回答文本
objcc_ExamPaperStuRelationENT.IsPublish = objcc_ExamPaperStuRelationENS.IsPublish; //是否发布
objcc_ExamPaperStuRelationENT.IsLook = objcc_ExamPaperStuRelationENS.IsLook; //是否查看
objcc_ExamPaperStuRelationENT.IsSave = objcc_ExamPaperStuRelationENS.IsSave; //是否保存
objcc_ExamPaperStuRelationENT.IsSubmit = objcc_ExamPaperStuRelationENS.IsSubmit; //是否提交
objcc_ExamPaperStuRelationENT.ApplySendBackDate = objcc_ExamPaperStuRelationENS.ApplySendBackDate; //申请退回日期
objcc_ExamPaperStuRelationENT.IsApplySendBack = objcc_ExamPaperStuRelationENS.IsApplySendBack; //是否申请退回
objcc_ExamPaperStuRelationENT.RealFinishDate = objcc_ExamPaperStuRelationENS.RealFinishDate; //实际完成日期
objcc_ExamPaperStuRelationENT.OperateTime = objcc_ExamPaperStuRelationENS.OperateTime; //操作时间
objcc_ExamPaperStuRelationENT.Score = objcc_ExamPaperStuRelationENS.Score; //得分
objcc_ExamPaperStuRelationENT.Comment = objcc_ExamPaperStuRelationENS.Comment; //批注
objcc_ExamPaperStuRelationENT.IsMarking = objcc_ExamPaperStuRelationENS.IsMarking; //是否批阅
objcc_ExamPaperStuRelationENT.MarkerId = objcc_ExamPaperStuRelationENS.MarkerId; //打分者
objcc_ExamPaperStuRelationENT.MarkDate = objcc_ExamPaperStuRelationENS.MarkDate; //打分日期
objcc_ExamPaperStuRelationENT.IsSendBack = objcc_ExamPaperStuRelationENS.IsSendBack; //是否退回
objcc_ExamPaperStuRelationENT.IsInErrorQuestion = objcc_ExamPaperStuRelationENS.IsInErrorQuestion; //是否进入错题
objcc_ExamPaperStuRelationENT.WorkTypeId = objcc_ExamPaperStuRelationENS.WorkTypeId; //作业类型Id
objcc_ExamPaperStuRelationENT.AnswerIP = objcc_ExamPaperStuRelationENS.AnswerIP; //回答IP
objcc_ExamPaperStuRelationENT.AnswerDate = objcc_ExamPaperStuRelationENS.AnswerDate; //回答日期
objcc_ExamPaperStuRelationENT.AnswerTime = objcc_ExamPaperStuRelationENS.AnswerTime; //回答时间
objcc_ExamPaperStuRelationENT.IsRight = objcc_ExamPaperStuRelationENS.IsRight; //是否正确
objcc_ExamPaperStuRelationENT.IsAccessKnowledge = objcc_ExamPaperStuRelationENS.IsAccessKnowledge; //是否处理知识点
objcc_ExamPaperStuRelationENT.IsNotProcessTimeout = objcc_ExamPaperStuRelationENS.IsNotProcessTimeout; //是否不处理超时
objcc_ExamPaperStuRelationENT.SchoolYear = objcc_ExamPaperStuRelationENS.SchoolYear; //学年
objcc_ExamPaperStuRelationENT.SchoolTerm = objcc_ExamPaperStuRelationENS.SchoolTerm; //学期
objcc_ExamPaperStuRelationENT.UpdDate = objcc_ExamPaperStuRelationENS.UpdDate; //修改日期
objcc_ExamPaperStuRelationENT.UpdUserId = objcc_ExamPaperStuRelationENS.UpdUserId; //修改用户Id
objcc_ExamPaperStuRelationENT.Memo = objcc_ExamPaperStuRelationENS.Memo; //备注
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
 /// <param name = "objcc_ExamPaperStuRelationENS">源对象</param>
 /// <returns>目标对象=>clscc_ExamPaperStuRelationEN:objcc_ExamPaperStuRelationENT</returns>
 public static clscc_ExamPaperStuRelationEN CopyTo(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationENS)
{
try
{
 clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationENT = new clscc_ExamPaperStuRelationEN()
{
IdExamPaperStuRelation = objcc_ExamPaperStuRelationENS.IdExamPaperStuRelation, //流水号
CourseExamPaperId = objcc_ExamPaperStuRelationENS.CourseExamPaperId, //考卷流水号
IdCurrEduCls = objcc_ExamPaperStuRelationENS.IdCurrEduCls, //教学班流水号
Scores = objcc_ExamPaperStuRelationENS.Scores, //分值
SpecifyCompletionDate = objcc_ExamPaperStuRelationENS.SpecifyCompletionDate, //指定完成日期
IdStudentInfo = objcc_ExamPaperStuRelationENS.IdStudentInfo, //学生流水号
AnswerModeId = objcc_ExamPaperStuRelationENS.AnswerModeId, //答案模式Id
AnswerOptionId = objcc_ExamPaperStuRelationENS.AnswerOptionId, //回答选项Id
AnswerMultiOptions = objcc_ExamPaperStuRelationENS.AnswerMultiOptions, //多选项答案
StuAnswerText = objcc_ExamPaperStuRelationENS.StuAnswerText, //学生回答文本
IsPublish = objcc_ExamPaperStuRelationENS.IsPublish, //是否发布
IsLook = objcc_ExamPaperStuRelationENS.IsLook, //是否查看
IsSave = objcc_ExamPaperStuRelationENS.IsSave, //是否保存
IsSubmit = objcc_ExamPaperStuRelationENS.IsSubmit, //是否提交
ApplySendBackDate = objcc_ExamPaperStuRelationENS.ApplySendBackDate, //申请退回日期
IsApplySendBack = objcc_ExamPaperStuRelationENS.IsApplySendBack, //是否申请退回
RealFinishDate = objcc_ExamPaperStuRelationENS.RealFinishDate, //实际完成日期
OperateTime = objcc_ExamPaperStuRelationENS.OperateTime, //操作时间
Score = objcc_ExamPaperStuRelationENS.Score, //得分
Comment = objcc_ExamPaperStuRelationENS.Comment, //批注
IsMarking = objcc_ExamPaperStuRelationENS.IsMarking, //是否批阅
MarkerId = objcc_ExamPaperStuRelationENS.MarkerId, //打分者
MarkDate = objcc_ExamPaperStuRelationENS.MarkDate, //打分日期
IsSendBack = objcc_ExamPaperStuRelationENS.IsSendBack, //是否退回
IsInErrorQuestion = objcc_ExamPaperStuRelationENS.IsInErrorQuestion, //是否进入错题
WorkTypeId = objcc_ExamPaperStuRelationENS.WorkTypeId, //作业类型Id
AnswerIP = objcc_ExamPaperStuRelationENS.AnswerIP, //回答IP
AnswerDate = objcc_ExamPaperStuRelationENS.AnswerDate, //回答日期
AnswerTime = objcc_ExamPaperStuRelationENS.AnswerTime, //回答时间
IsRight = objcc_ExamPaperStuRelationENS.IsRight, //是否正确
IsAccessKnowledge = objcc_ExamPaperStuRelationENS.IsAccessKnowledge, //是否处理知识点
IsNotProcessTimeout = objcc_ExamPaperStuRelationENS.IsNotProcessTimeout, //是否不处理超时
SchoolYear = objcc_ExamPaperStuRelationENS.SchoolYear, //学年
SchoolTerm = objcc_ExamPaperStuRelationENS.SchoolTerm, //学期
UpdDate = objcc_ExamPaperStuRelationENS.UpdDate, //修改日期
UpdUserId = objcc_ExamPaperStuRelationENS.UpdUserId, //修改用户Id
Memo = objcc_ExamPaperStuRelationENS.Memo, //备注
};
 return objcc_ExamPaperStuRelationENT;
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
public static void CheckPropertyNew(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
 clscc_ExamPaperStuRelationBL.cc_ExamPaperStuRelationDA.CheckPropertyNew(objcc_ExamPaperStuRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
 clscc_ExamPaperStuRelationBL.cc_ExamPaperStuRelationDA.CheckProperty4Condition(objcc_ExamPaperStuRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IdExamPaperStuRelation) == true)
{
string strComparisonOpIdExamPaperStuRelation = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.IdExamPaperStuRelation];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperStuRelation.IdExamPaperStuRelation, objcc_ExamPaperStuRelationCond.IdExamPaperStuRelation, strComparisonOpIdExamPaperStuRelation);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.CourseExamPaperId, objcc_ExamPaperStuRelationCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.IdCurrEduCls, objcc_ExamPaperStuRelationCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.Scores) == true)
{
string strComparisonOpScores = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperStuRelation.Scores, objcc_ExamPaperStuRelationCond.Scores, strComparisonOpScores);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.SpecifyCompletionDate) == true)
{
string strComparisonOpSpecifyCompletionDate = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.SpecifyCompletionDate, objcc_ExamPaperStuRelationCond.SpecifyCompletionDate, strComparisonOpSpecifyCompletionDate);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.IdStudentInfo, objcc_ExamPaperStuRelationCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerModeId, objcc_ExamPaperStuRelationCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.AnswerOptionId) == true)
{
string strComparisonOpAnswerOptionId = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerOptionId, objcc_ExamPaperStuRelationCond.AnswerOptionId, strComparisonOpAnswerOptionId);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.AnswerMultiOptions) == true)
{
string strComparisonOpAnswerMultiOptions = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerMultiOptions, objcc_ExamPaperStuRelationCond.AnswerMultiOptions, strComparisonOpAnswerMultiOptions);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IsPublish) == true)
{
if (objcc_ExamPaperStuRelationCond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsPublish);
}
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IsLook) == true)
{
if (objcc_ExamPaperStuRelationCond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsLook);
}
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IsSave) == true)
{
if (objcc_ExamPaperStuRelationCond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsSave);
}
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IsSubmit) == true)
{
if (objcc_ExamPaperStuRelationCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsSubmit);
}
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.ApplySendBackDate) == true)
{
string strComparisonOpApplySendBackDate = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.ApplySendBackDate, objcc_ExamPaperStuRelationCond.ApplySendBackDate, strComparisonOpApplySendBackDate);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IsApplySendBack) == true)
{
if (objcc_ExamPaperStuRelationCond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsApplySendBack);
}
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.RealFinishDate) == true)
{
string strComparisonOpRealFinishDate = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.RealFinishDate, objcc_ExamPaperStuRelationCond.RealFinishDate, strComparisonOpRealFinishDate);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.OperateTime) == true)
{
string strComparisonOpOperateTime = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.OperateTime, objcc_ExamPaperStuRelationCond.OperateTime, strComparisonOpOperateTime);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.Score) == true)
{
string strComparisonOpScore = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.Score];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperStuRelation.Score, objcc_ExamPaperStuRelationCond.Score, strComparisonOpScore);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IsMarking) == true)
{
if (objcc_ExamPaperStuRelationCond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsMarking);
}
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.MarkerId) == true)
{
string strComparisonOpMarkerId = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.MarkerId, objcc_ExamPaperStuRelationCond.MarkerId, strComparisonOpMarkerId);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.MarkDate) == true)
{
string strComparisonOpMarkDate = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.MarkDate, objcc_ExamPaperStuRelationCond.MarkDate, strComparisonOpMarkDate);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IsSendBack) == true)
{
if (objcc_ExamPaperStuRelationCond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsSendBack);
}
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IsInErrorQuestion) == true)
{
if (objcc_ExamPaperStuRelationCond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsInErrorQuestion);
}
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.WorkTypeId) == true)
{
string strComparisonOpWorkTypeId = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.WorkTypeId, objcc_ExamPaperStuRelationCond.WorkTypeId, strComparisonOpWorkTypeId);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.AnswerIP) == true)
{
string strComparisonOpAnswerIP = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerIP, objcc_ExamPaperStuRelationCond.AnswerIP, strComparisonOpAnswerIP);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.AnswerDate) == true)
{
string strComparisonOpAnswerDate = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerDate, objcc_ExamPaperStuRelationCond.AnswerDate, strComparisonOpAnswerDate);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.AnswerTime) == true)
{
string strComparisonOpAnswerTime = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.AnswerTime, objcc_ExamPaperStuRelationCond.AnswerTime, strComparisonOpAnswerTime);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IsRight) == true)
{
if (objcc_ExamPaperStuRelationCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsRight);
}
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IsAccessKnowledge) == true)
{
if (objcc_ExamPaperStuRelationCond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsAccessKnowledge);
}
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.IsNotProcessTimeout) == true)
{
if (objcc_ExamPaperStuRelationCond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuRelation.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuRelation.IsNotProcessTimeout);
}
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.SchoolYear, objcc_ExamPaperStuRelationCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.SchoolTerm, objcc_ExamPaperStuRelationCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.UpdDate, objcc_ExamPaperStuRelationCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.UpdUserId, objcc_ExamPaperStuRelationCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_ExamPaperStuRelationCond.IsUpdated(concc_ExamPaperStuRelation.Memo) == true)
{
string strComparisonOpMemo = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[concc_ExamPaperStuRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuRelation.Memo, objcc_ExamPaperStuRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_ExamPaperStuRelation(考卷与学生关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseExamPaperId_id_StudentInfo_id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_ExamPaperStuRelationEN == null) return true;
if (objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null", objcc_ExamPaperStuRelationEN.CourseExamPaperId);
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuRelationEN.CourseExamPaperId);
}
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_ExamPaperStuRelationEN.IdStudentInfo);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_ExamPaperStuRelationEN.IdCurrEduCls);
if (clscc_ExamPaperStuRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdExamPaperStuRelation !=  {0}", objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuRelationEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_ExamPaperStuRelationEN.IdStudentInfo);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_ExamPaperStuRelationEN.IdCurrEduCls);
if (clscc_ExamPaperStuRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_ExamPaperStuRelation(考卷与学生关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseExamPaperId_id_StudentInfo_id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_ExamPaperStuRelationEN == null) return "";
if (objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_ExamPaperStuRelationEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null", objcc_ExamPaperStuRelationEN.CourseExamPaperId);
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuRelationEN.CourseExamPaperId);
}
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_ExamPaperStuRelationEN.IdStudentInfo);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_ExamPaperStuRelationEN.IdCurrEduCls);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdExamPaperStuRelation !=  {0}", objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuRelationEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_ExamPaperStuRelationEN.IdStudentInfo);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_ExamPaperStuRelationEN.IdCurrEduCls);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_ExamPaperStuRelation
{
public virtual bool UpdRelaTabDate(long lngIdExamPaperStuRelation, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 考卷与学生关系(cc_ExamPaperStuRelation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_ExamPaperStuRelationBL
{
public static RelatedActions_cc_ExamPaperStuRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_ExamPaperStuRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_ExamPaperStuRelationDA cc_ExamPaperStuRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_ExamPaperStuRelationDA();
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
 public clscc_ExamPaperStuRelationBL()
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
if (string.IsNullOrEmpty(clscc_ExamPaperStuRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_ExamPaperStuRelationEN._ConnectString);
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
public static DataTable GetDataTable_cc_ExamPaperStuRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_ExamPaperStuRelationDA.GetDataTable_cc_ExamPaperStuRelation(strWhereCond);
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
objDT = cc_ExamPaperStuRelationDA.GetDataTable(strWhereCond);
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
objDT = cc_ExamPaperStuRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_ExamPaperStuRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_ExamPaperStuRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_ExamPaperStuRelationDA.GetDataTable_Top(objTopPara);
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
objDT = cc_ExamPaperStuRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_ExamPaperStuRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_ExamPaperStuRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdExamPaperStuRelationLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_ExamPaperStuRelationEN> GetObjLstByIdExamPaperStuRelationLst(List<long> arrIdExamPaperStuRelationLst)
{
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdExamPaperStuRelationLst);
 string strWhereCond = string.Format("IdExamPaperStuRelation in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = Int32.Parse(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdExamPaperStuRelationLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_ExamPaperStuRelationEN> GetObjLstByIdExamPaperStuRelationLstCache(List<long> arrIdExamPaperStuRelationLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuRelationEN._CurrTabName, strIdCurrEduCls);
List<clscc_ExamPaperStuRelationEN> arrcc_ExamPaperStuRelationObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clscc_ExamPaperStuRelationEN> arrcc_ExamPaperStuRelationObjLst_Sel =
arrcc_ExamPaperStuRelationObjLstCache
.Where(x => arrIdExamPaperStuRelationLst.Contains(x.IdExamPaperStuRelation));
return arrcc_ExamPaperStuRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperStuRelationEN> GetObjLst(string strWhereCond)
{
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = Int32.Parse(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
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
public static List<clscc_ExamPaperStuRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = Int32.Parse(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_ExamPaperStuRelationEN> GetSubObjLstCache(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationCond)
{
 string strIdCurrEduCls = objcc_ExamPaperStuRelationCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clscc_ExamPaperStuRelationBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clscc_ExamPaperStuRelationEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clscc_ExamPaperStuRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_ExamPaperStuRelation.AttributeName)
{
if (objcc_ExamPaperStuRelationCond.IsUpdated(strFldName) == false) continue;
if (objcc_ExamPaperStuRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperStuRelationCond[strFldName].ToString());
}
else
{
if (objcc_ExamPaperStuRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperStuRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_ExamPaperStuRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperStuRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperStuRelationCond[strFldName]));
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
public static List<clscc_ExamPaperStuRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = Int32.Parse(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
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
public static List<clscc_ExamPaperStuRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = Int32.Parse(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
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
List<clscc_ExamPaperStuRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_ExamPaperStuRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperStuRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_ExamPaperStuRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
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
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = Int32.Parse(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
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
public static List<clscc_ExamPaperStuRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = Int32.Parse(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_ExamPaperStuRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_ExamPaperStuRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = Int32.Parse(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
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
public static List<clscc_ExamPaperStuRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = Int32.Parse(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperStuRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_ExamPaperStuRelationEN> arrObjLst = new List<clscc_ExamPaperStuRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
try
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = Int32.Parse(objRow[concc_ExamPaperStuRelation.IdExamPaperStuRelation].ToString().Trim()); //流水号
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objRow[concc_ExamPaperStuRelation.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objRow[concc_ExamPaperStuRelation.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuRelationEN.Scores = objRow[concc_ExamPaperStuRelation.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objRow[concc_ExamPaperStuRelation.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperStuRelationEN.IdStudentInfo = objRow[concc_ExamPaperStuRelation.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuRelationEN.AnswerModeId = objRow[concc_ExamPaperStuRelation.AnswerModeId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerModeId].ToString().Trim(); //答案模式Id
objcc_ExamPaperStuRelationEN.AnswerOptionId = objRow[concc_ExamPaperStuRelation.AnswerOptionId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerOptionId].ToString().Trim(); //回答选项Id
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objRow[concc_ExamPaperStuRelation.AnswerMultiOptions] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerMultiOptions].ToString().Trim(); //多选项答案
objcc_ExamPaperStuRelationEN.StuAnswerText = objRow[concc_ExamPaperStuRelation.StuAnswerText] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.StuAnswerText].ToString().Trim(); //学生回答文本
objcc_ExamPaperStuRelationEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperStuRelationEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsLook].ToString().Trim()); //是否查看
objcc_ExamPaperStuRelationEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuRelationEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objRow[concc_ExamPaperStuRelation.ApplySendBackDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.ApplySendBackDate].ToString().Trim(); //申请退回日期
objcc_ExamPaperStuRelationEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsApplySendBack].ToString().Trim()); //是否申请退回
objcc_ExamPaperStuRelationEN.RealFinishDate = objRow[concc_ExamPaperStuRelation.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuRelationEN.OperateTime = objRow[concc_ExamPaperStuRelation.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuRelationEN.Score = objRow[concc_ExamPaperStuRelation.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuRelation.Score].ToString().Trim()); //得分
objcc_ExamPaperStuRelationEN.Comment = objRow[concc_ExamPaperStuRelation.Comment] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Comment].ToString().Trim(); //批注
objcc_ExamPaperStuRelationEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuRelationEN.MarkerId = objRow[concc_ExamPaperStuRelation.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuRelationEN.MarkDate = objRow[concc_ExamPaperStuRelation.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuRelationEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsSendBack].ToString().Trim()); //是否退回
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objcc_ExamPaperStuRelationEN.WorkTypeId = objRow[concc_ExamPaperStuRelation.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperStuRelationEN.AnswerIP = objRow[concc_ExamPaperStuRelation.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuRelationEN.AnswerDate = objRow[concc_ExamPaperStuRelation.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuRelationEN.AnswerTime = objRow[concc_ExamPaperStuRelation.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuRelationEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsRight].ToString().Trim()); //是否正确
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuRelation.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objcc_ExamPaperStuRelationEN.SchoolYear = objRow[concc_ExamPaperStuRelation.SchoolYear] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolYear].ToString().Trim(); //学年
objcc_ExamPaperStuRelationEN.SchoolTerm = objRow[concc_ExamPaperStuRelation.SchoolTerm] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.SchoolTerm].ToString().Trim(); //学期
objcc_ExamPaperStuRelationEN.UpdDate = objRow[concc_ExamPaperStuRelation.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuRelationEN.UpdUserId = objRow[concc_ExamPaperStuRelation.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuRelationEN.Memo = objRow[concc_ExamPaperStuRelation.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_ExamPaperStuRelation(ref clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
bool bolResult = cc_ExamPaperStuRelationDA.Getcc_ExamPaperStuRelation(ref objcc_ExamPaperStuRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdExamPaperStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperStuRelationEN GetObjByIdExamPaperStuRelation(long lngIdExamPaperStuRelation)
{
clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = cc_ExamPaperStuRelationDA.GetObjByIdExamPaperStuRelation(lngIdExamPaperStuRelation);
return objcc_ExamPaperStuRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_ExamPaperStuRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = cc_ExamPaperStuRelationDA.GetFirstObj(strWhereCond);
 return objcc_ExamPaperStuRelationEN;
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
public static clscc_ExamPaperStuRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = cc_ExamPaperStuRelationDA.GetObjByDataRow(objRow);
 return objcc_ExamPaperStuRelationEN;
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
public static clscc_ExamPaperStuRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = cc_ExamPaperStuRelationDA.GetObjByDataRow(objRow);
 return objcc_ExamPaperStuRelationEN;
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
 /// <param name = "lngIdExamPaperStuRelation">所给的关键字</param>
 /// <param name = "lstcc_ExamPaperStuRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ExamPaperStuRelationEN GetObjByIdExamPaperStuRelationFromList(long lngIdExamPaperStuRelation, List<clscc_ExamPaperStuRelationEN> lstcc_ExamPaperStuRelationObjLst)
{
foreach (clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN in lstcc_ExamPaperStuRelationObjLst)
{
if (objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation == lngIdExamPaperStuRelation)
{
return objcc_ExamPaperStuRelationEN;
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
 long lngIdExamPaperStuRelation;
 try
 {
 lngIdExamPaperStuRelation = new clscc_ExamPaperStuRelationDA().GetFirstID(strWhereCond);
 return lngIdExamPaperStuRelation;
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
 arrList = cc_ExamPaperStuRelationDA.GetID(strWhereCond);
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
bool bolIsExist = cc_ExamPaperStuRelationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdExamPaperStuRelation">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdExamPaperStuRelation)
{
//检测记录是否存在
bool bolIsExist = cc_ExamPaperStuRelationDA.IsExist(lngIdExamPaperStuRelation);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdExamPaperStuRelation">流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdExamPaperStuRelation, string strOpUser)
{
clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = clscc_ExamPaperStuRelationBL.GetObjByIdExamPaperStuRelation(lngIdExamPaperStuRelation);
objcc_ExamPaperStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_ExamPaperStuRelationEN.UpdUserId = strOpUser;
return clscc_ExamPaperStuRelationBL.UpdateBySql2(objcc_ExamPaperStuRelationEN);
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
 bolIsExist = clscc_ExamPaperStuRelationDA.IsExistTable();
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
 bolIsExist = cc_ExamPaperStuRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_ExamPaperStuRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],学生流水号 = [{1}],教学班流水号 = [{2}]的数据已经存在!(in clscc_ExamPaperStuRelationBL.AddNewRecordBySql2)", objcc_ExamPaperStuRelationEN.CourseExamPaperId,objcc_ExamPaperStuRelationEN.IdStudentInfo,objcc_ExamPaperStuRelationEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
bool bolResult = cc_ExamPaperStuRelationDA.AddNewRecordBySQL2(objcc_ExamPaperStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationBL.ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_ExamPaperStuRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],学生流水号 = [{1}],教学班流水号 = [{2}]的数据已经存在!(in clscc_ExamPaperStuRelationBL.AddNewRecordBySql2WithReturnKey)", objcc_ExamPaperStuRelationEN.CourseExamPaperId,objcc_ExamPaperStuRelationEN.IdStudentInfo,objcc_ExamPaperStuRelationEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
string strKey = cc_ExamPaperStuRelationDA.AddNewRecordBySQL2WithReturnKey(objcc_ExamPaperStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationBL.ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
try
{
bool bolResult = cc_ExamPaperStuRelationDA.Update(objcc_ExamPaperStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationBL.ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
 if (objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_ExamPaperStuRelationDA.UpdateBySql2(objcc_ExamPaperStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuRelationBL.ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
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
 /// <param name = "lngIdExamPaperStuRelation">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdExamPaperStuRelation)
{
try
{
 clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = clscc_ExamPaperStuRelationBL.GetObjByIdExamPaperStuRelation(lngIdExamPaperStuRelation);

if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation, objcc_ExamPaperStuRelationEN.UpdUserId);
}
if (objcc_ExamPaperStuRelationEN != null)
{
int intRecNum = cc_ExamPaperStuRelationDA.DelRecord(lngIdExamPaperStuRelation);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);
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
/// <param name="lngIdExamPaperStuRelation">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdExamPaperStuRelation , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
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
//删除与表:[cc_ExamPaperStuRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_ExamPaperStuRelation.IdExamPaperStuRelation,
//lngIdExamPaperStuRelation);
//        clscc_ExamPaperStuRelationBL.Delcc_ExamPaperStuRelationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_ExamPaperStuRelationBL.DelRecord(lngIdExamPaperStuRelation, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_ExamPaperStuRelationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdExamPaperStuRelation, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdExamPaperStuRelation">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdExamPaperStuRelation, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(lngIdExamPaperStuRelation, "UpdRelaTabDate");
}
bool bolResult = cc_ExamPaperStuRelationDA.DelRecord(lngIdExamPaperStuRelation,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdExamPaperStuRelationLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_ExamPaperStuRelations(List<string> arrIdExamPaperStuRelationLst)
{
if (arrIdExamPaperStuRelationLst.Count == 0) return 0;
try
{
if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
foreach (var strIdExamPaperStuRelation in arrIdExamPaperStuRelationLst)
{
long lngIdExamPaperStuRelation = long.Parse(strIdExamPaperStuRelation);
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(lngIdExamPaperStuRelation, "UpdRelaTabDate");
}
}
 clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = clscc_ExamPaperStuRelationBL.GetObjByIdExamPaperStuRelation(long.Parse(arrIdExamPaperStuRelationLst[0]));
int intDelRecNum = cc_ExamPaperStuRelationDA.Delcc_ExamPaperStuRelation(arrIdExamPaperStuRelationLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_ExamPaperStuRelationEN.IdCurrEduCls);
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
public static int Delcc_ExamPaperStuRelationsByCond(string strWhereCond)
{
try
{
if (clscc_ExamPaperStuRelationBL.relatedActions != null)
{
List<string> arrIdExamPaperStuRelation = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdExamPaperStuRelation in arrIdExamPaperStuRelation)
{
long lngIdExamPaperStuRelation = long.Parse(strIdExamPaperStuRelation);
clscc_ExamPaperStuRelationBL.relatedActions.UpdRelaTabDate(lngIdExamPaperStuRelation, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(concc_ExamPaperStuRelation.IdCurrEduCls, strWhereCond);
int intRecNum = cc_ExamPaperStuRelationDA.Delcc_ExamPaperStuRelation(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_ExamPaperStuRelation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdExamPaperStuRelation">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdExamPaperStuRelation, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
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
//删除与表:[cc_ExamPaperStuRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_ExamPaperStuRelationBL.DelRecord(lngIdExamPaperStuRelation, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_ExamPaperStuRelationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdExamPaperStuRelation, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_ExamPaperStuRelationENS">源对象</param>
 /// <param name = "objcc_ExamPaperStuRelationENT">目标对象</param>
 public static void CopyTo(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationENS, clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationENT)
{
try
{
objcc_ExamPaperStuRelationENT.IdExamPaperStuRelation = objcc_ExamPaperStuRelationENS.IdExamPaperStuRelation; //流水号
objcc_ExamPaperStuRelationENT.CourseExamPaperId = objcc_ExamPaperStuRelationENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperStuRelationENT.IdCurrEduCls = objcc_ExamPaperStuRelationENS.IdCurrEduCls; //教学班流水号
objcc_ExamPaperStuRelationENT.Scores = objcc_ExamPaperStuRelationENS.Scores; //分值
objcc_ExamPaperStuRelationENT.SpecifyCompletionDate = objcc_ExamPaperStuRelationENS.SpecifyCompletionDate; //指定完成日期
objcc_ExamPaperStuRelationENT.IdStudentInfo = objcc_ExamPaperStuRelationENS.IdStudentInfo; //学生流水号
objcc_ExamPaperStuRelationENT.AnswerModeId = objcc_ExamPaperStuRelationENS.AnswerModeId; //答案模式Id
objcc_ExamPaperStuRelationENT.AnswerOptionId = objcc_ExamPaperStuRelationENS.AnswerOptionId; //回答选项Id
objcc_ExamPaperStuRelationENT.AnswerMultiOptions = objcc_ExamPaperStuRelationENS.AnswerMultiOptions; //多选项答案
objcc_ExamPaperStuRelationENT.StuAnswerText = objcc_ExamPaperStuRelationENS.StuAnswerText; //学生回答文本
objcc_ExamPaperStuRelationENT.IsPublish = objcc_ExamPaperStuRelationENS.IsPublish; //是否发布
objcc_ExamPaperStuRelationENT.IsLook = objcc_ExamPaperStuRelationENS.IsLook; //是否查看
objcc_ExamPaperStuRelationENT.IsSave = objcc_ExamPaperStuRelationENS.IsSave; //是否保存
objcc_ExamPaperStuRelationENT.IsSubmit = objcc_ExamPaperStuRelationENS.IsSubmit; //是否提交
objcc_ExamPaperStuRelationENT.ApplySendBackDate = objcc_ExamPaperStuRelationENS.ApplySendBackDate; //申请退回日期
objcc_ExamPaperStuRelationENT.IsApplySendBack = objcc_ExamPaperStuRelationENS.IsApplySendBack; //是否申请退回
objcc_ExamPaperStuRelationENT.RealFinishDate = objcc_ExamPaperStuRelationENS.RealFinishDate; //实际完成日期
objcc_ExamPaperStuRelationENT.OperateTime = objcc_ExamPaperStuRelationENS.OperateTime; //操作时间
objcc_ExamPaperStuRelationENT.Score = objcc_ExamPaperStuRelationENS.Score; //得分
objcc_ExamPaperStuRelationENT.Comment = objcc_ExamPaperStuRelationENS.Comment; //批注
objcc_ExamPaperStuRelationENT.IsMarking = objcc_ExamPaperStuRelationENS.IsMarking; //是否批阅
objcc_ExamPaperStuRelationENT.MarkerId = objcc_ExamPaperStuRelationENS.MarkerId; //打分者
objcc_ExamPaperStuRelationENT.MarkDate = objcc_ExamPaperStuRelationENS.MarkDate; //打分日期
objcc_ExamPaperStuRelationENT.IsSendBack = objcc_ExamPaperStuRelationENS.IsSendBack; //是否退回
objcc_ExamPaperStuRelationENT.IsInErrorQuestion = objcc_ExamPaperStuRelationENS.IsInErrorQuestion; //是否进入错题
objcc_ExamPaperStuRelationENT.WorkTypeId = objcc_ExamPaperStuRelationENS.WorkTypeId; //作业类型Id
objcc_ExamPaperStuRelationENT.AnswerIP = objcc_ExamPaperStuRelationENS.AnswerIP; //回答IP
objcc_ExamPaperStuRelationENT.AnswerDate = objcc_ExamPaperStuRelationENS.AnswerDate; //回答日期
objcc_ExamPaperStuRelationENT.AnswerTime = objcc_ExamPaperStuRelationENS.AnswerTime; //回答时间
objcc_ExamPaperStuRelationENT.IsRight = objcc_ExamPaperStuRelationENS.IsRight; //是否正确
objcc_ExamPaperStuRelationENT.IsAccessKnowledge = objcc_ExamPaperStuRelationENS.IsAccessKnowledge; //是否处理知识点
objcc_ExamPaperStuRelationENT.IsNotProcessTimeout = objcc_ExamPaperStuRelationENS.IsNotProcessTimeout; //是否不处理超时
objcc_ExamPaperStuRelationENT.SchoolYear = objcc_ExamPaperStuRelationENS.SchoolYear; //学年
objcc_ExamPaperStuRelationENT.SchoolTerm = objcc_ExamPaperStuRelationENS.SchoolTerm; //学期
objcc_ExamPaperStuRelationENT.UpdDate = objcc_ExamPaperStuRelationENS.UpdDate; //修改日期
objcc_ExamPaperStuRelationENT.UpdUserId = objcc_ExamPaperStuRelationENS.UpdUserId; //修改用户Id
objcc_ExamPaperStuRelationENT.Memo = objcc_ExamPaperStuRelationENS.Memo; //备注
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
 /// <param name = "objcc_ExamPaperStuRelationEN">源简化对象</param>
 public static void SetUpdFlag(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
try
{
objcc_ExamPaperStuRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_ExamPaperStuRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IdExamPaperStuRelation, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation = objcc_ExamPaperStuRelationEN.IdExamPaperStuRelation; //流水号
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.CourseExamPaperId = objcc_ExamPaperStuRelationEN.CourseExamPaperId == "[null]" ? null :  objcc_ExamPaperStuRelationEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IdCurrEduCls = objcc_ExamPaperStuRelationEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.Scores, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.Scores = objcc_ExamPaperStuRelationEN.Scores; //分值
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.SpecifyCompletionDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objcc_ExamPaperStuRelationEN.SpecifyCompletionDate; //指定完成日期
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IdStudentInfo = objcc_ExamPaperStuRelationEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.AnswerModeId = objcc_ExamPaperStuRelationEN.AnswerModeId == "[null]" ? null :  objcc_ExamPaperStuRelationEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.AnswerOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.AnswerOptionId = objcc_ExamPaperStuRelationEN.AnswerOptionId == "[null]" ? null :  objcc_ExamPaperStuRelationEN.AnswerOptionId; //回答选项Id
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.AnswerMultiOptions, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.AnswerMultiOptions = objcc_ExamPaperStuRelationEN.AnswerMultiOptions == "[null]" ? null :  objcc_ExamPaperStuRelationEN.AnswerMultiOptions; //多选项答案
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.StuAnswerText, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.StuAnswerText = objcc_ExamPaperStuRelationEN.StuAnswerText == "[null]" ? null :  objcc_ExamPaperStuRelationEN.StuAnswerText; //学生回答文本
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IsPublish, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IsPublish = objcc_ExamPaperStuRelationEN.IsPublish; //是否发布
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IsLook, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IsLook = objcc_ExamPaperStuRelationEN.IsLook; //是否查看
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IsSave, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IsSave = objcc_ExamPaperStuRelationEN.IsSave; //是否保存
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IsSubmit = objcc_ExamPaperStuRelationEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.ApplySendBackDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.ApplySendBackDate = objcc_ExamPaperStuRelationEN.ApplySendBackDate == "[null]" ? null :  objcc_ExamPaperStuRelationEN.ApplySendBackDate; //申请退回日期
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IsApplySendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IsApplySendBack = objcc_ExamPaperStuRelationEN.IsApplySendBack; //是否申请退回
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.RealFinishDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.RealFinishDate = objcc_ExamPaperStuRelationEN.RealFinishDate == "[null]" ? null :  objcc_ExamPaperStuRelationEN.RealFinishDate; //实际完成日期
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.OperateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.OperateTime = objcc_ExamPaperStuRelationEN.OperateTime == "[null]" ? null :  objcc_ExamPaperStuRelationEN.OperateTime; //操作时间
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.Score = objcc_ExamPaperStuRelationEN.Score; //得分
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.Comment, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.Comment = objcc_ExamPaperStuRelationEN.Comment == "[null]" ? null :  objcc_ExamPaperStuRelationEN.Comment; //批注
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IsMarking, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IsMarking = objcc_ExamPaperStuRelationEN.IsMarking; //是否批阅
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.MarkerId = objcc_ExamPaperStuRelationEN.MarkerId == "[null]" ? null :  objcc_ExamPaperStuRelationEN.MarkerId; //打分者
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.MarkDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.MarkDate = objcc_ExamPaperStuRelationEN.MarkDate == "[null]" ? null :  objcc_ExamPaperStuRelationEN.MarkDate; //打分日期
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IsSendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IsSendBack = objcc_ExamPaperStuRelationEN.IsSendBack; //是否退回
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IsInErrorQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IsInErrorQuestion = objcc_ExamPaperStuRelationEN.IsInErrorQuestion; //是否进入错题
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.WorkTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.WorkTypeId = objcc_ExamPaperStuRelationEN.WorkTypeId; //作业类型Id
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.AnswerIP, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.AnswerIP = objcc_ExamPaperStuRelationEN.AnswerIP == "[null]" ? null :  objcc_ExamPaperStuRelationEN.AnswerIP; //回答IP
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.AnswerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.AnswerDate = objcc_ExamPaperStuRelationEN.AnswerDate == "[null]" ? null :  objcc_ExamPaperStuRelationEN.AnswerDate; //回答日期
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.AnswerTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.AnswerTime = objcc_ExamPaperStuRelationEN.AnswerTime == "[null]" ? null :  objcc_ExamPaperStuRelationEN.AnswerTime; //回答时间
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IsRight = objcc_ExamPaperStuRelationEN.IsRight; //是否正确
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IsAccessKnowledge, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IsAccessKnowledge = objcc_ExamPaperStuRelationEN.IsAccessKnowledge; //是否处理知识点
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.IsNotProcessTimeout, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.IsNotProcessTimeout = objcc_ExamPaperStuRelationEN.IsNotProcessTimeout; //是否不处理超时
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.SchoolYear = objcc_ExamPaperStuRelationEN.SchoolYear == "[null]" ? null :  objcc_ExamPaperStuRelationEN.SchoolYear; //学年
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.SchoolTerm = objcc_ExamPaperStuRelationEN.SchoolTerm == "[null]" ? null :  objcc_ExamPaperStuRelationEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.UpdDate = objcc_ExamPaperStuRelationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.UpdUserId = objcc_ExamPaperStuRelationEN.UpdUserId == "[null]" ? null :  objcc_ExamPaperStuRelationEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_ExamPaperStuRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuRelationEN.Memo = objcc_ExamPaperStuRelationEN.Memo == "[null]" ? null :  objcc_ExamPaperStuRelationEN.Memo; //备注
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
 /// <param name = "objcc_ExamPaperStuRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
try
{
if (objcc_ExamPaperStuRelationEN.CourseExamPaperId == "[null]") objcc_ExamPaperStuRelationEN.CourseExamPaperId = null; //考卷流水号
if (objcc_ExamPaperStuRelationEN.AnswerModeId == "[null]") objcc_ExamPaperStuRelationEN.AnswerModeId = null; //答案模式Id
if (objcc_ExamPaperStuRelationEN.AnswerOptionId == "[null]") objcc_ExamPaperStuRelationEN.AnswerOptionId = null; //回答选项Id
if (objcc_ExamPaperStuRelationEN.AnswerMultiOptions == "[null]") objcc_ExamPaperStuRelationEN.AnswerMultiOptions = null; //多选项答案
if (objcc_ExamPaperStuRelationEN.StuAnswerText == "[null]") objcc_ExamPaperStuRelationEN.StuAnswerText = null; //学生回答文本
if (objcc_ExamPaperStuRelationEN.ApplySendBackDate == "[null]") objcc_ExamPaperStuRelationEN.ApplySendBackDate = null; //申请退回日期
if (objcc_ExamPaperStuRelationEN.RealFinishDate == "[null]") objcc_ExamPaperStuRelationEN.RealFinishDate = null; //实际完成日期
if (objcc_ExamPaperStuRelationEN.OperateTime == "[null]") objcc_ExamPaperStuRelationEN.OperateTime = null; //操作时间
if (objcc_ExamPaperStuRelationEN.Comment == "[null]") objcc_ExamPaperStuRelationEN.Comment = null; //批注
if (objcc_ExamPaperStuRelationEN.MarkerId == "[null]") objcc_ExamPaperStuRelationEN.MarkerId = null; //打分者
if (objcc_ExamPaperStuRelationEN.MarkDate == "[null]") objcc_ExamPaperStuRelationEN.MarkDate = null; //打分日期
if (objcc_ExamPaperStuRelationEN.AnswerIP == "[null]") objcc_ExamPaperStuRelationEN.AnswerIP = null; //回答IP
if (objcc_ExamPaperStuRelationEN.AnswerDate == "[null]") objcc_ExamPaperStuRelationEN.AnswerDate = null; //回答日期
if (objcc_ExamPaperStuRelationEN.AnswerTime == "[null]") objcc_ExamPaperStuRelationEN.AnswerTime = null; //回答时间
if (objcc_ExamPaperStuRelationEN.SchoolYear == "[null]") objcc_ExamPaperStuRelationEN.SchoolYear = null; //学年
if (objcc_ExamPaperStuRelationEN.SchoolTerm == "[null]") objcc_ExamPaperStuRelationEN.SchoolTerm = null; //学期
if (objcc_ExamPaperStuRelationEN.UpdUserId == "[null]") objcc_ExamPaperStuRelationEN.UpdUserId = null; //修改用户Id
if (objcc_ExamPaperStuRelationEN.Memo == "[null]") objcc_ExamPaperStuRelationEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
 cc_ExamPaperStuRelationDA.CheckPropertyNew(objcc_ExamPaperStuRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
 cc_ExamPaperStuRelationDA.CheckProperty4Condition(objcc_ExamPaperStuRelationEN);
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
if (clscc_ExamPaperStuRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperStuRelationBL没有刷新缓存机制(clscc_ExamPaperStuRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdExamPaperStuRelation");
//if (arrcc_ExamPaperStuRelationObjLstCache == null)
//{
//arrcc_ExamPaperStuRelationObjLstCache = cc_ExamPaperStuRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdExamPaperStuRelation">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ExamPaperStuRelationEN GetObjByIdExamPaperStuRelationCache(long lngIdExamPaperStuRelation, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuRelationEN._CurrTabName, strIdCurrEduCls);
List<clscc_ExamPaperStuRelationEN> arrcc_ExamPaperStuRelationObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clscc_ExamPaperStuRelationEN> arrcc_ExamPaperStuRelationObjLst_Sel =
arrcc_ExamPaperStuRelationObjLstCache
.Where(x=> x.IdExamPaperStuRelation == lngIdExamPaperStuRelation 
);
if (arrcc_ExamPaperStuRelationObjLst_Sel.Count() == 0)
{
   clscc_ExamPaperStuRelationEN obj = clscc_ExamPaperStuRelationBL.GetObjByIdExamPaperStuRelation(lngIdExamPaperStuRelation);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngIdExamPaperStuRelation, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrcc_ExamPaperStuRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ExamPaperStuRelationEN> GetAllcc_ExamPaperStuRelationObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clscc_ExamPaperStuRelationEN> arrcc_ExamPaperStuRelationObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrcc_ExamPaperStuRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ExamPaperStuRelationEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuRelationEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clscc_ExamPaperStuRelationEN> arrcc_ExamPaperStuRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrcc_ExamPaperStuRelationObjLstCache;
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
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuRelationEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clscc_ExamPaperStuRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_ExamPaperStuRelationEN._RefreshTimeLst.Count == 0) return "";
return clscc_ExamPaperStuRelationEN._RefreshTimeLst[clscc_ExamPaperStuRelationEN._RefreshTimeLst.Count - 1];
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
if (clscc_ExamPaperStuRelationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuRelationEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clscc_ExamPaperStuRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_ExamPaperStuRelationBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_ExamPaperStuRelation(考卷与学生关系)
 /// 唯一性条件:CourseExamPaperId_id_StudentInfo_id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN)
{
//检测记录是否存在
string strResult = cc_ExamPaperStuRelationDA.GetUniCondStr(objcc_ExamPaperStuRelationEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdExamPaperStuRelation, string strIdCurrEduCls)
{
if (strInFldName != concc_ExamPaperStuRelation.IdExamPaperStuRelation)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_ExamPaperStuRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_ExamPaperStuRelation.AttributeName));
throw new Exception(strMsg);
}
var objcc_ExamPaperStuRelation = clscc_ExamPaperStuRelationBL.GetObjByIdExamPaperStuRelationCache(lngIdExamPaperStuRelation, strIdCurrEduCls);
if (objcc_ExamPaperStuRelation == null) return "";
return objcc_ExamPaperStuRelation[strOutFldName].ToString();
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
int intRecCount = clscc_ExamPaperStuRelationDA.GetRecCount(strTabName);
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
int intRecCount = clscc_ExamPaperStuRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_ExamPaperStuRelationDA.GetRecCount();
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
int intRecCount = clscc_ExamPaperStuRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationCond)
{
 string strIdCurrEduCls = objcc_ExamPaperStuRelationCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clscc_ExamPaperStuRelationBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clscc_ExamPaperStuRelationEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clscc_ExamPaperStuRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_ExamPaperStuRelation.AttributeName)
{
if (objcc_ExamPaperStuRelationCond.IsUpdated(strFldName) == false) continue;
if (objcc_ExamPaperStuRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperStuRelationCond[strFldName].ToString());
}
else
{
if (objcc_ExamPaperStuRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_ExamPaperStuRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperStuRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_ExamPaperStuRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_ExamPaperStuRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperStuRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperStuRelationCond[strFldName]));
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
 List<string> arrList = clscc_ExamPaperStuRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_ExamPaperStuRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_ExamPaperStuRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_ExamPaperStuRelationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperStuRelationDA.SetFldValue(clscc_ExamPaperStuRelationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_ExamPaperStuRelationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperStuRelationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperStuRelationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperStuRelationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_ExamPaperStuRelation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**流水号*/ 
 strCreateTabCode.Append(" IdExamPaperStuRelation bigint primary key identity, "); 
 // /**考卷流水号*/ 
 strCreateTabCode.Append(" CourseExamPaperId char(8) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
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
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**考卷名称*/ 
 strCreateTabCode.Append(" ExamPaperName varchar(500) Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) Null, "); 
 // /**姓名*/ 
 strCreateTabCode.Append(" StuName varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 考卷与学生关系(cc_ExamPaperStuRelation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_ExamPaperStuRelation : clsCommFun4BLV2
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
clscc_ExamPaperStuRelationBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}