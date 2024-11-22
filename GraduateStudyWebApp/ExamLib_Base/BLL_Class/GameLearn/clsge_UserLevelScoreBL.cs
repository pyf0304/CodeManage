﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_UserLevelScoreBL
 表名:ge_UserLevelScore(01120942)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
public static class  clsge_UserLevelScoreBL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objge_UserLevelScoreEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (string.IsNullOrEmpty(objge_UserLevelScoreEN.GameLevelId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (string.IsNullOrEmpty(objge_UserLevelScoreEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_UserLevelScoreBL.IsExist(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_UserLevelScoreEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsge_UserLevelScoreBL.ge_UserLevelScoreDA.AddNewRecordBySQL2(objge_UserLevelScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserLevelScoreBL.ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
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
public static bool AddRecordEx(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsge_UserLevelScoreBL.IsExist(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objge_UserLevelScoreEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objge_UserLevelScoreEN.AddNewRecord();
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
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objge_UserLevelScoreEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_UserLevelScoreBL.IsExist(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_UserLevelScoreEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsge_UserLevelScoreBL.ge_UserLevelScoreDA.AddNewRecordBySQL2WithReturnKey(objge_UserLevelScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserLevelScoreBL.ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
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
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetIdCurrEduCls(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conge_UserLevelScore.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conge_UserLevelScore.IdCurrEduCls);
}
objge_UserLevelScoreEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.IdCurrEduCls) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.IdCurrEduCls, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.IdCurrEduCls] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetGameLevelId(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strGameLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGameLevelId, 8, conge_UserLevelScore.GameLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGameLevelId, 8, conge_UserLevelScore.GameLevelId);
}
objge_UserLevelScoreEN.GameLevelId = strGameLevelId; //游戏关卡Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.GameLevelId) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.GameLevelId, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.GameLevelId] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetUserId(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conge_UserLevelScore.UserId);
}
objge_UserLevelScoreEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.UserId) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.UserId, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.UserId] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetCourseId(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conge_UserLevelScore.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_UserLevelScore.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_UserLevelScore.CourseId);
}
objge_UserLevelScoreEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.CourseId) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.CourseId, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.CourseId] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetPassed(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, bool bolPassed, string strComparisonOp="")
	{
objge_UserLevelScoreEN.Passed = bolPassed; //是否合格
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.Passed) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.Passed, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.Passed] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetCredits(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, int intCredits, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intCredits, conge_UserLevelScore.Credits);
objge_UserLevelScoreEN.Credits = intCredits; //积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.Credits) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.Credits, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.Credits] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetGetDate(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strGetDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetDate, 20, conge_UserLevelScore.GetDate);
}
objge_UserLevelScoreEN.GetDate = strGetDate; //获取日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.GetDate) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.GetDate, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.GetDate] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetGetInstructions(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strGetInstructions, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetInstructions, 100, conge_UserLevelScore.GetInstructions);
}
objge_UserLevelScoreEN.GetInstructions = strGetInstructions; //获取说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.GetInstructions) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.GetInstructions, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.GetInstructions] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetBadgeNum(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, int? intBadgeNum, string strComparisonOp="")
	{
objge_UserLevelScoreEN.BadgeNum = intBadgeNum; //徽章数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.BadgeNum) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.BadgeNum, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.BadgeNum] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetUpdDate(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_UserLevelScore.UpdDate);
}
objge_UserLevelScoreEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.UpdDate) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.UpdDate, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.UpdDate] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetUpdUser(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_UserLevelScore.UpdUser);
}
objge_UserLevelScoreEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.UpdUser) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.UpdUser, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.UpdUser] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserLevelScoreEN SetMemo(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_UserLevelScore.Memo);
}
objge_UserLevelScoreEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserLevelScoreEN.dicFldComparisonOp.ContainsKey(conge_UserLevelScore.Memo) == false)
{
objge_UserLevelScoreEN.dicFldComparisonOp.Add(conge_UserLevelScore.Memo, strComparisonOp);
}
else
{
objge_UserLevelScoreEN.dicFldComparisonOp[conge_UserLevelScore.Memo] = strComparisonOp;
}
}
return objge_UserLevelScoreEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_UserLevelScoreEN.CheckPropertyNew();
clsge_UserLevelScoreEN objge_UserLevelScoreCond = new clsge_UserLevelScoreEN();
string strCondition = objge_UserLevelScoreCond
.SetIdCurrEduCls(objge_UserLevelScoreEN.IdCurrEduCls, "=")
.GetCombineCondition();
objge_UserLevelScoreEN._IsCheckProperty = true;
bool bolIsExist = clsge_UserLevelScoreBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_UserLevelScoreEN.Update();
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
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
 if (string.IsNullOrEmpty(objge_UserLevelScoreEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_UserLevelScoreBL.ge_UserLevelScoreDA.UpdateBySql2(objge_UserLevelScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserLevelScoreBL.ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
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
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_UserLevelScoreEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_UserLevelScoreBL.ge_UserLevelScoreDA.UpdateBySql2(objge_UserLevelScoreEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserLevelScoreBL.ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
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
 /// <param name = "objge_UserLevelScoreEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strWhereCond)
{
try
{
bool bolResult = clsge_UserLevelScoreBL.ge_UserLevelScoreDA.UpdateBySqlWithCondition(objge_UserLevelScoreEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserLevelScoreBL.ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
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
 /// <param name = "objge_UserLevelScoreEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_UserLevelScoreEN objge_UserLevelScoreEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_UserLevelScoreBL.ge_UserLevelScoreDA.UpdateBySqlWithConditionTransaction(objge_UserLevelScoreEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserLevelScoreBL.ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
try
{
int intRecNum = clsge_UserLevelScoreBL.ge_UserLevelScoreDA.DelRecord(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserLevelScoreBL.ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
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
 /// <param name = "objge_UserLevelScoreENS">源对象</param>
 /// <param name = "objge_UserLevelScoreENT">目标对象</param>
 public static void CopyTo(this clsge_UserLevelScoreEN objge_UserLevelScoreENS, clsge_UserLevelScoreEN objge_UserLevelScoreENT)
{
try
{
objge_UserLevelScoreENT.IdCurrEduCls = objge_UserLevelScoreENS.IdCurrEduCls; //教学班流水号
objge_UserLevelScoreENT.GameLevelId = objge_UserLevelScoreENS.GameLevelId; //游戏关卡Id
objge_UserLevelScoreENT.UserId = objge_UserLevelScoreENS.UserId; //用户ID
objge_UserLevelScoreENT.CourseId = objge_UserLevelScoreENS.CourseId; //课程Id
objge_UserLevelScoreENT.Passed = objge_UserLevelScoreENS.Passed; //是否合格
objge_UserLevelScoreENT.Credits = objge_UserLevelScoreENS.Credits; //积分
objge_UserLevelScoreENT.GetDate = objge_UserLevelScoreENS.GetDate; //获取日期
objge_UserLevelScoreENT.GetInstructions = objge_UserLevelScoreENS.GetInstructions; //获取说明
objge_UserLevelScoreENT.BadgeNum = objge_UserLevelScoreENS.BadgeNum; //徽章数量
objge_UserLevelScoreENT.UpdDate = objge_UserLevelScoreENS.UpdDate; //修改日期
objge_UserLevelScoreENT.UpdUser = objge_UserLevelScoreENS.UpdUser; //修改人
objge_UserLevelScoreENT.Memo = objge_UserLevelScoreENS.Memo; //备注
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
 /// <param name = "objge_UserLevelScoreENS">源对象</param>
 /// <returns>目标对象=>clsge_UserLevelScoreEN:objge_UserLevelScoreENT</returns>
 public static clsge_UserLevelScoreEN CopyTo(this clsge_UserLevelScoreEN objge_UserLevelScoreENS)
{
try
{
 clsge_UserLevelScoreEN objge_UserLevelScoreENT = new clsge_UserLevelScoreEN()
{
IdCurrEduCls = objge_UserLevelScoreENS.IdCurrEduCls, //教学班流水号
GameLevelId = objge_UserLevelScoreENS.GameLevelId, //游戏关卡Id
UserId = objge_UserLevelScoreENS.UserId, //用户ID
CourseId = objge_UserLevelScoreENS.CourseId, //课程Id
Passed = objge_UserLevelScoreENS.Passed, //是否合格
Credits = objge_UserLevelScoreENS.Credits, //积分
GetDate = objge_UserLevelScoreENS.GetDate, //获取日期
GetInstructions = objge_UserLevelScoreENS.GetInstructions, //获取说明
BadgeNum = objge_UserLevelScoreENS.BadgeNum, //徽章数量
UpdDate = objge_UserLevelScoreENS.UpdDate, //修改日期
UpdUser = objge_UserLevelScoreENS.UpdUser, //修改人
Memo = objge_UserLevelScoreENS.Memo, //备注
};
 return objge_UserLevelScoreENT;
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
public static void CheckPropertyNew(this clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
 clsge_UserLevelScoreBL.ge_UserLevelScoreDA.CheckPropertyNew(objge_UserLevelScoreEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
 clsge_UserLevelScoreBL.ge_UserLevelScoreDA.CheckProperty4Condition(objge_UserLevelScoreEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_UserLevelScoreEN objge_UserLevelScoreCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objge_UserLevelScoreCond.dicFldComparisonOp[conge_UserLevelScore.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserLevelScore.IdCurrEduCls, objge_UserLevelScoreCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.GameLevelId) == true)
{
string strComparisonOpGameLevelId = objge_UserLevelScoreCond.dicFldComparisonOp[conge_UserLevelScore.GameLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserLevelScore.GameLevelId, objge_UserLevelScoreCond.GameLevelId, strComparisonOpGameLevelId);
}
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.UserId) == true)
{
string strComparisonOpUserId = objge_UserLevelScoreCond.dicFldComparisonOp[conge_UserLevelScore.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserLevelScore.UserId, objge_UserLevelScoreCond.UserId, strComparisonOpUserId);
}
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.CourseId) == true)
{
string strComparisonOpCourseId = objge_UserLevelScoreCond.dicFldComparisonOp[conge_UserLevelScore.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserLevelScore.CourseId, objge_UserLevelScoreCond.CourseId, strComparisonOpCourseId);
}
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.Passed) == true)
{
if (objge_UserLevelScoreCond.Passed == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_UserLevelScore.Passed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_UserLevelScore.Passed);
}
}
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.Credits) == true)
{
string strComparisonOpCredits = objge_UserLevelScoreCond.dicFldComparisonOp[conge_UserLevelScore.Credits];
strWhereCond += string.Format(" And {0} {2} {1}", conge_UserLevelScore.Credits, objge_UserLevelScoreCond.Credits, strComparisonOpCredits);
}
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.GetDate) == true)
{
string strComparisonOpGetDate = objge_UserLevelScoreCond.dicFldComparisonOp[conge_UserLevelScore.GetDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserLevelScore.GetDate, objge_UserLevelScoreCond.GetDate, strComparisonOpGetDate);
}
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.GetInstructions) == true)
{
string strComparisonOpGetInstructions = objge_UserLevelScoreCond.dicFldComparisonOp[conge_UserLevelScore.GetInstructions];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserLevelScore.GetInstructions, objge_UserLevelScoreCond.GetInstructions, strComparisonOpGetInstructions);
}
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.BadgeNum) == true)
{
string strComparisonOpBadgeNum = objge_UserLevelScoreCond.dicFldComparisonOp[conge_UserLevelScore.BadgeNum];
strWhereCond += string.Format(" And {0} {2} {1}", conge_UserLevelScore.BadgeNum, objge_UserLevelScoreCond.BadgeNum, strComparisonOpBadgeNum);
}
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_UserLevelScoreCond.dicFldComparisonOp[conge_UserLevelScore.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserLevelScore.UpdDate, objge_UserLevelScoreCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_UserLevelScoreCond.dicFldComparisonOp[conge_UserLevelScore.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserLevelScore.UpdUser, objge_UserLevelScoreCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_UserLevelScoreCond.IsUpdated(conge_UserLevelScore.Memo) == true)
{
string strComparisonOpMemo = objge_UserLevelScoreCond.dicFldComparisonOp[conge_UserLevelScore.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserLevelScore.Memo, objge_UserLevelScoreCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_UserLevelScore
{
public virtual bool UpdRelaTabDate(string strIdCurrEduCls,string strGameLevelId,string strUserId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户闯关得分(ge_UserLevelScore)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_UserLevelScoreBL
{
public static RelatedActions_ge_UserLevelScore relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_UserLevelScoreDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_UserLevelScoreDA ge_UserLevelScoreDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_UserLevelScoreDA();
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
 public clsge_UserLevelScoreBL()
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
if (string.IsNullOrEmpty(clsge_UserLevelScoreEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_UserLevelScoreEN._ConnectString);
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
public static DataTable GetDataTable_ge_UserLevelScore(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_UserLevelScoreDA.GetDataTable_ge_UserLevelScore(strWhereCond);
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
objDT = ge_UserLevelScoreDA.GetDataTable(strWhereCond);
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
objDT = ge_UserLevelScoreDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_UserLevelScoreDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_UserLevelScoreDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_UserLevelScoreDA.GetDataTable_Top(objTopPara);
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
objDT = ge_UserLevelScoreDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_UserLevelScoreDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_UserLevelScoreDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--ge_UserLevelScore(用户闯关得分)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
//检测记录是否存在
string strResult = "";
strResult += objge_UserLevelScoreEN.IdCurrEduCls;
strResult += "|" + objge_UserLevelScoreEN.GameLevelId;
strResult += "|" + objge_UserLevelScoreEN.UserId;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_UserLevelScoreEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsge_UserLevelScoreEN._CurrTabName, strIdCurrEduCls);
List<clsge_UserLevelScoreEN> arrge_UserLevelScoreObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_UserLevelScoreEN> arrge_UserLevelScoreObjLst_Sel =
arrge_UserLevelScoreObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrge_UserLevelScoreObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_UserLevelScoreEN> GetObjLst(string strWhereCond)
{
List<clsge_UserLevelScoreEN> arrObjLst = new List<clsge_UserLevelScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = Int32.Parse(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserLevelScoreEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserLevelScoreEN);
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
public static List<clsge_UserLevelScoreEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_UserLevelScoreEN> arrObjLst = new List<clsge_UserLevelScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = Int32.Parse(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserLevelScoreEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserLevelScoreEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_UserLevelScoreCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_UserLevelScoreEN> GetSubObjLstCache(clsge_UserLevelScoreEN objge_UserLevelScoreCond)
{
 string strIdCurrEduCls = objge_UserLevelScoreCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_UserLevelScoreBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_UserLevelScoreEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_UserLevelScoreEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_UserLevelScore.AttributeName)
{
if (objge_UserLevelScoreCond.IsUpdated(strFldName) == false) continue;
if (objge_UserLevelScoreCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_UserLevelScoreCond[strFldName].ToString());
}
else
{
if (objge_UserLevelScoreCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_UserLevelScoreCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_UserLevelScoreCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_UserLevelScoreCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_UserLevelScoreCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_UserLevelScoreCond[strFldName]));
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
public static List<clsge_UserLevelScoreEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_UserLevelScoreEN> arrObjLst = new List<clsge_UserLevelScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = Int32.Parse(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserLevelScoreEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserLevelScoreEN);
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
public static List<clsge_UserLevelScoreEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_UserLevelScoreEN> arrObjLst = new List<clsge_UserLevelScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = Int32.Parse(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserLevelScoreEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserLevelScoreEN);
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
List<clsge_UserLevelScoreEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_UserLevelScoreEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_UserLevelScoreEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_UserLevelScoreEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_UserLevelScoreEN> arrObjLst = new List<clsge_UserLevelScoreEN>(); 
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
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = Int32.Parse(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserLevelScoreEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserLevelScoreEN);
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
public static List<clsge_UserLevelScoreEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_UserLevelScoreEN> arrObjLst = new List<clsge_UserLevelScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = Int32.Parse(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserLevelScoreEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserLevelScoreEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_UserLevelScoreEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_UserLevelScoreEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_UserLevelScoreEN> arrObjLst = new List<clsge_UserLevelScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = Int32.Parse(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserLevelScoreEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserLevelScoreEN);
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
public static List<clsge_UserLevelScoreEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_UserLevelScoreEN> arrObjLst = new List<clsge_UserLevelScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = Int32.Parse(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserLevelScoreEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserLevelScoreEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_UserLevelScoreEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_UserLevelScoreEN> arrObjLst = new List<clsge_UserLevelScoreEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserLevelScoreEN objge_UserLevelScoreEN = new clsge_UserLevelScoreEN();
try
{
objge_UserLevelScoreEN.IdCurrEduCls = objRow[conge_UserLevelScore.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserLevelScoreEN.GameLevelId = objRow[conge_UserLevelScore.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserLevelScoreEN.UserId = objRow[conge_UserLevelScore.UserId].ToString().Trim(); //用户ID
objge_UserLevelScoreEN.CourseId = objRow[conge_UserLevelScore.CourseId].ToString().Trim(); //课程Id
objge_UserLevelScoreEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserLevelScore.Passed].ToString().Trim()); //是否合格
objge_UserLevelScoreEN.Credits = Int32.Parse(objRow[conge_UserLevelScore.Credits].ToString().Trim()); //积分
objge_UserLevelScoreEN.GetDate = objRow[conge_UserLevelScore.GetDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetDate].ToString().Trim(); //获取日期
objge_UserLevelScoreEN.GetInstructions = objRow[conge_UserLevelScore.GetInstructions] == DBNull.Value ? null : objRow[conge_UserLevelScore.GetInstructions].ToString().Trim(); //获取说明
objge_UserLevelScoreEN.BadgeNum = objRow[conge_UserLevelScore.BadgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserLevelScore.BadgeNum].ToString().Trim()); //徽章数量
objge_UserLevelScoreEN.UpdDate = objRow[conge_UserLevelScore.UpdDate] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdDate].ToString().Trim(); //修改日期
objge_UserLevelScoreEN.UpdUser = objRow[conge_UserLevelScore.UpdUser] == DBNull.Value ? null : objRow[conge_UserLevelScore.UpdUser].ToString().Trim(); //修改人
objge_UserLevelScoreEN.Memo = objRow[conge_UserLevelScore.Memo] == DBNull.Value ? null : objRow[conge_UserLevelScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserLevelScoreEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserLevelScoreEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_UserLevelScoreEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_UserLevelScore(ref clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
bool bolResult = ge_UserLevelScoreDA.Getge_UserLevelScore(ref objge_UserLevelScoreEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <param name = "strGameLevelId">表关键字</param>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_UserLevelScoreEN GetObjByKeyLst(string strIdCurrEduCls,string strGameLevelId,string strUserId)
{
if (strIdCurrEduCls.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strIdCurrEduCls,strGameLevelId,strUserId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (strGameLevelId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strIdCurrEduCls,strGameLevelId,strUserId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (strUserId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strIdCurrEduCls,strGameLevelId,strUserId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strIdCurrEduCls]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strGameLevelId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strGameLevelId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strUserId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strUserId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_UserLevelScoreEN objge_UserLevelScoreEN = ge_UserLevelScoreDA.GetObjByKeyLst(strIdCurrEduCls,strGameLevelId,strUserId);
return objge_UserLevelScoreEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_UserLevelScoreEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_UserLevelScoreEN objge_UserLevelScoreEN = ge_UserLevelScoreDA.GetFirstObj(strWhereCond);
 return objge_UserLevelScoreEN;
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
public static clsge_UserLevelScoreEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_UserLevelScoreEN objge_UserLevelScoreEN = ge_UserLevelScoreDA.GetObjByDataRow(objRow);
 return objge_UserLevelScoreEN;
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
public static clsge_UserLevelScoreEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_UserLevelScoreEN objge_UserLevelScoreEN = ge_UserLevelScoreDA.GetObjByDataRow(objRow);
 return objge_UserLevelScoreEN;
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
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <param name = "strGameLevelId">表关键字</param>
 /// <param name = "strUserId">表关键字</param>
 /// <param name = "lstge_UserLevelScoreObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_UserLevelScoreEN GetObjByKeyLstFromList(string strIdCurrEduCls,string strGameLevelId,string strUserId, List<clsge_UserLevelScoreEN> lstge_UserLevelScoreObjLst)
{
foreach (clsge_UserLevelScoreEN objge_UserLevelScoreEN in lstge_UserLevelScoreObjLst)
{
if (objge_UserLevelScoreEN.IdCurrEduCls == strIdCurrEduCls 
 && objge_UserLevelScoreEN.GameLevelId == strGameLevelId 
 && objge_UserLevelScoreEN.UserId == strUserId 
)
{
return objge_UserLevelScoreEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdCurrEduCls;
 try
 {
 strIdCurrEduCls = new clsge_UserLevelScoreDA().GetFirstID(strWhereCond);
 return strIdCurrEduCls;
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
 arrList = ge_UserLevelScoreDA.GetID(strWhereCond);
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
bool bolIsExist = ge_UserLevelScoreDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCurrEduCls,string strGameLevelId,string strUserId)
{
//检测记录是否存在
bool bolIsExist = ge_UserLevelScoreDA.IsExist(strIdCurrEduCls,strGameLevelId,strUserId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdCurrEduCls">教学班流水号</param>
/// <param name = "strGameLevelId">游戏关卡Id</param>
/// <param name = "strUserId">用户ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdCurrEduCls , string strGameLevelId , string strUserId, string strOpUser)
{
clsge_UserLevelScoreEN objge_UserLevelScoreEN = clsge_UserLevelScoreBL.GetObjByKeyLst(strIdCurrEduCls,strGameLevelId,strUserId);
objge_UserLevelScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objge_UserLevelScoreEN.UpdUser = strOpUser;
return clsge_UserLevelScoreBL.UpdateBySql2(objge_UserLevelScoreEN);
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
 bolIsExist = clsge_UserLevelScoreDA.IsExistTable();
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
 bolIsExist = ge_UserLevelScoreDA.IsExistTable(strTabName);
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
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_UserLevelScoreEN objge_UserLevelScoreEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objge_UserLevelScoreEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_UserLevelScoreBL.IsExist(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_UserLevelScoreEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = ge_UserLevelScoreDA.AddNewRecordBySQL2(objge_UserLevelScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserLevelScoreBL.ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
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
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_UserLevelScoreEN objge_UserLevelScoreEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objge_UserLevelScoreEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_UserLevelScoreBL.IsExist(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_UserLevelScoreEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = ge_UserLevelScoreDA.AddNewRecordBySQL2WithReturnKey(objge_UserLevelScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserLevelScoreBL.ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
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
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
try
{
bool bolResult = ge_UserLevelScoreDA.Update(objge_UserLevelScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserLevelScoreBL.ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
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
 /// <param name = "objge_UserLevelScoreEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
 if (string.IsNullOrEmpty(objge_UserLevelScoreEN.IdCurrEduCls) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_UserLevelScoreDA.UpdateBySql2(objge_UserLevelScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserLevelScoreBL.ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdCurrEduCls,string strGameLevelId,string strUserId)
{
try
{
 clsge_UserLevelScoreEN objge_UserLevelScoreEN = clsge_UserLevelScoreBL.GetObjByKeyLst(strIdCurrEduCls,strGameLevelId,strUserId);

if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(objge_UserLevelScoreEN.IdCurrEduCls,objge_UserLevelScoreEN.GameLevelId,objge_UserLevelScoreEN.UserId, objge_UserLevelScoreEN.UpdUser);
}
if (objge_UserLevelScoreEN != null)
{
int intRecNum = ge_UserLevelScoreDA.DelRecord(strIdCurrEduCls,strGameLevelId,strUserId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);
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
/// <param name="strIdCurrEduCls">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdCurrEduCls,string strGameLevelId,string strUserId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
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
//删除与表:[ge_UserLevelScore]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_UserLevelScore.IdCurrEduCls,
//strIdCurrEduCls);
//        clsge_UserLevelScoreBL.Delge_UserLevelScoresByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_UserLevelScoreBL.DelRecord(strIdCurrEduCls,strGameLevelId,strUserId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_UserLevelScoreBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdCurrEduCls,string strGameLevelId,string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_UserLevelScoreBL.relatedActions != null)
{
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls,strGameLevelId,strUserId, "UpdRelaTabDate");
}
bool bolResult = ge_UserLevelScoreDA.DelRecord(strIdCurrEduCls,strGameLevelId,strUserId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdCurrEduClsLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
string strIdCurrEduCls;
string strGameLevelId;
string strUserId;
if (clsge_UserLevelScoreBL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
strIdCurrEduCls = sstrKey[0];
strGameLevelId = sstrKey[1];
strUserId = sstrKey[2];
clsge_UserLevelScoreBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls,strGameLevelId,strUserId, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
strIdCurrEduCls = sstrKey[0];
strGameLevelId = sstrKey[1];
strUserId = sstrKey[2];
 clsge_UserLevelScoreEN objge_UserLevelScoreEN = clsge_UserLevelScoreBL.GetObjByKeyLst(strIdCurrEduCls,strGameLevelId,strUserId);
int intDelRecNum = ge_UserLevelScoreDA.DelRecKeyLsts(arrKeyLsts);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_UserLevelScoreEN.IdCurrEduCls);
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
public static int Delge_UserLevelScoresByCond(string strWhereCond)
{
try
{
List<string> arrIdCurrEduCls = GetFldValue(conge_UserLevelScore.IdCurrEduCls, strWhereCond);
int intRecNum = ge_UserLevelScoreDA.Delge_UserLevelScore(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_UserLevelScore]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdCurrEduCls">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdCurrEduCls,string strGameLevelId,string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_UserLevelScoreDA.GetSpecSQLObj();
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
//删除与表:[ge_UserLevelScore]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_UserLevelScoreBL.DelRecord(strIdCurrEduCls,strGameLevelId,strUserId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_UserLevelScoreBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_UserLevelScoreENS">源对象</param>
 /// <param name = "objge_UserLevelScoreENT">目标对象</param>
 public static void CopyTo(clsge_UserLevelScoreEN objge_UserLevelScoreENS, clsge_UserLevelScoreEN objge_UserLevelScoreENT)
{
try
{
objge_UserLevelScoreENT.IdCurrEduCls = objge_UserLevelScoreENS.IdCurrEduCls; //教学班流水号
objge_UserLevelScoreENT.GameLevelId = objge_UserLevelScoreENS.GameLevelId; //游戏关卡Id
objge_UserLevelScoreENT.UserId = objge_UserLevelScoreENS.UserId; //用户ID
objge_UserLevelScoreENT.CourseId = objge_UserLevelScoreENS.CourseId; //课程Id
objge_UserLevelScoreENT.Passed = objge_UserLevelScoreENS.Passed; //是否合格
objge_UserLevelScoreENT.Credits = objge_UserLevelScoreENS.Credits; //积分
objge_UserLevelScoreENT.GetDate = objge_UserLevelScoreENS.GetDate; //获取日期
objge_UserLevelScoreENT.GetInstructions = objge_UserLevelScoreENS.GetInstructions; //获取说明
objge_UserLevelScoreENT.BadgeNum = objge_UserLevelScoreENS.BadgeNum; //徽章数量
objge_UserLevelScoreENT.UpdDate = objge_UserLevelScoreENS.UpdDate; //修改日期
objge_UserLevelScoreENT.UpdUser = objge_UserLevelScoreENS.UpdUser; //修改人
objge_UserLevelScoreENT.Memo = objge_UserLevelScoreENS.Memo; //备注
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
 /// <param name = "objge_UserLevelScoreEN">源简化对象</param>
 public static void SetUpdFlag(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
try
{
objge_UserLevelScoreEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_UserLevelScoreEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_UserLevelScore.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.IdCurrEduCls = objge_UserLevelScoreEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conge_UserLevelScore.GameLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.GameLevelId = objge_UserLevelScoreEN.GameLevelId; //游戏关卡Id
}
if (arrFldSet.Contains(conge_UserLevelScore.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.UserId = objge_UserLevelScoreEN.UserId; //用户ID
}
if (arrFldSet.Contains(conge_UserLevelScore.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.CourseId = objge_UserLevelScoreEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_UserLevelScore.Passed, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.Passed = objge_UserLevelScoreEN.Passed; //是否合格
}
if (arrFldSet.Contains(conge_UserLevelScore.Credits, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.Credits = objge_UserLevelScoreEN.Credits; //积分
}
if (arrFldSet.Contains(conge_UserLevelScore.GetDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.GetDate = objge_UserLevelScoreEN.GetDate == "[null]" ? null :  objge_UserLevelScoreEN.GetDate; //获取日期
}
if (arrFldSet.Contains(conge_UserLevelScore.GetInstructions, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.GetInstructions = objge_UserLevelScoreEN.GetInstructions == "[null]" ? null :  objge_UserLevelScoreEN.GetInstructions; //获取说明
}
if (arrFldSet.Contains(conge_UserLevelScore.BadgeNum, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.BadgeNum = objge_UserLevelScoreEN.BadgeNum; //徽章数量
}
if (arrFldSet.Contains(conge_UserLevelScore.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.UpdDate = objge_UserLevelScoreEN.UpdDate == "[null]" ? null :  objge_UserLevelScoreEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_UserLevelScore.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.UpdUser = objge_UserLevelScoreEN.UpdUser == "[null]" ? null :  objge_UserLevelScoreEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_UserLevelScore.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserLevelScoreEN.Memo = objge_UserLevelScoreEN.Memo == "[null]" ? null :  objge_UserLevelScoreEN.Memo; //备注
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
 /// <param name = "objge_UserLevelScoreEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
try
{
if (objge_UserLevelScoreEN.GetDate == "[null]") objge_UserLevelScoreEN.GetDate = null; //获取日期
if (objge_UserLevelScoreEN.GetInstructions == "[null]") objge_UserLevelScoreEN.GetInstructions = null; //获取说明
if (objge_UserLevelScoreEN.UpdDate == "[null]") objge_UserLevelScoreEN.UpdDate = null; //修改日期
if (objge_UserLevelScoreEN.UpdUser == "[null]") objge_UserLevelScoreEN.UpdUser = null; //修改人
if (objge_UserLevelScoreEN.Memo == "[null]") objge_UserLevelScoreEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
 ge_UserLevelScoreDA.CheckPropertyNew(objge_UserLevelScoreEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_UserLevelScoreEN objge_UserLevelScoreEN)
{
 ge_UserLevelScoreDA.CheckProperty4Condition(objge_UserLevelScoreEN);
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
if (clsge_UserLevelScoreBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_UserLevelScoreBL没有刷新缓存机制(clsge_UserLevelScoreBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCurrEduCls");
//if (arrge_UserLevelScoreObjLstCache == null)
//{
//arrge_UserLevelScoreObjLstCache = ge_UserLevelScoreDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <param name = "strGameLevelId">表关键字</param>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_UserLevelScoreEN GetObjByKeyLstCache(string strIdCurrEduCls,string strGameLevelId,string strUserId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsge_UserLevelScoreEN._CurrTabName, strIdCurrEduCls);
List<clsge_UserLevelScoreEN> arrge_UserLevelScoreObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_UserLevelScoreEN> arrge_UserLevelScoreObjLst_Sel =
arrge_UserLevelScoreObjLstCache
.Where(x=> x.IdCurrEduCls == strIdCurrEduCls 
 && x.GameLevelId == strGameLevelId 
 && x.UserId == strUserId 
);
if (arrge_UserLevelScoreObjLst_Sel.Count() == 0)
{
   clsge_UserLevelScoreEN obj = clsge_UserLevelScoreBL.GetObjByKeyLst(strIdCurrEduCls,strGameLevelId,strUserId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
 }
return null;
}
return arrge_UserLevelScoreObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_UserLevelScoreEN> GetAllge_UserLevelScoreObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsge_UserLevelScoreEN> arrge_UserLevelScoreObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrge_UserLevelScoreObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_UserLevelScoreEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsge_UserLevelScoreEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsge_UserLevelScoreEN> arrge_UserLevelScoreObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_UserLevelScoreObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsge_UserLevelScoreEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsge_UserLevelScoreEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_UserLevelScoreEN._RefreshTimeLst.Count == 0) return "";
return clsge_UserLevelScoreEN._RefreshTimeLst[clsge_UserLevelScoreEN._RefreshTimeLst.Count - 1];
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
if (clsge_UserLevelScoreBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_UserLevelScoreEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsge_UserLevelScoreEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_UserLevelScoreBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdCurrEduCls,string strGameLevelId,string strUserId)
{
if (strInFldName != conge_UserLevelScore.IdCurrEduCls)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_UserLevelScore.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_UserLevelScore.AttributeName));
throw new Exception(strMsg);
}
var objge_UserLevelScore = clsge_UserLevelScoreBL.GetObjByKeyLstCache(strIdCurrEduCls,strGameLevelId,strUserId);
if (objge_UserLevelScore == null) return "";
return objge_UserLevelScore[strOutFldName].ToString();
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
int intRecCount = clsge_UserLevelScoreDA.GetRecCount(strTabName);
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
int intRecCount = clsge_UserLevelScoreDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_UserLevelScoreDA.GetRecCount();
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
int intRecCount = clsge_UserLevelScoreDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_UserLevelScoreCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_UserLevelScoreEN objge_UserLevelScoreCond)
{
 string strIdCurrEduCls = objge_UserLevelScoreCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_UserLevelScoreBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_UserLevelScoreEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_UserLevelScoreEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_UserLevelScore.AttributeName)
{
if (objge_UserLevelScoreCond.IsUpdated(strFldName) == false) continue;
if (objge_UserLevelScoreCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_UserLevelScoreCond[strFldName].ToString());
}
else
{
if (objge_UserLevelScoreCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_UserLevelScoreCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_UserLevelScoreCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_UserLevelScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_UserLevelScoreCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_UserLevelScoreCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_UserLevelScoreCond[strFldName]));
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
 List<string> arrList = clsge_UserLevelScoreDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_UserLevelScoreDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_UserLevelScoreDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_UserLevelScoreDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_UserLevelScoreDA.SetFldValue(clsge_UserLevelScoreEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_UserLevelScoreDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_UserLevelScoreDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_UserLevelScoreDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_UserLevelScoreDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_UserLevelScore] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) primary key, "); 
 // /**游戏关卡Id*/ 
 strCreateTabCode.Append(" GameLevelId char(8) primary key, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) primary key, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**是否合格*/ 
 strCreateTabCode.Append(" Passed bit Null, "); 
 // /**积分*/ 
 strCreateTabCode.Append(" Credits int not Null, "); 
 // /**获取日期*/ 
 strCreateTabCode.Append(" GetDate varchar(20) Null, "); 
 // /**获取说明*/ 
 strCreateTabCode.Append(" GetInstructions varchar(100) Null, "); 
 // /**徽章数量*/ 
 strCreateTabCode.Append(" BadgeNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) Null, "); 
 // /**游戏关卡名称*/ 
 strCreateTabCode.Append(" GameLevelName varchar(100) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDateSim varchar(20) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 用户闯关得分(ge_UserLevelScore)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_UserLevelScore : clsCommFun4BLV2
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
clsge_UserLevelScoreBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}