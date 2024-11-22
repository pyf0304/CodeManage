
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseLearningLogWApi
 表名:CaseLearningLog(01120365)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:19
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
public static class clsCaseLearningLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseLearningLogEN SetFuncModuleId(this clsCaseLearningLogEN objCaseLearningLogEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conCaseLearningLog.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conCaseLearningLog.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conCaseLearningLog.FuncModuleId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseLearningLogEN SetCaseId(this clsCaseLearningLogEN objCaseLearningLogEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId, conCaseLearningLog.CaseId);
clsCheckSql.CheckFieldLen(strCaseId, 8, conCaseLearningLog.CaseId);
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, conCaseLearningLog.CaseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseLearningLogEN SetCaseName(this clsCaseLearningLogEN objCaseLearningLogEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, conCaseLearningLog.CaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseLearningLogEN SetOwnerId(this clsCaseLearningLogEN objCaseLearningLogEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCaseLearningLog.OwnerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseLearningLogEN SetUserId(this clsCaseLearningLogEN objCaseLearningLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conCaseLearningLog.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, conCaseLearningLog.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseLearningLogEN SetLearnStartTime(this clsCaseLearningLogEN objCaseLearningLogEN, string strLearnStartTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnStartTime, conCaseLearningLog.LearnStartTime);
clsCheckSql.CheckFieldLen(strLearnStartTime, 14, conCaseLearningLog.LearnStartTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseLearningLogEN SetLearnEndTime(this clsCaseLearningLogEN objCaseLearningLogEN, string strLearnEndTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnEndTime, conCaseLearningLog.LearnEndTime);
clsCheckSql.CheckFieldLen(strLearnEndTime, 14, conCaseLearningLog.LearnEndTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseLearningLogEN SetIpAddress(this clsCaseLearningLogEN objCaseLearningLogEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 50, conCaseLearningLog.IpAddress);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseLearningLogEN SetTimeLengthOfVideo(this clsCaseLearningLogEN objCaseLearningLogEN, double dblTimeLengthOfVideo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseLearningLogEN SetMemo(this clsCaseLearningLogEN objCaseLearningLogEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseLearningLog.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseLearningLogEN objCaseLearningLog_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.mId) == true)
{
string strComparisonOp_mId = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseLearningLog.mId, objCaseLearningLog_Cond.mId, strComparisonOp_mId);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.FuncModuleId, objCaseLearningLog_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.CaseId) == true)
{
string strComparisonOp_CaseId = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.CaseId, objCaseLearningLog_Cond.CaseId, strComparisonOp_CaseId);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.CaseName) == true)
{
string strComparisonOp_CaseName = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.CaseName, objCaseLearningLog_Cond.CaseName, strComparisonOp_CaseName);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.OwnerId) == true)
{
string strComparisonOp_OwnerId = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.OwnerId, objCaseLearningLog_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.UserId) == true)
{
string strComparisonOp_UserId = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.UserId, objCaseLearningLog_Cond.UserId, strComparisonOp_UserId);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.LearnStartTime) == true)
{
string strComparisonOp_LearnStartTime = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.LearnStartTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.LearnStartTime, objCaseLearningLog_Cond.LearnStartTime, strComparisonOp_LearnStartTime);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.LearnEndTime) == true)
{
string strComparisonOp_LearnEndTime = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.LearnEndTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.LearnEndTime, objCaseLearningLog_Cond.LearnEndTime, strComparisonOp_LearnEndTime);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.VideoStartTime) == true)
{
string strComparisonOp_VideoStartTime = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.VideoStartTime];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseLearningLog.VideoStartTime, objCaseLearningLog_Cond.VideoStartTime, strComparisonOp_VideoStartTime);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.VideoEndTime) == true)
{
string strComparisonOp_VideoEndTime = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.VideoEndTime];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseLearningLog.VideoEndTime, objCaseLearningLog_Cond.VideoEndTime, strComparisonOp_VideoEndTime);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.IpAddress) == true)
{
string strComparisonOp_IpAddress = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.IpAddress, objCaseLearningLog_Cond.IpAddress, strComparisonOp_IpAddress);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.TimeLengthOfVideo) == true)
{
string strComparisonOp_TimeLengthOfVideo = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.TimeLengthOfVideo];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseLearningLog.TimeLengthOfVideo, objCaseLearningLog_Cond.TimeLengthOfVideo, strComparisonOp_TimeLengthOfVideo);
}
if (objCaseLearningLog_Cond.IsUpdated(conCaseLearningLog.Memo) == true)
{
string strComparisonOp_Memo = objCaseLearningLog_Cond.dicFldComparisonOp[conCaseLearningLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseLearningLog.Memo, objCaseLearningLog_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseLearningLogEN objCaseLearningLogEN)
{
 if (objCaseLearningLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCaseLearningLogEN.sf_UpdFldSetStr = objCaseLearningLogEN.getsf_UpdFldSetStr();
clsCaseLearningLogWApi.CheckPropertyNew(objCaseLearningLogEN); 
bool bolResult = clsCaseLearningLogWApi.UpdateRecord(objCaseLearningLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CaseLearningLog(案例学习日志), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CaseId_OwnerId_LearnStartTime_VideoEndTime(this clsCaseLearningLogEN objCaseLearningLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCaseLearningLogEN == null) return "";
if (objCaseLearningLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseLearningLogEN.CaseId);
 sbCondition.AppendFormat(" and OwnerId = '{0}'", objCaseLearningLogEN.OwnerId);
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

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseLearningLogEN objCaseLearningLogEN)
{
try
{
clsCaseLearningLogWApi.CheckPropertyNew(objCaseLearningLogEN); 
bool bolResult = clsCaseLearningLogWApi.AddNewRecord(objCaseLearningLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseLearningLogEN objCaseLearningLogEN, string strWhereCond)
{
try
{
clsCaseLearningLogWApi.CheckPropertyNew(objCaseLearningLogEN); 
bool bolResult = clsCaseLearningLogWApi.UpdateWithCondition(objCaseLearningLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 案例学习日志(CaseLearningLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCaseLearningLogWApi
{
private static readonly string mstrApiControllerName = "CaseLearningLogApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCaseLearningLogWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCaseLearningLogEN objCaseLearningLogEN)
{
if (!Object.Equals(null, objCaseLearningLogEN.FuncModuleId) && GetStrLen(objCaseLearningLogEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseLearningLogEN.CaseId) && GetStrLen(objCaseLearningLogEN.CaseId) > 8)
{
 throw new Exception("字段[案例Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseLearningLogEN.CaseName) && GetStrLen(objCaseLearningLogEN.CaseName) > 100)
{
 throw new Exception("字段[案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objCaseLearningLogEN.OwnerId) && GetStrLen(objCaseLearningLogEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseLearningLogEN.UserId) && GetStrLen(objCaseLearningLogEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseLearningLogEN.LearnStartTime) && GetStrLen(objCaseLearningLogEN.LearnStartTime) > 14)
{
 throw new Exception("字段[开始时间]的长度不能超过14!");
}
if (!Object.Equals(null, objCaseLearningLogEN.LearnEndTime) && GetStrLen(objCaseLearningLogEN.LearnEndTime) > 14)
{
 throw new Exception("字段[结束时间]的长度不能超过14!");
}
if (!Object.Equals(null, objCaseLearningLogEN.IpAddress) && GetStrLen(objCaseLearningLogEN.IpAddress) > 50)
{
 throw new Exception("字段[Ip地址]的长度不能超过50!");
}
if (!Object.Equals(null, objCaseLearningLogEN.Memo) && GetStrLen(objCaseLearningLogEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCaseLearningLogEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseLearningLogEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseLearningLogEN objCaseLearningLogEN = null;
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
objCaseLearningLogEN = JsonConvert.DeserializeObject<clsCaseLearningLogEN>((string)jobjReturn["ReturnObj"]);
return objCaseLearningLogEN;
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
public static clsCaseLearningLogEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseLearningLogEN objCaseLearningLogEN = null;
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
objCaseLearningLogEN = JsonConvert.DeserializeObject<clsCaseLearningLogEN>((string)jobjReturn["ReturnObj"]);
return objCaseLearningLogEN;
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
public static clsCaseLearningLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseLearningLogEN objCaseLearningLogEN = null;
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
objCaseLearningLogEN = JsonConvert.DeserializeObject<clsCaseLearningLogEN>((string)jobjReturn["ReturnObj"]);
return objCaseLearningLogEN;
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
public static clsCaseLearningLogEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseLearningLogEN._CurrTabName_S);
List<clsCaseLearningLogEN> arrCaseLearningLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseLearningLogEN> arrCaseLearningLogObjLst_Sel =
from objCaseLearningLogEN in arrCaseLearningLogObjLst_Cache
where objCaseLearningLogEN.mId == lngmId
select objCaseLearningLogEN;
if (arrCaseLearningLogObjLst_Sel.Count() == 0)
{
   clsCaseLearningLogEN obj = clsCaseLearningLogWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCaseLearningLogObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseLearningLogEN> GetObjLst(string strWhereCond)
{
 List<clsCaseLearningLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseLearningLogEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsCaseLearningLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsCaseLearningLogEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseLearningLogEN._CurrTabName_S);
List<clsCaseLearningLogEN> arrCaseLearningLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseLearningLogEN> arrCaseLearningLogObjLst_Sel =
from objCaseLearningLogEN in arrCaseLearningLogObjLst_Cache
where arrMId.Contains(objCaseLearningLogEN.mId)
select objCaseLearningLogEN;
return arrCaseLearningLogObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseLearningLogEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsCaseLearningLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseLearningLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCaseLearningLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseLearningLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCaseLearningLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseLearningLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCaseLearningLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseLearningLogEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCaseLearningLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseLearningLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCaseLearningLogEN objCaseLearningLogEN = clsCaseLearningLogWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseLearningLogWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelCaseLearningLogs(List<string> arrmId)
{
string strAction = "DelCaseLearningLogs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseLearningLogWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelCaseLearningLogsByCond(string strWhereCond)
{
string strAction = "DelCaseLearningLogsByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsCaseLearningLogEN objCaseLearningLogEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseLearningLogEN>(objCaseLearningLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCaseLearningLogEN objCaseLearningLogEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseLearningLogEN>(objCaseLearningLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseLearningLogWApi.ReFreshCache();
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsCaseLearningLogEN objCaseLearningLogEN)
{
if (string.IsNullOrEmpty(objCaseLearningLogEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseLearningLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseLearningLogEN>(objCaseLearningLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCaseLearningLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCaseLearningLogEN objCaseLearningLogEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCaseLearningLogEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseLearningLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseLearningLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseLearningLogEN>(objCaseLearningLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
public static DataTable ToDataTable(List<clsCaseLearningLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCaseLearningLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCaseLearningLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCaseLearningLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCaseLearningLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCaseLearningLogEN.AttributeName)
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
if (clsCaseLearningLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLearningLogWApi没有刷新缓存机制(clsCaseLearningLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCaseLearningLogObjLst_Cache == null)
//{
//arrCaseLearningLogObjLst_Cache = await clsCaseLearningLogWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCaseLearningLogEN._CurrTabName_S);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCaseLearningLogWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseLearningLogEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCaseLearningLogWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseLearningLogEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCaseLearningLogEN._CurrTabName_S);
List<clsCaseLearningLogEN> arrCaseLearningLogObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseLearningLogObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCaseLearningLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCaseLearningLog.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCaseLearningLog.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseLearningLog.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseLearningLog.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(conCaseLearningLog.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseLearningLog.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseLearningLog.LearnStartTime, Type.GetType("System.String"));
objDT.Columns.Add(conCaseLearningLog.LearnEndTime, Type.GetType("System.String"));
objDT.Columns.Add(conCaseLearningLog.VideoStartTime, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCaseLearningLog.VideoEndTime, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCaseLearningLog.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(conCaseLearningLog.TimeLengthOfVideo, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCaseLearningLog.Memo, Type.GetType("System.String"));
foreach (clsCaseLearningLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCaseLearningLog.mId] = objInFor[conCaseLearningLog.mId];
objDR[conCaseLearningLog.FuncModuleId] = objInFor[conCaseLearningLog.FuncModuleId];
objDR[conCaseLearningLog.CaseId] = objInFor[conCaseLearningLog.CaseId];
objDR[conCaseLearningLog.CaseName] = objInFor[conCaseLearningLog.CaseName];
objDR[conCaseLearningLog.OwnerId] = objInFor[conCaseLearningLog.OwnerId];
objDR[conCaseLearningLog.UserId] = objInFor[conCaseLearningLog.UserId];
objDR[conCaseLearningLog.LearnStartTime] = objInFor[conCaseLearningLog.LearnStartTime];
objDR[conCaseLearningLog.LearnEndTime] = objInFor[conCaseLearningLog.LearnEndTime];
objDR[conCaseLearningLog.VideoStartTime] = objInFor[conCaseLearningLog.VideoStartTime];
objDR[conCaseLearningLog.VideoEndTime] = objInFor[conCaseLearningLog.VideoEndTime];
objDR[conCaseLearningLog.IpAddress] = objInFor[conCaseLearningLog.IpAddress];
objDR[conCaseLearningLog.TimeLengthOfVideo] = objInFor[conCaseLearningLog.TimeLengthOfVideo];
objDR[conCaseLearningLog.Memo] = objInFor[conCaseLearningLog.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 案例学习日志(CaseLearningLog)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CaseLearningLog : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
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
clsCaseLearningLogWApi.ReFreshThisCache();
}
}

}