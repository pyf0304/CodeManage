﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_AnswerBL
 表名:zx_Answer(01120721)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class  clszx_AnswerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_AnswerEN GetObj(this K_zxAnswerId_zx_Answer myKey)
{
clszx_AnswerEN objzx_AnswerEN = clszx_AnswerBL.zx_AnswerDA.GetObjByzxAnswerId(myKey.Value);
return objzx_AnswerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_AnswerEN objzx_AnswerEN)
{
if (CheckUniqueness(objzx_AnswerEN) == false)
{
var strMsg = string.Format("记录已经存在!提问Id = [{0}]的数据已经存在!(in clszx_AnswerBL.AddNewRecord)", objzx_AnswerEN.zxQuestionsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_AnswerEN.zxAnswerId) == true || clszx_AnswerBL.IsExist(objzx_AnswerEN.zxAnswerId) == true)
 {
     objzx_AnswerEN.zxAnswerId = clszx_AnswerBL.GetMaxStrId_S();
 }
bool bolResult = clszx_AnswerBL.zx_AnswerDA.AddNewRecordBySQL2(objzx_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_AnswerEN objzx_AnswerEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_AnswerBL.IsExist(objzx_AnswerEN.zxAnswerId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_AnswerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_AnswerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(提问Id(zxQuestionsId)=[{0}])已经存在,不能重复!", objzx_AnswerEN.zxQuestionsId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_AnswerEN.zxAnswerId) == true || clszx_AnswerBL.IsExist(objzx_AnswerEN.zxAnswerId) == true)
 {
     objzx_AnswerEN.zxAnswerId = clszx_AnswerBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_AnswerEN.AddNewRecord();
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
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_AnswerEN objzx_AnswerEN)
{
if (CheckUniqueness(objzx_AnswerEN) == false)
{
var strMsg = string.Format("记录已经存在!提问Id = [{0}]的数据已经存在!(in clszx_AnswerBL.AddNewRecordWithMaxId)", objzx_AnswerEN.zxQuestionsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_AnswerEN.zxAnswerId) == true || clszx_AnswerBL.IsExist(objzx_AnswerEN.zxAnswerId) == true)
 {
     objzx_AnswerEN.zxAnswerId = clszx_AnswerBL.GetMaxStrId_S();
 }
string strzxAnswerId = clszx_AnswerBL.zx_AnswerDA.AddNewRecordBySQL2WithReturnKey(objzx_AnswerEN);
     objzx_AnswerEN.zxAnswerId = strzxAnswerId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
}
return strzxAnswerId;
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
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_AnswerEN objzx_AnswerEN)
{
if (CheckUniqueness(objzx_AnswerEN) == false)
{
var strMsg = string.Format("记录已经存在!提问Id = [{0}]的数据已经存在!(in clszx_AnswerBL.AddNewRecordWithReturnKey)", objzx_AnswerEN.zxQuestionsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_AnswerEN.zxAnswerId) == true || clszx_AnswerBL.IsExist(objzx_AnswerEN.zxAnswerId) == true)
 {
     objzx_AnswerEN.zxAnswerId = clszx_AnswerBL.GetMaxStrId_S();
 }
string strKey = clszx_AnswerBL.zx_AnswerDA.AddNewRecordBySQL2WithReturnKey(objzx_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetzxAnswerId(this clszx_AnswerEN objzx_AnswerEN, string strzxAnswerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxAnswerId, 10, conzx_Answer.zxAnswerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxAnswerId, 10, conzx_Answer.zxAnswerId);
}
objzx_AnswerEN.zxAnswerId = strzxAnswerId; //回答Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.zxAnswerId) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.zxAnswerId, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.zxAnswerId] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetzxQuestionsId(this clszx_AnswerEN objzx_AnswerEN, string strzxQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxQuestionsId, conzx_Answer.zxQuestionsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxQuestionsId, 8, conzx_Answer.zxQuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxQuestionsId, 8, conzx_Answer.zxQuestionsId);
}
objzx_AnswerEN.zxQuestionsId = strzxQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.zxQuestionsId) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.zxQuestionsId, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.zxQuestionsId] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetAnswerContent(this clszx_AnswerEN objzx_AnswerEN, string strAnswerContent, string strComparisonOp="")
	{
objzx_AnswerEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.AnswerContent) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.AnswerContent, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.AnswerContent] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetScore(this clszx_AnswerEN objzx_AnswerEN, float? fltScore, string strComparisonOp="")
	{
objzx_AnswerEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.Score) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.Score, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.Score] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetScoreType(this clszx_AnswerEN objzx_AnswerEN, string strScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreType, 1, conzx_Answer.ScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, conzx_Answer.ScoreType);
}
objzx_AnswerEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.ScoreType) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.ScoreType, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.ScoreType] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetIsRight(this clszx_AnswerEN objzx_AnswerEN, bool bolIsRight, string strComparisonOp="")
	{
objzx_AnswerEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.IsRight) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.IsRight, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.IsRight] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetParentId(this clszx_AnswerEN objzx_AnswerEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, conzx_Answer.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, conzx_Answer.ParentId);
}
objzx_AnswerEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.ParentId) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.ParentId, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.ParentId] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetVoteCount(this clszx_AnswerEN objzx_AnswerEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_AnswerEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.VoteCount) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.VoteCount, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.VoteCount] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetUpdUser(this clszx_AnswerEN objzx_AnswerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_Answer.UpdUser);
}
objzx_AnswerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.UpdUser) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.UpdUser, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.UpdUser] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetUpdDate(this clszx_AnswerEN objzx_AnswerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_Answer.UpdDate);
}
objzx_AnswerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.UpdDate) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.UpdDate, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.UpdDate] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetMemo(this clszx_AnswerEN objzx_AnswerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_Answer.Memo);
}
objzx_AnswerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.Memo) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.Memo, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.Memo] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetIsPublic(this clszx_AnswerEN objzx_AnswerEN, bool bolIsPublic, string strComparisonOp="")
	{
objzx_AnswerEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.IsPublic) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.IsPublic, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.IsPublic] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetIsRecommend(this clszx_AnswerEN objzx_AnswerEN, bool bolIsRecommend, string strComparisonOp="")
	{
objzx_AnswerEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.IsRecommend) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.IsRecommend, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.IsRecommend] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetGroupTextId(this clszx_AnswerEN objzx_AnswerEN, string strGroupTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupTextId, conzx_Answer.GroupTextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_Answer.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_Answer.GroupTextId);
}
objzx_AnswerEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.GroupTextId) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.GroupTextId, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.GroupTextId] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetIsSubmit(this clszx_AnswerEN objzx_AnswerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_AnswerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.IsSubmit) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.IsSubmit, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.IsSubmit] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetAppraiseCount(this clszx_AnswerEN objzx_AnswerEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_AnswerEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.AppraiseCount) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.AppraiseCount, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.AppraiseCount] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetStuScore(this clszx_AnswerEN objzx_AnswerEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_AnswerEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.StuScore) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.StuScore, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.StuScore] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetTeaScore(this clszx_AnswerEN objzx_AnswerEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_AnswerEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.TeaScore) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.TeaScore, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.TeaScore] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetTextId(this clszx_AnswerEN objzx_AnswerEN, string strTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextId, conzx_Answer.TextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_Answer.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_Answer.TextId);
}
objzx_AnswerEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.TextId) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.TextId, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.TextId] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetAnswerTypeId(this clszx_AnswerEN objzx_AnswerEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conzx_Answer.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conzx_Answer.AnswerTypeId);
}
objzx_AnswerEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.AnswerTypeId) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.AnswerTypeId, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.AnswerTypeId] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetIdCurrEduCls(this clszx_AnswerEN objzx_AnswerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, conzx_Answer.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_Answer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_Answer.IdCurrEduCls);
}
objzx_AnswerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.IdCurrEduCls) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerEN SetCreateDate(this clszx_AnswerEN objzx_AnswerEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_Answer.CreateDate);
}
objzx_AnswerEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerEN.dicFldComparisonOp.ContainsKey(conzx_Answer.CreateDate) == false)
{
objzx_AnswerEN.dicFldComparisonOp.Add(conzx_Answer.CreateDate, strComparisonOp);
}
else
{
objzx_AnswerEN.dicFldComparisonOp[conzx_Answer.CreateDate] = strComparisonOp;
}
}
return objzx_AnswerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_AnswerEN objzx_AnswerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_AnswerEN.CheckPropertyNew();
clszx_AnswerEN objzx_AnswerCond = new clszx_AnswerEN();
string strCondition = objzx_AnswerCond
.SetzxAnswerId(objzx_AnswerEN.zxAnswerId, "<>")
.SetzxQuestionsId(objzx_AnswerEN.zxQuestionsId, "=")
.GetCombineCondition();
objzx_AnswerEN._IsCheckProperty = true;
bool bolIsExist = clszx_AnswerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxQuestionsId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_AnswerEN.Update();
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
 /// <param name = "objzx_Answer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_AnswerEN objzx_Answer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_AnswerEN objzx_AnswerCond = new clszx_AnswerEN();
