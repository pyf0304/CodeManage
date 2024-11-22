
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionOptionsBL
 表名:QuestionOptions(01120188)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:14
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
public static class  clsQuestionOptionsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionOptionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionOptionsEN GetObj(this K_QuestionOptionId_QuestionOptions myKey)
{
clsQuestionOptionsEN objQuestionOptionsEN = clsQuestionOptionsBL.QuestionOptionsDA.GetObjByQuestionOptionId(myKey.Value);
return objQuestionOptionsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionOptionsEN objQuestionOptionsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionOptionsEN) == false)
{
var strMsg = string.Format("记录已经存在!题目选项Id = [{0}]的数据已经存在!(in clsQuestionOptionsBL.AddNewRecord)", objQuestionOptionsEN.QuestionOptionId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionOptionsEN.QuestionOptionId) == true || clsQuestionOptionsBL.IsExist(objQuestionOptionsEN.QuestionOptionId) == true)
 {
     objQuestionOptionsEN.QuestionOptionId = clsQuestionOptionsBL.GetMaxStrId_S();
 }
bool bolResult = clsQuestionOptionsBL.QuestionOptionsDA.AddNewRecordBySQL2(objQuestionOptionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
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
public static bool AddRecordEx(this clsQuestionOptionsEN objQuestionOptionsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsQuestionOptionsBL.IsExist(objQuestionOptionsEN.QuestionOptionId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objQuestionOptionsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objQuestionOptionsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(题目选项Id(QuestionOptionId)=[{0}])已经存在,不能重复!", objQuestionOptionsEN.QuestionOptionId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objQuestionOptionsEN.QuestionOptionId) == true || clsQuestionOptionsBL.IsExist(objQuestionOptionsEN.QuestionOptionId) == true)
 {
     objQuestionOptionsEN.QuestionOptionId = clsQuestionOptionsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objQuestionOptionsEN.AddNewRecord();
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
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionOptionsEN objQuestionOptionsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionOptionsEN) == false)
{
var strMsg = string.Format("记录已经存在!题目选项Id = [{0}]的数据已经存在!(in clsQuestionOptionsBL.AddNewRecordWithMaxId)", objQuestionOptionsEN.QuestionOptionId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionOptionsEN.QuestionOptionId) == true || clsQuestionOptionsBL.IsExist(objQuestionOptionsEN.QuestionOptionId) == true)
 {
     objQuestionOptionsEN.QuestionOptionId = clsQuestionOptionsBL.GetMaxStrId_S();
 }
string strQuestionOptionId = clsQuestionOptionsBL.QuestionOptionsDA.AddNewRecordBySQL2WithReturnKey(objQuestionOptionsEN);
     objQuestionOptionsEN.QuestionOptionId = strQuestionOptionId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
}
return strQuestionOptionId;
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
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQuestionOptionsEN objQuestionOptionsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionOptionsEN) == false)
{
var strMsg = string.Format("记录已经存在!题目选项Id = [{0}]的数据已经存在!(in clsQuestionOptionsBL.AddNewRecordWithReturnKey)", objQuestionOptionsEN.QuestionOptionId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionOptionsEN.QuestionOptionId) == true || clsQuestionOptionsBL.IsExist(objQuestionOptionsEN.QuestionOptionId) == true)
 {
     objQuestionOptionsEN.QuestionOptionId = clsQuestionOptionsBL.GetMaxStrId_S();
 }
string strKey = clsQuestionOptionsBL.QuestionOptionsDA.AddNewRecordBySQL2WithReturnKey(objQuestionOptionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
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
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetQuestionOptionId(this clsQuestionOptionsEN objQuestionOptionsEN, string strQuestionOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionOptionId, 8, conQuestionOptions.QuestionOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionOptionId, 8, conQuestionOptions.QuestionOptionId);
}
objQuestionOptionsEN.QuestionOptionId = strQuestionOptionId; //题目选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.QuestionOptionId) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.QuestionOptionId, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.QuestionOptionId] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetOptionName(this clsQuestionOptionsEN objQuestionOptionsEN, string strOptionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptionName, 4000, conQuestionOptions.OptionName);
}
objQuestionOptionsEN.OptionName = strOptionName; //选项名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.OptionName) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.OptionName, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.OptionName] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetQuestionId(this clsQuestionOptionsEN objQuestionOptionsEN, long lngQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngQuestionId, conQuestionOptions.QuestionId);
objQuestionOptionsEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.QuestionId) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.QuestionId, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.QuestionId] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetOptionIndex(this clsQuestionOptionsEN objQuestionOptionsEN, int intOptionIndex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOptionIndex, conQuestionOptions.OptionIndex);
objQuestionOptionsEN.OptionIndex = intOptionIndex; //选项序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.OptionIndex) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.OptionIndex, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.OptionIndex] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetOptionTitle(this clsQuestionOptionsEN objQuestionOptionsEN, string strOptionTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptionTitle, 20, conQuestionOptions.OptionTitle);
}
objQuestionOptionsEN.OptionTitle = strOptionTitle; //选项标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.OptionTitle) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.OptionTitle, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.OptionTitle] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetOptionContent(this clsQuestionOptionsEN objQuestionOptionsEN, string strOptionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptionContent, 4000, conQuestionOptions.OptionContent);
}
objQuestionOptionsEN.OptionContent = strOptionContent; //选项内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.OptionContent) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.OptionContent, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.OptionContent] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetIsCorrect(this clsQuestionOptionsEN objQuestionOptionsEN, bool bolIsCorrect, string strComparisonOp="")
	{
objQuestionOptionsEN.IsCorrect = bolIsCorrect; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.IsCorrect) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.IsCorrect, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.IsCorrect] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetScore(this clsQuestionOptionsEN objQuestionOptionsEN, double? dblScore, string strComparisonOp="")
	{
objQuestionOptionsEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.Score) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.Score, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.Score] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetIsShow(this clsQuestionOptionsEN objQuestionOptionsEN, bool bolIsShow, string strComparisonOp="")
	{
objQuestionOptionsEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.IsShow) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.IsShow, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.IsShow] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetCourseId(this clsQuestionOptionsEN objQuestionOptionsEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conQuestionOptions.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conQuestionOptions.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conQuestionOptions.CourseId);
}
objQuestionOptionsEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.CourseId) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.CourseId, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.CourseId] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetUpdDate(this clsQuestionOptionsEN objQuestionOptionsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionOptions.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionOptions.UpdDate);
}
objQuestionOptionsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.UpdDate) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.UpdDate, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.UpdDate] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetUpdUser(this clsQuestionOptionsEN objQuestionOptionsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionOptions.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionOptions.UpdUser);
}
objQuestionOptionsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.UpdUser) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.UpdUser, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.UpdUser] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionOptionsEN SetMemo(this clsQuestionOptionsEN objQuestionOptionsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionOptions.Memo);
}
objQuestionOptionsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.Memo) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.Memo, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.Memo] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQuestionOptionsEN objQuestionOptionsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQuestionOptionsEN.CheckPropertyNew();
clsQuestionOptionsEN objQuestionOptionsCond = new clsQuestionOptionsEN();
string strCondition = objQuestionOptionsCond
.SetQuestionOptionId(objQuestionOptionsEN.QuestionOptionId, "<>")
.SetQuestionOptionId(objQuestionOptionsEN.QuestionOptionId, "=")
.GetCombineCondition();
objQuestionOptionsEN._IsCheckProperty = true;
bool bolIsExist = clsQuestionOptionsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionOptionId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQuestionOptionsEN.Update();
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
 /// <param name = "objQuestionOptions">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQuestionOptionsEN objQuestionOptions)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQuestionOptionsEN objQuestionOptionsCond = new clsQuestionOptionsEN();
