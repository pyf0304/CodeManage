
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoPlayLogBL
 表名:vVideoPlayLog(01120302)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsvVideoPlayLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdVideoPlayLog">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoPlayLogEN GetObj(this K_IdVideoPlayLog_vVideoPlayLog myKey)
{
clsvVideoPlayLogEN objvVideoPlayLogEN = clsvVideoPlayLogBL.vVideoPlayLogDA.GetObjByIdVideoPlayLog(myKey.Value);
return objvVideoPlayLogEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetIdVideoPlayLog(this clsvVideoPlayLogEN objvVideoPlayLogEN, long lngIdVideoPlayLog, string strComparisonOp="")
	{
objvVideoPlayLogEN.IdVideoPlayLog = lngIdVideoPlayLog; //视频播放日志流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.IdVideoPlayLog) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.IdVideoPlayLog, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.IdVideoPlayLog] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetFuncModuleId(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoPlayLog.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoPlayLog.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoPlayLog.FuncModuleId);
}
objvVideoPlayLogEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.FuncModuleId) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.FuncModuleId, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.FuncModuleId] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetFuncModuleNameSim(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convVideoPlayLog.FuncModuleNameSim);
}
objvVideoPlayLogEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.FuncModuleNameSim) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.FuncModuleNameSim, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.FuncModuleNameSim] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetIdCase(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strIdCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCase, convVideoPlayLog.IdCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCase, 8, convVideoPlayLog.IdCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCase, 8, convVideoPlayLog.IdCase);
}
objvVideoPlayLogEN.IdCase = strIdCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.IdCase) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.IdCase, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.IdCase] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetVideoLibName(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strVideoLibName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoPlayLog.VideoLibName);
}
objvVideoPlayLogEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.VideoLibName) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.VideoLibName, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.VideoLibName] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetVideoUrl(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convVideoPlayLog.VideoUrl);
}
objvVideoPlayLogEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.VideoUrl) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.VideoUrl, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.VideoUrl] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetCoverPicUrl(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strCoverPicUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCoverPicUrl, 1000, convVideoPlayLog.CoverPicUrl);
}
objvVideoPlayLogEN.CoverPicUrl = strCoverPicUrl; //封面Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.CoverPicUrl) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.CoverPicUrl, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.CoverPicUrl] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetLikeNum(this clsvVideoPlayLogEN objvVideoPlayLogEN, int? intLikeNum, string strComparisonOp="")
	{
objvVideoPlayLogEN.LikeNum = intLikeNum; //点赞数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.LikeNum) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.LikeNum, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.LikeNum] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetPlayNum(this clsvVideoPlayLogEN objvVideoPlayLogEN, int? intPlayNum, string strComparisonOp="")
	{
objvVideoPlayLogEN.PlayNum = intPlayNum; //播放数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.PlayNum) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.PlayNum, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.PlayNum] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetUserId(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convVideoPlayLog.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convVideoPlayLog.UserId);
}
objvVideoPlayLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.UserId) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.UserId, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.UserId] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetPlayDate(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strPlayDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlayDate, 20, convVideoPlayLog.PlayDate);
}
objvVideoPlayLogEN.PlayDate = strPlayDate; //播放日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.PlayDate) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.PlayDate, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.PlayDate] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLogEN SetMemo(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoPlayLog.Memo);
}
objvVideoPlayLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.Memo) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.Memo, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.Memo] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvVideoPlayLogENS">源对象</param>
 /// <param name = "objvVideoPlayLogENT">目标对象</param>
 public static void CopyTo(this clsvVideoPlayLogEN objvVideoPlayLogENS, clsvVideoPlayLogEN objvVideoPlayLogENT)
{
try
{
objvVideoPlayLogENT.IdVideoPlayLog = objvVideoPlayLogENS.IdVideoPlayLog; //视频播放日志流水号
objvVideoPlayLogENT.FuncModuleId = objvVideoPlayLogENS.FuncModuleId; //功能模块Id
objvVideoPlayLogENT.FuncModuleNameSim = objvVideoPlayLogENS.FuncModuleNameSim; //功能模块简称
objvVideoPlayLogENT.IdCase = objvVideoPlayLogENS.IdCase; //案例流水号
objvVideoPlayLogENT.VideoLibName = objvVideoPlayLogENS.VideoLibName; //视频名称
objvVideoPlayLogENT.VideoUrl = objvVideoPlayLogENS.VideoUrl; //视频Url
objvVideoPlayLogENT.CoverPicUrl = objvVideoPlayLogENS.CoverPicUrl; //封面Url
objvVideoPlayLogENT.LikeNum = objvVideoPlayLogENS.LikeNum; //点赞数
objvVideoPlayLogENT.PlayNum = objvVideoPlayLogENS.PlayNum; //播放数
objvVideoPlayLogENT.UserId = objvVideoPlayLogENS.UserId; //用户ID
objvVideoPlayLogENT.PlayDate = objvVideoPlayLogENS.PlayDate; //播放日期
objvVideoPlayLogENT.Memo = objvVideoPlayLogENS.Memo; //备注
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
 /// <param name = "objvVideoPlayLogENS">源对象</param>
 /// <returns>目标对象=>clsvVideoPlayLogEN:objvVideoPlayLogENT</returns>
 public static clsvVideoPlayLogEN CopyTo(this clsvVideoPlayLogEN objvVideoPlayLogENS)
{
try
{
 clsvVideoPlayLogEN objvVideoPlayLogENT = new clsvVideoPlayLogEN()
{
IdVideoPlayLog = objvVideoPlayLogENS.IdVideoPlayLog, //视频播放日志流水号
FuncModuleId = objvVideoPlayLogENS.FuncModuleId, //功能模块Id
FuncModuleNameSim = objvVideoPlayLogENS.FuncModuleNameSim, //功能模块简称
IdCase = objvVideoPlayLogENS.IdCase, //案例流水号
VideoLibName = objvVideoPlayLogENS.VideoLibName, //视频名称
VideoUrl = objvVideoPlayLogENS.VideoUrl, //视频Url
CoverPicUrl = objvVideoPlayLogENS.CoverPicUrl, //封面Url
LikeNum = objvVideoPlayLogENS.LikeNum, //点赞数
PlayNum = objvVideoPlayLogENS.PlayNum, //播放数
UserId = objvVideoPlayLogENS.UserId, //用户ID
PlayDate = objvVideoPlayLogENS.PlayDate, //播放日期
Memo = objvVideoPlayLogENS.Memo, //备注
};
 return objvVideoPlayLogENT;
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
public static void CheckProperty4Condition(this clsvVideoPlayLogEN objvVideoPlayLogEN)
{
 clsvVideoPlayLogBL.vVideoPlayLogDA.CheckProperty4Condition(objvVideoPlayLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoPlayLogEN objvVideoPlayLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.IdVideoPlayLog) == true)
{
string strComparisonOpIdVideoPlayLog = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.IdVideoPlayLog];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog.IdVideoPlayLog, objvVideoPlayLogCond.IdVideoPlayLog, strComparisonOpIdVideoPlayLog);
}
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.FuncModuleId, objvVideoPlayLogCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.FuncModuleNameSim, objvVideoPlayLogCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.IdCase) == true)
{
string strComparisonOpIdCase = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.IdCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.IdCase, objvVideoPlayLogCond.IdCase, strComparisonOpIdCase);
}
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.VideoLibName) == true)
{
string strComparisonOpVideoLibName = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.VideoLibName, objvVideoPlayLogCond.VideoLibName, strComparisonOpVideoLibName);
}
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.VideoUrl, objvVideoPlayLogCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.CoverPicUrl) == true)
{
string strComparisonOpCoverPicUrl = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.CoverPicUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.CoverPicUrl, objvVideoPlayLogCond.CoverPicUrl, strComparisonOpCoverPicUrl);
}
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.LikeNum) == true)
{
string strComparisonOpLikeNum = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.LikeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog.LikeNum, objvVideoPlayLogCond.LikeNum, strComparisonOpLikeNum);
}
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.PlayNum) == true)
{
string strComparisonOpPlayNum = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.PlayNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog.PlayNum, objvVideoPlayLogCond.PlayNum, strComparisonOpPlayNum);
}
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.UserId) == true)
{
string strComparisonOpUserId = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.UserId, objvVideoPlayLogCond.UserId, strComparisonOpUserId);
}
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.PlayDate) == true)
{
string strComparisonOpPlayDate = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.PlayDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.PlayDate, objvVideoPlayLogCond.PlayDate, strComparisonOpPlayDate);
}
if (objvVideoPlayLogCond.IsUpdated(convVideoPlayLog.Memo) == true)
{
string strComparisonOpMemo = objvVideoPlayLogCond.dicFldComparisonOp[convVideoPlayLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.Memo, objvVideoPlayLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vVideoPlayLog
{
public virtual bool UpdRelaTabDate(long lngIdVideoPlayLog, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v视频播放日志(vVideoPlayLog)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvVideoPlayLogBL
{
public static RelatedActions_vVideoPlayLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvVideoPlayLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvVideoPlayLogDA vVideoPlayLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvVideoPlayLogDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvVideoPlayLogBL()
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
if (string.IsNullOrEmpty(clsvVideoPlayLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoPlayLogEN._ConnectString);
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
public static DataTable GetDataTable_vVideoPlayLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vVideoPlayLogDA.GetDataTable_vVideoPlayLog(strWhereCond);
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
objDT = vVideoPlayLogDA.GetDataTable(strWhereCond);
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
objDT = vVideoPlayLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vVideoPlayLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vVideoPlayLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vVideoPlayLogDA.GetDataTable_Top(objTopPara);
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
objDT = vVideoPlayLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vVideoPlayLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vVideoPlayLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdVideoPlayLogLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvVideoPlayLogEN> GetObjLstByIdVideoPlayLogLst(List<long> arrIdVideoPlayLogLst)
{
List<clsvVideoPlayLogEN> arrObjLst = new List<clsvVideoPlayLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdVideoPlayLogLst);
 string strWhereCond = string.Format("IdVideoPlayLog in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLogEN objvVideoPlayLogEN = new clsvVideoPlayLogEN();
try
{
objvVideoPlayLogEN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLogEN.FuncModuleId = objRow[convVideoPlayLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLogEN.FuncModuleNameSim = objRow[convVideoPlayLog.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLogEN.IdCase = objRow[convVideoPlayLog.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLogEN.VideoLibName = objRow[convVideoPlayLog.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLogEN.VideoUrl = objRow[convVideoPlayLog.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLogEN.CoverPicUrl = objRow[convVideoPlayLog.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLogEN.LikeNum = objRow[convVideoPlayLog.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLogEN.PlayNum = objRow[convVideoPlayLog.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLogEN.UserId = objRow[convVideoPlayLog.UserId].ToString().Trim(); //用户ID
objvVideoPlayLogEN.PlayDate = objRow[convVideoPlayLog.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLogEN.Memo = objRow[convVideoPlayLog.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLogEN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdVideoPlayLogLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvVideoPlayLogEN> GetObjLstByIdVideoPlayLogLstCache(List<long> arrIdVideoPlayLogLst)
{
string strKey = string.Format("{0}", clsvVideoPlayLogEN._CurrTabName);
List<clsvVideoPlayLogEN> arrvVideoPlayLogObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoPlayLogEN> arrvVideoPlayLogObjLst_Sel =
arrvVideoPlayLogObjLstCache
.Where(x => arrIdVideoPlayLogLst.Contains(x.IdVideoPlayLog));
return arrvVideoPlayLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoPlayLogEN> GetObjLst(string strWhereCond)
{
List<clsvVideoPlayLogEN> arrObjLst = new List<clsvVideoPlayLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLogEN objvVideoPlayLogEN = new clsvVideoPlayLogEN();
try
{
objvVideoPlayLogEN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLogEN.FuncModuleId = objRow[convVideoPlayLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLogEN.FuncModuleNameSim = objRow[convVideoPlayLog.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLogEN.IdCase = objRow[convVideoPlayLog.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLogEN.VideoLibName = objRow[convVideoPlayLog.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLogEN.VideoUrl = objRow[convVideoPlayLog.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLogEN.CoverPicUrl = objRow[convVideoPlayLog.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLogEN.LikeNum = objRow[convVideoPlayLog.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLogEN.PlayNum = objRow[convVideoPlayLog.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLogEN.UserId = objRow[convVideoPlayLog.UserId].ToString().Trim(); //用户ID
objvVideoPlayLogEN.PlayDate = objRow[convVideoPlayLog.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLogEN.Memo = objRow[convVideoPlayLog.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLogEN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLogEN);
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
public static List<clsvVideoPlayLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvVideoPlayLogEN> arrObjLst = new List<clsvVideoPlayLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLogEN objvVideoPlayLogEN = new clsvVideoPlayLogEN();
try
{
objvVideoPlayLogEN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLogEN.FuncModuleId = objRow[convVideoPlayLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLogEN.FuncModuleNameSim = objRow[convVideoPlayLog.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLogEN.IdCase = objRow[convVideoPlayLog.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLogEN.VideoLibName = objRow[convVideoPlayLog.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLogEN.VideoUrl = objRow[convVideoPlayLog.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLogEN.CoverPicUrl = objRow[convVideoPlayLog.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLogEN.LikeNum = objRow[convVideoPlayLog.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLogEN.PlayNum = objRow[convVideoPlayLog.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLogEN.UserId = objRow[convVideoPlayLog.UserId].ToString().Trim(); //用户ID
objvVideoPlayLogEN.PlayDate = objRow[convVideoPlayLog.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLogEN.Memo = objRow[convVideoPlayLog.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLogEN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvVideoPlayLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvVideoPlayLogEN> GetSubObjLstCache(clsvVideoPlayLogEN objvVideoPlayLogCond)
{
List<clsvVideoPlayLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoPlayLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoPlayLog.AttributeName)
{
if (objvVideoPlayLogCond.IsUpdated(strFldName) == false) continue;
if (objvVideoPlayLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoPlayLogCond[strFldName].ToString());
}
else
{
if (objvVideoPlayLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoPlayLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoPlayLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoPlayLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoPlayLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoPlayLogCond[strFldName]));
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
public static List<clsvVideoPlayLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvVideoPlayLogEN> arrObjLst = new List<clsvVideoPlayLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLogEN objvVideoPlayLogEN = new clsvVideoPlayLogEN();
try
{
objvVideoPlayLogEN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLogEN.FuncModuleId = objRow[convVideoPlayLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLogEN.FuncModuleNameSim = objRow[convVideoPlayLog.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLogEN.IdCase = objRow[convVideoPlayLog.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLogEN.VideoLibName = objRow[convVideoPlayLog.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLogEN.VideoUrl = objRow[convVideoPlayLog.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLogEN.CoverPicUrl = objRow[convVideoPlayLog.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLogEN.LikeNum = objRow[convVideoPlayLog.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLogEN.PlayNum = objRow[convVideoPlayLog.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLogEN.UserId = objRow[convVideoPlayLog.UserId].ToString().Trim(); //用户ID
objvVideoPlayLogEN.PlayDate = objRow[convVideoPlayLog.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLogEN.Memo = objRow[convVideoPlayLog.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLogEN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLogEN);
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
public static List<clsvVideoPlayLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvVideoPlayLogEN> arrObjLst = new List<clsvVideoPlayLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLogEN objvVideoPlayLogEN = new clsvVideoPlayLogEN();
try
{
objvVideoPlayLogEN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLogEN.FuncModuleId = objRow[convVideoPlayLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLogEN.FuncModuleNameSim = objRow[convVideoPlayLog.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLogEN.IdCase = objRow[convVideoPlayLog.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLogEN.VideoLibName = objRow[convVideoPlayLog.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLogEN.VideoUrl = objRow[convVideoPlayLog.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLogEN.CoverPicUrl = objRow[convVideoPlayLog.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLogEN.LikeNum = objRow[convVideoPlayLog.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLogEN.PlayNum = objRow[convVideoPlayLog.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLogEN.UserId = objRow[convVideoPlayLog.UserId].ToString().Trim(); //用户ID
objvVideoPlayLogEN.PlayDate = objRow[convVideoPlayLog.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLogEN.Memo = objRow[convVideoPlayLog.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLogEN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLogEN);
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
List<clsvVideoPlayLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvVideoPlayLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoPlayLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvVideoPlayLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoPlayLogEN> arrObjLst = new List<clsvVideoPlayLogEN>(); 
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
	clsvVideoPlayLogEN objvVideoPlayLogEN = new clsvVideoPlayLogEN();
try
{
objvVideoPlayLogEN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLogEN.FuncModuleId = objRow[convVideoPlayLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLogEN.FuncModuleNameSim = objRow[convVideoPlayLog.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLogEN.IdCase = objRow[convVideoPlayLog.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLogEN.VideoLibName = objRow[convVideoPlayLog.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLogEN.VideoUrl = objRow[convVideoPlayLog.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLogEN.CoverPicUrl = objRow[convVideoPlayLog.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLogEN.LikeNum = objRow[convVideoPlayLog.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLogEN.PlayNum = objRow[convVideoPlayLog.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLogEN.UserId = objRow[convVideoPlayLog.UserId].ToString().Trim(); //用户ID
objvVideoPlayLogEN.PlayDate = objRow[convVideoPlayLog.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLogEN.Memo = objRow[convVideoPlayLog.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLogEN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLogEN);
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
public static List<clsvVideoPlayLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvVideoPlayLogEN> arrObjLst = new List<clsvVideoPlayLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLogEN objvVideoPlayLogEN = new clsvVideoPlayLogEN();
try
{
objvVideoPlayLogEN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLogEN.FuncModuleId = objRow[convVideoPlayLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLogEN.FuncModuleNameSim = objRow[convVideoPlayLog.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLogEN.IdCase = objRow[convVideoPlayLog.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLogEN.VideoLibName = objRow[convVideoPlayLog.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLogEN.VideoUrl = objRow[convVideoPlayLog.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLogEN.CoverPicUrl = objRow[convVideoPlayLog.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLogEN.LikeNum = objRow[convVideoPlayLog.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLogEN.PlayNum = objRow[convVideoPlayLog.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLogEN.UserId = objRow[convVideoPlayLog.UserId].ToString().Trim(); //用户ID
objvVideoPlayLogEN.PlayDate = objRow[convVideoPlayLog.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLogEN.Memo = objRow[convVideoPlayLog.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLogEN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvVideoPlayLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvVideoPlayLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoPlayLogEN> arrObjLst = new List<clsvVideoPlayLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLogEN objvVideoPlayLogEN = new clsvVideoPlayLogEN();
try
{
objvVideoPlayLogEN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLogEN.FuncModuleId = objRow[convVideoPlayLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLogEN.FuncModuleNameSim = objRow[convVideoPlayLog.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLogEN.IdCase = objRow[convVideoPlayLog.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLogEN.VideoLibName = objRow[convVideoPlayLog.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLogEN.VideoUrl = objRow[convVideoPlayLog.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLogEN.CoverPicUrl = objRow[convVideoPlayLog.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLogEN.LikeNum = objRow[convVideoPlayLog.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLogEN.PlayNum = objRow[convVideoPlayLog.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLogEN.UserId = objRow[convVideoPlayLog.UserId].ToString().Trim(); //用户ID
objvVideoPlayLogEN.PlayDate = objRow[convVideoPlayLog.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLogEN.Memo = objRow[convVideoPlayLog.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLogEN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLogEN);
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
public static List<clsvVideoPlayLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvVideoPlayLogEN> arrObjLst = new List<clsvVideoPlayLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLogEN objvVideoPlayLogEN = new clsvVideoPlayLogEN();
try
{
objvVideoPlayLogEN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLogEN.FuncModuleId = objRow[convVideoPlayLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLogEN.FuncModuleNameSim = objRow[convVideoPlayLog.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLogEN.IdCase = objRow[convVideoPlayLog.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLogEN.VideoLibName = objRow[convVideoPlayLog.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLogEN.VideoUrl = objRow[convVideoPlayLog.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLogEN.CoverPicUrl = objRow[convVideoPlayLog.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLogEN.LikeNum = objRow[convVideoPlayLog.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLogEN.PlayNum = objRow[convVideoPlayLog.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLogEN.UserId = objRow[convVideoPlayLog.UserId].ToString().Trim(); //用户ID
objvVideoPlayLogEN.PlayDate = objRow[convVideoPlayLog.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLogEN.Memo = objRow[convVideoPlayLog.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLogEN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoPlayLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvVideoPlayLogEN> arrObjLst = new List<clsvVideoPlayLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLogEN objvVideoPlayLogEN = new clsvVideoPlayLogEN();
try
{
objvVideoPlayLogEN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLogEN.FuncModuleId = objRow[convVideoPlayLog.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLogEN.FuncModuleNameSim = objRow[convVideoPlayLog.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLogEN.IdCase = objRow[convVideoPlayLog.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLogEN.VideoLibName = objRow[convVideoPlayLog.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLogEN.VideoUrl = objRow[convVideoPlayLog.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLogEN.CoverPicUrl = objRow[convVideoPlayLog.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLogEN.LikeNum = objRow[convVideoPlayLog.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLogEN.PlayNum = objRow[convVideoPlayLog.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLogEN.UserId = objRow[convVideoPlayLog.UserId].ToString().Trim(); //用户ID
objvVideoPlayLogEN.PlayDate = objRow[convVideoPlayLog.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLogEN.Memo = objRow[convVideoPlayLog.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLogEN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvVideoPlayLog(ref clsvVideoPlayLogEN objvVideoPlayLogEN)
{
bool bolResult = vVideoPlayLogDA.GetvVideoPlayLog(ref objvVideoPlayLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdVideoPlayLog">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoPlayLogEN GetObjByIdVideoPlayLog(long lngIdVideoPlayLog)
{
clsvVideoPlayLogEN objvVideoPlayLogEN = vVideoPlayLogDA.GetObjByIdVideoPlayLog(lngIdVideoPlayLog);
return objvVideoPlayLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvVideoPlayLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvVideoPlayLogEN objvVideoPlayLogEN = vVideoPlayLogDA.GetFirstObj(strWhereCond);
 return objvVideoPlayLogEN;
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
public static clsvVideoPlayLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvVideoPlayLogEN objvVideoPlayLogEN = vVideoPlayLogDA.GetObjByDataRow(objRow);
 return objvVideoPlayLogEN;
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
public static clsvVideoPlayLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvVideoPlayLogEN objvVideoPlayLogEN = vVideoPlayLogDA.GetObjByDataRow(objRow);
 return objvVideoPlayLogEN;
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
 /// <param name = "lngIdVideoPlayLog">所给的关键字</param>
 /// <param name = "lstvVideoPlayLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoPlayLogEN GetObjByIdVideoPlayLogFromList(long lngIdVideoPlayLog, List<clsvVideoPlayLogEN> lstvVideoPlayLogObjLst)
{
foreach (clsvVideoPlayLogEN objvVideoPlayLogEN in lstvVideoPlayLogObjLst)
{
if (objvVideoPlayLogEN.IdVideoPlayLog == lngIdVideoPlayLog)
{
return objvVideoPlayLogEN;
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
 long lngIdVideoPlayLog;
 try
 {
 lngIdVideoPlayLog = new clsvVideoPlayLogDA().GetFirstID(strWhereCond);
 return lngIdVideoPlayLog;
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
 arrList = vVideoPlayLogDA.GetID(strWhereCond);
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
bool bolIsExist = vVideoPlayLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdVideoPlayLog">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdVideoPlayLog)
{
//检测记录是否存在
bool bolIsExist = vVideoPlayLogDA.IsExist(lngIdVideoPlayLog);
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
 bolIsExist = clsvVideoPlayLogDA.IsExistTable();
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
 bolIsExist = vVideoPlayLogDA.IsExistTable(strTabName);
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
 /// <param name = "objvVideoPlayLogENS">源对象</param>
 /// <param name = "objvVideoPlayLogENT">目标对象</param>
 public static void CopyTo(clsvVideoPlayLogEN objvVideoPlayLogENS, clsvVideoPlayLogEN objvVideoPlayLogENT)
{
try
{
objvVideoPlayLogENT.IdVideoPlayLog = objvVideoPlayLogENS.IdVideoPlayLog; //视频播放日志流水号
objvVideoPlayLogENT.FuncModuleId = objvVideoPlayLogENS.FuncModuleId; //功能模块Id
objvVideoPlayLogENT.FuncModuleNameSim = objvVideoPlayLogENS.FuncModuleNameSim; //功能模块简称
objvVideoPlayLogENT.IdCase = objvVideoPlayLogENS.IdCase; //案例流水号
objvVideoPlayLogENT.VideoLibName = objvVideoPlayLogENS.VideoLibName; //视频名称
objvVideoPlayLogENT.VideoUrl = objvVideoPlayLogENS.VideoUrl; //视频Url
objvVideoPlayLogENT.CoverPicUrl = objvVideoPlayLogENS.CoverPicUrl; //封面Url
objvVideoPlayLogENT.LikeNum = objvVideoPlayLogENS.LikeNum; //点赞数
objvVideoPlayLogENT.PlayNum = objvVideoPlayLogENS.PlayNum; //播放数
objvVideoPlayLogENT.UserId = objvVideoPlayLogENS.UserId; //用户ID
objvVideoPlayLogENT.PlayDate = objvVideoPlayLogENS.PlayDate; //播放日期
objvVideoPlayLogENT.Memo = objvVideoPlayLogENS.Memo; //备注
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
 /// <param name = "objvVideoPlayLogEN">源简化对象</param>
 public static void SetUpdFlag(clsvVideoPlayLogEN objvVideoPlayLogEN)
{
try
{
objvVideoPlayLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvVideoPlayLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convVideoPlayLog.IdVideoPlayLog, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.IdVideoPlayLog = objvVideoPlayLogEN.IdVideoPlayLog; //视频播放日志流水号
}
if (arrFldSet.Contains(convVideoPlayLog.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.FuncModuleId = objvVideoPlayLogEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convVideoPlayLog.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.FuncModuleNameSim = objvVideoPlayLogEN.FuncModuleNameSim == "[null]" ? null :  objvVideoPlayLogEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convVideoPlayLog.IdCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.IdCase = objvVideoPlayLogEN.IdCase; //案例流水号
}
if (arrFldSet.Contains(convVideoPlayLog.VideoLibName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.VideoLibName = objvVideoPlayLogEN.VideoLibName == "[null]" ? null :  objvVideoPlayLogEN.VideoLibName; //视频名称
}
if (arrFldSet.Contains(convVideoPlayLog.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.VideoUrl = objvVideoPlayLogEN.VideoUrl == "[null]" ? null :  objvVideoPlayLogEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convVideoPlayLog.CoverPicUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.CoverPicUrl = objvVideoPlayLogEN.CoverPicUrl == "[null]" ? null :  objvVideoPlayLogEN.CoverPicUrl; //封面Url
}
if (arrFldSet.Contains(convVideoPlayLog.LikeNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.LikeNum = objvVideoPlayLogEN.LikeNum; //点赞数
}
if (arrFldSet.Contains(convVideoPlayLog.PlayNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.PlayNum = objvVideoPlayLogEN.PlayNum; //播放数
}
if (arrFldSet.Contains(convVideoPlayLog.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.UserId = objvVideoPlayLogEN.UserId; //用户ID
}
if (arrFldSet.Contains(convVideoPlayLog.PlayDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.PlayDate = objvVideoPlayLogEN.PlayDate == "[null]" ? null :  objvVideoPlayLogEN.PlayDate; //播放日期
}
if (arrFldSet.Contains(convVideoPlayLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLogEN.Memo = objvVideoPlayLogEN.Memo == "[null]" ? null :  objvVideoPlayLogEN.Memo; //备注
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
 /// <param name = "objvVideoPlayLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsvVideoPlayLogEN objvVideoPlayLogEN)
{
try
{
if (objvVideoPlayLogEN.FuncModuleNameSim == "[null]") objvVideoPlayLogEN.FuncModuleNameSim = null; //功能模块简称
if (objvVideoPlayLogEN.VideoLibName == "[null]") objvVideoPlayLogEN.VideoLibName = null; //视频名称
if (objvVideoPlayLogEN.VideoUrl == "[null]") objvVideoPlayLogEN.VideoUrl = null; //视频Url
if (objvVideoPlayLogEN.CoverPicUrl == "[null]") objvVideoPlayLogEN.CoverPicUrl = null; //封面Url
if (objvVideoPlayLogEN.PlayDate == "[null]") objvVideoPlayLogEN.PlayDate = null; //播放日期
if (objvVideoPlayLogEN.Memo == "[null]") objvVideoPlayLogEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvVideoPlayLogEN objvVideoPlayLogEN)
{
 vVideoPlayLogDA.CheckProperty4Condition(objvVideoPlayLogEN);
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoPlayLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoPlayLogBL没有刷新缓存机制(clsVideoPlayLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibBL没有刷新缓存机制(clsVideoLibBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibTypeBL没有刷新缓存机制(clsVideoLibTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelBL没有刷新缓存机制(clsCaseLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityBL没有刷新缓存机制(clsQxUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLikeLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLikeLogBL没有刷新缓存机制(clsVideoLikeLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseBL没有刷新缓存机制(clsMicroteachAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdVideoPlayLog");
//if (arrvVideoPlayLogObjLstCache == null)
//{
//arrvVideoPlayLogObjLstCache = vVideoPlayLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdVideoPlayLog">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoPlayLogEN GetObjByIdVideoPlayLogCache(long lngIdVideoPlayLog)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvVideoPlayLogEN._CurrTabName);
List<clsvVideoPlayLogEN> arrvVideoPlayLogObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoPlayLogEN> arrvVideoPlayLogObjLst_Sel =
arrvVideoPlayLogObjLstCache
.Where(x=> x.IdVideoPlayLog == lngIdVideoPlayLog 
);
if (arrvVideoPlayLogObjLst_Sel.Count() == 0)
{
   clsvVideoPlayLogEN obj = clsvVideoPlayLogBL.GetObjByIdVideoPlayLog(lngIdVideoPlayLog);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvVideoPlayLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoPlayLogEN> GetAllvVideoPlayLogObjLstCache()
{
//获取缓存中的对象列表
List<clsvVideoPlayLogEN> arrvVideoPlayLogObjLstCache = GetObjLstCache(); 
return arrvVideoPlayLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoPlayLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvVideoPlayLogEN._CurrTabName);
List<clsvVideoPlayLogEN> arrvVideoPlayLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoPlayLogObjLstCache;
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
string strKey = string.Format("{0}", clsvVideoPlayLogEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdVideoPlayLog)
{
if (strInFldName != convVideoPlayLog.IdVideoPlayLog)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convVideoPlayLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convVideoPlayLog.AttributeName));
throw new Exception(strMsg);
}
var objvVideoPlayLog = clsvVideoPlayLogBL.GetObjByIdVideoPlayLogCache(lngIdVideoPlayLog);
if (objvVideoPlayLog == null) return "";
return objvVideoPlayLog[strOutFldName].ToString();
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
int intRecCount = clsvVideoPlayLogDA.GetRecCount(strTabName);
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
int intRecCount = clsvVideoPlayLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvVideoPlayLogDA.GetRecCount();
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
int intRecCount = clsvVideoPlayLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvVideoPlayLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvVideoPlayLogEN objvVideoPlayLogCond)
{
List<clsvVideoPlayLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoPlayLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoPlayLog.AttributeName)
{
if (objvVideoPlayLogCond.IsUpdated(strFldName) == false) continue;
if (objvVideoPlayLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoPlayLogCond[strFldName].ToString());
}
else
{
if (objvVideoPlayLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoPlayLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoPlayLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoPlayLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoPlayLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoPlayLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoPlayLogCond[strFldName]));
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
 List<string> arrList = clsvVideoPlayLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vVideoPlayLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vVideoPlayLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}