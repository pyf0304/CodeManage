﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseLearningLogBL
 表名:CaseLearningLog(01120365)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:07:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsCaseLearningLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseLearningLogEN GetObj(this K_mId_CaseLearningLog myKey)
{
clsCaseLearningLogEN objCaseLearningLogEN = clsCaseLearningLogBL.CaseLearningLogDA.GetObjBymId(myKey.Value);
return objCaseLearningLogEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseLearningLogEN objCaseLearningLogEN)
{
if (CheckUniqueness(objCaseLearningLogEN) == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],拥有者Id = [{1}],开始时间 = [{2}],观看视频结束时间 = [{3}]的数据已经存在!(in clsCaseLearningLogBL.AddNewRecord)", objCaseLearningLogEN.CaseId,objCaseLearningLogEN.OwnerId,objCaseLearningLogEN.LearnStartTime,objCaseLearningLogEN.VideoEndTime);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCaseLearningLogBL.CaseLearningLogDA.AddNewRecordBySQL2(objCaseLearningLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogBL.ReFreshCache();

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsCaseLearningLogEN objCaseLearningLogEN)
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
objCaseLearningLogEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objCaseLearningLogEN.CheckUniqueness() == false)
{
strMsg = string.Format("(案例Id(CaseId)=[{0}],拥有者Id(OwnerId)=[{1}],开始时间(LearnStartTime)=[{2}],观看视频结束时间(VideoEndTime)=[{3}])已经存在,不能重复!", objCaseLearningLogEN.CaseId, objCaseLearningLogEN.OwnerId, objCaseLearningLogEN.LearnStartTime, objCaseLearningLogEN.VideoEndTime);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCaseLearningLogEN.AddNewRecord();
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
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCaseLearningLogEN objCaseLearningLogEN)
{
if (CheckUniqueness(objCaseLearningLogEN) == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],拥有者Id = [{1}],开始时间 = [{2}],观看视频结束时间 = [{3}]的数据已经存在!(in clsCaseLearningLogBL.AddNewRecordWithReturnKey)", objCaseLearningLogEN.CaseId,objCaseLearningLogEN.OwnerId,objCaseLearningLogEN.LearnStartTime,objCaseLearningLogEN.VideoEndTime);
throw new Exception(strMsg);
}
try
{
string strKey = clsCaseLearningLogBL.CaseLearningLogDA.AddNewRecordBySQL2WithReturnKey(objCaseLearningLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogBL.ReFreshCache();

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
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
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetmId(this clsCaseLearningLogEN objCaseLearningLogEN, long lngmId, string strComparisonOp="")
	{
objCaseLearningLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.mId) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.mId, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.mId] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetFuncModuleId(this clsCaseLearningLogEN objCaseLearningLogEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conCaseLearningLog.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conCaseLearningLog.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conCaseLearningLog.FuncModuleId);
}
objCaseLearningLogEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.FuncModuleId) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.FuncModuleId, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.FuncModuleId] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetCaseId(this clsCaseLearningLogEN objCaseLearningLogEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId, conCaseLearningLog.CaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, conCaseLearningLog.CaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, conCaseLearningLog.CaseId);
}
objCaseLearningLogEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.CaseId) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.CaseId, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.CaseId] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetCaseName(this clsCaseLearningLogEN objCaseLearningLogEN, string strCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 100, conCaseLearningLog.CaseName);
}
objCaseLearningLogEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.CaseName) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.CaseName, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.CaseName] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetOwnerId(this clsCaseLearningLogEN objCaseLearningLogEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCaseLearningLog.OwnerId);
}
objCaseLearningLogEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.OwnerId) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.OwnerId, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.OwnerId] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetUserId(this clsCaseLearningLogEN objCaseLearningLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conCaseLearningLog.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conCaseLearningLog.UserId);
}
objCaseLearningLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.UserId) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.UserId, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.UserId] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetLearnStartTime(this clsCaseLearningLogEN objCaseLearningLogEN, string strLearnStartTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnStartTime, conCaseLearningLog.LearnStartTime);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLearnStartTime, 14, conCaseLearningLog.LearnStartTime);
}
objCaseLearningLogEN.LearnStartTime = strLearnStartTime; //开始时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.LearnStartTime) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.LearnStartTime, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.LearnStartTime] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetLearnEndTime(this clsCaseLearningLogEN objCaseLearningLogEN, string strLearnEndTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnEndTime, conCaseLearningLog.LearnEndTime);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLearnEndTime, 14, conCaseLearningLog.LearnEndTime);
}
objCaseLearningLogEN.LearnEndTime = strLearnEndTime; //结束时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.LearnEndTime) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.LearnEndTime, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.LearnEndTime] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetVideoStartTime(this clsCaseLearningLogEN objCaseLearningLogEN, double dblVideoStartTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblVideoStartTime, conCaseLearningLog.VideoStartTime);
objCaseLearningLogEN.VideoStartTime = dblVideoStartTime; //观看视频开始时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.VideoStartTime) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.VideoStartTime, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.VideoStartTime] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetVideoEndTime(this clsCaseLearningLogEN objCaseLearningLogEN, double dblVideoEndTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblVideoEndTime, conCaseLearningLog.VideoEndTime);
objCaseLearningLogEN.VideoEndTime = dblVideoEndTime; //观看视频结束时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.VideoEndTime) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.VideoEndTime, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.VideoEndTime] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetIpAddress(this clsCaseLearningLogEN objCaseLearningLogEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 50, conCaseLearningLog.IpAddress);
}
objCaseLearningLogEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.IpAddress) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.IpAddress, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.IpAddress] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetTimeLengthOfVideo(this clsCaseLearningLogEN objCaseLearningLogEN, double? dblTimeLengthOfVideo, string strComparisonOp="")
	{
objCaseLearningLogEN.TimeLengthOfVideo = dblTimeLengthOfVideo; //视频时长
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.TimeLengthOfVideo) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.TimeLengthOfVideo, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.TimeLengthOfVideo] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseLearningLogEN SetMemo(this clsCaseLearningLogEN objCaseLearningLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseLearningLog.Memo);
}
objCaseLearningLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseLearningLogEN.dicFldComparisonOp.ContainsKey(conCaseLearningLog.Memo) == false)
{
objCaseLearningLogEN.dicFldComparisonOp.Add(conCaseLearningLog.Memo, strComparisonOp);
}
else
{
objCaseLearningLogEN.dicFldComparisonOp[conCaseLearningLog.Memo] = strComparisonOp;
}
}
return objCaseLearningLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCaseLearningLogEN objCaseLearningLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCaseLearningLogEN.CheckPropertyNew();
clsCaseLearningLogEN objCaseLearningLogCond = new clsCaseLearningLogEN();
string strCondition = objCaseLearningLogCond
.SetmId(objCaseLearningLogEN.mId, "<>")
.SetCaseId(objCaseLearningLogEN.CaseId, "=")
.SetOwnerId(objCaseLearningLogEN.OwnerId, "=")
.SetLearnStartTime(objCaseLearningLogEN.LearnStartTime, "=")
.SetVideoEndTime(objCaseLearningLogEN.VideoEndTime, "=")
.GetCombineCondition();
objCaseLearningLogEN._IsCheckProperty = true;
bool bolIsExist = clsCaseLearningLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CaseId_OwnerId_LearnStartTime_VideoEndTime)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCaseLearningLogEN.Update();
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
 /// <param name = "objCaseLearningLog">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCaseLearningLogEN objCaseLearningLog)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCaseLearningLogEN objCaseLearningLogCond = new clsCaseLearningLogEN();
