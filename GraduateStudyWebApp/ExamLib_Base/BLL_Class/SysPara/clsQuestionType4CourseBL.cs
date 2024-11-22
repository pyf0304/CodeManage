﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionType4CourseBL
 表名:QuestionType4Course(01120339)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsQuestionType4CourseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionType4CourseEN GetObj(this K_QuestionTypeId4Course_QuestionType4Course myKey)
{
clsQuestionType4CourseEN objQuestionType4CourseEN = clsQuestionType4CourseBL.QuestionType4CourseDA.GetObjByQuestionTypeId4Course(myKey.Value);
return objQuestionType4CourseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionType4CourseEN objQuestionType4CourseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionType4CourseEN) == false)
{
var strMsg = string.Format("记录已经存在!题目类型名4课程 = [{0}],课程Id = [{1}]的数据已经存在!(in clsQuestionType4CourseBL.AddNewRecord)", objQuestionType4CourseEN.QuestionTypeName4Course,objQuestionType4CourseEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionType4CourseEN.QuestionTypeId4Course) == true || clsQuestionType4CourseBL.IsExist(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
     objQuestionType4CourseEN.QuestionTypeId4Course = clsQuestionType4CourseBL.GetMaxStrId_S();
 }
bool bolResult = clsQuestionType4CourseBL.QuestionType4CourseDA.AddNewRecordBySQL2(objQuestionType4CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
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
public static bool AddRecordEx(this clsQuestionType4CourseEN objQuestionType4CourseEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsQuestionType4CourseBL.IsExist(objQuestionType4CourseEN.QuestionTypeId4Course))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objQuestionType4CourseEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objQuestionType4CourseEN.CheckUniqueness() == false)
{
strMsg = string.Format("(题目类型名4课程(QuestionTypeName4Course)=[{0}],课程Id(CourseId)=[{1}])已经存在,不能重复!", objQuestionType4CourseEN.QuestionTypeName4Course, objQuestionType4CourseEN.CourseId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objQuestionType4CourseEN.QuestionTypeId4Course) == true || clsQuestionType4CourseBL.IsExist(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
     objQuestionType4CourseEN.QuestionTypeId4Course = clsQuestionType4CourseBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objQuestionType4CourseEN.AddNewRecord();
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionType4CourseEN objQuestionType4CourseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionType4CourseEN) == false)
{
var strMsg = string.Format("记录已经存在!题目类型名4课程 = [{0}],课程Id = [{1}]的数据已经存在!(in clsQuestionType4CourseBL.AddNewRecordWithMaxId)", objQuestionType4CourseEN.QuestionTypeName4Course,objQuestionType4CourseEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionType4CourseEN.QuestionTypeId4Course) == true || clsQuestionType4CourseBL.IsExist(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
     objQuestionType4CourseEN.QuestionTypeId4Course = clsQuestionType4CourseBL.GetMaxStrId_S();
 }
string strQuestionTypeId4Course = clsQuestionType4CourseBL.QuestionType4CourseDA.AddNewRecordBySQL2WithReturnKey(objQuestionType4CourseEN);
     objQuestionType4CourseEN.QuestionTypeId4Course = strQuestionTypeId4Course;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
}
return strQuestionTypeId4Course;
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQuestionType4CourseEN objQuestionType4CourseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionType4CourseEN) == false)
{
var strMsg = string.Format("记录已经存在!题目类型名4课程 = [{0}],课程Id = [{1}]的数据已经存在!(in clsQuestionType4CourseBL.AddNewRecordWithReturnKey)", objQuestionType4CourseEN.QuestionTypeName4Course,objQuestionType4CourseEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionType4CourseEN.QuestionTypeId4Course) == true || clsQuestionType4CourseBL.IsExist(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
     objQuestionType4CourseEN.QuestionTypeId4Course = clsQuestionType4CourseBL.GetMaxStrId_S();
 }
string strKey = clsQuestionType4CourseBL.QuestionType4CourseDA.AddNewRecordBySQL2WithReturnKey(objQuestionType4CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
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
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionType4CourseEN SetQuestionTypeId4Course(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, conQuestionType4Course.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, conQuestionType4Course.QuestionTypeId4Course);
}
objQuestionType4CourseEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.QuestionTypeId4Course) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.QuestionTypeId4Course, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.QuestionTypeId4Course] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionType4CourseEN SetQuestionTypeName4Course(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strQuestionTypeName4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeName4Course, conQuestionType4Course.QuestionTypeName4Course);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName4Course, 30, conQuestionType4Course.QuestionTypeName4Course);
}
objQuestionType4CourseEN.QuestionTypeName4Course = strQuestionTypeName4Course; //题目类型名4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.QuestionTypeName4Course) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.QuestionTypeName4Course, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.QuestionTypeName4Course] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionType4CourseEN SetCourseId(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conQuestionType4Course.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conQuestionType4Course.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conQuestionType4Course.CourseId);
}
objQuestionType4CourseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.CourseId) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.CourseId, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.CourseId] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionType4CourseEN SetOrderNum(this clsQuestionType4CourseEN objQuestionType4CourseEN, int? intOrderNum, string strComparisonOp="")
	{
objQuestionType4CourseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.OrderNum) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.OrderNum, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.OrderNum] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionType4CourseEN SetIsUse(this clsQuestionType4CourseEN objQuestionType4CourseEN, bool bolIsUse, string strComparisonOp="")
	{
objQuestionType4CourseEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.IsUse) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.IsUse, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.IsUse] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionType4CourseEN SetUpdDate(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionType4Course.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionType4Course.UpdDate);
}
objQuestionType4CourseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.UpdDate) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.UpdDate, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.UpdDate] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionType4CourseEN SetUpdUser(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionType4Course.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionType4Course.UpdUser);
}
objQuestionType4CourseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.UpdUser) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.UpdUser, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.UpdUser] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionType4CourseEN SetMemo(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionType4Course.Memo);
}
objQuestionType4CourseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.Memo) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.Memo, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.Memo] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQuestionType4CourseEN objQuestionType4CourseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQuestionType4CourseEN.CheckPropertyNew();
clsQuestionType4CourseEN objQuestionType4CourseCond = new clsQuestionType4CourseEN();
string strCondition = objQuestionType4CourseCond
.SetQuestionTypeId4Course(objQuestionType4CourseEN.QuestionTypeId4Course, "<>")
.SetQuestionTypeName4Course(objQuestionType4CourseEN.QuestionTypeName4Course, "=")
.SetCourseId(objQuestionType4CourseEN.CourseId, "=")
.GetCombineCondition();
objQuestionType4CourseEN._IsCheckProperty = true;
bool bolIsExist = clsQuestionType4CourseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionTypeName4Course_CourseId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQuestionType4CourseEN.Update();
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
 /// <param name = "objQuestionType4Course">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQuestionType4CourseEN objQuestionType4Course)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQuestionType4CourseEN objQuestionType4CourseCond = new clsQuestionType4CourseEN();
