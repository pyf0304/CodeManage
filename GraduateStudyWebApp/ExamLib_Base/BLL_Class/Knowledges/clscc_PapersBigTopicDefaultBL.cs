﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PapersBigTopicDefaultBL
 表名:cc_PapersBigTopicDefault(01120088)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:32
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
public static class  clscc_PapersBigTopicDefaultBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPapersBigTopicDefaultId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PapersBigTopicDefaultEN GetObj(this K_PapersBigTopicDefaultId_cc_PapersBigTopicDefault myKey)
{
clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.GetObjByPapersBigTopicDefaultId(myKey.Value);
return objcc_PapersBigTopicDefaultEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_PapersBigTopicDefaultEN) == false)
{
var strMsg = string.Format("记录已经存在!试卷大题目名称 = [{0}]的数据已经存在!(in clscc_PapersBigTopicDefaultBL.AddNewRecord)", objcc_PapersBigTopicDefaultEN.PapersBigTopicName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true || clscc_PapersBigTopicDefaultBL.IsExist(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
     objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = clscc_PapersBigTopicDefaultBL.GetMaxStrId_S();
 }
bool bolResult = clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.AddNewRecordBySQL2(objcc_PapersBigTopicDefaultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
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
public static bool AddRecordEx(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clscc_PapersBigTopicDefaultBL.IsExist(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objcc_PapersBigTopicDefaultEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_PapersBigTopicDefaultEN.CheckUniqueness() == false)
{
strMsg = string.Format("(试卷大题目名称(PapersBigTopicName)=[{0}])已经存在,不能重复!", objcc_PapersBigTopicDefaultEN.PapersBigTopicName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true || clscc_PapersBigTopicDefaultBL.IsExist(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
     objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = clscc_PapersBigTopicDefaultBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objcc_PapersBigTopicDefaultEN.AddNewRecord();
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_PapersBigTopicDefaultEN) == false)
{
var strMsg = string.Format("记录已经存在!试卷大题目名称 = [{0}]的数据已经存在!(in clscc_PapersBigTopicDefaultBL.AddNewRecordWithMaxId)", objcc_PapersBigTopicDefaultEN.PapersBigTopicName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true || clscc_PapersBigTopicDefaultBL.IsExist(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
     objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = clscc_PapersBigTopicDefaultBL.GetMaxStrId_S();
 }
string strPapersBigTopicDefaultId = clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.AddNewRecordBySQL2WithReturnKey(objcc_PapersBigTopicDefaultEN);
     objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = strPapersBigTopicDefaultId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
}
return strPapersBigTopicDefaultId;
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_PapersBigTopicDefaultEN) == false)
{
var strMsg = string.Format("记录已经存在!试卷大题目名称 = [{0}]的数据已经存在!(in clscc_PapersBigTopicDefaultBL.AddNewRecordWithReturnKey)", objcc_PapersBigTopicDefaultEN.PapersBigTopicName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true || clscc_PapersBigTopicDefaultBL.IsExist(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
     objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = clscc_PapersBigTopicDefaultBL.GetMaxStrId_S();
 }
string strKey = clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.AddNewRecordBySQL2WithReturnKey(objcc_PapersBigTopicDefaultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetPapersBigTopicDefaultId(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strPapersBigTopicDefaultId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicDefaultId, 8, concc_PapersBigTopicDefault.PapersBigTopicDefaultId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicDefaultId, 8, concc_PapersBigTopicDefault.PapersBigTopicDefaultId);
}
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = strPapersBigTopicDefaultId; //PapersBigTopicDefaultId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.PapersBigTopicDefaultId) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.PapersBigTopicDefaultId, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.PapersBigTopicDefaultId] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetQuestionTypeId(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId, concc_PapersBigTopicDefault.QuestionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, concc_PapersBigTopicDefault.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, concc_PapersBigTopicDefault.QuestionTypeId);
}
objcc_PapersBigTopicDefaultEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.QuestionTypeId) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.QuestionTypeId, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.QuestionTypeId] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetPapersBigTopicName(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strPapersBigTopicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPapersBigTopicName, concc_PapersBigTopicDefault.PapersBigTopicName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, concc_PapersBigTopicDefault.PapersBigTopicName);
}
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = strPapersBigTopicName; //试卷大题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.PapersBigTopicName) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.PapersBigTopicName, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.PapersBigTopicName] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetTopicDescription(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strTopicDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, concc_PapersBigTopicDefault.TopicDescription);
}
objcc_PapersBigTopicDefaultEN.TopicDescription = strTopicDescription; //标题描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.TopicDescription) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.TopicDescription, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.TopicDescription] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetTopicScores(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, int? intTopicScores, string strComparisonOp="")
	{
objcc_PapersBigTopicDefaultEN.TopicScores = intTopicScores; //大题得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.TopicScores) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.TopicScores, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.TopicScores] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetUpdDate(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_PapersBigTopicDefault.UpdDate);
}
objcc_PapersBigTopicDefaultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.UpdDate) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.UpdDate, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.UpdDate] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetUpdUser(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_PapersBigTopicDefault.UpdUser);
}
objcc_PapersBigTopicDefaultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.UpdUser) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.UpdUser, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.UpdUser] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetMemo(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_PapersBigTopicDefault.Memo);
}
objcc_PapersBigTopicDefaultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.Memo) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.Memo, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.Memo] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_PapersBigTopicDefaultEN.CheckPropertyNew();
clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultCond = new clscc_PapersBigTopicDefaultEN();
string strCondition = objcc_PapersBigTopicDefaultCond
.SetPapersBigTopicDefaultId(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, "<>")
.SetPapersBigTopicName(objcc_PapersBigTopicDefaultEN.PapersBigTopicName, "=")
.GetCombineCondition();
objcc_PapersBigTopicDefaultEN._IsCheckProperty = true;
bool bolIsExist = clscc_PapersBigTopicDefaultBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PapersBigTopicName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_PapersBigTopicDefaultEN.Update();
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
 /// <param name = "objcc_PapersBigTopicDefault">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefault)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultCond = new clscc_PapersBigTopicDefaultEN();
