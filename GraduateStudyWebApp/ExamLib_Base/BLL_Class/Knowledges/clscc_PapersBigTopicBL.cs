
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PapersBigTopicBL
 表名:cc_PapersBigTopic(01120077)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clscc_PapersBigTopicBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPapersBigTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PapersBigTopicEN GetObj(this K_PapersBigTopicId_cc_PapersBigTopic myKey)
{
clscc_PapersBigTopicEN objcc_PapersBigTopicEN = clscc_PapersBigTopicBL.cc_PapersBigTopicDA.GetObjByPapersBigTopicId(myKey.Value);
return objcc_PapersBigTopicEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_PapersBigTopicEN) == false)
{
var strMsg = string.Format("记录已经存在!试卷大题目名称 = [{0}]的数据已经存在!(in clscc_PapersBigTopicBL.AddNewRecord)", objcc_PapersBigTopicEN.PapersBigTopicName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.PapersBigTopicId) == true || clscc_PapersBigTopicBL.IsExist(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
     objcc_PapersBigTopicEN.PapersBigTopicId = clscc_PapersBigTopicBL.GetMaxStrId_S();
 }
bool bolResult = clscc_PapersBigTopicBL.cc_PapersBigTopicDA.AddNewRecordBySQL2(objcc_PapersBigTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
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
public static bool AddRecordEx(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clscc_PapersBigTopicBL.IsExist(objcc_PapersBigTopicEN.PapersBigTopicId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objcc_PapersBigTopicEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_PapersBigTopicEN.CheckUniqueness() == false)
{
strMsg = string.Format("(试卷大题目名称(PapersBigTopicName)=[{0}])已经存在,不能重复!", objcc_PapersBigTopicEN.PapersBigTopicName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.PapersBigTopicId) == true || clscc_PapersBigTopicBL.IsExist(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
     objcc_PapersBigTopicEN.PapersBigTopicId = clscc_PapersBigTopicBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objcc_PapersBigTopicEN.AddNewRecord();
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
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_PapersBigTopicEN) == false)
{
var strMsg = string.Format("记录已经存在!试卷大题目名称 = [{0}]的数据已经存在!(in clscc_PapersBigTopicBL.AddNewRecordWithMaxId)", objcc_PapersBigTopicEN.PapersBigTopicName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.PapersBigTopicId) == true || clscc_PapersBigTopicBL.IsExist(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
     objcc_PapersBigTopicEN.PapersBigTopicId = clscc_PapersBigTopicBL.GetMaxStrId_S();
 }
string strPapersBigTopicId = clscc_PapersBigTopicBL.cc_PapersBigTopicDA.AddNewRecordBySQL2WithReturnKey(objcc_PapersBigTopicEN);
     objcc_PapersBigTopicEN.PapersBigTopicId = strPapersBigTopicId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
}
return strPapersBigTopicId;
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
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_PapersBigTopicEN) == false)
{
var strMsg = string.Format("记录已经存在!试卷大题目名称 = [{0}]的数据已经存在!(in clscc_PapersBigTopicBL.AddNewRecordWithReturnKey)", objcc_PapersBigTopicEN.PapersBigTopicName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.PapersBigTopicId) == true || clscc_PapersBigTopicBL.IsExist(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
     objcc_PapersBigTopicEN.PapersBigTopicId = clscc_PapersBigTopicBL.GetMaxStrId_S();
 }
string strKey = clscc_PapersBigTopicBL.cc_PapersBigTopicDA.AddNewRecordBySQL2WithReturnKey(objcc_PapersBigTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicEN SetPapersBigTopicId(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strPapersBigTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicId, 8, concc_PapersBigTopic.PapersBigTopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicId, 8, concc_PapersBigTopic.PapersBigTopicId);
}
objcc_PapersBigTopicEN.PapersBigTopicId = strPapersBigTopicId; //试卷大题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.PapersBigTopicId) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.PapersBigTopicId, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.PapersBigTopicId] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicEN SetPapersBigTopicName(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strPapersBigTopicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPapersBigTopicName, concc_PapersBigTopic.PapersBigTopicName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, concc_PapersBigTopic.PapersBigTopicName);
}
objcc_PapersBigTopicEN.PapersBigTopicName = strPapersBigTopicName; //试卷大题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.PapersBigTopicName) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.PapersBigTopicName, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.PapersBigTopicName] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicEN SetTopicDescription(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strTopicDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, concc_PapersBigTopic.TopicDescription);
}
objcc_PapersBigTopicEN.TopicDescription = strTopicDescription; //标题描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.TopicDescription) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.TopicDescription, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.TopicDescription] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicEN SetTopicScores(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, int? intTopicScores, string strComparisonOp="")
	{
objcc_PapersBigTopicEN.TopicScores = intTopicScores; //大题得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.TopicScores) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.TopicScores, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.TopicScores] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicEN SetCourseExamPaperId(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseExamPaperId, concc_PapersBigTopic.CourseExamPaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_PapersBigTopic.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_PapersBigTopic.CourseExamPaperId);
}
objcc_PapersBigTopicEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.CourseExamPaperId) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicEN SetQuestionTypeId(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, concc_PapersBigTopic.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, concc_PapersBigTopic.QuestionTypeId);
}
objcc_PapersBigTopicEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.QuestionTypeId) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.QuestionTypeId, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.QuestionTypeId] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicEN SetIsShow(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, bool bolIsShow, string strComparisonOp="")
	{
objcc_PapersBigTopicEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.IsShow) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.IsShow, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.IsShow] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicEN SetOrderNum(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, int? intOrderNum, string strComparisonOp="")
	{
objcc_PapersBigTopicEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.OrderNum) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.OrderNum, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.OrderNum] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicEN SetUpdDate(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_PapersBigTopic.UpdDate);
}
objcc_PapersBigTopicEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.UpdDate) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.UpdDate, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.UpdDate] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicEN SetUpdUser(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_PapersBigTopic.UpdUser);
}
objcc_PapersBigTopicEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.UpdUser) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.UpdUser, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.UpdUser] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicEN SetMemo(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_PapersBigTopic.Memo);
}
objcc_PapersBigTopicEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopic.Memo) == false)
{
objcc_PapersBigTopicEN.dicFldComparisonOp.Add(concc_PapersBigTopic.Memo, strComparisonOp);
}
else
{
objcc_PapersBigTopicEN.dicFldComparisonOp[concc_PapersBigTopic.Memo] = strComparisonOp;
}
}
return objcc_PapersBigTopicEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_PapersBigTopicEN.CheckPropertyNew();
clscc_PapersBigTopicEN objcc_PapersBigTopicCond = new clscc_PapersBigTopicEN();
string strCondition = objcc_PapersBigTopicCond
.SetPapersBigTopicId(objcc_PapersBigTopicEN.PapersBigTopicId, "<>")
.SetPapersBigTopicName(objcc_PapersBigTopicEN.PapersBigTopicName, "=")
.GetCombineCondition();
objcc_PapersBigTopicEN._IsCheckProperty = true;
bool bolIsExist = clscc_PapersBigTopicBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PapersBigTopicName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_PapersBigTopicEN.Update();
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
 /// <param name = "objcc_PapersBigTopic">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_PapersBigTopicEN objcc_PapersBigTopic)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_PapersBigTopicEN objcc_PapersBigTopicCond = new clscc_PapersBigTopicEN();