string strCondition = objCaseLearningLogCond
.SetCaseId(objCaseLearningLog.CaseId, "=")
.SetOwnerId(objCaseLearningLog.OwnerId, "=")
.SetLearnStartTime(objCaseLearningLog.LearnStartTime, "=")
.SetVideoEndTime(objCaseLearningLog.VideoEndTime, "=")
.GetCombineCondition();
objCaseLearningLog._IsCheckProperty = true;
bool bolIsExist = clsCaseLearningLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCaseLearningLog.mId = clsCaseLearningLogBL.GetFirstID_S(strCondition);
objCaseLearningLog.UpdateWithCondition(strCondition);
}
else
{
objCaseLearningLog.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseLearningLogEN objCaseLearningLogEN)
{
 if (objCaseLearningLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseLearningLogBL.CaseLearningLogDA.UpdateBySql2(objCaseLearningLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogBL.ReFreshCache();

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
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
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseLearningLogEN objCaseLearningLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCaseLearningLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseLearningLogBL.CaseLearningLogDA.UpdateBySql2(objCaseLearningLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogBL.ReFreshCache();

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
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
 /// <param name = "objCaseLearningLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseLearningLogEN objCaseLearningLogEN, string strWhereCond)
{
try
{
bool bolResult = clsCaseLearningLogBL.CaseLearningLogDA.UpdateBySqlWithCondition(objCaseLearningLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogBL.ReFreshCache();

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
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
 /// <param name = "objCaseLearningLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseLearningLogEN objCaseLearningLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCaseLearningLogBL.CaseLearningLogDA.UpdateBySqlWithConditionTransaction(objCaseLearningLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogBL.ReFreshCache();

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCaseLearningLogEN objCaseLearningLogEN)
{
try
{
int intRecNum = clsCaseLearningLogBL.CaseLearningLogDA.DelRecord(objCaseLearningLogEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogBL.ReFreshCache();

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
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
 /// <param name = "objCaseLearningLogENS">源对象</param>
 /// <param name = "objCaseLearningLogENT">目标对象</param>
 public static void CopyTo(this clsCaseLearningLogEN objCaseLearningLogENS, clsCaseLearningLogEN objCaseLearningLogENT)
{
try
{
objCaseLearningLogENT.mId = objCaseLearningLogENS.mId; //mId
objCaseLearningLogENT.FuncModuleId = objCaseLearningLogENS.FuncModuleId; //功能模块Id
objCaseLearningLogENT.CaseId = objCaseLearningLogENS.CaseId; //案例Id
objCaseLearningLogENT.CaseName = objCaseLearningLogENS.CaseName; //案例名称
objCaseLearningLogENT.OwnerId = objCaseLearningLogENS.OwnerId; //拥有者Id
objCaseLearningLogENT.UserId = objCaseLearningLogENS.UserId; //用户ID
objCaseLearningLogENT.LearnStartTime = objCaseLearningLogENS.LearnStartTime; //开始时间
objCaseLearningLogENT.LearnEndTime = objCaseLearningLogENS.LearnEndTime; //结束时间
objCaseLearningLogENT.VideoStartTime = objCaseLearningLogENS.VideoStartTime; //观看视频开始时间
objCaseLearningLogENT.VideoEndTime = objCaseLearningLogENS.VideoEndTime; //观看视频结束时间
objCaseLearningLogENT.IpAddress = objCaseLearningLogENS.IpAddress; //Ip地址
objCaseLearningLogENT.TimeLengthOfVideo = objCaseLearningLogENS.TimeLengthOfVideo; //视频时长
objCaseLearningLogENT.Memo = objCaseLearningLogENS.Memo; //备注
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
 /// <param name = "objCaseLearningLogENS">源对象</param>
 /// <returns>目标对象=>clsCaseLearningLogEN:objCaseLearningLogENT</returns>
 public static clsCaseLearningLogEN CopyTo(this clsCaseLearningLogEN objCaseLearningLogENS)
{
try
{
 clsCaseLearningLogEN objCaseLearningLogENT = new clsCaseLearningLogEN()
{
mId = objCaseLearningLogENS.mId, //mId
FuncModuleId = objCaseLearningLogENS.FuncModuleId, //功能模块Id
CaseId = objCaseLearningLogENS.CaseId, //案例Id
CaseName = objCaseLearningLogENS.CaseName, //案例名称
OwnerId = objCaseLearningLogENS.OwnerId, //拥有者Id
UserId = objCaseLearningLogENS.UserId, //用户ID
LearnStartTime = objCaseLearningLogENS.LearnStartTime, //开始时间
LearnEndTime = objCaseLearningLogENS.LearnEndTime, //结束时间
VideoStartTime = objCaseLearningLogENS.VideoStartTime, //观看视频开始时间
VideoEndTime = objCaseLearningLogENS.VideoEndTime, //观看视频结束时间
IpAddress = objCaseLearningLogENS.IpAddress, //Ip地址
TimeLengthOfVideo = objCaseLearningLogENS.TimeLengthOfVideo, //视频时长
Memo = objCaseLearningLogENS.Memo, //备注
};
 return objCaseLearningLogENT;
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
public static void CheckPropertyNew(this clsCaseLearningLogEN objCaseLearningLogEN)
{
 clsCaseLearningLogBL.CaseLearningLogDA.CheckPropertyNew(objCaseLearningLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCaseLearningLogEN objCaseLearningLogEN)
{
 clsCaseLearningLogBL.CaseLearningLogDA.CheckProperty4Condition(objCaseLearningLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseLearningLogEN objCaseLearningLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.mId) == true)
{
string strComparisonOpmId = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseLearningLog.mId, objCaseLearningLogCond.mId, strComparisonOpmId);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.FuncModuleId, objCaseLearningLogCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.CaseId) == true)
{
string strComparisonOpCaseId = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.CaseId, objCaseLearningLogCond.CaseId, strComparisonOpCaseId);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.CaseName) == true)
{
string strComparisonOpCaseName = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.CaseName, objCaseLearningLogCond.CaseName, strComparisonOpCaseName);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.OwnerId) == true)
{
string strComparisonOpOwnerId = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.OwnerId, objCaseLearningLogCond.OwnerId, strComparisonOpOwnerId);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.UserId) == true)
{
string strComparisonOpUserId = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.UserId, objCaseLearningLogCond.UserId, strComparisonOpUserId);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.LearnStartTime) == true)
{
string strComparisonOpLearnStartTime = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.LearnStartTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.LearnStartTime, objCaseLearningLogCond.LearnStartTime, strComparisonOpLearnStartTime);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.LearnEndTime) == true)
{
string strComparisonOpLearnEndTime = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.LearnEndTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.LearnEndTime, objCaseLearningLogCond.LearnEndTime, strComparisonOpLearnEndTime);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.VideoStartTime) == true)
{
string strComparisonOpVideoStartTime = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.VideoStartTime];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseLearningLog.VideoStartTime, objCaseLearningLogCond.VideoStartTime, strComparisonOpVideoStartTime);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.VideoEndTime) == true)
{
string strComparisonOpVideoEndTime = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.VideoEndTime];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseLearningLog.VideoEndTime, objCaseLearningLogCond.VideoEndTime, strComparisonOpVideoEndTime);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.IpAddress) == true)
{
string strComparisonOpIpAddress = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.IpAddress, objCaseLearningLogCond.IpAddress, strComparisonOpIpAddress);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.TimeLengthOfVideo) == true)
{
string strComparisonOpTimeLengthOfVideo = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.TimeLengthOfVideo];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseLearningLog.TimeLengthOfVideo, objCaseLearningLogCond.TimeLengthOfVideo, strComparisonOpTimeLengthOfVideo);
}
if (objCaseLearningLogCond.IsUpdated(conCaseLearningLog.Memo) == true)
{
string strComparisonOpMemo = objCaseLearningLogCond.dicFldComparisonOp[conCaseLearningLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.Memo, objCaseLearningLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CaseLearningLog(案例学习日志), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CaseId_OwnerId_LearnStartTime_VideoEndTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCaseLearningLogEN objCaseLearningLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCaseLearningLogEN == null) return true;
if (objCaseLearningLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseLearningLogEN.CaseId);
 if (objCaseLearningLogEN.OwnerId == null)
{
 sbCondition.AppendFormat(" and OwnerId is null", objCaseLearningLogEN.OwnerId);
}
else
{
 sbCondition.AppendFormat(" and OwnerId = '{0}'", objCaseLearningLogEN.OwnerId);
}
 sbCondition.AppendFormat(" and LearnStartTime = '{0}'", objCaseLearningLogEN.LearnStartTime);
 sbCondition.AppendFormat(" and VideoEndTime = '{0}'", objCaseLearningLogEN.VideoEndTime);
if (clsCaseLearningLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCaseLearningLogEN.mId);
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseLearningLogEN.CaseId);
 sbCondition.AppendFormat(" and OwnerId = '{0}'", objCaseLearningLogEN.OwnerId);
 sbCondition.AppendFormat(" and LearnStartTime = '{0}'", objCaseLearningLogEN.LearnStartTime);
 sbCondition.AppendFormat(" and VideoEndTime = '{0}'", objCaseLearningLogEN.VideoEndTime);