string strCondition = objzx_AnswerCond
.SetzxQuestionsId(objzx_Answer.zxQuestionsId, "=")
.GetCombineCondition();
objzx_Answer._IsCheckProperty = true;
bool bolIsExist = clszx_AnswerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_Answer.zxAnswerId = clszx_AnswerBL.GetFirstID_S(strCondition);
objzx_Answer.UpdateWithCondition(strCondition);
}
else
{
objzx_Answer.zxAnswerId = clszx_AnswerBL.GetMaxStrId_S();
objzx_Answer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_AnswerEN objzx_AnswerEN)
{
 if (string.IsNullOrEmpty(objzx_AnswerEN.zxAnswerId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_AnswerBL.zx_AnswerDA.UpdateBySql2(objzx_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_AnswerEN objzx_AnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_AnswerEN.zxAnswerId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_AnswerBL.zx_AnswerDA.UpdateBySql2(objzx_AnswerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_AnswerEN objzx_AnswerEN, string strWhereCond)
{
try
{
bool bolResult = clszx_AnswerBL.zx_AnswerDA.UpdateBySqlWithCondition(objzx_AnswerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_AnswerEN objzx_AnswerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_AnswerBL.zx_AnswerDA.UpdateBySqlWithConditionTransaction(objzx_AnswerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
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
 /// <param name = "strzxAnswerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_AnswerEN objzx_AnswerEN)
{
try
{
int intRecNum = clszx_AnswerBL.zx_AnswerDA.DelRecord(objzx_AnswerEN.zxAnswerId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerENS">源对象</param>
 /// <param name = "objzx_AnswerENT">目标对象</param>
 public static void CopyTo(this clszx_AnswerEN objzx_AnswerENS, clszx_AnswerEN objzx_AnswerENT)
{
try
{
objzx_AnswerENT.zxAnswerId = objzx_AnswerENS.zxAnswerId; //回答Id
objzx_AnswerENT.zxQuestionsId = objzx_AnswerENS.zxQuestionsId; //提问Id
objzx_AnswerENT.AnswerContent = objzx_AnswerENS.AnswerContent; //答案内容
objzx_AnswerENT.Score = objzx_AnswerENS.Score; //评分
objzx_AnswerENT.ScoreType = objzx_AnswerENS.ScoreType; //评分类型
objzx_AnswerENT.IsRight = objzx_AnswerENS.IsRight; //是否正确
objzx_AnswerENT.ParentId = objzx_AnswerENS.ParentId; //父节点Id
objzx_AnswerENT.VoteCount = objzx_AnswerENS.VoteCount; //点赞计数
objzx_AnswerENT.UpdUser = objzx_AnswerENS.UpdUser; //修改人
objzx_AnswerENT.UpdDate = objzx_AnswerENS.UpdDate; //修改日期
objzx_AnswerENT.Memo = objzx_AnswerENS.Memo; //备注
objzx_AnswerENT.IsPublic = objzx_AnswerENS.IsPublic; //是否公开
objzx_AnswerENT.IsRecommend = objzx_AnswerENS.IsRecommend; //是否推荐
objzx_AnswerENT.GroupTextId = objzx_AnswerENS.GroupTextId; //小组Id
objzx_AnswerENT.IsSubmit = objzx_AnswerENS.IsSubmit; //是否提交
objzx_AnswerENT.AppraiseCount = objzx_AnswerENS.AppraiseCount; //评论数
objzx_AnswerENT.StuScore = objzx_AnswerENS.StuScore; //学生平均分
objzx_AnswerENT.TeaScore = objzx_AnswerENS.TeaScore; //教师评分
objzx_AnswerENT.TextId = objzx_AnswerENS.TextId; //课件Id
objzx_AnswerENT.AnswerTypeId = objzx_AnswerENS.AnswerTypeId; //答案类型ID
objzx_AnswerENT.IdCurrEduCls = objzx_AnswerENS.IdCurrEduCls; //教学班流水号
objzx_AnswerENT.CreateDate = objzx_AnswerENS.CreateDate; //建立日期
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
 /// <param name = "objzx_AnswerENS">源对象</param>
 /// <returns>目标对象=>clszx_AnswerEN:objzx_AnswerENT</returns>
 public static clszx_AnswerEN CopyTo(this clszx_AnswerEN objzx_AnswerENS)
{
try
{
 clszx_AnswerEN objzx_AnswerENT = new clszx_AnswerEN()
{
zxAnswerId = objzx_AnswerENS.zxAnswerId, //回答Id
zxQuestionsId = objzx_AnswerENS.zxQuestionsId, //提问Id
AnswerContent = objzx_AnswerENS.AnswerContent, //答案内容
Score = objzx_AnswerENS.Score, //评分
ScoreType = objzx_AnswerENS.ScoreType, //评分类型
IsRight = objzx_AnswerENS.IsRight, //是否正确
ParentId = objzx_AnswerENS.ParentId, //父节点Id
VoteCount = objzx_AnswerENS.VoteCount, //点赞计数
UpdUser = objzx_AnswerENS.UpdUser, //修改人
UpdDate = objzx_AnswerENS.UpdDate, //修改日期
Memo = objzx_AnswerENS.Memo, //备注
IsPublic = objzx_AnswerENS.IsPublic, //是否公开
IsRecommend = objzx_AnswerENS.IsRecommend, //是否推荐
GroupTextId = objzx_AnswerENS.GroupTextId, //小组Id
IsSubmit = objzx_AnswerENS.IsSubmit, //是否提交
AppraiseCount = objzx_AnswerENS.AppraiseCount, //评论数
StuScore = objzx_AnswerENS.StuScore, //学生平均分
TeaScore = objzx_AnswerENS.TeaScore, //教师评分
TextId = objzx_AnswerENS.TextId, //课件Id
AnswerTypeId = objzx_AnswerENS.AnswerTypeId, //答案类型ID
IdCurrEduCls = objzx_AnswerENS.IdCurrEduCls, //教学班流水号
CreateDate = objzx_AnswerENS.CreateDate, //建立日期
};
 return objzx_AnswerENT;
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
public static void CheckPropertyNew(this clszx_AnswerEN objzx_AnswerEN)
{
 clszx_AnswerBL.zx_AnswerDA.CheckPropertyNew(objzx_AnswerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_AnswerEN objzx_AnswerEN)
{
 clszx_AnswerBL.zx_AnswerDA.CheckProperty4Condition(objzx_AnswerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_AnswerEN objzx_AnswerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_AnswerCond.IsUpdated(conzx_Answer.zxAnswerId) == true)
{
string strComparisonOpzxAnswerId = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.zxAnswerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.zxAnswerId, objzx_AnswerCond.zxAnswerId, strComparisonOpzxAnswerId);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.zxQuestionsId) == true)
{
string strComparisonOpzxQuestionsId = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.zxQuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.zxQuestionsId, objzx_AnswerCond.zxQuestionsId, strComparisonOpzxQuestionsId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_AnswerCond.IsUpdated(conzx_Answer.Score) == true)
{
string strComparisonOpScore = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Answer.Score, objzx_AnswerCond.Score, strComparisonOpScore);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.ScoreType) == true)
{
string strComparisonOpScoreType = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.ScoreType, objzx_AnswerCond.ScoreType, strComparisonOpScoreType);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.IsRight) == true)
{
if (objzx_AnswerCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Answer.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Answer.IsRight);
}
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.ParentId) == true)
{
string strComparisonOpParentId = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.ParentId, objzx_AnswerCond.ParentId, strComparisonOpParentId);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Answer.VoteCount, objzx_AnswerCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.UpdUser, objzx_AnswerCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.UpdDate, objzx_AnswerCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.Memo) == true)
{
string strComparisonOpMemo = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.Memo, objzx_AnswerCond.Memo, strComparisonOpMemo);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.IsPublic) == true)
{
if (objzx_AnswerCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Answer.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Answer.IsPublic);
}
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.IsRecommend) == true)
{
if (objzx_AnswerCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Answer.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Answer.IsRecommend);
}
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.GroupTextId, objzx_AnswerCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.IsSubmit) == true)
{
if (objzx_AnswerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Answer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Answer.IsSubmit);
}
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Answer.AppraiseCount, objzx_AnswerCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.StuScore) == true)
{
string strComparisonOpStuScore = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Answer.StuScore, objzx_AnswerCond.StuScore, strComparisonOpStuScore);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Answer.TeaScore, objzx_AnswerCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.TextId) == true)
{
string strComparisonOpTextId = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.TextId, objzx_AnswerCond.TextId, strComparisonOpTextId);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.AnswerTypeId, objzx_AnswerCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.IdCurrEduCls, objzx_AnswerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_AnswerCond.IsUpdated(conzx_Answer.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_AnswerCond.dicFldComparisonOp[conzx_Answer.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Answer.CreateDate, objzx_AnswerCond.CreateDate, strComparisonOpCreateDate);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_Answer(zx_Answer), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxQuestionsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_AnswerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_AnswerEN objzx_AnswerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_AnswerEN == null) return true;
if (objzx_AnswerEN.zxAnswerId == null || objzx_AnswerEN.zxAnswerId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxQuestionsId = '{0}'", objzx_AnswerEN.zxQuestionsId);
if (clszx_AnswerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxAnswerId !=  '{0}'", objzx_AnswerEN.zxAnswerId);
 sbCondition.AppendFormat(" and zxQuestionsId = '{0}'", objzx_AnswerEN.zxQuestionsId);
if (clszx_AnswerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_Answer(zx_Answer), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxQuestionsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_AnswerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_AnswerEN objzx_AnswerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_AnswerEN == null) return "";
if (objzx_AnswerEN.zxAnswerId == null || objzx_AnswerEN.zxAnswerId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxQuestionsId = '{0}'", objzx_AnswerEN.zxQuestionsId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxAnswerId !=  '{0}'", objzx_AnswerEN.zxAnswerId);
 sbCondition.AppendFormat(" and zxQuestionsId = '{0}'", objzx_AnswerEN.zxQuestionsId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_Answer
{
public virtual bool UpdRelaTabDate(string strzxAnswerId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// zx_Answer(zx_Answer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_AnswerBL
{
public static RelatedActions_zx_Answer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_AnswerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_AnswerDA zx_AnswerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_AnswerDA();
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
 public clszx_AnswerBL()
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
if (string.IsNullOrEmpty(clszx_AnswerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_AnswerEN._ConnectString);
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
public static DataTable GetDataTable_zx_Answer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_AnswerDA.GetDataTable_zx_Answer(strWhereCond);
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
objDT = zx_AnswerDA.GetDataTable(strWhereCond);
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
objDT = zx_AnswerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_AnswerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_AnswerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_AnswerDA.GetDataTable_Top(objTopPara);
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
objDT = zx_AnswerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_AnswerEN> GetObjLstByZxAnswerIdLst(List<string> arrZxAnswerIdLst)
{
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxAnswerIdLst, true);
 string strWhereCond = string.Format("zxAnswerId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_AnswerEN> GetObjLstByZxAnswerIdLstCache(List<string> arrZxAnswerIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clszx_AnswerEN._CurrTabName, strIdCurrEduCls);
List<clszx_AnswerEN> arrzx_AnswerObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_AnswerEN> arrzx_AnswerObjLst_Sel =
arrzx_AnswerObjLstCache
.Where(x => arrZxAnswerIdLst.Contains(x.zxAnswerId));
return arrzx_AnswerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_AnswerEN> GetObjLst(string strWhereCond)
{
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerEN);
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
public static List<clszx_AnswerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_AnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_AnswerEN> GetSubObjLstCache(clszx_AnswerEN objzx_AnswerCond)
{
 string strIdCurrEduCls = objzx_AnswerCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clszx_AnswerBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clszx_AnswerEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_AnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Answer.AttributeName)
{
if (objzx_AnswerCond.IsUpdated(strFldName) == false) continue;
if (objzx_AnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_AnswerCond[strFldName].ToString());
}
else
{
if (objzx_AnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_AnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_AnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_AnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_AnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_AnswerCond[strFldName]));
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
public static List<clszx_AnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerEN);
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
public static List<clszx_AnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerEN);
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
List<clszx_AnswerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_AnswerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_AnswerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_AnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
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
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerEN);
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
public static List<clszx_AnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_AnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_AnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerEN);
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
public static List<clszx_AnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_AnswerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_AnswerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_Answer(ref clszx_AnswerEN objzx_AnswerEN)
{
bool bolResult = zx_AnswerDA.Getzx_Answer(ref objzx_AnswerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_AnswerEN GetObjByzxAnswerId(string strzxAnswerId)
{
if (strzxAnswerId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxAnswerId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxAnswerId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxAnswerId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_AnswerEN objzx_AnswerEN = zx_AnswerDA.GetObjByzxAnswerId(strzxAnswerId);
return objzx_AnswerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_AnswerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_AnswerEN objzx_AnswerEN = zx_AnswerDA.GetFirstObj(strWhereCond);
 return objzx_AnswerEN;
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
public static clszx_AnswerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_AnswerEN objzx_AnswerEN = zx_AnswerDA.GetObjByDataRow(objRow);
 return objzx_AnswerEN;
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
public static clszx_AnswerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_AnswerEN objzx_AnswerEN = zx_AnswerDA.GetObjByDataRow(objRow);
 return objzx_AnswerEN;
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
 /// <param name = "strzxAnswerId">所给的关键字</param>
 /// <param name = "lstzx_AnswerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_AnswerEN GetObjByzxAnswerIdFromList(string strzxAnswerId, List<clszx_AnswerEN> lstzx_AnswerObjLst)
{
foreach (clszx_AnswerEN objzx_AnswerEN in lstzx_AnswerObjLst)
{
if (objzx_AnswerEN.zxAnswerId == strzxAnswerId)
{
return objzx_AnswerEN;
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
 string strMaxZxAnswerId;
 try
 {
 strMaxZxAnswerId = clszx_AnswerDA.GetMaxStrId();
 return strMaxZxAnswerId;
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
 string strzxAnswerId;
 try
 {
 strzxAnswerId = new clszx_AnswerDA().GetFirstID(strWhereCond);
 return strzxAnswerId;
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
 arrList = zx_AnswerDA.GetID(strWhereCond);
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
bool bolIsExist = zx_AnswerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxAnswerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxAnswerId)
{
if (string.IsNullOrEmpty(strzxAnswerId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxAnswerId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_AnswerDA.IsExist(strzxAnswerId);
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
 bolIsExist = clszx_AnswerDA.IsExistTable();
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
 bolIsExist = zx_AnswerDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_AnswerEN objzx_AnswerEN)
{
if (objzx_AnswerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!提问Id = [{0}]的数据已经存在!(in clszx_AnswerBL.AddNewRecordBySql2)", objzx_AnswerEN.zxQuestionsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_AnswerEN.zxAnswerId) == true || clszx_AnswerBL.IsExist(objzx_AnswerEN.zxAnswerId) == true)
 {
     objzx_AnswerEN.zxAnswerId = clszx_AnswerBL.GetMaxStrId_S();
 }
bool bolResult = zx_AnswerDA.AddNewRecordBySQL2(objzx_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_AnswerEN objzx_AnswerEN)
{
if (objzx_AnswerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!提问Id = [{0}]的数据已经存在!(in clszx_AnswerBL.AddNewRecordBySql2WithReturnKey)", objzx_AnswerEN.zxQuestionsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_AnswerEN.zxAnswerId) == true || clszx_AnswerBL.IsExist(objzx_AnswerEN.zxAnswerId) == true)
 {
     objzx_AnswerEN.zxAnswerId = clszx_AnswerBL.GetMaxStrId_S();
 }
string strKey = zx_AnswerDA.AddNewRecordBySQL2WithReturnKey(objzx_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_AnswerEN objzx_AnswerEN)
{
try
{
bool bolResult = zx_AnswerDA.Update(objzx_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_AnswerEN objzx_AnswerEN)
{
 if (string.IsNullOrEmpty(objzx_AnswerEN.zxAnswerId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_AnswerDA.UpdateBySql2(objzx_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerBL.ReFreshCache(objzx_AnswerEN.IdCurrEduCls);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
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
 /// <param name = "strzxAnswerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxAnswerId)
{
try
{
 clszx_AnswerEN objzx_AnswerEN = clszx_AnswerBL.GetObjByzxAnswerId(strzxAnswerId);

if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(objzx_AnswerEN.zxAnswerId, "SetUpdDate");
}
if (objzx_AnswerEN != null)
{
int intRecNum = zx_AnswerDA.DelRecord(strzxAnswerId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_AnswerEN.IdCurrEduCls);
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
/// <param name="strzxAnswerId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxAnswerId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_AnswerDA.GetSpecSQLObj();
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
//删除与表:[zx_Answer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_Answer.zxAnswerId,
//strzxAnswerId);
//        clszx_AnswerBL.Delzx_AnswersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_AnswerBL.DelRecord(strzxAnswerId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_AnswerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxAnswerId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxAnswerId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxAnswerId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_AnswerBL.relatedActions != null)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(strzxAnswerId, "UpdRelaTabDate");
}
bool bolResult = zx_AnswerDA.DelRecord(strzxAnswerId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxAnswerIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_Answers(List<string> arrzxAnswerIdLst)
{
if (arrzxAnswerIdLst.Count == 0) return 0;
try
{
if (clszx_AnswerBL.relatedActions != null)
{
foreach (var strzxAnswerId in arrzxAnswerIdLst)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(strzxAnswerId, "UpdRelaTabDate");
}
}
 clszx_AnswerEN objzx_AnswerEN = clszx_AnswerBL.GetObjByzxAnswerId(arrzxAnswerIdLst[0]);
int intDelRecNum = zx_AnswerDA.Delzx_Answer(arrzxAnswerIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_AnswerEN.IdCurrEduCls);
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
public static int Delzx_AnswersByCond(string strWhereCond)
{
try
{
if (clszx_AnswerBL.relatedActions != null)
{
List<string> arrzxAnswerId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxAnswerId in arrzxAnswerId)
{
clszx_AnswerBL.relatedActions.UpdRelaTabDate(strzxAnswerId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conzx_Answer.IdCurrEduCls, strWhereCond);
int intRecNum = zx_AnswerDA.Delzx_Answer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_Answer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxAnswerId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxAnswerId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_AnswerDA.GetSpecSQLObj();
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
//删除与表:[zx_Answer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_AnswerBL.DelRecord(strzxAnswerId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_AnswerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxAnswerId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_AnswerENS">源对象</param>
 /// <param name = "objzx_AnswerENT">目标对象</param>
 public static void CopyTo(clszx_AnswerEN objzx_AnswerENS, clszx_AnswerEN objzx_AnswerENT)
{
try
{
objzx_AnswerENT.zxAnswerId = objzx_AnswerENS.zxAnswerId; //回答Id
objzx_AnswerENT.zxQuestionsId = objzx_AnswerENS.zxQuestionsId; //提问Id
objzx_AnswerENT.AnswerContent = objzx_AnswerENS.AnswerContent; //答案内容
objzx_AnswerENT.Score = objzx_AnswerENS.Score; //评分
objzx_AnswerENT.ScoreType = objzx_AnswerENS.ScoreType; //评分类型
objzx_AnswerENT.IsRight = objzx_AnswerENS.IsRight; //是否正确
objzx_AnswerENT.ParentId = objzx_AnswerENS.ParentId; //父节点Id
objzx_AnswerENT.VoteCount = objzx_AnswerENS.VoteCount; //点赞计数
objzx_AnswerENT.UpdUser = objzx_AnswerENS.UpdUser; //修改人
objzx_AnswerENT.UpdDate = objzx_AnswerENS.UpdDate; //修改日期
objzx_AnswerENT.Memo = objzx_AnswerENS.Memo; //备注
objzx_AnswerENT.IsPublic = objzx_AnswerENS.IsPublic; //是否公开
objzx_AnswerENT.IsRecommend = objzx_AnswerENS.IsRecommend; //是否推荐
objzx_AnswerENT.GroupTextId = objzx_AnswerENS.GroupTextId; //小组Id
objzx_AnswerENT.IsSubmit = objzx_AnswerENS.IsSubmit; //是否提交
objzx_AnswerENT.AppraiseCount = objzx_AnswerENS.AppraiseCount; //评论数
objzx_AnswerENT.StuScore = objzx_AnswerENS.StuScore; //学生平均分
objzx_AnswerENT.TeaScore = objzx_AnswerENS.TeaScore; //教师评分
objzx_AnswerENT.TextId = objzx_AnswerENS.TextId; //课件Id
objzx_AnswerENT.AnswerTypeId = objzx_AnswerENS.AnswerTypeId; //答案类型ID
objzx_AnswerENT.IdCurrEduCls = objzx_AnswerENS.IdCurrEduCls; //教学班流水号
objzx_AnswerENT.CreateDate = objzx_AnswerENS.CreateDate; //建立日期
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
 /// <param name = "objzx_AnswerEN">源简化对象</param>
 public static void SetUpdFlag(clszx_AnswerEN objzx_AnswerEN)
{
try
{
objzx_AnswerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_AnswerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_Answer.zxAnswerId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.zxAnswerId = objzx_AnswerEN.zxAnswerId; //回答Id
}
if (arrFldSet.Contains(conzx_Answer.zxQuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.zxQuestionsId = objzx_AnswerEN.zxQuestionsId; //提问Id
}
if (arrFldSet.Contains(conzx_Answer.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.AnswerContent = objzx_AnswerEN.AnswerContent == "[null]" ? null :  objzx_AnswerEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(conzx_Answer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.Score = objzx_AnswerEN.Score; //评分
}
if (arrFldSet.Contains(conzx_Answer.ScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.ScoreType = objzx_AnswerEN.ScoreType == "[null]" ? null :  objzx_AnswerEN.ScoreType; //评分类型
}
if (arrFldSet.Contains(conzx_Answer.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.IsRight = objzx_AnswerEN.IsRight; //是否正确
}
if (arrFldSet.Contains(conzx_Answer.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.ParentId = objzx_AnswerEN.ParentId == "[null]" ? null :  objzx_AnswerEN.ParentId; //父节点Id
}
if (arrFldSet.Contains(conzx_Answer.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.VoteCount = objzx_AnswerEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_Answer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.UpdUser = objzx_AnswerEN.UpdUser == "[null]" ? null :  objzx_AnswerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_Answer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.UpdDate = objzx_AnswerEN.UpdDate == "[null]" ? null :  objzx_AnswerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_Answer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.Memo = objzx_AnswerEN.Memo == "[null]" ? null :  objzx_AnswerEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_Answer.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.IsPublic = objzx_AnswerEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(conzx_Answer.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.IsRecommend = objzx_AnswerEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(conzx_Answer.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.GroupTextId = objzx_AnswerEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(conzx_Answer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.IsSubmit = objzx_AnswerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_Answer.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.AppraiseCount = objzx_AnswerEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_Answer.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.StuScore = objzx_AnswerEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_Answer.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.TeaScore = objzx_AnswerEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_Answer.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.TextId = objzx_AnswerEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_Answer.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.AnswerTypeId = objzx_AnswerEN.AnswerTypeId == "[null]" ? null :  objzx_AnswerEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(conzx_Answer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.IdCurrEduCls = objzx_AnswerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_Answer.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerEN.CreateDate = objzx_AnswerEN.CreateDate == "[null]" ? null :  objzx_AnswerEN.CreateDate; //建立日期
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
 /// <param name = "objzx_AnswerEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_AnswerEN objzx_AnswerEN)
{
try
{
if (objzx_AnswerEN.AnswerContent == "[null]") objzx_AnswerEN.AnswerContent = null; //答案内容
if (objzx_AnswerEN.ScoreType == "[null]") objzx_AnswerEN.ScoreType = null; //评分类型
if (objzx_AnswerEN.ParentId == "[null]") objzx_AnswerEN.ParentId = null; //父节点Id
if (objzx_AnswerEN.UpdUser == "[null]") objzx_AnswerEN.UpdUser = null; //修改人
if (objzx_AnswerEN.UpdDate == "[null]") objzx_AnswerEN.UpdDate = null; //修改日期
if (objzx_AnswerEN.Memo == "[null]") objzx_AnswerEN.Memo = null; //备注
if (objzx_AnswerEN.AnswerTypeId == "[null]") objzx_AnswerEN.AnswerTypeId = null; //答案类型ID
if (objzx_AnswerEN.CreateDate == "[null]") objzx_AnswerEN.CreateDate = null; //建立日期
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
public static void CheckPropertyNew(clszx_AnswerEN objzx_AnswerEN)
{
 zx_AnswerDA.CheckPropertyNew(objzx_AnswerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_AnswerEN objzx_AnswerEN)
{
 zx_AnswerDA.CheckProperty4Condition(objzx_AnswerEN);
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
if (clszx_AnswerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_AnswerBL没有刷新缓存机制(clszx_AnswerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxAnswerId");
//if (arrzx_AnswerObjLstCache == null)
//{
//arrzx_AnswerObjLstCache = zx_AnswerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxAnswerId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_AnswerEN GetObjByzxAnswerIdCache(string strzxAnswerId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_AnswerEN._CurrTabName, strIdCurrEduCls);
List<clszx_AnswerEN> arrzx_AnswerObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_AnswerEN> arrzx_AnswerObjLst_Sel =
arrzx_AnswerObjLstCache
.Where(x=> x.zxAnswerId == strzxAnswerId 
);
if (arrzx_AnswerObjLst_Sel.Count() == 0)
{
   clszx_AnswerEN obj = clszx_AnswerBL.GetObjByzxAnswerId(strzxAnswerId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxAnswerId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrzx_AnswerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_AnswerEN> GetAllzx_AnswerObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clszx_AnswerEN> arrzx_AnswerObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrzx_AnswerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_AnswerEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_AnswerEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clszx_AnswerEN> arrzx_AnswerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrzx_AnswerObjLstCache;
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
string strKey = string.Format("{0}_{1}", clszx_AnswerEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
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
if (clszx_AnswerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clszx_AnswerEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clszx_AnswerBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_Answer(zx_Answer)
 /// 唯一性条件:zxQuestionsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_AnswerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_AnswerEN objzx_AnswerEN)
{
//检测记录是否存在
string strResult = zx_AnswerDA.GetUniCondStr(objzx_AnswerEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxAnswerId, string strIdCurrEduCls)
{
if (strInFldName != conzx_Answer.zxAnswerId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_Answer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_Answer.AttributeName));
throw new Exception(strMsg);
}
var objzx_Answer = clszx_AnswerBL.GetObjByzxAnswerIdCache(strzxAnswerId, strIdCurrEduCls);
if (objzx_Answer == null) return "";
return objzx_Answer[strOutFldName].ToString();
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
int intRecCount = clszx_AnswerDA.GetRecCount(strTabName);
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
int intRecCount = clszx_AnswerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_AnswerDA.GetRecCount();
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
int intRecCount = clszx_AnswerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_AnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_AnswerEN objzx_AnswerCond)
{
 string strIdCurrEduCls = objzx_AnswerCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clszx_AnswerBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clszx_AnswerEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_AnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Answer.AttributeName)
{
if (objzx_AnswerCond.IsUpdated(strFldName) == false) continue;
if (objzx_AnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_AnswerCond[strFldName].ToString());
}
else
{
if (objzx_AnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_AnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_AnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_AnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_AnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_AnswerCond[strFldName]));
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
 List<string> arrList = clszx_AnswerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_AnswerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_AnswerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_AnswerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_AnswerDA.SetFldValue(clszx_AnswerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_AnswerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_AnswerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_AnswerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_AnswerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_Answer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**回答Id*/ 
 strCreateTabCode.Append(" zxAnswerId char(10) primary key, "); 
 // /**提问Id*/ 
 strCreateTabCode.Append(" zxQuestionsId char(8) not Null, "); 
 // /**答案内容*/ 
 strCreateTabCode.Append(" AnswerContent text Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**评分类型*/ 
 strCreateTabCode.Append(" ScoreType char(1) Null, "); 
 // /**是否正确*/ 
 strCreateTabCode.Append(" IsRight bit Null, "); 
 // /**父节点Id*/ 
 strCreateTabCode.Append(" ParentId char(10) Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否公开*/ 
 strCreateTabCode.Append(" IsPublic bit Null, "); 
 // /**是否推荐*/ 
 strCreateTabCode.Append(" IsRecommend bit Null, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) not Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) not Null, "); 
 // /**答案类型ID*/ 
 strCreateTabCode.Append(" AnswerTypeId char(2) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// zx_Answer(zx_Answer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_Answer : clsCommFun4BLV2
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
clszx_AnswerBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}