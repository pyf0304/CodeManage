
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperEduClsRelaBL
 表名:cc_ExamPaperEduClsRela(01120233)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:09
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
public static class  clscc_ExamPaperEduClsRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdExamPaperEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperEduClsRelaEN GetObj(this K_IdExamPaperEduClsRela_cc_ExamPaperEduClsRela myKey)
{
clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.GetObjByIdExamPaperEduClsRela(myKey.Value);
return objcc_ExamPaperEduClsRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_ExamPaperEduClsRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],教学班流水号 = [{1}]的数据已经存在!(in clscc_ExamPaperEduClsRelaBL.AddNewRecord)", objcc_ExamPaperEduClsRelaEN.CourseExamPaperId,objcc_ExamPaperEduClsRelaEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
bool bolResult = clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.AddNewRecordBySQL2(objcc_ExamPaperEduClsRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaBL.ReFreshCache();

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objcc_ExamPaperEduClsRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_ExamPaperEduClsRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(考卷流水号(CourseExamPaperId)=[{0}],教学班流水号(IdCurrEduCls)=[{1}])已经存在,不能重复!", objcc_ExamPaperEduClsRelaEN.CourseExamPaperId, objcc_ExamPaperEduClsRelaEN.IdCurrEduCls);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objcc_ExamPaperEduClsRelaEN.AddNewRecord();
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
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_ExamPaperEduClsRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],教学班流水号 = [{1}]的数据已经存在!(in clscc_ExamPaperEduClsRelaBL.AddNewRecordWithReturnKey)", objcc_ExamPaperEduClsRelaEN.CourseExamPaperId,objcc_ExamPaperEduClsRelaEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
string strKey = clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.AddNewRecordBySQL2WithReturnKey(objcc_ExamPaperEduClsRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaBL.ReFreshCache();

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetIdExamPaperEduClsRela(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, long lngIdExamPaperEduClsRela, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = lngIdExamPaperEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.IdExamPaperEduClsRela) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.IdExamPaperEduClsRela, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetCourseExamPaperId(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseExamPaperId, concc_ExamPaperEduClsRela.CourseExamPaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_ExamPaperEduClsRela.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_ExamPaperEduClsRela.CourseExamPaperId);
}
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.CourseExamPaperId) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetIdCurrEduCls(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, concc_ExamPaperEduClsRela.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, concc_ExamPaperEduClsRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, concc_ExamPaperEduClsRela.IdCurrEduCls);
}
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.IdCurrEduCls) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.IdCurrEduCls, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.IdCurrEduCls] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetScores(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, double? dblScores, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.Scores) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.Scores, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.Scores] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetTeacherId(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherId, concc_ExamPaperEduClsRela.TeacherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherId, 12, concc_ExamPaperEduClsRela.TeacherId);
}
objcc_ExamPaperEduClsRelaEN.TeacherId = strTeacherId; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.TeacherId) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.TeacherId, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.TeacherId] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetIsPublish(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, bool bolIsPublish, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.IsPublish) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.IsPublish, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.IsPublish] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetPubDate(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strPubDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubDate, 14, concc_ExamPaperEduClsRela.PubDate);
}
objcc_ExamPaperEduClsRelaEN.PubDate = strPubDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.PubDate) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.PubDate, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.PubDate] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN Setpublisher(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strpublisher, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strpublisher, 20, concc_ExamPaperEduClsRela.publisher);
}
objcc_ExamPaperEduClsRelaEN.publisher = strpublisher; //发布者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.publisher) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.publisher, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.publisher] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetSpecifyCompletionDate(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, concc_ExamPaperEduClsRela.SpecifyCompletionDate);
}
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.SpecifyCompletionDate) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.SpecifyCompletionDate, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.SpecifyCompletionDate] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetIsCurrEduCls(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, bool bolIsCurrEduCls, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = bolIsCurrEduCls; //是否为教学班作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.IsCurrEduCls) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.IsCurrEduCls, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.IsCurrEduCls] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetIsGroupWork(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, bool bolIsGroupWork, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.IsGroupWork = bolIsGroupWork; //是否为小组作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.IsGroupWork) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.IsGroupWork, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.IsGroupWork] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetCourseStudentGroupId(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, long? lngCourseStudentGroupId, string strComparisonOp="")
	{
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = lngCourseStudentGroupId; //学生分组表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.CourseStudentGroupId) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.CourseStudentGroupId, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.CourseStudentGroupId] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetWorkTypeId(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, concc_ExamPaperEduClsRela.WorkTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, concc_ExamPaperEduClsRela.WorkTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, concc_ExamPaperEduClsRela.WorkTypeId);
}
objcc_ExamPaperEduClsRelaEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.WorkTypeId) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.WorkTypeId, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.WorkTypeId] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetUpdDate(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_ExamPaperEduClsRela.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_ExamPaperEduClsRela.UpdDate);
}
objcc_ExamPaperEduClsRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.UpdDate) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.UpdDate, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.UpdDate] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetUpdUserId(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_ExamPaperEduClsRela.UpdUserId);
}
objcc_ExamPaperEduClsRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.UpdUserId) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.UpdUserId, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.UpdUserId] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperEduClsRelaEN SetMemo(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_ExamPaperEduClsRela.Memo);
}
objcc_ExamPaperEduClsRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperEduClsRela.Memo) == false)
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp.Add(concc_ExamPaperEduClsRela.Memo, strComparisonOp);
}
else
{
objcc_ExamPaperEduClsRelaEN.dicFldComparisonOp[concc_ExamPaperEduClsRela.Memo] = strComparisonOp;
}
}
return objcc_ExamPaperEduClsRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_ExamPaperEduClsRelaEN.CheckPropertyNew();
clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaCond = new clscc_ExamPaperEduClsRelaEN();
string strCondition = objcc_ExamPaperEduClsRelaCond
.SetIdExamPaperEduClsRela(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, "<>")
.SetCourseExamPaperId(objcc_ExamPaperEduClsRelaEN.CourseExamPaperId, "=")
.SetIdCurrEduCls(objcc_ExamPaperEduClsRelaEN.IdCurrEduCls, "=")
.GetCombineCondition();
objcc_ExamPaperEduClsRelaEN._IsCheckProperty = true;
bool bolIsExist = clscc_ExamPaperEduClsRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CourseExamPaperId_id_CurrEduCls)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_ExamPaperEduClsRelaEN.Update();
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
 /// <param name = "objcc_ExamPaperEduClsRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaCond = new clscc_ExamPaperEduClsRelaEN();