if (clsCaseLearningLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CaseLearningLog(案例学习日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CaseId_OwnerId_LearnStartTime_VideoEndTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCaseLearningLogEN objCaseLearningLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCaseLearningLogEN == null) return "";
if (objCaseLearningLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseLearningLogEN.CaseId);
 if (objCaseLearningLogEN.OwnerId == null)
{
 sbCondition.AppendFormat(" and OwnerId is null", objCaseLearningLogEN.OwnerId);
}
else
{
 sbCondition.AppendFormat(" and OwnerId = '{0}'", objCaseLearningLogEN.OwnerId);
}
 sbCondition.AppendFormat(" and LearnStartTime = '{0}'", objCaseLearningLogEN.LearnStartTime);
 sbCondition.AppendFormat(" and VideoEndTime = '{0}'", objCaseLearningLogEN.VideoEndTime);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCaseLearningLogEN.mId);
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseLearningLogEN.CaseId);
 sbCondition.AppendFormat(" and OwnerId = '{0}'", objCaseLearningLogEN.OwnerId);
 sbCondition.AppendFormat(" and LearnStartTime = '{0}'", objCaseLearningLogEN.LearnStartTime);
 sbCondition.AppendFormat(" and VideoEndTime = '{0}'", objCaseLearningLogEN.VideoEndTime);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CaseLearningLog
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 案例学习日志(CaseLearningLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCaseLearningLogBL
{
public static RelatedActions_CaseLearningLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCaseLearningLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCaseLearningLogDA CaseLearningLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCaseLearningLogDA();
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
 public clsCaseLearningLogBL()
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
if (string.IsNullOrEmpty(clsCaseLearningLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseLearningLogEN._ConnectString);
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
public static DataTable GetDataTable_CaseLearningLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CaseLearningLogDA.GetDataTable_CaseLearningLog(strWhereCond);
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
objDT = CaseLearningLogDA.GetDataTable(strWhereCond);
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
objDT = CaseLearningLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CaseLearningLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CaseLearningLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CaseLearningLogDA.GetDataTable_Top(objTopPara);
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
objDT = CaseLearningLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CaseLearningLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CaseLearningLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCaseLearningLogEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = Int32.Parse(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = Double.Parse(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = Double.Parse(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseLearningLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCaseLearningLogEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsCaseLearningLogEN._CurrTabName);
List<clsCaseLearningLogEN> arrCaseLearningLogObjLstCache = GetObjLstCache();
IEnumerable <clsCaseLearningLogEN> arrCaseLearningLogObjLst_Sel =
arrCaseLearningLogObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrCaseLearningLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseLearningLogEN> GetObjLst(string strWhereCond)
{
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = Int32.Parse(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = Double.Parse(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = Double.Parse(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseLearningLogEN);
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
public static List<clsCaseLearningLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = Int32.Parse(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = Double.Parse(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = Double.Parse(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseLearningLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCaseLearningLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCaseLearningLogEN> GetSubObjLstCache(clsCaseLearningLogEN objCaseLearningLogCond)
{
List<clsCaseLearningLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseLearningLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseLearningLog.AttributeName)
{
if (objCaseLearningLogCond.IsUpdated(strFldName) == false) continue;
if (objCaseLearningLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseLearningLogCond[strFldName].ToString());
}
else
{
if (objCaseLearningLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseLearningLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseLearningLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseLearningLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseLearningLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseLearningLogCond[strFldName]));
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
public static List<clsCaseLearningLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = Int32.Parse(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = Double.Parse(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = Double.Parse(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseLearningLogEN);
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
public static List<clsCaseLearningLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = Int32.Parse(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = Double.Parse(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = Double.Parse(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseLearningLogEN);
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
List<clsCaseLearningLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCaseLearningLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseLearningLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCaseLearningLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
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
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = Int32.Parse(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = Double.Parse(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = Double.Parse(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseLearningLogEN);
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
public static List<clsCaseLearningLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = Int32.Parse(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = Double.Parse(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = Double.Parse(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseLearningLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCaseLearningLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCaseLearningLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = Int32.Parse(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = Double.Parse(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = Double.Parse(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseLearningLogEN);
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
public static List<clsCaseLearningLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = Int32.Parse(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = Double.Parse(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = Double.Parse(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseLearningLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseLearningLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCaseLearningLogEN> arrObjLst = new List<clsCaseLearningLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseLearningLogEN objCaseLearningLogEN = new clsCaseLearningLogEN();
try
{
objCaseLearningLogEN.mId = Int32.Parse(objRow[conCaseLearningLog.mId].ToString().Trim()); //mId
objCaseLearningLogEN.FuncModuleId = objRow[conCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseLearningLogEN.CaseId = objRow[conCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objCaseLearningLogEN.CaseName = objRow[conCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[conCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objCaseLearningLogEN.OwnerId = objRow[conCaseLearningLog.OwnerId] == DBNull.Value ? null : objRow[conCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objCaseLearningLogEN.UserId = objRow[conCaseLearningLog.UserId].ToString().Trim(); //用户ID
objCaseLearningLogEN.LearnStartTime = objRow[conCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objCaseLearningLogEN.LearnEndTime = objRow[conCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objCaseLearningLogEN.VideoStartTime = Double.Parse(objRow[conCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objCaseLearningLogEN.VideoEndTime = Double.Parse(objRow[conCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objCaseLearningLogEN.IpAddress = objRow[conCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[conCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objCaseLearningLogEN.TimeLengthOfVideo = objRow[conCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objCaseLearningLogEN.Memo = objRow[conCaseLearningLog.Memo] == DBNull.Value ? null : objRow[conCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseLearningLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCaseLearningLog(ref clsCaseLearningLogEN objCaseLearningLogEN)
{
bool bolResult = CaseLearningLogDA.GetCaseLearningLog(ref objCaseLearningLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseLearningLogEN GetObjBymId(long lngmId)
{
clsCaseLearningLogEN objCaseLearningLogEN = CaseLearningLogDA.GetObjBymId(lngmId);
return objCaseLearningLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCaseLearningLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCaseLearningLogEN objCaseLearningLogEN = CaseLearningLogDA.GetFirstObj(strWhereCond);
 return objCaseLearningLogEN;
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
public static clsCaseLearningLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCaseLearningLogEN objCaseLearningLogEN = CaseLearningLogDA.GetObjByDataRow(objRow);
 return objCaseLearningLogEN;
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
public static clsCaseLearningLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCaseLearningLogEN objCaseLearningLogEN = CaseLearningLogDA.GetObjByDataRow(objRow);
 return objCaseLearningLogEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstCaseLearningLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseLearningLogEN GetObjBymIdFromList(long lngmId, List<clsCaseLearningLogEN> lstCaseLearningLogObjLst)
{
foreach (clsCaseLearningLogEN objCaseLearningLogEN in lstCaseLearningLogObjLst)
{
if (objCaseLearningLogEN.mId == lngmId)
{
return objCaseLearningLogEN;
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
 long lngmId;
 try
 {
 lngmId = new clsCaseLearningLogDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = CaseLearningLogDA.GetID(strWhereCond);
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
bool bolIsExist = CaseLearningLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = CaseLearningLogDA.IsExist(lngmId);
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
 bolIsExist = clsCaseLearningLogDA.IsExistTable();
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
 bolIsExist = CaseLearningLogDA.IsExistTable(strTabName);
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
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCaseLearningLogEN objCaseLearningLogEN)
{
if (objCaseLearningLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],拥有者Id = [{1}],开始时间 = [{2}],观看视频结束时间 = [{3}]的数据已经存在!(in clsCaseLearningLogBL.AddNewRecordBySql2)", objCaseLearningLogEN.CaseId,objCaseLearningLogEN.OwnerId,objCaseLearningLogEN.LearnStartTime,objCaseLearningLogEN.VideoEndTime);
throw new Exception(strMsg);
}
try
{
bool bolResult = CaseLearningLogDA.AddNewRecordBySQL2(objCaseLearningLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogBL.ReFreshCache();

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
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
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCaseLearningLogEN objCaseLearningLogEN)
{
if (objCaseLearningLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],拥有者Id = [{1}],开始时间 = [{2}],观看视频结束时间 = [{3}]的数据已经存在!(in clsCaseLearningLogBL.AddNewRecordBySql2WithReturnKey)", objCaseLearningLogEN.CaseId,objCaseLearningLogEN.OwnerId,objCaseLearningLogEN.LearnStartTime,objCaseLearningLogEN.VideoEndTime);
throw new Exception(strMsg);
}
try
{
string strKey = CaseLearningLogDA.AddNewRecordBySQL2WithReturnKey(objCaseLearningLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogBL.ReFreshCache();

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
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
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCaseLearningLogEN objCaseLearningLogEN)
{
try
{
bool bolResult = CaseLearningLogDA.Update(objCaseLearningLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogBL.ReFreshCache();

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
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
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCaseLearningLogEN objCaseLearningLogEN)
{
 if (objCaseLearningLogEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CaseLearningLogDA.UpdateBySql2(objCaseLearningLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogBL.ReFreshCache();

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsCaseLearningLogEN objCaseLearningLogEN = clsCaseLearningLogBL.GetObjBymId(lngmId);

if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(objCaseLearningLogEN.mId, "SetUpdDate");
}
if (objCaseLearningLogEN != null)
{
int intRecNum = CaseLearningLogDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
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
//删除与表:[CaseLearningLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCaseLearningLog.mId,
//lngmId);
//        clsCaseLearningLogBL.DelCaseLearningLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseLearningLogBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseLearningLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCaseLearningLogBL.relatedActions != null)
{
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = CaseLearningLogDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCaseLearningLogs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsCaseLearningLogBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = CaseLearningLogDA.DelCaseLearningLog(arrmIdLst);
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
public static int DelCaseLearningLogsByCond(string strWhereCond)
{
try
{
if (clsCaseLearningLogBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsCaseLearningLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = CaseLearningLogDA.DelCaseLearningLog(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CaseLearningLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseLearningLogDA.GetSpecSQLObj();
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
//删除与表:[CaseLearningLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseLearningLogBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseLearningLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCaseLearningLogENS">源对象</param>
 /// <param name = "objCaseLearningLogENT">目标对象</param>
 public static void CopyTo(clsCaseLearningLogEN objCaseLearningLogENS, clsCaseLearningLogEN objCaseLearningLogENT)
{
try
{
objCaseLearningLogENT.mId = objCaseLearningLogENS.mId; //mId
objCaseLearningLogENT.FuncModuleId = objCaseLearningLogENS.FuncModuleId; //功能模块Id
objCaseLearningLogENT.CaseId = objCaseLearningLogENS.CaseId; //案例Id
objCaseLearningLogENT.CaseName = objCaseLearningLogENS.CaseName; //案例名称
objCaseLearningLogENT.OwnerId = objCaseLearningLogENS.OwnerId; //拥有者Id
objCaseLearningLogENT.UserId = objCaseLearningLogENS.UserId; //用户ID
objCaseLearningLogENT.LearnStartTime = objCaseLearningLogENS.LearnStartTime; //开始时间
objCaseLearningLogENT.LearnEndTime = objCaseLearningLogENS.LearnEndTime; //结束时间
objCaseLearningLogENT.VideoStartTime = objCaseLearningLogENS.VideoStartTime; //观看视频开始时间
objCaseLearningLogENT.VideoEndTime = objCaseLearningLogENS.VideoEndTime; //观看视频结束时间
objCaseLearningLogENT.IpAddress = objCaseLearningLogENS.IpAddress; //Ip地址
objCaseLearningLogENT.TimeLengthOfVideo = objCaseLearningLogENS.TimeLengthOfVideo; //视频时长
objCaseLearningLogENT.Memo = objCaseLearningLogENS.Memo; //备注
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
 /// <param name = "objCaseLearningLogEN">源简化对象</param>
 public static void SetUpdFlag(clsCaseLearningLogEN objCaseLearningLogEN)
{
try
{
objCaseLearningLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCaseLearningLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCaseLearningLog.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.mId = objCaseLearningLogEN.mId; //mId
}
if (arrFldSet.Contains(conCaseLearningLog.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.FuncModuleId = objCaseLearningLogEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conCaseLearningLog.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.CaseId = objCaseLearningLogEN.CaseId; //案例Id
}
if (arrFldSet.Contains(conCaseLearningLog.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.CaseName = objCaseLearningLogEN.CaseName == "[null]" ? null :  objCaseLearningLogEN.CaseName; //案例名称
}
if (arrFldSet.Contains(conCaseLearningLog.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.OwnerId = objCaseLearningLogEN.OwnerId == "[null]" ? null :  objCaseLearningLogEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(conCaseLearningLog.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.UserId = objCaseLearningLogEN.UserId; //用户ID
}
if (arrFldSet.Contains(conCaseLearningLog.LearnStartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.LearnStartTime = objCaseLearningLogEN.LearnStartTime; //开始时间
}
if (arrFldSet.Contains(conCaseLearningLog.LearnEndTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.LearnEndTime = objCaseLearningLogEN.LearnEndTime; //结束时间
}
if (arrFldSet.Contains(conCaseLearningLog.VideoStartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.VideoStartTime = objCaseLearningLogEN.VideoStartTime; //观看视频开始时间
}
if (arrFldSet.Contains(conCaseLearningLog.VideoEndTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.VideoEndTime = objCaseLearningLogEN.VideoEndTime; //观看视频结束时间
}
if (arrFldSet.Contains(conCaseLearningLog.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.IpAddress = objCaseLearningLogEN.IpAddress == "[null]" ? null :  objCaseLearningLogEN.IpAddress; //Ip地址
}
if (arrFldSet.Contains(conCaseLearningLog.TimeLengthOfVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.TimeLengthOfVideo = objCaseLearningLogEN.TimeLengthOfVideo; //视频时长
}
if (arrFldSet.Contains(conCaseLearningLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseLearningLogEN.Memo = objCaseLearningLogEN.Memo == "[null]" ? null :  objCaseLearningLogEN.Memo; //备注
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
 /// <param name = "objCaseLearningLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsCaseLearningLogEN objCaseLearningLogEN)
{
try
{
if (objCaseLearningLogEN.CaseName == "[null]") objCaseLearningLogEN.CaseName = null; //案例名称
if (objCaseLearningLogEN.OwnerId == "[null]") objCaseLearningLogEN.OwnerId = null; //拥有者Id
if (objCaseLearningLogEN.IpAddress == "[null]") objCaseLearningLogEN.IpAddress = null; //Ip地址
if (objCaseLearningLogEN.Memo == "[null]") objCaseLearningLogEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCaseLearningLogEN objCaseLearningLogEN)
{
 CaseLearningLogDA.CheckPropertyNew(objCaseLearningLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCaseLearningLogEN objCaseLearningLogEN)
{
 CaseLearningLogDA.CheckProperty4Condition(objCaseLearningLogEN);
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
if (clsCaseLearningLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLearningLogBL没有刷新缓存机制(clsCaseLearningLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCaseLearningLogObjLstCache == null)
//{
//arrCaseLearningLogObjLstCache = CaseLearningLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseLearningLogEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCaseLearningLogEN._CurrTabName);
List<clsCaseLearningLogEN> arrCaseLearningLogObjLstCache = GetObjLstCache();
IEnumerable <clsCaseLearningLogEN> arrCaseLearningLogObjLst_Sel =
arrCaseLearningLogObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrCaseLearningLogObjLst_Sel.Count() == 0)
{
   clsCaseLearningLogEN obj = clsCaseLearningLogBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCaseLearningLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseLearningLogEN> GetAllCaseLearningLogObjLstCache()
{
//获取缓存中的对象列表
List<clsCaseLearningLogEN> arrCaseLearningLogObjLstCache = GetObjLstCache(); 
return arrCaseLearningLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseLearningLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCaseLearningLogEN._CurrTabName);
List<clsCaseLearningLogEN> arrCaseLearningLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseLearningLogObjLstCache;
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
string strKey = string.Format("{0}", clsCaseLearningLogEN._CurrTabName);
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
public static void ReFreshCache()
{
if (clsCaseLearningLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseLearningLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCaseLearningLogBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CaseLearningLog(案例学习日志)
 /// 唯一性条件:CaseId_OwnerId_LearnStartTime_VideoEndTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCaseLearningLogEN objCaseLearningLogEN)
{
//检测记录是否存在
string strResult = CaseLearningLogDA.GetUniCondStr(objCaseLearningLogEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conCaseLearningLog.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCaseLearningLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCaseLearningLog.AttributeName));
throw new Exception(strMsg);
}
var objCaseLearningLog = clsCaseLearningLogBL.GetObjBymIdCache(lngmId);
if (objCaseLearningLog == null) return "";
return objCaseLearningLog[strOutFldName].ToString();
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
int intRecCount = clsCaseLearningLogDA.GetRecCount(strTabName);
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
int intRecCount = clsCaseLearningLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCaseLearningLogDA.GetRecCount();
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
int intRecCount = clsCaseLearningLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCaseLearningLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCaseLearningLogEN objCaseLearningLogCond)
{
List<clsCaseLearningLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseLearningLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseLearningLog.AttributeName)
{
if (objCaseLearningLogCond.IsUpdated(strFldName) == false) continue;
if (objCaseLearningLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseLearningLogCond[strFldName].ToString());
}
else
{
if (objCaseLearningLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseLearningLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseLearningLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseLearningLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseLearningLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseLearningLogCond[strFldName]));
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
 List<string> arrList = clsCaseLearningLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CaseLearningLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CaseLearningLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CaseLearningLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseLearningLogDA.SetFldValue(clsCaseLearningLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CaseLearningLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseLearningLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseLearningLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseLearningLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CaseLearningLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) not Null, "); 
 // /**案例Id*/ 
 strCreateTabCode.Append(" CaseId char(8) not Null, "); 
 // /**案例名称*/ 
 strCreateTabCode.Append(" CaseName varchar(100) Null, "); 
 // /**拥有者Id*/ 
 strCreateTabCode.Append(" OwnerId varchar(20) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**开始时间*/ 
 strCreateTabCode.Append(" LearnStartTime varchar(14) not Null, "); 
 // /**结束时间*/ 
 strCreateTabCode.Append(" LearnEndTime varchar(14) not Null, "); 
 // /**观看视频开始时间*/ 
 strCreateTabCode.Append(" VideoStartTime decimal(10,2) not Null, "); 
 // /**观看视频结束时间*/ 
 strCreateTabCode.Append(" VideoEndTime decimal(10,2) not Null, "); 
 // /**Ip地址*/ 
 strCreateTabCode.Append(" IpAddress varchar(50) Null, "); 
 // /**视频时长*/ 
 strCreateTabCode.Append(" TimeLengthOfVideo decimal(12,2) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 案例学习日志(CaseLearningLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CaseLearningLog : clsCommFun4BL
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
clsCaseLearningLogBL.ReFreshThisCache();
}
}

}