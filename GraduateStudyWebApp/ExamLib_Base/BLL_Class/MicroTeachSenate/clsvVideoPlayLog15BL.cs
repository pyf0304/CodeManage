
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoPlayLog15BL
 表名:vVideoPlayLog15(01120299)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:53
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
public static class  clsvVideoPlayLog15BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdVideoPlayLog">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoPlayLog15EN GetObj(this K_IdVideoPlayLog_vVideoPlayLog15 myKey)
{
clsvVideoPlayLog15EN objvVideoPlayLog15EN = clsvVideoPlayLog15BL.vVideoPlayLog15DA.GetObjByIdVideoPlayLog(myKey.Value);
return objvVideoPlayLog15EN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetIdVideoPlayLog(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, long lngIdVideoPlayLog, string strComparisonOp="")
	{
objvVideoPlayLog15EN.IdVideoPlayLog = lngIdVideoPlayLog; //视频播放日志流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.IdVideoPlayLog) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.IdVideoPlayLog, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.IdVideoPlayLog] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetFuncModuleId(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoPlayLog15.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoPlayLog15.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoPlayLog15.FuncModuleId);
}
objvVideoPlayLog15EN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.FuncModuleId) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.FuncModuleId, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.FuncModuleId] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetFuncModuleNameSim(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convVideoPlayLog15.FuncModuleNameSim);
}
objvVideoPlayLog15EN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.FuncModuleNameSim) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.FuncModuleNameSim, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.FuncModuleNameSim] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetIdCase(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strIdCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCase, convVideoPlayLog15.IdCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCase, 8, convVideoPlayLog15.IdCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCase, 8, convVideoPlayLog15.IdCase);
}
objvVideoPlayLog15EN.IdCase = strIdCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.IdCase) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.IdCase, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.IdCase] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetVideoLibName(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strVideoLibName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoPlayLog15.VideoLibName);
}
objvVideoPlayLog15EN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.VideoLibName) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.VideoLibName, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.VideoLibName] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetVideoUrl(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convVideoPlayLog15.VideoUrl);
}
objvVideoPlayLog15EN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.VideoUrl) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.VideoUrl, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.VideoUrl] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetCoverPicUrl(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strCoverPicUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCoverPicUrl, 1000, convVideoPlayLog15.CoverPicUrl);
}
objvVideoPlayLog15EN.CoverPicUrl = strCoverPicUrl; //封面Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.CoverPicUrl) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.CoverPicUrl, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.CoverPicUrl] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetLikeNum(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, int? intLikeNum, string strComparisonOp="")
	{
objvVideoPlayLog15EN.LikeNum = intLikeNum; //点赞数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.LikeNum) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.LikeNum, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.LikeNum] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetPlayNum(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, int? intPlayNum, string strComparisonOp="")
	{
objvVideoPlayLog15EN.PlayNum = intPlayNum; //播放数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.PlayNum) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.PlayNum, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.PlayNum] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetUserId(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convVideoPlayLog15.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convVideoPlayLog15.UserId);
}
objvVideoPlayLog15EN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.UserId) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.UserId, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.UserId] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetPlayDate(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strPlayDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlayDate, 20, convVideoPlayLog15.PlayDate);
}
objvVideoPlayLog15EN.PlayDate = strPlayDate; //播放日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.PlayDate) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.PlayDate, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.PlayDate] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoPlayLog15EN SetMemo(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoPlayLog15.Memo);
}
objvVideoPlayLog15EN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.Memo) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.Memo, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.Memo] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvVideoPlayLog15ENS">源对象</param>
 /// <param name = "objvVideoPlayLog15ENT">目标对象</param>
 public static void CopyTo(this clsvVideoPlayLog15EN objvVideoPlayLog15ENS, clsvVideoPlayLog15EN objvVideoPlayLog15ENT)
{
try
{
objvVideoPlayLog15ENT.IdVideoPlayLog = objvVideoPlayLog15ENS.IdVideoPlayLog; //视频播放日志流水号
objvVideoPlayLog15ENT.FuncModuleId = objvVideoPlayLog15ENS.FuncModuleId; //功能模块Id
objvVideoPlayLog15ENT.FuncModuleNameSim = objvVideoPlayLog15ENS.FuncModuleNameSim; //功能模块简称
objvVideoPlayLog15ENT.IdCase = objvVideoPlayLog15ENS.IdCase; //案例流水号
objvVideoPlayLog15ENT.VideoLibName = objvVideoPlayLog15ENS.VideoLibName; //视频名称
objvVideoPlayLog15ENT.VideoUrl = objvVideoPlayLog15ENS.VideoUrl; //视频Url
objvVideoPlayLog15ENT.CoverPicUrl = objvVideoPlayLog15ENS.CoverPicUrl; //封面Url
objvVideoPlayLog15ENT.LikeNum = objvVideoPlayLog15ENS.LikeNum; //点赞数
objvVideoPlayLog15ENT.PlayNum = objvVideoPlayLog15ENS.PlayNum; //播放数
objvVideoPlayLog15ENT.UserId = objvVideoPlayLog15ENS.UserId; //用户ID
objvVideoPlayLog15ENT.PlayDate = objvVideoPlayLog15ENS.PlayDate; //播放日期
objvVideoPlayLog15ENT.Memo = objvVideoPlayLog15ENS.Memo; //备注
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
 /// <param name = "objvVideoPlayLog15ENS">源对象</param>
 /// <returns>目标对象=>clsvVideoPlayLog15EN:objvVideoPlayLog15ENT</returns>
 public static clsvVideoPlayLog15EN CopyTo(this clsvVideoPlayLog15EN objvVideoPlayLog15ENS)
{
try
{
 clsvVideoPlayLog15EN objvVideoPlayLog15ENT = new clsvVideoPlayLog15EN()
{
IdVideoPlayLog = objvVideoPlayLog15ENS.IdVideoPlayLog, //视频播放日志流水号
FuncModuleId = objvVideoPlayLog15ENS.FuncModuleId, //功能模块Id
FuncModuleNameSim = objvVideoPlayLog15ENS.FuncModuleNameSim, //功能模块简称
IdCase = objvVideoPlayLog15ENS.IdCase, //案例流水号
VideoLibName = objvVideoPlayLog15ENS.VideoLibName, //视频名称
VideoUrl = objvVideoPlayLog15ENS.VideoUrl, //视频Url
CoverPicUrl = objvVideoPlayLog15ENS.CoverPicUrl, //封面Url
LikeNum = objvVideoPlayLog15ENS.LikeNum, //点赞数
PlayNum = objvVideoPlayLog15ENS.PlayNum, //播放数
UserId = objvVideoPlayLog15ENS.UserId, //用户ID
PlayDate = objvVideoPlayLog15ENS.PlayDate, //播放日期
Memo = objvVideoPlayLog15ENS.Memo, //备注
};
 return objvVideoPlayLog15ENT;
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
public static void CheckProperty4Condition(this clsvVideoPlayLog15EN objvVideoPlayLog15EN)
{
 clsvVideoPlayLog15BL.vVideoPlayLog15DA.CheckProperty4Condition(objvVideoPlayLog15EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoPlayLog15EN objvVideoPlayLog15Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.IdVideoPlayLog) == true)
{
string strComparisonOpIdVideoPlayLog = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.IdVideoPlayLog];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog15.IdVideoPlayLog, objvVideoPlayLog15Cond.IdVideoPlayLog, strComparisonOpIdVideoPlayLog);
}
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.FuncModuleId, objvVideoPlayLog15Cond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.FuncModuleNameSim, objvVideoPlayLog15Cond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.IdCase) == true)
{
string strComparisonOpIdCase = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.IdCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.IdCase, objvVideoPlayLog15Cond.IdCase, strComparisonOpIdCase);
}
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.VideoLibName) == true)
{
string strComparisonOpVideoLibName = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.VideoLibName, objvVideoPlayLog15Cond.VideoLibName, strComparisonOpVideoLibName);
}
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.VideoUrl, objvVideoPlayLog15Cond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.CoverPicUrl) == true)
{
string strComparisonOpCoverPicUrl = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.CoverPicUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.CoverPicUrl, objvVideoPlayLog15Cond.CoverPicUrl, strComparisonOpCoverPicUrl);
}
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.LikeNum) == true)
{
string strComparisonOpLikeNum = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.LikeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog15.LikeNum, objvVideoPlayLog15Cond.LikeNum, strComparisonOpLikeNum);
}
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.PlayNum) == true)
{
string strComparisonOpPlayNum = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.PlayNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog15.PlayNum, objvVideoPlayLog15Cond.PlayNum, strComparisonOpPlayNum);
}
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.UserId) == true)
{
string strComparisonOpUserId = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.UserId, objvVideoPlayLog15Cond.UserId, strComparisonOpUserId);
}
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.PlayDate) == true)
{
string strComparisonOpPlayDate = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.PlayDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.PlayDate, objvVideoPlayLog15Cond.PlayDate, strComparisonOpPlayDate);
}
if (objvVideoPlayLog15Cond.IsUpdated(convVideoPlayLog15.Memo) == true)
{
string strComparisonOpMemo = objvVideoPlayLog15Cond.dicFldComparisonOp[convVideoPlayLog15.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.Memo, objvVideoPlayLog15Cond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vVideoPlayLog15
{
public virtual bool UpdRelaTabDate(long lngIdVideoPlayLog, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v视频播放日志表15(vVideoPlayLog15)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvVideoPlayLog15BL
{
public static RelatedActions_vVideoPlayLog15 relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvVideoPlayLog15DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvVideoPlayLog15DA vVideoPlayLog15DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvVideoPlayLog15DA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvVideoPlayLog15BL()
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
if (string.IsNullOrEmpty(clsvVideoPlayLog15EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoPlayLog15EN._ConnectString);
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
public static DataTable GetDataTable_vVideoPlayLog15(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vVideoPlayLog15DA.GetDataTable_vVideoPlayLog15(strWhereCond);
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
objDT = vVideoPlayLog15DA.GetDataTable(strWhereCond);
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
objDT = vVideoPlayLog15DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vVideoPlayLog15DA.GetDataTable(strWhereCond, strTabName);
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
objDT = vVideoPlayLog15DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vVideoPlayLog15DA.GetDataTable_Top(objTopPara);
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
objDT = vVideoPlayLog15DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vVideoPlayLog15DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vVideoPlayLog15DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvVideoPlayLog15EN> GetObjLstByIdVideoPlayLogLst(List<long> arrIdVideoPlayLogLst)
{
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
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
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLog15EN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLog15EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdVideoPlayLogLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvVideoPlayLog15EN> GetObjLstByIdVideoPlayLogLstCache(List<long> arrIdVideoPlayLogLst)
{
string strKey = string.Format("{0}", clsvVideoPlayLog15EN._CurrTabName);
List<clsvVideoPlayLog15EN> arrvVideoPlayLog15ObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoPlayLog15EN> arrvVideoPlayLog15ObjLst_Sel =
arrvVideoPlayLog15ObjLstCache
.Where(x => arrIdVideoPlayLogLst.Contains(x.IdVideoPlayLog));
return arrvVideoPlayLog15ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoPlayLog15EN> GetObjLst(string strWhereCond)
{
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLog15EN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLog15EN);
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
public static List<clsvVideoPlayLog15EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLog15EN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLog15EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvVideoPlayLog15Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvVideoPlayLog15EN> GetSubObjLstCache(clsvVideoPlayLog15EN objvVideoPlayLog15Cond)
{
List<clsvVideoPlayLog15EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoPlayLog15EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoPlayLog15.AttributeName)
{
if (objvVideoPlayLog15Cond.IsUpdated(strFldName) == false) continue;
if (objvVideoPlayLog15Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoPlayLog15Cond[strFldName].ToString());
}
else
{
if (objvVideoPlayLog15Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoPlayLog15Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoPlayLog15Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoPlayLog15Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoPlayLog15Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoPlayLog15Cond[strFldName]));
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
public static List<clsvVideoPlayLog15EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLog15EN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLog15EN);
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
public static List<clsvVideoPlayLog15EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLog15EN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLog15EN);
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
List<clsvVideoPlayLog15EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvVideoPlayLog15EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoPlayLog15EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvVideoPlayLog15EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
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
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLog15EN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLog15EN);
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
public static List<clsvVideoPlayLog15EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLog15EN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLog15EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvVideoPlayLog15EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvVideoPlayLog15EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLog15EN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLog15EN);
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
public static List<clsvVideoPlayLog15EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLog15EN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLog15EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoPlayLog15EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvVideoPlayLog15EN> arrObjLst = new List<clsvVideoPlayLog15EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoPlayLog15EN objvVideoPlayLog15EN = new clsvVideoPlayLog15EN();
try
{
objvVideoPlayLog15EN.IdVideoPlayLog = Int32.Parse(objRow[convVideoPlayLog15.IdVideoPlayLog].ToString().Trim()); //视频播放日志流水号
objvVideoPlayLog15EN.FuncModuleId = objRow[convVideoPlayLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoPlayLog15EN.FuncModuleNameSim = objRow[convVideoPlayLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoPlayLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoPlayLog15EN.IdCase = objRow[convVideoPlayLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoPlayLog15EN.VideoLibName = objRow[convVideoPlayLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoPlayLog15EN.VideoUrl = objRow[convVideoPlayLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoPlayLog15EN.CoverPicUrl = objRow[convVideoPlayLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoPlayLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoPlayLog15EN.LikeNum = objRow[convVideoPlayLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoPlayLog15EN.PlayNum = objRow[convVideoPlayLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoPlayLog15.PlayNum].ToString().Trim()); //播放数
objvVideoPlayLog15EN.UserId = objRow[convVideoPlayLog15.UserId].ToString().Trim(); //用户ID
objvVideoPlayLog15EN.PlayDate = objRow[convVideoPlayLog15.PlayDate] == DBNull.Value ? null : objRow[convVideoPlayLog15.PlayDate].ToString().Trim(); //播放日期
objvVideoPlayLog15EN.Memo = objRow[convVideoPlayLog15.Memo] == DBNull.Value ? null : objRow[convVideoPlayLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoPlayLog15EN.IdVideoPlayLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoPlayLog15EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvVideoPlayLog15(ref clsvVideoPlayLog15EN objvVideoPlayLog15EN)
{
bool bolResult = vVideoPlayLog15DA.GetvVideoPlayLog15(ref objvVideoPlayLog15EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdVideoPlayLog">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoPlayLog15EN GetObjByIdVideoPlayLog(long lngIdVideoPlayLog)
{
clsvVideoPlayLog15EN objvVideoPlayLog15EN = vVideoPlayLog15DA.GetObjByIdVideoPlayLog(lngIdVideoPlayLog);
return objvVideoPlayLog15EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvVideoPlayLog15EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvVideoPlayLog15EN objvVideoPlayLog15EN = vVideoPlayLog15DA.GetFirstObj(strWhereCond);
 return objvVideoPlayLog15EN;
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
public static clsvVideoPlayLog15EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvVideoPlayLog15EN objvVideoPlayLog15EN = vVideoPlayLog15DA.GetObjByDataRow(objRow);
 return objvVideoPlayLog15EN;
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
public static clsvVideoPlayLog15EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvVideoPlayLog15EN objvVideoPlayLog15EN = vVideoPlayLog15DA.GetObjByDataRow(objRow);
 return objvVideoPlayLog15EN;
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
 /// <param name = "lstvVideoPlayLog15ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoPlayLog15EN GetObjByIdVideoPlayLogFromList(long lngIdVideoPlayLog, List<clsvVideoPlayLog15EN> lstvVideoPlayLog15ObjLst)
{
foreach (clsvVideoPlayLog15EN objvVideoPlayLog15EN in lstvVideoPlayLog15ObjLst)
{
if (objvVideoPlayLog15EN.IdVideoPlayLog == lngIdVideoPlayLog)
{
return objvVideoPlayLog15EN;
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
 lngIdVideoPlayLog = new clsvVideoPlayLog15DA().GetFirstID(strWhereCond);
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
 arrList = vVideoPlayLog15DA.GetID(strWhereCond);
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
bool bolIsExist = vVideoPlayLog15DA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vVideoPlayLog15DA.IsExist(lngIdVideoPlayLog);
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
 bolIsExist = clsvVideoPlayLog15DA.IsExistTable();
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
 bolIsExist = vVideoPlayLog15DA.IsExistTable(strTabName);
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
 /// <param name = "objvVideoPlayLog15ENS">源对象</param>
 /// <param name = "objvVideoPlayLog15ENT">目标对象</param>
 public static void CopyTo(clsvVideoPlayLog15EN objvVideoPlayLog15ENS, clsvVideoPlayLog15EN objvVideoPlayLog15ENT)
{
try
{
objvVideoPlayLog15ENT.IdVideoPlayLog = objvVideoPlayLog15ENS.IdVideoPlayLog; //视频播放日志流水号
objvVideoPlayLog15ENT.FuncModuleId = objvVideoPlayLog15ENS.FuncModuleId; //功能模块Id
objvVideoPlayLog15ENT.FuncModuleNameSim = objvVideoPlayLog15ENS.FuncModuleNameSim; //功能模块简称
objvVideoPlayLog15ENT.IdCase = objvVideoPlayLog15ENS.IdCase; //案例流水号
objvVideoPlayLog15ENT.VideoLibName = objvVideoPlayLog15ENS.VideoLibName; //视频名称
objvVideoPlayLog15ENT.VideoUrl = objvVideoPlayLog15ENS.VideoUrl; //视频Url
objvVideoPlayLog15ENT.CoverPicUrl = objvVideoPlayLog15ENS.CoverPicUrl; //封面Url
objvVideoPlayLog15ENT.LikeNum = objvVideoPlayLog15ENS.LikeNum; //点赞数
objvVideoPlayLog15ENT.PlayNum = objvVideoPlayLog15ENS.PlayNum; //播放数
objvVideoPlayLog15ENT.UserId = objvVideoPlayLog15ENS.UserId; //用户ID
objvVideoPlayLog15ENT.PlayDate = objvVideoPlayLog15ENS.PlayDate; //播放日期
objvVideoPlayLog15ENT.Memo = objvVideoPlayLog15ENS.Memo; //备注
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
 /// <param name = "objvVideoPlayLog15EN">源简化对象</param>
 public static void SetUpdFlag(clsvVideoPlayLog15EN objvVideoPlayLog15EN)
{
try
{
objvVideoPlayLog15EN.ClearUpdateState();
   string strsfUpdFldSetStr = objvVideoPlayLog15EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convVideoPlayLog15.IdVideoPlayLog, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.IdVideoPlayLog = objvVideoPlayLog15EN.IdVideoPlayLog; //视频播放日志流水号
}
if (arrFldSet.Contains(convVideoPlayLog15.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.FuncModuleId = objvVideoPlayLog15EN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convVideoPlayLog15.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.FuncModuleNameSim = objvVideoPlayLog15EN.FuncModuleNameSim == "[null]" ? null :  objvVideoPlayLog15EN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convVideoPlayLog15.IdCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.IdCase = objvVideoPlayLog15EN.IdCase; //案例流水号
}
if (arrFldSet.Contains(convVideoPlayLog15.VideoLibName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.VideoLibName = objvVideoPlayLog15EN.VideoLibName == "[null]" ? null :  objvVideoPlayLog15EN.VideoLibName; //视频名称
}
if (arrFldSet.Contains(convVideoPlayLog15.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.VideoUrl = objvVideoPlayLog15EN.VideoUrl == "[null]" ? null :  objvVideoPlayLog15EN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convVideoPlayLog15.CoverPicUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.CoverPicUrl = objvVideoPlayLog15EN.CoverPicUrl == "[null]" ? null :  objvVideoPlayLog15EN.CoverPicUrl; //封面Url
}
if (arrFldSet.Contains(convVideoPlayLog15.LikeNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.LikeNum = objvVideoPlayLog15EN.LikeNum; //点赞数
}
if (arrFldSet.Contains(convVideoPlayLog15.PlayNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.PlayNum = objvVideoPlayLog15EN.PlayNum; //播放数
}
if (arrFldSet.Contains(convVideoPlayLog15.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.UserId = objvVideoPlayLog15EN.UserId; //用户ID
}
if (arrFldSet.Contains(convVideoPlayLog15.PlayDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.PlayDate = objvVideoPlayLog15EN.PlayDate == "[null]" ? null :  objvVideoPlayLog15EN.PlayDate; //播放日期
}
if (arrFldSet.Contains(convVideoPlayLog15.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoPlayLog15EN.Memo = objvVideoPlayLog15EN.Memo == "[null]" ? null :  objvVideoPlayLog15EN.Memo; //备注
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
 /// <param name = "objvVideoPlayLog15EN">源简化对象</param>
 public static void AccessFldValueNull(clsvVideoPlayLog15EN objvVideoPlayLog15EN)
{
try
{
if (objvVideoPlayLog15EN.FuncModuleNameSim == "[null]") objvVideoPlayLog15EN.FuncModuleNameSim = null; //功能模块简称
if (objvVideoPlayLog15EN.VideoLibName == "[null]") objvVideoPlayLog15EN.VideoLibName = null; //视频名称
if (objvVideoPlayLog15EN.VideoUrl == "[null]") objvVideoPlayLog15EN.VideoUrl = null; //视频Url
if (objvVideoPlayLog15EN.CoverPicUrl == "[null]") objvVideoPlayLog15EN.CoverPicUrl = null; //封面Url
if (objvVideoPlayLog15EN.PlayDate == "[null]") objvVideoPlayLog15EN.PlayDate = null; //播放日期
if (objvVideoPlayLog15EN.Memo == "[null]") objvVideoPlayLog15EN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvVideoPlayLog15EN objvVideoPlayLog15EN)
{
 vVideoPlayLog15DA.CheckProperty4Condition(objvVideoPlayLog15EN);
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
//if (arrvVideoPlayLog15ObjLstCache == null)
//{
//arrvVideoPlayLog15ObjLstCache = vVideoPlayLog15DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdVideoPlayLog">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoPlayLog15EN GetObjByIdVideoPlayLogCache(long lngIdVideoPlayLog)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvVideoPlayLog15EN._CurrTabName);
List<clsvVideoPlayLog15EN> arrvVideoPlayLog15ObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoPlayLog15EN> arrvVideoPlayLog15ObjLst_Sel =
arrvVideoPlayLog15ObjLstCache
.Where(x=> x.IdVideoPlayLog == lngIdVideoPlayLog 
);
if (arrvVideoPlayLog15ObjLst_Sel.Count() == 0)
{
   clsvVideoPlayLog15EN obj = clsvVideoPlayLog15BL.GetObjByIdVideoPlayLog(lngIdVideoPlayLog);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvVideoPlayLog15ObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoPlayLog15EN> GetAllvVideoPlayLog15ObjLstCache()
{
//获取缓存中的对象列表
List<clsvVideoPlayLog15EN> arrvVideoPlayLog15ObjLstCache = GetObjLstCache(); 
return arrvVideoPlayLog15ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoPlayLog15EN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvVideoPlayLog15EN._CurrTabName);
List<clsvVideoPlayLog15EN> arrvVideoPlayLog15ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoPlayLog15ObjLstCache;
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
string strKey = string.Format("{0}", clsvVideoPlayLog15EN._CurrTabName);
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
if (strInFldName != convVideoPlayLog15.IdVideoPlayLog)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convVideoPlayLog15.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convVideoPlayLog15.AttributeName));
throw new Exception(strMsg);
}
var objvVideoPlayLog15 = clsvVideoPlayLog15BL.GetObjByIdVideoPlayLogCache(lngIdVideoPlayLog);
if (objvVideoPlayLog15 == null) return "";
return objvVideoPlayLog15[strOutFldName].ToString();
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
int intRecCount = clsvVideoPlayLog15DA.GetRecCount(strTabName);
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
int intRecCount = clsvVideoPlayLog15DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvVideoPlayLog15DA.GetRecCount();
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
int intRecCount = clsvVideoPlayLog15DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvVideoPlayLog15Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvVideoPlayLog15EN objvVideoPlayLog15Cond)
{
List<clsvVideoPlayLog15EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoPlayLog15EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoPlayLog15.AttributeName)
{
if (objvVideoPlayLog15Cond.IsUpdated(strFldName) == false) continue;
if (objvVideoPlayLog15Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoPlayLog15Cond[strFldName].ToString());
}
else
{
if (objvVideoPlayLog15Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoPlayLog15Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoPlayLog15Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoPlayLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoPlayLog15Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoPlayLog15Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoPlayLog15Cond[strFldName]));
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
 List<string> arrList = clsvVideoPlayLog15DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vVideoPlayLog15DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vVideoPlayLog15DA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}