string strCondition = objcc_PapersBigTopicCond
.SetPapersBigTopicName(objcc_PapersBigTopic.PapersBigTopicName, "=")
.GetCombineCondition();
objcc_PapersBigTopic._IsCheckProperty = true;
bool bolIsExist = clscc_PapersBigTopicBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_PapersBigTopic.PapersBigTopicId = clscc_PapersBigTopicBL.GetFirstID_S(strCondition);
objcc_PapersBigTopic.UpdateWithCondition(strCondition);
}
else
{
objcc_PapersBigTopic.PapersBigTopicId = clscc_PapersBigTopicBL.GetMaxStrId_S();
objcc_PapersBigTopic.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_PapersBigTopicBL.cc_PapersBigTopicDA.UpdateBySql2(objcc_PapersBigTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_PapersBigTopicBL.cc_PapersBigTopicDA.UpdateBySql2(objcc_PapersBigTopicEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strWhereCond)
{
try
{
bool bolResult = clscc_PapersBigTopicBL.cc_PapersBigTopicDA.UpdateBySqlWithCondition(objcc_PapersBigTopicEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_PapersBigTopicBL.cc_PapersBigTopicDA.UpdateBySqlWithConditionTransaction(objcc_PapersBigTopicEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
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
 /// <param name = "strPapersBigTopicId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
try
{
int intRecNum = clscc_PapersBigTopicBL.cc_PapersBigTopicDA.DelRecord(objcc_PapersBigTopicEN.PapersBigTopicId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicENS">源对象</param>
 /// <param name = "objcc_PapersBigTopicENT">目标对象</param>
 public static void CopyTo(this clscc_PapersBigTopicEN objcc_PapersBigTopicENS, clscc_PapersBigTopicEN objcc_PapersBigTopicENT)
{
try
{
objcc_PapersBigTopicENT.PapersBigTopicId = objcc_PapersBigTopicENS.PapersBigTopicId; //试卷大题目Id
objcc_PapersBigTopicENT.PapersBigTopicName = objcc_PapersBigTopicENS.PapersBigTopicName; //试卷大题目名称
objcc_PapersBigTopicENT.TopicDescription = objcc_PapersBigTopicENS.TopicDescription; //标题描述
objcc_PapersBigTopicENT.TopicScores = objcc_PapersBigTopicENS.TopicScores; //大题得分
objcc_PapersBigTopicENT.CourseExamPaperId = objcc_PapersBigTopicENS.CourseExamPaperId; //考卷流水号
objcc_PapersBigTopicENT.QuestionTypeId = objcc_PapersBigTopicENS.QuestionTypeId; //题目类型Id
objcc_PapersBigTopicENT.IsShow = objcc_PapersBigTopicENS.IsShow; //是否启用
objcc_PapersBigTopicENT.OrderNum = objcc_PapersBigTopicENS.OrderNum; //序号
objcc_PapersBigTopicENT.UpdDate = objcc_PapersBigTopicENS.UpdDate; //修改日期
objcc_PapersBigTopicENT.UpdUser = objcc_PapersBigTopicENS.UpdUser; //修改人
objcc_PapersBigTopicENT.Memo = objcc_PapersBigTopicENS.Memo; //备注
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
 /// <param name = "objcc_PapersBigTopicENS">源对象</param>
 /// <returns>目标对象=>clscc_PapersBigTopicEN:objcc_PapersBigTopicENT</returns>
 public static clscc_PapersBigTopicEN CopyTo(this clscc_PapersBigTopicEN objcc_PapersBigTopicENS)
{
try
{
 clscc_PapersBigTopicEN objcc_PapersBigTopicENT = new clscc_PapersBigTopicEN()
{
PapersBigTopicId = objcc_PapersBigTopicENS.PapersBigTopicId, //试卷大题目Id
PapersBigTopicName = objcc_PapersBigTopicENS.PapersBigTopicName, //试卷大题目名称
TopicDescription = objcc_PapersBigTopicENS.TopicDescription, //标题描述
TopicScores = objcc_PapersBigTopicENS.TopicScores, //大题得分
CourseExamPaperId = objcc_PapersBigTopicENS.CourseExamPaperId, //考卷流水号
QuestionTypeId = objcc_PapersBigTopicENS.QuestionTypeId, //题目类型Id
IsShow = objcc_PapersBigTopicENS.IsShow, //是否启用
OrderNum = objcc_PapersBigTopicENS.OrderNum, //序号
UpdDate = objcc_PapersBigTopicENS.UpdDate, //修改日期
UpdUser = objcc_PapersBigTopicENS.UpdUser, //修改人
Memo = objcc_PapersBigTopicENS.Memo, //备注
};
 return objcc_PapersBigTopicENT;
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
public static void CheckPropertyNew(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 clscc_PapersBigTopicBL.cc_PapersBigTopicDA.CheckPropertyNew(objcc_PapersBigTopicEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 clscc_PapersBigTopicBL.cc_PapersBigTopicDA.CheckProperty4Condition(objcc_PapersBigTopicEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_PapersBigTopicEN objcc_PapersBigTopicCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_PapersBigTopicCond.IsUpdated(concc_PapersBigTopic.PapersBigTopicId) == true)
{
string strComparisonOpPapersBigTopicId = objcc_PapersBigTopicCond.dicFldComparisonOp[concc_PapersBigTopic.PapersBigTopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.PapersBigTopicId, objcc_PapersBigTopicCond.PapersBigTopicId, strComparisonOpPapersBigTopicId);
}
if (objcc_PapersBigTopicCond.IsUpdated(concc_PapersBigTopic.PapersBigTopicName) == true)
{
string strComparisonOpPapersBigTopicName = objcc_PapersBigTopicCond.dicFldComparisonOp[concc_PapersBigTopic.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.PapersBigTopicName, objcc_PapersBigTopicCond.PapersBigTopicName, strComparisonOpPapersBigTopicName);
}
if (objcc_PapersBigTopicCond.IsUpdated(concc_PapersBigTopic.TopicDescription) == true)
{
string strComparisonOpTopicDescription = objcc_PapersBigTopicCond.dicFldComparisonOp[concc_PapersBigTopic.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.TopicDescription, objcc_PapersBigTopicCond.TopicDescription, strComparisonOpTopicDescription);
}
if (objcc_PapersBigTopicCond.IsUpdated(concc_PapersBigTopic.TopicScores) == true)
{
string strComparisonOpTopicScores = objcc_PapersBigTopicCond.dicFldComparisonOp[concc_PapersBigTopic.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PapersBigTopic.TopicScores, objcc_PapersBigTopicCond.TopicScores, strComparisonOpTopicScores);
}
if (objcc_PapersBigTopicCond.IsUpdated(concc_PapersBigTopic.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objcc_PapersBigTopicCond.dicFldComparisonOp[concc_PapersBigTopic.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.CourseExamPaperId, objcc_PapersBigTopicCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objcc_PapersBigTopicCond.IsUpdated(concc_PapersBigTopic.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objcc_PapersBigTopicCond.dicFldComparisonOp[concc_PapersBigTopic.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.QuestionTypeId, objcc_PapersBigTopicCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objcc_PapersBigTopicCond.IsUpdated(concc_PapersBigTopic.IsShow) == true)
{
if (objcc_PapersBigTopicCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PapersBigTopic.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PapersBigTopic.IsShow);
}
}
if (objcc_PapersBigTopicCond.IsUpdated(concc_PapersBigTopic.OrderNum) == true)
{
string strComparisonOpOrderNum = objcc_PapersBigTopicCond.dicFldComparisonOp[concc_PapersBigTopic.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PapersBigTopic.OrderNum, objcc_PapersBigTopicCond.OrderNum, strComparisonOpOrderNum);
}
if (objcc_PapersBigTopicCond.IsUpdated(concc_PapersBigTopic.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_PapersBigTopicCond.dicFldComparisonOp[concc_PapersBigTopic.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.UpdDate, objcc_PapersBigTopicCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_PapersBigTopicCond.IsUpdated(concc_PapersBigTopic.UpdUser) == true)
{
string strComparisonOpUpdUser = objcc_PapersBigTopicCond.dicFldComparisonOp[concc_PapersBigTopic.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.UpdUser, objcc_PapersBigTopicCond.UpdUser, strComparisonOpUpdUser);
}
if (objcc_PapersBigTopicCond.IsUpdated(concc_PapersBigTopic.Memo) == true)
{
string strComparisonOpMemo = objcc_PapersBigTopicCond.dicFldComparisonOp[concc_PapersBigTopic.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopic.Memo, objcc_PapersBigTopicCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_PapersBigTopic(试卷大题目), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PapersBigTopicName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_PapersBigTopicEN == null) return true;
if (objcc_PapersBigTopicEN.PapersBigTopicId == null || objcc_PapersBigTopicEN.PapersBigTopicId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PapersBigTopicName = '{0}'", objcc_PapersBigTopicEN.PapersBigTopicName);
if (clscc_PapersBigTopicBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PapersBigTopicId !=  '{0}'", objcc_PapersBigTopicEN.PapersBigTopicId);
 sbCondition.AppendFormat(" and PapersBigTopicName = '{0}'", objcc_PapersBigTopicEN.PapersBigTopicName);
if (clscc_PapersBigTopicBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_PapersBigTopic(试卷大题目), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PapersBigTopicName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_PapersBigTopicEN == null) return "";
if (objcc_PapersBigTopicEN.PapersBigTopicId == null || objcc_PapersBigTopicEN.PapersBigTopicId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PapersBigTopicName = '{0}'", objcc_PapersBigTopicEN.PapersBigTopicName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PapersBigTopicId !=  '{0}'", objcc_PapersBigTopicEN.PapersBigTopicId);
 sbCondition.AppendFormat(" and PapersBigTopicName = '{0}'", objcc_PapersBigTopicEN.PapersBigTopicName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_PapersBigTopic
{
public virtual bool UpdRelaTabDate(string strPapersBigTopicId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 试卷大题目(cc_PapersBigTopic)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_PapersBigTopicBL
{
public static RelatedActions_cc_PapersBigTopic relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_PapersBigTopicDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_PapersBigTopicDA cc_PapersBigTopicDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_PapersBigTopicDA();
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
 public clscc_PapersBigTopicBL()
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
if (string.IsNullOrEmpty(clscc_PapersBigTopicEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_PapersBigTopicEN._ConnectString);
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
public static DataTable GetDataTable_cc_PapersBigTopic(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_PapersBigTopicDA.GetDataTable_cc_PapersBigTopic(strWhereCond);
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
objDT = cc_PapersBigTopicDA.GetDataTable(strWhereCond);
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
objDT = cc_PapersBigTopicDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_PapersBigTopicDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_PapersBigTopicDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_PapersBigTopicDA.GetDataTable_Top(objTopPara);
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
objDT = cc_PapersBigTopicDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_PapersBigTopicDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_PapersBigTopicDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPapersBigTopicIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_PapersBigTopicEN> GetObjLstByPapersBigTopicIdLst(List<string> arrPapersBigTopicIdLst)
{
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPapersBigTopicIdLst, true);
 string strWhereCond = string.Format("PapersBigTopicId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPapersBigTopicIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_PapersBigTopicEN> GetObjLstByPapersBigTopicIdLstCache(List<string> arrPapersBigTopicIdLst)
{
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName);
List<clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLstCache = GetObjLstCache();
IEnumerable <clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Sel =
arrcc_PapersBigTopicObjLstCache
.Where(x => arrPapersBigTopicIdLst.Contains(x.PapersBigTopicId));
return arrcc_PapersBigTopicObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PapersBigTopicEN> GetObjLst(string strWhereCond)
{
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicEN);
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
public static List<clscc_PapersBigTopicEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_PapersBigTopicEN> GetSubObjLstCache(clscc_PapersBigTopicEN objcc_PapersBigTopicCond)
{
List<clscc_PapersBigTopicEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_PapersBigTopicEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_PapersBigTopic.AttributeName)
{
if (objcc_PapersBigTopicCond.IsUpdated(strFldName) == false) continue;
if (objcc_PapersBigTopicCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PapersBigTopicCond[strFldName].ToString());
}
else
{
if (objcc_PapersBigTopicCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_PapersBigTopicCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PapersBigTopicCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_PapersBigTopicCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_PapersBigTopicCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_PapersBigTopicCond[strFldName]));
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
public static List<clscc_PapersBigTopicEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicEN);
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
public static List<clscc_PapersBigTopicEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicEN);
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
List<clscc_PapersBigTopicEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_PapersBigTopicEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PapersBigTopicEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_PapersBigTopicEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
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
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicEN);
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
public static List<clscc_PapersBigTopicEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_PapersBigTopicEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_PapersBigTopicEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicEN);
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
public static List<clscc_PapersBigTopicEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PapersBigTopicEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_PapersBigTopic(ref clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
bool bolResult = cc_PapersBigTopicDA.Getcc_PapersBigTopic(ref objcc_PapersBigTopicEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPapersBigTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PapersBigTopicEN GetObjByPapersBigTopicId(string strPapersBigTopicId)
{
if (strPapersBigTopicId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPapersBigTopicId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPapersBigTopicId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPapersBigTopicId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_PapersBigTopicEN objcc_PapersBigTopicEN = cc_PapersBigTopicDA.GetObjByPapersBigTopicId(strPapersBigTopicId);
return objcc_PapersBigTopicEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_PapersBigTopicEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_PapersBigTopicEN objcc_PapersBigTopicEN = cc_PapersBigTopicDA.GetFirstObj(strWhereCond);
 return objcc_PapersBigTopicEN;
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
public static clscc_PapersBigTopicEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_PapersBigTopicEN objcc_PapersBigTopicEN = cc_PapersBigTopicDA.GetObjByDataRow(objRow);
 return objcc_PapersBigTopicEN;
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
public static clscc_PapersBigTopicEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_PapersBigTopicEN objcc_PapersBigTopicEN = cc_PapersBigTopicDA.GetObjByDataRow(objRow);
 return objcc_PapersBigTopicEN;
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
 /// <param name = "strPapersBigTopicId">所给的关键字</param>
 /// <param name = "lstcc_PapersBigTopicObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_PapersBigTopicEN GetObjByPapersBigTopicIdFromList(string strPapersBigTopicId, List<clscc_PapersBigTopicEN> lstcc_PapersBigTopicObjLst)
{
foreach (clscc_PapersBigTopicEN objcc_PapersBigTopicEN in lstcc_PapersBigTopicObjLst)
{
if (objcc_PapersBigTopicEN.PapersBigTopicId == strPapersBigTopicId)
{
return objcc_PapersBigTopicEN;
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
 string strMaxPapersBigTopicId;
 try
 {
 strMaxPapersBigTopicId = clscc_PapersBigTopicDA.GetMaxStrId();
 return strMaxPapersBigTopicId;
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
 string strPapersBigTopicId;
 try
 {
 strPapersBigTopicId = new clscc_PapersBigTopicDA().GetFirstID(strWhereCond);
 return strPapersBigTopicId;
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
 arrList = cc_PapersBigTopicDA.GetID(strWhereCond);
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
bool bolIsExist = cc_PapersBigTopicDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPapersBigTopicId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPapersBigTopicId)
{
if (string.IsNullOrEmpty(strPapersBigTopicId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPapersBigTopicId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_PapersBigTopicDA.IsExist(strPapersBigTopicId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strPapersBigTopicId">试卷大题目Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strPapersBigTopicId, string strOpUser)
{
clscc_PapersBigTopicEN objcc_PapersBigTopicEN = clscc_PapersBigTopicBL.GetObjByPapersBigTopicId(strPapersBigTopicId);
objcc_PapersBigTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_PapersBigTopicEN.UpdUser = strOpUser;
return clscc_PapersBigTopicBL.UpdateBySql2(objcc_PapersBigTopicEN);
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
 bolIsExist = clscc_PapersBigTopicDA.IsExistTable();
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
 bolIsExist = cc_PapersBigTopicDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_PapersBigTopicEN objcc_PapersBigTopicEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_PapersBigTopicEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!试卷大题目名称 = [{0}]的数据已经存在!(in clscc_PapersBigTopicBL.AddNewRecordBySql2)", objcc_PapersBigTopicEN.PapersBigTopicName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.PapersBigTopicId) == true || clscc_PapersBigTopicBL.IsExist(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
     objcc_PapersBigTopicEN.PapersBigTopicId = clscc_PapersBigTopicBL.GetMaxStrId_S();
 }
bool bolResult = cc_PapersBigTopicDA.AddNewRecordBySQL2(objcc_PapersBigTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_PapersBigTopicEN objcc_PapersBigTopicEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_PapersBigTopicEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!试卷大题目名称 = [{0}]的数据已经存在!(in clscc_PapersBigTopicBL.AddNewRecordBySql2WithReturnKey)", objcc_PapersBigTopicEN.PapersBigTopicName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.PapersBigTopicId) == true || clscc_PapersBigTopicBL.IsExist(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
     objcc_PapersBigTopicEN.PapersBigTopicId = clscc_PapersBigTopicBL.GetMaxStrId_S();
 }
string strKey = cc_PapersBigTopicDA.AddNewRecordBySQL2WithReturnKey(objcc_PapersBigTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
try
{
bool bolResult = cc_PapersBigTopicDA.Update(objcc_PapersBigTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicEN.PapersBigTopicId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_PapersBigTopicDA.UpdateBySql2(objcc_PapersBigTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicBL.ReFreshCache();

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
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
 /// <param name = "strPapersBigTopicId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPapersBigTopicId)
{
try
{
 clscc_PapersBigTopicEN objcc_PapersBigTopicEN = clscc_PapersBigTopicBL.GetObjByPapersBigTopicId(strPapersBigTopicId);

if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicEN.PapersBigTopicId, objcc_PapersBigTopicEN.UpdUser);
}
if (objcc_PapersBigTopicEN != null)
{
int intRecNum = cc_PapersBigTopicDA.DelRecord(strPapersBigTopicId);
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
/// <param name="strPapersBigTopicId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPapersBigTopicId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
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
//删除与表:[cc_PapersBigTopic]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_PapersBigTopic.PapersBigTopicId,
//strPapersBigTopicId);
//        clscc_PapersBigTopicBL.Delcc_PapersBigTopicsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_PapersBigTopicBL.DelRecord(strPapersBigTopicId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_PapersBigTopicBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPapersBigTopicId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPapersBigTopicId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPapersBigTopicId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_PapersBigTopicBL.relatedActions != null)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(strPapersBigTopicId, "UpdRelaTabDate");
}
bool bolResult = cc_PapersBigTopicDA.DelRecord(strPapersBigTopicId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPapersBigTopicIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_PapersBigTopics(List<string> arrPapersBigTopicIdLst)
{
if (arrPapersBigTopicIdLst.Count == 0) return 0;
try
{
if (clscc_PapersBigTopicBL.relatedActions != null)
{
foreach (var strPapersBigTopicId in arrPapersBigTopicIdLst)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(strPapersBigTopicId, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_PapersBigTopicDA.Delcc_PapersBigTopic(arrPapersBigTopicIdLst);
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
public static int Delcc_PapersBigTopicsByCond(string strWhereCond)
{
try
{
if (clscc_PapersBigTopicBL.relatedActions != null)
{
List<string> arrPapersBigTopicId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPapersBigTopicId in arrPapersBigTopicId)
{
clscc_PapersBigTopicBL.relatedActions.UpdRelaTabDate(strPapersBigTopicId, "UpdRelaTabDate");
}
}
int intRecNum = cc_PapersBigTopicDA.Delcc_PapersBigTopic(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_PapersBigTopic]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPapersBigTopicId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPapersBigTopicId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
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
//删除与表:[cc_PapersBigTopic]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_PapersBigTopicBL.DelRecord(strPapersBigTopicId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_PapersBigTopicBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPapersBigTopicId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_PapersBigTopicENS">源对象</param>
 /// <param name = "objcc_PapersBigTopicENT">目标对象</param>
 public static void CopyTo(clscc_PapersBigTopicEN objcc_PapersBigTopicENS, clscc_PapersBigTopicEN objcc_PapersBigTopicENT)
{
try
{
objcc_PapersBigTopicENT.PapersBigTopicId = objcc_PapersBigTopicENS.PapersBigTopicId; //试卷大题目Id
objcc_PapersBigTopicENT.PapersBigTopicName = objcc_PapersBigTopicENS.PapersBigTopicName; //试卷大题目名称
objcc_PapersBigTopicENT.TopicDescription = objcc_PapersBigTopicENS.TopicDescription; //标题描述
objcc_PapersBigTopicENT.TopicScores = objcc_PapersBigTopicENS.TopicScores; //大题得分
objcc_PapersBigTopicENT.CourseExamPaperId = objcc_PapersBigTopicENS.CourseExamPaperId; //考卷流水号
objcc_PapersBigTopicENT.QuestionTypeId = objcc_PapersBigTopicENS.QuestionTypeId; //题目类型Id
objcc_PapersBigTopicENT.IsShow = objcc_PapersBigTopicENS.IsShow; //是否启用
objcc_PapersBigTopicENT.OrderNum = objcc_PapersBigTopicENS.OrderNum; //序号
objcc_PapersBigTopicENT.UpdDate = objcc_PapersBigTopicENS.UpdDate; //修改日期
objcc_PapersBigTopicENT.UpdUser = objcc_PapersBigTopicENS.UpdUser; //修改人
objcc_PapersBigTopicENT.Memo = objcc_PapersBigTopicENS.Memo; //备注
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
 /// <param name = "objcc_PapersBigTopicEN">源简化对象</param>
 public static void SetUpdFlag(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
try
{
objcc_PapersBigTopicEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_PapersBigTopicEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_PapersBigTopic.PapersBigTopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicEN.PapersBigTopicId = objcc_PapersBigTopicEN.PapersBigTopicId; //试卷大题目Id
}
if (arrFldSet.Contains(concc_PapersBigTopic.PapersBigTopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicEN.PapersBigTopicName = objcc_PapersBigTopicEN.PapersBigTopicName; //试卷大题目名称
}
if (arrFldSet.Contains(concc_PapersBigTopic.TopicDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicEN.TopicDescription = objcc_PapersBigTopicEN.TopicDescription == "[null]" ? null :  objcc_PapersBigTopicEN.TopicDescription; //标题描述
}
if (arrFldSet.Contains(concc_PapersBigTopic.TopicScores, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicEN.TopicScores = objcc_PapersBigTopicEN.TopicScores; //大题得分
}
if (arrFldSet.Contains(concc_PapersBigTopic.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicEN.CourseExamPaperId = objcc_PapersBigTopicEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(concc_PapersBigTopic.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicEN.QuestionTypeId = objcc_PapersBigTopicEN.QuestionTypeId == "[null]" ? null :  objcc_PapersBigTopicEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(concc_PapersBigTopic.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicEN.IsShow = objcc_PapersBigTopicEN.IsShow; //是否启用
}
if (arrFldSet.Contains(concc_PapersBigTopic.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicEN.OrderNum = objcc_PapersBigTopicEN.OrderNum; //序号
}
if (arrFldSet.Contains(concc_PapersBigTopic.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicEN.UpdDate = objcc_PapersBigTopicEN.UpdDate == "[null]" ? null :  objcc_PapersBigTopicEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_PapersBigTopic.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicEN.UpdUser = objcc_PapersBigTopicEN.UpdUser == "[null]" ? null :  objcc_PapersBigTopicEN.UpdUser; //修改人
}
if (arrFldSet.Contains(concc_PapersBigTopic.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicEN.Memo = objcc_PapersBigTopicEN.Memo == "[null]" ? null :  objcc_PapersBigTopicEN.Memo; //备注
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
 /// <param name = "objcc_PapersBigTopicEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
try
{
if (objcc_PapersBigTopicEN.TopicDescription == "[null]") objcc_PapersBigTopicEN.TopicDescription = null; //标题描述
if (objcc_PapersBigTopicEN.QuestionTypeId == "[null]") objcc_PapersBigTopicEN.QuestionTypeId = null; //题目类型Id
if (objcc_PapersBigTopicEN.UpdDate == "[null]") objcc_PapersBigTopicEN.UpdDate = null; //修改日期
if (objcc_PapersBigTopicEN.UpdUser == "[null]") objcc_PapersBigTopicEN.UpdUser = null; //修改人
if (objcc_PapersBigTopicEN.Memo == "[null]") objcc_PapersBigTopicEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 cc_PapersBigTopicDA.CheckPropertyNew(objcc_PapersBigTopicEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 cc_PapersBigTopicDA.CheckProperty4Condition(objcc_PapersBigTopicEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PapersBigTopicIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[试卷大题目]...","0");
List<clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst = GetAllcc_PapersBigTopicObjLstCache(); 
objDDL.DataValueField = concc_PapersBigTopic.PapersBigTopicId;
objDDL.DataTextField = concc_PapersBigTopic.PapersBigTopicName;
objDDL.DataSource = arrcc_PapersBigTopicObjLst;
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
if (clscc_PapersBigTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicBL没有刷新缓存机制(clscc_PapersBigTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PapersBigTopicId");
//if (arrcc_PapersBigTopicObjLstCache == null)
//{
//arrcc_PapersBigTopicObjLstCache = cc_PapersBigTopicDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPapersBigTopicId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_PapersBigTopicEN GetObjByPapersBigTopicIdCache(string strPapersBigTopicId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName);
List<clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLstCache = GetObjLstCache();
IEnumerable <clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLst_Sel =
arrcc_PapersBigTopicObjLstCache
.Where(x=> x.PapersBigTopicId == strPapersBigTopicId 
);
if (arrcc_PapersBigTopicObjLst_Sel.Count() == 0)
{
   clscc_PapersBigTopicEN obj = clscc_PapersBigTopicBL.GetObjByPapersBigTopicId(strPapersBigTopicId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_PapersBigTopicObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPapersBigTopicId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPapersBigTopicNameByPapersBigTopicIdCache(string strPapersBigTopicId)
{
if (string.IsNullOrEmpty(strPapersBigTopicId) == true) return "";
//获取缓存中的对象列表
clscc_PapersBigTopicEN objcc_PapersBigTopic = GetObjByPapersBigTopicIdCache(strPapersBigTopicId);
if (objcc_PapersBigTopic == null) return "";
return objcc_PapersBigTopic.PapersBigTopicName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPapersBigTopicId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPapersBigTopicIdCache(string strPapersBigTopicId)
{
if (string.IsNullOrEmpty(strPapersBigTopicId) == true) return "";
//获取缓存中的对象列表
clscc_PapersBigTopicEN objcc_PapersBigTopic = GetObjByPapersBigTopicIdCache(strPapersBigTopicId);
if (objcc_PapersBigTopic == null) return "";
return objcc_PapersBigTopic.PapersBigTopicName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_PapersBigTopicEN> GetAllcc_PapersBigTopicObjLstCache()
{
//获取缓存中的对象列表
List<clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLstCache = GetObjLstCache(); 
return arrcc_PapersBigTopicObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_PapersBigTopicEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName);
List<clscc_PapersBigTopicEN> arrcc_PapersBigTopicObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_PapersBigTopicObjLstCache;
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
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_PapersBigTopicEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_PapersBigTopicEN._RefreshTimeLst.Count == 0) return "";
return clscc_PapersBigTopicEN._RefreshTimeLst[clscc_PapersBigTopicEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_PapersBigTopicBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_PapersBigTopicEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_PapersBigTopicEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_PapersBigTopicBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_PapersBigTopic(试卷大题目)
 /// 唯一性条件:PapersBigTopicName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
//检测记录是否存在
string strResult = cc_PapersBigTopicDA.GetUniCondStr(objcc_PapersBigTopicEN);
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
public static string Func(string strInFldName, string strOutFldName, string strPapersBigTopicId)
{
if (strInFldName != concc_PapersBigTopic.PapersBigTopicId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_PapersBigTopic.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_PapersBigTopic.AttributeName));
throw new Exception(strMsg);
}
var objcc_PapersBigTopic = clscc_PapersBigTopicBL.GetObjByPapersBigTopicIdCache(strPapersBigTopicId);
if (objcc_PapersBigTopic == null) return "";
return objcc_PapersBigTopic[strOutFldName].ToString();
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
int intRecCount = clscc_PapersBigTopicDA.GetRecCount(strTabName);
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
int intRecCount = clscc_PapersBigTopicDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_PapersBigTopicDA.GetRecCount();
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
int intRecCount = clscc_PapersBigTopicDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_PapersBigTopicEN objcc_PapersBigTopicCond)
{
List<clscc_PapersBigTopicEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_PapersBigTopicEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_PapersBigTopic.AttributeName)
{
if (objcc_PapersBigTopicCond.IsUpdated(strFldName) == false) continue;
if (objcc_PapersBigTopicCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PapersBigTopicCond[strFldName].ToString());
}
else
{
if (objcc_PapersBigTopicCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_PapersBigTopicCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PapersBigTopicCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_PapersBigTopicCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_PapersBigTopicCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_PapersBigTopicCond[strFldName]));
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
 List<string> arrList = clscc_PapersBigTopicDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_PapersBigTopicDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_PapersBigTopicDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_PapersBigTopicDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_PapersBigTopicDA.SetFldValue(clscc_PapersBigTopicEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_PapersBigTopicDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_PapersBigTopicDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_PapersBigTopicDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_PapersBigTopicDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_PapersBigTopic] "); 
 strCreateTabCode.Append(" ( "); 
 // /**试卷大题目Id*/ 
 strCreateTabCode.Append(" PapersBigTopicId char(8) primary key, "); 
 // /**试卷大题目名称*/ 
 strCreateTabCode.Append(" PapersBigTopicName varchar(50) not Null, "); 
 // /**标题描述*/ 
 strCreateTabCode.Append(" TopicDescription varchar(100) Null, "); 
 // /**大题得分*/ 
 strCreateTabCode.Append(" TopicScores int Null, "); 
 // /**考卷流水号*/ 
 strCreateTabCode.Append(" CourseExamPaperId char(8) not Null, "); 
 // /**题目类型Id*/ 
 strCreateTabCode.Append(" QuestionTypeId char(2) Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" IsShow bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 试卷大题目(cc_PapersBigTopic)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_PapersBigTopic : clsCommFun4BL
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
clscc_PapersBigTopicBL.ReFreshThisCache();
}
}

}