string strCondition = objcc_ExamPaperEduClsRelaCond
.SetCourseExamPaperId(objcc_ExamPaperEduClsRela.CourseExamPaperId, "=")
.SetIdCurrEduCls(objcc_ExamPaperEduClsRela.IdCurrEduCls, "=")
.GetCombineCondition();
objcc_ExamPaperEduClsRela._IsCheckProperty = true;
bool bolIsExist = clscc_ExamPaperEduClsRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_ExamPaperEduClsRela.IdExamPaperEduClsRela = clscc_ExamPaperEduClsRelaBL.GetFirstID_S(strCondition);
objcc_ExamPaperEduClsRela.UpdateWithCondition(strCondition);
}
else
{
objcc_ExamPaperEduClsRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
 if (objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.UpdateBySql2(objcc_ExamPaperEduClsRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaBL.ReFreshCache();

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.UpdateBySql2(objcc_ExamPaperEduClsRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaBL.ReFreshCache();

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strWhereCond)
{
try
{
bool bolResult = clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.UpdateBySqlWithCondition(objcc_ExamPaperEduClsRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaBL.ReFreshCache();

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.UpdateBySqlWithConditionTransaction(objcc_ExamPaperEduClsRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaBL.ReFreshCache();

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
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
 /// <param name = "lngIdExamPaperEduClsRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
try
{
int intRecNum = clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.DelRecord(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaBL.ReFreshCache();

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperEduClsRelaENS">源对象</param>
 /// <param name = "objcc_ExamPaperEduClsRelaENT">目标对象</param>
 public static void CopyTo(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaENS, clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaENT)
{
try
{
objcc_ExamPaperEduClsRelaENT.IdExamPaperEduClsRela = objcc_ExamPaperEduClsRelaENS.IdExamPaperEduClsRela; //作业教学班关系流水号
objcc_ExamPaperEduClsRelaENT.CourseExamPaperId = objcc_ExamPaperEduClsRelaENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperEduClsRelaENT.IdCurrEduCls = objcc_ExamPaperEduClsRelaENS.IdCurrEduCls; //教学班流水号
objcc_ExamPaperEduClsRelaENT.Scores = objcc_ExamPaperEduClsRelaENS.Scores; //分值
objcc_ExamPaperEduClsRelaENT.TeacherId = objcc_ExamPaperEduClsRelaENS.TeacherId; //教师工号
objcc_ExamPaperEduClsRelaENT.IsPublish = objcc_ExamPaperEduClsRelaENS.IsPublish; //是否发布
objcc_ExamPaperEduClsRelaENT.PubDate = objcc_ExamPaperEduClsRelaENS.PubDate; //发布日期
objcc_ExamPaperEduClsRelaENT.publisher = objcc_ExamPaperEduClsRelaENS.publisher; //发布者Id
objcc_ExamPaperEduClsRelaENT.SpecifyCompletionDate = objcc_ExamPaperEduClsRelaENS.SpecifyCompletionDate; //指定完成日期
objcc_ExamPaperEduClsRelaENT.IsCurrEduCls = objcc_ExamPaperEduClsRelaENS.IsCurrEduCls; //是否为教学班作业
objcc_ExamPaperEduClsRelaENT.IsGroupWork = objcc_ExamPaperEduClsRelaENS.IsGroupWork; //是否为小组作业
objcc_ExamPaperEduClsRelaENT.CourseStudentGroupId = objcc_ExamPaperEduClsRelaENS.CourseStudentGroupId; //学生分组表流水号
objcc_ExamPaperEduClsRelaENT.WorkTypeId = objcc_ExamPaperEduClsRelaENS.WorkTypeId; //作业类型Id
objcc_ExamPaperEduClsRelaENT.UpdDate = objcc_ExamPaperEduClsRelaENS.UpdDate; //修改日期
objcc_ExamPaperEduClsRelaENT.UpdUserId = objcc_ExamPaperEduClsRelaENS.UpdUserId; //修改用户Id
objcc_ExamPaperEduClsRelaENT.Memo = objcc_ExamPaperEduClsRelaENS.Memo; //备注
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
 /// <param name = "objcc_ExamPaperEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_ExamPaperEduClsRelaEN:objcc_ExamPaperEduClsRelaENT</returns>
 public static clscc_ExamPaperEduClsRelaEN CopyTo(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaENS)
{
try
{
 clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaENT = new clscc_ExamPaperEduClsRelaEN()
{
IdExamPaperEduClsRela = objcc_ExamPaperEduClsRelaENS.IdExamPaperEduClsRela, //作业教学班关系流水号
CourseExamPaperId = objcc_ExamPaperEduClsRelaENS.CourseExamPaperId, //考卷流水号
IdCurrEduCls = objcc_ExamPaperEduClsRelaENS.IdCurrEduCls, //教学班流水号
Scores = objcc_ExamPaperEduClsRelaENS.Scores, //分值
TeacherId = objcc_ExamPaperEduClsRelaENS.TeacherId, //教师工号
IsPublish = objcc_ExamPaperEduClsRelaENS.IsPublish, //是否发布
PubDate = objcc_ExamPaperEduClsRelaENS.PubDate, //发布日期
publisher = objcc_ExamPaperEduClsRelaENS.publisher, //发布者Id
SpecifyCompletionDate = objcc_ExamPaperEduClsRelaENS.SpecifyCompletionDate, //指定完成日期
IsCurrEduCls = objcc_ExamPaperEduClsRelaENS.IsCurrEduCls, //是否为教学班作业
IsGroupWork = objcc_ExamPaperEduClsRelaENS.IsGroupWork, //是否为小组作业
CourseStudentGroupId = objcc_ExamPaperEduClsRelaENS.CourseStudentGroupId, //学生分组表流水号
WorkTypeId = objcc_ExamPaperEduClsRelaENS.WorkTypeId, //作业类型Id
UpdDate = objcc_ExamPaperEduClsRelaENS.UpdDate, //修改日期
UpdUserId = objcc_ExamPaperEduClsRelaENS.UpdUserId, //修改用户Id
Memo = objcc_ExamPaperEduClsRelaENS.Memo, //备注
};
 return objcc_ExamPaperEduClsRelaENT;
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
public static void CheckPropertyNew(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
 clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.CheckPropertyNew(objcc_ExamPaperEduClsRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
 clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.CheckProperty4Condition(objcc_ExamPaperEduClsRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.IdExamPaperEduClsRela) == true)
{
string strComparisonOpIdExamPaperEduClsRela = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperEduClsRela.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaCond.IdExamPaperEduClsRela, strComparisonOpIdExamPaperEduClsRela);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.CourseExamPaperId, objcc_ExamPaperEduClsRelaCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.IdCurrEduCls, objcc_ExamPaperEduClsRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.Scores) == true)
{
string strComparisonOpScores = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperEduClsRela.Scores, objcc_ExamPaperEduClsRelaCond.Scores, strComparisonOpScores);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.TeacherId) == true)
{
string strComparisonOpTeacherId = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.TeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.TeacherId, objcc_ExamPaperEduClsRelaCond.TeacherId, strComparisonOpTeacherId);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.IsPublish) == true)
{
if (objcc_ExamPaperEduClsRelaCond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperEduClsRela.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperEduClsRela.IsPublish);
}
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.PubDate) == true)
{
string strComparisonOpPubDate = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.PubDate, objcc_ExamPaperEduClsRelaCond.PubDate, strComparisonOpPubDate);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.publisher) == true)
{
string strComparisonOppublisher = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.publisher];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.publisher, objcc_ExamPaperEduClsRelaCond.publisher, strComparisonOppublisher);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.SpecifyCompletionDate) == true)
{
string strComparisonOpSpecifyCompletionDate = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.SpecifyCompletionDate, objcc_ExamPaperEduClsRelaCond.SpecifyCompletionDate, strComparisonOpSpecifyCompletionDate);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.IsCurrEduCls) == true)
{
if (objcc_ExamPaperEduClsRelaCond.IsCurrEduCls == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperEduClsRela.IsCurrEduCls);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperEduClsRela.IsCurrEduCls);
}
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.IsGroupWork) == true)
{
if (objcc_ExamPaperEduClsRelaCond.IsGroupWork == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperEduClsRela.IsGroupWork);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperEduClsRela.IsGroupWork);
}
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.CourseStudentGroupId) == true)
{
string strComparisonOpCourseStudentGroupId = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.CourseStudentGroupId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperEduClsRela.CourseStudentGroupId, objcc_ExamPaperEduClsRelaCond.CourseStudentGroupId, strComparisonOpCourseStudentGroupId);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.WorkTypeId) == true)
{
string strComparisonOpWorkTypeId = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.WorkTypeId, objcc_ExamPaperEduClsRelaCond.WorkTypeId, strComparisonOpWorkTypeId);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.UpdDate, objcc_ExamPaperEduClsRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.UpdUserId, objcc_ExamPaperEduClsRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(concc_ExamPaperEduClsRela.Memo) == true)
{
string strComparisonOpMemo = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[concc_ExamPaperEduClsRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperEduClsRela.Memo, objcc_ExamPaperEduClsRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_ExamPaperEduClsRela(考卷教学班关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseExamPaperId_id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_ExamPaperEduClsRelaEN == null) return true;
if (objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperEduClsRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_ExamPaperEduClsRelaEN.IdCurrEduCls);
if (clscc_ExamPaperEduClsRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdExamPaperEduClsRela !=  {0}", objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperEduClsRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_ExamPaperEduClsRelaEN.IdCurrEduCls);
if (clscc_ExamPaperEduClsRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_ExamPaperEduClsRela(考卷教学班关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseExamPaperId_id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_ExamPaperEduClsRelaEN == null) return "";
if (objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperEduClsRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_ExamPaperEduClsRelaEN.IdCurrEduCls);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdExamPaperEduClsRela !=  {0}", objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperEduClsRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_ExamPaperEduClsRelaEN.IdCurrEduCls);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_ExamPaperEduClsRela
{
public virtual bool UpdRelaTabDate(long lngIdExamPaperEduClsRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 考卷教学班关系(cc_ExamPaperEduClsRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_ExamPaperEduClsRelaBL
{
public static RelatedActions_cc_ExamPaperEduClsRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_ExamPaperEduClsRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_ExamPaperEduClsRelaDA cc_ExamPaperEduClsRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_ExamPaperEduClsRelaDA();
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
 public clscc_ExamPaperEduClsRelaBL()
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
if (string.IsNullOrEmpty(clscc_ExamPaperEduClsRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_ExamPaperEduClsRelaEN._ConnectString);
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
public static DataTable GetDataTable_cc_ExamPaperEduClsRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_ExamPaperEduClsRelaDA.GetDataTable_cc_ExamPaperEduClsRela(strWhereCond);
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
objDT = cc_ExamPaperEduClsRelaDA.GetDataTable(strWhereCond);
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
objDT = cc_ExamPaperEduClsRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_ExamPaperEduClsRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_ExamPaperEduClsRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_ExamPaperEduClsRelaDA.GetDataTable_Top(objTopPara);
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
objDT = cc_ExamPaperEduClsRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_ExamPaperEduClsRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_ExamPaperEduClsRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdExamPaperEduClsRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstByIdExamPaperEduClsRelaLst(List<long> arrIdExamPaperEduClsRelaLst)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = new List<clscc_ExamPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdExamPaperEduClsRelaLst);
 string strWhereCond = string.Format("IdExamPaperEduClsRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = new clscc_ExamPaperEduClsRelaEN();
try
{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = Int32.Parse(objRow[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = objRow[concc_ExamPaperEduClsRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = objRow[concc_ExamPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperEduClsRelaEN.Scores = objRow[concc_ExamPaperEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperEduClsRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperEduClsRelaEN.TeacherId = objRow[concc_ExamPaperEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_ExamPaperEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperEduClsRelaEN.PubDate = objRow[concc_ExamPaperEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_ExamPaperEduClsRelaEN.publisher = objRow[concc_ExamPaperEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_ExamPaperEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_ExamPaperEduClsRelaEN.WorkTypeId = objRow[concc_ExamPaperEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperEduClsRelaEN.UpdDate = objRow[concc_ExamPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperEduClsRelaEN.UpdUserId = objRow[concc_ExamPaperEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperEduClsRelaEN.Memo = objRow[concc_ExamPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdExamPaperEduClsRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_ExamPaperEduClsRelaEN> GetObjLstByIdExamPaperEduClsRelaLstCache(List<long> arrIdExamPaperEduClsRelaLst)
{
string strKey = string.Format("{0}", clscc_ExamPaperEduClsRelaEN._CurrTabName);
List<clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaObjLstCache = GetObjLstCache();
IEnumerable <clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaObjLst_Sel =
arrcc_ExamPaperEduClsRelaObjLstCache
.Where(x => arrIdExamPaperEduClsRelaLst.Contains(x.IdExamPaperEduClsRela));
return arrcc_ExamPaperEduClsRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLst(string strWhereCond)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = new List<clscc_ExamPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = new clscc_ExamPaperEduClsRelaEN();
try
{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = Int32.Parse(objRow[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = objRow[concc_ExamPaperEduClsRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = objRow[concc_ExamPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperEduClsRelaEN.Scores = objRow[concc_ExamPaperEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperEduClsRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperEduClsRelaEN.TeacherId = objRow[concc_ExamPaperEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_ExamPaperEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperEduClsRelaEN.PubDate = objRow[concc_ExamPaperEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_ExamPaperEduClsRelaEN.publisher = objRow[concc_ExamPaperEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_ExamPaperEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_ExamPaperEduClsRelaEN.WorkTypeId = objRow[concc_ExamPaperEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperEduClsRelaEN.UpdDate = objRow[concc_ExamPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperEduClsRelaEN.UpdUserId = objRow[concc_ExamPaperEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperEduClsRelaEN.Memo = objRow[concc_ExamPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperEduClsRelaEN);
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
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = new List<clscc_ExamPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = new clscc_ExamPaperEduClsRelaEN();
try
{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = Int32.Parse(objRow[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = objRow[concc_ExamPaperEduClsRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = objRow[concc_ExamPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperEduClsRelaEN.Scores = objRow[concc_ExamPaperEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperEduClsRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperEduClsRelaEN.TeacherId = objRow[concc_ExamPaperEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_ExamPaperEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperEduClsRelaEN.PubDate = objRow[concc_ExamPaperEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_ExamPaperEduClsRelaEN.publisher = objRow[concc_ExamPaperEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_ExamPaperEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_ExamPaperEduClsRelaEN.WorkTypeId = objRow[concc_ExamPaperEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperEduClsRelaEN.UpdDate = objRow[concc_ExamPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperEduClsRelaEN.UpdUserId = objRow[concc_ExamPaperEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperEduClsRelaEN.Memo = objRow[concc_ExamPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_ExamPaperEduClsRelaEN> GetSubObjLstCache(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaCond)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_ExamPaperEduClsRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_ExamPaperEduClsRela.AttributeName)
{
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(strFldName) == false) continue;
if (objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperEduClsRelaCond[strFldName].ToString());
}
else
{
if (objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperEduClsRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_ExamPaperEduClsRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperEduClsRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperEduClsRelaCond[strFldName]));
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
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = new List<clscc_ExamPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = new clscc_ExamPaperEduClsRelaEN();
try
{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = Int32.Parse(objRow[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = objRow[concc_ExamPaperEduClsRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = objRow[concc_ExamPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperEduClsRelaEN.Scores = objRow[concc_ExamPaperEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperEduClsRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperEduClsRelaEN.TeacherId = objRow[concc_ExamPaperEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_ExamPaperEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperEduClsRelaEN.PubDate = objRow[concc_ExamPaperEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_ExamPaperEduClsRelaEN.publisher = objRow[concc_ExamPaperEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_ExamPaperEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_ExamPaperEduClsRelaEN.WorkTypeId = objRow[concc_ExamPaperEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperEduClsRelaEN.UpdDate = objRow[concc_ExamPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperEduClsRelaEN.UpdUserId = objRow[concc_ExamPaperEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperEduClsRelaEN.Memo = objRow[concc_ExamPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperEduClsRelaEN);
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
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = new List<clscc_ExamPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = new clscc_ExamPaperEduClsRelaEN();
try
{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = Int32.Parse(objRow[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = objRow[concc_ExamPaperEduClsRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = objRow[concc_ExamPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperEduClsRelaEN.Scores = objRow[concc_ExamPaperEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperEduClsRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperEduClsRelaEN.TeacherId = objRow[concc_ExamPaperEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_ExamPaperEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperEduClsRelaEN.PubDate = objRow[concc_ExamPaperEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_ExamPaperEduClsRelaEN.publisher = objRow[concc_ExamPaperEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_ExamPaperEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_ExamPaperEduClsRelaEN.WorkTypeId = objRow[concc_ExamPaperEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperEduClsRelaEN.UpdDate = objRow[concc_ExamPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperEduClsRelaEN.UpdUserId = objRow[concc_ExamPaperEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperEduClsRelaEN.Memo = objRow[concc_ExamPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperEduClsRelaEN);
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
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperEduClsRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_ExamPaperEduClsRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = new List<clscc_ExamPaperEduClsRelaEN>(); 
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
	clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = new clscc_ExamPaperEduClsRelaEN();
try
{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = Int32.Parse(objRow[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = objRow[concc_ExamPaperEduClsRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = objRow[concc_ExamPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperEduClsRelaEN.Scores = objRow[concc_ExamPaperEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperEduClsRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperEduClsRelaEN.TeacherId = objRow[concc_ExamPaperEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_ExamPaperEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperEduClsRelaEN.PubDate = objRow[concc_ExamPaperEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_ExamPaperEduClsRelaEN.publisher = objRow[concc_ExamPaperEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_ExamPaperEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_ExamPaperEduClsRelaEN.WorkTypeId = objRow[concc_ExamPaperEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperEduClsRelaEN.UpdDate = objRow[concc_ExamPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperEduClsRelaEN.UpdUserId = objRow[concc_ExamPaperEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperEduClsRelaEN.Memo = objRow[concc_ExamPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperEduClsRelaEN);
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
public static List<clscc_ExamPaperEduClsRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = new List<clscc_ExamPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = new clscc_ExamPaperEduClsRelaEN();
try
{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = Int32.Parse(objRow[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = objRow[concc_ExamPaperEduClsRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = objRow[concc_ExamPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperEduClsRelaEN.Scores = objRow[concc_ExamPaperEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperEduClsRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperEduClsRelaEN.TeacherId = objRow[concc_ExamPaperEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_ExamPaperEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperEduClsRelaEN.PubDate = objRow[concc_ExamPaperEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_ExamPaperEduClsRelaEN.publisher = objRow[concc_ExamPaperEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_ExamPaperEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_ExamPaperEduClsRelaEN.WorkTypeId = objRow[concc_ExamPaperEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperEduClsRelaEN.UpdDate = objRow[concc_ExamPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperEduClsRelaEN.UpdUserId = objRow[concc_ExamPaperEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperEduClsRelaEN.Memo = objRow[concc_ExamPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = new List<clscc_ExamPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = new clscc_ExamPaperEduClsRelaEN();
try
{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = Int32.Parse(objRow[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = objRow[concc_ExamPaperEduClsRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = objRow[concc_ExamPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperEduClsRelaEN.Scores = objRow[concc_ExamPaperEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperEduClsRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperEduClsRelaEN.TeacherId = objRow[concc_ExamPaperEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_ExamPaperEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperEduClsRelaEN.PubDate = objRow[concc_ExamPaperEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_ExamPaperEduClsRelaEN.publisher = objRow[concc_ExamPaperEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_ExamPaperEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_ExamPaperEduClsRelaEN.WorkTypeId = objRow[concc_ExamPaperEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperEduClsRelaEN.UpdDate = objRow[concc_ExamPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperEduClsRelaEN.UpdUserId = objRow[concc_ExamPaperEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperEduClsRelaEN.Memo = objRow[concc_ExamPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperEduClsRelaEN);
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
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = new List<clscc_ExamPaperEduClsRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = new clscc_ExamPaperEduClsRelaEN();
try
{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = Int32.Parse(objRow[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = objRow[concc_ExamPaperEduClsRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = objRow[concc_ExamPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperEduClsRelaEN.Scores = objRow[concc_ExamPaperEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperEduClsRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperEduClsRelaEN.TeacherId = objRow[concc_ExamPaperEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_ExamPaperEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperEduClsRelaEN.PubDate = objRow[concc_ExamPaperEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_ExamPaperEduClsRelaEN.publisher = objRow[concc_ExamPaperEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_ExamPaperEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_ExamPaperEduClsRelaEN.WorkTypeId = objRow[concc_ExamPaperEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperEduClsRelaEN.UpdDate = objRow[concc_ExamPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperEduClsRelaEN.UpdUserId = objRow[concc_ExamPaperEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperEduClsRelaEN.Memo = objRow[concc_ExamPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperEduClsRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLst = new List<clscc_ExamPaperEduClsRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = new clscc_ExamPaperEduClsRelaEN();
try
{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = Int32.Parse(objRow[concc_ExamPaperEduClsRela.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = objRow[concc_ExamPaperEduClsRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = objRow[concc_ExamPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperEduClsRelaEN.Scores = objRow[concc_ExamPaperEduClsRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperEduClsRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperEduClsRelaEN.TeacherId = objRow[concc_ExamPaperEduClsRela.TeacherId].ToString().Trim(); //教师工号
objcc_ExamPaperEduClsRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsPublish].ToString().Trim()); //是否发布
objcc_ExamPaperEduClsRelaEN.PubDate = objRow[concc_ExamPaperEduClsRela.PubDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.PubDate].ToString().Trim(); //发布日期
objcc_ExamPaperEduClsRelaEN.publisher = objRow[concc_ExamPaperEduClsRela.publisher] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.publisher].ToString().Trim(); //发布者Id
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objcc_ExamPaperEduClsRelaEN.IsGroupWork = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperEduClsRela.IsGroupWork].ToString().Trim()); //是否为小组作业
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_ExamPaperEduClsRela.CourseStudentGroupId].ToString().Trim()); //学生分组表流水号
objcc_ExamPaperEduClsRelaEN.WorkTypeId = objRow[concc_ExamPaperEduClsRela.WorkTypeId].ToString().Trim(); //作业类型Id
objcc_ExamPaperEduClsRelaEN.UpdDate = objRow[concc_ExamPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperEduClsRelaEN.UpdUserId = objRow[concc_ExamPaperEduClsRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperEduClsRelaEN.Memo = objRow[concc_ExamPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperEduClsRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperEduClsRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_ExamPaperEduClsRela(ref clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
bool bolResult = cc_ExamPaperEduClsRelaDA.Getcc_ExamPaperEduClsRela(ref objcc_ExamPaperEduClsRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdExamPaperEduClsRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperEduClsRelaEN GetObjByIdExamPaperEduClsRela(long lngIdExamPaperEduClsRela)
{
clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = cc_ExamPaperEduClsRelaDA.GetObjByIdExamPaperEduClsRela(lngIdExamPaperEduClsRela);
return objcc_ExamPaperEduClsRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_ExamPaperEduClsRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = cc_ExamPaperEduClsRelaDA.GetFirstObj(strWhereCond);
 return objcc_ExamPaperEduClsRelaEN;
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
public static clscc_ExamPaperEduClsRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = cc_ExamPaperEduClsRelaDA.GetObjByDataRow(objRow);
 return objcc_ExamPaperEduClsRelaEN;
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
public static clscc_ExamPaperEduClsRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = cc_ExamPaperEduClsRelaDA.GetObjByDataRow(objRow);
 return objcc_ExamPaperEduClsRelaEN;
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
 /// <param name = "lngIdExamPaperEduClsRela">所给的关键字</param>
 /// <param name = "lstcc_ExamPaperEduClsRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ExamPaperEduClsRelaEN GetObjByIdExamPaperEduClsRelaFromList(long lngIdExamPaperEduClsRela, List<clscc_ExamPaperEduClsRelaEN> lstcc_ExamPaperEduClsRelaObjLst)
{
foreach (clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN in lstcc_ExamPaperEduClsRelaObjLst)
{
if (objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela == lngIdExamPaperEduClsRela)
{
return objcc_ExamPaperEduClsRelaEN;
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
 long lngIdExamPaperEduClsRela;
 try
 {
 lngIdExamPaperEduClsRela = new clscc_ExamPaperEduClsRelaDA().GetFirstID(strWhereCond);
 return lngIdExamPaperEduClsRela;
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
 arrList = cc_ExamPaperEduClsRelaDA.GetID(strWhereCond);
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
bool bolIsExist = cc_ExamPaperEduClsRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdExamPaperEduClsRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdExamPaperEduClsRela)
{
//检测记录是否存在
bool bolIsExist = cc_ExamPaperEduClsRelaDA.IsExist(lngIdExamPaperEduClsRela);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdExamPaperEduClsRela">作业教学班关系流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdExamPaperEduClsRela, string strOpUser)
{
clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = clscc_ExamPaperEduClsRelaBL.GetObjByIdExamPaperEduClsRela(lngIdExamPaperEduClsRela);
objcc_ExamPaperEduClsRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_ExamPaperEduClsRelaEN.UpdUserId = strOpUser;
return clscc_ExamPaperEduClsRelaBL.UpdateBySql2(objcc_ExamPaperEduClsRelaEN);
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
 bolIsExist = clscc_ExamPaperEduClsRelaDA.IsExistTable();
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
 bolIsExist = cc_ExamPaperEduClsRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_ExamPaperEduClsRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],教学班流水号 = [{1}]的数据已经存在!(in clscc_ExamPaperEduClsRelaBL.AddNewRecordBySql2)", objcc_ExamPaperEduClsRelaEN.CourseExamPaperId,objcc_ExamPaperEduClsRelaEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
bool bolResult = cc_ExamPaperEduClsRelaDA.AddNewRecordBySQL2(objcc_ExamPaperEduClsRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaBL.ReFreshCache();

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_ExamPaperEduClsRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],教学班流水号 = [{1}]的数据已经存在!(in clscc_ExamPaperEduClsRelaBL.AddNewRecordBySql2WithReturnKey)", objcc_ExamPaperEduClsRelaEN.CourseExamPaperId,objcc_ExamPaperEduClsRelaEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
string strKey = cc_ExamPaperEduClsRelaDA.AddNewRecordBySQL2WithReturnKey(objcc_ExamPaperEduClsRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaBL.ReFreshCache();

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
try
{
bool bolResult = cc_ExamPaperEduClsRelaDA.Update(objcc_ExamPaperEduClsRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaBL.ReFreshCache();

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperEduClsRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
 if (objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_ExamPaperEduClsRelaDA.UpdateBySql2(objcc_ExamPaperEduClsRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperEduClsRelaBL.ReFreshCache();

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
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
 /// <param name = "lngIdExamPaperEduClsRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdExamPaperEduClsRela)
{
try
{
 clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = clscc_ExamPaperEduClsRelaBL.GetObjByIdExamPaperEduClsRela(lngIdExamPaperEduClsRela);

if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela, objcc_ExamPaperEduClsRelaEN.UpdUserId);
}
if (objcc_ExamPaperEduClsRelaEN != null)
{
int intRecNum = cc_ExamPaperEduClsRelaDA.DelRecord(lngIdExamPaperEduClsRela);
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
/// <param name="lngIdExamPaperEduClsRela">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdExamPaperEduClsRela )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_ExamPaperEduClsRelaDA.GetSpecSQLObj();
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
//删除与表:[cc_ExamPaperEduClsRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_ExamPaperEduClsRela.IdExamPaperEduClsRela,
//lngIdExamPaperEduClsRela);
//        clscc_ExamPaperEduClsRelaBL.Delcc_ExamPaperEduClsRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_ExamPaperEduClsRelaBL.DelRecord(lngIdExamPaperEduClsRela, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_ExamPaperEduClsRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdExamPaperEduClsRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdExamPaperEduClsRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdExamPaperEduClsRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(lngIdExamPaperEduClsRela, "UpdRelaTabDate");
}
bool bolResult = cc_ExamPaperEduClsRelaDA.DelRecord(lngIdExamPaperEduClsRela,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdExamPaperEduClsRelaLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_ExamPaperEduClsRelas(List<string> arrIdExamPaperEduClsRelaLst)
{
if (arrIdExamPaperEduClsRelaLst.Count == 0) return 0;
try
{
if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
foreach (var strIdExamPaperEduClsRela in arrIdExamPaperEduClsRelaLst)
{
long lngIdExamPaperEduClsRela = long.Parse(strIdExamPaperEduClsRela);
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(lngIdExamPaperEduClsRela, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_ExamPaperEduClsRelaDA.Delcc_ExamPaperEduClsRela(arrIdExamPaperEduClsRelaLst);
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
public static int Delcc_ExamPaperEduClsRelasByCond(string strWhereCond)
{
try
{
if (clscc_ExamPaperEduClsRelaBL.relatedActions != null)
{
List<string> arrIdExamPaperEduClsRela = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdExamPaperEduClsRela in arrIdExamPaperEduClsRela)
{
long lngIdExamPaperEduClsRela = long.Parse(strIdExamPaperEduClsRela);
clscc_ExamPaperEduClsRelaBL.relatedActions.UpdRelaTabDate(lngIdExamPaperEduClsRela, "UpdRelaTabDate");
}
}
int intRecNum = cc_ExamPaperEduClsRelaDA.Delcc_ExamPaperEduClsRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_ExamPaperEduClsRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdExamPaperEduClsRela">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdExamPaperEduClsRela)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_ExamPaperEduClsRelaDA.GetSpecSQLObj();
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
//删除与表:[cc_ExamPaperEduClsRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_ExamPaperEduClsRelaBL.DelRecord(lngIdExamPaperEduClsRela, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_ExamPaperEduClsRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdExamPaperEduClsRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_ExamPaperEduClsRelaENS">源对象</param>
 /// <param name = "objcc_ExamPaperEduClsRelaENT">目标对象</param>
 public static void CopyTo(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaENS, clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaENT)
{
try
{
objcc_ExamPaperEduClsRelaENT.IdExamPaperEduClsRela = objcc_ExamPaperEduClsRelaENS.IdExamPaperEduClsRela; //作业教学班关系流水号
objcc_ExamPaperEduClsRelaENT.CourseExamPaperId = objcc_ExamPaperEduClsRelaENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperEduClsRelaENT.IdCurrEduCls = objcc_ExamPaperEduClsRelaENS.IdCurrEduCls; //教学班流水号
objcc_ExamPaperEduClsRelaENT.Scores = objcc_ExamPaperEduClsRelaENS.Scores; //分值
objcc_ExamPaperEduClsRelaENT.TeacherId = objcc_ExamPaperEduClsRelaENS.TeacherId; //教师工号
objcc_ExamPaperEduClsRelaENT.IsPublish = objcc_ExamPaperEduClsRelaENS.IsPublish; //是否发布
objcc_ExamPaperEduClsRelaENT.PubDate = objcc_ExamPaperEduClsRelaENS.PubDate; //发布日期
objcc_ExamPaperEduClsRelaENT.publisher = objcc_ExamPaperEduClsRelaENS.publisher; //发布者Id
objcc_ExamPaperEduClsRelaENT.SpecifyCompletionDate = objcc_ExamPaperEduClsRelaENS.SpecifyCompletionDate; //指定完成日期
objcc_ExamPaperEduClsRelaENT.IsCurrEduCls = objcc_ExamPaperEduClsRelaENS.IsCurrEduCls; //是否为教学班作业
objcc_ExamPaperEduClsRelaENT.IsGroupWork = objcc_ExamPaperEduClsRelaENS.IsGroupWork; //是否为小组作业
objcc_ExamPaperEduClsRelaENT.CourseStudentGroupId = objcc_ExamPaperEduClsRelaENS.CourseStudentGroupId; //学生分组表流水号
objcc_ExamPaperEduClsRelaENT.WorkTypeId = objcc_ExamPaperEduClsRelaENS.WorkTypeId; //作业类型Id
objcc_ExamPaperEduClsRelaENT.UpdDate = objcc_ExamPaperEduClsRelaENS.UpdDate; //修改日期
objcc_ExamPaperEduClsRelaENT.UpdUserId = objcc_ExamPaperEduClsRelaENS.UpdUserId; //修改用户Id
objcc_ExamPaperEduClsRelaENT.Memo = objcc_ExamPaperEduClsRelaENS.Memo; //备注
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
 /// <param name = "objcc_ExamPaperEduClsRelaEN">源简化对象</param>
 public static void SetUpdFlag(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
try
{
objcc_ExamPaperEduClsRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_ExamPaperEduClsRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.IdExamPaperEduClsRela, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela = objcc_ExamPaperEduClsRelaEN.IdExamPaperEduClsRela; //作业教学班关系流水号
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.CourseExamPaperId = objcc_ExamPaperEduClsRelaEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.IdCurrEduCls = objcc_ExamPaperEduClsRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.Scores, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.Scores = objcc_ExamPaperEduClsRelaEN.Scores; //分值
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.TeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.TeacherId = objcc_ExamPaperEduClsRelaEN.TeacherId; //教师工号
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.IsPublish, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.IsPublish = objcc_ExamPaperEduClsRelaEN.IsPublish; //是否发布
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.PubDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.PubDate = objcc_ExamPaperEduClsRelaEN.PubDate == "[null]" ? null :  objcc_ExamPaperEduClsRelaEN.PubDate; //发布日期
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.publisher, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.publisher = objcc_ExamPaperEduClsRelaEN.publisher == "[null]" ? null :  objcc_ExamPaperEduClsRelaEN.publisher; //发布者Id
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.SpecifyCompletionDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate == "[null]" ? null :  objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate; //指定完成日期
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.IsCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.IsCurrEduCls = objcc_ExamPaperEduClsRelaEN.IsCurrEduCls; //是否为教学班作业
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.IsGroupWork, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.IsGroupWork = objcc_ExamPaperEduClsRelaEN.IsGroupWork; //是否为小组作业
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.CourseStudentGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId = objcc_ExamPaperEduClsRelaEN.CourseStudentGroupId; //学生分组表流水号
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.WorkTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.WorkTypeId = objcc_ExamPaperEduClsRelaEN.WorkTypeId; //作业类型Id
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.UpdDate = objcc_ExamPaperEduClsRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.UpdUserId = objcc_ExamPaperEduClsRelaEN.UpdUserId == "[null]" ? null :  objcc_ExamPaperEduClsRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_ExamPaperEduClsRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperEduClsRelaEN.Memo = objcc_ExamPaperEduClsRelaEN.Memo == "[null]" ? null :  objcc_ExamPaperEduClsRelaEN.Memo; //备注
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
 /// <param name = "objcc_ExamPaperEduClsRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
try
{
if (objcc_ExamPaperEduClsRelaEN.PubDate == "[null]") objcc_ExamPaperEduClsRelaEN.PubDate = null; //发布日期
if (objcc_ExamPaperEduClsRelaEN.publisher == "[null]") objcc_ExamPaperEduClsRelaEN.publisher = null; //发布者Id
if (objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate == "[null]") objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate = null; //指定完成日期
if (objcc_ExamPaperEduClsRelaEN.UpdUserId == "[null]") objcc_ExamPaperEduClsRelaEN.UpdUserId = null; //修改用户Id
if (objcc_ExamPaperEduClsRelaEN.Memo == "[null]") objcc_ExamPaperEduClsRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
 cc_ExamPaperEduClsRelaDA.CheckPropertyNew(objcc_ExamPaperEduClsRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
 cc_ExamPaperEduClsRelaDA.CheckProperty4Condition(objcc_ExamPaperEduClsRelaEN);
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
if (clscc_ExamPaperEduClsRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperEduClsRelaBL没有刷新缓存机制(clscc_ExamPaperEduClsRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdExamPaperEduClsRela");
//if (arrcc_ExamPaperEduClsRelaObjLstCache == null)
//{
//arrcc_ExamPaperEduClsRelaObjLstCache = cc_ExamPaperEduClsRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdExamPaperEduClsRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ExamPaperEduClsRelaEN GetObjByIdExamPaperEduClsRelaCache(long lngIdExamPaperEduClsRela)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_ExamPaperEduClsRelaEN._CurrTabName);
List<clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaObjLstCache = GetObjLstCache();
IEnumerable <clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaObjLst_Sel =
arrcc_ExamPaperEduClsRelaObjLstCache
.Where(x=> x.IdExamPaperEduClsRela == lngIdExamPaperEduClsRela 
);
if (arrcc_ExamPaperEduClsRelaObjLst_Sel.Count() == 0)
{
   clscc_ExamPaperEduClsRelaEN obj = clscc_ExamPaperEduClsRelaBL.GetObjByIdExamPaperEduClsRela(lngIdExamPaperEduClsRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_ExamPaperEduClsRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ExamPaperEduClsRelaEN> GetAllcc_ExamPaperEduClsRelaObjLstCache()
{
//获取缓存中的对象列表
List<clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaObjLstCache = GetObjLstCache(); 
return arrcc_ExamPaperEduClsRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ExamPaperEduClsRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_ExamPaperEduClsRelaEN._CurrTabName);
List<clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_ExamPaperEduClsRelaObjLstCache;
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
string strKey = string.Format("{0}", clscc_ExamPaperEduClsRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_ExamPaperEduClsRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_ExamPaperEduClsRelaEN._RefreshTimeLst.Count == 0) return "";
return clscc_ExamPaperEduClsRelaEN._RefreshTimeLst[clscc_ExamPaperEduClsRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_ExamPaperEduClsRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_ExamPaperEduClsRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_ExamPaperEduClsRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_ExamPaperEduClsRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_ExamPaperEduClsRela(考卷教学班关系)
 /// 唯一性条件:CourseExamPaperId_id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN)
{
//检测记录是否存在
string strResult = cc_ExamPaperEduClsRelaDA.GetUniCondStr(objcc_ExamPaperEduClsRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdExamPaperEduClsRela)
{
if (strInFldName != concc_ExamPaperEduClsRela.IdExamPaperEduClsRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_ExamPaperEduClsRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_ExamPaperEduClsRela.AttributeName));
throw new Exception(strMsg);
}
var objcc_ExamPaperEduClsRela = clscc_ExamPaperEduClsRelaBL.GetObjByIdExamPaperEduClsRelaCache(lngIdExamPaperEduClsRela);
if (objcc_ExamPaperEduClsRela == null) return "";
return objcc_ExamPaperEduClsRela[strOutFldName].ToString();
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
int intRecCount = clscc_ExamPaperEduClsRelaDA.GetRecCount(strTabName);
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
int intRecCount = clscc_ExamPaperEduClsRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_ExamPaperEduClsRelaDA.GetRecCount();
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
int intRecCount = clscc_ExamPaperEduClsRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaCond)
{
List<clscc_ExamPaperEduClsRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_ExamPaperEduClsRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_ExamPaperEduClsRela.AttributeName)
{
if (objcc_ExamPaperEduClsRelaCond.IsUpdated(strFldName) == false) continue;
if (objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperEduClsRelaCond[strFldName].ToString());
}
else
{
if (objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_ExamPaperEduClsRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperEduClsRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_ExamPaperEduClsRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_ExamPaperEduClsRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperEduClsRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperEduClsRelaCond[strFldName]));
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
 List<string> arrList = clscc_ExamPaperEduClsRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_ExamPaperEduClsRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_ExamPaperEduClsRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_ExamPaperEduClsRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperEduClsRelaDA.SetFldValue(clscc_ExamPaperEduClsRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_ExamPaperEduClsRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperEduClsRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperEduClsRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperEduClsRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_ExamPaperEduClsRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**作业教学班关系流水号*/ 
 strCreateTabCode.Append(" IdExamPaperEduClsRela bigint primary key identity, "); 
 // /**考卷流水号*/ 
 strCreateTabCode.Append(" CourseExamPaperId char(8) not Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
 // /**分值*/ 
 strCreateTabCode.Append(" Scores decimal(8,2) Null, "); 
 // /**教师工号*/ 
 strCreateTabCode.Append(" TeacherId varchar(12) not Null, "); 
 // /**是否发布*/ 
 strCreateTabCode.Append(" IsPublish bit Null, "); 
 // /**发布日期*/ 
 strCreateTabCode.Append(" PubDate varchar(14) Null, "); 
 // /**发布者Id*/ 
 strCreateTabCode.Append(" publisher varchar(20) Null, "); 
 // /**指定完成日期*/ 
 strCreateTabCode.Append(" SpecifyCompletionDate varchar(14) Null, "); 
 // /**是否为教学班作业*/ 
 strCreateTabCode.Append(" IsCurrEduCls bit Null, "); 
 // /**是否为小组作业*/ 
 strCreateTabCode.Append(" IsGroupWork bit Null, "); 
 // /**学生分组表流水号*/ 
 strCreateTabCode.Append(" CourseStudentGroupId bigint Null, "); 
 // /**作业类型Id*/ 
 strCreateTabCode.Append(" WorkTypeId char(2) not Null, "); 
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
 /// 考卷教学班关系(cc_ExamPaperEduClsRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_ExamPaperEduClsRela : clsCommFun4BL
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
clscc_ExamPaperEduClsRelaBL.ReFreshThisCache();
}
}

}