string strCondition = objQuestionOptionsCond
.SetQuestionOptionId(objQuestionOptions.QuestionOptionId, "=")
.GetCombineCondition();
objQuestionOptions._IsCheckProperty = true;
bool bolIsExist = clsQuestionOptionsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQuestionOptions.QuestionOptionId = clsQuestionOptionsBL.GetFirstID_S(strCondition);
objQuestionOptions.UpdateWithCondition(strCondition);
}
else
{
objQuestionOptions.QuestionOptionId = clsQuestionOptionsBL.GetMaxStrId_S();
objQuestionOptions.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionOptionsEN objQuestionOptionsEN)
{
 if (string.IsNullOrEmpty(objQuestionOptionsEN.QuestionOptionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionOptionsBL.QuestionOptionsDA.UpdateBySql2(objQuestionOptionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
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
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionOptionsEN objQuestionOptionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQuestionOptionsEN.QuestionOptionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionOptionsBL.QuestionOptionsDA.UpdateBySql2(objQuestionOptionsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
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
 /// <param name = "objQuestionOptionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionOptionsEN objQuestionOptionsEN, string strWhereCond)
{
try
{
bool bolResult = clsQuestionOptionsBL.QuestionOptionsDA.UpdateBySqlWithCondition(objQuestionOptionsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
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
 /// <param name = "objQuestionOptionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionOptionsEN objQuestionOptionsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQuestionOptionsBL.QuestionOptionsDA.UpdateBySqlWithConditionTransaction(objQuestionOptionsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
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
 /// <param name = "strQuestionOptionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQuestionOptionsEN objQuestionOptionsEN)
{
try
{
int intRecNum = clsQuestionOptionsBL.QuestionOptionsDA.DelRecord(objQuestionOptionsEN.QuestionOptionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
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
 /// <param name = "objQuestionOptionsENS">源对象</param>
 /// <param name = "objQuestionOptionsENT">目标对象</param>
 public static void CopyTo(this clsQuestionOptionsEN objQuestionOptionsENS, clsQuestionOptionsEN objQuestionOptionsENT)
{
try
{
objQuestionOptionsENT.QuestionOptionId = objQuestionOptionsENS.QuestionOptionId; //题目选项Id
objQuestionOptionsENT.OptionName = objQuestionOptionsENS.OptionName; //选项名称
objQuestionOptionsENT.QuestionId = objQuestionOptionsENS.QuestionId; //题目Id
objQuestionOptionsENT.OptionIndex = objQuestionOptionsENS.OptionIndex; //选项序号
objQuestionOptionsENT.OptionTitle = objQuestionOptionsENS.OptionTitle; //选项标题
objQuestionOptionsENT.OptionContent = objQuestionOptionsENS.OptionContent; //选项内容
objQuestionOptionsENT.IsCorrect = objQuestionOptionsENS.IsCorrect; //是否正确
objQuestionOptionsENT.Score = objQuestionOptionsENS.Score; //得分
objQuestionOptionsENT.IsShow = objQuestionOptionsENS.IsShow; //是否启用
objQuestionOptionsENT.CourseId = objQuestionOptionsENS.CourseId; //课程Id
objQuestionOptionsENT.UpdDate = objQuestionOptionsENS.UpdDate; //修改日期
objQuestionOptionsENT.UpdUser = objQuestionOptionsENS.UpdUser; //修改人
objQuestionOptionsENT.Memo = objQuestionOptionsENS.Memo; //备注
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
 /// <param name = "objQuestionOptionsENS">源对象</param>
 /// <returns>目标对象=>clsQuestionOptionsEN:objQuestionOptionsENT</returns>
 public static clsQuestionOptionsEN CopyTo(this clsQuestionOptionsEN objQuestionOptionsENS)
{
try
{
 clsQuestionOptionsEN objQuestionOptionsENT = new clsQuestionOptionsEN()
{
QuestionOptionId = objQuestionOptionsENS.QuestionOptionId, //题目选项Id
OptionName = objQuestionOptionsENS.OptionName, //选项名称
QuestionId = objQuestionOptionsENS.QuestionId, //题目Id
OptionIndex = objQuestionOptionsENS.OptionIndex, //选项序号
OptionTitle = objQuestionOptionsENS.OptionTitle, //选项标题
OptionContent = objQuestionOptionsENS.OptionContent, //选项内容
IsCorrect = objQuestionOptionsENS.IsCorrect, //是否正确
Score = objQuestionOptionsENS.Score, //得分
IsShow = objQuestionOptionsENS.IsShow, //是否启用
CourseId = objQuestionOptionsENS.CourseId, //课程Id
UpdDate = objQuestionOptionsENS.UpdDate, //修改日期
UpdUser = objQuestionOptionsENS.UpdUser, //修改人
Memo = objQuestionOptionsENS.Memo, //备注
};
 return objQuestionOptionsENT;
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
public static void CheckPropertyNew(this clsQuestionOptionsEN objQuestionOptionsEN)
{
 clsQuestionOptionsBL.QuestionOptionsDA.CheckPropertyNew(objQuestionOptionsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQuestionOptionsEN objQuestionOptionsEN)
{
 clsQuestionOptionsBL.QuestionOptionsDA.CheckProperty4Condition(objQuestionOptionsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionOptionsEN objQuestionOptionsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.QuestionOptionId) == true)
{
string strComparisonOpQuestionOptionId = objQuestionOptionsCond.dicFldComparisonOp[conQuestionOptions.QuestionOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.QuestionOptionId, objQuestionOptionsCond.QuestionOptionId, strComparisonOpQuestionOptionId);
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.OptionName) == true)
{
string strComparisonOpOptionName = objQuestionOptionsCond.dicFldComparisonOp[conQuestionOptions.OptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.OptionName, objQuestionOptionsCond.OptionName, strComparisonOpOptionName);
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.QuestionId) == true)
{
string strComparisonOpQuestionId = objQuestionOptionsCond.dicFldComparisonOp[conQuestionOptions.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionOptions.QuestionId, objQuestionOptionsCond.QuestionId, strComparisonOpQuestionId);
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.OptionIndex) == true)
{
string strComparisonOpOptionIndex = objQuestionOptionsCond.dicFldComparisonOp[conQuestionOptions.OptionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionOptions.OptionIndex, objQuestionOptionsCond.OptionIndex, strComparisonOpOptionIndex);
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.OptionTitle) == true)
{
string strComparisonOpOptionTitle = objQuestionOptionsCond.dicFldComparisonOp[conQuestionOptions.OptionTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.OptionTitle, objQuestionOptionsCond.OptionTitle, strComparisonOpOptionTitle);
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.OptionContent) == true)
{
string strComparisonOpOptionContent = objQuestionOptionsCond.dicFldComparisonOp[conQuestionOptions.OptionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.OptionContent, objQuestionOptionsCond.OptionContent, strComparisonOpOptionContent);
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.IsCorrect) == true)
{
if (objQuestionOptionsCond.IsCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionOptions.IsCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionOptions.IsCorrect);
}
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.Score) == true)
{
string strComparisonOpScore = objQuestionOptionsCond.dicFldComparisonOp[conQuestionOptions.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionOptions.Score, objQuestionOptionsCond.Score, strComparisonOpScore);
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.IsShow) == true)
{
if (objQuestionOptionsCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionOptions.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionOptions.IsShow);
}
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.CourseId) == true)
{
string strComparisonOpCourseId = objQuestionOptionsCond.dicFldComparisonOp[conQuestionOptions.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.CourseId, objQuestionOptionsCond.CourseId, strComparisonOpCourseId);
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.UpdDate) == true)
{
string strComparisonOpUpdDate = objQuestionOptionsCond.dicFldComparisonOp[conQuestionOptions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.UpdDate, objQuestionOptionsCond.UpdDate, strComparisonOpUpdDate);
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.UpdUser) == true)
{
string strComparisonOpUpdUser = objQuestionOptionsCond.dicFldComparisonOp[conQuestionOptions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.UpdUser, objQuestionOptionsCond.UpdUser, strComparisonOpUpdUser);
}
if (objQuestionOptionsCond.IsUpdated(conQuestionOptions.Memo) == true)
{
string strComparisonOpMemo = objQuestionOptionsCond.dicFldComparisonOp[conQuestionOptions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.Memo, objQuestionOptionsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QuestionOptions(题目选项), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionOptionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQuestionOptionsEN objQuestionOptionsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQuestionOptionsEN == null) return true;
if (objQuestionOptionsEN.QuestionOptionId == null || objQuestionOptionsEN.QuestionOptionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionOptionId = '{0}'", objQuestionOptionsEN.QuestionOptionId);
if (clsQuestionOptionsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("QuestionOptionId !=  '{0}'", objQuestionOptionsEN.QuestionOptionId);
 sbCondition.AppendFormat(" and QuestionOptionId = '{0}'", objQuestionOptionsEN.QuestionOptionId);
if (clsQuestionOptionsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QuestionOptions(题目选项), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionOptionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQuestionOptionsEN objQuestionOptionsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQuestionOptionsEN == null) return "";
if (objQuestionOptionsEN.QuestionOptionId == null || objQuestionOptionsEN.QuestionOptionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionOptionId = '{0}'", objQuestionOptionsEN.QuestionOptionId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QuestionOptionId !=  '{0}'", objQuestionOptionsEN.QuestionOptionId);
 sbCondition.AppendFormat(" and QuestionOptionId = '{0}'", objQuestionOptionsEN.QuestionOptionId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QuestionOptions
{
public virtual bool UpdRelaTabDate(string strQuestionOptionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 题目选项(QuestionOptions)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQuestionOptionsBL
{
public static RelatedActions_QuestionOptions relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQuestionOptionsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQuestionOptionsDA QuestionOptionsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQuestionOptionsDA();
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
 public clsQuestionOptionsBL()
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
if (string.IsNullOrEmpty(clsQuestionOptionsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionOptionsEN._ConnectString);
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
public static DataTable GetDataTable_QuestionOptions(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QuestionOptionsDA.GetDataTable_QuestionOptions(strWhereCond);
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
objDT = QuestionOptionsDA.GetDataTable(strWhereCond);
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
objDT = QuestionOptionsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QuestionOptionsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QuestionOptionsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QuestionOptionsDA.GetDataTable_Top(objTopPara);
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
objDT = QuestionOptionsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QuestionOptionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QuestionOptionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionOptionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQuestionOptionsEN> GetObjLstByQuestionOptionIdLst(List<string> arrQuestionOptionIdLst)
{
List<clsQuestionOptionsEN> arrObjLst = new List<clsQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionOptionIdLst, true);
 string strWhereCond = string.Format("QuestionOptionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN();
try
{
objQuestionOptionsEN.QuestionOptionId = objRow[conQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objQuestionOptionsEN.OptionName = objRow[conQuestionOptions.OptionName] == DBNull.Value ? null : objRow[conQuestionOptions.OptionName].ToString().Trim(); //选项名称
objQuestionOptionsEN.QuestionId = Int32.Parse(objRow[conQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[conQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objQuestionOptionsEN.OptionTitle = objRow[conQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[conQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objQuestionOptionsEN.OptionContent = objRow[conQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[conQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objQuestionOptionsEN.Score = objRow[conQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conQuestionOptions.Score].ToString().Trim()); //得分
objQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsShow].ToString().Trim()); //是否启用
objQuestionOptionsEN.CourseId = objRow[conQuestionOptions.CourseId].ToString().Trim(); //课程Id
objQuestionOptionsEN.UpdDate = objRow[conQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objQuestionOptionsEN.UpdUser = objRow[conQuestionOptions.UpdUser].ToString().Trim(); //修改人
objQuestionOptionsEN.Memo = objRow[conQuestionOptions.Memo] == DBNull.Value ? null : objRow[conQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionOptionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionOptionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQuestionOptionsEN> GetObjLstByQuestionOptionIdLstCache(List<string> arrQuestionOptionIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName, strCourseId);
List<clsQuestionOptionsEN> arrQuestionOptionsObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionOptionsEN> arrQuestionOptionsObjLst_Sel =
arrQuestionOptionsObjLstCache
.Where(x => arrQuestionOptionIdLst.Contains(x.QuestionOptionId));
return arrQuestionOptionsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionOptionsEN> GetObjLst(string strWhereCond)
{
List<clsQuestionOptionsEN> arrObjLst = new List<clsQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN();
try
{
objQuestionOptionsEN.QuestionOptionId = objRow[conQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objQuestionOptionsEN.OptionName = objRow[conQuestionOptions.OptionName] == DBNull.Value ? null : objRow[conQuestionOptions.OptionName].ToString().Trim(); //选项名称
objQuestionOptionsEN.QuestionId = Int32.Parse(objRow[conQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[conQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objQuestionOptionsEN.OptionTitle = objRow[conQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[conQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objQuestionOptionsEN.OptionContent = objRow[conQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[conQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objQuestionOptionsEN.Score = objRow[conQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conQuestionOptions.Score].ToString().Trim()); //得分
objQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsShow].ToString().Trim()); //是否启用
objQuestionOptionsEN.CourseId = objRow[conQuestionOptions.CourseId].ToString().Trim(); //课程Id
objQuestionOptionsEN.UpdDate = objRow[conQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objQuestionOptionsEN.UpdUser = objRow[conQuestionOptions.UpdUser].ToString().Trim(); //修改人
objQuestionOptionsEN.Memo = objRow[conQuestionOptions.Memo] == DBNull.Value ? null : objRow[conQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionOptionsEN);
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
public static List<clsQuestionOptionsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQuestionOptionsEN> arrObjLst = new List<clsQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN();
try
{
objQuestionOptionsEN.QuestionOptionId = objRow[conQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objQuestionOptionsEN.OptionName = objRow[conQuestionOptions.OptionName] == DBNull.Value ? null : objRow[conQuestionOptions.OptionName].ToString().Trim(); //选项名称
objQuestionOptionsEN.QuestionId = Int32.Parse(objRow[conQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[conQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objQuestionOptionsEN.OptionTitle = objRow[conQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[conQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objQuestionOptionsEN.OptionContent = objRow[conQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[conQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objQuestionOptionsEN.Score = objRow[conQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conQuestionOptions.Score].ToString().Trim()); //得分
objQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsShow].ToString().Trim()); //是否启用
objQuestionOptionsEN.CourseId = objRow[conQuestionOptions.CourseId].ToString().Trim(); //课程Id
objQuestionOptionsEN.UpdDate = objRow[conQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objQuestionOptionsEN.UpdUser = objRow[conQuestionOptions.UpdUser].ToString().Trim(); //修改人
objQuestionOptionsEN.Memo = objRow[conQuestionOptions.Memo] == DBNull.Value ? null : objRow[conQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionOptionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQuestionOptionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQuestionOptionsEN> GetSubObjLstCache(clsQuestionOptionsEN objQuestionOptionsCond)
{
 string strCourseId = objQuestionOptionsCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsQuestionOptionsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsQuestionOptionsEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionOptionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionOptions.AttributeName)
{
if (objQuestionOptionsCond.IsUpdated(strFldName) == false) continue;
if (objQuestionOptionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionOptionsCond[strFldName].ToString());
}
else
{
if (objQuestionOptionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionOptionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionOptionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionOptionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionOptionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionOptionsCond[strFldName]));
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
public static List<clsQuestionOptionsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQuestionOptionsEN> arrObjLst = new List<clsQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN();
try
{
objQuestionOptionsEN.QuestionOptionId = objRow[conQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objQuestionOptionsEN.OptionName = objRow[conQuestionOptions.OptionName] == DBNull.Value ? null : objRow[conQuestionOptions.OptionName].ToString().Trim(); //选项名称
objQuestionOptionsEN.QuestionId = Int32.Parse(objRow[conQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[conQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objQuestionOptionsEN.OptionTitle = objRow[conQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[conQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objQuestionOptionsEN.OptionContent = objRow[conQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[conQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objQuestionOptionsEN.Score = objRow[conQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conQuestionOptions.Score].ToString().Trim()); //得分
objQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsShow].ToString().Trim()); //是否启用
objQuestionOptionsEN.CourseId = objRow[conQuestionOptions.CourseId].ToString().Trim(); //课程Id
objQuestionOptionsEN.UpdDate = objRow[conQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objQuestionOptionsEN.UpdUser = objRow[conQuestionOptions.UpdUser].ToString().Trim(); //修改人
objQuestionOptionsEN.Memo = objRow[conQuestionOptions.Memo] == DBNull.Value ? null : objRow[conQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionOptionsEN);
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
public static List<clsQuestionOptionsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQuestionOptionsEN> arrObjLst = new List<clsQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN();
try
{
objQuestionOptionsEN.QuestionOptionId = objRow[conQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objQuestionOptionsEN.OptionName = objRow[conQuestionOptions.OptionName] == DBNull.Value ? null : objRow[conQuestionOptions.OptionName].ToString().Trim(); //选项名称
objQuestionOptionsEN.QuestionId = Int32.Parse(objRow[conQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[conQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objQuestionOptionsEN.OptionTitle = objRow[conQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[conQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objQuestionOptionsEN.OptionContent = objRow[conQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[conQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objQuestionOptionsEN.Score = objRow[conQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conQuestionOptions.Score].ToString().Trim()); //得分
objQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsShow].ToString().Trim()); //是否启用
objQuestionOptionsEN.CourseId = objRow[conQuestionOptions.CourseId].ToString().Trim(); //课程Id
objQuestionOptionsEN.UpdDate = objRow[conQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objQuestionOptionsEN.UpdUser = objRow[conQuestionOptions.UpdUser].ToString().Trim(); //修改人
objQuestionOptionsEN.Memo = objRow[conQuestionOptions.Memo] == DBNull.Value ? null : objRow[conQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionOptionsEN);
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
List<clsQuestionOptionsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQuestionOptionsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionOptionsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQuestionOptionsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionOptionsEN> arrObjLst = new List<clsQuestionOptionsEN>(); 
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
	clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN();
try
{
objQuestionOptionsEN.QuestionOptionId = objRow[conQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objQuestionOptionsEN.OptionName = objRow[conQuestionOptions.OptionName] == DBNull.Value ? null : objRow[conQuestionOptions.OptionName].ToString().Trim(); //选项名称
objQuestionOptionsEN.QuestionId = Int32.Parse(objRow[conQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[conQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objQuestionOptionsEN.OptionTitle = objRow[conQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[conQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objQuestionOptionsEN.OptionContent = objRow[conQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[conQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objQuestionOptionsEN.Score = objRow[conQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conQuestionOptions.Score].ToString().Trim()); //得分
objQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsShow].ToString().Trim()); //是否启用
objQuestionOptionsEN.CourseId = objRow[conQuestionOptions.CourseId].ToString().Trim(); //课程Id
objQuestionOptionsEN.UpdDate = objRow[conQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objQuestionOptionsEN.UpdUser = objRow[conQuestionOptions.UpdUser].ToString().Trim(); //修改人
objQuestionOptionsEN.Memo = objRow[conQuestionOptions.Memo] == DBNull.Value ? null : objRow[conQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionOptionsEN);
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
public static List<clsQuestionOptionsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQuestionOptionsEN> arrObjLst = new List<clsQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN();
try
{
objQuestionOptionsEN.QuestionOptionId = objRow[conQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objQuestionOptionsEN.OptionName = objRow[conQuestionOptions.OptionName] == DBNull.Value ? null : objRow[conQuestionOptions.OptionName].ToString().Trim(); //选项名称
objQuestionOptionsEN.QuestionId = Int32.Parse(objRow[conQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[conQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objQuestionOptionsEN.OptionTitle = objRow[conQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[conQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objQuestionOptionsEN.OptionContent = objRow[conQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[conQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objQuestionOptionsEN.Score = objRow[conQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conQuestionOptions.Score].ToString().Trim()); //得分
objQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsShow].ToString().Trim()); //是否启用
objQuestionOptionsEN.CourseId = objRow[conQuestionOptions.CourseId].ToString().Trim(); //课程Id
objQuestionOptionsEN.UpdDate = objRow[conQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objQuestionOptionsEN.UpdUser = objRow[conQuestionOptions.UpdUser].ToString().Trim(); //修改人
objQuestionOptionsEN.Memo = objRow[conQuestionOptions.Memo] == DBNull.Value ? null : objRow[conQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionOptionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQuestionOptionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQuestionOptionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionOptionsEN> arrObjLst = new List<clsQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN();
try
{
objQuestionOptionsEN.QuestionOptionId = objRow[conQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objQuestionOptionsEN.OptionName = objRow[conQuestionOptions.OptionName] == DBNull.Value ? null : objRow[conQuestionOptions.OptionName].ToString().Trim(); //选项名称
objQuestionOptionsEN.QuestionId = Int32.Parse(objRow[conQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[conQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objQuestionOptionsEN.OptionTitle = objRow[conQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[conQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objQuestionOptionsEN.OptionContent = objRow[conQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[conQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objQuestionOptionsEN.Score = objRow[conQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conQuestionOptions.Score].ToString().Trim()); //得分
objQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsShow].ToString().Trim()); //是否启用
objQuestionOptionsEN.CourseId = objRow[conQuestionOptions.CourseId].ToString().Trim(); //课程Id
objQuestionOptionsEN.UpdDate = objRow[conQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objQuestionOptionsEN.UpdUser = objRow[conQuestionOptions.UpdUser].ToString().Trim(); //修改人
objQuestionOptionsEN.Memo = objRow[conQuestionOptions.Memo] == DBNull.Value ? null : objRow[conQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionOptionsEN);
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
public static List<clsQuestionOptionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQuestionOptionsEN> arrObjLst = new List<clsQuestionOptionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN();
try
{
objQuestionOptionsEN.QuestionOptionId = objRow[conQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objQuestionOptionsEN.OptionName = objRow[conQuestionOptions.OptionName] == DBNull.Value ? null : objRow[conQuestionOptions.OptionName].ToString().Trim(); //选项名称
objQuestionOptionsEN.QuestionId = Int32.Parse(objRow[conQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[conQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objQuestionOptionsEN.OptionTitle = objRow[conQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[conQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objQuestionOptionsEN.OptionContent = objRow[conQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[conQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objQuestionOptionsEN.Score = objRow[conQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conQuestionOptions.Score].ToString().Trim()); //得分
objQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsShow].ToString().Trim()); //是否启用
objQuestionOptionsEN.CourseId = objRow[conQuestionOptions.CourseId].ToString().Trim(); //课程Id
objQuestionOptionsEN.UpdDate = objRow[conQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objQuestionOptionsEN.UpdUser = objRow[conQuestionOptions.UpdUser].ToString().Trim(); //修改人
objQuestionOptionsEN.Memo = objRow[conQuestionOptions.Memo] == DBNull.Value ? null : objRow[conQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionOptionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionOptionsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQuestionOptionsEN> arrObjLst = new List<clsQuestionOptionsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN();
try
{
objQuestionOptionsEN.QuestionOptionId = objRow[conQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objQuestionOptionsEN.OptionName = objRow[conQuestionOptions.OptionName] == DBNull.Value ? null : objRow[conQuestionOptions.OptionName].ToString().Trim(); //选项名称
objQuestionOptionsEN.QuestionId = Int32.Parse(objRow[conQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[conQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objQuestionOptionsEN.OptionTitle = objRow[conQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[conQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objQuestionOptionsEN.OptionContent = objRow[conQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[conQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objQuestionOptionsEN.Score = objRow[conQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conQuestionOptions.Score].ToString().Trim()); //得分
objQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionOptions.IsShow].ToString().Trim()); //是否启用
objQuestionOptionsEN.CourseId = objRow[conQuestionOptions.CourseId].ToString().Trim(); //课程Id
objQuestionOptionsEN.UpdDate = objRow[conQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objQuestionOptionsEN.UpdUser = objRow[conQuestionOptions.UpdUser].ToString().Trim(); //修改人
objQuestionOptionsEN.Memo = objRow[conQuestionOptions.Memo] == DBNull.Value ? null : objRow[conQuestionOptions.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionOptionsEN.QuestionOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionOptionsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQuestionOptions(ref clsQuestionOptionsEN objQuestionOptionsEN)
{
bool bolResult = QuestionOptionsDA.GetQuestionOptions(ref objQuestionOptionsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionOptionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionOptionsEN GetObjByQuestionOptionId(string strQuestionOptionId)
{
if (strQuestionOptionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQuestionOptionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQuestionOptionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQuestionOptionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQuestionOptionsEN objQuestionOptionsEN = QuestionOptionsDA.GetObjByQuestionOptionId(strQuestionOptionId);
return objQuestionOptionsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQuestionOptionsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQuestionOptionsEN objQuestionOptionsEN = QuestionOptionsDA.GetFirstObj(strWhereCond);
 return objQuestionOptionsEN;
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
public static clsQuestionOptionsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQuestionOptionsEN objQuestionOptionsEN = QuestionOptionsDA.GetObjByDataRow(objRow);
 return objQuestionOptionsEN;
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
public static clsQuestionOptionsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQuestionOptionsEN objQuestionOptionsEN = QuestionOptionsDA.GetObjByDataRow(objRow);
 return objQuestionOptionsEN;
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
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <param name = "lstQuestionOptionsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionOptionsEN GetObjByQuestionOptionIdFromList(string strQuestionOptionId, List<clsQuestionOptionsEN> lstQuestionOptionsObjLst)
{
foreach (clsQuestionOptionsEN objQuestionOptionsEN in lstQuestionOptionsObjLst)
{
if (objQuestionOptionsEN.QuestionOptionId == strQuestionOptionId)
{
return objQuestionOptionsEN;
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
 string strMaxQuestionOptionId;
 try
 {
 strMaxQuestionOptionId = clsQuestionOptionsDA.GetMaxStrId();
 return strMaxQuestionOptionId;
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
 string strQuestionOptionId;
 try
 {
 strQuestionOptionId = new clsQuestionOptionsDA().GetFirstID(strWhereCond);
 return strQuestionOptionId;
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
 arrList = QuestionOptionsDA.GetID(strWhereCond);
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
bool bolIsExist = QuestionOptionsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQuestionOptionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQuestionOptionId)
{
if (string.IsNullOrEmpty(strQuestionOptionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQuestionOptionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QuestionOptionsDA.IsExist(strQuestionOptionId);
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
 bolIsExist = clsQuestionOptionsDA.IsExistTable();
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
 bolIsExist = QuestionOptionsDA.IsExistTable(strTabName);
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
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQuestionOptionsEN objQuestionOptionsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionOptionsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目选项Id = [{0}]的数据已经存在!(in clsQuestionOptionsBL.AddNewRecordBySql2)", objQuestionOptionsEN.QuestionOptionId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionOptionsEN.QuestionOptionId) == true || clsQuestionOptionsBL.IsExist(objQuestionOptionsEN.QuestionOptionId) == true)
 {
     objQuestionOptionsEN.QuestionOptionId = clsQuestionOptionsBL.GetMaxStrId_S();
 }
bool bolResult = QuestionOptionsDA.AddNewRecordBySQL2(objQuestionOptionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
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
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQuestionOptionsEN objQuestionOptionsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionOptionsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目选项Id = [{0}]的数据已经存在!(in clsQuestionOptionsBL.AddNewRecordBySql2WithReturnKey)", objQuestionOptionsEN.QuestionOptionId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionOptionsEN.QuestionOptionId) == true || clsQuestionOptionsBL.IsExist(objQuestionOptionsEN.QuestionOptionId) == true)
 {
     objQuestionOptionsEN.QuestionOptionId = clsQuestionOptionsBL.GetMaxStrId_S();
 }
string strKey = QuestionOptionsDA.AddNewRecordBySQL2WithReturnKey(objQuestionOptionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
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
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQuestionOptionsEN objQuestionOptionsEN)
{
try
{
bool bolResult = QuestionOptionsDA.Update(objQuestionOptionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
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
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQuestionOptionsEN objQuestionOptionsEN)
{
 if (string.IsNullOrEmpty(objQuestionOptionsEN.QuestionOptionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QuestionOptionsDA.UpdateBySql2(objQuestionOptionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsBL.ReFreshCache(objQuestionOptionsEN.CourseId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
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
 /// <param name = "strQuestionOptionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strQuestionOptionId)
{
try
{
 clsQuestionOptionsEN objQuestionOptionsEN = clsQuestionOptionsBL.GetObjByQuestionOptionId(strQuestionOptionId);

if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(objQuestionOptionsEN.QuestionOptionId, objQuestionOptionsEN.UpdUser);
}
if (objQuestionOptionsEN != null)
{
int intRecNum = QuestionOptionsDA.DelRecord(strQuestionOptionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQuestionOptionsEN.CourseId);
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
/// <param name="strQuestionOptionId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strQuestionOptionId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionOptionsDA.GetSpecSQLObj();
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
//删除与表:[QuestionOptions]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQuestionOptions.QuestionOptionId,
//strQuestionOptionId);
//        clsQuestionOptionsBL.DelQuestionOptionssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionOptionsBL.DelRecord(strQuestionOptionId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionOptionsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQuestionOptionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strQuestionOptionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strQuestionOptionId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQuestionOptionsBL.relatedActions != null)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(strQuestionOptionId, "UpdRelaTabDate");
}
bool bolResult = QuestionOptionsDA.DelRecord(strQuestionOptionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrQuestionOptionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQuestionOptionss(List<string> arrQuestionOptionIdLst)
{
if (arrQuestionOptionIdLst.Count == 0) return 0;
try
{
if (clsQuestionOptionsBL.relatedActions != null)
{
foreach (var strQuestionOptionId in arrQuestionOptionIdLst)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(strQuestionOptionId, "UpdRelaTabDate");
}
}
 clsQuestionOptionsEN objQuestionOptionsEN = clsQuestionOptionsBL.GetObjByQuestionOptionId(arrQuestionOptionIdLst[0]);
int intDelRecNum = QuestionOptionsDA.DelQuestionOptions(arrQuestionOptionIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQuestionOptionsEN.CourseId);
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
public static int DelQuestionOptionssByCond(string strWhereCond)
{
try
{
if (clsQuestionOptionsBL.relatedActions != null)
{
List<string> arrQuestionOptionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strQuestionOptionId in arrQuestionOptionId)
{
clsQuestionOptionsBL.relatedActions.UpdRelaTabDate(strQuestionOptionId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conQuestionOptions.CourseId, strWhereCond);
int intRecNum = QuestionOptionsDA.DelQuestionOptions(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QuestionOptions]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strQuestionOptionId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strQuestionOptionId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionOptionsDA.GetSpecSQLObj();
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
//删除与表:[QuestionOptions]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionOptionsBL.DelRecord(strQuestionOptionId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionOptionsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQuestionOptionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQuestionOptionsENS">源对象</param>
 /// <param name = "objQuestionOptionsENT">目标对象</param>
 public static void CopyTo(clsQuestionOptionsEN objQuestionOptionsENS, clsQuestionOptionsEN objQuestionOptionsENT)
{
try
{
objQuestionOptionsENT.QuestionOptionId = objQuestionOptionsENS.QuestionOptionId; //题目选项Id
objQuestionOptionsENT.OptionName = objQuestionOptionsENS.OptionName; //选项名称
objQuestionOptionsENT.QuestionId = objQuestionOptionsENS.QuestionId; //题目Id
objQuestionOptionsENT.OptionIndex = objQuestionOptionsENS.OptionIndex; //选项序号
objQuestionOptionsENT.OptionTitle = objQuestionOptionsENS.OptionTitle; //选项标题
objQuestionOptionsENT.OptionContent = objQuestionOptionsENS.OptionContent; //选项内容
objQuestionOptionsENT.IsCorrect = objQuestionOptionsENS.IsCorrect; //是否正确
objQuestionOptionsENT.Score = objQuestionOptionsENS.Score; //得分
objQuestionOptionsENT.IsShow = objQuestionOptionsENS.IsShow; //是否启用
objQuestionOptionsENT.CourseId = objQuestionOptionsENS.CourseId; //课程Id
objQuestionOptionsENT.UpdDate = objQuestionOptionsENS.UpdDate; //修改日期
objQuestionOptionsENT.UpdUser = objQuestionOptionsENS.UpdUser; //修改人
objQuestionOptionsENT.Memo = objQuestionOptionsENS.Memo; //备注
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
 /// <param name = "objQuestionOptionsEN">源简化对象</param>
 public static void SetUpdFlag(clsQuestionOptionsEN objQuestionOptionsEN)
{
try
{
objQuestionOptionsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQuestionOptionsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQuestionOptions.QuestionOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.QuestionOptionId = objQuestionOptionsEN.QuestionOptionId; //题目选项Id
}
if (arrFldSet.Contains(conQuestionOptions.OptionName, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.OptionName = objQuestionOptionsEN.OptionName == "[null]" ? null :  objQuestionOptionsEN.OptionName; //选项名称
}
if (arrFldSet.Contains(conQuestionOptions.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.QuestionId = objQuestionOptionsEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conQuestionOptions.OptionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.OptionIndex = objQuestionOptionsEN.OptionIndex; //选项序号
}
if (arrFldSet.Contains(conQuestionOptions.OptionTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.OptionTitle = objQuestionOptionsEN.OptionTitle == "[null]" ? null :  objQuestionOptionsEN.OptionTitle; //选项标题
}
if (arrFldSet.Contains(conQuestionOptions.OptionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.OptionContent = objQuestionOptionsEN.OptionContent == "[null]" ? null :  objQuestionOptionsEN.OptionContent; //选项内容
}
if (arrFldSet.Contains(conQuestionOptions.IsCorrect, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.IsCorrect = objQuestionOptionsEN.IsCorrect; //是否正确
}
if (arrFldSet.Contains(conQuestionOptions.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.Score = objQuestionOptionsEN.Score; //得分
}
if (arrFldSet.Contains(conQuestionOptions.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.IsShow = objQuestionOptionsEN.IsShow; //是否启用
}
if (arrFldSet.Contains(conQuestionOptions.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.CourseId = objQuestionOptionsEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conQuestionOptions.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.UpdDate = objQuestionOptionsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQuestionOptions.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.UpdUser = objQuestionOptionsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conQuestionOptions.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionOptionsEN.Memo = objQuestionOptionsEN.Memo == "[null]" ? null :  objQuestionOptionsEN.Memo; //备注
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
 /// <param name = "objQuestionOptionsEN">源简化对象</param>
 public static void AccessFldValueNull(clsQuestionOptionsEN objQuestionOptionsEN)
{
try
{
if (objQuestionOptionsEN.OptionName == "[null]") objQuestionOptionsEN.OptionName = null; //选项名称
if (objQuestionOptionsEN.OptionTitle == "[null]") objQuestionOptionsEN.OptionTitle = null; //选项标题
if (objQuestionOptionsEN.OptionContent == "[null]") objQuestionOptionsEN.OptionContent = null; //选项内容
if (objQuestionOptionsEN.Memo == "[null]") objQuestionOptionsEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQuestionOptionsEN objQuestionOptionsEN)
{
 QuestionOptionsDA.CheckPropertyNew(objQuestionOptionsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQuestionOptionsEN objQuestionOptionsEN)
{
 QuestionOptionsDA.CheckProperty4Condition(objQuestionOptionsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindCbo_QuestionOptionId(System.Windows.Forms.ComboBox objComboBox , string strCourseId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQuestionOptions.QuestionOptionId); 
List<clsQuestionOptionsEN> arrObjLst = clsQuestionOptionsBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN()
{
QuestionOptionId = "0",
OptionName = "选[题目选项]..."
};
arrObjLstSel.Insert(0, objQuestionOptionsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQuestionOptions.QuestionOptionId;
objComboBox.DisplayMember = conQuestionOptions.OptionName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindDdl_QuestionOptionId(System.Web.UI.WebControls.DropDownList objDDL , string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目选项]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQuestionOptions.QuestionOptionId); 
IEnumerable<clsQuestionOptionsEN> arrObjLst = clsQuestionOptionsBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = conQuestionOptions.QuestionOptionId;
objDDL.DataTextField = conQuestionOptions.OptionName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionOptionIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目选项]...","0");
List<clsQuestionOptionsEN> arrQuestionOptionsObjLst = GetAllQuestionOptionsObjLstCache(strCourseId); 
arrQuestionOptionsObjLst = arrQuestionOptionsObjLst.OrderBy(x=>x.OptionIndex).ToList(); 
objDDL.DataValueField = conQuestionOptions.QuestionOptionId;
objDDL.DataTextField = conQuestionOptions.OptionName;
objDDL.DataSource = arrQuestionOptionsObjLst;
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
if (clsQuestionOptionsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionOptionsBL没有刷新缓存机制(clsQuestionOptionsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionOptionId");
//if (arrQuestionOptionsObjLstCache == null)
//{
//arrQuestionOptionsObjLstCache = QuestionOptionsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionOptionsEN GetObjByQuestionOptionIdCache(string strQuestionOptionId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName, strCourseId);
List<clsQuestionOptionsEN> arrQuestionOptionsObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionOptionsEN> arrQuestionOptionsObjLst_Sel =
arrQuestionOptionsObjLstCache
.Where(x=> x.QuestionOptionId == strQuestionOptionId 
);
if (arrQuestionOptionsObjLst_Sel.Count() == 0)
{
   clsQuestionOptionsEN obj = clsQuestionOptionsBL.GetObjByQuestionOptionId(strQuestionOptionId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strQuestionOptionId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrQuestionOptionsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetOptionNameByQuestionOptionIdCache(string strQuestionOptionId, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionOptionId) == true) return "";
//获取缓存中的对象列表
clsQuestionOptionsEN objQuestionOptions = GetObjByQuestionOptionIdCache(strQuestionOptionId, strCourseId);
if (objQuestionOptions == null) return "";
return objQuestionOptions.OptionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionOptionIdCache(string strQuestionOptionId, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionOptionId) == true) return "";
//获取缓存中的对象列表
clsQuestionOptionsEN objQuestionOptions = GetObjByQuestionOptionIdCache(strQuestionOptionId, strCourseId);
if (objQuestionOptions == null) return "";
return objQuestionOptions.OptionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionOptionsEN> GetAllQuestionOptionsObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsQuestionOptionsEN> arrQuestionOptionsObjLstCache = GetObjLstCache(strCourseId); 
return arrQuestionOptionsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionOptionsEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsQuestionOptionsEN> arrQuestionOptionsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrQuestionOptionsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsQuestionOptionsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQuestionOptionsEN._RefreshTimeLst.Count == 0) return "";
return clsQuestionOptionsEN._RefreshTimeLst[clsQuestionOptionsEN._RefreshTimeLst.Count - 1];
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
if (clsQuestionOptionsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsQuestionOptionsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQuestionOptionsBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QuestionOptions(题目选项)
 /// 唯一性条件:QuestionOptionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQuestionOptionsEN objQuestionOptionsEN)
{
//检测记录是否存在
string strResult = QuestionOptionsDA.GetUniCondStr(objQuestionOptionsEN);
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
public static string Func(string strInFldName, string strOutFldName, string strQuestionOptionId, string strCourseId)
{
if (strInFldName != conQuestionOptions.QuestionOptionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQuestionOptions.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQuestionOptions.AttributeName));
throw new Exception(strMsg);
}
var objQuestionOptions = clsQuestionOptionsBL.GetObjByQuestionOptionIdCache(strQuestionOptionId, strCourseId);
if (objQuestionOptions == null) return "";
return objQuestionOptions[strOutFldName].ToString();
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
int intRecCount = clsQuestionOptionsDA.GetRecCount(strTabName);
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
int intRecCount = clsQuestionOptionsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQuestionOptionsDA.GetRecCount();
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
int intRecCount = clsQuestionOptionsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQuestionOptionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQuestionOptionsEN objQuestionOptionsCond)
{
 string strCourseId = objQuestionOptionsCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsQuestionOptionsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsQuestionOptionsEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionOptionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionOptions.AttributeName)
{
if (objQuestionOptionsCond.IsUpdated(strFldName) == false) continue;
if (objQuestionOptionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionOptionsCond[strFldName].ToString());
}
else
{
if (objQuestionOptionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionOptionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionOptionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionOptionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionOptionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionOptionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionOptionsCond[strFldName]));
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
 List<string> arrList = clsQuestionOptionsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QuestionOptionsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QuestionOptionsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QuestionOptionsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionOptionsDA.SetFldValue(clsQuestionOptionsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QuestionOptionsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionOptionsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionOptionsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionOptionsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QuestionOptions] "); 
 strCreateTabCode.Append(" ( "); 
 // /**题目选项Id*/ 
 strCreateTabCode.Append(" QuestionOptionId char(8) primary key, "); 
 // /**选项名称*/ 
 strCreateTabCode.Append(" OptionName varchar(4000) Null, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint not Null, "); 
 // /**选项序号*/ 
 strCreateTabCode.Append(" OptionIndex int not Null, "); 
 // /**选项标题*/ 
 strCreateTabCode.Append(" OptionTitle varchar(20) Null, "); 
 // /**选项内容*/ 
 strCreateTabCode.Append(" OptionContent varchar(4000) Null, "); 
 // /**是否正确*/ 
 strCreateTabCode.Append(" IsCorrect bit Null, "); 
 // /**得分*/ 
 strCreateTabCode.Append(" Score decimal(6,1) Null, "); 
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
 strCreateTabCode.Append(" QuestionName varchar(500) Null ");
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
strCondition += string.Format(" And {0} = '{1}' ", conQuestionOptions.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by OptionIndex ");
List<clsQuestionOptionsEN> arrQuestionOptionsObjList = new clsQuestionOptionsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQuestionOptionsEN objQuestionOptions in arrQuestionOptionsObjList)
{
objQuestionOptions.OptionIndex = intIndex;
UpdateBySql2(objQuestionOptions);
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
/// <param name="strQuestionOptionId">所给的关键字</param>
/// <param name="lngQuestionId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strQuestionOptionId ,long lngQuestionId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[QuestionOptionId],获取相应的序号[OptionIndex]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字QuestionOptionId
//5、把当前关键字QuestionOptionId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字QuestionOptionId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevQuestionOptionId = "";    //上一条序号的关键字QuestionOptionId
string strNextQuestionOptionId = "";    //下一条序号的关键字QuestionOptionId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[QuestionOptionId],获取相应的序号[OptionIndex]。

clsQuestionOptionsEN objQuestionOptions = clsQuestionOptionsBL.GetObjByQuestionOptionId(strQuestionOptionId);

intOrderNum = objQuestionOptions.OptionIndex;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQuestionOptions.QuestionId, lngQuestionId);
intTabRecNum = clsQuestionOptionsBL.GetRecCountByCond(clsQuestionOptionsEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conQuestionOptions.OptionIndex, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conQuestionOptions.QuestionId, lngQuestionId);
//4、获取上一个序号字段的关键字QuestionOptionId
strPrevQuestionOptionId = clsQuestionOptionsBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevQuestionOptionId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字QuestionOptionId所对应记录的序号减1
//6、把下(上)一个序号关键字QuestionOptionId所对应的记录序号加1
clsQuestionOptionsBL.SetFldValue(clsQuestionOptionsEN._CurrTabName, conQuestionOptions.OptionIndex,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conQuestionOptions.QuestionOptionId, strQuestionOptionId));
clsQuestionOptionsBL.SetFldValue(clsQuestionOptionsEN._CurrTabName, conQuestionOptions.OptionIndex,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conQuestionOptions.QuestionOptionId, strPrevQuestionOptionId));
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

//4、获取下一个序号字段的关键字QuestionOptionId
sbCondition.AppendFormat(" {0} = {1} ", conQuestionOptions.OptionIndex, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conQuestionOptions.QuestionId, lngQuestionId);

strNextQuestionOptionId = clsQuestionOptionsBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextQuestionOptionId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字QuestionOptionId所对应记录的序号加1
//6、把下(上)一个序号关键字QuestionOptionId所对应的记录序号减1
clsQuestionOptionsBL.SetFldValue(clsQuestionOptionsEN._CurrTabName, conQuestionOptions.OptionIndex,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conQuestionOptions.QuestionOptionId, strQuestionOptionId));
clsQuestionOptionsBL.SetFldValue(clsQuestionOptionsEN._CurrTabName, conQuestionOptions.OptionIndex,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conQuestionOptions.QuestionOptionId, strNextQuestionOptionId));
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
public static bool GoBottom(List<string> arrKeyId ,long lngQuestionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conQuestionOptions.QuestionOptionId, strKeyList);
List<clsQuestionOptionsEN> arrQuestionOptionsLst = GetObjLst(strCondition);
foreach (clsQuestionOptionsEN objQuestionOptions in arrQuestionOptionsLst)
{
objQuestionOptions.OptionIndex = objQuestionOptions.OptionIndex + 10000;
UpdateBySql2(objQuestionOptions);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQuestionOptions.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by OptionIndex ");
List<clsQuestionOptionsEN> arrQuestionOptionsObjList = new clsQuestionOptionsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQuestionOptionsEN objQuestionOptions in arrQuestionOptionsObjList)
{
objQuestionOptions.OptionIndex = intIndex;
UpdateBySql2(objQuestionOptions);
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
public static bool GoTop(List<string> arrKeyId ,long lngQuestionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conQuestionOptions.QuestionOptionId, strKeyList);
List<clsQuestionOptionsEN> arrQuestionOptionsLst = GetObjLst(strCondition);
foreach (clsQuestionOptionsEN objQuestionOptions in arrQuestionOptionsLst)
{
objQuestionOptions.OptionIndex = objQuestionOptions.OptionIndex - 10000;
UpdateBySql2(objQuestionOptions);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQuestionOptions.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by OptionIndex ");
List<clsQuestionOptionsEN> arrQuestionOptionsObjList = new clsQuestionOptionsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQuestionOptionsEN objQuestionOptions in arrQuestionOptionsObjList)
{
objQuestionOptions.OptionIndex = intIndex;
UpdateBySql2(objQuestionOptions);
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
 /// 题目选项(QuestionOptions)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QuestionOptions : clsCommFun4BLV2
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
clsQuestionOptionsBL.ReFreshThisCache(strCourseId);
}
}

}