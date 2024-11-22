
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireAddiBL
 表名:QuestionnaireAddi(01120886)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:56
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
public static class  clsQuestionnaireAddiBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireAddiEN GetObj(this K_QuestionId_QuestionnaireAddi myKey)
{
clsQuestionnaireAddiEN objQuestionnaireAddiEN = clsQuestionnaireAddiBL.QuestionnaireAddiDA.GetObjByQuestionId(myKey.Value);
return objQuestionnaireAddiEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsNeedCheckUniqueness = true)
{
try
{
bool bolResult = clsQuestionnaireAddiBL.QuestionnaireAddiDA.AddNewRecordBySQL2(objQuestionnaireAddiEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiBL.ReFreshCache(objQuestionnaireAddiEN.CourseId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
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
public static bool AddRecordEx(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQuestionnaireAddiBL.IsExist(objQuestionnaireAddiEN.QuestionId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQuestionnaireAddiEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objQuestionnaireAddiEN.AddNewRecord();
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
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsNeedCheckUniqueness = true)
{
try
{
string strKey = clsQuestionnaireAddiBL.QuestionnaireAddiDA.AddNewRecordBySQL2WithReturnKey(objQuestionnaireAddiEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiBL.ReFreshCache(objQuestionnaireAddiEN.CourseId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
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
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, long lngQuestionId, string strComparisonOp="")
	{
objQuestionnaireAddiEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionIndex(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int? intQuestionIndex, string strComparisonOp="")
	{
objQuestionnaireAddiEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionIndex) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionIndex, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionIndex] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionName(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionName, conQuestionnaireAddi.QuestionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, conQuestionnaireAddi.QuestionName);
}
objQuestionnaireAddiEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionName) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionName, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionName] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionContent(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionContent, 4000, conQuestionnaireAddi.QuestionContent);
}
objQuestionnaireAddiEN.QuestionContent = strQuestionContent; //题目内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionContent) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionContent, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionContent] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionMemo(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionMemo, 1000, conQuestionnaireAddi.QuestionMemo);
}
objQuestionnaireAddiEN.QuestionMemo = strQuestionMemo; //题目说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionMemo) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionMemo, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionMemo] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionNo(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, conQuestionnaireAddi.QuestionNo);
}
objQuestionnaireAddiEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionNo) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionNo, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionNo] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetParentQuestionId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strParentQuestionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentQuestionId, 8, conQuestionnaireAddi.ParentQuestionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentQuestionId, 8, conQuestionnaireAddi.ParentQuestionId);
}
objQuestionnaireAddiEN.ParentQuestionId = strParentQuestionId; //父题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.ParentQuestionId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.ParentQuestionId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.ParentQuestionId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetExamAnswer(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strExamAnswer, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamAnswer, 8000, conQuestionnaireAddi.ExamAnswer);
}
objQuestionnaireAddiEN.ExamAnswer = strExamAnswer; //题目答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.ExamAnswer) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.ExamAnswer, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.ExamAnswer] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCourseId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conQuestionnaireAddi.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conQuestionnaireAddi.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conQuestionnaireAddi.CourseId);
}
objQuestionnaireAddiEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CourseId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CourseId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CourseId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetLevelNo(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int? intLevelNo, string strComparisonOp="")
	{
objQuestionnaireAddiEN.LevelNo = intLevelNo; //学习关号2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.LevelNo) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.LevelNo, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.LevelNo] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCourseChapterId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conQuestionnaireAddi.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conQuestionnaireAddi.CourseChapterId);
}
objQuestionnaireAddiEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CourseChapterId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CourseChapterId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CourseChapterId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionTypeId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, conQuestionnaireAddi.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, conQuestionnaireAddi.QuestionTypeId);
}
objQuestionnaireAddiEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionTypeId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionTypeId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionTypeId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionTypeId4Course(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId4Course, conQuestionnaireAddi.QuestionTypeId4Course);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, conQuestionnaireAddi.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, conQuestionnaireAddi.QuestionTypeId4Course);
}
objQuestionnaireAddiEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionTypeId4Course) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionTypeId4Course, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionTypeId4Course] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetExamGradeId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strExamGradeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamGradeId, 2, conQuestionnaireAddi.ExamGradeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamGradeId, 2, conQuestionnaireAddi.ExamGradeId);
}
objQuestionnaireAddiEN.ExamGradeId = strExamGradeId; //题库等级ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.ExamGradeId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.ExamGradeId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.ExamGradeId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetAnswerTypeId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAnswerTypeId, conQuestionnaireAddi.AnswerTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conQuestionnaireAddi.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conQuestionnaireAddi.AnswerTypeId);
}
objQuestionnaireAddiEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.AnswerTypeId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.AnswerTypeId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.AnswerTypeId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetGridTitle(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, conQuestionnaireAddi.GridTitle);
}
objQuestionnaireAddiEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.GridTitle) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.GridTitle, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.GridTitle] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetAnswerModeId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, conQuestionnaireAddi.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, conQuestionnaireAddi.AnswerModeId);
}
objQuestionnaireAddiEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.AnswerModeId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.AnswerModeId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.AnswerModeId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsHaveAdditionalMemo(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsHaveAdditionalMemo, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsHaveAdditionalMemo = bolIsHaveAdditionalMemo; //是否有附加说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsHaveAdditionalMemo) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsHaveAdditionalMemo, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsHaveAdditionalMemo] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionnaireSetId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, conQuestionnaireAddi.QuestionnaireSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, conQuestionnaireAddi.QuestionnaireSetId);
}
objQuestionnaireAddiEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionnaireSetId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionnaireSetId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionnaireSetId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionScore(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, float? fltQuestionScore, string strComparisonOp="")
	{
objQuestionnaireAddiEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionScore) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionScore, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionScore] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetQuestionNameAdd(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strQuestionNameAdd, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNameAdd, 500, conQuestionnaireAddi.QuestionNameAdd);
}
objQuestionnaireAddiEN.QuestionNameAdd = strQuestionNameAdd; //题目补充
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.QuestionNameAdd) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.QuestionNameAdd, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.QuestionNameAdd] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetDefaultValue(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conQuestionnaireAddi.DefaultValue);
}
objQuestionnaireAddiEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.DefaultValue) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.DefaultValue, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.DefaultValue] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetTextDirectId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strTextDirectId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextDirectId, conQuestionnaireAddi.TextDirectId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextDirectId, 4, conQuestionnaireAddi.TextDirectId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextDirectId, 4, conQuestionnaireAddi.TextDirectId);
}
objQuestionnaireAddiEN.TextDirectId = strTextDirectId; //文本方向ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.TextDirectId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.TextDirectId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.TextDirectId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetFillInTextWidth(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int? intFillInTextWidth, string strComparisonOp="")
	{
objQuestionnaireAddiEN.FillInTextWidth = intFillInTextWidth; //填空框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.FillInTextWidth) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.FillInTextWidth, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.FillInTextWidth] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetMemoTextWidth(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int? intMemoTextWidth, string strComparisonOp="")
	{
objQuestionnaireAddiEN.MemoTextWidth = intMemoTextWidth; //备注框宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.MemoTextWidth) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.MemoTextWidth, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.MemoTextWidth] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCodeTab(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCodeTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTab, 50, conQuestionnaireAddi.CodeTab);
}
objQuestionnaireAddiEN.CodeTab = strCodeTab; //代码表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CodeTab) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CodeTab, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CodeTab] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCodeTabCode(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCodeTabCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCode, 50, conQuestionnaireAddi.CodeTabCode);
}
objQuestionnaireAddiEN.CodeTabCode = strCodeTabCode; //CodeTab_Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CodeTabCode) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CodeTabCode, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CodeTabCode] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCodeTabName(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCodeTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabName, 50, conQuestionnaireAddi.CodeTabName);
}
objQuestionnaireAddiEN.CodeTabName = strCodeTabName; //CodeTab_Name
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CodeTabName) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CodeTabName, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CodeTabName] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCodeTabCondition(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCodeTabCondition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCondition, 200, conQuestionnaireAddi.CodeTabCondition);
}
objQuestionnaireAddiEN.CodeTabCondition = strCodeTabCondition; //代码表_条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CodeTabCondition) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CodeTabCondition, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CodeTabCondition] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetRelaEvent(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strRelaEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaEvent, 4000, conQuestionnaireAddi.RelaEvent);
}
objQuestionnaireAddiEN.RelaEvent = strRelaEvent; //相关事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.RelaEvent) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.RelaEvent, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.RelaEvent] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetFirstIndent(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolFirstIndent, string strComparisonOp="")
	{
objQuestionnaireAddiEN.FirstIndent = bolFirstIndent; //首行缩进
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.FirstIndent) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.FirstIndent, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.FirstIndent] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetDefaultSelectItem(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strDefaultSelectItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultSelectItem, 20, conQuestionnaireAddi.DefaultSelectItem);
}
objQuestionnaireAddiEN.DefaultSelectItem = strDefaultSelectItem; //默认选项
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.DefaultSelectItem) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.DefaultSelectItem, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.DefaultSelectItem] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIfLinkage(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIfLinkage, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IfLinkage = bolIfLinkage; //是否联动
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IfLinkage) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IfLinkage, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IfLinkage] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetLinkageIndex(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int? intLinkageIndex, string strComparisonOp="")
	{
objQuestionnaireAddiEN.LinkageIndex = intLinkageIndex; //联动题序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.LinkageIndex) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.LinkageIndex, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.LinkageIndex] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsAutoGridTitle(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsAutoGridTitle, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsAutoGridTitle = bolIsAutoGridTitle; //是否自动编表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsAutoGridTitle) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsAutoGridTitle, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsAutoGridTitle] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetFillInTextHeight(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int? intFillInTextHeight, string strComparisonOp="")
	{
objQuestionnaireAddiEN.FillInTextHeight = intFillInTextHeight; //填空框高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.FillInTextHeight) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.FillInTextHeight, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.FillInTextHeight] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsMulti4FillInText(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsMulti4FillInText, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsMulti4FillInText = bolIsMulti4FillInText; //是否填空框多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsMulti4FillInText) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsMulti4FillInText, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsMulti4FillInText] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetCheckBoxLimitCount(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, int? intCheckBoxLimitCount, string strComparisonOp="")
	{
objQuestionnaireAddiEN.CheckBoxLimitCount = intCheckBoxLimitCount; //复选框限制数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.CheckBoxLimitCount) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.CheckBoxLimitCount, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.CheckBoxLimitCount] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetRoleId(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQuestionnaireAddi.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQuestionnaireAddi.RoleId);
}
objQuestionnaireAddiEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.RoleId) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.RoleId, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.RoleId] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsShow(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsShow, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsShow) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsShow, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsShow] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsCast(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsCast, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsCast = bolIsCast; //是否播放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsCast) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsCast, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsCast] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetLikeCount(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, long? lngLikeCount, string strComparisonOp="")
	{
objQuestionnaireAddiEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.LikeCount) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.LikeCount, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.LikeCount] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetAnswerAttLimitSize(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, long? lngAnswerAttLimitSize, string strComparisonOp="")
	{
objQuestionnaireAddiEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.AnswerAttLimitSize) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.AnswerAttLimitSize, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.AnswerAttLimitSize] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetLimitedResourceType(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strLimitedResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, conQuestionnaireAddi.LimitedResourceType);
}
objQuestionnaireAddiEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.LimitedResourceType) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.LimitedResourceType, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.LimitedResourceType] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsEffective(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsEffective, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsEffective) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsEffective, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsEffective] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetIsCanInPaper(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsCanInPaper, string strComparisonOp="")
	{
objQuestionnaireAddiEN.IsCanInPaper = bolIsCanInPaper; //是否可在Paper
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.IsCanInPaper) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.IsCanInPaper, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.IsCanInPaper] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetUpdDate(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionnaireAddi.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionnaireAddi.UpdDate);
}
objQuestionnaireAddiEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.UpdDate) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.UpdDate, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.UpdDate] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetUpdUser(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionnaireAddi.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionnaireAddi.UpdUser);
}
objQuestionnaireAddiEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.UpdUser) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.UpdUser, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.UpdUser] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireAddiEN SetMemo(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionnaireAddi.Memo);
}
objQuestionnaireAddiEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireAddiEN.dicFldComparisonOp.ContainsKey(conQuestionnaireAddi.Memo) == false)
{
objQuestionnaireAddiEN.dicFldComparisonOp.Add(conQuestionnaireAddi.Memo, strComparisonOp);
}
else
{
objQuestionnaireAddiEN.dicFldComparisonOp[conQuestionnaireAddi.Memo] = strComparisonOp;
}
}
return objQuestionnaireAddiEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQuestionnaireAddiEN.CheckPropertyNew();
clsQuestionnaireAddiEN objQuestionnaireAddiCond = new clsQuestionnaireAddiEN();
string strCondition = objQuestionnaireAddiCond
.SetQuestionId(objQuestionnaireAddiEN.QuestionId, "=")
.GetCombineCondition();
objQuestionnaireAddiEN._IsCheckProperty = true;
bool bolIsExist = clsQuestionnaireAddiBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQuestionnaireAddiEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
 if (objQuestionnaireAddiEN.QuestionId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionnaireAddiBL.QuestionnaireAddiDA.UpdateBySql2(objQuestionnaireAddiEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiBL.ReFreshCache(objQuestionnaireAddiEN.CourseId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
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
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQuestionnaireAddiEN.QuestionId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionnaireAddiBL.QuestionnaireAddiDA.UpdateBySql2(objQuestionnaireAddiEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiBL.ReFreshCache(objQuestionnaireAddiEN.CourseId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
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
 /// <param name = "objQuestionnaireAddiEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strWhereCond)
{
try
{
bool bolResult = clsQuestionnaireAddiBL.QuestionnaireAddiDA.UpdateBySqlWithCondition(objQuestionnaireAddiEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiBL.ReFreshCache(objQuestionnaireAddiEN.CourseId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
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
 /// <param name = "objQuestionnaireAddiEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQuestionnaireAddiBL.QuestionnaireAddiDA.UpdateBySqlWithConditionTransaction(objQuestionnaireAddiEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiBL.ReFreshCache(objQuestionnaireAddiEN.CourseId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
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
public static int Delete(this clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
try
{
int intRecNum = clsQuestionnaireAddiBL.QuestionnaireAddiDA.DelRecord(objQuestionnaireAddiEN.QuestionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiBL.ReFreshCache(objQuestionnaireAddiEN.CourseId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
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
 /// <param name = "objQuestionnaireAddiENS">源对象</param>
 /// <param name = "objQuestionnaireAddiENT">目标对象</param>
 public static void CopyTo(this clsQuestionnaireAddiEN objQuestionnaireAddiENS, clsQuestionnaireAddiEN objQuestionnaireAddiENT)
{
try
{
objQuestionnaireAddiENT.QuestionId = objQuestionnaireAddiENS.QuestionId; //题目Id
objQuestionnaireAddiENT.QuestionIndex = objQuestionnaireAddiENS.QuestionIndex; //题目序号
objQuestionnaireAddiENT.QuestionName = objQuestionnaireAddiENS.QuestionName; //题目名称
objQuestionnaireAddiENT.QuestionContent = objQuestionnaireAddiENS.QuestionContent; //题目内容
objQuestionnaireAddiENT.QuestionMemo = objQuestionnaireAddiENS.QuestionMemo; //题目说明
objQuestionnaireAddiENT.QuestionNo = objQuestionnaireAddiENS.QuestionNo; //题目编号
objQuestionnaireAddiENT.ParentQuestionId = objQuestionnaireAddiENS.ParentQuestionId; //父题目Id
objQuestionnaireAddiENT.ExamAnswer = objQuestionnaireAddiENS.ExamAnswer; //题目答案
objQuestionnaireAddiENT.CourseId = objQuestionnaireAddiENS.CourseId; //课程Id
objQuestionnaireAddiENT.LevelNo = objQuestionnaireAddiENS.LevelNo; //学习关号2
objQuestionnaireAddiENT.CourseChapterId = objQuestionnaireAddiENS.CourseChapterId; //课程章节ID
objQuestionnaireAddiENT.QuestionTypeId = objQuestionnaireAddiENS.QuestionTypeId; //题目类型Id
objQuestionnaireAddiENT.QuestionTypeId4Course = objQuestionnaireAddiENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionnaireAddiENT.ExamGradeId = objQuestionnaireAddiENS.ExamGradeId; //题库等级ID
objQuestionnaireAddiENT.AnswerTypeId = objQuestionnaireAddiENS.AnswerTypeId; //答案类型ID
objQuestionnaireAddiENT.GridTitle = objQuestionnaireAddiENS.GridTitle; //表格标题
objQuestionnaireAddiENT.AnswerModeId = objQuestionnaireAddiENS.AnswerModeId; //答案模式Id
objQuestionnaireAddiENT.IsHaveAdditionalMemo = objQuestionnaireAddiENS.IsHaveAdditionalMemo; //是否有附加说明
objQuestionnaireAddiENT.QuestionnaireSetId = objQuestionnaireAddiENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireAddiENT.QuestionScore = objQuestionnaireAddiENS.QuestionScore; //题目得分
objQuestionnaireAddiENT.QuestionNameAdd = objQuestionnaireAddiENS.QuestionNameAdd; //题目补充
objQuestionnaireAddiENT.DefaultValue = objQuestionnaireAddiENS.DefaultValue; //缺省值
objQuestionnaireAddiENT.TextDirectId = objQuestionnaireAddiENS.TextDirectId; //文本方向ID
objQuestionnaireAddiENT.FillInTextWidth = objQuestionnaireAddiENS.FillInTextWidth; //填空框宽度
objQuestionnaireAddiENT.MemoTextWidth = objQuestionnaireAddiENS.MemoTextWidth; //备注框宽度
objQuestionnaireAddiENT.CodeTab = objQuestionnaireAddiENS.CodeTab; //代码表
objQuestionnaireAddiENT.CodeTabCode = objQuestionnaireAddiENS.CodeTabCode; //CodeTab_Code
objQuestionnaireAddiENT.CodeTabName = objQuestionnaireAddiENS.CodeTabName; //CodeTab_Name
objQuestionnaireAddiENT.CodeTabCondition = objQuestionnaireAddiENS.CodeTabCondition; //代码表_条件
objQuestionnaireAddiENT.RelaEvent = objQuestionnaireAddiENS.RelaEvent; //相关事件
objQuestionnaireAddiENT.FirstIndent = objQuestionnaireAddiENS.FirstIndent; //首行缩进
objQuestionnaireAddiENT.DefaultSelectItem = objQuestionnaireAddiENS.DefaultSelectItem; //默认选项
objQuestionnaireAddiENT.IfLinkage = objQuestionnaireAddiENS.IfLinkage; //是否联动
objQuestionnaireAddiENT.LinkageIndex = objQuestionnaireAddiENS.LinkageIndex; //联动题序号
objQuestionnaireAddiENT.IsAutoGridTitle = objQuestionnaireAddiENS.IsAutoGridTitle; //是否自动编表格标题
objQuestionnaireAddiENT.FillInTextHeight = objQuestionnaireAddiENS.FillInTextHeight; //填空框高度
objQuestionnaireAddiENT.IsMulti4FillInText = objQuestionnaireAddiENS.IsMulti4FillInText; //是否填空框多行
objQuestionnaireAddiENT.CheckBoxLimitCount = objQuestionnaireAddiENS.CheckBoxLimitCount; //复选框限制数
objQuestionnaireAddiENT.RoleId = objQuestionnaireAddiENS.RoleId; //角色Id
objQuestionnaireAddiENT.IsShow = objQuestionnaireAddiENS.IsShow; //是否启用
objQuestionnaireAddiENT.IsCast = objQuestionnaireAddiENS.IsCast; //是否播放
objQuestionnaireAddiENT.LikeCount = objQuestionnaireAddiENS.LikeCount; //资源喜欢数量
objQuestionnaireAddiENT.AnswerAttLimitSize = objQuestionnaireAddiENS.AnswerAttLimitSize; //回答附件限制大小
objQuestionnaireAddiENT.LimitedResourceType = objQuestionnaireAddiENS.LimitedResourceType; //限制资源类型
objQuestionnaireAddiENT.IsEffective = objQuestionnaireAddiENS.IsEffective; //是否有效
objQuestionnaireAddiENT.IsCanInPaper = objQuestionnaireAddiENS.IsCanInPaper; //是否可在Paper
objQuestionnaireAddiENT.UpdDate = objQuestionnaireAddiENS.UpdDate; //修改日期
objQuestionnaireAddiENT.UpdUser = objQuestionnaireAddiENS.UpdUser; //修改人
objQuestionnaireAddiENT.Memo = objQuestionnaireAddiENS.Memo; //备注
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
 /// <param name = "objQuestionnaireAddiENS">源对象</param>
 /// <returns>目标对象=>clsQuestionnaireAddiEN:objQuestionnaireAddiENT</returns>
 public static clsQuestionnaireAddiEN CopyTo(this clsQuestionnaireAddiEN objQuestionnaireAddiENS)
{
try
{
 clsQuestionnaireAddiEN objQuestionnaireAddiENT = new clsQuestionnaireAddiEN()
{
QuestionId = objQuestionnaireAddiENS.QuestionId, //题目Id
QuestionIndex = objQuestionnaireAddiENS.QuestionIndex, //题目序号
QuestionName = objQuestionnaireAddiENS.QuestionName, //题目名称
QuestionContent = objQuestionnaireAddiENS.QuestionContent, //题目内容
QuestionMemo = objQuestionnaireAddiENS.QuestionMemo, //题目说明
QuestionNo = objQuestionnaireAddiENS.QuestionNo, //题目编号
ParentQuestionId = objQuestionnaireAddiENS.ParentQuestionId, //父题目Id
ExamAnswer = objQuestionnaireAddiENS.ExamAnswer, //题目答案
CourseId = objQuestionnaireAddiENS.CourseId, //课程Id
LevelNo = objQuestionnaireAddiENS.LevelNo, //学习关号2
CourseChapterId = objQuestionnaireAddiENS.CourseChapterId, //课程章节ID
QuestionTypeId = objQuestionnaireAddiENS.QuestionTypeId, //题目类型Id
QuestionTypeId4Course = objQuestionnaireAddiENS.QuestionTypeId4Course, //题目类型Id4课程
ExamGradeId = objQuestionnaireAddiENS.ExamGradeId, //题库等级ID
AnswerTypeId = objQuestionnaireAddiENS.AnswerTypeId, //答案类型ID
GridTitle = objQuestionnaireAddiENS.GridTitle, //表格标题
AnswerModeId = objQuestionnaireAddiENS.AnswerModeId, //答案模式Id
IsHaveAdditionalMemo = objQuestionnaireAddiENS.IsHaveAdditionalMemo, //是否有附加说明
QuestionnaireSetId = objQuestionnaireAddiENS.QuestionnaireSetId, //问卷集ID
QuestionScore = objQuestionnaireAddiENS.QuestionScore, //题目得分
QuestionNameAdd = objQuestionnaireAddiENS.QuestionNameAdd, //题目补充
DefaultValue = objQuestionnaireAddiENS.DefaultValue, //缺省值
TextDirectId = objQuestionnaireAddiENS.TextDirectId, //文本方向ID
FillInTextWidth = objQuestionnaireAddiENS.FillInTextWidth, //填空框宽度
MemoTextWidth = objQuestionnaireAddiENS.MemoTextWidth, //备注框宽度
CodeTab = objQuestionnaireAddiENS.CodeTab, //代码表
CodeTabCode = objQuestionnaireAddiENS.CodeTabCode, //CodeTab_Code
CodeTabName = objQuestionnaireAddiENS.CodeTabName, //CodeTab_Name
CodeTabCondition = objQuestionnaireAddiENS.CodeTabCondition, //代码表_条件
RelaEvent = objQuestionnaireAddiENS.RelaEvent, //相关事件
FirstIndent = objQuestionnaireAddiENS.FirstIndent, //首行缩进
DefaultSelectItem = objQuestionnaireAddiENS.DefaultSelectItem, //默认选项
IfLinkage = objQuestionnaireAddiENS.IfLinkage, //是否联动
LinkageIndex = objQuestionnaireAddiENS.LinkageIndex, //联动题序号
IsAutoGridTitle = objQuestionnaireAddiENS.IsAutoGridTitle, //是否自动编表格标题
FillInTextHeight = objQuestionnaireAddiENS.FillInTextHeight, //填空框高度
IsMulti4FillInText = objQuestionnaireAddiENS.IsMulti4FillInText, //是否填空框多行
CheckBoxLimitCount = objQuestionnaireAddiENS.CheckBoxLimitCount, //复选框限制数
RoleId = objQuestionnaireAddiENS.RoleId, //角色Id
IsShow = objQuestionnaireAddiENS.IsShow, //是否启用
IsCast = objQuestionnaireAddiENS.IsCast, //是否播放
LikeCount = objQuestionnaireAddiENS.LikeCount, //资源喜欢数量
AnswerAttLimitSize = objQuestionnaireAddiENS.AnswerAttLimitSize, //回答附件限制大小
LimitedResourceType = objQuestionnaireAddiENS.LimitedResourceType, //限制资源类型
IsEffective = objQuestionnaireAddiENS.IsEffective, //是否有效
IsCanInPaper = objQuestionnaireAddiENS.IsCanInPaper, //是否可在Paper
UpdDate = objQuestionnaireAddiENS.UpdDate, //修改日期
UpdUser = objQuestionnaireAddiENS.UpdUser, //修改人
Memo = objQuestionnaireAddiENS.Memo, //备注
};
 return objQuestionnaireAddiENT;
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
public static void CheckPropertyNew(this clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
 clsQuestionnaireAddiBL.QuestionnaireAddiDA.CheckPropertyNew(objQuestionnaireAddiEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
 clsQuestionnaireAddiBL.QuestionnaireAddiDA.CheckProperty4Condition(objQuestionnaireAddiEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionnaireAddiEN objQuestionnaireAddiCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.QuestionId) == true)
{
string strComparisonOpQuestionId = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.QuestionId, objQuestionnaireAddiCond.QuestionId, strComparisonOpQuestionId);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.QuestionIndex, objQuestionnaireAddiCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.QuestionName) == true)
{
string strComparisonOpQuestionName = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionName, objQuestionnaireAddiCond.QuestionName, strComparisonOpQuestionName);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.QuestionContent) == true)
{
string strComparisonOpQuestionContent = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.QuestionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionContent, objQuestionnaireAddiCond.QuestionContent, strComparisonOpQuestionContent);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.QuestionMemo) == true)
{
string strComparisonOpQuestionMemo = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.QuestionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionMemo, objQuestionnaireAddiCond.QuestionMemo, strComparisonOpQuestionMemo);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionNo, objQuestionnaireAddiCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.ParentQuestionId) == true)
{
string strComparisonOpParentQuestionId = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.ParentQuestionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.ParentQuestionId, objQuestionnaireAddiCond.ParentQuestionId, strComparisonOpParentQuestionId);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.ExamAnswer) == true)
{
string strComparisonOpExamAnswer = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.ExamAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.ExamAnswer, objQuestionnaireAddiCond.ExamAnswer, strComparisonOpExamAnswer);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.CourseId) == true)
{
string strComparisonOpCourseId = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CourseId, objQuestionnaireAddiCond.CourseId, strComparisonOpCourseId);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.LevelNo) == true)
{
string strComparisonOpLevelNo = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.LevelNo];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.LevelNo, objQuestionnaireAddiCond.LevelNo, strComparisonOpLevelNo);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CourseChapterId, objQuestionnaireAddiCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionTypeId, objQuestionnaireAddiCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionTypeId4Course, objQuestionnaireAddiCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.ExamGradeId) == true)
{
string strComparisonOpExamGradeId = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.ExamGradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.ExamGradeId, objQuestionnaireAddiCond.ExamGradeId, strComparisonOpExamGradeId);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.AnswerTypeId, objQuestionnaireAddiCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.GridTitle) == true)
{
string strComparisonOpGridTitle = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.GridTitle, objQuestionnaireAddiCond.GridTitle, strComparisonOpGridTitle);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.AnswerModeId, objQuestionnaireAddiCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.IsHaveAdditionalMemo) == true)
{
if (objQuestionnaireAddiCond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsHaveAdditionalMemo);
}
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.QuestionnaireSetId) == true)
{
string strComparisonOpQuestionnaireSetId = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionnaireSetId, objQuestionnaireAddiCond.QuestionnaireSetId, strComparisonOpQuestionnaireSetId);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.QuestionScore) == true)
{
string strComparisonOpQuestionScore = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.QuestionScore, objQuestionnaireAddiCond.QuestionScore, strComparisonOpQuestionScore);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.QuestionNameAdd) == true)
{
string strComparisonOpQuestionNameAdd = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.QuestionNameAdd];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.QuestionNameAdd, objQuestionnaireAddiCond.QuestionNameAdd, strComparisonOpQuestionNameAdd);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.DefaultValue, objQuestionnaireAddiCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.TextDirectId) == true)
{
string strComparisonOpTextDirectId = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.TextDirectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.TextDirectId, objQuestionnaireAddiCond.TextDirectId, strComparisonOpTextDirectId);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.FillInTextWidth) == true)
{
string strComparisonOpFillInTextWidth = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.FillInTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.FillInTextWidth, objQuestionnaireAddiCond.FillInTextWidth, strComparisonOpFillInTextWidth);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.MemoTextWidth) == true)
{
string strComparisonOpMemoTextWidth = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.MemoTextWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.MemoTextWidth, objQuestionnaireAddiCond.MemoTextWidth, strComparisonOpMemoTextWidth);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.CodeTab) == true)
{
string strComparisonOpCodeTab = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CodeTab, objQuestionnaireAddiCond.CodeTab, strComparisonOpCodeTab);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.CodeTabCode) == true)
{
string strComparisonOpCodeTabCode = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.CodeTabCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CodeTabCode, objQuestionnaireAddiCond.CodeTabCode, strComparisonOpCodeTabCode);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.CodeTabName) == true)
{
string strComparisonOpCodeTabName = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.CodeTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CodeTabName, objQuestionnaireAddiCond.CodeTabName, strComparisonOpCodeTabName);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.CodeTabCondition) == true)
{
string strComparisonOpCodeTabCondition = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.CodeTabCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.CodeTabCondition, objQuestionnaireAddiCond.CodeTabCondition, strComparisonOpCodeTabCondition);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.RelaEvent) == true)
{
string strComparisonOpRelaEvent = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.RelaEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.RelaEvent, objQuestionnaireAddiCond.RelaEvent, strComparisonOpRelaEvent);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.FirstIndent) == true)
{
if (objQuestionnaireAddiCond.FirstIndent == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.FirstIndent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.FirstIndent);
}
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.DefaultSelectItem) == true)
{
string strComparisonOpDefaultSelectItem = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.DefaultSelectItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.DefaultSelectItem, objQuestionnaireAddiCond.DefaultSelectItem, strComparisonOpDefaultSelectItem);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.IfLinkage) == true)
{
if (objQuestionnaireAddiCond.IfLinkage == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IfLinkage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IfLinkage);
}
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.LinkageIndex) == true)
{
string strComparisonOpLinkageIndex = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.LinkageIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.LinkageIndex, objQuestionnaireAddiCond.LinkageIndex, strComparisonOpLinkageIndex);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.IsAutoGridTitle) == true)
{
if (objQuestionnaireAddiCond.IsAutoGridTitle == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsAutoGridTitle);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsAutoGridTitle);
}
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.FillInTextHeight) == true)
{
string strComparisonOpFillInTextHeight = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.FillInTextHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.FillInTextHeight, objQuestionnaireAddiCond.FillInTextHeight, strComparisonOpFillInTextHeight);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.IsMulti4FillInText) == true)
{
if (objQuestionnaireAddiCond.IsMulti4FillInText == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsMulti4FillInText);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsMulti4FillInText);
}
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.CheckBoxLimitCount) == true)
{
string strComparisonOpCheckBoxLimitCount = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.CheckBoxLimitCount];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.CheckBoxLimitCount, objQuestionnaireAddiCond.CheckBoxLimitCount, strComparisonOpCheckBoxLimitCount);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.RoleId) == true)
{
string strComparisonOpRoleId = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.RoleId, objQuestionnaireAddiCond.RoleId, strComparisonOpRoleId);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.IsShow) == true)
{
if (objQuestionnaireAddiCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsShow);
}
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.IsCast) == true)
{
if (objQuestionnaireAddiCond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsCast);
}
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.LikeCount) == true)
{
string strComparisonOpLikeCount = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.LikeCount, objQuestionnaireAddiCond.LikeCount, strComparisonOpLikeCount);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.AnswerAttLimitSize) == true)
{
string strComparisonOpAnswerAttLimitSize = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireAddi.AnswerAttLimitSize, objQuestionnaireAddiCond.AnswerAttLimitSize, strComparisonOpAnswerAttLimitSize);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.LimitedResourceType) == true)
{
string strComparisonOpLimitedResourceType = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.LimitedResourceType, objQuestionnaireAddiCond.LimitedResourceType, strComparisonOpLimitedResourceType);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.IsEffective) == true)
{
if (objQuestionnaireAddiCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsEffective);
}
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.IsCanInPaper) == true)
{
if (objQuestionnaireAddiCond.IsCanInPaper == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireAddi.IsCanInPaper);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireAddi.IsCanInPaper);
}
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.UpdDate) == true)
{
string strComparisonOpUpdDate = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.UpdDate, objQuestionnaireAddiCond.UpdDate, strComparisonOpUpdDate);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.UpdUser) == true)
{
string strComparisonOpUpdUser = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.UpdUser, objQuestionnaireAddiCond.UpdUser, strComparisonOpUpdUser);
}
if (objQuestionnaireAddiCond.IsUpdated(conQuestionnaireAddi.Memo) == true)
{
string strComparisonOpMemo = objQuestionnaireAddiCond.dicFldComparisonOp[conQuestionnaireAddi.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireAddi.Memo, objQuestionnaireAddiCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QuestionnaireAddi
{
public virtual bool UpdRelaTabDate(long lngQuestionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 题目附加(QuestionnaireAddi)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQuestionnaireAddiBL
{
public static RelatedActions_QuestionnaireAddi relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQuestionnaireAddiDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQuestionnaireAddiDA QuestionnaireAddiDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQuestionnaireAddiDA();
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
 public clsQuestionnaireAddiBL()
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
if (string.IsNullOrEmpty(clsQuestionnaireAddiEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionnaireAddiEN._ConnectString);
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
public static DataTable GetDataTable_QuestionnaireAddi(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QuestionnaireAddiDA.GetDataTable_QuestionnaireAddi(strWhereCond);
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
objDT = QuestionnaireAddiDA.GetDataTable(strWhereCond);
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
objDT = QuestionnaireAddiDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QuestionnaireAddiDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QuestionnaireAddiDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QuestionnaireAddiDA.GetDataTable_Top(objTopPara);
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
objDT = QuestionnaireAddiDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QuestionnaireAddiDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QuestionnaireAddiDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsQuestionnaireAddiEN> GetObjLstByQuestionIdLst(List<long> arrQuestionIdLst)
{
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
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
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = Int32.Parse(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireAddiEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireAddiEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQuestionnaireAddiEN> GetObjLstByQuestionIdLstCache(List<long> arrQuestionIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName, strCourseId);
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel =
arrQuestionnaireAddiObjLstCache
.Where(x => arrQuestionIdLst.Contains(x.QuestionId));
return arrQuestionnaireAddiObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireAddiEN> GetObjLst(string strWhereCond)
{
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = Int32.Parse(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireAddiEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireAddiEN);
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
public static List<clsQuestionnaireAddiEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = Int32.Parse(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireAddiEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireAddiEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQuestionnaireAddiCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQuestionnaireAddiEN> GetSubObjLstCache(clsQuestionnaireAddiEN objQuestionnaireAddiCond)
{
 string strCourseId = objQuestionnaireAddiCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsQuestionnaireAddiBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsQuestionnaireAddiEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionnaireAddiEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionnaireAddi.AttributeName)
{
if (objQuestionnaireAddiCond.IsUpdated(strFldName) == false) continue;
if (objQuestionnaireAddiCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireAddiCond[strFldName].ToString());
}
else
{
if (objQuestionnaireAddiCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionnaireAddiCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireAddiCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionnaireAddiCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionnaireAddiCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionnaireAddiCond[strFldName]));
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
public static List<clsQuestionnaireAddiEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = Int32.Parse(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireAddiEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireAddiEN);
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
public static List<clsQuestionnaireAddiEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = Int32.Parse(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireAddiEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireAddiEN);
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
List<clsQuestionnaireAddiEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQuestionnaireAddiEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireAddiEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQuestionnaireAddiEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
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
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = Int32.Parse(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireAddiEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireAddiEN);
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
public static List<clsQuestionnaireAddiEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = Int32.Parse(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireAddiEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireAddiEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQuestionnaireAddiEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQuestionnaireAddiEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = Int32.Parse(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireAddiEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireAddiEN);
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
public static List<clsQuestionnaireAddiEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = Int32.Parse(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireAddiEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireAddiEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireAddiEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = Int32.Parse(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireAddiEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireAddiEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQuestionnaireAddi(ref clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
bool bolResult = QuestionnaireAddiDA.GetQuestionnaireAddi(ref objQuestionnaireAddiEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireAddiEN GetObjByQuestionId(long lngQuestionId)
{
clsQuestionnaireAddiEN objQuestionnaireAddiEN = QuestionnaireAddiDA.GetObjByQuestionId(lngQuestionId);
return objQuestionnaireAddiEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQuestionnaireAddiEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQuestionnaireAddiEN objQuestionnaireAddiEN = QuestionnaireAddiDA.GetFirstObj(strWhereCond);
 return objQuestionnaireAddiEN;
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
public static clsQuestionnaireAddiEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQuestionnaireAddiEN objQuestionnaireAddiEN = QuestionnaireAddiDA.GetObjByDataRow(objRow);
 return objQuestionnaireAddiEN;
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
public static clsQuestionnaireAddiEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQuestionnaireAddiEN objQuestionnaireAddiEN = QuestionnaireAddiDA.GetObjByDataRow(objRow);
 return objQuestionnaireAddiEN;
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
 /// <param name = "lstQuestionnaireAddiObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionnaireAddiEN GetObjByQuestionIdFromList(long lngQuestionId, List<clsQuestionnaireAddiEN> lstQuestionnaireAddiObjLst)
{
foreach (clsQuestionnaireAddiEN objQuestionnaireAddiEN in lstQuestionnaireAddiObjLst)
{
if (objQuestionnaireAddiEN.QuestionId == lngQuestionId)
{
return objQuestionnaireAddiEN;
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
 lngQuestionId = new clsQuestionnaireAddiDA().GetFirstID(strWhereCond);
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
 arrList = QuestionnaireAddiDA.GetID(strWhereCond);
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
bool bolIsExist = QuestionnaireAddiDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QuestionnaireAddiDA.IsExist(lngQuestionId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngQuestionId">题目Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngQuestionId, string strOpUser)
{
clsQuestionnaireAddiEN objQuestionnaireAddiEN = clsQuestionnaireAddiBL.GetObjByQuestionId(lngQuestionId);
objQuestionnaireAddiEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQuestionnaireAddiEN.UpdUser = strOpUser;
return clsQuestionnaireAddiBL.UpdateBySql2(objQuestionnaireAddiEN);
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
 bolIsExist = clsQuestionnaireAddiDA.IsExistTable();
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
 bolIsExist = QuestionnaireAddiDA.IsExistTable(strTabName);
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
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsNeedCheckUniqueness=true)
{
try
{
bool bolResult = QuestionnaireAddiDA.AddNewRecordBySQL2(objQuestionnaireAddiEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiBL.ReFreshCache(objQuestionnaireAddiEN.CourseId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
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
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQuestionnaireAddiEN objQuestionnaireAddiEN, bool bolIsNeedCheckUniqueness=true)
{
try
{
string strKey = QuestionnaireAddiDA.AddNewRecordBySQL2WithReturnKey(objQuestionnaireAddiEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiBL.ReFreshCache(objQuestionnaireAddiEN.CourseId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
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
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
try
{
bool bolResult = QuestionnaireAddiDA.Update(objQuestionnaireAddiEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiBL.ReFreshCache(objQuestionnaireAddiEN.CourseId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
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
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
 if (objQuestionnaireAddiEN.QuestionId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QuestionnaireAddiDA.UpdateBySql2(objQuestionnaireAddiEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireAddiBL.ReFreshCache(objQuestionnaireAddiEN.CourseId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
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
 clsQuestionnaireAddiEN objQuestionnaireAddiEN = clsQuestionnaireAddiBL.GetObjByQuestionId(lngQuestionId);

if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(objQuestionnaireAddiEN.QuestionId, objQuestionnaireAddiEN.UpdUser);
}
if (objQuestionnaireAddiEN != null)
{
int intRecNum = QuestionnaireAddiDA.DelRecord(lngQuestionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQuestionnaireAddiEN.CourseId);
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
objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
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
//删除与表:[QuestionnaireAddi]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQuestionnaireAddi.QuestionId,
//lngQuestionId);
//        clsQuestionnaireAddiBL.DelQuestionnaireAddisByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionnaireAddiBL.DelRecord(lngQuestionId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionnaireAddiBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsQuestionnaireAddiBL.relatedActions != null)
{
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(lngQuestionId, "UpdRelaTabDate");
}
bool bolResult = QuestionnaireAddiDA.DelRecord(lngQuestionId,objSqlConnection,objSqlTransaction);
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
public static int DelQuestionnaireAddis(List<string> arrQuestionIdLst)
{
if (arrQuestionIdLst.Count == 0) return 0;
try
{
if (clsQuestionnaireAddiBL.relatedActions != null)
{
foreach (var strQuestionId in arrQuestionIdLst)
{
long lngQuestionId = long.Parse(strQuestionId);
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(lngQuestionId, "UpdRelaTabDate");
}
}
 clsQuestionnaireAddiEN objQuestionnaireAddiEN = clsQuestionnaireAddiBL.GetObjByQuestionId(long.Parse(arrQuestionIdLst[0]));
int intDelRecNum = QuestionnaireAddiDA.DelQuestionnaireAddi(arrQuestionIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQuestionnaireAddiEN.CourseId);
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
public static int DelQuestionnaireAddisByCond(string strWhereCond)
{
try
{
if (clsQuestionnaireAddiBL.relatedActions != null)
{
List<string> arrQuestionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strQuestionId in arrQuestionId)
{
long lngQuestionId = long.Parse(strQuestionId);
clsQuestionnaireAddiBL.relatedActions.UpdRelaTabDate(lngQuestionId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conQuestionnaireAddi.CourseId, strWhereCond);
int intRecNum = QuestionnaireAddiDA.DelQuestionnaireAddi(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QuestionnaireAddi]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngQuestionId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngQuestionId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
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
//删除与表:[QuestionnaireAddi]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionnaireAddiBL.DelRecord(lngQuestionId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionnaireAddiBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objQuestionnaireAddiENS">源对象</param>
 /// <param name = "objQuestionnaireAddiENT">目标对象</param>
 public static void CopyTo(clsQuestionnaireAddiEN objQuestionnaireAddiENS, clsQuestionnaireAddiEN objQuestionnaireAddiENT)
{
try
{
objQuestionnaireAddiENT.QuestionId = objQuestionnaireAddiENS.QuestionId; //题目Id
objQuestionnaireAddiENT.QuestionIndex = objQuestionnaireAddiENS.QuestionIndex; //题目序号
objQuestionnaireAddiENT.QuestionName = objQuestionnaireAddiENS.QuestionName; //题目名称
objQuestionnaireAddiENT.QuestionContent = objQuestionnaireAddiENS.QuestionContent; //题目内容
objQuestionnaireAddiENT.QuestionMemo = objQuestionnaireAddiENS.QuestionMemo; //题目说明
objQuestionnaireAddiENT.QuestionNo = objQuestionnaireAddiENS.QuestionNo; //题目编号
objQuestionnaireAddiENT.ParentQuestionId = objQuestionnaireAddiENS.ParentQuestionId; //父题目Id
objQuestionnaireAddiENT.ExamAnswer = objQuestionnaireAddiENS.ExamAnswer; //题目答案
objQuestionnaireAddiENT.CourseId = objQuestionnaireAddiENS.CourseId; //课程Id
objQuestionnaireAddiENT.LevelNo = objQuestionnaireAddiENS.LevelNo; //学习关号2
objQuestionnaireAddiENT.CourseChapterId = objQuestionnaireAddiENS.CourseChapterId; //课程章节ID
objQuestionnaireAddiENT.QuestionTypeId = objQuestionnaireAddiENS.QuestionTypeId; //题目类型Id
objQuestionnaireAddiENT.QuestionTypeId4Course = objQuestionnaireAddiENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionnaireAddiENT.ExamGradeId = objQuestionnaireAddiENS.ExamGradeId; //题库等级ID
objQuestionnaireAddiENT.AnswerTypeId = objQuestionnaireAddiENS.AnswerTypeId; //答案类型ID
objQuestionnaireAddiENT.GridTitle = objQuestionnaireAddiENS.GridTitle; //表格标题
objQuestionnaireAddiENT.AnswerModeId = objQuestionnaireAddiENS.AnswerModeId; //答案模式Id
objQuestionnaireAddiENT.IsHaveAdditionalMemo = objQuestionnaireAddiENS.IsHaveAdditionalMemo; //是否有附加说明
objQuestionnaireAddiENT.QuestionnaireSetId = objQuestionnaireAddiENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireAddiENT.QuestionScore = objQuestionnaireAddiENS.QuestionScore; //题目得分
objQuestionnaireAddiENT.QuestionNameAdd = objQuestionnaireAddiENS.QuestionNameAdd; //题目补充
objQuestionnaireAddiENT.DefaultValue = objQuestionnaireAddiENS.DefaultValue; //缺省值
objQuestionnaireAddiENT.TextDirectId = objQuestionnaireAddiENS.TextDirectId; //文本方向ID
objQuestionnaireAddiENT.FillInTextWidth = objQuestionnaireAddiENS.FillInTextWidth; //填空框宽度
objQuestionnaireAddiENT.MemoTextWidth = objQuestionnaireAddiENS.MemoTextWidth; //备注框宽度
objQuestionnaireAddiENT.CodeTab = objQuestionnaireAddiENS.CodeTab; //代码表
objQuestionnaireAddiENT.CodeTabCode = objQuestionnaireAddiENS.CodeTabCode; //CodeTab_Code
objQuestionnaireAddiENT.CodeTabName = objQuestionnaireAddiENS.CodeTabName; //CodeTab_Name
objQuestionnaireAddiENT.CodeTabCondition = objQuestionnaireAddiENS.CodeTabCondition; //代码表_条件
objQuestionnaireAddiENT.RelaEvent = objQuestionnaireAddiENS.RelaEvent; //相关事件
objQuestionnaireAddiENT.FirstIndent = objQuestionnaireAddiENS.FirstIndent; //首行缩进
objQuestionnaireAddiENT.DefaultSelectItem = objQuestionnaireAddiENS.DefaultSelectItem; //默认选项
objQuestionnaireAddiENT.IfLinkage = objQuestionnaireAddiENS.IfLinkage; //是否联动
objQuestionnaireAddiENT.LinkageIndex = objQuestionnaireAddiENS.LinkageIndex; //联动题序号
objQuestionnaireAddiENT.IsAutoGridTitle = objQuestionnaireAddiENS.IsAutoGridTitle; //是否自动编表格标题
objQuestionnaireAddiENT.FillInTextHeight = objQuestionnaireAddiENS.FillInTextHeight; //填空框高度
objQuestionnaireAddiENT.IsMulti4FillInText = objQuestionnaireAddiENS.IsMulti4FillInText; //是否填空框多行
objQuestionnaireAddiENT.CheckBoxLimitCount = objQuestionnaireAddiENS.CheckBoxLimitCount; //复选框限制数
objQuestionnaireAddiENT.RoleId = objQuestionnaireAddiENS.RoleId; //角色Id
objQuestionnaireAddiENT.IsShow = objQuestionnaireAddiENS.IsShow; //是否启用
objQuestionnaireAddiENT.IsCast = objQuestionnaireAddiENS.IsCast; //是否播放
objQuestionnaireAddiENT.LikeCount = objQuestionnaireAddiENS.LikeCount; //资源喜欢数量
objQuestionnaireAddiENT.AnswerAttLimitSize = objQuestionnaireAddiENS.AnswerAttLimitSize; //回答附件限制大小
objQuestionnaireAddiENT.LimitedResourceType = objQuestionnaireAddiENS.LimitedResourceType; //限制资源类型
objQuestionnaireAddiENT.IsEffective = objQuestionnaireAddiENS.IsEffective; //是否有效
objQuestionnaireAddiENT.IsCanInPaper = objQuestionnaireAddiENS.IsCanInPaper; //是否可在Paper
objQuestionnaireAddiENT.UpdDate = objQuestionnaireAddiENS.UpdDate; //修改日期
objQuestionnaireAddiENT.UpdUser = objQuestionnaireAddiENS.UpdUser; //修改人
objQuestionnaireAddiENT.Memo = objQuestionnaireAddiENS.Memo; //备注
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
 /// <param name = "objQuestionnaireAddiEN">源简化对象</param>
 public static void SetUpdFlag(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
try
{
objQuestionnaireAddiEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQuestionnaireAddiEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQuestionnaireAddi.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.QuestionId = objQuestionnaireAddiEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conQuestionnaireAddi.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.QuestionIndex = objQuestionnaireAddiEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(conQuestionnaireAddi.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.QuestionName = objQuestionnaireAddiEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(conQuestionnaireAddi.QuestionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.QuestionContent = objQuestionnaireAddiEN.QuestionContent == "[null]" ? null :  objQuestionnaireAddiEN.QuestionContent; //题目内容
}
if (arrFldSet.Contains(conQuestionnaireAddi.QuestionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.QuestionMemo = objQuestionnaireAddiEN.QuestionMemo == "[null]" ? null :  objQuestionnaireAddiEN.QuestionMemo; //题目说明
}
if (arrFldSet.Contains(conQuestionnaireAddi.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.QuestionNo = objQuestionnaireAddiEN.QuestionNo == "[null]" ? null :  objQuestionnaireAddiEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(conQuestionnaireAddi.ParentQuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.ParentQuestionId = objQuestionnaireAddiEN.ParentQuestionId == "[null]" ? null :  objQuestionnaireAddiEN.ParentQuestionId; //父题目Id
}
if (arrFldSet.Contains(conQuestionnaireAddi.ExamAnswer, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.ExamAnswer = objQuestionnaireAddiEN.ExamAnswer == "[null]" ? null :  objQuestionnaireAddiEN.ExamAnswer; //题目答案
}
if (arrFldSet.Contains(conQuestionnaireAddi.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.CourseId = objQuestionnaireAddiEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conQuestionnaireAddi.LevelNo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.LevelNo = objQuestionnaireAddiEN.LevelNo; //学习关号2
}
if (arrFldSet.Contains(conQuestionnaireAddi.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.CourseChapterId = objQuestionnaireAddiEN.CourseChapterId == "[null]" ? null :  objQuestionnaireAddiEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(conQuestionnaireAddi.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.QuestionTypeId = objQuestionnaireAddiEN.QuestionTypeId == "[null]" ? null :  objQuestionnaireAddiEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(conQuestionnaireAddi.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.QuestionTypeId4Course = objQuestionnaireAddiEN.QuestionTypeId4Course; //题目类型Id4课程
}
if (arrFldSet.Contains(conQuestionnaireAddi.ExamGradeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.ExamGradeId = objQuestionnaireAddiEN.ExamGradeId == "[null]" ? null :  objQuestionnaireAddiEN.ExamGradeId; //题库等级ID
}
if (arrFldSet.Contains(conQuestionnaireAddi.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.AnswerTypeId = objQuestionnaireAddiEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(conQuestionnaireAddi.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.GridTitle = objQuestionnaireAddiEN.GridTitle == "[null]" ? null :  objQuestionnaireAddiEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(conQuestionnaireAddi.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.AnswerModeId = objQuestionnaireAddiEN.AnswerModeId == "[null]" ? null :  objQuestionnaireAddiEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(conQuestionnaireAddi.IsHaveAdditionalMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.IsHaveAdditionalMemo = objQuestionnaireAddiEN.IsHaveAdditionalMemo; //是否有附加说明
}
if (arrFldSet.Contains(conQuestionnaireAddi.QuestionnaireSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.QuestionnaireSetId = objQuestionnaireAddiEN.QuestionnaireSetId == "[null]" ? null :  objQuestionnaireAddiEN.QuestionnaireSetId; //问卷集ID
}
if (arrFldSet.Contains(conQuestionnaireAddi.QuestionScore, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.QuestionScore = objQuestionnaireAddiEN.QuestionScore; //题目得分
}
if (arrFldSet.Contains(conQuestionnaireAddi.QuestionNameAdd, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.QuestionNameAdd = objQuestionnaireAddiEN.QuestionNameAdd == "[null]" ? null :  objQuestionnaireAddiEN.QuestionNameAdd; //题目补充
}
if (arrFldSet.Contains(conQuestionnaireAddi.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.DefaultValue = objQuestionnaireAddiEN.DefaultValue == "[null]" ? null :  objQuestionnaireAddiEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(conQuestionnaireAddi.TextDirectId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.TextDirectId = objQuestionnaireAddiEN.TextDirectId; //文本方向ID
}
if (arrFldSet.Contains(conQuestionnaireAddi.FillInTextWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.FillInTextWidth = objQuestionnaireAddiEN.FillInTextWidth; //填空框宽度
}
if (arrFldSet.Contains(conQuestionnaireAddi.MemoTextWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.MemoTextWidth = objQuestionnaireAddiEN.MemoTextWidth; //备注框宽度
}
if (arrFldSet.Contains(conQuestionnaireAddi.CodeTab, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.CodeTab = objQuestionnaireAddiEN.CodeTab == "[null]" ? null :  objQuestionnaireAddiEN.CodeTab; //代码表
}
if (arrFldSet.Contains(conQuestionnaireAddi.CodeTabCode, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.CodeTabCode = objQuestionnaireAddiEN.CodeTabCode == "[null]" ? null :  objQuestionnaireAddiEN.CodeTabCode; //CodeTab_Code
}
if (arrFldSet.Contains(conQuestionnaireAddi.CodeTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.CodeTabName = objQuestionnaireAddiEN.CodeTabName == "[null]" ? null :  objQuestionnaireAddiEN.CodeTabName; //CodeTab_Name
}
if (arrFldSet.Contains(conQuestionnaireAddi.CodeTabCondition, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.CodeTabCondition = objQuestionnaireAddiEN.CodeTabCondition == "[null]" ? null :  objQuestionnaireAddiEN.CodeTabCondition; //代码表_条件
}
if (arrFldSet.Contains(conQuestionnaireAddi.RelaEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.RelaEvent = objQuestionnaireAddiEN.RelaEvent == "[null]" ? null :  objQuestionnaireAddiEN.RelaEvent; //相关事件
}
if (arrFldSet.Contains(conQuestionnaireAddi.FirstIndent, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.FirstIndent = objQuestionnaireAddiEN.FirstIndent; //首行缩进
}
if (arrFldSet.Contains(conQuestionnaireAddi.DefaultSelectItem, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.DefaultSelectItem = objQuestionnaireAddiEN.DefaultSelectItem == "[null]" ? null :  objQuestionnaireAddiEN.DefaultSelectItem; //默认选项
}
if (arrFldSet.Contains(conQuestionnaireAddi.IfLinkage, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.IfLinkage = objQuestionnaireAddiEN.IfLinkage; //是否联动
}
if (arrFldSet.Contains(conQuestionnaireAddi.LinkageIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.LinkageIndex = objQuestionnaireAddiEN.LinkageIndex; //联动题序号
}
if (arrFldSet.Contains(conQuestionnaireAddi.IsAutoGridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.IsAutoGridTitle = objQuestionnaireAddiEN.IsAutoGridTitle; //是否自动编表格标题
}
if (arrFldSet.Contains(conQuestionnaireAddi.FillInTextHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.FillInTextHeight = objQuestionnaireAddiEN.FillInTextHeight; //填空框高度
}
if (arrFldSet.Contains(conQuestionnaireAddi.IsMulti4FillInText, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.IsMulti4FillInText = objQuestionnaireAddiEN.IsMulti4FillInText; //是否填空框多行
}
if (arrFldSet.Contains(conQuestionnaireAddi.CheckBoxLimitCount, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.CheckBoxLimitCount = objQuestionnaireAddiEN.CheckBoxLimitCount; //复选框限制数
}
if (arrFldSet.Contains(conQuestionnaireAddi.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.RoleId = objQuestionnaireAddiEN.RoleId == "[null]" ? null :  objQuestionnaireAddiEN.RoleId; //角色Id
}
if (arrFldSet.Contains(conQuestionnaireAddi.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.IsShow = objQuestionnaireAddiEN.IsShow; //是否启用
}
if (arrFldSet.Contains(conQuestionnaireAddi.IsCast, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.IsCast = objQuestionnaireAddiEN.IsCast; //是否播放
}
if (arrFldSet.Contains(conQuestionnaireAddi.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.LikeCount = objQuestionnaireAddiEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(conQuestionnaireAddi.AnswerAttLimitSize, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.AnswerAttLimitSize = objQuestionnaireAddiEN.AnswerAttLimitSize; //回答附件限制大小
}
if (arrFldSet.Contains(conQuestionnaireAddi.LimitedResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.LimitedResourceType = objQuestionnaireAddiEN.LimitedResourceType == "[null]" ? null :  objQuestionnaireAddiEN.LimitedResourceType; //限制资源类型
}
if (arrFldSet.Contains(conQuestionnaireAddi.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.IsEffective = objQuestionnaireAddiEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(conQuestionnaireAddi.IsCanInPaper, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.IsCanInPaper = objQuestionnaireAddiEN.IsCanInPaper; //是否可在Paper
}
if (arrFldSet.Contains(conQuestionnaireAddi.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.UpdDate = objQuestionnaireAddiEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQuestionnaireAddi.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.UpdUser = objQuestionnaireAddiEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conQuestionnaireAddi.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireAddiEN.Memo = objQuestionnaireAddiEN.Memo == "[null]" ? null :  objQuestionnaireAddiEN.Memo; //备注
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
 /// <param name = "objQuestionnaireAddiEN">源简化对象</param>
 public static void AccessFldValueNull(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
try
{
if (objQuestionnaireAddiEN.QuestionContent == "[null]") objQuestionnaireAddiEN.QuestionContent = null; //题目内容
if (objQuestionnaireAddiEN.QuestionMemo == "[null]") objQuestionnaireAddiEN.QuestionMemo = null; //题目说明
if (objQuestionnaireAddiEN.QuestionNo == "[null]") objQuestionnaireAddiEN.QuestionNo = null; //题目编号
if (objQuestionnaireAddiEN.ParentQuestionId == "[null]") objQuestionnaireAddiEN.ParentQuestionId = null; //父题目Id
if (objQuestionnaireAddiEN.ExamAnswer == "[null]") objQuestionnaireAddiEN.ExamAnswer = null; //题目答案
if (objQuestionnaireAddiEN.CourseChapterId == "[null]") objQuestionnaireAddiEN.CourseChapterId = null; //课程章节ID
if (objQuestionnaireAddiEN.QuestionTypeId == "[null]") objQuestionnaireAddiEN.QuestionTypeId = null; //题目类型Id
if (objQuestionnaireAddiEN.ExamGradeId == "[null]") objQuestionnaireAddiEN.ExamGradeId = null; //题库等级ID
if (objQuestionnaireAddiEN.GridTitle == "[null]") objQuestionnaireAddiEN.GridTitle = null; //表格标题
if (objQuestionnaireAddiEN.AnswerModeId == "[null]") objQuestionnaireAddiEN.AnswerModeId = null; //答案模式Id
if (objQuestionnaireAddiEN.QuestionnaireSetId == "[null]") objQuestionnaireAddiEN.QuestionnaireSetId = null; //问卷集ID
if (objQuestionnaireAddiEN.QuestionNameAdd == "[null]") objQuestionnaireAddiEN.QuestionNameAdd = null; //题目补充
if (objQuestionnaireAddiEN.DefaultValue == "[null]") objQuestionnaireAddiEN.DefaultValue = null; //缺省值
if (objQuestionnaireAddiEN.CodeTab == "[null]") objQuestionnaireAddiEN.CodeTab = null; //代码表
if (objQuestionnaireAddiEN.CodeTabCode == "[null]") objQuestionnaireAddiEN.CodeTabCode = null; //CodeTab_Code
if (objQuestionnaireAddiEN.CodeTabName == "[null]") objQuestionnaireAddiEN.CodeTabName = null; //CodeTab_Name
if (objQuestionnaireAddiEN.CodeTabCondition == "[null]") objQuestionnaireAddiEN.CodeTabCondition = null; //代码表_条件
if (objQuestionnaireAddiEN.RelaEvent == "[null]") objQuestionnaireAddiEN.RelaEvent = null; //相关事件
if (objQuestionnaireAddiEN.DefaultSelectItem == "[null]") objQuestionnaireAddiEN.DefaultSelectItem = null; //默认选项
if (objQuestionnaireAddiEN.RoleId == "[null]") objQuestionnaireAddiEN.RoleId = null; //角色Id
if (objQuestionnaireAddiEN.LimitedResourceType == "[null]") objQuestionnaireAddiEN.LimitedResourceType = null; //限制资源类型
if (objQuestionnaireAddiEN.Memo == "[null]") objQuestionnaireAddiEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
 QuestionnaireAddiDA.CheckPropertyNew(objQuestionnaireAddiEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
 QuestionnaireAddiDA.CheckProperty4Condition(objQuestionnaireAddiEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindCbo_QuestionId(System.Windows.Forms.ComboBox objComboBox , string strCourseId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQuestionnaireAddi.QuestionId); 
List<clsQuestionnaireAddiEN> arrObjLst = clsQuestionnaireAddiBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN()
{
QuestionId = 0,
QuestionName = "选[题目附加]..."
};
arrObjLstSel.Insert(0, objQuestionnaireAddiEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQuestionnaireAddi.QuestionId;
objComboBox.DisplayMember = conQuestionnaireAddi.QuestionName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindDdl_QuestionId(System.Web.UI.WebControls.DropDownList objDDL , string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目附加]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQuestionnaireAddi.QuestionId); 
IEnumerable<clsQuestionnaireAddiEN> arrObjLst = clsQuestionnaireAddiBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = conQuestionnaireAddi.QuestionId;
objDDL.DataTextField = conQuestionnaireAddi.QuestionName;
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
public static void BindDdl_QuestionIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目附加]...","0");
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst = GetAllQuestionnaireAddiObjLstCache(strCourseId); 
objDDL.DataValueField = conQuestionnaireAddi.QuestionId;
objDDL.DataTextField = conQuestionnaireAddi.QuestionName;
objDDL.DataSource = arrQuestionnaireAddiObjLst;
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
if (clsQuestionnaireAddiBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireAddiBL没有刷新缓存机制(clsQuestionnaireAddiBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionId");
//if (arrQuestionnaireAddiObjLstCache == null)
//{
//arrQuestionnaireAddiObjLstCache = QuestionnaireAddiDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionnaireAddiEN GetObjByQuestionIdCache(long lngQuestionId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName, strCourseId);
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel =
arrQuestionnaireAddiObjLstCache
.Where(x=> x.QuestionId == lngQuestionId 
);
if (arrQuestionnaireAddiObjLst_Sel.Count() == 0)
{
   clsQuestionnaireAddiEN obj = clsQuestionnaireAddiBL.GetObjByQuestionId(lngQuestionId);
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
return arrQuestionnaireAddiObjLst_Sel.First();
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
clsQuestionnaireAddiEN objQuestionnaireAddi = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objQuestionnaireAddi == null) return "";
return objQuestionnaireAddi.QuestionName;
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
clsQuestionnaireAddiEN objQuestionnaireAddi = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objQuestionnaireAddi == null) return "";
return objQuestionnaireAddi.QuestionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireAddiEN> GetAllQuestionnaireAddiObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLstCache = GetObjLstCache(strCourseId); 
return arrQuestionnaireAddiObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireAddiEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrQuestionnaireAddiObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:CourseId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrQuestionnaireAddiObjLst">需要排序的对象列表</param>
public static List <clsQuestionnaireAddiEN> GetSubSet4QuestionnaireAddiObjLstByCourseIdCache(string strCourseId)
{
   if (string.IsNullOrEmpty(strCourseId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName, strCourseId);
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel1 =
from objQuestionnaireAddiEN in arrQuestionnaireAddiObjLstCache
where objQuestionnaireAddiEN.CourseId == strCourseId
select objQuestionnaireAddiEN;
List <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel = new List<clsQuestionnaireAddiEN>();
foreach (clsQuestionnaireAddiEN obj in arrQuestionnaireAddiObjLst_Sel1)
{
arrQuestionnaireAddiObjLst_Sel.Add(obj);
}
return arrQuestionnaireAddiObjLst_Sel;
}
 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:QuestionTypeId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrQuestionnaireAddiObjLst">需要排序的对象列表</param>
public static List <clsQuestionnaireAddiEN> GetSubSet4QuestionnaireAddiObjLstByQuestionTypeIdCache(string strQuestionTypeId, string strCourseId)
{
   if (string.IsNullOrEmpty(strQuestionTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName, strCourseId);
List<clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel1 =
from objQuestionnaireAddiEN in arrQuestionnaireAddiObjLstCache
where objQuestionnaireAddiEN.QuestionTypeId == strQuestionTypeId
select objQuestionnaireAddiEN;
List <clsQuestionnaireAddiEN> arrQuestionnaireAddiObjLst_Sel = new List<clsQuestionnaireAddiEN>();
foreach (clsQuestionnaireAddiEN obj in arrQuestionnaireAddiObjLst_Sel1)
{
arrQuestionnaireAddiObjLst_Sel.Add(obj);
}
return arrQuestionnaireAddiObjLst_Sel;
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
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsQuestionnaireAddiEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQuestionnaireAddiEN._RefreshTimeLst.Count == 0) return "";
return clsQuestionnaireAddiEN._RefreshTimeLst[clsQuestionnaireAddiEN._RefreshTimeLst.Count - 1];
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
if (clsQuestionnaireAddiBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQuestionnaireAddiEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsQuestionnaireAddiEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQuestionnaireAddiBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
if (strInFldName != conQuestionnaireAddi.QuestionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQuestionnaireAddi.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQuestionnaireAddi.AttributeName));
throw new Exception(strMsg);
}
var objQuestionnaireAddi = clsQuestionnaireAddiBL.GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objQuestionnaireAddi == null) return "";
return objQuestionnaireAddi[strOutFldName].ToString();
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
int intRecCount = clsQuestionnaireAddiDA.GetRecCount(strTabName);
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
int intRecCount = clsQuestionnaireAddiDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQuestionnaireAddiDA.GetRecCount();
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
int intRecCount = clsQuestionnaireAddiDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQuestionnaireAddiCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQuestionnaireAddiEN objQuestionnaireAddiCond)
{
 string strCourseId = objQuestionnaireAddiCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsQuestionnaireAddiBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsQuestionnaireAddiEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsQuestionnaireAddiEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionnaireAddi.AttributeName)
{
if (objQuestionnaireAddiCond.IsUpdated(strFldName) == false) continue;
if (objQuestionnaireAddiCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireAddiCond[strFldName].ToString());
}
else
{
if (objQuestionnaireAddiCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionnaireAddiCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireAddiCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionnaireAddiCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionnaireAddiCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionnaireAddiCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionnaireAddiCond[strFldName]));
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
 List<string> arrList = clsQuestionnaireAddiDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QuestionnaireAddiDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QuestionnaireAddiDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QuestionnaireAddiDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionnaireAddiDA.SetFldValue(clsQuestionnaireAddiEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QuestionnaireAddiDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionnaireAddiDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionnaireAddiDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionnaireAddiDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QuestionnaireAddi] "); 
 strCreateTabCode.Append(" ( "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint primary key, "); 
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
 strCreateTabCode.Append(" QuestionTypeId4Course char(8) not Null, "); 
 // /**题库等级ID*/ 
 strCreateTabCode.Append(" ExamGradeId char(2) Null, "); 
 // /**答案类型ID*/ 
 strCreateTabCode.Append(" AnswerTypeId char(2) not Null, "); 
 // /**表格标题*/ 
 strCreateTabCode.Append(" GridTitle varchar(30) Null, "); 
 // /**答案模式Id*/ 
 strCreateTabCode.Append(" AnswerModeId char(4) Null, "); 
 // /**是否有附加说明*/ 
 strCreateTabCode.Append(" IsHaveAdditionalMemo bit Null, "); 
 // /**问卷集ID*/ 
 strCreateTabCode.Append(" QuestionnaireSetId char(4) Null, "); 
 // /**题目得分*/ 
 strCreateTabCode.Append(" QuestionScore float Null, "); 
 // /**题目补充*/ 
 strCreateTabCode.Append(" QuestionNameAdd varchar(500) Null, "); 
 // /**缺省值*/ 
 strCreateTabCode.Append(" DefaultValue varchar(50) Null, "); 
 // /**文本方向ID*/ 
 strCreateTabCode.Append(" TextDirectId char(4) not Null, "); 
 // /**填空框宽度*/ 
 strCreateTabCode.Append(" FillInTextWidth int Null, "); 
 // /**备注框宽度*/ 
 strCreateTabCode.Append(" MemoTextWidth int Null, "); 
 // /**代码表*/ 
 strCreateTabCode.Append(" CodeTab varchar(50) Null, "); 
 // /**CodeTab_Code*/ 
 strCreateTabCode.Append(" CodeTabCode varchar(50) Null, "); 
 // /**CodeTab_Name*/ 
 strCreateTabCode.Append(" CodeTabName varchar(50) Null, "); 
 // /**代码表_条件*/ 
 strCreateTabCode.Append(" CodeTabCondition varchar(200) Null, "); 
 // /**相关事件*/ 
 strCreateTabCode.Append(" RelaEvent varchar(4000) Null, "); 
 // /**首行缩进*/ 
 strCreateTabCode.Append(" FirstIndent bit Null, "); 
 // /**默认选项*/ 
 strCreateTabCode.Append(" DefaultSelectItem varchar(20) Null, "); 
 // /**是否联动*/ 
 strCreateTabCode.Append(" IfLinkage bit Null, "); 
 // /**联动题序号*/ 
 strCreateTabCode.Append(" LinkageIndex int Null, "); 
 // /**是否自动编表格标题*/ 
 strCreateTabCode.Append(" IsAutoGridTitle bit Null, "); 
 // /**填空框高度*/ 
 strCreateTabCode.Append(" FillInTextHeight int Null, "); 
 // /**是否填空框多行*/ 
 strCreateTabCode.Append(" IsMulti4FillInText bit Null, "); 
 // /**复选框限制数*/ 
 strCreateTabCode.Append(" CheckBoxLimitCount int Null, "); 
 // /**角色Id*/ 
 strCreateTabCode.Append(" RoleId char(8) Null, "); 
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
}
 /// <summary>
 /// 题目附加(QuestionnaireAddi)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QuestionnaireAddi : clsCommFun4BLV2
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
clsQuestionnaireAddiBL.ReFreshThisCache(strCourseId);
}
}

}