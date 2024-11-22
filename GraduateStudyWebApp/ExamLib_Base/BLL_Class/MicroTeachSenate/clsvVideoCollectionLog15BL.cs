
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoCollectionLog15BL
 表名:vVideoCollectionLog15(01120301)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:30
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
public static class  clsvVideoCollectionLog15BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdVideoCollectionLog">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoCollectionLog15EN GetObj(this K_IdVideoCollectionLog_vVideoCollectionLog15 myKey)
{
clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = clsvVideoCollectionLog15BL.vVideoCollectionLog15DA.GetObjByIdVideoCollectionLog(myKey.Value);
return objvVideoCollectionLog15EN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetIdVideoCollectionLog(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, long lngIdVideoCollectionLog, string strComparisonOp="")
	{
objvVideoCollectionLog15EN.IdVideoCollectionLog = lngIdVideoCollectionLog; //视频收藏日志流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.IdVideoCollectionLog) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.IdVideoCollectionLog, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.IdVideoCollectionLog] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetFuncModuleId(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoCollectionLog15.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoCollectionLog15.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoCollectionLog15.FuncModuleId);
}
objvVideoCollectionLog15EN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.FuncModuleId) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.FuncModuleId, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.FuncModuleId] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetFuncModuleNameSim(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convVideoCollectionLog15.FuncModuleNameSim);
}
objvVideoCollectionLog15EN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.FuncModuleNameSim) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.FuncModuleNameSim, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.FuncModuleNameSim] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetIdCase(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, string strIdCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCase, convVideoCollectionLog15.IdCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCase, 8, convVideoCollectionLog15.IdCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCase, 8, convVideoCollectionLog15.IdCase);
}
objvVideoCollectionLog15EN.IdCase = strIdCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.IdCase) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.IdCase, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.IdCase] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetVideoLibName(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, string strVideoLibName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoCollectionLog15.VideoLibName);
}
objvVideoCollectionLog15EN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.VideoLibName) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.VideoLibName, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.VideoLibName] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetVideoUrl(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convVideoCollectionLog15.VideoUrl);
}
objvVideoCollectionLog15EN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.VideoUrl) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.VideoUrl, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.VideoUrl] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetCoverPicUrl(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, string strCoverPicUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCoverPicUrl, 1000, convVideoCollectionLog15.CoverPicUrl);
}
objvVideoCollectionLog15EN.CoverPicUrl = strCoverPicUrl; //封面Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.CoverPicUrl) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.CoverPicUrl, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.CoverPicUrl] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetLikeNum(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, int? intLikeNum, string strComparisonOp="")
	{
objvVideoCollectionLog15EN.LikeNum = intLikeNum; //点赞数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.LikeNum) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.LikeNum, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.LikeNum] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetPlayNum(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, int? intPlayNum, string strComparisonOp="")
	{
objvVideoCollectionLog15EN.PlayNum = intPlayNum; //播放数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.PlayNum) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.PlayNum, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.PlayNum] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetUserId(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convVideoCollectionLog15.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convVideoCollectionLog15.UserId);
}
objvVideoCollectionLog15EN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.UserId) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.UserId, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.UserId] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetCollectionDate(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, string strCollectionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollectionDate, convVideoCollectionLog15.CollectionDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollectionDate, 20, convVideoCollectionLog15.CollectionDate);
}
objvVideoCollectionLog15EN.CollectionDate = strCollectionDate; //收藏日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.CollectionDate) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.CollectionDate, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.CollectionDate] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoCollectionLog15EN SetMemo(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoCollectionLog15.Memo);
}
objvVideoCollectionLog15EN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoCollectionLog15EN.dicFldComparisonOp.ContainsKey(convVideoCollectionLog15.Memo) == false)
{
objvVideoCollectionLog15EN.dicFldComparisonOp.Add(convVideoCollectionLog15.Memo, strComparisonOp);
}
else
{
objvVideoCollectionLog15EN.dicFldComparisonOp[convVideoCollectionLog15.Memo] = strComparisonOp;
}
}
return objvVideoCollectionLog15EN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15ENS">源对象</param>
 /// <param name = "objvVideoCollectionLog15ENT">目标对象</param>
 public static void CopyTo(this clsvVideoCollectionLog15EN objvVideoCollectionLog15ENS, clsvVideoCollectionLog15EN objvVideoCollectionLog15ENT)
{
try
{
objvVideoCollectionLog15ENT.IdVideoCollectionLog = objvVideoCollectionLog15ENS.IdVideoCollectionLog; //视频收藏日志流水号
objvVideoCollectionLog15ENT.FuncModuleId = objvVideoCollectionLog15ENS.FuncModuleId; //功能模块Id
objvVideoCollectionLog15ENT.FuncModuleNameSim = objvVideoCollectionLog15ENS.FuncModuleNameSim; //功能模块简称
objvVideoCollectionLog15ENT.IdCase = objvVideoCollectionLog15ENS.IdCase; //案例流水号
objvVideoCollectionLog15ENT.VideoLibName = objvVideoCollectionLog15ENS.VideoLibName; //视频名称
objvVideoCollectionLog15ENT.VideoUrl = objvVideoCollectionLog15ENS.VideoUrl; //视频Url
objvVideoCollectionLog15ENT.CoverPicUrl = objvVideoCollectionLog15ENS.CoverPicUrl; //封面Url
objvVideoCollectionLog15ENT.LikeNum = objvVideoCollectionLog15ENS.LikeNum; //点赞数
objvVideoCollectionLog15ENT.PlayNum = objvVideoCollectionLog15ENS.PlayNum; //播放数
objvVideoCollectionLog15ENT.UserId = objvVideoCollectionLog15ENS.UserId; //用户ID
objvVideoCollectionLog15ENT.CollectionDate = objvVideoCollectionLog15ENS.CollectionDate; //收藏日期
objvVideoCollectionLog15ENT.Memo = objvVideoCollectionLog15ENS.Memo; //备注
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
 /// <param name = "objvVideoCollectionLog15ENS">源对象</param>
 /// <returns>目标对象=>clsvVideoCollectionLog15EN:objvVideoCollectionLog15ENT</returns>
 public static clsvVideoCollectionLog15EN CopyTo(this clsvVideoCollectionLog15EN objvVideoCollectionLog15ENS)
{
try
{
 clsvVideoCollectionLog15EN objvVideoCollectionLog15ENT = new clsvVideoCollectionLog15EN()
{
IdVideoCollectionLog = objvVideoCollectionLog15ENS.IdVideoCollectionLog, //视频收藏日志流水号
FuncModuleId = objvVideoCollectionLog15ENS.FuncModuleId, //功能模块Id
FuncModuleNameSim = objvVideoCollectionLog15ENS.FuncModuleNameSim, //功能模块简称
IdCase = objvVideoCollectionLog15ENS.IdCase, //案例流水号
VideoLibName = objvVideoCollectionLog15ENS.VideoLibName, //视频名称
VideoUrl = objvVideoCollectionLog15ENS.VideoUrl, //视频Url
CoverPicUrl = objvVideoCollectionLog15ENS.CoverPicUrl, //封面Url
LikeNum = objvVideoCollectionLog15ENS.LikeNum, //点赞数
PlayNum = objvVideoCollectionLog15ENS.PlayNum, //播放数
UserId = objvVideoCollectionLog15ENS.UserId, //用户ID
CollectionDate = objvVideoCollectionLog15ENS.CollectionDate, //收藏日期
Memo = objvVideoCollectionLog15ENS.Memo, //备注
};
 return objvVideoCollectionLog15ENT;
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
public static void CheckProperty4Condition(this clsvVideoCollectionLog15EN objvVideoCollectionLog15EN)
{
 clsvVideoCollectionLog15BL.vVideoCollectionLog15DA.CheckProperty4Condition(objvVideoCollectionLog15EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoCollectionLog15EN objvVideoCollectionLog15Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.IdVideoCollectionLog) == true)
{
string strComparisonOpIdVideoCollectionLog = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.IdVideoCollectionLog];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoCollectionLog15.IdVideoCollectionLog, objvVideoCollectionLog15Cond.IdVideoCollectionLog, strComparisonOpIdVideoCollectionLog);
}
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoCollectionLog15.FuncModuleId, objvVideoCollectionLog15Cond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoCollectionLog15.FuncModuleNameSim, objvVideoCollectionLog15Cond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.IdCase) == true)
{
string strComparisonOpIdCase = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.IdCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoCollectionLog15.IdCase, objvVideoCollectionLog15Cond.IdCase, strComparisonOpIdCase);
}
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.VideoLibName) == true)
{
string strComparisonOpVideoLibName = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoCollectionLog15.VideoLibName, objvVideoCollectionLog15Cond.VideoLibName, strComparisonOpVideoLibName);
}
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoCollectionLog15.VideoUrl, objvVideoCollectionLog15Cond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.CoverPicUrl) == true)
{
string strComparisonOpCoverPicUrl = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.CoverPicUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoCollectionLog15.CoverPicUrl, objvVideoCollectionLog15Cond.CoverPicUrl, strComparisonOpCoverPicUrl);
}
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.LikeNum) == true)
{
string strComparisonOpLikeNum = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.LikeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoCollectionLog15.LikeNum, objvVideoCollectionLog15Cond.LikeNum, strComparisonOpLikeNum);
}
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.PlayNum) == true)
{
string strComparisonOpPlayNum = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.PlayNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoCollectionLog15.PlayNum, objvVideoCollectionLog15Cond.PlayNum, strComparisonOpPlayNum);
}
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.UserId) == true)
{
string strComparisonOpUserId = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoCollectionLog15.UserId, objvVideoCollectionLog15Cond.UserId, strComparisonOpUserId);
}
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.CollectionDate) == true)
{
string strComparisonOpCollectionDate = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.CollectionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoCollectionLog15.CollectionDate, objvVideoCollectionLog15Cond.CollectionDate, strComparisonOpCollectionDate);
}
if (objvVideoCollectionLog15Cond.IsUpdated(convVideoCollectionLog15.Memo) == true)
{
string strComparisonOpMemo = objvVideoCollectionLog15Cond.dicFldComparisonOp[convVideoCollectionLog15.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoCollectionLog15.Memo, objvVideoCollectionLog15Cond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vVideoCollectionLog15
{
public virtual bool UpdRelaTabDate(long lngIdVideoCollectionLog, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v视频收藏日志15(vVideoCollectionLog15)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvVideoCollectionLog15BL
{
public static RelatedActions_vVideoCollectionLog15 relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvVideoCollectionLog15DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvVideoCollectionLog15DA vVideoCollectionLog15DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvVideoCollectionLog15DA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvVideoCollectionLog15BL()
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
if (string.IsNullOrEmpty(clsvVideoCollectionLog15EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoCollectionLog15EN._ConnectString);
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
public static DataTable GetDataTable_vVideoCollectionLog15(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vVideoCollectionLog15DA.GetDataTable_vVideoCollectionLog15(strWhereCond);
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
objDT = vVideoCollectionLog15DA.GetDataTable(strWhereCond);
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
objDT = vVideoCollectionLog15DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vVideoCollectionLog15DA.GetDataTable(strWhereCond, strTabName);
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
objDT = vVideoCollectionLog15DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vVideoCollectionLog15DA.GetDataTable_Top(objTopPara);
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
objDT = vVideoCollectionLog15DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vVideoCollectionLog15DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vVideoCollectionLog15DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdVideoCollectionLogLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvVideoCollectionLog15EN> GetObjLstByIdVideoCollectionLogLst(List<long> arrIdVideoCollectionLogLst)
{
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdVideoCollectionLogLst);
 string strWhereCond = string.Format("IdVideoCollectionLog in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = Int32.Parse(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoCollectionLog15EN.IdVideoCollectionLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoCollectionLog15EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdVideoCollectionLogLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvVideoCollectionLog15EN> GetObjLstByIdVideoCollectionLogLstCache(List<long> arrIdVideoCollectionLogLst)
{
string strKey = string.Format("{0}", clsvVideoCollectionLog15EN._CurrTabName);
List<clsvVideoCollectionLog15EN> arrvVideoCollectionLog15ObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoCollectionLog15EN> arrvVideoCollectionLog15ObjLst_Sel =
arrvVideoCollectionLog15ObjLstCache
.Where(x => arrIdVideoCollectionLogLst.Contains(x.IdVideoCollectionLog));
return arrvVideoCollectionLog15ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoCollectionLog15EN> GetObjLst(string strWhereCond)
{
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = Int32.Parse(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoCollectionLog15EN.IdVideoCollectionLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoCollectionLog15EN);
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
public static List<clsvVideoCollectionLog15EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = Int32.Parse(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoCollectionLog15EN.IdVideoCollectionLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoCollectionLog15EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvVideoCollectionLog15EN> GetSubObjLstCache(clsvVideoCollectionLog15EN objvVideoCollectionLog15Cond)
{
List<clsvVideoCollectionLog15EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoCollectionLog15EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoCollectionLog15.AttributeName)
{
if (objvVideoCollectionLog15Cond.IsUpdated(strFldName) == false) continue;
if (objvVideoCollectionLog15Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoCollectionLog15Cond[strFldName].ToString());
}
else
{
if (objvVideoCollectionLog15Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoCollectionLog15Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoCollectionLog15Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoCollectionLog15Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoCollectionLog15Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoCollectionLog15Cond[strFldName]));
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
public static List<clsvVideoCollectionLog15EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = Int32.Parse(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoCollectionLog15EN.IdVideoCollectionLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoCollectionLog15EN);
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
public static List<clsvVideoCollectionLog15EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = Int32.Parse(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoCollectionLog15EN.IdVideoCollectionLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoCollectionLog15EN);
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
List<clsvVideoCollectionLog15EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvVideoCollectionLog15EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoCollectionLog15EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvVideoCollectionLog15EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
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
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = Int32.Parse(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoCollectionLog15EN.IdVideoCollectionLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoCollectionLog15EN);
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
public static List<clsvVideoCollectionLog15EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = Int32.Parse(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoCollectionLog15EN.IdVideoCollectionLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoCollectionLog15EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvVideoCollectionLog15EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvVideoCollectionLog15EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = Int32.Parse(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoCollectionLog15EN.IdVideoCollectionLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoCollectionLog15EN);
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
public static List<clsvVideoCollectionLog15EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = Int32.Parse(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoCollectionLog15EN.IdVideoCollectionLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoCollectionLog15EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoCollectionLog15EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvVideoCollectionLog15EN> arrObjLst = new List<clsvVideoCollectionLog15EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = new clsvVideoCollectionLog15EN();
try
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = Int32.Parse(objRow[convVideoCollectionLog15.IdVideoCollectionLog].ToString().Trim()); //视频收藏日志流水号
objvVideoCollectionLog15EN.FuncModuleId = objRow[convVideoCollectionLog15.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoCollectionLog15EN.FuncModuleNameSim = objRow[convVideoCollectionLog15.FuncModuleNameSim] == DBNull.Value ? null : objRow[convVideoCollectionLog15.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvVideoCollectionLog15EN.IdCase = objRow[convVideoCollectionLog15.IdCase].ToString().Trim(); //案例流水号
objvVideoCollectionLog15EN.VideoLibName = objRow[convVideoCollectionLog15.VideoLibName] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoLibName].ToString().Trim(); //视频名称
objvVideoCollectionLog15EN.VideoUrl = objRow[convVideoCollectionLog15.VideoUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.VideoUrl].ToString().Trim(); //视频Url
objvVideoCollectionLog15EN.CoverPicUrl = objRow[convVideoCollectionLog15.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoCollectionLog15.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoCollectionLog15EN.LikeNum = objRow[convVideoCollectionLog15.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.LikeNum].ToString().Trim()); //点赞数
objvVideoCollectionLog15EN.PlayNum = objRow[convVideoCollectionLog15.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoCollectionLog15.PlayNum].ToString().Trim()); //播放数
objvVideoCollectionLog15EN.UserId = objRow[convVideoCollectionLog15.UserId].ToString().Trim(); //用户ID
objvVideoCollectionLog15EN.CollectionDate = objRow[convVideoCollectionLog15.CollectionDate].ToString().Trim(); //收藏日期
objvVideoCollectionLog15EN.Memo = objRow[convVideoCollectionLog15.Memo] == DBNull.Value ? null : objRow[convVideoCollectionLog15.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoCollectionLog15EN.IdVideoCollectionLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoCollectionLog15EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvVideoCollectionLog15(ref clsvVideoCollectionLog15EN objvVideoCollectionLog15EN)
{
bool bolResult = vVideoCollectionLog15DA.GetvVideoCollectionLog15(ref objvVideoCollectionLog15EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdVideoCollectionLog">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoCollectionLog15EN GetObjByIdVideoCollectionLog(long lngIdVideoCollectionLog)
{
clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = vVideoCollectionLog15DA.GetObjByIdVideoCollectionLog(lngIdVideoCollectionLog);
return objvVideoCollectionLog15EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvVideoCollectionLog15EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = vVideoCollectionLog15DA.GetFirstObj(strWhereCond);
 return objvVideoCollectionLog15EN;
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
public static clsvVideoCollectionLog15EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = vVideoCollectionLog15DA.GetObjByDataRow(objRow);
 return objvVideoCollectionLog15EN;
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
public static clsvVideoCollectionLog15EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvVideoCollectionLog15EN objvVideoCollectionLog15EN = vVideoCollectionLog15DA.GetObjByDataRow(objRow);
 return objvVideoCollectionLog15EN;
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
 /// <param name = "lngIdVideoCollectionLog">所给的关键字</param>
 /// <param name = "lstvVideoCollectionLog15ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoCollectionLog15EN GetObjByIdVideoCollectionLogFromList(long lngIdVideoCollectionLog, List<clsvVideoCollectionLog15EN> lstvVideoCollectionLog15ObjLst)
{
foreach (clsvVideoCollectionLog15EN objvVideoCollectionLog15EN in lstvVideoCollectionLog15ObjLst)
{
if (objvVideoCollectionLog15EN.IdVideoCollectionLog == lngIdVideoCollectionLog)
{
return objvVideoCollectionLog15EN;
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
 long lngIdVideoCollectionLog;
 try
 {
 lngIdVideoCollectionLog = new clsvVideoCollectionLog15DA().GetFirstID(strWhereCond);
 return lngIdVideoCollectionLog;
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
 arrList = vVideoCollectionLog15DA.GetID(strWhereCond);
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
bool bolIsExist = vVideoCollectionLog15DA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdVideoCollectionLog">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdVideoCollectionLog)
{
//检测记录是否存在
bool bolIsExist = vVideoCollectionLog15DA.IsExist(lngIdVideoCollectionLog);
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
 bolIsExist = clsvVideoCollectionLog15DA.IsExistTable();
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
 bolIsExist = vVideoCollectionLog15DA.IsExistTable(strTabName);
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
 /// <param name = "objvVideoCollectionLog15ENS">源对象</param>
 /// <param name = "objvVideoCollectionLog15ENT">目标对象</param>
 public static void CopyTo(clsvVideoCollectionLog15EN objvVideoCollectionLog15ENS, clsvVideoCollectionLog15EN objvVideoCollectionLog15ENT)
{
try
{
objvVideoCollectionLog15ENT.IdVideoCollectionLog = objvVideoCollectionLog15ENS.IdVideoCollectionLog; //视频收藏日志流水号
objvVideoCollectionLog15ENT.FuncModuleId = objvVideoCollectionLog15ENS.FuncModuleId; //功能模块Id
objvVideoCollectionLog15ENT.FuncModuleNameSim = objvVideoCollectionLog15ENS.FuncModuleNameSim; //功能模块简称
objvVideoCollectionLog15ENT.IdCase = objvVideoCollectionLog15ENS.IdCase; //案例流水号
objvVideoCollectionLog15ENT.VideoLibName = objvVideoCollectionLog15ENS.VideoLibName; //视频名称
objvVideoCollectionLog15ENT.VideoUrl = objvVideoCollectionLog15ENS.VideoUrl; //视频Url
objvVideoCollectionLog15ENT.CoverPicUrl = objvVideoCollectionLog15ENS.CoverPicUrl; //封面Url
objvVideoCollectionLog15ENT.LikeNum = objvVideoCollectionLog15ENS.LikeNum; //点赞数
objvVideoCollectionLog15ENT.PlayNum = objvVideoCollectionLog15ENS.PlayNum; //播放数
objvVideoCollectionLog15ENT.UserId = objvVideoCollectionLog15ENS.UserId; //用户ID
objvVideoCollectionLog15ENT.CollectionDate = objvVideoCollectionLog15ENS.CollectionDate; //收藏日期
objvVideoCollectionLog15ENT.Memo = objvVideoCollectionLog15ENS.Memo; //备注
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
 /// <param name = "objvVideoCollectionLog15EN">源简化对象</param>
 public static void SetUpdFlag(clsvVideoCollectionLog15EN objvVideoCollectionLog15EN)
{
try
{
objvVideoCollectionLog15EN.ClearUpdateState();
   string strsfUpdFldSetStr = objvVideoCollectionLog15EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convVideoCollectionLog15.IdVideoCollectionLog, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.IdVideoCollectionLog = objvVideoCollectionLog15EN.IdVideoCollectionLog; //视频收藏日志流水号
}
if (arrFldSet.Contains(convVideoCollectionLog15.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.FuncModuleId = objvVideoCollectionLog15EN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convVideoCollectionLog15.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.FuncModuleNameSim = objvVideoCollectionLog15EN.FuncModuleNameSim == "[null]" ? null :  objvVideoCollectionLog15EN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convVideoCollectionLog15.IdCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.IdCase = objvVideoCollectionLog15EN.IdCase; //案例流水号
}
if (arrFldSet.Contains(convVideoCollectionLog15.VideoLibName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.VideoLibName = objvVideoCollectionLog15EN.VideoLibName == "[null]" ? null :  objvVideoCollectionLog15EN.VideoLibName; //视频名称
}
if (arrFldSet.Contains(convVideoCollectionLog15.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.VideoUrl = objvVideoCollectionLog15EN.VideoUrl == "[null]" ? null :  objvVideoCollectionLog15EN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convVideoCollectionLog15.CoverPicUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.CoverPicUrl = objvVideoCollectionLog15EN.CoverPicUrl == "[null]" ? null :  objvVideoCollectionLog15EN.CoverPicUrl; //封面Url
}
if (arrFldSet.Contains(convVideoCollectionLog15.LikeNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.LikeNum = objvVideoCollectionLog15EN.LikeNum; //点赞数
}
if (arrFldSet.Contains(convVideoCollectionLog15.PlayNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.PlayNum = objvVideoCollectionLog15EN.PlayNum; //播放数
}
if (arrFldSet.Contains(convVideoCollectionLog15.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.UserId = objvVideoCollectionLog15EN.UserId; //用户ID
}
if (arrFldSet.Contains(convVideoCollectionLog15.CollectionDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.CollectionDate = objvVideoCollectionLog15EN.CollectionDate; //收藏日期
}
if (arrFldSet.Contains(convVideoCollectionLog15.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoCollectionLog15EN.Memo = objvVideoCollectionLog15EN.Memo == "[null]" ? null :  objvVideoCollectionLog15EN.Memo; //备注
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
 /// <param name = "objvVideoCollectionLog15EN">源简化对象</param>
 public static void AccessFldValueNull(clsvVideoCollectionLog15EN objvVideoCollectionLog15EN)
{
try
{
if (objvVideoCollectionLog15EN.FuncModuleNameSim == "[null]") objvVideoCollectionLog15EN.FuncModuleNameSim = null; //功能模块简称
if (objvVideoCollectionLog15EN.VideoLibName == "[null]") objvVideoCollectionLog15EN.VideoLibName = null; //视频名称
if (objvVideoCollectionLog15EN.VideoUrl == "[null]") objvVideoCollectionLog15EN.VideoUrl = null; //视频Url
if (objvVideoCollectionLog15EN.CoverPicUrl == "[null]") objvVideoCollectionLog15EN.CoverPicUrl = null; //封面Url
if (objvVideoCollectionLog15EN.Memo == "[null]") objvVideoCollectionLog15EN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvVideoCollectionLog15EN objvVideoCollectionLog15EN)
{
 vVideoCollectionLog15DA.CheckProperty4Condition(objvVideoCollectionLog15EN);
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
if (clsVideoCollectionLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoCollectionLogBL没有刷新缓存机制(clsVideoCollectionLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsVideoPlayLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoPlayLogBL没有刷新缓存机制(clsVideoPlayLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdVideoCollectionLog");
//if (arrvVideoCollectionLog15ObjLstCache == null)
//{
//arrvVideoCollectionLog15ObjLstCache = vVideoCollectionLog15DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdVideoCollectionLog">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoCollectionLog15EN GetObjByIdVideoCollectionLogCache(long lngIdVideoCollectionLog)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvVideoCollectionLog15EN._CurrTabName);
List<clsvVideoCollectionLog15EN> arrvVideoCollectionLog15ObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoCollectionLog15EN> arrvVideoCollectionLog15ObjLst_Sel =
arrvVideoCollectionLog15ObjLstCache
.Where(x=> x.IdVideoCollectionLog == lngIdVideoCollectionLog 
);
if (arrvVideoCollectionLog15ObjLst_Sel.Count() == 0)
{
   clsvVideoCollectionLog15EN obj = clsvVideoCollectionLog15BL.GetObjByIdVideoCollectionLog(lngIdVideoCollectionLog);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvVideoCollectionLog15ObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoCollectionLog15EN> GetAllvVideoCollectionLog15ObjLstCache()
{
//获取缓存中的对象列表
List<clsvVideoCollectionLog15EN> arrvVideoCollectionLog15ObjLstCache = GetObjLstCache(); 
return arrvVideoCollectionLog15ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoCollectionLog15EN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvVideoCollectionLog15EN._CurrTabName);
List<clsvVideoCollectionLog15EN> arrvVideoCollectionLog15ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoCollectionLog15ObjLstCache;
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
string strKey = string.Format("{0}", clsvVideoCollectionLog15EN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdVideoCollectionLog)
{
if (strInFldName != convVideoCollectionLog15.IdVideoCollectionLog)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convVideoCollectionLog15.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convVideoCollectionLog15.AttributeName));
throw new Exception(strMsg);
}
var objvVideoCollectionLog15 = clsvVideoCollectionLog15BL.GetObjByIdVideoCollectionLogCache(lngIdVideoCollectionLog);
if (objvVideoCollectionLog15 == null) return "";
return objvVideoCollectionLog15[strOutFldName].ToString();
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
int intRecCount = clsvVideoCollectionLog15DA.GetRecCount(strTabName);
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
int intRecCount = clsvVideoCollectionLog15DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvVideoCollectionLog15DA.GetRecCount();
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
int intRecCount = clsvVideoCollectionLog15DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvVideoCollectionLog15Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvVideoCollectionLog15EN objvVideoCollectionLog15Cond)
{
List<clsvVideoCollectionLog15EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoCollectionLog15EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoCollectionLog15.AttributeName)
{
if (objvVideoCollectionLog15Cond.IsUpdated(strFldName) == false) continue;
if (objvVideoCollectionLog15Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoCollectionLog15Cond[strFldName].ToString());
}
else
{
if (objvVideoCollectionLog15Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoCollectionLog15Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoCollectionLog15Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoCollectionLog15Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoCollectionLog15Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoCollectionLog15Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoCollectionLog15Cond[strFldName]));
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
 List<string> arrList = clsvVideoCollectionLog15DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vVideoCollectionLog15DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vVideoCollectionLog15DA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}