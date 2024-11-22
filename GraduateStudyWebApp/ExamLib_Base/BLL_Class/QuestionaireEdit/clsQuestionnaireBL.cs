
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireBL
 表名:Questionnaire(01120001)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:19
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
public static class  clsQuestionnaireBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireEN GetObj(this K_QuestionId_Questionnaire myKey)
{
clsQuestionnaireEN objQuestionnaireEN = clsQuestionnaireBL.QuestionnaireDA.GetObjByQuestionId(myKey.Value);
return objQuestionnaireEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionnaireEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}]的数据已经存在!(in clsQuestionnaireBL.AddNewRecord)", objQuestionnaireEN.QuestionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQuestionnaireBL.QuestionnaireDA.AddNewRecordBySQL2(objQuestionnaireEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBL.ReFreshCache(objQuestionnaireEN.CourseId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
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
public static bool AddRecordEx(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsNeedCheckUniqueness = true)
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
objQuestionnaireEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objQuestionnaireEN.CheckUniqueness() == false)
{
strMsg = string.Format("(题目Id(QuestionId)=[{0}])已经存在,不能重复!", objQuestionnaireEN.QuestionId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQuestionnaireEN.AddNewRecord();
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
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionnaireEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}]的数据已经存在!(in clsQuestionnaireBL.AddNewRecordWithReturnKey)", objQuestionnaireEN.QuestionId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQuestionnaireBL.QuestionnaireDA.AddNewRecordBySQL2WithReturnKey(objQuestionnaireEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBL.ReFreshCache(objQuestionnaireEN.CourseId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
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
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionId(this clsQuestionnaireEN objQuestionnaireEN, long lngQuestionId, string strComparisonOp="")
	{
objQuestionnaireEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionIndex(this clsQuestionnaireEN objQuestionnaireEN, int? intQuestionIndex, string strComparisonOp="")
	{
objQuestionnaireEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionIndex) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionIndex, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionIndex] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionName(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionName, conQuestionnaire.QuestionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, conQuestionnaire.QuestionName);
}
objQuestionnaireEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionName) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionName, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionName] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionContent(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, conQuestionnaire.QuestionContent);
}
objQuestionnaireEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionContent) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionContent, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionContent] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionMemo(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, conQuestionnaire.QuestionMemo);
}
objQuestionnaireEN.QuestionMemo = strQuestionMemo; //题目说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionMemo) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionMemo, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionMemo] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionNo(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, conQuestionnaire.QuestionNo);
}
objQuestionnaireEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionNo) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionNo, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionNo] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetParentQuestionId(this clsQuestionnaireEN objQuestionnaireEN, string strParentQuestionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentQuestionId, 8, conQuestionnaire.ParentQuestionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentQuestionId, 8, conQuestionnaire.ParentQuestionId);
}
objQuestionnaireEN.ParentQuestionId = strParentQuestionId; //父题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.ParentQuestionId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.ParentQuestionId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.ParentQuestionId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetExamAnswer(this clsQuestionnaireEN objQuestionnaireEN, string strExamAnswer, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, conQuestionnaire.ExamAnswer);
}
objQuestionnaireEN.ExamAnswer = strExamAnswer; //题目答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.ExamAnswer) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.ExamAnswer, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.ExamAnswer] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetCourseId(this clsQuestionnaireEN objQuestionnaireEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conQuestionnaire.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conQuestionnaire.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conQuestionnaire.CourseId);
}
objQuestionnaireEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CourseId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CourseId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CourseId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetLevelNo(this clsQuestionnaireEN objQuestionnaireEN, int? intLevelNo, string strComparisonOp="")
	{
objQuestionnaireEN.LevelNo = intLevelNo; //学习关号2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.LevelNo) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.LevelNo, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.LevelNo] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetCourseChapterId(this clsQuestionnaireEN objQuestionnaireEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conQuestionnaire.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conQuestionnaire.CourseChapterId);
}
objQuestionnaireEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CourseChapterId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CourseChapterId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CourseChapterId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionTypeId(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, conQuestionnaire.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, conQuestionnaire.QuestionTypeId);
}
objQuestionnaireEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionTypeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionTypeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionTypeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionTypeId4Course(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, conQuestionnaire.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, conQuestionnaire.QuestionTypeId4Course);
}
objQuestionnaireEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionTypeId4Course) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionTypeId4Course, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionTypeId4Course] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetAnswerTypeId(this clsQuestionnaireEN objQuestionnaireEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conQuestionnaire.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conQuestionnaire.AnswerTypeId);
}
objQuestionnaireEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.AnswerTypeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.AnswerTypeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.AnswerTypeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetGridTitle(this clsQuestionnaireEN objQuestionnaireEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, conQuestionnaire.GridTitle);
}
objQuestionnaireEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.GridTitle) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.GridTitle, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.GridTitle] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetAnswerModeId(this clsQuestionnaireEN objQuestionnaireEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, conQuestionnaire.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, conQuestionnaire.AnswerModeId);
}
objQuestionnaireEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.AnswerModeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.AnswerModeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.AnswerModeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetIsHaveAdditionalMemo(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsHaveAdditionalMemo, string strComparisonOp="")
	{
objQuestionnaireEN.IsHaveAdditionalMemo = bolIsHaveAdditionalMemo; //是否有附加说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsHaveAdditionalMemo) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsHaveAdditionalMemo, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsHaveAdditionalMemo] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionScore(this clsQuestionnaireEN objQuestionnaireEN, float? fltQuestionScore, string strComparisonOp="")
	{
objQuestionnaireEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionScore) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionScore, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionScore] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetDefaultValue(this clsQuestionnaireEN objQuestionnaireEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conQuestionnaire.DefaultValue);
}
objQuestionnaireEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.DefaultValue) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.DefaultValue, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.DefaultValue] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetDefaultSelectItem(this clsQuestionnaireEN objQuestionnaireEN, string strDefaultSelectItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultSelectItem, 20, conQuestionnaire.DefaultSelectItem);
}
objQuestionnaireEN.DefaultSelectItem = strDefaultSelectItem; //默认选项
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.DefaultSelectItem) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.DefaultSelectItem, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.DefaultSelectItem] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetIsShow(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsShow, string strComparisonOp="")
	{
objQuestionnaireEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsShow) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsShow, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsShow] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetIsCast(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsCast, string strComparisonOp="")
	{
objQuestionnaireEN.IsCast = bolIsCast; //是否播放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsCast) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsCast, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsCast] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetLikeCount(this clsQuestionnaireEN objQuestionnaireEN, long? lngLikeCount, string strComparisonOp="")
	{
objQuestionnaireEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.LikeCount) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.LikeCount, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.LikeCount] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetAnswerAttLimitSize(this clsQuestionnaireEN objQuestionnaireEN, long? lngAnswerAttLimitSize, string strComparisonOp="")
	{
objQuestionnaireEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.AnswerAttLimitSize) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.AnswerAttLimitSize, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.AnswerAttLimitSize] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetLimitedResourceType(this clsQuestionnaireEN objQuestionnaireEN, string strLimitedResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, conQuestionnaire.LimitedResourceType);
}
objQuestionnaireEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.LimitedResourceType) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.LimitedResourceType, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.LimitedResourceType] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetIsEffective(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsEffective, string strComparisonOp="")
	{
objQuestionnaireEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsEffective) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsEffective, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsEffective] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetIsCanInPaper(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsCanInPaper, string strComparisonOp="")
	{
objQuestionnaireEN.IsCanInPaper = bolIsCanInPaper; //是否可在Paper
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsCanInPaper) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsCanInPaper, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsCanInPaper] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetExamGradeId(this clsQuestionnaireEN objQuestionnaireEN, string strExamGradeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, conQuestionnaire.ExamGradeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, conQuestionnaire.ExamGradeId);
}
objQuestionnaireEN.ExamGradeId = strExamGradeId; //题库等级ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.ExamGradeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.ExamGradeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.ExamGradeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetTextDirectId(this clsQuestionnaireEN objQuestionnaireEN, string strTextDirectId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, conQuestionnaire.TextDirectId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, conQuestionnaire.TextDirectId);
}
objQuestionnaireEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.TextDirectId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.TextDirectId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.TextDirectId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetUpdDate(this clsQuestionnaireEN objQuestionnaireEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionnaire.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionnaire.UpdDate);
}
objQuestionnaireEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.UpdDate) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.UpdDate, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.UpdDate] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetUpdUser(this clsQuestionnaireEN objQuestionnaireEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionnaire.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionnaire.UpdUser);
}
objQuestionnaireEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.UpdUser) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.UpdUser, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.UpdUser] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetMemo(this clsQuestionnaireEN objQuestionnaireEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionnaire.Memo);
}
objQuestionnaireEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.Memo) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.Memo, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.Memo] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionCode(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionCode, 8000, conQuestionnaire.QuestionCode);
}
objQuestionnaireEN.QuestionCode = strQuestionCode; //html代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionCode) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionCode, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionCode] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetDifficultyLevelId(this clsQuestionnaireEN objQuestionnaireEN, string strDifficultyLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDifficultyLevelId, 2, conQuestionnaire.DifficultyLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDifficultyLevelId, 2, conQuestionnaire.DifficultyLevelId);
}
objQuestionnaireEN.DifficultyLevelId = strDifficultyLevelId; //难度等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.DifficultyLevelId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.DifficultyLevelId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.DifficultyLevelId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetSectionTypeId(this clsQuestionnaireEN objQuestionnaireEN, string strSectionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionTypeId, 8, conQuestionnaire.SectionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionTypeId, 8, conQuestionnaire.SectionTypeId);
}
objQuestionnaireEN.SectionTypeId = strSectionTypeId; //节点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.SectionTypeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.SectionTypeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.SectionTypeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetKnowledgeGraphId(this clsQuestionnaireEN objQuestionnaireEN, string strKnowledgeGraphId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeGraphId, 10, conQuestionnaire.KnowledgeGraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeGraphId, 10, conQuestionnaire.KnowledgeGraphId);
}
objQuestionnaireEN.KnowledgeGraphId = strKnowledgeGraphId; //知识点图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.KnowledgeGraphId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.KnowledgeGraphId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.KnowledgeGraphId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetFirstIndent(this clsQuestionnaireEN objQuestionnaireEN, bool bolFirstIndent, string strComparisonOp="")
	{
objQuestionnaireEN.FirstIndent = bolFirstIndent; //首行缩进
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.FirstIndent) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.FirstIndent, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.FirstIndent] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetQuestionNameAdd(this clsQuestionnaireEN objQuestionnaireEN, string strQuestionNameAdd, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNameAdd, 500, conQuestionnaire.QuestionNameAdd);
}
objQuestionnaireEN.QuestionNameAdd = strQuestionNameAdd; //题目补充
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.QuestionNameAdd) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.QuestionNameAdd, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.QuestionNameAdd] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetCodeTab(this clsQuestionnaireEN objQuestionnaireEN, string strCodeTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTab, 50, conQuestionnaire.CodeTab);
}
objQuestionnaireEN.CodeTab = strCodeTab; //代码表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CodeTab) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CodeTab, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CodeTab] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetCodeTabCode(this clsQuestionnaireEN objQuestionnaireEN, string strCodeTabCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCode, 50, conQuestionnaire.CodeTabCode);
}
objQuestionnaireEN.CodeTabCode = strCodeTabCode; //CodeTab_Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CodeTabCode) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CodeTabCode, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CodeTabCode] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetCodeTabCondition(this clsQuestionnaireEN objQuestionnaireEN, string strCodeTabCondition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCondition, 200, conQuestionnaire.CodeTabCondition);
}
objQuestionnaireEN.CodeTabCondition = strCodeTabCondition; //代码表_条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CodeTabCondition) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CodeTabCondition, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CodeTabCondition] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetCodeTabName(this clsQuestionnaireEN objQuestionnaireEN, string strCodeTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabName, 50, conQuestionnaire.CodeTabName);
}
objQuestionnaireEN.CodeTabName = strCodeTabName; //CodeTab_Name
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CodeTabName) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CodeTabName, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CodeTabName] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetFillInTextHeight(this clsQuestionnaireEN objQuestionnaireEN, int? intFillInTextHeight, string strComparisonOp="")
	{
objQuestionnaireEN.FillInTextHeight = intFillInTextHeight; //填空框高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.FillInTextHeight) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.FillInTextHeight, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.FillInTextHeight] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetFillInTextWidth(this clsQuestionnaireEN objQuestionnaireEN, int? intFillInTextWidth, string strComparisonOp="")
	{
objQuestionnaireEN.FillInTextWidth = intFillInTextWidth; //填空框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.FillInTextWidth) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.FillInTextWidth, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.FillInTextWidth] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetIsMulti4FillInText(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsMulti4FillInText, string strComparisonOp="")
	{
objQuestionnaireEN.IsMulti4FillInText = bolIsMulti4FillInText; //是否填空框多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsMulti4FillInText) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsMulti4FillInText, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsMulti4FillInText] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetCheckBoxLimitCount(this clsQuestionnaireEN objQuestionnaireEN, int? intCheckBoxLimitCount, string strComparisonOp="")
	{
objQuestionnaireEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.CheckBoxLimitCount) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.CheckBoxLimitCount, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.CheckBoxLimitCount] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetIsJs(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsJs, string strComparisonOp="")
	{
objQuestionnaireEN.IsJs = bolIsJs; //是否是JS
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsJs) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsJs, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsJs] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetMemoTextWidth(this clsQuestionnaireEN objQuestionnaireEN, int? intMemoTextWidth, string strComparisonOp="")
	{
objQuestionnaireEN.MemoTextWidth = intMemoTextWidth; //备注框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.MemoTextWidth) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.MemoTextWidth, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.MemoTextWidth] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetRelaEvent(this clsQuestionnaireEN objQuestionnaireEN, string strRelaEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, conQuestionnaire.RelaEvent);
}
objQuestionnaireEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.RelaEvent) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.RelaEvent, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.RelaEvent] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetIsTest(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsTest, string strComparisonOp="")
	{
objQuestionnaireEN.IsTest = bolIsTest; //是否测试
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsTest) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsTest, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsTest] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetLevelModeTypeId(this clsQuestionnaireEN objQuestionnaireEN, string strLevelModeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLevelModeTypeId, conQuestionnaire.LevelModeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelModeTypeId, 2, conQuestionnaire.LevelModeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelModeTypeId, 2, conQuestionnaire.LevelModeTypeId);
}
objQuestionnaireEN.LevelModeTypeId = strLevelModeTypeId; //模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.LevelModeTypeId) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.LevelModeTypeId, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.LevelModeTypeId] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireEN SetIsRandom(this clsQuestionnaireEN objQuestionnaireEN, bool bolIsRandom, string strComparisonOp="")
	{
objQuestionnaireEN.IsRandom = bolIsRandom; //是否随机
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireEN.dicFldComparisonOp.ContainsKey(conQuestionnaire.IsRandom) == false)
{
objQuestionnaireEN.dicFldComparisonOp.Add(conQuestionnaire.IsRandom, strComparisonOp);
}
else
{
objQuestionnaireEN.dicFldComparisonOp[conQuestionnaire.IsRandom] = strComparisonOp;
}
}
return objQuestionnaireEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQuestionnaireEN objQuestionnaireEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQuestionnaireEN.CheckPropertyNew();
clsQuestionnaireEN objQuestionnaireCond = new clsQuestionnaireEN();
string strCondition = objQuestionnaireCond
.SetQuestionId(objQuestionnaireEN.QuestionId, "<>")
.SetQuestionId(objQuestionnaireEN.QuestionId, "=")
.GetCombineCondition();
objQuestionnaireEN._IsCheckProperty = true;
bool bolIsExist = clsQuestionnaireBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionID)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQuestionnaireEN.Update();
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
 /// <param name = "objQuestionnaire">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQuestionnaireEN objQuestionnaire)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQuestionnaireEN objQuestionnaireCond = new clsQuestionnaireEN();
