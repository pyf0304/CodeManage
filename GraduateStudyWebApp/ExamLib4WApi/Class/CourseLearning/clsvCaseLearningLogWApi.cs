
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseLearningLogWApi
 表名:vCaseLearningLog(01120366)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:15
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsvCaseLearningLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetFuncModuleId(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseLearningLog.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseLearningLog.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseLearningLog.FuncModuleId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetFuncModuleName(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseLearningLog.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseLearningLog.FuncModuleName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetCaseId(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseId, 8, convCaseLearningLog.CaseId);
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, convCaseLearningLog.CaseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetCaseName(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, convCaseLearningLog.CaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetOwnerId(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCaseLearningLog.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCaseLearningLog.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetUserId(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convCaseLearningLog.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetUserName(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convCaseLearningLog.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetLearnStartTime(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strLearnStartTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnStartTime, convCaseLearningLog.LearnStartTime);
clsCheckSql.CheckFieldLen(strLearnStartTime, 14, convCaseLearningLog.LearnStartTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetLearnEndTime(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strLearnEndTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnEndTime, convCaseLearningLog.LearnEndTime);
clsCheckSql.CheckFieldLen(strLearnEndTime, 14, convCaseLearningLog.LearnEndTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetVideoStartTime(this clsvCaseLearningLogEN objvCaseLearningLogEN, double dblVideoStartTime, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetVideoEndTime(this clsvCaseLearningLogEN objvCaseLearningLogEN, double dblVideoEndTime, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetTimeLengthOfVideo(this clsvCaseLearningLogEN objvCaseLearningLogEN, double dblTimeLengthOfVideo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetIpAddress(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 50, convCaseLearningLog.IpAddress);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseLearningLogEN SetMemo(this clsvCaseLearningLogEN objvCaseLearningLogEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseLearningLog.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseLearningLogEN objvCaseLearningLog_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.mId) == true)
{
string strComparisonOp_mId = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseLearningLog.mId, objvCaseLearningLog_Cond.mId, strComparisonOp_mId);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.FuncModuleId, objvCaseLearningLog_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.FuncModuleName, objvCaseLearningLog_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.CaseId) == true)
{
string strComparisonOp_CaseId = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.CaseId, objvCaseLearningLog_Cond.CaseId, strComparisonOp_CaseId);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.CaseName) == true)
{
string strComparisonOp_CaseName = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.CaseName, objvCaseLearningLog_Cond.CaseName, strComparisonOp_CaseName);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.OwnerId, objvCaseLearningLog_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.UserId) == true)
{
string strComparisonOp_UserId = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.UserId, objvCaseLearningLog_Cond.UserId, strComparisonOp_UserId);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.UserName) == true)
{
string strComparisonOp_UserName = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.UserName, objvCaseLearningLog_Cond.UserName, strComparisonOp_UserName);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.LearnStartTime) == true)
{
string strComparisonOp_LearnStartTime = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.LearnStartTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.LearnStartTime, objvCaseLearningLog_Cond.LearnStartTime, strComparisonOp_LearnStartTime);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.LearnEndTime) == true)
{
string strComparisonOp_LearnEndTime = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.LearnEndTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.LearnEndTime, objvCaseLearningLog_Cond.LearnEndTime, strComparisonOp_LearnEndTime);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.VideoStartTime) == true)
{
string strComparisonOp_VideoStartTime = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.VideoStartTime];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseLearningLog.VideoStartTime, objvCaseLearningLog_Cond.VideoStartTime, strComparisonOp_VideoStartTime);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.VideoEndTime) == true)
{
string strComparisonOp_VideoEndTime = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.VideoEndTime];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseLearningLog.VideoEndTime, objvCaseLearningLog_Cond.VideoEndTime, strComparisonOp_VideoEndTime);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.TimeLengthOfVideo) == true)
{
string strComparisonOp_TimeLengthOfVideo = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.TimeLengthOfVideo];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseLearningLog.TimeLengthOfVideo, objvCaseLearningLog_Cond.TimeLengthOfVideo, strComparisonOp_TimeLengthOfVideo);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.IpAddress) == true)
{
string strComparisonOp_IpAddress = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.IpAddress, objvCaseLearningLog_Cond.IpAddress, strComparisonOp_IpAddress);
}
if (objvCaseLearningLog_Cond.IsUpdated(convCaseLearningLog.Memo) == true)
{
string strComparisonOp_Memo = objvCaseLearningLog_Cond.dicFldComparisonOp[convCaseLearningLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseLearningLog.Memo, objvCaseLearningLog_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v案例学习日志(vCaseLearningLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCaseLearningLogWApi
{
private static readonly string mstrApiControllerName = "vCaseLearningLogApi";

 public clsvCaseLearningLogWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseLearningLogEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseLearningLogEN objvCaseLearningLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseLearningLogEN = JsonConvert.DeserializeObject<clsvCaseLearningLogEN>((string)jobjReturn["ReturnObj"]);
return objvCaseLearningLogEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseLearningLogEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseLearningLogEN objvCaseLearningLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseLearningLogEN = JsonConvert.DeserializeObject<clsvCaseLearningLogEN>((string)jobjReturn["ReturnObj"]);
return objvCaseLearningLogEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvCaseLearningLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseLearningLogEN objvCaseLearningLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseLearningLogEN = JsonConvert.DeserializeObject<clsvCaseLearningLogEN>((string)jobjReturn["ReturnObj"]);
return objvCaseLearningLogEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseLearningLogEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseLearningLogEN._CurrTabName_S);
List<clsvCaseLearningLogEN> arrvCaseLearningLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseLearningLogEN> arrvCaseLearningLogObjLst_Sel =
from objvCaseLearningLogEN in arrvCaseLearningLogObjLst_Cache
where objvCaseLearningLogEN.mId == lngmId
select objvCaseLearningLogEN;
if (arrvCaseLearningLogObjLst_Sel.Count() == 0)
{
   clsvCaseLearningLogEN obj = clsvCaseLearningLogWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCaseLearningLogObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseLearningLogEN> GetObjLst(string strWhereCond)
{
 List<clsvCaseLearningLogEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseLearningLogEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCaseLearningLogEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCaseLearningLogEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseLearningLogEN._CurrTabName_S);
List<clsvCaseLearningLogEN> arrvCaseLearningLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseLearningLogEN> arrvCaseLearningLogObjLst_Sel =
from objvCaseLearningLogEN in arrvCaseLearningLogObjLst_Cache
where arrMId.Contains(objvCaseLearningLogEN.mId)
select objvCaseLearningLogEN;
return arrvCaseLearningLogObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseLearningLogEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvCaseLearningLogEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseLearningLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCaseLearningLogEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseLearningLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCaseLearningLogEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvCaseLearningLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCaseLearningLogEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvCaseLearningLogEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCaseLearningLogEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvCaseLearningLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCaseLearningLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCaseLearningLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCaseLearningLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCaseLearningLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCaseLearningLogEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLearningLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLearningLogWApi没有刷新缓存机制(clsCaseLearningLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCaseLearningLogObjLst_Cache == null)
//{
//arrvCaseLearningLogObjLst_Cache = await clsvCaseLearningLogWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvCaseLearningLogEN._CurrTabName_S);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseLearningLogEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCaseLearningLogEN._CurrTabName_S);
List<clsvCaseLearningLogEN> arrvCaseLearningLogObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseLearningLogObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCaseLearningLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCaseLearningLog.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCaseLearningLog.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseLearningLog.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseLearningLog.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseLearningLog.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseLearningLog.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseLearningLog.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseLearningLog.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseLearningLog.LearnStartTime, Type.GetType("System.String"));
objDT.Columns.Add(convCaseLearningLog.LearnEndTime, Type.GetType("System.String"));
objDT.Columns.Add(convCaseLearningLog.VideoStartTime, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCaseLearningLog.VideoEndTime, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCaseLearningLog.TimeLengthOfVideo, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCaseLearningLog.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convCaseLearningLog.Memo, Type.GetType("System.String"));
foreach (clsvCaseLearningLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCaseLearningLog.mId] = objInFor[convCaseLearningLog.mId];
objDR[convCaseLearningLog.FuncModuleId] = objInFor[convCaseLearningLog.FuncModuleId];
objDR[convCaseLearningLog.FuncModuleName] = objInFor[convCaseLearningLog.FuncModuleName];
objDR[convCaseLearningLog.CaseId] = objInFor[convCaseLearningLog.CaseId];
objDR[convCaseLearningLog.CaseName] = objInFor[convCaseLearningLog.CaseName];
objDR[convCaseLearningLog.OwnerId] = objInFor[convCaseLearningLog.OwnerId];
objDR[convCaseLearningLog.UserId] = objInFor[convCaseLearningLog.UserId];
objDR[convCaseLearningLog.UserName] = objInFor[convCaseLearningLog.UserName];
objDR[convCaseLearningLog.LearnStartTime] = objInFor[convCaseLearningLog.LearnStartTime];
objDR[convCaseLearningLog.LearnEndTime] = objInFor[convCaseLearningLog.LearnEndTime];
objDR[convCaseLearningLog.VideoStartTime] = objInFor[convCaseLearningLog.VideoStartTime];
objDR[convCaseLearningLog.VideoEndTime] = objInFor[convCaseLearningLog.VideoEndTime];
objDR[convCaseLearningLog.TimeLengthOfVideo] = objInFor[convCaseLearningLog.TimeLengthOfVideo];
objDR[convCaseLearningLog.IpAddress] = objInFor[convCaseLearningLog.IpAddress];
objDR[convCaseLearningLog.Memo] = objInFor[convCaseLearningLog.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}