string strCondition = objQuestionType4CourseCond
.SetQuestionTypeName4Course(objQuestionType4Course.QuestionTypeName4Course, "=")
.SetCourseId(objQuestionType4Course.CourseId, "=")
.GetCombineCondition();
objQuestionType4Course._IsCheckProperty = true;
bool bolIsExist = clsQuestionType4CourseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQuestionType4Course.QuestionTypeId4Course = clsQuestionType4CourseBL.GetFirstID_S(strCondition);
objQuestionType4Course.UpdateWithCondition(strCondition);
}
else
{
objQuestionType4Course.QuestionTypeId4Course = clsQuestionType4CourseBL.GetMaxStrId_S();
objQuestionType4Course.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 if (string.IsNullOrEmpty(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionType4CourseBL.QuestionType4CourseDA.UpdateBySql2(objQuestionType4CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionType4CourseEN objQuestionType4CourseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionType4CourseBL.QuestionType4CourseDA.UpdateBySql2(objQuestionType4CourseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
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
 /// <param name = "objQuestionType4CourseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strWhereCond)
{
try
{
bool bolResult = clsQuestionType4CourseBL.QuestionType4CourseDA.UpdateBySqlWithCondition(objQuestionType4CourseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
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
 /// <param name = "objQuestionType4CourseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQuestionType4CourseBL.QuestionType4CourseDA.UpdateBySqlWithConditionTransaction(objQuestionType4CourseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
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
 /// <param name = "strQuestionTypeId4Course">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQuestionType4CourseEN objQuestionType4CourseEN)
{
try
{
int intRecNum = clsQuestionType4CourseBL.QuestionType4CourseDA.DelRecord(objQuestionType4CourseEN.QuestionTypeId4Course);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
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
 /// <param name = "objQuestionType4CourseENS">源对象</param>
 /// <param name = "objQuestionType4CourseENT">目标对象</param>
 public static void CopyTo(this clsQuestionType4CourseEN objQuestionType4CourseENS, clsQuestionType4CourseEN objQuestionType4CourseENT)
{
try
{
objQuestionType4CourseENT.QuestionTypeId4Course = objQuestionType4CourseENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionType4CourseENT.QuestionTypeName4Course = objQuestionType4CourseENS.QuestionTypeName4Course; //题目类型名4课程
objQuestionType4CourseENT.CourseId = objQuestionType4CourseENS.CourseId; //课程Id
objQuestionType4CourseENT.OrderNum = objQuestionType4CourseENS.OrderNum; //序号
objQuestionType4CourseENT.IsUse = objQuestionType4CourseENS.IsUse; //是否使用
objQuestionType4CourseENT.UpdDate = objQuestionType4CourseENS.UpdDate; //修改日期
objQuestionType4CourseENT.UpdUser = objQuestionType4CourseENS.UpdUser; //修改人
objQuestionType4CourseENT.Memo = objQuestionType4CourseENS.Memo; //备注
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
 /// <param name = "objQuestionType4CourseENS">源对象</param>
 /// <returns>目标对象=>clsQuestionType4CourseEN:objQuestionType4CourseENT</returns>
 public static clsQuestionType4CourseEN CopyTo(this clsQuestionType4CourseEN objQuestionType4CourseENS)
{
try
{
 clsQuestionType4CourseEN objQuestionType4CourseENT = new clsQuestionType4CourseEN()
{
QuestionTypeId4Course = objQuestionType4CourseENS.QuestionTypeId4Course, //题目类型Id4课程
QuestionTypeName4Course = objQuestionType4CourseENS.QuestionTypeName4Course, //题目类型名4课程
CourseId = objQuestionType4CourseENS.CourseId, //课程Id
OrderNum = objQuestionType4CourseENS.OrderNum, //序号
IsUse = objQuestionType4CourseENS.IsUse, //是否使用
UpdDate = objQuestionType4CourseENS.UpdDate, //修改日期
UpdUser = objQuestionType4CourseENS.UpdUser, //修改人
Memo = objQuestionType4CourseENS.Memo, //备注
};
 return objQuestionType4CourseENT;
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
public static void CheckPropertyNew(this clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 clsQuestionType4CourseBL.QuestionType4CourseDA.CheckPropertyNew(objQuestionType4CourseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 clsQuestionType4CourseBL.QuestionType4CourseDA.CheckProperty4Condition(objQuestionType4CourseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionType4CourseEN objQuestionType4CourseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionType4CourseCond.IsUpdated(conQuestionType4Course.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objQuestionType4CourseCond.dicFldComparisonOp[conQuestionType4Course.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.QuestionTypeId4Course, objQuestionType4CourseCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
if (objQuestionType4CourseCond.IsUpdated(conQuestionType4Course.QuestionTypeName4Course) == true)
{
string strComparisonOpQuestionTypeName4Course = objQuestionType4CourseCond.dicFldComparisonOp[conQuestionType4Course.QuestionTypeName4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.QuestionTypeName4Course, objQuestionType4CourseCond.QuestionTypeName4Course, strComparisonOpQuestionTypeName4Course);
}
if (objQuestionType4CourseCond.IsUpdated(conQuestionType4Course.CourseId) == true)
{
string strComparisonOpCourseId = objQuestionType4CourseCond.dicFldComparisonOp[conQuestionType4Course.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.CourseId, objQuestionType4CourseCond.CourseId, strComparisonOpCourseId);
}
if (objQuestionType4CourseCond.IsUpdated(conQuestionType4Course.OrderNum) == true)
{
string strComparisonOpOrderNum = objQuestionType4CourseCond.dicFldComparisonOp[conQuestionType4Course.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionType4Course.OrderNum, objQuestionType4CourseCond.OrderNum, strComparisonOpOrderNum);
}
if (objQuestionType4CourseCond.IsUpdated(conQuestionType4Course.IsUse) == true)
{
if (objQuestionType4CourseCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionType4Course.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionType4Course.IsUse);
}
}
if (objQuestionType4CourseCond.IsUpdated(conQuestionType4Course.UpdDate) == true)
{
string strComparisonOpUpdDate = objQuestionType4CourseCond.dicFldComparisonOp[conQuestionType4Course.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.UpdDate, objQuestionType4CourseCond.UpdDate, strComparisonOpUpdDate);
}
if (objQuestionType4CourseCond.IsUpdated(conQuestionType4Course.UpdUser) == true)
{
string strComparisonOpUpdUser = objQuestionType4CourseCond.dicFldComparisonOp[conQuestionType4Course.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.UpdUser, objQuestionType4CourseCond.UpdUser, strComparisonOpUpdUser);
}
if (objQuestionType4CourseCond.IsUpdated(conQuestionType4Course.Memo) == true)
{
string strComparisonOpMemo = objQuestionType4CourseCond.dicFldComparisonOp[conQuestionType4Course.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.Memo, objQuestionType4CourseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QuestionType4Course(题目类型4课程), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionTypeName4Course_CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQuestionType4CourseEN objQuestionType4CourseEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQuestionType4CourseEN == null) return true;
if (objQuestionType4CourseEN.QuestionTypeId4Course == null || objQuestionType4CourseEN.QuestionTypeId4Course == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionTypeName4Course = '{0}'", objQuestionType4CourseEN.QuestionTypeName4Course);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objQuestionType4CourseEN.CourseId);
if (clsQuestionType4CourseBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("QuestionTypeId4Course !=  '{0}'", objQuestionType4CourseEN.QuestionTypeId4Course);
 sbCondition.AppendFormat(" and QuestionTypeName4Course = '{0}'", objQuestionType4CourseEN.QuestionTypeName4Course);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objQuestionType4CourseEN.CourseId);
if (clsQuestionType4CourseBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QuestionType4Course(题目类型4课程), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionTypeName4Course_CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQuestionType4CourseEN objQuestionType4CourseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQuestionType4CourseEN == null) return "";
if (objQuestionType4CourseEN.QuestionTypeId4Course == null || objQuestionType4CourseEN.QuestionTypeId4Course == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionTypeName4Course = '{0}'", objQuestionType4CourseEN.QuestionTypeName4Course);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objQuestionType4CourseEN.CourseId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QuestionTypeId4Course !=  '{0}'", objQuestionType4CourseEN.QuestionTypeId4Course);
 sbCondition.AppendFormat(" and QuestionTypeName4Course = '{0}'", objQuestionType4CourseEN.QuestionTypeName4Course);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objQuestionType4CourseEN.CourseId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QuestionType4Course
{
public virtual bool UpdRelaTabDate(string strQuestionTypeId4Course, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 题目类型4课程(QuestionType4Course)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQuestionType4CourseBL
{
public static RelatedActions_QuestionType4Course relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQuestionType4CourseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQuestionType4CourseDA QuestionType4CourseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQuestionType4CourseDA();
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
 public clsQuestionType4CourseBL()
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
if (string.IsNullOrEmpty(clsQuestionType4CourseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionType4CourseEN._ConnectString);
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
public static DataTable GetDataTable_QuestionType4Course(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QuestionType4CourseDA.GetDataTable_QuestionType4Course(strWhereCond);
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
objDT = QuestionType4CourseDA.GetDataTable(strWhereCond);
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
objDT = QuestionType4CourseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QuestionType4CourseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QuestionType4CourseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QuestionType4CourseDA.GetDataTable_Top(objTopPara);
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
objDT = QuestionType4CourseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QuestionType4CourseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QuestionType4CourseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionTypeId4CourseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQuestionType4CourseEN> GetObjLstByQuestionTypeId4CourseLst(List<string> arrQuestionTypeId4CourseLst)
{
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionTypeId4CourseLst, true);
 string strWhereCond = string.Format("QuestionTypeId4Course in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionType4CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionTypeId4CourseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQuestionType4CourseEN> GetObjLstByQuestionTypeId4CourseLstCache(List<string> arrQuestionTypeId4CourseLst)
{
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName);
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Sel =
arrQuestionType4CourseObjLstCache
.Where(x => arrQuestionTypeId4CourseLst.Contains(x.QuestionTypeId4Course));
return arrQuestionType4CourseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionType4CourseEN> GetObjLst(string strWhereCond)
{
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionType4CourseEN);
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
public static List<clsQuestionType4CourseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionType4CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQuestionType4CourseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQuestionType4CourseEN> GetSubObjLstCache(clsQuestionType4CourseEN objQuestionType4CourseCond)
{
List<clsQuestionType4CourseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionType4CourseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionType4Course.AttributeName)
{
if (objQuestionType4CourseCond.IsUpdated(strFldName) == false) continue;
if (objQuestionType4CourseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionType4CourseCond[strFldName].ToString());
}
else
{
if (objQuestionType4CourseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionType4CourseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionType4CourseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionType4CourseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionType4CourseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionType4CourseCond[strFldName]));
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
public static List<clsQuestionType4CourseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionType4CourseEN);
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
public static List<clsQuestionType4CourseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionType4CourseEN);
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
List<clsQuestionType4CourseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQuestionType4CourseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionType4CourseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQuestionType4CourseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
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
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionType4CourseEN);
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
public static List<clsQuestionType4CourseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionType4CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQuestionType4CourseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQuestionType4CourseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionType4CourseEN);
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
public static List<clsQuestionType4CourseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionType4CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionType4CourseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionType4CourseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQuestionType4Course(ref clsQuestionType4CourseEN objQuestionType4CourseEN)
{
bool bolResult = QuestionType4CourseDA.GetQuestionType4Course(ref objQuestionType4CourseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionType4CourseEN GetObjByQuestionTypeId4Course(string strQuestionTypeId4Course)
{
if (strQuestionTypeId4Course.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQuestionTypeId4Course]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQuestionTypeId4Course]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQuestionType4CourseEN objQuestionType4CourseEN = QuestionType4CourseDA.GetObjByQuestionTypeId4Course(strQuestionTypeId4Course);
return objQuestionType4CourseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQuestionType4CourseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQuestionType4CourseEN objQuestionType4CourseEN = QuestionType4CourseDA.GetFirstObj(strWhereCond);
 return objQuestionType4CourseEN;
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
public static clsQuestionType4CourseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQuestionType4CourseEN objQuestionType4CourseEN = QuestionType4CourseDA.GetObjByDataRow(objRow);
 return objQuestionType4CourseEN;
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
public static clsQuestionType4CourseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQuestionType4CourseEN objQuestionType4CourseEN = QuestionType4CourseDA.GetObjByDataRow(objRow);
 return objQuestionType4CourseEN;
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
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <param name = "lstQuestionType4CourseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionType4CourseEN GetObjByQuestionTypeId4CourseFromList(string strQuestionTypeId4Course, List<clsQuestionType4CourseEN> lstQuestionType4CourseObjLst)
{
foreach (clsQuestionType4CourseEN objQuestionType4CourseEN in lstQuestionType4CourseObjLst)
{
if (objQuestionType4CourseEN.QuestionTypeId4Course == strQuestionTypeId4Course)
{
return objQuestionType4CourseEN;
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
 string strMaxQuestionTypeId4Course;
 try
 {
 strMaxQuestionTypeId4Course = clsQuestionType4CourseDA.GetMaxStrId();
 return strMaxQuestionTypeId4Course;
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
 string strQuestionTypeId4Course;
 try
 {
 strQuestionTypeId4Course = new clsQuestionType4CourseDA().GetFirstID(strWhereCond);
 return strQuestionTypeId4Course;
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
 arrList = QuestionType4CourseDA.GetID(strWhereCond);
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
bool bolIsExist = QuestionType4CourseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQuestionTypeId4Course]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QuestionType4CourseDA.IsExist(strQuestionTypeId4Course);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strQuestionTypeId4Course">题目类型Id4课程</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strQuestionTypeId4Course, string strOpUser)
{
clsQuestionType4CourseEN objQuestionType4CourseEN = clsQuestionType4CourseBL.GetObjByQuestionTypeId4Course(strQuestionTypeId4Course);
objQuestionType4CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQuestionType4CourseEN.UpdUser = strOpUser;
return clsQuestionType4CourseBL.UpdateBySql2(objQuestionType4CourseEN);
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
 bolIsExist = clsQuestionType4CourseDA.IsExistTable();
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
 bolIsExist = QuestionType4CourseDA.IsExistTable(strTabName);
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQuestionType4CourseEN objQuestionType4CourseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionType4CourseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目类型名4课程 = [{0}],课程Id = [{1}]的数据已经存在!(in clsQuestionType4CourseBL.AddNewRecordBySql2)", objQuestionType4CourseEN.QuestionTypeName4Course,objQuestionType4CourseEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionType4CourseEN.QuestionTypeId4Course) == true || clsQuestionType4CourseBL.IsExist(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
     objQuestionType4CourseEN.QuestionTypeId4Course = clsQuestionType4CourseBL.GetMaxStrId_S();
 }
bool bolResult = QuestionType4CourseDA.AddNewRecordBySQL2(objQuestionType4CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQuestionType4CourseEN objQuestionType4CourseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionType4CourseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目类型名4课程 = [{0}],课程Id = [{1}]的数据已经存在!(in clsQuestionType4CourseBL.AddNewRecordBySql2WithReturnKey)", objQuestionType4CourseEN.QuestionTypeName4Course,objQuestionType4CourseEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionType4CourseEN.QuestionTypeId4Course) == true || clsQuestionType4CourseBL.IsExist(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
     objQuestionType4CourseEN.QuestionTypeId4Course = clsQuestionType4CourseBL.GetMaxStrId_S();
 }
string strKey = QuestionType4CourseDA.AddNewRecordBySQL2WithReturnKey(objQuestionType4CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
try
{
bool bolResult = QuestionType4CourseDA.Update(objQuestionType4CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 if (string.IsNullOrEmpty(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QuestionType4CourseDA.UpdateBySql2(objQuestionType4CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseBL.ReFreshCache();

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
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
 /// <param name = "strQuestionTypeId4Course">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strQuestionTypeId4Course)
{
try
{
 clsQuestionType4CourseEN objQuestionType4CourseEN = clsQuestionType4CourseBL.GetObjByQuestionTypeId4Course(strQuestionTypeId4Course);

if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4CourseEN.QuestionTypeId4Course, objQuestionType4CourseEN.UpdUser);
}
if (objQuestionType4CourseEN != null)
{
int intRecNum = QuestionType4CourseDA.DelRecord(strQuestionTypeId4Course);
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
/// <param name="strQuestionTypeId4Course">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strQuestionTypeId4Course )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
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
//删除与表:[QuestionType4Course]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQuestionType4Course.QuestionTypeId4Course,
//strQuestionTypeId4Course);
//        clsQuestionType4CourseBL.DelQuestionType4CoursesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionType4CourseBL.DelRecord(strQuestionTypeId4Course, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionType4CourseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQuestionTypeId4Course, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strQuestionTypeId4Course">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strQuestionTypeId4Course, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(strQuestionTypeId4Course, "UpdRelaTabDate");
}
bool bolResult = QuestionType4CourseDA.DelRecord(strQuestionTypeId4Course,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrQuestionTypeId4CourseLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQuestionType4Courses(List<string> arrQuestionTypeId4CourseLst)
{
if (arrQuestionTypeId4CourseLst.Count == 0) return 0;
try
{
if (clsQuestionType4CourseBL.relatedActions != null)
{
foreach (var strQuestionTypeId4Course in arrQuestionTypeId4CourseLst)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(strQuestionTypeId4Course, "UpdRelaTabDate");
}
}
int intDelRecNum = QuestionType4CourseDA.DelQuestionType4Course(arrQuestionTypeId4CourseLst);
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
public static int DelQuestionType4CoursesByCond(string strWhereCond)
{
try
{
if (clsQuestionType4CourseBL.relatedActions != null)
{
List<string> arrQuestionTypeId4Course = GetPrimaryKeyID_S(strWhereCond);
foreach (var strQuestionTypeId4Course in arrQuestionTypeId4Course)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(strQuestionTypeId4Course, "UpdRelaTabDate");
}
}
int intRecNum = QuestionType4CourseDA.DelQuestionType4Course(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QuestionType4Course]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strQuestionTypeId4Course">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strQuestionTypeId4Course)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
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
//删除与表:[QuestionType4Course]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionType4CourseBL.DelRecord(strQuestionTypeId4Course, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionType4CourseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQuestionTypeId4Course, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQuestionType4CourseENS">源对象</param>
 /// <param name = "objQuestionType4CourseENT">目标对象</param>
 public static void CopyTo(clsQuestionType4CourseEN objQuestionType4CourseENS, clsQuestionType4CourseEN objQuestionType4CourseENT)
{
try
{
objQuestionType4CourseENT.QuestionTypeId4Course = objQuestionType4CourseENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionType4CourseENT.QuestionTypeName4Course = objQuestionType4CourseENS.QuestionTypeName4Course; //题目类型名4课程
objQuestionType4CourseENT.CourseId = objQuestionType4CourseENS.CourseId; //课程Id
objQuestionType4CourseENT.OrderNum = objQuestionType4CourseENS.OrderNum; //序号
objQuestionType4CourseENT.IsUse = objQuestionType4CourseENS.IsUse; //是否使用
objQuestionType4CourseENT.UpdDate = objQuestionType4CourseENS.UpdDate; //修改日期
objQuestionType4CourseENT.UpdUser = objQuestionType4CourseENS.UpdUser; //修改人
objQuestionType4CourseENT.Memo = objQuestionType4CourseENS.Memo; //备注
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
 /// <param name = "objQuestionType4CourseEN">源简化对象</param>
 public static void SetUpdFlag(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
try
{
objQuestionType4CourseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQuestionType4CourseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQuestionType4Course.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionType4CourseEN.QuestionTypeId4Course = objQuestionType4CourseEN.QuestionTypeId4Course; //题目类型Id4课程
}
if (arrFldSet.Contains(conQuestionType4Course.QuestionTypeName4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionType4CourseEN.QuestionTypeName4Course = objQuestionType4CourseEN.QuestionTypeName4Course; //题目类型名4课程
}
if (arrFldSet.Contains(conQuestionType4Course.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionType4CourseEN.CourseId = objQuestionType4CourseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conQuestionType4Course.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionType4CourseEN.OrderNum = objQuestionType4CourseEN.OrderNum; //序号
}
if (arrFldSet.Contains(conQuestionType4Course.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionType4CourseEN.IsUse = objQuestionType4CourseEN.IsUse; //是否使用
}
if (arrFldSet.Contains(conQuestionType4Course.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionType4CourseEN.UpdDate = objQuestionType4CourseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQuestionType4Course.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionType4CourseEN.UpdUser = objQuestionType4CourseEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conQuestionType4Course.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionType4CourseEN.Memo = objQuestionType4CourseEN.Memo == "[null]" ? null :  objQuestionType4CourseEN.Memo; //备注
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
 /// <param name = "objQuestionType4CourseEN">源简化对象</param>
 public static void AccessFldValueNull(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
try
{
if (objQuestionType4CourseEN.Memo == "[null]") objQuestionType4CourseEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 QuestionType4CourseDA.CheckPropertyNew(objQuestionType4CourseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 QuestionType4CourseDA.CheckProperty4Condition(objQuestionType4CourseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_QuestionTypeId4Course(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQuestionType4Course.QuestionTypeId4Course); 
List<clsQuestionType4CourseEN> arrObjLst = clsQuestionType4CourseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN()
{
QuestionTypeId4Course = "0",
QuestionTypeName4Course = "选[题目类型4课程]..."
};
arrObjLst.Insert(0, objQuestionType4CourseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQuestionType4Course.QuestionTypeId4Course;
objComboBox.DisplayMember = conQuestionType4Course.QuestionTypeName4Course;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_QuestionTypeId4Course(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目类型4课程]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQuestionType4Course.QuestionTypeId4Course); 
IEnumerable<clsQuestionType4CourseEN> arrObjLst = clsQuestionType4CourseBL.GetObjLst(strCondition);
objDDL.DataValueField = conQuestionType4Course.QuestionTypeId4Course;
objDDL.DataTextField = conQuestionType4Course.QuestionTypeName4Course;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionTypeId4CourseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目类型4课程]...","0");
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjLst = GetAllQuestionType4CourseObjLstCache(); 
arrQuestionType4CourseObjLst = arrQuestionType4CourseObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conQuestionType4Course.QuestionTypeId4Course;
objDDL.DataTextField = conQuestionType4Course.QuestionTypeName4Course;
objDDL.DataSource = arrQuestionType4CourseObjLst;
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
if (clsQuestionType4CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseBL没有刷新缓存机制(clsQuestionType4CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionTypeId4Course");
//if (arrQuestionType4CourseObjLstCache == null)
//{
//arrQuestionType4CourseObjLstCache = QuestionType4CourseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionType4CourseEN GetObjByQuestionTypeId4CourseCache(string strQuestionTypeId4Course)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName);
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Sel =
arrQuestionType4CourseObjLstCache
.Where(x=> x.QuestionTypeId4Course == strQuestionTypeId4Course 
);
if (arrQuestionType4CourseObjLst_Sel.Count() == 0)
{
   clsQuestionType4CourseEN obj = clsQuestionType4CourseBL.GetObjByQuestionTypeId4Course(strQuestionTypeId4Course);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQuestionType4CourseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionTypeName4CourseByQuestionTypeId4CourseCache(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true) return "";
//获取缓存中的对象列表
clsQuestionType4CourseEN objQuestionType4Course = GetObjByQuestionTypeId4CourseCache(strQuestionTypeId4Course);
if (objQuestionType4Course == null) return "";
return objQuestionType4Course.QuestionTypeName4Course;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionTypeId4CourseCache(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true) return "";
//获取缓存中的对象列表
clsQuestionType4CourseEN objQuestionType4Course = GetObjByQuestionTypeId4CourseCache(strQuestionTypeId4Course);
if (objQuestionType4Course == null) return "";
return objQuestionType4Course.QuestionTypeName4Course;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionType4CourseEN> GetAllQuestionType4CourseObjLstCache()
{
//获取缓存中的对象列表
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjLstCache = GetObjLstCache(); 
return arrQuestionType4CourseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionType4CourseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName);
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQuestionType4CourseObjLstCache;
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
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQuestionType4CourseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQuestionType4CourseEN._RefreshTimeLst.Count == 0) return "";
return clsQuestionType4CourseEN._RefreshTimeLst[clsQuestionType4CourseEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQuestionType4CourseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQuestionType4CourseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQuestionType4CourseBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QuestionType4Course(题目类型4课程)
 /// 唯一性条件:QuestionTypeName4Course_CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
//检测记录是否存在
string strResult = QuestionType4CourseDA.GetUniCondStr(objQuestionType4CourseEN);
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
public static string Func(string strInFldName, string strOutFldName, string strQuestionTypeId4Course)
{
if (strInFldName != conQuestionType4Course.QuestionTypeId4Course)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQuestionType4Course.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQuestionType4Course.AttributeName));
throw new Exception(strMsg);
}
var objQuestionType4Course = clsQuestionType4CourseBL.GetObjByQuestionTypeId4CourseCache(strQuestionTypeId4Course);
if (objQuestionType4Course == null) return "";
return objQuestionType4Course[strOutFldName].ToString();
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
int intRecCount = clsQuestionType4CourseDA.GetRecCount(strTabName);
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
int intRecCount = clsQuestionType4CourseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQuestionType4CourseDA.GetRecCount();
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
int intRecCount = clsQuestionType4CourseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQuestionType4CourseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQuestionType4CourseEN objQuestionType4CourseCond)
{
List<clsQuestionType4CourseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionType4CourseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionType4Course.AttributeName)
{
if (objQuestionType4CourseCond.IsUpdated(strFldName) == false) continue;
if (objQuestionType4CourseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionType4CourseCond[strFldName].ToString());
}
else
{
if (objQuestionType4CourseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionType4CourseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionType4CourseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionType4CourseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionType4CourseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionType4CourseCond[strFldName]));
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
 List<string> arrList = clsQuestionType4CourseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QuestionType4CourseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QuestionType4CourseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QuestionType4CourseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionType4CourseDA.SetFldValue(clsQuestionType4CourseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QuestionType4CourseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionType4CourseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionType4CourseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionType4CourseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QuestionType4Course] "); 
 strCreateTabCode.Append(" ( "); 
 // /**题目类型Id4课程*/ 
 strCreateTabCode.Append(" QuestionTypeId4Course char(8) primary key, "); 
 // /**题目类型名4课程*/ 
 strCreateTabCode.Append(" QuestionTypeName4Course varchar(30) not Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否使用*/ 
 strCreateTabCode.Append(" IsUse bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conQuestionType4Course.OrderNum); 
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjList = new clsQuestionType4CourseDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQuestionType4CourseEN objQuestionType4Course in arrQuestionType4CourseObjList)
{
objQuestionType4Course.OrderNum = intIndex;
UpdateBySql2(objQuestionType4Course);
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
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strQuestionTypeId4Course">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strQuestionTypeId4Course)
{
try
{
//操作步骤：
//1、根据所给定的关键字[QuestionTypeId4Course],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字QuestionTypeId4Course
//5、把当前关键字QuestionTypeId4Course所对应记录的序号加(减)1
//6、把下(上)一个序号关键字QuestionTypeId4Course所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevQuestionTypeId4Course = "";    //上一条序号的关键字QuestionTypeId4Course
string strNextQuestionTypeId4Course = "";    //下一条序号的关键字QuestionTypeId4Course
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[QuestionTypeId4Course],获取相应的序号[OrderNum]。

clsQuestionType4CourseEN objQuestionType4Course = clsQuestionType4CourseBL.GetObjByQuestionTypeId4Course(strQuestionTypeId4Course);

intOrderNum = objQuestionType4Course.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsQuestionType4CourseBL.GetRecCountByCond(clsQuestionType4CourseEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conQuestionType4Course.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字QuestionTypeId4Course
strPrevQuestionTypeId4Course = clsQuestionType4CourseBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevQuestionTypeId4Course) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字QuestionTypeId4Course所对应记录的序号减1
//6、把下(上)一个序号关键字QuestionTypeId4Course所对应的记录序号加1
clsQuestionType4CourseBL.SetFldValue(clsQuestionType4CourseEN._CurrTabName, conQuestionType4Course.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conQuestionType4Course.QuestionTypeId4Course, strQuestionTypeId4Course));
clsQuestionType4CourseBL.SetFldValue(clsQuestionType4CourseEN._CurrTabName, conQuestionType4Course.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conQuestionType4Course.QuestionTypeId4Course, strPrevQuestionTypeId4Course));
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

//4、获取下一个序号字段的关键字QuestionTypeId4Course
strCondition.AppendFormat(" {0} = {1}", conQuestionType4Course.OrderNum, intOrderNum + 1);

strNextQuestionTypeId4Course = clsQuestionType4CourseBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextQuestionTypeId4Course) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字QuestionTypeId4Course所对应记录的序号加1
//6、把下(上)一个序号关键字QuestionTypeId4Course所对应的记录序号减1
clsQuestionType4CourseBL.SetFldValue(clsQuestionType4CourseEN._CurrTabName, conQuestionType4Course.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conQuestionType4Course.QuestionTypeId4Course, strQuestionTypeId4Course));
clsQuestionType4CourseBL.SetFldValue(clsQuestionType4CourseEN._CurrTabName, conQuestionType4Course.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conQuestionType4Course.QuestionTypeId4Course, strNextQuestionTypeId4Course));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsQuestionType4CourseBL.ReFreshCache();
if (clsQuestionType4CourseBL.relatedActions != null)
{
clsQuestionType4CourseBL.relatedActions.UpdRelaTabDate(objQuestionType4Course.QuestionTypeId4Course, "UpdRelaTabDate");
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
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conQuestionType4Course.QuestionTypeId4Course, strKeyList);
List<clsQuestionType4CourseEN> arrQuestionType4CourseLst = GetObjLst(strCondition);
foreach (clsQuestionType4CourseEN objQuestionType4Course in arrQuestionType4CourseLst)
{
objQuestionType4Course.OrderNum = objQuestionType4Course.OrderNum + 10000;
UpdateBySql2(objQuestionType4Course);
}
strCondition = string.Format("1 = 1 order by {0} ", conQuestionType4Course.OrderNum); 
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjList = new clsQuestionType4CourseDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQuestionType4CourseEN objQuestionType4Course in arrQuestionType4CourseObjList)
{
objQuestionType4Course.OrderNum = intIndex;
UpdateBySql2(objQuestionType4Course);
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
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conQuestionType4Course.QuestionTypeId4Course, strKeyList);
List<clsQuestionType4CourseEN> arrQuestionType4CourseLst = GetObjLst(strCondition);
foreach (clsQuestionType4CourseEN objQuestionType4Course in arrQuestionType4CourseLst)
{
objQuestionType4Course.OrderNum = objQuestionType4Course.OrderNum - 10000;
UpdateBySql2(objQuestionType4Course);
}
strCondition = string.Format("1 = 1 order by {0} ", conQuestionType4Course.OrderNum); 
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjList = new clsQuestionType4CourseDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQuestionType4CourseEN objQuestionType4Course in arrQuestionType4CourseObjList)
{
objQuestionType4Course.OrderNum = intIndex;
UpdateBySql2(objQuestionType4Course);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 题目类型4课程(QuestionType4Course)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QuestionType4Course : clsCommFun4BL
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
clsQuestionType4CourseBL.ReFreshThisCache();
}
}

}