string strCondition = objQuestionnaireCond
.SetQuestionId(objQuestionnaire.QuestionId, "=")
.GetCombineCondition();
objQuestionnaire._IsCheckProperty = true;
bool bolIsExist = clsQuestionnaireBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQuestionnaire.QuestionId = clsQuestionnaireBL.GetFirstID_S(strCondition);
objQuestionnaire.UpdateWithCondition(strCondition);
}
else
{
objQuestionnaire.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireEN objQuestionnaireEN)
{
 if (objQuestionnaireEN.QuestionId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionnaireBL.QuestionnaireDA.UpdateBySql2(objQuestionnaireEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBL.ReFreshCache(objQuestionnaireEN.CourseId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
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
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireEN objQuestionnaireEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQuestionnaireEN.QuestionId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionnaireBL.QuestionnaireDA.UpdateBySql2(objQuestionnaireEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBL.ReFreshCache(objQuestionnaireEN.CourseId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
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
 /// <param name = "objQuestionnaireEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireEN objQuestionnaireEN, string strWhereCond)
{
try
{
bool bolResult = clsQuestionnaireBL.QuestionnaireDA.UpdateBySqlWithCondition(objQuestionnaireEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBL.ReFreshCache(objQuestionnaireEN.CourseId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
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
 /// <param name = "objQuestionnaireEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireEN objQuestionnaireEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQuestionnaireBL.QuestionnaireDA.UpdateBySqlWithConditionTransaction(objQuestionnaireEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBL.ReFreshCache(objQuestionnaireEN.CourseId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
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
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQuestionnaireEN objQuestionnaireEN)
{
try
{
int intRecNum = clsQuestionnaireBL.QuestionnaireDA.DelRecord(objQuestionnaireEN.QuestionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBL.ReFreshCache(objQuestionnaireEN.CourseId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
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
 /// <param name = "objQuestionnaireENS">源对象</param>
 /// <param name = "objQuestionnaireENT">目标对象</param>
 public static void CopyTo(this clsQuestionnaireEN objQuestionnaireENS, clsQuestionnaireEN objQuestionnaireENT)
{
try
{
objQuestionnaireENT.QuestionId = objQuestionnaireENS.QuestionId; //题目Id
objQuestionnaireENT.QuestionIndex = objQuestionnaireENS.QuestionIndex; //题目序号
objQuestionnaireENT.QuestionName = objQuestionnaireENS.QuestionName; //题目名称
objQuestionnaireENT.QuestionContent = objQuestionnaireENS.QuestionContent; //题目内容
objQuestionnaireENT.QuestionMemo = objQuestionnaireENS.QuestionMemo; //题目说明
objQuestionnaireENT.QuestionNo = objQuestionnaireENS.QuestionNo; //题目编号
objQuestionnaireENT.ParentQuestionId = objQuestionnaireENS.ParentQuestionId; //父题目Id
objQuestionnaireENT.ExamAnswer = objQuestionnaireENS.ExamAnswer; //题目答案
objQuestionnaireENT.CourseId = objQuestionnaireENS.CourseId; //课程Id
objQuestionnaireENT.LevelNo = objQuestionnaireENS.LevelNo; //学习关号2
objQuestionnaireENT.CourseChapterId = objQuestionnaireENS.CourseChapterId; //课程章节ID
objQuestionnaireENT.QuestionTypeId = objQuestionnaireENS.QuestionTypeId; //题目类型Id
objQuestionnaireENT.QuestionTypeId4Course = objQuestionnaireENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionnaireENT.AnswerTypeId = objQuestionnaireENS.AnswerTypeId; //答案类型ID
objQuestionnaireENT.GridTitle = objQuestionnaireENS.GridTitle; //表格标题
objQuestionnaireENT.AnswerModeId = objQuestionnaireENS.AnswerModeId; //答案模式Id
objQuestionnaireENT.IsHaveAdditionalMemo = objQuestionnaireENS.IsHaveAdditionalMemo; //是否有附加说明
objQuestionnaireENT.QuestionScore = objQuestionnaireENS.QuestionScore; //题目得分
objQuestionnaireENT.DefaultValue = objQuestionnaireENS.DefaultValue; //缺省值
objQuestionnaireENT.DefaultSelectItem = objQuestionnaireENS.DefaultSelectItem; //默认选项
objQuestionnaireENT.IsShow = objQuestionnaireENS.IsShow; //是否启用
objQuestionnaireENT.IsCast = objQuestionnaireENS.IsCast; //是否播放
objQuestionnaireENT.LikeCount = objQuestionnaireENS.LikeCount; //资源喜欢数量
objQuestionnaireENT.AnswerAttLimitSize = objQuestionnaireENS.AnswerAttLimitSize; //回答附件限制大小
objQuestionnaireENT.LimitedResourceType = objQuestionnaireENS.LimitedResourceType; //限制资源类型
objQuestionnaireENT.IsEffective = objQuestionnaireENS.IsEffective; //是否有效
objQuestionnaireENT.IsCanInPaper = objQuestionnaireENS.IsCanInPaper; //是否可在Paper
objQuestionnaireENT.ExamGradeId = objQuestionnaireENS.ExamGradeId; //题库等级ID
objQuestionnaireENT.TextDirectId = objQuestionnaireENS.TextDirectId; //文本方向ID
objQuestionnaireENT.UpdDate = objQuestionnaireENS.UpdDate; //修改日期
objQuestionnaireENT.UpdUser = objQuestionnaireENS.UpdUser; //修改人
objQuestionnaireENT.Memo = objQuestionnaireENS.Memo; //备注
objQuestionnaireENT.QuestionCode = objQuestionnaireENS.QuestionCode; //html代码
objQuestionnaireENT.DifficultyLevelId = objQuestionnaireENS.DifficultyLevelId; //难度等级Id
objQuestionnaireENT.SectionTypeId = objQuestionnaireENS.SectionTypeId; //节点类型Id
objQuestionnaireENT.KnowledgeGraphId = objQuestionnaireENS.KnowledgeGraphId; //知识点图Id
objQuestionnaireENT.FirstIndent = objQuestionnaireENS.FirstIndent; //首行缩进
objQuestionnaireENT.QuestionNameAdd = objQuestionnaireENS.QuestionNameAdd; //题目补充
objQuestionnaireENT.CodeTab = objQuestionnaireENS.CodeTab; //代码表
objQuestionnaireENT.CodeTabCode = objQuestionnaireENS.CodeTabCode; //CodeTab_Code
objQuestionnaireENT.CodeTabCondition = objQuestionnaireENS.CodeTabCondition; //代码表_条件
objQuestionnaireENT.CodeTabName = objQuestionnaireENS.CodeTabName; //CodeTab_Name
objQuestionnaireENT.FillInTextHeight = objQuestionnaireENS.FillInTextHeight; //填空框高度
objQuestionnaireENT.FillInTextWidth = objQuestionnaireENS.FillInTextWidth; //填空框宽度
objQuestionnaireENT.IsMulti4FillInText = objQuestionnaireENS.IsMulti4FillInText; //是否填空框多行
objQuestionnaireENT.CheckBoxLimitCount = objQuestionnaireENS.CheckBoxLimitCount; //复选框限制数
objQuestionnaireENT.IsJs = objQuestionnaireENS.IsJs; //是否是JS
objQuestionnaireENT.MemoTextWidth = objQuestionnaireENS.MemoTextWidth; //备注框宽度
objQuestionnaireENT.RelaEvent = objQuestionnaireENS.RelaEvent; //相关事件
objQuestionnaireENT.IsTest = objQuestionnaireENS.IsTest; //是否测试
objQuestionnaireENT.LevelModeTypeId = objQuestionnaireENS.LevelModeTypeId; //模式Id
objQuestionnaireENT.IsRandom = objQuestionnaireENS.IsRandom; //是否随机
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
 /// <param name = "objQuestionnaireENS">源对象</param>
 /// <returns>目标对象=>clsQuestionnaireEN:objQuestionnaireENT</returns>
 public static clsQuestionnaireEN CopyTo(this clsQuestionnaireEN objQuestionnaireENS)
{
try
{
 clsQuestionnaireEN objQuestionnaireENT = new clsQuestionnaireEN()
{
QuestionId = objQuestionnaireENS.QuestionId, //题目Id
QuestionIndex = objQuestionnaireENS.QuestionIndex, //题目序号
QuestionName = objQuestionnaireENS.QuestionName, //题目名称
QuestionContent = objQuestionnaireENS.QuestionContent, //题目内容
QuestionMemo = objQuestionnaireENS.QuestionMemo, //题目说明
QuestionNo = objQuestionnaireENS.QuestionNo, //题目编号
ParentQuestionId = objQuestionnaireENS.ParentQuestionId, //父题目Id
ExamAnswer = objQuestionnaireENS.ExamAnswer, //题目答案
CourseId = objQuestionnaireENS.CourseId, //课程Id
LevelNo = objQuestionnaireENS.LevelNo, //学习关号2
CourseChapterId = objQuestionnaireENS.CourseChapterId, //课程章节ID
QuestionTypeId = objQuestionnaireENS.QuestionTypeId, //题目类型Id
QuestionTypeId4Course = objQuestionnaireENS.QuestionTypeId4Course, //题目类型Id4课程
AnswerTypeId = objQuestionnaireENS.AnswerTypeId, //答案类型ID
GridTitle = objQuestionnaireENS.GridTitle, //表格标题
AnswerModeId = objQuestionnaireENS.AnswerModeId, //答案模式Id
IsHaveAdditionalMemo = objQuestionnaireENS.IsHaveAdditionalMemo, //是否有附加说明
QuestionScore = objQuestionnaireENS.QuestionScore, //题目得分
DefaultValue = objQuestionnaireENS.DefaultValue, //缺省值
DefaultSelectItem = objQuestionnaireENS.DefaultSelectItem, //默认选项
IsShow = objQuestionnaireENS.IsShow, //是否启用
IsCast = objQuestionnaireENS.IsCast, //是否播放
LikeCount = objQuestionnaireENS.LikeCount, //资源喜欢数量
AnswerAttLimitSize = objQuestionnaireENS.AnswerAttLimitSize, //回答附件限制大小
LimitedResourceType = objQuestionnaireENS.LimitedResourceType, //限制资源类型
IsEffective = objQuestionnaireENS.IsEffective, //是否有效
IsCanInPaper = objQuestionnaireENS.IsCanInPaper, //是否可在Paper
ExamGradeId = objQuestionnaireENS.ExamGradeId, //题库等级ID
TextDirectId = objQuestionnaireENS.TextDirectId, //文本方向ID
UpdDate = objQuestionnaireENS.UpdDate, //修改日期
UpdUser = objQuestionnaireENS.UpdUser, //修改人
Memo = objQuestionnaireENS.Memo, //备注
QuestionCode = objQuestionnaireENS.QuestionCode, //html代码
DifficultyLevelId = objQuestionnaireENS.DifficultyLevelId, //难度等级Id
SectionTypeId = objQuestionnaireENS.SectionTypeId, //节点类型Id
KnowledgeGraphId = objQuestionnaireENS.KnowledgeGraphId, //知识点图Id
FirstIndent = objQuestionnaireENS.FirstIndent, //首行缩进
QuestionNameAdd = objQuestionnaireENS.QuestionNameAdd, //题目补充
CodeTab = objQuestionnaireENS.CodeTab, //代码表
CodeTabCode = objQuestionnaireENS.CodeTabCode, //CodeTab_Code
CodeTabCondition = objQuestionnaireENS.CodeTabCondition, //代码表_条件
CodeTabName = objQuestionnaireENS.CodeTabName, //CodeTab_Name
FillInTextHeight = objQuestionnaireENS.FillInTextHeight, //填空框高度
FillInTextWidth = objQuestionnaireENS.FillInTextWidth, //填空框宽度
IsMulti4FillInText = objQuestionnaireENS.IsMulti4FillInText, //是否填空框多行
CheckBoxLimitCount = objQuestionnaireENS.CheckBoxLimitCount, //复选框限制数
IsJs = objQuestionnaireENS.IsJs, //是否是JS
MemoTextWidth = objQuestionnaireENS.MemoTextWidth, //备注框宽度
RelaEvent = objQuestionnaireENS.RelaEvent, //相关事件
IsTest = objQuestionnaireENS.IsTest, //是否测试
LevelModeTypeId = objQuestionnaireENS.LevelModeTypeId, //模式Id
IsRandom = objQuestionnaireENS.IsRandom, //是否随机
};
 return objQuestionnaireENT;
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
public static void CheckPropertyNew(this clsQuestionnaireEN objQuestionnaireEN)
{
 clsQuestionnaireBL.QuestionnaireDA.CheckPropertyNew(objQuestionnaireEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQuestionnaireEN objQuestionnaireEN)
{
 clsQuestionnaireBL.QuestionnaireDA.CheckProperty4Condition(objQuestionnaireEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionnaireEN objQuestionnaireCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.QuestionId) == true)
{
string strComparisonOpQuestionId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.QuestionId, objQuestionnaireCond.QuestionId, strComparisonOpQuestionId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.QuestionIndex, objQuestionnaireCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.QuestionName) == true)
{
string strComparisonOpQuestionName = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionName, objQuestionnaireCond.QuestionName, strComparisonOpQuestionName);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.QuestionContent) == true)
{
string strComparisonOpQuestionContent = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionContent, objQuestionnaireCond.QuestionContent, strComparisonOpQuestionContent);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.QuestionMemo) == true)
{
string strComparisonOpQuestionMemo = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionMemo, objQuestionnaireCond.QuestionMemo, strComparisonOpQuestionMemo);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionNo, objQuestionnaireCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.ParentQuestionId) == true)
{
string strComparisonOpParentQuestionId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.ParentQuestionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.ParentQuestionId, objQuestionnaireCond.ParentQuestionId, strComparisonOpParentQuestionId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.ExamAnswer) == true)
{
string strComparisonOpExamAnswer = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.ExamAnswer, objQuestionnaireCond.ExamAnswer, strComparisonOpExamAnswer);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.CourseId) == true)
{
string strComparisonOpCourseId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CourseId, objQuestionnaireCond.CourseId, strComparisonOpCourseId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.LevelNo) == true)
{
string strComparisonOpLevelNo = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.LevelNo];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.LevelNo, objQuestionnaireCond.LevelNo, strComparisonOpLevelNo);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CourseChapterId, objQuestionnaireCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionTypeId, objQuestionnaireCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionTypeId4Course, objQuestionnaireCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.AnswerTypeId, objQuestionnaireCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.GridTitle) == true)
{
string strComparisonOpGridTitle = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.GridTitle, objQuestionnaireCond.GridTitle, strComparisonOpGridTitle);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.AnswerModeId, objQuestionnaireCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.IsHaveAdditionalMemo) == true)
{
if (objQuestionnaireCond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsHaveAdditionalMemo);
}
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.QuestionScore) == true)
{
string strComparisonOpQuestionScore = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.QuestionScore, objQuestionnaireCond.QuestionScore, strComparisonOpQuestionScore);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.DefaultValue, objQuestionnaireCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.DefaultSelectItem) == true)
{
string strComparisonOpDefaultSelectItem = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.DefaultSelectItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.DefaultSelectItem, objQuestionnaireCond.DefaultSelectItem, strComparisonOpDefaultSelectItem);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.IsShow) == true)
{
if (objQuestionnaireCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsShow);
}
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.IsCast) == true)
{
if (objQuestionnaireCond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsCast);
}
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.LikeCount) == true)
{
string strComparisonOpLikeCount = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.LikeCount, objQuestionnaireCond.LikeCount, strComparisonOpLikeCount);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.AnswerAttLimitSize) == true)
{
string strComparisonOpAnswerAttLimitSize = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.AnswerAttLimitSize, objQuestionnaireCond.AnswerAttLimitSize, strComparisonOpAnswerAttLimitSize);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.LimitedResourceType) == true)
{
string strComparisonOpLimitedResourceType = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.LimitedResourceType, objQuestionnaireCond.LimitedResourceType, strComparisonOpLimitedResourceType);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.IsEffective) == true)
{
if (objQuestionnaireCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsEffective);
}
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.IsCanInPaper) == true)
{
if (objQuestionnaireCond.IsCanInPaper == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsCanInPaper);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsCanInPaper);
}
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.ExamGradeId) == true)
{
string strComparisonOpExamGradeId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.ExamGradeId, objQuestionnaireCond.ExamGradeId, strComparisonOpExamGradeId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.TextDirectId) == true)
{
string strComparisonOpTextDirectId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.TextDirectId, objQuestionnaireCond.TextDirectId, strComparisonOpTextDirectId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.UpdDate) == true)
{
string strComparisonOpUpdDate = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.UpdDate, objQuestionnaireCond.UpdDate, strComparisonOpUpdDate);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.UpdUser) == true)
{
string strComparisonOpUpdUser = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.UpdUser, objQuestionnaireCond.UpdUser, strComparisonOpUpdUser);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.Memo) == true)
{
string strComparisonOpMemo = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.Memo, objQuestionnaireCond.Memo, strComparisonOpMemo);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.QuestionCode) == true)
{
string strComparisonOpQuestionCode = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.QuestionCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionCode, objQuestionnaireCond.QuestionCode, strComparisonOpQuestionCode);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.DifficultyLevelId) == true)
{
string strComparisonOpDifficultyLevelId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.DifficultyLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.DifficultyLevelId, objQuestionnaireCond.DifficultyLevelId, strComparisonOpDifficultyLevelId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.SectionTypeId) == true)
{
string strComparisonOpSectionTypeId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.SectionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.SectionTypeId, objQuestionnaireCond.SectionTypeId, strComparisonOpSectionTypeId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.KnowledgeGraphId) == true)
{
string strComparisonOpKnowledgeGraphId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.KnowledgeGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.KnowledgeGraphId, objQuestionnaireCond.KnowledgeGraphId, strComparisonOpKnowledgeGraphId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.FirstIndent) == true)
{
if (objQuestionnaireCond.FirstIndent == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.FirstIndent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.FirstIndent);
}
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.QuestionNameAdd) == true)
{
string strComparisonOpQuestionNameAdd = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.QuestionNameAdd];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.QuestionNameAdd, objQuestionnaireCond.QuestionNameAdd, strComparisonOpQuestionNameAdd);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.CodeTab) == true)
{
string strComparisonOpCodeTab = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CodeTab, objQuestionnaireCond.CodeTab, strComparisonOpCodeTab);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.CodeTabCode) == true)
{
string strComparisonOpCodeTabCode = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.CodeTabCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CodeTabCode, objQuestionnaireCond.CodeTabCode, strComparisonOpCodeTabCode);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.CodeTabCondition) == true)
{
string strComparisonOpCodeTabCondition = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.CodeTabCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CodeTabCondition, objQuestionnaireCond.CodeTabCondition, strComparisonOpCodeTabCondition);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.CodeTabName) == true)
{
string strComparisonOpCodeTabName = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.CodeTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.CodeTabName, objQuestionnaireCond.CodeTabName, strComparisonOpCodeTabName);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.FillInTextHeight) == true)
{
string strComparisonOpFillInTextHeight = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.FillInTextHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.FillInTextHeight, objQuestionnaireCond.FillInTextHeight, strComparisonOpFillInTextHeight);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.FillInTextWidth) == true)
{
string strComparisonOpFillInTextWidth = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.FillInTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.FillInTextWidth, objQuestionnaireCond.FillInTextWidth, strComparisonOpFillInTextWidth);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.IsMulti4FillInText) == true)
{
if (objQuestionnaireCond.IsMulti4FillInText == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsMulti4FillInText);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsMulti4FillInText);
}
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.CheckBoxLimitCount) == true)
{
string strComparisonOpCheckBoxLimitCount = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.CheckBoxLimitCount, objQuestionnaireCond.CheckBoxLimitCount, strComparisonOpCheckBoxLimitCount);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.IsJs) == true)
{
if (objQuestionnaireCond.IsJs == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsJs);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsJs);
}
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.MemoTextWidth) == true)
{
string strComparisonOpMemoTextWidth = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.MemoTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaire.MemoTextWidth, objQuestionnaireCond.MemoTextWidth, strComparisonOpMemoTextWidth);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.RelaEvent) == true)
{
string strComparisonOpRelaEvent = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.RelaEvent, objQuestionnaireCond.RelaEvent, strComparisonOpRelaEvent);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.IsTest) == true)
{
if (objQuestionnaireCond.IsTest == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsTest);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsTest);
}
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.LevelModeTypeId) == true)
{
string strComparisonOpLevelModeTypeId = objQuestionnaireCond.dicFldComparisonOp[conQuestionnaire.LevelModeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaire.LevelModeTypeId, objQuestionnaireCond.LevelModeTypeId, strComparisonOpLevelModeTypeId);
}
if (objQuestionnaireCond.IsUpdated(conQuestionnaire.IsRandom) == true)
{
if (objQuestionnaireCond.IsRandom == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaire.IsRandom);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaire.IsRandom);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Questionnaire(题目), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQuestionnaireEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQuestionnaireEN objQuestionnaireEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQuestionnaireEN == null) return true;
if (objQuestionnaireEN.QuestionId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objQuestionnaireEN.QuestionId);
if (clsQuestionnaireBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("QuestionId !=  {0}", objQuestionnaireEN.QuestionId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objQuestionnaireEN.QuestionId);
if (clsQuestionnaireBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Questionnaire(题目), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQuestionnaireEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQuestionnaireEN objQuestionnaireEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQuestionnaireEN == null) return "";
if (objQuestionnaireEN.QuestionId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objQuestionnaireEN.QuestionId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QuestionId !=  {0}", objQuestionnaireEN.QuestionId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objQuestionnaireEN.QuestionId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Questionnaire
{
public virtual bool UpdRelaTabDate(long lngQuestionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 题目(Questionnaire)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQuestionnaireBL
{
public static RelatedActions_Questionnaire relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQuestionnaireDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQuestionnaireDA QuestionnaireDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQuestionnaireDA();
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
 public clsQuestionnaireBL()
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
if (string.IsNullOrEmpty(clsQuestionnaireEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionnaireEN._ConnectString);
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
public static DataTable GetDataTable_Questionnaire(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QuestionnaireDA.GetDataTable_Questionnaire(strWhereCond);
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
objDT = QuestionnaireDA.GetDataTable(strWhereCond);
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
objDT = QuestionnaireDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QuestionnaireDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QuestionnaireDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QuestionnaireDA.GetDataTable_Top(objTopPara);
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
objDT = QuestionnaireDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QuestionnaireDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QuestionnaireDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQuestionnaireEN> GetObjLstByQuestionIdLst(List<long> arrQuestionIdLst)
{
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionIdLst);
 string strWhereCond = string.Format("QuestionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = Int32.Parse(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQuestionnaireEN> GetObjLstByQuestionIdLstCache(List<long> arrQuestionIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName, strCourseId);
List<clsQuestionnaireEN> arrQuestionnaireObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionnaireEN> arrQuestionnaireObjLst_Sel =
arrQuestionnaireObjLstCache
.Where(x => arrQuestionIdLst.Contains(x.QuestionId));
return arrQuestionnaireObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireEN> GetObjLst(string strWhereCond)
{
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = Int32.Parse(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireEN);
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
public static List<clsQuestionnaireEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = Int32.Parse(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQuestionnaireCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQuestionnaireEN> GetSubObjLstCache(clsQuestionnaireEN objQuestionnaireCond)
{
 string strCourseId = objQuestionnaireCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsQuestionnaireBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsQuestionnaireEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionnaireEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionnaire.AttributeName)
{
if (objQuestionnaireCond.IsUpdated(strFldName) == false) continue;
if (objQuestionnaireCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireCond[strFldName].ToString());
}
else
{
if (objQuestionnaireCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionnaireCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionnaireCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionnaireCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionnaireCond[strFldName]));
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
public static List<clsQuestionnaireEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = Int32.Parse(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireEN);
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
public static List<clsQuestionnaireEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = Int32.Parse(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireEN);
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
List<clsQuestionnaireEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQuestionnaireEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQuestionnaireEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
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
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = Int32.Parse(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireEN);
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
public static List<clsQuestionnaireEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = Int32.Parse(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQuestionnaireEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQuestionnaireEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = Int32.Parse(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireEN);
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
public static List<clsQuestionnaireEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = Int32.Parse(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = Int32.Parse(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQuestionnaireEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQuestionnaire(ref clsQuestionnaireEN objQuestionnaireEN)
{
bool bolResult = QuestionnaireDA.GetQuestionnaire(ref objQuestionnaireEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireEN GetObjByQuestionId(long lngQuestionId)
{
clsQuestionnaireEN objQuestionnaireEN = QuestionnaireDA.GetObjByQuestionId(lngQuestionId);
return objQuestionnaireEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQuestionnaireEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQuestionnaireEN objQuestionnaireEN = QuestionnaireDA.GetFirstObj(strWhereCond);
 return objQuestionnaireEN;
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
public static clsQuestionnaireEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQuestionnaireEN objQuestionnaireEN = QuestionnaireDA.GetObjByDataRow(objRow);
 return objQuestionnaireEN;
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
public static clsQuestionnaireEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQuestionnaireEN objQuestionnaireEN = QuestionnaireDA.GetObjByDataRow(objRow);
 return objQuestionnaireEN;
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
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <param name = "lstQuestionnaireObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionnaireEN GetObjByQuestionIdFromList(long lngQuestionId, List<clsQuestionnaireEN> lstQuestionnaireObjLst)
{
foreach (clsQuestionnaireEN objQuestionnaireEN in lstQuestionnaireObjLst)
{
if (objQuestionnaireEN.QuestionId == lngQuestionId)
{
return objQuestionnaireEN;
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
 long lngQuestionId;
 try
 {
 lngQuestionId = new clsQuestionnaireDA().GetFirstID(strWhereCond);
 return lngQuestionId;
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
 arrList = QuestionnaireDA.GetID(strWhereCond);
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
bool bolIsExist = QuestionnaireDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngQuestionId)
{
//检测记录是否存在
bool bolIsExist = QuestionnaireDA.IsExist(lngQuestionId);
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
 bolIsExist = clsQuestionnaireDA.IsExistTable();
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
 bolIsExist = QuestionnaireDA.IsExistTable(strTabName);
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
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQuestionnaireEN objQuestionnaireEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionnaireEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}]的数据已经存在!(in clsQuestionnaireBL.AddNewRecordBySql2)", objQuestionnaireEN.QuestionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QuestionnaireDA.AddNewRecordBySQL2(objQuestionnaireEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBL.ReFreshCache(objQuestionnaireEN.CourseId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
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
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQuestionnaireEN objQuestionnaireEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionnaireEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}]的数据已经存在!(in clsQuestionnaireBL.AddNewRecordBySql2WithReturnKey)", objQuestionnaireEN.QuestionId);
throw new Exception(strMsg);
}
try
{
string strKey = QuestionnaireDA.AddNewRecordBySQL2WithReturnKey(objQuestionnaireEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBL.ReFreshCache(objQuestionnaireEN.CourseId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
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
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQuestionnaireEN objQuestionnaireEN)
{
try
{
bool bolResult = QuestionnaireDA.Update(objQuestionnaireEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBL.ReFreshCache(objQuestionnaireEN.CourseId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
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
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQuestionnaireEN objQuestionnaireEN)
{
 if (objQuestionnaireEN.QuestionId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QuestionnaireDA.UpdateBySql2(objQuestionnaireEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBL.ReFreshCache(objQuestionnaireEN.CourseId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
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
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngQuestionId)
{
try
{
 clsQuestionnaireEN objQuestionnaireEN = clsQuestionnaireBL.GetObjByQuestionId(lngQuestionId);

if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(objQuestionnaireEN.QuestionId, objQuestionnaireEN.UpdUser);
}
if (objQuestionnaireEN != null)
{
int intRecNum = QuestionnaireDA.DelRecord(lngQuestionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQuestionnaireEN.CourseId);
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
/// <param name="lngQuestionId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngQuestionId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionnaireDA.GetSpecSQLObj();
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
//删除与表:[Questionnaire]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQuestionnaire.QuestionId,
//lngQuestionId);
//        clsQuestionnaireBL.DelQuestionnairesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionnaireBL.DelRecord(lngQuestionId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionnaireBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngQuestionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngQuestionId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQuestionnaireBL.relatedActions != null)
{
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(lngQuestionId, "UpdRelaTabDate");
}
bool bolResult = QuestionnaireDA.DelRecord(lngQuestionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrQuestionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQuestionnaires(List<string> arrQuestionIdLst)
{
if (arrQuestionIdLst.Count == 0) return 0;
try
{
if (clsQuestionnaireBL.relatedActions != null)
{
foreach (var strQuestionId in arrQuestionIdLst)
{
long lngQuestionId = long.Parse(strQuestionId);
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(lngQuestionId, "UpdRelaTabDate");
}
}
 clsQuestionnaireEN objQuestionnaireEN = clsQuestionnaireBL.GetObjByQuestionId(long.Parse(arrQuestionIdLst[0]));
int intDelRecNum = QuestionnaireDA.DelQuestionnaire(arrQuestionIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQuestionnaireEN.CourseId);
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
public static int DelQuestionnairesByCond(string strWhereCond)
{
try
{
if (clsQuestionnaireBL.relatedActions != null)
{
List<string> arrQuestionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strQuestionId in arrQuestionId)
{
long lngQuestionId = long.Parse(strQuestionId);
clsQuestionnaireBL.relatedActions.UpdRelaTabDate(lngQuestionId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conQuestionnaire.CourseId, strWhereCond);
int intRecNum = QuestionnaireDA.DelQuestionnaire(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Questionnaire]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngQuestionId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngQuestionId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionnaireDA.GetSpecSQLObj();
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
//删除与表:[Questionnaire]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionnaireBL.DelRecord(lngQuestionId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionnaireBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngQuestionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQuestionnaireENS">源对象</param>
 /// <param name = "objQuestionnaireENT">目标对象</param>
 public static void CopyTo(clsQuestionnaireEN objQuestionnaireENS, clsQuestionnaireEN objQuestionnaireENT)
{
try
{
objQuestionnaireENT.QuestionId = objQuestionnaireENS.QuestionId; //题目Id
objQuestionnaireENT.QuestionIndex = objQuestionnaireENS.QuestionIndex; //题目序号
objQuestionnaireENT.QuestionName = objQuestionnaireENS.QuestionName; //题目名称
objQuestionnaireENT.QuestionContent = objQuestionnaireENS.QuestionContent; //题目内容
objQuestionnaireENT.QuestionMemo = objQuestionnaireENS.QuestionMemo; //题目说明
objQuestionnaireENT.QuestionNo = objQuestionnaireENS.QuestionNo; //题目编号
objQuestionnaireENT.ParentQuestionId = objQuestionnaireENS.ParentQuestionId; //父题目Id
objQuestionnaireENT.ExamAnswer = objQuestionnaireENS.ExamAnswer; //题目答案
objQuestionnaireENT.CourseId = objQuestionnaireENS.CourseId; //课程Id
objQuestionnaireENT.LevelNo = objQuestionnaireENS.LevelNo; //学习关号2
objQuestionnaireENT.CourseChapterId = objQuestionnaireENS.CourseChapterId; //课程章节ID
objQuestionnaireENT.QuestionTypeId = objQuestionnaireENS.QuestionTypeId; //题目类型Id
objQuestionnaireENT.QuestionTypeId4Course = objQuestionnaireENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionnaireENT.AnswerTypeId = objQuestionnaireENS.AnswerTypeId; //答案类型ID
objQuestionnaireENT.GridTitle = objQuestionnaireENS.GridTitle; //表格标题
objQuestionnaireENT.AnswerModeId = objQuestionnaireENS.AnswerModeId; //答案模式Id
objQuestionnaireENT.IsHaveAdditionalMemo = objQuestionnaireENS.IsHaveAdditionalMemo; //是否有附加说明
objQuestionnaireENT.QuestionScore = objQuestionnaireENS.QuestionScore; //题目得分
objQuestionnaireENT.DefaultValue = objQuestionnaireENS.DefaultValue; //缺省值
objQuestionnaireENT.DefaultSelectItem = objQuestionnaireENS.DefaultSelectItem; //默认选项
objQuestionnaireENT.IsShow = objQuestionnaireENS.IsShow; //是否启用
objQuestionnaireENT.IsCast = objQuestionnaireENS.IsCast; //是否播放
objQuestionnaireENT.LikeCount = objQuestionnaireENS.LikeCount; //资源喜欢数量
objQuestionnaireENT.AnswerAttLimitSize = objQuestionnaireENS.AnswerAttLimitSize; //回答附件限制大小
objQuestionnaireENT.LimitedResourceType = objQuestionnaireENS.LimitedResourceType; //限制资源类型
objQuestionnaireENT.IsEffective = objQuestionnaireENS.IsEffective; //是否有效
objQuestionnaireENT.IsCanInPaper = objQuestionnaireENS.IsCanInPaper; //是否可在Paper
objQuestionnaireENT.ExamGradeId = objQuestionnaireENS.ExamGradeId; //题库等级ID
objQuestionnaireENT.TextDirectId = objQuestionnaireENS.TextDirectId; //文本方向ID
objQuestionnaireENT.UpdDate = objQuestionnaireENS.UpdDate; //修改日期
objQuestionnaireENT.UpdUser = objQuestionnaireENS.UpdUser; //修改人
objQuestionnaireENT.Memo = objQuestionnaireENS.Memo; //备注
objQuestionnaireENT.QuestionCode = objQuestionnaireENS.QuestionCode; //html代码
objQuestionnaireENT.DifficultyLevelId = objQuestionnaireENS.DifficultyLevelId; //难度等级Id
objQuestionnaireENT.SectionTypeId = objQuestionnaireENS.SectionTypeId; //节点类型Id
objQuestionnaireENT.KnowledgeGraphId = objQuestionnaireENS.KnowledgeGraphId; //知识点图Id
objQuestionnaireENT.FirstIndent = objQuestionnaireENS.FirstIndent; //首行缩进
objQuestionnaireENT.QuestionNameAdd = objQuestionnaireENS.QuestionNameAdd; //题目补充
objQuestionnaireENT.CodeTab = objQuestionnaireENS.CodeTab; //代码表
objQuestionnaireENT.CodeTabCode = objQuestionnaireENS.CodeTabCode; //CodeTab_Code
objQuestionnaireENT.CodeTabCondition = objQuestionnaireENS.CodeTabCondition; //代码表_条件
objQuestionnaireENT.CodeTabName = objQuestionnaireENS.CodeTabName; //CodeTab_Name
objQuestionnaireENT.FillInTextHeight = objQuestionnaireENS.FillInTextHeight; //填空框高度
objQuestionnaireENT.FillInTextWidth = objQuestionnaireENS.FillInTextWidth; //填空框宽度
objQuestionnaireENT.IsMulti4FillInText = objQuestionnaireENS.IsMulti4FillInText; //是否填空框多行
objQuestionnaireENT.CheckBoxLimitCount = objQuestionnaireENS.CheckBoxLimitCount; //复选框限制数
objQuestionnaireENT.IsJs = objQuestionnaireENS.IsJs; //是否是JS
objQuestionnaireENT.MemoTextWidth = objQuestionnaireENS.MemoTextWidth; //备注框宽度
objQuestionnaireENT.RelaEvent = objQuestionnaireENS.RelaEvent; //相关事件
objQuestionnaireENT.IsTest = objQuestionnaireENS.IsTest; //是否测试
objQuestionnaireENT.LevelModeTypeId = objQuestionnaireENS.LevelModeTypeId; //模式Id
objQuestionnaireENT.IsRandom = objQuestionnaireENS.IsRandom; //是否随机
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
 /// <param name = "objQuestionnaireEN">源简化对象</param>
 public static void SetUpdFlag(clsQuestionnaireEN objQuestionnaireEN)
{
try
{
objQuestionnaireEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQuestionnaireEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQuestionnaire.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.QuestionId = objQuestionnaireEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conQuestionnaire.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.QuestionIndex = objQuestionnaireEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(conQuestionnaire.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.QuestionName = objQuestionnaireEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(conQuestionnaire.QuestionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.QuestionContent = objQuestionnaireEN.QuestionContent == "[null]" ? null :  objQuestionnaireEN.QuestionContent; //题目内容
}
if (arrFldSet.Contains(conQuestionnaire.QuestionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.QuestionMemo = objQuestionnaireEN.QuestionMemo == "[null]" ? null :  objQuestionnaireEN.QuestionMemo; //题目说明
}
if (arrFldSet.Contains(conQuestionnaire.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.QuestionNo = objQuestionnaireEN.QuestionNo == "[null]" ? null :  objQuestionnaireEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(conQuestionnaire.ParentQuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.ParentQuestionId = objQuestionnaireEN.ParentQuestionId == "[null]" ? null :  objQuestionnaireEN.ParentQuestionId; //父题目Id
}
if (arrFldSet.Contains(conQuestionnaire.ExamAnswer, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.ExamAnswer = objQuestionnaireEN.ExamAnswer == "[null]" ? null :  objQuestionnaireEN.ExamAnswer; //题目答案
}
if (arrFldSet.Contains(conQuestionnaire.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.CourseId = objQuestionnaireEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conQuestionnaire.LevelNo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.LevelNo = objQuestionnaireEN.LevelNo; //学习关号2
}
if (arrFldSet.Contains(conQuestionnaire.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.CourseChapterId = objQuestionnaireEN.CourseChapterId == "[null]" ? null :  objQuestionnaireEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(conQuestionnaire.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.QuestionTypeId = objQuestionnaireEN.QuestionTypeId == "[null]" ? null :  objQuestionnaireEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(conQuestionnaire.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.QuestionTypeId4Course = objQuestionnaireEN.QuestionTypeId4Course == "[null]" ? null :  objQuestionnaireEN.QuestionTypeId4Course; //题目类型Id4课程
}
if (arrFldSet.Contains(conQuestionnaire.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.AnswerTypeId = objQuestionnaireEN.AnswerTypeId == "[null]" ? null :  objQuestionnaireEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(conQuestionnaire.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.GridTitle = objQuestionnaireEN.GridTitle == "[null]" ? null :  objQuestionnaireEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(conQuestionnaire.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.AnswerModeId = objQuestionnaireEN.AnswerModeId == "[null]" ? null :  objQuestionnaireEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(conQuestionnaire.IsHaveAdditionalMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.IsHaveAdditionalMemo = objQuestionnaireEN.IsHaveAdditionalMemo; //是否有附加说明
}
if (arrFldSet.Contains(conQuestionnaire.QuestionScore, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.QuestionScore = objQuestionnaireEN.QuestionScore; //题目得分
}
if (arrFldSet.Contains(conQuestionnaire.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.DefaultValue = objQuestionnaireEN.DefaultValue == "[null]" ? null :  objQuestionnaireEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(conQuestionnaire.DefaultSelectItem, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.DefaultSelectItem = objQuestionnaireEN.DefaultSelectItem == "[null]" ? null :  objQuestionnaireEN.DefaultSelectItem; //默认选项
}
if (arrFldSet.Contains(conQuestionnaire.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.IsShow = objQuestionnaireEN.IsShow; //是否启用
}
if (arrFldSet.Contains(conQuestionnaire.IsCast, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.IsCast = objQuestionnaireEN.IsCast; //是否播放
}
if (arrFldSet.Contains(conQuestionnaire.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.LikeCount = objQuestionnaireEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(conQuestionnaire.AnswerAttLimitSize, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.AnswerAttLimitSize = objQuestionnaireEN.AnswerAttLimitSize; //回答附件限制大小
}
if (arrFldSet.Contains(conQuestionnaire.LimitedResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.LimitedResourceType = objQuestionnaireEN.LimitedResourceType == "[null]" ? null :  objQuestionnaireEN.LimitedResourceType; //限制资源类型
}
if (arrFldSet.Contains(conQuestionnaire.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.IsEffective = objQuestionnaireEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(conQuestionnaire.IsCanInPaper, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.IsCanInPaper = objQuestionnaireEN.IsCanInPaper; //是否可在Paper
}
if (arrFldSet.Contains(conQuestionnaire.ExamGradeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.ExamGradeId = objQuestionnaireEN.ExamGradeId == "[null]" ? null :  objQuestionnaireEN.ExamGradeId; //题库等级ID
}
if (arrFldSet.Contains(conQuestionnaire.TextDirectId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.TextDirectId = objQuestionnaireEN.TextDirectId == "[null]" ? null :  objQuestionnaireEN.TextDirectId; //文本方向ID
}
if (arrFldSet.Contains(conQuestionnaire.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.UpdDate = objQuestionnaireEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQuestionnaire.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.UpdUser = objQuestionnaireEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conQuestionnaire.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.Memo = objQuestionnaireEN.Memo == "[null]" ? null :  objQuestionnaireEN.Memo; //备注
}
if (arrFldSet.Contains(conQuestionnaire.QuestionCode, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.QuestionCode = objQuestionnaireEN.QuestionCode == "[null]" ? null :  objQuestionnaireEN.QuestionCode; //html代码
}
if (arrFldSet.Contains(conQuestionnaire.DifficultyLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.DifficultyLevelId = objQuestionnaireEN.DifficultyLevelId == "[null]" ? null :  objQuestionnaireEN.DifficultyLevelId; //难度等级Id
}
if (arrFldSet.Contains(conQuestionnaire.SectionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.SectionTypeId = objQuestionnaireEN.SectionTypeId == "[null]" ? null :  objQuestionnaireEN.SectionTypeId; //节点类型Id
}
if (arrFldSet.Contains(conQuestionnaire.KnowledgeGraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.KnowledgeGraphId = objQuestionnaireEN.KnowledgeGraphId == "[null]" ? null :  objQuestionnaireEN.KnowledgeGraphId; //知识点图Id
}
if (arrFldSet.Contains(conQuestionnaire.FirstIndent, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.FirstIndent = objQuestionnaireEN.FirstIndent; //首行缩进
}
if (arrFldSet.Contains(conQuestionnaire.QuestionNameAdd, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.QuestionNameAdd = objQuestionnaireEN.QuestionNameAdd == "[null]" ? null :  objQuestionnaireEN.QuestionNameAdd; //题目补充
}
if (arrFldSet.Contains(conQuestionnaire.CodeTab, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.CodeTab = objQuestionnaireEN.CodeTab == "[null]" ? null :  objQuestionnaireEN.CodeTab; //代码表
}
if (arrFldSet.Contains(conQuestionnaire.CodeTabCode, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.CodeTabCode = objQuestionnaireEN.CodeTabCode == "[null]" ? null :  objQuestionnaireEN.CodeTabCode; //CodeTab_Code
}
if (arrFldSet.Contains(conQuestionnaire.CodeTabCondition, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.CodeTabCondition = objQuestionnaireEN.CodeTabCondition == "[null]" ? null :  objQuestionnaireEN.CodeTabCondition; //代码表_条件
}
if (arrFldSet.Contains(conQuestionnaire.CodeTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.CodeTabName = objQuestionnaireEN.CodeTabName == "[null]" ? null :  objQuestionnaireEN.CodeTabName; //CodeTab_Name
}
if (arrFldSet.Contains(conQuestionnaire.FillInTextHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.FillInTextHeight = objQuestionnaireEN.FillInTextHeight; //填空框高度
}
if (arrFldSet.Contains(conQuestionnaire.FillInTextWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.FillInTextWidth = objQuestionnaireEN.FillInTextWidth; //填空框宽度
}
if (arrFldSet.Contains(conQuestionnaire.IsMulti4FillInText, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.IsMulti4FillInText = objQuestionnaireEN.IsMulti4FillInText; //是否填空框多行
}
if (arrFldSet.Contains(conQuestionnaire.CheckBoxLimitCount, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.CheckBoxLimitCount = objQuestionnaireEN.CheckBoxLimitCount; //复选框限制数
}
if (arrFldSet.Contains(conQuestionnaire.IsJs, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.IsJs = objQuestionnaireEN.IsJs; //是否是JS
}
if (arrFldSet.Contains(conQuestionnaire.MemoTextWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.MemoTextWidth = objQuestionnaireEN.MemoTextWidth; //备注框宽度
}
if (arrFldSet.Contains(conQuestionnaire.RelaEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.RelaEvent = objQuestionnaireEN.RelaEvent == "[null]" ? null :  objQuestionnaireEN.RelaEvent; //相关事件
}
if (arrFldSet.Contains(conQuestionnaire.IsTest, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.IsTest = objQuestionnaireEN.IsTest; //是否测试
}
if (arrFldSet.Contains(conQuestionnaire.LevelModeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.LevelModeTypeId = objQuestionnaireEN.LevelModeTypeId; //模式Id
}
if (arrFldSet.Contains(conQuestionnaire.IsRandom, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireEN.IsRandom = objQuestionnaireEN.IsRandom; //是否随机
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
 /// <param name = "objQuestionnaireEN">源简化对象</param>
 public static void AccessFldValueNull(clsQuestionnaireEN objQuestionnaireEN)
{
try
{
if (objQuestionnaireEN.QuestionContent == "[null]") objQuestionnaireEN.QuestionContent = null; //题目内容
if (objQuestionnaireEN.QuestionMemo == "[null]") objQuestionnaireEN.QuestionMemo = null; //题目说明
if (objQuestionnaireEN.QuestionNo == "[null]") objQuestionnaireEN.QuestionNo = null; //题目编号
if (objQuestionnaireEN.ParentQuestionId == "[null]") objQuestionnaireEN.ParentQuestionId = null; //父题目Id
if (objQuestionnaireEN.ExamAnswer == "[null]") objQuestionnaireEN.ExamAnswer = null; //题目答案
if (objQuestionnaireEN.CourseChapterId == "[null]") objQuestionnaireEN.CourseChapterId = null; //课程章节ID
if (objQuestionnaireEN.QuestionTypeId == "[null]") objQuestionnaireEN.QuestionTypeId = null; //题目类型Id
if (objQuestionnaireEN.QuestionTypeId4Course == "[null]") objQuestionnaireEN.QuestionTypeId4Course = null; //题目类型Id4课程
if (objQuestionnaireEN.AnswerTypeId == "[null]") objQuestionnaireEN.AnswerTypeId = null; //答案类型ID
if (objQuestionnaireEN.GridTitle == "[null]") objQuestionnaireEN.GridTitle = null; //表格标题
if (objQuestionnaireEN.AnswerModeId == "[null]") objQuestionnaireEN.AnswerModeId = null; //答案模式Id
if (objQuestionnaireEN.DefaultValue == "[null]") objQuestionnaireEN.DefaultValue = null; //缺省值
if (objQuestionnaireEN.DefaultSelectItem == "[null]") objQuestionnaireEN.DefaultSelectItem = null; //默认选项
if (objQuestionnaireEN.LimitedResourceType == "[null]") objQuestionnaireEN.LimitedResourceType = null; //限制资源类型
if (objQuestionnaireEN.ExamGradeId == "[null]") objQuestionnaireEN.ExamGradeId = null; //题库等级ID
if (objQuestionnaireEN.TextDirectId == "[null]") objQuestionnaireEN.TextDirectId = null; //文本方向ID
if (objQuestionnaireEN.Memo == "[null]") objQuestionnaireEN.Memo = null; //备注
if (objQuestionnaireEN.QuestionCode == "[null]") objQuestionnaireEN.QuestionCode = null; //html代码
if (objQuestionnaireEN.DifficultyLevelId == "[null]") objQuestionnaireEN.DifficultyLevelId = null; //难度等级Id
if (objQuestionnaireEN.SectionTypeId == "[null]") objQuestionnaireEN.SectionTypeId = null; //节点类型Id
if (objQuestionnaireEN.KnowledgeGraphId == "[null]") objQuestionnaireEN.KnowledgeGraphId = null; //知识点图Id
if (objQuestionnaireEN.QuestionNameAdd == "[null]") objQuestionnaireEN.QuestionNameAdd = null; //题目补充
if (objQuestionnaireEN.CodeTab == "[null]") objQuestionnaireEN.CodeTab = null; //代码表
if (objQuestionnaireEN.CodeTabCode == "[null]") objQuestionnaireEN.CodeTabCode = null; //CodeTab_Code
if (objQuestionnaireEN.CodeTabCondition == "[null]") objQuestionnaireEN.CodeTabCondition = null; //代码表_条件
if (objQuestionnaireEN.CodeTabName == "[null]") objQuestionnaireEN.CodeTabName = null; //CodeTab_Name
if (objQuestionnaireEN.RelaEvent == "[null]") objQuestionnaireEN.RelaEvent = null; //相关事件
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
public static void CheckPropertyNew(clsQuestionnaireEN objQuestionnaireEN)
{
 QuestionnaireDA.CheckPropertyNew(objQuestionnaireEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQuestionnaireEN objQuestionnaireEN)
{
 QuestionnaireDA.CheckProperty4Condition(objQuestionnaireEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目]...","0");
List<clsQuestionnaireEN> arrQuestionnaireObjLst = GetAllQuestionnaireObjLstCache(strCourseId); 
arrQuestionnaireObjLst = arrQuestionnaireObjLst.OrderBy(x=>x.QuestionIndex).ToList(); 
objDDL.DataValueField = conQuestionnaire.QuestionId;
objDDL.DataTextField = conQuestionnaire.QuestionName;
objDDL.DataSource = arrQuestionnaireObjLst;
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
if (clsQuestionnaireBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBL没有刷新缓存机制(clsQuestionnaireBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionId");
//if (arrQuestionnaireObjLstCache == null)
//{
//arrQuestionnaireObjLstCache = QuestionnaireDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionnaireEN GetObjByQuestionIdCache(long lngQuestionId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName, strCourseId);
List<clsQuestionnaireEN> arrQuestionnaireObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionnaireEN> arrQuestionnaireObjLst_Sel =
arrQuestionnaireObjLstCache
.Where(x=> x.QuestionId == lngQuestionId 
);
if (arrQuestionnaireObjLst_Sel.Count() == 0)
{
   clsQuestionnaireEN obj = clsQuestionnaireBL.GetObjByQuestionId(lngQuestionId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngQuestionId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrQuestionnaireObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionNameByQuestionIdCache(long lngQuestionId, string strCourseId)
{
//获取缓存中的对象列表
clsQuestionnaireEN objQuestionnaire = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objQuestionnaire == null) return "";
return objQuestionnaire.QuestionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionIdCache(long lngQuestionId, string strCourseId)
{
//获取缓存中的对象列表
clsQuestionnaireEN objQuestionnaire = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objQuestionnaire == null) return "";
return objQuestionnaire.QuestionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireEN> GetAllQuestionnaireObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsQuestionnaireEN> arrQuestionnaireObjLstCache = GetObjLstCache(strCourseId); 
return arrQuestionnaireObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsQuestionnaireEN> arrQuestionnaireObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrQuestionnaireObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:QuestionTypeId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrQuestionnaireObjLst">需要排序的对象列表</param>
public static List <clsQuestionnaireEN> GetSubSet4QuestionnaireObjLstByQuestionTypeIdCache(string strQuestionTypeId, string strCourseId)
{
   if (string.IsNullOrEmpty(strQuestionTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName, strCourseId);
List<clsQuestionnaireEN> arrQuestionnaireObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionnaireEN> arrQuestionnaireObjLst_Sel1 =
from objQuestionnaireEN in arrQuestionnaireObjLstCache
where objQuestionnaireEN.QuestionTypeId == strQuestionTypeId
select objQuestionnaireEN;
List <clsQuestionnaireEN> arrQuestionnaireObjLst_Sel = new List<clsQuestionnaireEN>();
foreach (clsQuestionnaireEN obj in arrQuestionnaireObjLst_Sel1)
{
arrQuestionnaireObjLst_Sel.Add(obj);
}
return arrQuestionnaireObjLst_Sel;
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
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsQuestionnaireEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQuestionnaireEN._RefreshTimeLst.Count == 0) return "";
return clsQuestionnaireEN._RefreshTimeLst[clsQuestionnaireEN._RefreshTimeLst.Count - 1];
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
if (clsQuestionnaireBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQuestionnaireEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsQuestionnaireEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQuestionnaireBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Questionnaire(题目)
 /// 唯一性条件:QuestionID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQuestionnaireEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQuestionnaireEN objQuestionnaireEN)
{
//检测记录是否存在
string strResult = QuestionnaireDA.GetUniCondStr(objQuestionnaireEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngQuestionId, string strCourseId)
{
if (strInFldName != conQuestionnaire.QuestionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQuestionnaire.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQuestionnaire.AttributeName));
throw new Exception(strMsg);
}
var objQuestionnaire = clsQuestionnaireBL.GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objQuestionnaire == null) return "";
return objQuestionnaire[strOutFldName].ToString();
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
int intRecCount = clsQuestionnaireDA.GetRecCount(strTabName);
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
int intRecCount = clsQuestionnaireDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQuestionnaireDA.GetRecCount();
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
int intRecCount = clsQuestionnaireDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQuestionnaireCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQuestionnaireEN objQuestionnaireCond)
{
 string strCourseId = objQuestionnaireCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsQuestionnaireBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsQuestionnaireEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionnaireEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionnaire.AttributeName)
{
if (objQuestionnaireCond.IsUpdated(strFldName) == false) continue;
if (objQuestionnaireCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireCond[strFldName].ToString());
}
else
{
if (objQuestionnaireCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionnaireCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionnaireCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionnaireCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionnaireCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionnaireCond[strFldName]));
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
 List<string> arrList = clsQuestionnaireDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QuestionnaireDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QuestionnaireDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QuestionnaireDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionnaireDA.SetFldValue(clsQuestionnaireEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QuestionnaireDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionnaireDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionnaireDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionnaireDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Questionnaire] "); 
 strCreateTabCode.Append(" ( "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint primary key identity, "); 
 // /**题目序号*/ 
 strCreateTabCode.Append(" QuestionIndex int Null, "); 
 // /**题目名称*/ 
 strCreateTabCode.Append(" QuestionName varchar(500) not Null, "); 
 // /**题目内容*/ 
 strCreateTabCode.Append(" QuestionContent varchar(4000) Null, "); 
 // /**题目说明*/ 
 strCreateTabCode.Append(" QuestionMemo varchar(1000) Null, "); 
 // /**题目编号*/ 
 strCreateTabCode.Append(" QuestionNo varchar(10) Null, "); 
 // /**父题目Id*/ 
 strCreateTabCode.Append(" ParentQuestionId char(8) Null, "); 
 // /**题目答案*/ 
 strCreateTabCode.Append(" ExamAnswer varchar(8000) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**学习关号2*/ 
 strCreateTabCode.Append(" LevelNo int Null, "); 
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) Null, "); 
 // /**题目类型Id*/ 
 strCreateTabCode.Append(" QuestionTypeId char(2) Null, "); 
 // /**题目类型Id4课程*/ 
 strCreateTabCode.Append(" QuestionTypeId4Course char(8) Null, "); 
 // /**答案类型ID*/ 
 strCreateTabCode.Append(" AnswerTypeId char(2) Null, "); 
 // /**表格标题*/ 
 strCreateTabCode.Append(" GridTitle varchar(30) Null, "); 
 // /**答案模式Id*/ 
 strCreateTabCode.Append(" AnswerModeId char(4) Null, "); 
 // /**是否有附加说明*/ 
 strCreateTabCode.Append(" IsHaveAdditionalMemo bit Null, "); 
 // /**题目得分*/ 
 strCreateTabCode.Append(" QuestionScore float Null, "); 
 // /**缺省值*/ 
 strCreateTabCode.Append(" DefaultValue varchar(50) Null, "); 
 // /**默认选项*/ 
 strCreateTabCode.Append(" DefaultSelectItem varchar(20) Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" IsShow bit Null, "); 
 // /**是否播放*/ 
 strCreateTabCode.Append(" IsCast bit Null, "); 
 // /**资源喜欢数量*/ 
 strCreateTabCode.Append(" LikeCount bigint Null, "); 
 // /**回答附件限制大小*/ 
 strCreateTabCode.Append(" AnswerAttLimitSize bigint Null, "); 
 // /**限制资源类型*/ 
 strCreateTabCode.Append(" LimitedResourceType varchar(100) Null, "); 
 // /**是否有效*/ 
 strCreateTabCode.Append(" IsEffective bit Null, "); 
 // /**是否可在Paper*/ 
 strCreateTabCode.Append(" IsCanInPaper bit Null, "); 
 // /**题库等级ID*/ 
 strCreateTabCode.Append(" ExamGradeId char(2) Null, "); 
 // /**文本方向ID*/ 
 strCreateTabCode.Append(" TextDirectId char(4) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**html代码*/ 
 strCreateTabCode.Append(" QuestionCode varchar(8000) Null, "); 
 // /**难度等级Id*/ 
 strCreateTabCode.Append(" DifficultyLevelId char(2) Null, "); 
 // /**节点类型Id*/ 
 strCreateTabCode.Append(" SectionTypeId char(8) Null, "); 
 // /**知识点图Id*/ 
 strCreateTabCode.Append(" KnowledgeGraphId char(10) Null, "); 
 // /**首行缩进*/ 
 strCreateTabCode.Append(" FirstIndent bit Null, "); 
 // /**题目补充*/ 
 strCreateTabCode.Append(" QuestionNameAdd varchar(500) Null, "); 
 // /**代码表*/ 
 strCreateTabCode.Append(" CodeTab varchar(50) Null, "); 
 // /**CodeTab_Code*/ 
 strCreateTabCode.Append(" CodeTabCode varchar(50) Null, "); 
 // /**代码表_条件*/ 
 strCreateTabCode.Append(" CodeTabCondition varchar(200) Null, "); 
 // /**CodeTab_Name*/ 
 strCreateTabCode.Append(" CodeTabName varchar(50) Null, "); 
 // /**填空框高度*/ 
 strCreateTabCode.Append(" FillInTextHeight int Null, "); 
 // /**填空框宽度*/ 
 strCreateTabCode.Append(" FillInTextWidth int Null, "); 
 // /**是否填空框多行*/ 
 strCreateTabCode.Append(" IsMulti4FillInText bit Null, "); 
 // /**复选框限制数*/ 
 strCreateTabCode.Append(" CheckBoxLimitCount int Null, "); 
 // /**是否是JS*/ 
 strCreateTabCode.Append(" IsJs bit Null, "); 
 // /**备注框宽度*/ 
 strCreateTabCode.Append(" MemoTextWidth int Null, "); 
 // /**相关事件*/ 
 strCreateTabCode.Append(" RelaEvent varchar(4000) Null, "); 
 // /**是否测试*/ 
 strCreateTabCode.Append(" IsTest bit Null, "); 
 // /**模式Id*/ 
 strCreateTabCode.Append(" LevelModeTypeId char(2) not Null, "); 
 // /**是否随机*/ 
 strCreateTabCode.Append(" IsRandom bit Null, "); 
 // /**模式名*/ 
 strCreateTabCode.Append(" LevelModeTypeName varchar(100) Null, "); 
 // /**难度等级名称*/ 
 strCreateTabCode.Append(" DifficultyLevelName varchar(1000) Null, "); 
 // /**章名*/ 
 strCreateTabCode.Append(" ChapterName varchar(100) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**题目类型名*/ 
 strCreateTabCode.Append(" QuestionTypeName varchar(20) Null, "); 
 // /**答案内容*/ 
 strCreateTabCode.Append(" AnswerContent varchar(8000) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDateSim varchar(20) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：CourseId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strCourseId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strCourseId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQuestionnaire.CourseId, strCourseId);
 strCondition += string.Format(" order by QuestionIndex ");
List<clsQuestionnaireEN> arrQuestionnaireObjList = new clsQuestionnaireDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireObjList)
{
objQuestionnaire.QuestionIndex = intIndex;
UpdateBySql2(objQuestionnaire);
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
/// 调整所给关键字记录的序号。根据分类字段：CourseId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngQuestionId">所给的关键字</param>
/// <param name="strCourseId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngQuestionId ,string strCourseId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[QuestionId],获取相应的序号[QuestionIndex]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字QuestionId
//5、把当前关键字QuestionId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字QuestionId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevQuestionId = 0;    //上一条序号的关键字QuestionId
long lngNextQuestionId = 0;    //下一条序号的关键字QuestionId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[QuestionId],获取相应的序号[QuestionIndex]。

clsQuestionnaireEN objQuestionnaire = clsQuestionnaireBL.GetObjByQuestionId(lngQuestionId);

intOrderNum = objQuestionnaire.QuestionIndex ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQuestionnaire.CourseId, strCourseId);
intTabRecNum = clsQuestionnaireBL.GetRecCountByCond(clsQuestionnaireEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conQuestionnaire.QuestionIndex, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conQuestionnaire.CourseId, strCourseId);
//4、获取上一个序号字段的关键字QuestionId
lngPrevQuestionId = clsQuestionnaireBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevQuestionId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字QuestionId所对应记录的序号减1
//6、把下(上)一个序号关键字QuestionId所对应的记录序号加1
clsQuestionnaireBL.SetFldValue(clsQuestionnaireEN._CurrTabName, conQuestionnaire.QuestionIndex,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conQuestionnaire.QuestionId, lngQuestionId));
clsQuestionnaireBL.SetFldValue(clsQuestionnaireEN._CurrTabName, conQuestionnaire.QuestionIndex,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conQuestionnaire.QuestionId, lngPrevQuestionId));
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

//4、获取下一个序号字段的关键字QuestionId
sbCondition.AppendFormat(" {0} = {1} ", conQuestionnaire.QuestionIndex, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conQuestionnaire.CourseId, strCourseId);

lngNextQuestionId = clsQuestionnaireBL.GetFirstID_S(sbCondition.ToString());
if (lngNextQuestionId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字QuestionId所对应记录的序号加1
//6、把下(上)一个序号关键字QuestionId所对应的记录序号减1
clsQuestionnaireBL.SetFldValue(clsQuestionnaireEN._CurrTabName, conQuestionnaire.QuestionIndex,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conQuestionnaire.QuestionId, lngQuestionId));
clsQuestionnaireBL.SetFldValue(clsQuestionnaireEN._CurrTabName, conQuestionnaire.QuestionIndex,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conQuestionnaire.QuestionId, lngNextQuestionId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CourseId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,string strCourseId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conQuestionnaire.QuestionId, strKeyList);
List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(strCondition);
foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
{
objQuestionnaire.QuestionIndex = objQuestionnaire.QuestionIndex + 10000;
UpdateBySql2(objQuestionnaire);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQuestionnaire.CourseId, strCourseId);
 strCondition += string.Format(" order by QuestionIndex ");
List<clsQuestionnaireEN> arrQuestionnaireObjList = new clsQuestionnaireDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireObjList)
{
objQuestionnaire.QuestionIndex = intIndex;
UpdateBySql2(objQuestionnaire);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CourseId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strCourseId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,string strCourseId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conQuestionnaire.QuestionId, strKeyList);
List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(strCondition);
foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
{
objQuestionnaire.QuestionIndex = objQuestionnaire.QuestionIndex - 10000;
UpdateBySql2(objQuestionnaire);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQuestionnaire.CourseId, strCourseId);
 strCondition += string.Format(" order by QuestionIndex ");
List<clsQuestionnaireEN> arrQuestionnaireObjList = new clsQuestionnaireDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireObjList)
{
objQuestionnaire.QuestionIndex = intIndex;
UpdateBySql2(objQuestionnaire);
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
 /// 题目(Questionnaire)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Questionnaire : clsCommFun4BLV2
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
clsQuestionnaireBL.ReFreshThisCache(strCourseId);
}
}

}