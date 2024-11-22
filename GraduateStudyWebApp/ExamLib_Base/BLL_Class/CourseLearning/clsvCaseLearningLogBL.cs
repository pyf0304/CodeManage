
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseLearningLogBL
 表名:vCaseLearningLog(01120366)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:42
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
public static class  clsvCaseLearningLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseLearningLogEN GetObj(this K_mId_vCaseLearningLog myKey)
{
clsvCaseLearningLogEN objvCaseLearningLogEN = clsvCaseLearningLogBL.vCaseLearningLogDA.GetObjBymId(myKey.Value);
return objvCaseLearningLogEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetmId(this clsvCaseLearningLogEN objvCaseLearningLogEN, long lngmId, string strComparisonOp="")
	{
objvCaseLearningLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.mId) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.mId, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.mId] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetFuncModuleId(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseLearningLog.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseLearningLog.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseLearningLog.FuncModuleId);
}
objvCaseLearningLogEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.FuncModuleId) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.FuncModuleId, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.FuncModuleId] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetFuncModuleName(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseLearningLog.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseLearningLog.FuncModuleName);
}
objvCaseLearningLogEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.FuncModuleName) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.FuncModuleName, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.FuncModuleName] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetCaseId(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strCaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, convCaseLearningLog.CaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, convCaseLearningLog.CaseId);
}
objvCaseLearningLogEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.CaseId) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.CaseId, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.CaseId] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetCaseName(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 100, convCaseLearningLog.CaseName);
}
objvCaseLearningLogEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.CaseName) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.CaseName, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.CaseName] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetOwnerId(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCaseLearningLog.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCaseLearningLog.OwnerId);
}
objvCaseLearningLogEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.OwnerId) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.OwnerId, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.OwnerId] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetUserId(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convCaseLearningLog.UserId);
}
objvCaseLearningLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.UserId) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.UserId, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.UserId] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetUserName(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convCaseLearningLog.UserName);
}
objvCaseLearningLogEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.UserName) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.UserName, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.UserName] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetLearnStartTime(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strLearnStartTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnStartTime, convCaseLearningLog.LearnStartTime);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLearnStartTime, 14, convCaseLearningLog.LearnStartTime);
}
objvCaseLearningLogEN.LearnStartTime = strLearnStartTime; //开始时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.LearnStartTime) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.LearnStartTime, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.LearnStartTime] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetLearnEndTime(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strLearnEndTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnEndTime, convCaseLearningLog.LearnEndTime);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLearnEndTime, 14, convCaseLearningLog.LearnEndTime);
}
objvCaseLearningLogEN.LearnEndTime = strLearnEndTime; //结束时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.LearnEndTime) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.LearnEndTime, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.LearnEndTime] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetVideoStartTime(this clsvCaseLearningLogEN objvCaseLearningLogEN, double? dblVideoStartTime, string strComparisonOp="")
	{
objvCaseLearningLogEN.VideoStartTime = dblVideoStartTime; //观看视频开始时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.VideoStartTime) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.VideoStartTime, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.VideoStartTime] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetVideoEndTime(this clsvCaseLearningLogEN objvCaseLearningLogEN, double? dblVideoEndTime, string strComparisonOp="")
	{
objvCaseLearningLogEN.VideoEndTime = dblVideoEndTime; //观看视频结束时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.VideoEndTime) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.VideoEndTime, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.VideoEndTime] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetTimeLengthOfVideo(this clsvCaseLearningLogEN objvCaseLearningLogEN, double? dblTimeLengthOfVideo, string strComparisonOp="")
	{
objvCaseLearningLogEN.TimeLengthOfVideo = dblTimeLengthOfVideo; //视频时长
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.TimeLengthOfVideo) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.TimeLengthOfVideo, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.TimeLengthOfVideo] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetIpAddress(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 50, convCaseLearningLog.IpAddress);
}
objvCaseLearningLogEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.IpAddress) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.IpAddress, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.IpAddress] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseLearningLogEN SetMemo(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseLearningLog.Memo);
}
objvCaseLearningLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseLearningLogEN.dicFldComparisonOp.ContainsKey(convCaseLearningLog.Memo) == false)
{
objvCaseLearningLogEN.dicFldComparisonOp.Add(convCaseLearningLog.Memo, strComparisonOp);
}
else
{
objvCaseLearningLogEN.dicFldComparisonOp[convCaseLearningLog.Memo] = strComparisonOp;
}
}
return objvCaseLearningLogEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCaseLearningLogENS">源对象</param>
 /// <param name = "objvCaseLearningLogENT">目标对象</param>
 public static void CopyTo(this clsvCaseLearningLogEN objvCaseLearningLogENS, clsvCaseLearningLogEN objvCaseLearningLogENT)
{
try
{
objvCaseLearningLogENT.mId = objvCaseLearningLogENS.mId; //mId
objvCaseLearningLogENT.FuncModuleId = objvCaseLearningLogENS.FuncModuleId; //功能模块Id
objvCaseLearningLogENT.FuncModuleName = objvCaseLearningLogENS.FuncModuleName; //功能模块名称
objvCaseLearningLogENT.CaseId = objvCaseLearningLogENS.CaseId; //案例Id
objvCaseLearningLogENT.CaseName = objvCaseLearningLogENS.CaseName; //案例名称
objvCaseLearningLogENT.OwnerId = objvCaseLearningLogENS.OwnerId; //拥有者Id
objvCaseLearningLogENT.UserId = objvCaseLearningLogENS.UserId; //用户ID
objvCaseLearningLogENT.UserName = objvCaseLearningLogENS.UserName; //用户名
objvCaseLearningLogENT.LearnStartTime = objvCaseLearningLogENS.LearnStartTime; //开始时间
objvCaseLearningLogENT.LearnEndTime = objvCaseLearningLogENS.LearnEndTime; //结束时间
objvCaseLearningLogENT.VideoStartTime = objvCaseLearningLogENS.VideoStartTime; //观看视频开始时间
objvCaseLearningLogENT.VideoEndTime = objvCaseLearningLogENS.VideoEndTime; //观看视频结束时间
objvCaseLearningLogENT.TimeLengthOfVideo = objvCaseLearningLogENS.TimeLengthOfVideo; //视频时长
objvCaseLearningLogENT.IpAddress = objvCaseLearningLogENS.IpAddress; //Ip地址
objvCaseLearningLogENT.Memo = objvCaseLearningLogENS.Memo; //备注
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
 /// <param name = "objvCaseLearningLogENS">源对象</param>
 /// <returns>目标对象=>clsvCaseLearningLogEN:objvCaseLearningLogENT</returns>
 public static clsvCaseLearningLogEN CopyTo(this clsvCaseLearningLogEN objvCaseLearningLogENS)
{
try
{
 clsvCaseLearningLogEN objvCaseLearningLogENT = new clsvCaseLearningLogEN()
{
mId = objvCaseLearningLogENS.mId, //mId
FuncModuleId = objvCaseLearningLogENS.FuncModuleId, //功能模块Id
FuncModuleName = objvCaseLearningLogENS.FuncModuleName, //功能模块名称
CaseId = objvCaseLearningLogENS.CaseId, //案例Id
CaseName = objvCaseLearningLogENS.CaseName, //案例名称
OwnerId = objvCaseLearningLogENS.OwnerId, //拥有者Id
UserId = objvCaseLearningLogENS.UserId, //用户ID
UserName = objvCaseLearningLogENS.UserName, //用户名
LearnStartTime = objvCaseLearningLogENS.LearnStartTime, //开始时间
LearnEndTime = objvCaseLearningLogENS.LearnEndTime, //结束时间
VideoStartTime = objvCaseLearningLogENS.VideoStartTime, //观看视频开始时间
VideoEndTime = objvCaseLearningLogENS.VideoEndTime, //观看视频结束时间
TimeLengthOfVideo = objvCaseLearningLogENS.TimeLengthOfVideo, //视频时长
IpAddress = objvCaseLearningLogENS.IpAddress, //Ip地址
Memo = objvCaseLearningLogENS.Memo, //备注
};
 return objvCaseLearningLogENT;
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvCaseLearningLogEN objvCaseLearningLogEN)
{
 clsvCaseLearningLogBL.vCaseLearningLogDA.CheckProperty4Condition(objvCaseLearningLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseLearningLogEN objvCaseLearningLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.mId) == true)
{
string strComparisonOpmId = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseLearningLog.mId, objvCaseLearningLogCond.mId, strComparisonOpmId);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.FuncModuleId, objvCaseLearningLogCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.FuncModuleName, objvCaseLearningLogCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.CaseId) == true)
{
string strComparisonOpCaseId = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.CaseId, objvCaseLearningLogCond.CaseId, strComparisonOpCaseId);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.CaseName) == true)
{
string strComparisonOpCaseName = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.CaseName, objvCaseLearningLogCond.CaseName, strComparisonOpCaseName);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.OwnerId) == true)
{
string strComparisonOpOwnerId = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.OwnerId, objvCaseLearningLogCond.OwnerId, strComparisonOpOwnerId);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.UserId) == true)
{
string strComparisonOpUserId = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.UserId, objvCaseLearningLogCond.UserId, strComparisonOpUserId);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.UserName) == true)
{
string strComparisonOpUserName = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.UserName, objvCaseLearningLogCond.UserName, strComparisonOpUserName);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.LearnStartTime) == true)
{
string strComparisonOpLearnStartTime = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.LearnStartTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.LearnStartTime, objvCaseLearningLogCond.LearnStartTime, strComparisonOpLearnStartTime);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.LearnEndTime) == true)
{
string strComparisonOpLearnEndTime = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.LearnEndTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.LearnEndTime, objvCaseLearningLogCond.LearnEndTime, strComparisonOpLearnEndTime);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.VideoStartTime) == true)
{
string strComparisonOpVideoStartTime = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.VideoStartTime];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseLearningLog.VideoStartTime, objvCaseLearningLogCond.VideoStartTime, strComparisonOpVideoStartTime);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.VideoEndTime) == true)
{
string strComparisonOpVideoEndTime = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.VideoEndTime];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseLearningLog.VideoEndTime, objvCaseLearningLogCond.VideoEndTime, strComparisonOpVideoEndTime);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.TimeLengthOfVideo) == true)
{
string strComparisonOpTimeLengthOfVideo = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.TimeLengthOfVideo];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseLearningLog.TimeLengthOfVideo, objvCaseLearningLogCond.TimeLengthOfVideo, strComparisonOpTimeLengthOfVideo);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.IpAddress) == true)
{
string strComparisonOpIpAddress = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.IpAddress, objvCaseLearningLogCond.IpAddress, strComparisonOpIpAddress);
}
if (objvCaseLearningLogCond.IsUpdated(convCaseLearningLog.Memo) == true)
{
string strComparisonOpMemo = objvCaseLearningLogCond.dicFldComparisonOp[convCaseLearningLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.Memo, objvCaseLearningLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCaseLearningLog
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v案例学习日志(vCaseLearningLog)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCaseLearningLogBL
{
public static RelatedActions_vCaseLearningLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCaseLearningLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCaseLearningLogDA vCaseLearningLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCaseLearningLogDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCaseLearningLogBL()
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
if (string.IsNullOrEmpty(clsvCaseLearningLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCaseLearningLogEN._ConnectString);
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
public static DataTable GetDataTable_vCaseLearningLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCaseLearningLogDA.GetDataTable_vCaseLearningLog(strWhereCond);
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
objDT = vCaseLearningLogDA.GetDataTable(strWhereCond);
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
objDT = vCaseLearningLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCaseLearningLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCaseLearningLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCaseLearningLogDA.GetDataTable_Top(objTopPara);
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
objDT = vCaseLearningLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCaseLearningLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCaseLearningLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvCaseLearningLogEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvCaseLearningLogEN> arrObjLst = new List<clsvCaseLearningLogEN>(); 
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
	clsvCaseLearningLogEN objvCaseLearningLogEN = new clsvCaseLearningLogEN();
try
{
objvCaseLearningLogEN.mId = Int32.Parse(objRow[convCaseLearningLog.mId].ToString().Trim()); //mId
objvCaseLearningLogEN.FuncModuleId = objRow[convCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseLearningLogEN.FuncModuleName = objRow[convCaseLearningLog.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseLearningLogEN.CaseId = objRow[convCaseLearningLog.CaseId] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objvCaseLearningLogEN.CaseName = objRow[convCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objvCaseLearningLogEN.OwnerId = objRow[convCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objvCaseLearningLogEN.UserId = objRow[convCaseLearningLog.UserId] == DBNull.Value ? null : objRow[convCaseLearningLog.UserId].ToString().Trim(); //用户ID
objvCaseLearningLogEN.UserName = objRow[convCaseLearningLog.UserName] == DBNull.Value ? null : objRow[convCaseLearningLog.UserName].ToString().Trim(); //用户名
objvCaseLearningLogEN.LearnStartTime = objRow[convCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objvCaseLearningLogEN.LearnEndTime = objRow[convCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objvCaseLearningLogEN.VideoStartTime = objRow[convCaseLearningLog.VideoStartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objvCaseLearningLogEN.VideoEndTime = objRow[convCaseLearningLog.VideoEndTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objvCaseLearningLogEN.TimeLengthOfVideo = objRow[convCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objvCaseLearningLogEN.IpAddress = objRow[convCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[convCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objvCaseLearningLogEN.Memo = objRow[convCaseLearningLog.Memo] == DBNull.Value ? null : objRow[convCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseLearningLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCaseLearningLogEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvCaseLearningLogEN._CurrTabName);
List<clsvCaseLearningLogEN> arrvCaseLearningLogObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseLearningLogEN> arrvCaseLearningLogObjLst_Sel =
arrvCaseLearningLogObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvCaseLearningLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseLearningLogEN> GetObjLst(string strWhereCond)
{
List<clsvCaseLearningLogEN> arrObjLst = new List<clsvCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseLearningLogEN objvCaseLearningLogEN = new clsvCaseLearningLogEN();
try
{
objvCaseLearningLogEN.mId = Int32.Parse(objRow[convCaseLearningLog.mId].ToString().Trim()); //mId
objvCaseLearningLogEN.FuncModuleId = objRow[convCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseLearningLogEN.FuncModuleName = objRow[convCaseLearningLog.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseLearningLogEN.CaseId = objRow[convCaseLearningLog.CaseId] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objvCaseLearningLogEN.CaseName = objRow[convCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objvCaseLearningLogEN.OwnerId = objRow[convCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objvCaseLearningLogEN.UserId = objRow[convCaseLearningLog.UserId] == DBNull.Value ? null : objRow[convCaseLearningLog.UserId].ToString().Trim(); //用户ID
objvCaseLearningLogEN.UserName = objRow[convCaseLearningLog.UserName] == DBNull.Value ? null : objRow[convCaseLearningLog.UserName].ToString().Trim(); //用户名
objvCaseLearningLogEN.LearnStartTime = objRow[convCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objvCaseLearningLogEN.LearnEndTime = objRow[convCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objvCaseLearningLogEN.VideoStartTime = objRow[convCaseLearningLog.VideoStartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objvCaseLearningLogEN.VideoEndTime = objRow[convCaseLearningLog.VideoEndTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objvCaseLearningLogEN.TimeLengthOfVideo = objRow[convCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objvCaseLearningLogEN.IpAddress = objRow[convCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[convCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objvCaseLearningLogEN.Memo = objRow[convCaseLearningLog.Memo] == DBNull.Value ? null : objRow[convCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseLearningLogEN);
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
public static List<clsvCaseLearningLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCaseLearningLogEN> arrObjLst = new List<clsvCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseLearningLogEN objvCaseLearningLogEN = new clsvCaseLearningLogEN();
try
{
objvCaseLearningLogEN.mId = Int32.Parse(objRow[convCaseLearningLog.mId].ToString().Trim()); //mId
objvCaseLearningLogEN.FuncModuleId = objRow[convCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseLearningLogEN.FuncModuleName = objRow[convCaseLearningLog.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseLearningLogEN.CaseId = objRow[convCaseLearningLog.CaseId] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objvCaseLearningLogEN.CaseName = objRow[convCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objvCaseLearningLogEN.OwnerId = objRow[convCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objvCaseLearningLogEN.UserId = objRow[convCaseLearningLog.UserId] == DBNull.Value ? null : objRow[convCaseLearningLog.UserId].ToString().Trim(); //用户ID
objvCaseLearningLogEN.UserName = objRow[convCaseLearningLog.UserName] == DBNull.Value ? null : objRow[convCaseLearningLog.UserName].ToString().Trim(); //用户名
objvCaseLearningLogEN.LearnStartTime = objRow[convCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objvCaseLearningLogEN.LearnEndTime = objRow[convCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objvCaseLearningLogEN.VideoStartTime = objRow[convCaseLearningLog.VideoStartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objvCaseLearningLogEN.VideoEndTime = objRow[convCaseLearningLog.VideoEndTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objvCaseLearningLogEN.TimeLengthOfVideo = objRow[convCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objvCaseLearningLogEN.IpAddress = objRow[convCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[convCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objvCaseLearningLogEN.Memo = objRow[convCaseLearningLog.Memo] == DBNull.Value ? null : objRow[convCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseLearningLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCaseLearningLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCaseLearningLogEN> GetSubObjLstCache(clsvCaseLearningLogEN objvCaseLearningLogCond)
{
List<clsvCaseLearningLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseLearningLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseLearningLog.AttributeName)
{
if (objvCaseLearningLogCond.IsUpdated(strFldName) == false) continue;
if (objvCaseLearningLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseLearningLogCond[strFldName].ToString());
}
else
{
if (objvCaseLearningLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseLearningLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseLearningLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseLearningLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseLearningLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseLearningLogCond[strFldName]));
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
public static List<clsvCaseLearningLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCaseLearningLogEN> arrObjLst = new List<clsvCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseLearningLogEN objvCaseLearningLogEN = new clsvCaseLearningLogEN();
try
{
objvCaseLearningLogEN.mId = Int32.Parse(objRow[convCaseLearningLog.mId].ToString().Trim()); //mId
objvCaseLearningLogEN.FuncModuleId = objRow[convCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseLearningLogEN.FuncModuleName = objRow[convCaseLearningLog.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseLearningLogEN.CaseId = objRow[convCaseLearningLog.CaseId] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objvCaseLearningLogEN.CaseName = objRow[convCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objvCaseLearningLogEN.OwnerId = objRow[convCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objvCaseLearningLogEN.UserId = objRow[convCaseLearningLog.UserId] == DBNull.Value ? null : objRow[convCaseLearningLog.UserId].ToString().Trim(); //用户ID
objvCaseLearningLogEN.UserName = objRow[convCaseLearningLog.UserName] == DBNull.Value ? null : objRow[convCaseLearningLog.UserName].ToString().Trim(); //用户名
objvCaseLearningLogEN.LearnStartTime = objRow[convCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objvCaseLearningLogEN.LearnEndTime = objRow[convCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objvCaseLearningLogEN.VideoStartTime = objRow[convCaseLearningLog.VideoStartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objvCaseLearningLogEN.VideoEndTime = objRow[convCaseLearningLog.VideoEndTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objvCaseLearningLogEN.TimeLengthOfVideo = objRow[convCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objvCaseLearningLogEN.IpAddress = objRow[convCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[convCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objvCaseLearningLogEN.Memo = objRow[convCaseLearningLog.Memo] == DBNull.Value ? null : objRow[convCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseLearningLogEN);
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
public static List<clsvCaseLearningLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCaseLearningLogEN> arrObjLst = new List<clsvCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseLearningLogEN objvCaseLearningLogEN = new clsvCaseLearningLogEN();
try
{
objvCaseLearningLogEN.mId = Int32.Parse(objRow[convCaseLearningLog.mId].ToString().Trim()); //mId
objvCaseLearningLogEN.FuncModuleId = objRow[convCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseLearningLogEN.FuncModuleName = objRow[convCaseLearningLog.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseLearningLogEN.CaseId = objRow[convCaseLearningLog.CaseId] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objvCaseLearningLogEN.CaseName = objRow[convCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objvCaseLearningLogEN.OwnerId = objRow[convCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objvCaseLearningLogEN.UserId = objRow[convCaseLearningLog.UserId] == DBNull.Value ? null : objRow[convCaseLearningLog.UserId].ToString().Trim(); //用户ID
objvCaseLearningLogEN.UserName = objRow[convCaseLearningLog.UserName] == DBNull.Value ? null : objRow[convCaseLearningLog.UserName].ToString().Trim(); //用户名
objvCaseLearningLogEN.LearnStartTime = objRow[convCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objvCaseLearningLogEN.LearnEndTime = objRow[convCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objvCaseLearningLogEN.VideoStartTime = objRow[convCaseLearningLog.VideoStartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objvCaseLearningLogEN.VideoEndTime = objRow[convCaseLearningLog.VideoEndTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objvCaseLearningLogEN.TimeLengthOfVideo = objRow[convCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objvCaseLearningLogEN.IpAddress = objRow[convCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[convCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objvCaseLearningLogEN.Memo = objRow[convCaseLearningLog.Memo] == DBNull.Value ? null : objRow[convCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseLearningLogEN);
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
List<clsvCaseLearningLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCaseLearningLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseLearningLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCaseLearningLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseLearningLogEN> arrObjLst = new List<clsvCaseLearningLogEN>(); 
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
	clsvCaseLearningLogEN objvCaseLearningLogEN = new clsvCaseLearningLogEN();
try
{
objvCaseLearningLogEN.mId = Int32.Parse(objRow[convCaseLearningLog.mId].ToString().Trim()); //mId
objvCaseLearningLogEN.FuncModuleId = objRow[convCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseLearningLogEN.FuncModuleName = objRow[convCaseLearningLog.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseLearningLogEN.CaseId = objRow[convCaseLearningLog.CaseId] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objvCaseLearningLogEN.CaseName = objRow[convCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objvCaseLearningLogEN.OwnerId = objRow[convCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objvCaseLearningLogEN.UserId = objRow[convCaseLearningLog.UserId] == DBNull.Value ? null : objRow[convCaseLearningLog.UserId].ToString().Trim(); //用户ID
objvCaseLearningLogEN.UserName = objRow[convCaseLearningLog.UserName] == DBNull.Value ? null : objRow[convCaseLearningLog.UserName].ToString().Trim(); //用户名
objvCaseLearningLogEN.LearnStartTime = objRow[convCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objvCaseLearningLogEN.LearnEndTime = objRow[convCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objvCaseLearningLogEN.VideoStartTime = objRow[convCaseLearningLog.VideoStartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objvCaseLearningLogEN.VideoEndTime = objRow[convCaseLearningLog.VideoEndTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objvCaseLearningLogEN.TimeLengthOfVideo = objRow[convCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objvCaseLearningLogEN.IpAddress = objRow[convCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[convCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objvCaseLearningLogEN.Memo = objRow[convCaseLearningLog.Memo] == DBNull.Value ? null : objRow[convCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseLearningLogEN);
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
public static List<clsvCaseLearningLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCaseLearningLogEN> arrObjLst = new List<clsvCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseLearningLogEN objvCaseLearningLogEN = new clsvCaseLearningLogEN();
try
{
objvCaseLearningLogEN.mId = Int32.Parse(objRow[convCaseLearningLog.mId].ToString().Trim()); //mId
objvCaseLearningLogEN.FuncModuleId = objRow[convCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseLearningLogEN.FuncModuleName = objRow[convCaseLearningLog.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseLearningLogEN.CaseId = objRow[convCaseLearningLog.CaseId] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objvCaseLearningLogEN.CaseName = objRow[convCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objvCaseLearningLogEN.OwnerId = objRow[convCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objvCaseLearningLogEN.UserId = objRow[convCaseLearningLog.UserId] == DBNull.Value ? null : objRow[convCaseLearningLog.UserId].ToString().Trim(); //用户ID
objvCaseLearningLogEN.UserName = objRow[convCaseLearningLog.UserName] == DBNull.Value ? null : objRow[convCaseLearningLog.UserName].ToString().Trim(); //用户名
objvCaseLearningLogEN.LearnStartTime = objRow[convCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objvCaseLearningLogEN.LearnEndTime = objRow[convCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objvCaseLearningLogEN.VideoStartTime = objRow[convCaseLearningLog.VideoStartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objvCaseLearningLogEN.VideoEndTime = objRow[convCaseLearningLog.VideoEndTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objvCaseLearningLogEN.TimeLengthOfVideo = objRow[convCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objvCaseLearningLogEN.IpAddress = objRow[convCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[convCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objvCaseLearningLogEN.Memo = objRow[convCaseLearningLog.Memo] == DBNull.Value ? null : objRow[convCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseLearningLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCaseLearningLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCaseLearningLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseLearningLogEN> arrObjLst = new List<clsvCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseLearningLogEN objvCaseLearningLogEN = new clsvCaseLearningLogEN();
try
{
objvCaseLearningLogEN.mId = Int32.Parse(objRow[convCaseLearningLog.mId].ToString().Trim()); //mId
objvCaseLearningLogEN.FuncModuleId = objRow[convCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseLearningLogEN.FuncModuleName = objRow[convCaseLearningLog.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseLearningLogEN.CaseId = objRow[convCaseLearningLog.CaseId] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objvCaseLearningLogEN.CaseName = objRow[convCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objvCaseLearningLogEN.OwnerId = objRow[convCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objvCaseLearningLogEN.UserId = objRow[convCaseLearningLog.UserId] == DBNull.Value ? null : objRow[convCaseLearningLog.UserId].ToString().Trim(); //用户ID
objvCaseLearningLogEN.UserName = objRow[convCaseLearningLog.UserName] == DBNull.Value ? null : objRow[convCaseLearningLog.UserName].ToString().Trim(); //用户名
objvCaseLearningLogEN.LearnStartTime = objRow[convCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objvCaseLearningLogEN.LearnEndTime = objRow[convCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objvCaseLearningLogEN.VideoStartTime = objRow[convCaseLearningLog.VideoStartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objvCaseLearningLogEN.VideoEndTime = objRow[convCaseLearningLog.VideoEndTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objvCaseLearningLogEN.TimeLengthOfVideo = objRow[convCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objvCaseLearningLogEN.IpAddress = objRow[convCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[convCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objvCaseLearningLogEN.Memo = objRow[convCaseLearningLog.Memo] == DBNull.Value ? null : objRow[convCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseLearningLogEN);
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
public static List<clsvCaseLearningLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCaseLearningLogEN> arrObjLst = new List<clsvCaseLearningLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseLearningLogEN objvCaseLearningLogEN = new clsvCaseLearningLogEN();
try
{
objvCaseLearningLogEN.mId = Int32.Parse(objRow[convCaseLearningLog.mId].ToString().Trim()); //mId
objvCaseLearningLogEN.FuncModuleId = objRow[convCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseLearningLogEN.FuncModuleName = objRow[convCaseLearningLog.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseLearningLogEN.CaseId = objRow[convCaseLearningLog.CaseId] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objvCaseLearningLogEN.CaseName = objRow[convCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objvCaseLearningLogEN.OwnerId = objRow[convCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objvCaseLearningLogEN.UserId = objRow[convCaseLearningLog.UserId] == DBNull.Value ? null : objRow[convCaseLearningLog.UserId].ToString().Trim(); //用户ID
objvCaseLearningLogEN.UserName = objRow[convCaseLearningLog.UserName] == DBNull.Value ? null : objRow[convCaseLearningLog.UserName].ToString().Trim(); //用户名
objvCaseLearningLogEN.LearnStartTime = objRow[convCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objvCaseLearningLogEN.LearnEndTime = objRow[convCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objvCaseLearningLogEN.VideoStartTime = objRow[convCaseLearningLog.VideoStartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objvCaseLearningLogEN.VideoEndTime = objRow[convCaseLearningLog.VideoEndTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objvCaseLearningLogEN.TimeLengthOfVideo = objRow[convCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objvCaseLearningLogEN.IpAddress = objRow[convCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[convCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objvCaseLearningLogEN.Memo = objRow[convCaseLearningLog.Memo] == DBNull.Value ? null : objRow[convCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseLearningLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseLearningLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCaseLearningLogEN> arrObjLst = new List<clsvCaseLearningLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseLearningLogEN objvCaseLearningLogEN = new clsvCaseLearningLogEN();
try
{
objvCaseLearningLogEN.mId = Int32.Parse(objRow[convCaseLearningLog.mId].ToString().Trim()); //mId
objvCaseLearningLogEN.FuncModuleId = objRow[convCaseLearningLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseLearningLogEN.FuncModuleName = objRow[convCaseLearningLog.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseLearningLogEN.CaseId = objRow[convCaseLearningLog.CaseId] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseId].ToString().Trim(); //案例Id
objvCaseLearningLogEN.CaseName = objRow[convCaseLearningLog.CaseName] == DBNull.Value ? null : objRow[convCaseLearningLog.CaseName].ToString().Trim(); //案例名称
objvCaseLearningLogEN.OwnerId = objRow[convCaseLearningLog.OwnerId].ToString().Trim(); //拥有者Id
objvCaseLearningLogEN.UserId = objRow[convCaseLearningLog.UserId] == DBNull.Value ? null : objRow[convCaseLearningLog.UserId].ToString().Trim(); //用户ID
objvCaseLearningLogEN.UserName = objRow[convCaseLearningLog.UserName] == DBNull.Value ? null : objRow[convCaseLearningLog.UserName].ToString().Trim(); //用户名
objvCaseLearningLogEN.LearnStartTime = objRow[convCaseLearningLog.LearnStartTime].ToString().Trim(); //开始时间
objvCaseLearningLogEN.LearnEndTime = objRow[convCaseLearningLog.LearnEndTime].ToString().Trim(); //结束时间
objvCaseLearningLogEN.VideoStartTime = objRow[convCaseLearningLog.VideoStartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoStartTime].ToString().Trim()); //观看视频开始时间
objvCaseLearningLogEN.VideoEndTime = objRow[convCaseLearningLog.VideoEndTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.VideoEndTime].ToString().Trim()); //观看视频结束时间
objvCaseLearningLogEN.TimeLengthOfVideo = objRow[convCaseLearningLog.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseLearningLog.TimeLengthOfVideo].ToString().Trim()); //视频时长
objvCaseLearningLogEN.IpAddress = objRow[convCaseLearningLog.IpAddress] == DBNull.Value ? null : objRow[convCaseLearningLog.IpAddress].ToString().Trim(); //Ip地址
objvCaseLearningLogEN.Memo = objRow[convCaseLearningLog.Memo] == DBNull.Value ? null : objRow[convCaseLearningLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseLearningLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseLearningLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCaseLearningLog(ref clsvCaseLearningLogEN objvCaseLearningLogEN)
{
bool bolResult = vCaseLearningLogDA.GetvCaseLearningLog(ref objvCaseLearningLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseLearningLogEN GetObjBymId(long lngmId)
{
clsvCaseLearningLogEN objvCaseLearningLogEN = vCaseLearningLogDA.GetObjBymId(lngmId);
return objvCaseLearningLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCaseLearningLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCaseLearningLogEN objvCaseLearningLogEN = vCaseLearningLogDA.GetFirstObj(strWhereCond);
 return objvCaseLearningLogEN;
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
public static clsvCaseLearningLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCaseLearningLogEN objvCaseLearningLogEN = vCaseLearningLogDA.GetObjByDataRow(objRow);
 return objvCaseLearningLogEN;
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
public static clsvCaseLearningLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCaseLearningLogEN objvCaseLearningLogEN = vCaseLearningLogDA.GetObjByDataRow(objRow);
 return objvCaseLearningLogEN;
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
 /// <param name = "lstvCaseLearningLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseLearningLogEN GetObjBymIdFromList(long lngmId, List<clsvCaseLearningLogEN> lstvCaseLearningLogObjLst)
{
foreach (clsvCaseLearningLogEN objvCaseLearningLogEN in lstvCaseLearningLogObjLst)
{
if (objvCaseLearningLogEN.mId == lngmId)
{
return objvCaseLearningLogEN;
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
 lngmId = new clsvCaseLearningLogDA().GetFirstID(strWhereCond);
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
 arrList = vCaseLearningLogDA.GetID(strWhereCond);
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
bool bolIsExist = vCaseLearningLogDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vCaseLearningLogDA.IsExist(lngmId);
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
 bolIsExist = clsvCaseLearningLogDA.IsExistTable();
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
 bolIsExist = vCaseLearningLogDA.IsExistTable(strTabName);
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


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvCaseLearningLogENS">源对象</param>
 /// <param name = "objvCaseLearningLogENT">目标对象</param>
 public static void CopyTo(clsvCaseLearningLogEN objvCaseLearningLogENS, clsvCaseLearningLogEN objvCaseLearningLogENT)
{
try
{
objvCaseLearningLogENT.mId = objvCaseLearningLogENS.mId; //mId
objvCaseLearningLogENT.FuncModuleId = objvCaseLearningLogENS.FuncModuleId; //功能模块Id
objvCaseLearningLogENT.FuncModuleName = objvCaseLearningLogENS.FuncModuleName; //功能模块名称
objvCaseLearningLogENT.CaseId = objvCaseLearningLogENS.CaseId; //案例Id
objvCaseLearningLogENT.CaseName = objvCaseLearningLogENS.CaseName; //案例名称
objvCaseLearningLogENT.OwnerId = objvCaseLearningLogENS.OwnerId; //拥有者Id
objvCaseLearningLogENT.UserId = objvCaseLearningLogENS.UserId; //用户ID
objvCaseLearningLogENT.UserName = objvCaseLearningLogENS.UserName; //用户名
objvCaseLearningLogENT.LearnStartTime = objvCaseLearningLogENS.LearnStartTime; //开始时间
objvCaseLearningLogENT.LearnEndTime = objvCaseLearningLogENS.LearnEndTime; //结束时间
objvCaseLearningLogENT.VideoStartTime = objvCaseLearningLogENS.VideoStartTime; //观看视频开始时间
objvCaseLearningLogENT.VideoEndTime = objvCaseLearningLogENS.VideoEndTime; //观看视频结束时间
objvCaseLearningLogENT.TimeLengthOfVideo = objvCaseLearningLogENS.TimeLengthOfVideo; //视频时长
objvCaseLearningLogENT.IpAddress = objvCaseLearningLogENS.IpAddress; //Ip地址
objvCaseLearningLogENT.Memo = objvCaseLearningLogENS.Memo; //备注
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
 /// <param name = "objvCaseLearningLogEN">源简化对象</param>
 public static void SetUpdFlag(clsvCaseLearningLogEN objvCaseLearningLogEN)
{
try
{
objvCaseLearningLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCaseLearningLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCaseLearningLog.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.mId = objvCaseLearningLogEN.mId; //mId
}
if (arrFldSet.Contains(convCaseLearningLog.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.FuncModuleId = objvCaseLearningLogEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convCaseLearningLog.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.FuncModuleName = objvCaseLearningLogEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCaseLearningLog.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.CaseId = objvCaseLearningLogEN.CaseId == "[null]" ? null :  objvCaseLearningLogEN.CaseId; //案例Id
}
if (arrFldSet.Contains(convCaseLearningLog.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.CaseName = objvCaseLearningLogEN.CaseName == "[null]" ? null :  objvCaseLearningLogEN.CaseName; //案例名称
}
if (arrFldSet.Contains(convCaseLearningLog.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.OwnerId = objvCaseLearningLogEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convCaseLearningLog.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.UserId = objvCaseLearningLogEN.UserId == "[null]" ? null :  objvCaseLearningLogEN.UserId; //用户ID
}
if (arrFldSet.Contains(convCaseLearningLog.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.UserName = objvCaseLearningLogEN.UserName == "[null]" ? null :  objvCaseLearningLogEN.UserName; //用户名
}
if (arrFldSet.Contains(convCaseLearningLog.LearnStartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.LearnStartTime = objvCaseLearningLogEN.LearnStartTime; //开始时间
}
if (arrFldSet.Contains(convCaseLearningLog.LearnEndTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.LearnEndTime = objvCaseLearningLogEN.LearnEndTime; //结束时间
}
if (arrFldSet.Contains(convCaseLearningLog.VideoStartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.VideoStartTime = objvCaseLearningLogEN.VideoStartTime; //观看视频开始时间
}
if (arrFldSet.Contains(convCaseLearningLog.VideoEndTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.VideoEndTime = objvCaseLearningLogEN.VideoEndTime; //观看视频结束时间
}
if (arrFldSet.Contains(convCaseLearningLog.TimeLengthOfVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.TimeLengthOfVideo = objvCaseLearningLogEN.TimeLengthOfVideo; //视频时长
}
if (arrFldSet.Contains(convCaseLearningLog.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.IpAddress = objvCaseLearningLogEN.IpAddress == "[null]" ? null :  objvCaseLearningLogEN.IpAddress; //Ip地址
}
if (arrFldSet.Contains(convCaseLearningLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseLearningLogEN.Memo = objvCaseLearningLogEN.Memo == "[null]" ? null :  objvCaseLearningLogEN.Memo; //备注
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
 /// <param name = "objvCaseLearningLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCaseLearningLogEN objvCaseLearningLogEN)
{
try
{
if (objvCaseLearningLogEN.CaseId == "[null]") objvCaseLearningLogEN.CaseId = null; //案例Id
if (objvCaseLearningLogEN.CaseName == "[null]") objvCaseLearningLogEN.CaseName = null; //案例名称
if (objvCaseLearningLogEN.UserId == "[null]") objvCaseLearningLogEN.UserId = null; //用户ID
if (objvCaseLearningLogEN.UserName == "[null]") objvCaseLearningLogEN.UserName = null; //用户名
if (objvCaseLearningLogEN.IpAddress == "[null]") objvCaseLearningLogEN.IpAddress = null; //Ip地址
if (objvCaseLearningLogEN.Memo == "[null]") objvCaseLearningLogEN.Memo = null; //备注
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvCaseLearningLogEN objvCaseLearningLogEN)
{
 vCaseLearningLogDA.CheckProperty4Condition(objvCaseLearningLogEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLearningLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLearningLogBL没有刷新缓存机制(clsCaseLearningLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCaseLearningLogObjLstCache == null)
//{
//arrvCaseLearningLogObjLstCache = vCaseLearningLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseLearningLogEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCaseLearningLogEN._CurrTabName);
List<clsvCaseLearningLogEN> arrvCaseLearningLogObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseLearningLogEN> arrvCaseLearningLogObjLst_Sel =
arrvCaseLearningLogObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvCaseLearningLogObjLst_Sel.Count() == 0)
{
   clsvCaseLearningLogEN obj = clsvCaseLearningLogBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCaseLearningLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseLearningLogEN> GetAllvCaseLearningLogObjLstCache()
{
//获取缓存中的对象列表
List<clsvCaseLearningLogEN> arrvCaseLearningLogObjLstCache = GetObjLstCache(); 
return arrvCaseLearningLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseLearningLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCaseLearningLogEN._CurrTabName);
List<clsvCaseLearningLogEN> arrvCaseLearningLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseLearningLogObjLstCache;
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
string strKey = string.Format("{0}", clsvCaseLearningLogEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


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
if (strInFldName != convCaseLearningLog.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCaseLearningLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCaseLearningLog.AttributeName));
throw new Exception(strMsg);
}
var objvCaseLearningLog = clsvCaseLearningLogBL.GetObjBymIdCache(lngmId);
if (objvCaseLearningLog == null) return "";
return objvCaseLearningLog[strOutFldName].ToString();
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
int intRecCount = clsvCaseLearningLogDA.GetRecCount(strTabName);
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
int intRecCount = clsvCaseLearningLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCaseLearningLogDA.GetRecCount();
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
int intRecCount = clsvCaseLearningLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCaseLearningLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCaseLearningLogEN objvCaseLearningLogCond)
{
List<clsvCaseLearningLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseLearningLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseLearningLog.AttributeName)
{
if (objvCaseLearningLogCond.IsUpdated(strFldName) == false) continue;
if (objvCaseLearningLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseLearningLogCond[strFldName].ToString());
}
else
{
if (objvCaseLearningLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseLearningLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseLearningLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseLearningLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseLearningLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseLearningLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseLearningLogCond[strFldName]));
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
 List<string> arrList = clsvCaseLearningLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCaseLearningLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCaseLearningLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}