string strCondition = objcc_PapersBigTopicDefaultCond
.SetPapersBigTopicName(objcc_PapersBigTopicDefault.PapersBigTopicName, "=")
.GetCombineCondition();
objcc_PapersBigTopicDefault._IsCheckProperty = true;
bool bolIsExist = clscc_PapersBigTopicDefaultBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_PapersBigTopicDefault.PapersBigTopicDefaultId = clscc_PapersBigTopicDefaultBL.GetFirstID_S(strCondition);
objcc_PapersBigTopicDefault.UpdateWithCondition(strCondition);
}
else
{
objcc_PapersBigTopicDefault.PapersBigTopicDefaultId = clscc_PapersBigTopicDefaultBL.GetMaxStrId_S();
objcc_PapersBigTopicDefault.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.UpdateBySql2(objcc_PapersBigTopicDefaultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.UpdateBySql2(objcc_PapersBigTopicDefaultEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strWhereCond)
{
try
{
bool bolResult = clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.UpdateBySqlWithCondition(objcc_PapersBigTopicDefaultEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.UpdateBySqlWithConditionTransaction(objcc_PapersBigTopicDefaultEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
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
 /// <param name = "strPapersBigTopicDefaultId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
try
{
int intRecNum = clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.DelRecord(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicDefaultENS">源对象</param>
 /// <param name = "objcc_PapersBigTopicDefaultENT">目标对象</param>
 public static void CopyTo(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultENS, clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultENT)
{
try
{
objcc_PapersBigTopicDefaultENT.PapersBigTopicDefaultId = objcc_PapersBigTopicDefaultENS.PapersBigTopicDefaultId; //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultENT.QuestionTypeId = objcc_PapersBigTopicDefaultENS.QuestionTypeId; //题目类型Id
objcc_PapersBigTopicDefaultENT.PapersBigTopicName = objcc_PapersBigTopicDefaultENS.PapersBigTopicName; //试卷大题目名称
objcc_PapersBigTopicDefaultENT.TopicDescription = objcc_PapersBigTopicDefaultENS.TopicDescription; //标题描述
objcc_PapersBigTopicDefaultENT.TopicScores = objcc_PapersBigTopicDefaultENS.TopicScores; //大题得分
objcc_PapersBigTopicDefaultENT.UpdDate = objcc_PapersBigTopicDefaultENS.UpdDate; //修改日期
objcc_PapersBigTopicDefaultENT.UpdUser = objcc_PapersBigTopicDefaultENS.UpdUser; //修改人
objcc_PapersBigTopicDefaultENT.Memo = objcc_PapersBigTopicDefaultENS.Memo; //备注
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
 /// <param name = "objcc_PapersBigTopicDefaultENS">源对象</param>
 /// <returns>目标对象=>clscc_PapersBigTopicDefaultEN:objcc_PapersBigTopicDefaultENT</returns>
 public static clscc_PapersBigTopicDefaultEN CopyTo(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultENS)
{
try
{
 clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultENT = new clscc_PapersBigTopicDefaultEN()
{
PapersBigTopicDefaultId = objcc_PapersBigTopicDefaultENS.PapersBigTopicDefaultId, //PapersBigTopicDefaultId
QuestionTypeId = objcc_PapersBigTopicDefaultENS.QuestionTypeId, //题目类型Id
PapersBigTopicName = objcc_PapersBigTopicDefaultENS.PapersBigTopicName, //试卷大题目名称
TopicDescription = objcc_PapersBigTopicDefaultENS.TopicDescription, //标题描述
TopicScores = objcc_PapersBigTopicDefaultENS.TopicScores, //大题得分
UpdDate = objcc_PapersBigTopicDefaultENS.UpdDate, //修改日期
UpdUser = objcc_PapersBigTopicDefaultENS.UpdUser, //修改人
Memo = objcc_PapersBigTopicDefaultENS.Memo, //备注
};
 return objcc_PapersBigTopicDefaultENT;
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
public static void CheckPropertyNew(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
 clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.CheckPropertyNew(objcc_PapersBigTopicDefaultEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
 clscc_PapersBigTopicDefaultBL.cc_PapersBigTopicDefaultDA.CheckProperty4Condition(objcc_PapersBigTopicDefaultEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_PapersBigTopicDefaultCond.IsUpdated(concc_PapersBigTopicDefault.PapersBigTopicDefaultId) == true)
{
string strComparisonOpPapersBigTopicDefaultId = objcc_PapersBigTopicDefaultCond.dicFldComparisonOp[concc_PapersBigTopicDefault.PapersBigTopicDefaultId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultCond.PapersBigTopicDefaultId, strComparisonOpPapersBigTopicDefaultId);
}
if (objcc_PapersBigTopicDefaultCond.IsUpdated(concc_PapersBigTopicDefault.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objcc_PapersBigTopicDefaultCond.dicFldComparisonOp[concc_PapersBigTopicDefault.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.QuestionTypeId, objcc_PapersBigTopicDefaultCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objcc_PapersBigTopicDefaultCond.IsUpdated(concc_PapersBigTopicDefault.PapersBigTopicName) == true)
{
string strComparisonOpPapersBigTopicName = objcc_PapersBigTopicDefaultCond.dicFldComparisonOp[concc_PapersBigTopicDefault.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.PapersBigTopicName, objcc_PapersBigTopicDefaultCond.PapersBigTopicName, strComparisonOpPapersBigTopicName);
}
if (objcc_PapersBigTopicDefaultCond.IsUpdated(concc_PapersBigTopicDefault.TopicDescription) == true)
{
string strComparisonOpTopicDescription = objcc_PapersBigTopicDefaultCond.dicFldComparisonOp[concc_PapersBigTopicDefault.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.TopicDescription, objcc_PapersBigTopicDefaultCond.TopicDescription, strComparisonOpTopicDescription);
}
if (objcc_PapersBigTopicDefaultCond.IsUpdated(concc_PapersBigTopicDefault.TopicScores) == true)
{
string strComparisonOpTopicScores = objcc_PapersBigTopicDefaultCond.dicFldComparisonOp[concc_PapersBigTopicDefault.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PapersBigTopicDefault.TopicScores, objcc_PapersBigTopicDefaultCond.TopicScores, strComparisonOpTopicScores);
}
if (objcc_PapersBigTopicDefaultCond.IsUpdated(concc_PapersBigTopicDefault.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_PapersBigTopicDefaultCond.dicFldComparisonOp[concc_PapersBigTopicDefault.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.UpdDate, objcc_PapersBigTopicDefaultCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_PapersBigTopicDefaultCond.IsUpdated(concc_PapersBigTopicDefault.UpdUser) == true)
{
string strComparisonOpUpdUser = objcc_PapersBigTopicDefaultCond.dicFldComparisonOp[concc_PapersBigTopicDefault.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.UpdUser, objcc_PapersBigTopicDefaultCond.UpdUser, strComparisonOpUpdUser);
}
if (objcc_PapersBigTopicDefaultCond.IsUpdated(concc_PapersBigTopicDefault.Memo) == true)
{
string strComparisonOpMemo = objcc_PapersBigTopicDefaultCond.dicFldComparisonOp[concc_PapersBigTopicDefault.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.Memo, objcc_PapersBigTopicDefaultCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_PapersBigTopicDefault(试卷大题目默认), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PapersBigTopicName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_PapersBigTopicDefaultEN == null) return true;
if (objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId == null || objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PapersBigTopicName = '{0}'", objcc_PapersBigTopicDefaultEN.PapersBigTopicName);
if (clscc_PapersBigTopicDefaultBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PapersBigTopicDefaultId !=  '{0}'", objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId);
 sbCondition.AppendFormat(" and PapersBigTopicName = '{0}'", objcc_PapersBigTopicDefaultEN.PapersBigTopicName);
if (clscc_PapersBigTopicDefaultBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_PapersBigTopicDefault(试卷大题目默认), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PapersBigTopicName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_PapersBigTopicDefaultEN == null) return "";
if (objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId == null || objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PapersBigTopicName = '{0}'", objcc_PapersBigTopicDefaultEN.PapersBigTopicName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PapersBigTopicDefaultId !=  '{0}'", objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId);
 sbCondition.AppendFormat(" and PapersBigTopicName = '{0}'", objcc_PapersBigTopicDefaultEN.PapersBigTopicName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_PapersBigTopicDefault
{
public virtual bool UpdRelaTabDate(string strPapersBigTopicDefaultId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 试卷大题目默认(cc_PapersBigTopicDefault)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_PapersBigTopicDefaultBL
{
public static RelatedActions_cc_PapersBigTopicDefault relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_PapersBigTopicDefaultDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_PapersBigTopicDefaultDA cc_PapersBigTopicDefaultDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_PapersBigTopicDefaultDA();
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
 public clscc_PapersBigTopicDefaultBL()
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
if (string.IsNullOrEmpty(clscc_PapersBigTopicDefaultEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_PapersBigTopicDefaultEN._ConnectString);
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
public static DataTable GetDataTable_cc_PapersBigTopicDefault(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_PapersBigTopicDefaultDA.GetDataTable_cc_PapersBigTopicDefault(strWhereCond);
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
objDT = cc_PapersBigTopicDefaultDA.GetDataTable(strWhereCond);
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
objDT = cc_PapersBigTopicDefaultDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_PapersBigTopicDefaultDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_PapersBigTopicDefaultDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_PapersBigTopicDefaultDA.GetDataTable_Top(objTopPara);
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
objDT = cc_PapersBigTopicDefaultDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_PapersBigTopicDefaultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_PapersBigTopicDefaultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPapersBigTopicDefaultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstByPapersBigTopicDefaultIdLst(List<string> arrPapersBigTopicDefaultIdLst)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLst = new List<clscc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPapersBigTopicDefaultIdLst, true);
 string strWhereCond = string.Format("PapersBigTopicDefaultId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = new clscc_PapersBigTopicDefaultEN();
try
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[concc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[concc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[concc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicDefaultEN.TopicDescription = objRow[concc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicDefaultEN.TopicScores = objRow[concc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicDefaultEN.UpdDate = objRow[concc_PapersBigTopicDefault.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicDefaultEN.UpdUser = objRow[concc_PapersBigTopicDefault.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicDefaultEN.Memo = objRow[concc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicDefaultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPapersBigTopicDefaultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_PapersBigTopicDefaultEN> GetObjLstByPapersBigTopicDefaultIdLstCache(List<string> arrPapersBigTopicDefaultIdLst)
{
string strKey = string.Format("{0}", clscc_PapersBigTopicDefaultEN._CurrTabName);
List<clscc_PapersBigTopicDefaultEN> arrcc_PapersBigTopicDefaultObjLstCache = GetObjLstCache();
IEnumerable <clscc_PapersBigTopicDefaultEN> arrcc_PapersBigTopicDefaultObjLst_Sel =
arrcc_PapersBigTopicDefaultObjLstCache
.Where(x => arrPapersBigTopicDefaultIdLst.Contains(x.PapersBigTopicDefaultId));
return arrcc_PapersBigTopicDefaultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PapersBigTopicDefaultEN> GetObjLst(string strWhereCond)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLst = new List<clscc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = new clscc_PapersBigTopicDefaultEN();
try
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[concc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[concc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[concc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicDefaultEN.TopicDescription = objRow[concc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicDefaultEN.TopicScores = objRow[concc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicDefaultEN.UpdDate = objRow[concc_PapersBigTopicDefault.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicDefaultEN.UpdUser = objRow[concc_PapersBigTopicDefault.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicDefaultEN.Memo = objRow[concc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicDefaultEN);
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
public static List<clscc_PapersBigTopicDefaultEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLst = new List<clscc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = new clscc_PapersBigTopicDefaultEN();
try
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[concc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[concc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[concc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicDefaultEN.TopicDescription = objRow[concc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicDefaultEN.TopicScores = objRow[concc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicDefaultEN.UpdDate = objRow[concc_PapersBigTopicDefault.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicDefaultEN.UpdUser = objRow[concc_PapersBigTopicDefault.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicDefaultEN.Memo = objRow[concc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicDefaultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_PapersBigTopicDefaultEN> GetSubObjLstCache(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultCond)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_PapersBigTopicDefaultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_PapersBigTopicDefault.AttributeName)
{
if (objcc_PapersBigTopicDefaultCond.IsUpdated(strFldName) == false) continue;
if (objcc_PapersBigTopicDefaultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PapersBigTopicDefaultCond[strFldName].ToString());
}
else
{
if (objcc_PapersBigTopicDefaultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_PapersBigTopicDefaultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PapersBigTopicDefaultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_PapersBigTopicDefaultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_PapersBigTopicDefaultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_PapersBigTopicDefaultCond[strFldName]));
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
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLst = new List<clscc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = new clscc_PapersBigTopicDefaultEN();
try
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[concc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[concc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[concc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicDefaultEN.TopicDescription = objRow[concc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicDefaultEN.TopicScores = objRow[concc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicDefaultEN.UpdDate = objRow[concc_PapersBigTopicDefault.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicDefaultEN.UpdUser = objRow[concc_PapersBigTopicDefault.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicDefaultEN.Memo = objRow[concc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicDefaultEN);
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
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLst = new List<clscc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = new clscc_PapersBigTopicDefaultEN();
try
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[concc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[concc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[concc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicDefaultEN.TopicDescription = objRow[concc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicDefaultEN.TopicScores = objRow[concc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicDefaultEN.UpdDate = objRow[concc_PapersBigTopicDefault.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicDefaultEN.UpdUser = objRow[concc_PapersBigTopicDefault.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicDefaultEN.Memo = objRow[concc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicDefaultEN);
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
List<clscc_PapersBigTopicDefaultEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_PapersBigTopicDefaultEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PapersBigTopicDefaultEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_PapersBigTopicDefaultEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLst = new List<clscc_PapersBigTopicDefaultEN>(); 
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
	clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = new clscc_PapersBigTopicDefaultEN();
try
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[concc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[concc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[concc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicDefaultEN.TopicDescription = objRow[concc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicDefaultEN.TopicScores = objRow[concc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicDefaultEN.UpdDate = objRow[concc_PapersBigTopicDefault.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicDefaultEN.UpdUser = objRow[concc_PapersBigTopicDefault.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicDefaultEN.Memo = objRow[concc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicDefaultEN);
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
public static List<clscc_PapersBigTopicDefaultEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLst = new List<clscc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = new clscc_PapersBigTopicDefaultEN();
try
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[concc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[concc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[concc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicDefaultEN.TopicDescription = objRow[concc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicDefaultEN.TopicScores = objRow[concc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicDefaultEN.UpdDate = objRow[concc_PapersBigTopicDefault.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicDefaultEN.UpdUser = objRow[concc_PapersBigTopicDefault.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicDefaultEN.Memo = objRow[concc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicDefaultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLst = new List<clscc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = new clscc_PapersBigTopicDefaultEN();
try
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[concc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[concc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[concc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicDefaultEN.TopicDescription = objRow[concc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicDefaultEN.TopicScores = objRow[concc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicDefaultEN.UpdDate = objRow[concc_PapersBigTopicDefault.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicDefaultEN.UpdUser = objRow[concc_PapersBigTopicDefault.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicDefaultEN.Memo = objRow[concc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicDefaultEN);
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
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLst = new List<clscc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = new clscc_PapersBigTopicDefaultEN();
try
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[concc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[concc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[concc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicDefaultEN.TopicDescription = objRow[concc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicDefaultEN.TopicScores = objRow[concc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicDefaultEN.UpdDate = objRow[concc_PapersBigTopicDefault.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicDefaultEN.UpdUser = objRow[concc_PapersBigTopicDefault.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicDefaultEN.Memo = objRow[concc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicDefaultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLst = new List<clscc_PapersBigTopicDefaultEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = new clscc_PapersBigTopicDefaultEN();
try
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[concc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[concc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[concc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicDefaultEN.TopicDescription = objRow[concc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicDefaultEN.TopicScores = objRow[concc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicDefaultEN.UpdDate = objRow[concc_PapersBigTopicDefault.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicDefaultEN.UpdUser = objRow[concc_PapersBigTopicDefault.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicDefaultEN.Memo = objRow[concc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PapersBigTopicDefaultEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_PapersBigTopicDefault(ref clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
bool bolResult = cc_PapersBigTopicDefaultDA.Getcc_PapersBigTopicDefault(ref objcc_PapersBigTopicDefaultEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPapersBigTopicDefaultId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultId(string strPapersBigTopicDefaultId)
{
if (strPapersBigTopicDefaultId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPapersBigTopicDefaultId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPapersBigTopicDefaultId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPapersBigTopicDefaultId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = cc_PapersBigTopicDefaultDA.GetObjByPapersBigTopicDefaultId(strPapersBigTopicDefaultId);
return objcc_PapersBigTopicDefaultEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_PapersBigTopicDefaultEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = cc_PapersBigTopicDefaultDA.GetFirstObj(strWhereCond);
 return objcc_PapersBigTopicDefaultEN;
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
public static clscc_PapersBigTopicDefaultEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = cc_PapersBigTopicDefaultDA.GetObjByDataRow(objRow);
 return objcc_PapersBigTopicDefaultEN;
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
public static clscc_PapersBigTopicDefaultEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = cc_PapersBigTopicDefaultDA.GetObjByDataRow(objRow);
 return objcc_PapersBigTopicDefaultEN;
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
 /// <param name = "strPapersBigTopicDefaultId">所给的关键字</param>
 /// <param name = "lstcc_PapersBigTopicDefaultObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultIdFromList(string strPapersBigTopicDefaultId, List<clscc_PapersBigTopicDefaultEN> lstcc_PapersBigTopicDefaultObjLst)
{
foreach (clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN in lstcc_PapersBigTopicDefaultObjLst)
{
if (objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId == strPapersBigTopicDefaultId)
{
return objcc_PapersBigTopicDefaultEN;
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
 string strMaxPapersBigTopicDefaultId;
 try
 {
 strMaxPapersBigTopicDefaultId = clscc_PapersBigTopicDefaultDA.GetMaxStrId();
 return strMaxPapersBigTopicDefaultId;
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
 string strPapersBigTopicDefaultId;
 try
 {
 strPapersBigTopicDefaultId = new clscc_PapersBigTopicDefaultDA().GetFirstID(strWhereCond);
 return strPapersBigTopicDefaultId;
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
 arrList = cc_PapersBigTopicDefaultDA.GetID(strWhereCond);
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
bool bolIsExist = cc_PapersBigTopicDefaultDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPapersBigTopicDefaultId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPapersBigTopicDefaultId)
{
if (string.IsNullOrEmpty(strPapersBigTopicDefaultId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPapersBigTopicDefaultId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_PapersBigTopicDefaultDA.IsExist(strPapersBigTopicDefaultId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strPapersBigTopicDefaultId">PapersBigTopicDefaultId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strPapersBigTopicDefaultId, string strOpUser)
{
clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = clscc_PapersBigTopicDefaultBL.GetObjByPapersBigTopicDefaultId(strPapersBigTopicDefaultId);
objcc_PapersBigTopicDefaultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_PapersBigTopicDefaultEN.UpdUser = strOpUser;
return clscc_PapersBigTopicDefaultBL.UpdateBySql2(objcc_PapersBigTopicDefaultEN);
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
 bolIsExist = clscc_PapersBigTopicDefaultDA.IsExistTable();
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
 bolIsExist = cc_PapersBigTopicDefaultDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_PapersBigTopicDefaultEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!试卷大题目名称 = [{0}]的数据已经存在!(in clscc_PapersBigTopicDefaultBL.AddNewRecordBySql2)", objcc_PapersBigTopicDefaultEN.PapersBigTopicName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true || clscc_PapersBigTopicDefaultBL.IsExist(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
     objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = clscc_PapersBigTopicDefaultBL.GetMaxStrId_S();
 }
bool bolResult = cc_PapersBigTopicDefaultDA.AddNewRecordBySQL2(objcc_PapersBigTopicDefaultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_PapersBigTopicDefaultEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!试卷大题目名称 = [{0}]的数据已经存在!(in clscc_PapersBigTopicDefaultBL.AddNewRecordBySql2WithReturnKey)", objcc_PapersBigTopicDefaultEN.PapersBigTopicName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true || clscc_PapersBigTopicDefaultBL.IsExist(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
     objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = clscc_PapersBigTopicDefaultBL.GetMaxStrId_S();
 }
string strKey = cc_PapersBigTopicDefaultDA.AddNewRecordBySQL2WithReturnKey(objcc_PapersBigTopicDefaultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
try
{
bool bolResult = cc_PapersBigTopicDefaultDA.Update(objcc_PapersBigTopicDefaultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_PapersBigTopicDefaultDA.UpdateBySql2(objcc_PapersBigTopicDefaultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultBL.ReFreshCache();

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
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
 /// <param name = "strPapersBigTopicDefaultId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPapersBigTopicDefaultId)
{
try
{
 clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = clscc_PapersBigTopicDefaultBL.GetObjByPapersBigTopicDefaultId(strPapersBigTopicDefaultId);

if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objcc_PapersBigTopicDefaultEN.UpdUser);
}
if (objcc_PapersBigTopicDefaultEN != null)
{
int intRecNum = cc_PapersBigTopicDefaultDA.DelRecord(strPapersBigTopicDefaultId);
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
/// <param name="strPapersBigTopicDefaultId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPapersBigTopicDefaultId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_PapersBigTopicDefaultDA.GetSpecSQLObj();
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
//删除与表:[cc_PapersBigTopicDefault]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_PapersBigTopicDefault.PapersBigTopicDefaultId,
//strPapersBigTopicDefaultId);
//        clscc_PapersBigTopicDefaultBL.Delcc_PapersBigTopicDefaultsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_PapersBigTopicDefaultBL.DelRecord(strPapersBigTopicDefaultId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_PapersBigTopicDefaultBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPapersBigTopicDefaultId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPapersBigTopicDefaultId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPapersBigTopicDefaultId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(strPapersBigTopicDefaultId, "UpdRelaTabDate");
}
bool bolResult = cc_PapersBigTopicDefaultDA.DelRecord(strPapersBigTopicDefaultId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPapersBigTopicDefaultIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_PapersBigTopicDefaults(List<string> arrPapersBigTopicDefaultIdLst)
{
if (arrPapersBigTopicDefaultIdLst.Count == 0) return 0;
try
{
if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
foreach (var strPapersBigTopicDefaultId in arrPapersBigTopicDefaultIdLst)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(strPapersBigTopicDefaultId, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_PapersBigTopicDefaultDA.Delcc_PapersBigTopicDefault(arrPapersBigTopicDefaultIdLst);
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
public static int Delcc_PapersBigTopicDefaultsByCond(string strWhereCond)
{
try
{
if (clscc_PapersBigTopicDefaultBL.relatedActions != null)
{
List<string> arrPapersBigTopicDefaultId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPapersBigTopicDefaultId in arrPapersBigTopicDefaultId)
{
clscc_PapersBigTopicDefaultBL.relatedActions.UpdRelaTabDate(strPapersBigTopicDefaultId, "UpdRelaTabDate");
}
}
int intRecNum = cc_PapersBigTopicDefaultDA.Delcc_PapersBigTopicDefault(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_PapersBigTopicDefault]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPapersBigTopicDefaultId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPapersBigTopicDefaultId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_PapersBigTopicDefaultDA.GetSpecSQLObj();
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
//删除与表:[cc_PapersBigTopicDefault]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_PapersBigTopicDefaultBL.DelRecord(strPapersBigTopicDefaultId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_PapersBigTopicDefaultBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPapersBigTopicDefaultId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_PapersBigTopicDefaultENS">源对象</param>
 /// <param name = "objcc_PapersBigTopicDefaultENT">目标对象</param>
 public static void CopyTo(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultENS, clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultENT)
{
try
{
objcc_PapersBigTopicDefaultENT.PapersBigTopicDefaultId = objcc_PapersBigTopicDefaultENS.PapersBigTopicDefaultId; //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultENT.QuestionTypeId = objcc_PapersBigTopicDefaultENS.QuestionTypeId; //题目类型Id
objcc_PapersBigTopicDefaultENT.PapersBigTopicName = objcc_PapersBigTopicDefaultENS.PapersBigTopicName; //试卷大题目名称
objcc_PapersBigTopicDefaultENT.TopicDescription = objcc_PapersBigTopicDefaultENS.TopicDescription; //标题描述
objcc_PapersBigTopicDefaultENT.TopicScores = objcc_PapersBigTopicDefaultENS.TopicScores; //大题得分
objcc_PapersBigTopicDefaultENT.UpdDate = objcc_PapersBigTopicDefaultENS.UpdDate; //修改日期
objcc_PapersBigTopicDefaultENT.UpdUser = objcc_PapersBigTopicDefaultENS.UpdUser; //修改人
objcc_PapersBigTopicDefaultENT.Memo = objcc_PapersBigTopicDefaultENS.Memo; //备注
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">源简化对象</param>
 public static void SetUpdFlag(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
try
{
objcc_PapersBigTopicDefaultEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_PapersBigTopicDefaultEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_PapersBigTopicDefault.PapersBigTopicDefaultId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId; //PapersBigTopicDefaultId
}
if (arrFldSet.Contains(concc_PapersBigTopicDefault.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicDefaultEN.QuestionTypeId = objcc_PapersBigTopicDefaultEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(concc_PapersBigTopicDefault.PapersBigTopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = objcc_PapersBigTopicDefaultEN.PapersBigTopicName; //试卷大题目名称
}
if (arrFldSet.Contains(concc_PapersBigTopicDefault.TopicDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicDefaultEN.TopicDescription = objcc_PapersBigTopicDefaultEN.TopicDescription == "[null]" ? null :  objcc_PapersBigTopicDefaultEN.TopicDescription; //标题描述
}
if (arrFldSet.Contains(concc_PapersBigTopicDefault.TopicScores, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicDefaultEN.TopicScores = objcc_PapersBigTopicDefaultEN.TopicScores; //大题得分
}
if (arrFldSet.Contains(concc_PapersBigTopicDefault.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicDefaultEN.UpdDate = objcc_PapersBigTopicDefaultEN.UpdDate == "[null]" ? null :  objcc_PapersBigTopicDefaultEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_PapersBigTopicDefault.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicDefaultEN.UpdUser = objcc_PapersBigTopicDefaultEN.UpdUser == "[null]" ? null :  objcc_PapersBigTopicDefaultEN.UpdUser; //修改人
}
if (arrFldSet.Contains(concc_PapersBigTopicDefault.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PapersBigTopicDefaultEN.Memo = objcc_PapersBigTopicDefaultEN.Memo == "[null]" ? null :  objcc_PapersBigTopicDefaultEN.Memo; //备注
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
try
{
if (objcc_PapersBigTopicDefaultEN.TopicDescription == "[null]") objcc_PapersBigTopicDefaultEN.TopicDescription = null; //标题描述
if (objcc_PapersBigTopicDefaultEN.UpdDate == "[null]") objcc_PapersBigTopicDefaultEN.UpdDate = null; //修改日期
if (objcc_PapersBigTopicDefaultEN.UpdUser == "[null]") objcc_PapersBigTopicDefaultEN.UpdUser = null; //修改人
if (objcc_PapersBigTopicDefaultEN.Memo == "[null]") objcc_PapersBigTopicDefaultEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
 cc_PapersBigTopicDefaultDA.CheckPropertyNew(objcc_PapersBigTopicDefaultEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
 cc_PapersBigTopicDefaultDA.CheckProperty4Condition(objcc_PapersBigTopicDefaultEN);
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
if (clscc_PapersBigTopicDefaultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicDefaultBL没有刷新缓存机制(clscc_PapersBigTopicDefaultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PapersBigTopicDefaultId");
//if (arrcc_PapersBigTopicDefaultObjLstCache == null)
//{
//arrcc_PapersBigTopicDefaultObjLstCache = cc_PapersBigTopicDefaultDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPapersBigTopicDefaultId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultIdCache(string strPapersBigTopicDefaultId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_PapersBigTopicDefaultEN._CurrTabName);
List<clscc_PapersBigTopicDefaultEN> arrcc_PapersBigTopicDefaultObjLstCache = GetObjLstCache();
IEnumerable <clscc_PapersBigTopicDefaultEN> arrcc_PapersBigTopicDefaultObjLst_Sel =
arrcc_PapersBigTopicDefaultObjLstCache
.Where(x=> x.PapersBigTopicDefaultId == strPapersBigTopicDefaultId 
);
if (arrcc_PapersBigTopicDefaultObjLst_Sel.Count() == 0)
{
   clscc_PapersBigTopicDefaultEN obj = clscc_PapersBigTopicDefaultBL.GetObjByPapersBigTopicDefaultId(strPapersBigTopicDefaultId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_PapersBigTopicDefaultObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_PapersBigTopicDefaultEN> GetAllcc_PapersBigTopicDefaultObjLstCache()
{
//获取缓存中的对象列表
List<clscc_PapersBigTopicDefaultEN> arrcc_PapersBigTopicDefaultObjLstCache = GetObjLstCache(); 
return arrcc_PapersBigTopicDefaultObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_PapersBigTopicDefaultEN._CurrTabName);
List<clscc_PapersBigTopicDefaultEN> arrcc_PapersBigTopicDefaultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_PapersBigTopicDefaultObjLstCache;
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
string strKey = string.Format("{0}", clscc_PapersBigTopicDefaultEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_PapersBigTopicDefaultEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_PapersBigTopicDefaultEN._RefreshTimeLst.Count == 0) return "";
return clscc_PapersBigTopicDefaultEN._RefreshTimeLst[clscc_PapersBigTopicDefaultEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_PapersBigTopicDefaultBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_PapersBigTopicDefaultEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_PapersBigTopicDefaultEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_PapersBigTopicDefaultBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_PapersBigTopicDefault(试卷大题目默认)
 /// 唯一性条件:PapersBigTopicName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
//检测记录是否存在
string strResult = cc_PapersBigTopicDefaultDA.GetUniCondStr(objcc_PapersBigTopicDefaultEN);
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
public static string Func(string strInFldName, string strOutFldName, string strPapersBigTopicDefaultId)
{
if (strInFldName != concc_PapersBigTopicDefault.PapersBigTopicDefaultId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_PapersBigTopicDefault.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_PapersBigTopicDefault.AttributeName));
throw new Exception(strMsg);
}
var objcc_PapersBigTopicDefault = clscc_PapersBigTopicDefaultBL.GetObjByPapersBigTopicDefaultIdCache(strPapersBigTopicDefaultId);
if (objcc_PapersBigTopicDefault == null) return "";
return objcc_PapersBigTopicDefault[strOutFldName].ToString();
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
int intRecCount = clscc_PapersBigTopicDefaultDA.GetRecCount(strTabName);
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
int intRecCount = clscc_PapersBigTopicDefaultDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_PapersBigTopicDefaultDA.GetRecCount();
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
int intRecCount = clscc_PapersBigTopicDefaultDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultCond)
{
List<clscc_PapersBigTopicDefaultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_PapersBigTopicDefaultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_PapersBigTopicDefault.AttributeName)
{
if (objcc_PapersBigTopicDefaultCond.IsUpdated(strFldName) == false) continue;
if (objcc_PapersBigTopicDefaultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PapersBigTopicDefaultCond[strFldName].ToString());
}
else
{
if (objcc_PapersBigTopicDefaultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_PapersBigTopicDefaultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PapersBigTopicDefaultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_PapersBigTopicDefaultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_PapersBigTopicDefaultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_PapersBigTopicDefaultCond[strFldName]));
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
 List<string> arrList = clscc_PapersBigTopicDefaultDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_PapersBigTopicDefaultDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_PapersBigTopicDefaultDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_PapersBigTopicDefaultDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_PapersBigTopicDefaultDA.SetFldValue(clscc_PapersBigTopicDefaultEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_PapersBigTopicDefaultDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_PapersBigTopicDefaultDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_PapersBigTopicDefaultDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_PapersBigTopicDefaultDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_PapersBigTopicDefault] "); 
 strCreateTabCode.Append(" ( "); 
 // /**PapersBigTopicDefaultId*/ 
 strCreateTabCode.Append(" PapersBigTopicDefaultId char(8) primary key, "); 
 // /**题目类型Id*/ 
 strCreateTabCode.Append(" QuestionTypeId char(2) not Null, "); 
 // /**试卷大题目名称*/ 
 strCreateTabCode.Append(" PapersBigTopicName varchar(50) not Null, "); 
 // /**标题描述*/ 
 strCreateTabCode.Append(" TopicDescription varchar(100) Null, "); 
 // /**大题得分*/ 
 strCreateTabCode.Append(" TopicScores int Null, "); 
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
 /// 试卷大题目默认(cc_PapersBigTopicDefault)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_PapersBigTopicDefault : clsCommFun4BL
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
clscc_PapersBigTopicDefaultBL.ReFreshThisCache();
}
}

}