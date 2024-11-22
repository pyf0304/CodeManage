
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibBL
 表名:vVideoLib(01120262)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库(VideoLib)
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
public static class  clsvVideoLibBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdVideoLib">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibEN GetObj(this K_IdVideoLib_vVideoLib myKey)
{
clsvVideoLibEN objvVideoLibEN = clsvVideoLibBL.vVideoLibDA.GetObjByIdVideoLib(myKey.Value);
return objvVideoLibEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetIdVideoLib(this clsvVideoLibEN objvVideoLibEN, string strIdVideoLib, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdVideoLib, 8, convVideoLib.IdVideoLib);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdVideoLib, 8, convVideoLib.IdVideoLib);
}
objvVideoLibEN.IdVideoLib = strIdVideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.IdVideoLib) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.IdVideoLib, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.IdVideoLib] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetAppraiseCount(this clsvVideoLibEN objvVideoLibEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvVideoLibEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.AppraiseCount) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.AppraiseCount, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.AppraiseCount] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetLikeNum(this clsvVideoLibEN objvVideoLibEN, int? intLikeNum, string strComparisonOp="")
	{
objvVideoLibEN.LikeNum = intLikeNum; //点赞数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.LikeNum) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.LikeNum, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.LikeNum] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetPlayNum(this clsvVideoLibEN objvVideoLibEN, int? intPlayNum, string strComparisonOp="")
	{
objvVideoLibEN.PlayNum = intPlayNum; //播放数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.PlayNum) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.PlayNum, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.PlayNum] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibID(this clsvVideoLibEN objvVideoLibEN, string strVideoLibID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibID, convVideoLib.VideoLibID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLib.VideoLibID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLib.VideoLibID);
}
objvVideoLibEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibID) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibID, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibID] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibName(this clsvVideoLibEN objvVideoLibEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibName, convVideoLib.VideoLibName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLib.VideoLibName);
}
objvVideoLibEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibTheme(this clsvVideoLibEN objvVideoLibEN, string strVideoLibTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, convVideoLib.VideoLibTheme);
}
objvVideoLibEN.VideoLibTheme = strVideoLibTheme; //视频库主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibTheme) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibTheme, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibTheme] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetIdVideoLibType(this clsvVideoLibEN objvVideoLibEN, string strIdVideoLibType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdVideoLibType, convVideoLib.IdVideoLibType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdVideoLibType, 4, convVideoLib.IdVideoLibType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdVideoLibType, 4, convVideoLib.IdVideoLibType);
}
objvVideoLibEN.IdVideoLibType = strIdVideoLibType; //视频库类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.IdVideoLibType) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.IdVideoLibType, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.IdVideoLibType] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibTypeName(this clsvVideoLibEN objvVideoLibEN, string strVideoLibTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibTypeName, convVideoLib.VideoLibTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTypeName, 30, convVideoLib.VideoLibTypeName);
}
objvVideoLibEN.VideoLibTypeName = strVideoLibTypeName; //视频库类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibTypeName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibTypeName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibTypeName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibText(this clsvVideoLibEN objvVideoLibEN, string strVideoLibText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibText, 8000, convVideoLib.VideoLibText);
}
objvVideoLibEN.VideoLibText = strVideoLibText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibText) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibText, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibText] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibDate(this clsvVideoLibEN objvVideoLibEN, string strVideoLibDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDate, 20, convVideoLib.VideoLibDate);
}
objvVideoLibEN.VideoLibDate = strVideoLibDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibDate) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibDate, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibDate] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibTime(this clsvVideoLibEN objvVideoLibEN, string strVideoLibTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, convVideoLib.VideoLibTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, convVideoLib.VideoLibTime);
}
objvVideoLibEN.VideoLibTime = strVideoLibTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibTime) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibTime, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibTime] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibDateIn(this clsvVideoLibEN objvVideoLibEN, string strVideoLibDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, convVideoLib.VideoLibDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, convVideoLib.VideoLibDateIn);
}
objvVideoLibEN.VideoLibDateIn = strVideoLibDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibDateIn) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibDateIn, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibDateIn] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVideoLibTimeIn(this clsvVideoLibEN objvVideoLibEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, convVideoLib.VideoLibTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, convVideoLib.VideoLibTimeIn);
}
objvVideoLibEN.VideoLibTimeIn = strVideoLibTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoLibTimeIn) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoLibTimeIn, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoLibTimeIn] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetOwnerId(this clsvVideoLibEN objvVideoLibEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convVideoLib.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoLib.OwnerId);
}
objvVideoLibEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.OwnerId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.OwnerId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.OwnerId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetIdTeachingPlan(this clsvVideoLibEN objvVideoLibEN, string strIdTeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingPlan, convVideoLib.IdTeachingPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convVideoLib.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convVideoLib.IdTeachingPlan);
}
objvVideoLibEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.IdTeachingPlan) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.IdTeachingPlan, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.IdTeachingPlan] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetIdSenateGaugeVersion(this clsvVideoLibEN objvVideoLibEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, convVideoLib.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convVideoLib.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convVideoLib.IdSenateGaugeVersion);
}
objvVideoLibEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.IdSenateGaugeVersion) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetsenateGaugeVersionID(this clsvVideoLibEN objvVideoLibEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convVideoLib.senateGaugeVersionID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoLib.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoLib.senateGaugeVersionID);
}
objvVideoLibEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.senateGaugeVersionID) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetsenateGaugeVersionName(this clsvVideoLibEN objvVideoLibEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoLib.senateGaugeVersionName);
}
objvVideoLibEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.senateGaugeVersionName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetsenateGaugeVersionTtlScore(this clsvVideoLibEN objvVideoLibEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convVideoLib.senateGaugeVersionTtlScore);
objvVideoLibEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.senateGaugeVersionTtlScore) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetIsUse(this clsvVideoLibEN objvVideoLibEN, bool bolIsUse, string strComparisonOp="")
	{
objvVideoLibEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.IsUse) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.IsUse, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.IsUse] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVersionNo(this clsvVideoLibEN objvVideoLibEN, int? intVersionNo, string strComparisonOp="")
	{
objvVideoLibEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VersionNo) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VersionNo, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VersionNo] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetCaseLevelId(this clsvVideoLibEN objvVideoLibEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convVideoLib.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convVideoLib.CaseLevelId);
}
objvVideoLibEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CaseLevelId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CaseLevelId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CaseLevelId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetCaseLevelName(this clsvVideoLibEN objvVideoLibEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convVideoLib.CaseLevelName);
}
objvVideoLibEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CaseLevelName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CaseLevelName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CaseLevelName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetIsVisible(this clsvVideoLibEN objvVideoLibEN, bool bolIsVisible, string strComparisonOp="")
	{
objvVideoLibEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.IsVisible) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.IsVisible, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.IsVisible] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetIdXzCollege(this clsvVideoLibEN objvVideoLibEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convVideoLib.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convVideoLib.IdXzCollege);
}
objvVideoLibEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.IdXzCollege) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.IdXzCollege, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.IdXzCollege] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetCollegeID(this clsvVideoLibEN objvVideoLibEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeID, convVideoLib.CollegeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLib.CollegeID);
}
objvVideoLibEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CollegeID) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CollegeID, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CollegeID] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetCollegeName(this clsvVideoLibEN objvVideoLibEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convVideoLib.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLib.CollegeName);
}
objvVideoLibEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CollegeName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CollegeName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CollegeName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetCollegeNameA(this clsvVideoLibEN objvVideoLibEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoLib.CollegeNameA);
}
objvVideoLibEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CollegeNameA) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CollegeNameA, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CollegeNameA] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetViewCount(this clsvVideoLibEN objvVideoLibEN, int? intViewCount, string strComparisonOp="")
	{
objvVideoLibEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.ViewCount) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.ViewCount, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.ViewCount] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetDownloadNumber(this clsvVideoLibEN objvVideoLibEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvVideoLibEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.DownloadNumber) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.DownloadNumber, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.DownloadNumber] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetFileIntegration(this clsvVideoLibEN objvVideoLibEN, int? intFileIntegration, string strComparisonOp="")
	{
objvVideoLibEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.FileIntegration) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.FileIntegration, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.FileIntegration] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetLikeCount(this clsvVideoLibEN objvVideoLibEN, long? lngLikeCount, string strComparisonOp="")
	{
objvVideoLibEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.LikeCount) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.LikeCount, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.LikeCount] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetCollectionCount(this clsvVideoLibEN objvVideoLibEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvVideoLibEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CollectionCount) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CollectionCount, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CollectionCount] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetRecommendedDegreeId(this clsvVideoLibEN objvVideoLibEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convVideoLib.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convVideoLib.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convVideoLib.RecommendedDegreeId);
}
objvVideoLibEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.RecommendedDegreeId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.RecommendedDegreeId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.RecommendedDegreeId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetRecommendedDegreeName(this clsvVideoLibEN objvVideoLibEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeName, convVideoLib.RecommendedDegreeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convVideoLib.RecommendedDegreeName);
}
objvVideoLibEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.RecommendedDegreeName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.RecommendedDegreeName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.RecommendedDegreeName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetCourseId(this clsvVideoLibEN objvVideoLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convVideoLib.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLib.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLib.CourseId);
}
objvVideoLibEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CourseId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CourseId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CourseId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetCourseCode(this clsvVideoLibEN objvVideoLibEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLib.CourseCode);
}
objvVideoLibEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CourseCode) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CourseCode, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CourseCode] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetCourseName(this clsvVideoLibEN objvVideoLibEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLib.CourseName);
}
objvVideoLibEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CourseName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CourseName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CourseName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVideoUrl(this clsvVideoLibEN objvVideoLibEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convVideoLib.VideoUrl);
}
objvVideoLibEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoUrl) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoUrl, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoUrl] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetVideoPath(this clsvVideoLibEN objvVideoLibEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convVideoLib.VideoPath);
}
objvVideoLibEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.VideoPath) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.VideoPath, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.VideoPath] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetCoverPicUrl(this clsvVideoLibEN objvVideoLibEN, string strCoverPicUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCoverPicUrl, 1000, convVideoLib.CoverPicUrl);
}
objvVideoLibEN.CoverPicUrl = strCoverPicUrl; //封面Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CoverPicUrl) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CoverPicUrl, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CoverPicUrl] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetCoverPicShortUrl(this clsvVideoLibEN objvVideoLibEN, string strCoverPicShortUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCoverPicShortUrl, 1000, convVideoLib.CoverPicShortUrl);
}
objvVideoLibEN.CoverPicShortUrl = strCoverPicShortUrl; //封面短Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.CoverPicShortUrl) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.CoverPicShortUrl, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.CoverPicShortUrl] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetResErrMsg(this clsvVideoLibEN objvVideoLibEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convVideoLib.ResErrMsg);
}
objvVideoLibEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.ResErrMsg) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.ResErrMsg, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.ResErrMsg] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetUpdDate(this clsvVideoLibEN objvVideoLibEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convVideoLib.UpdDate);
}
objvVideoLibEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.UpdDate) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.UpdDate, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.UpdDate] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetUpdUserId(this clsvVideoLibEN objvVideoLibEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convVideoLib.UpdUserId);
}
objvVideoLibEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.UpdUserId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.UpdUserId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.UpdUserId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetMemo(this clsvVideoLibEN objvVideoLibEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoLib.Memo);
}
objvVideoLibEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.Memo) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.Memo, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.Memo] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetBrowseCount4Case(this clsvVideoLibEN objvVideoLibEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvVideoLibEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.BrowseCount4Case) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.BrowseCount4Case, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.BrowseCount4Case] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetOwnerName(this clsvVideoLibEN objvVideoLibEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoLib.OwnerName);
}
objvVideoLibEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.OwnerName) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.OwnerName, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.OwnerName] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetOwnerNameWithId(this clsvVideoLibEN objvVideoLibEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoLib.OwnerNameWithId);
}
objvVideoLibEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.OwnerNameWithId) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.OwnerNameWithId, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.OwnerNameWithId] = strComparisonOp;
}
}
return objvVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibEN SetIsHaveVideo(this clsvVideoLibEN objvVideoLibEN, string strIsHaveVideo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIsHaveVideo, 6, convVideoLib.IsHaveVideo);
}
objvVideoLibEN.IsHaveVideo = strIsHaveVideo; //IsHaveVideo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibEN.dicFldComparisonOp.ContainsKey(convVideoLib.IsHaveVideo) == false)
{
objvVideoLibEN.dicFldComparisonOp.Add(convVideoLib.IsHaveVideo, strComparisonOp);
}
else
{
objvVideoLibEN.dicFldComparisonOp[convVideoLib.IsHaveVideo] = strComparisonOp;
}
}
return objvVideoLibEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvVideoLibENS">源对象</param>
 /// <param name = "objvVideoLibENT">目标对象</param>
 public static void CopyTo(this clsvVideoLibEN objvVideoLibENS, clsvVideoLibEN objvVideoLibENT)
{
try
{
objvVideoLibENT.IdVideoLib = objvVideoLibENS.IdVideoLib; //视频库流水号
objvVideoLibENT.AppraiseCount = objvVideoLibENS.AppraiseCount; //评论数
objvVideoLibENT.LikeNum = objvVideoLibENS.LikeNum; //点赞数
objvVideoLibENT.PlayNum = objvVideoLibENS.PlayNum; //播放数
objvVideoLibENT.VideoLibID = objvVideoLibENS.VideoLibID; //视频库ID
objvVideoLibENT.VideoLibName = objvVideoLibENS.VideoLibName; //视频名称
objvVideoLibENT.VideoLibTheme = objvVideoLibENS.VideoLibTheme; //视频库主题词
objvVideoLibENT.IdVideoLibType = objvVideoLibENS.IdVideoLibType; //视频库类型流水号
objvVideoLibENT.VideoLibTypeName = objvVideoLibENS.VideoLibTypeName; //视频库类型名称
objvVideoLibENT.VideoLibText = objvVideoLibENS.VideoLibText; //案例文本内容
objvVideoLibENT.VideoLibDate = objvVideoLibENS.VideoLibDate; //视频资源日期
objvVideoLibENT.VideoLibTime = objvVideoLibENS.VideoLibTime; //视频资源时间
objvVideoLibENT.VideoLibDateIn = objvVideoLibENS.VideoLibDateIn; //案例入库日期
objvVideoLibENT.VideoLibTimeIn = objvVideoLibENS.VideoLibTimeIn; //案例入库时间
objvVideoLibENT.OwnerId = objvVideoLibENS.OwnerId; //拥有者Id
objvVideoLibENT.IdTeachingPlan = objvVideoLibENS.IdTeachingPlan; //教案流水号
objvVideoLibENT.IdSenateGaugeVersion = objvVideoLibENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoLibENT.senateGaugeVersionID = objvVideoLibENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLibENT.senateGaugeVersionName = objvVideoLibENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLibENT.senateGaugeVersionTtlScore = objvVideoLibENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLibENT.IsUse = objvVideoLibENS.IsUse; //是否使用
objvVideoLibENT.VersionNo = objvVideoLibENS.VersionNo; //版本号
objvVideoLibENT.CaseLevelId = objvVideoLibENS.CaseLevelId; //课例等级Id
objvVideoLibENT.CaseLevelName = objvVideoLibENS.CaseLevelName; //案例等级名称
objvVideoLibENT.IsVisible = objvVideoLibENS.IsVisible; //是否显示
objvVideoLibENT.IdXzCollege = objvVideoLibENS.IdXzCollege; //学院流水号
objvVideoLibENT.CollegeID = objvVideoLibENS.CollegeID; //学院ID
objvVideoLibENT.CollegeName = objvVideoLibENS.CollegeName; //学院名称
objvVideoLibENT.CollegeNameA = objvVideoLibENS.CollegeNameA; //学院名称简写
objvVideoLibENT.ViewCount = objvVideoLibENS.ViewCount; //浏览量
objvVideoLibENT.DownloadNumber = objvVideoLibENS.DownloadNumber; //下载数目
objvVideoLibENT.FileIntegration = objvVideoLibENS.FileIntegration; //文件积分
objvVideoLibENT.LikeCount = objvVideoLibENS.LikeCount; //资源喜欢数量
objvVideoLibENT.CollectionCount = objvVideoLibENS.CollectionCount; //收藏数量
objvVideoLibENT.RecommendedDegreeId = objvVideoLibENS.RecommendedDegreeId; //推荐度Id
objvVideoLibENT.RecommendedDegreeName = objvVideoLibENS.RecommendedDegreeName; //推荐度名称
objvVideoLibENT.CourseId = objvVideoLibENS.CourseId; //课程Id
objvVideoLibENT.CourseCode = objvVideoLibENS.CourseCode; //课程代码
objvVideoLibENT.CourseName = objvVideoLibENS.CourseName; //课程名称
objvVideoLibENT.VideoUrl = objvVideoLibENS.VideoUrl; //视频Url
objvVideoLibENT.VideoPath = objvVideoLibENS.VideoPath; //视频目录
objvVideoLibENT.CoverPicUrl = objvVideoLibENS.CoverPicUrl; //封面Url
objvVideoLibENT.CoverPicShortUrl = objvVideoLibENS.CoverPicShortUrl; //封面短Url
objvVideoLibENT.ResErrMsg = objvVideoLibENS.ResErrMsg; //资源错误信息
objvVideoLibENT.UpdDate = objvVideoLibENS.UpdDate; //修改日期
objvVideoLibENT.UpdUserId = objvVideoLibENS.UpdUserId; //修改用户Id
objvVideoLibENT.Memo = objvVideoLibENS.Memo; //备注
objvVideoLibENT.BrowseCount4Case = objvVideoLibENS.BrowseCount4Case; //课例浏览次数
objvVideoLibENT.OwnerName = objvVideoLibENS.OwnerName; //拥有者姓名
objvVideoLibENT.OwnerNameWithId = objvVideoLibENS.OwnerNameWithId; //拥有者名称附Id
objvVideoLibENT.IsHaveVideo = objvVideoLibENS.IsHaveVideo; //IsHaveVideo
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
 /// <param name = "objvVideoLibENS">源对象</param>
 /// <returns>目标对象=>clsvVideoLibEN:objvVideoLibENT</returns>
 public static clsvVideoLibEN CopyTo(this clsvVideoLibEN objvVideoLibENS)
{
try
{
 clsvVideoLibEN objvVideoLibENT = new clsvVideoLibEN()
{
IdVideoLib = objvVideoLibENS.IdVideoLib, //视频库流水号
AppraiseCount = objvVideoLibENS.AppraiseCount, //评论数
LikeNum = objvVideoLibENS.LikeNum, //点赞数
PlayNum = objvVideoLibENS.PlayNum, //播放数
VideoLibID = objvVideoLibENS.VideoLibID, //视频库ID
VideoLibName = objvVideoLibENS.VideoLibName, //视频名称
VideoLibTheme = objvVideoLibENS.VideoLibTheme, //视频库主题词
IdVideoLibType = objvVideoLibENS.IdVideoLibType, //视频库类型流水号
VideoLibTypeName = objvVideoLibENS.VideoLibTypeName, //视频库类型名称
VideoLibText = objvVideoLibENS.VideoLibText, //案例文本内容
VideoLibDate = objvVideoLibENS.VideoLibDate, //视频资源日期
VideoLibTime = objvVideoLibENS.VideoLibTime, //视频资源时间
VideoLibDateIn = objvVideoLibENS.VideoLibDateIn, //案例入库日期
VideoLibTimeIn = objvVideoLibENS.VideoLibTimeIn, //案例入库时间
OwnerId = objvVideoLibENS.OwnerId, //拥有者Id
IdTeachingPlan = objvVideoLibENS.IdTeachingPlan, //教案流水号
IdSenateGaugeVersion = objvVideoLibENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvVideoLibENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvVideoLibENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvVideoLibENS.senateGaugeVersionTtlScore, //评价量表版本总分
IsUse = objvVideoLibENS.IsUse, //是否使用
VersionNo = objvVideoLibENS.VersionNo, //版本号
CaseLevelId = objvVideoLibENS.CaseLevelId, //课例等级Id
CaseLevelName = objvVideoLibENS.CaseLevelName, //案例等级名称
IsVisible = objvVideoLibENS.IsVisible, //是否显示
IdXzCollege = objvVideoLibENS.IdXzCollege, //学院流水号
CollegeID = objvVideoLibENS.CollegeID, //学院ID
CollegeName = objvVideoLibENS.CollegeName, //学院名称
CollegeNameA = objvVideoLibENS.CollegeNameA, //学院名称简写
ViewCount = objvVideoLibENS.ViewCount, //浏览量
DownloadNumber = objvVideoLibENS.DownloadNumber, //下载数目
FileIntegration = objvVideoLibENS.FileIntegration, //文件积分
LikeCount = objvVideoLibENS.LikeCount, //资源喜欢数量
CollectionCount = objvVideoLibENS.CollectionCount, //收藏数量
RecommendedDegreeId = objvVideoLibENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvVideoLibENS.RecommendedDegreeName, //推荐度名称
CourseId = objvVideoLibENS.CourseId, //课程Id
CourseCode = objvVideoLibENS.CourseCode, //课程代码
CourseName = objvVideoLibENS.CourseName, //课程名称
VideoUrl = objvVideoLibENS.VideoUrl, //视频Url
VideoPath = objvVideoLibENS.VideoPath, //视频目录
CoverPicUrl = objvVideoLibENS.CoverPicUrl, //封面Url
CoverPicShortUrl = objvVideoLibENS.CoverPicShortUrl, //封面短Url
ResErrMsg = objvVideoLibENS.ResErrMsg, //资源错误信息
UpdDate = objvVideoLibENS.UpdDate, //修改日期
UpdUserId = objvVideoLibENS.UpdUserId, //修改用户Id
Memo = objvVideoLibENS.Memo, //备注
BrowseCount4Case = objvVideoLibENS.BrowseCount4Case, //课例浏览次数
OwnerName = objvVideoLibENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvVideoLibENS.OwnerNameWithId, //拥有者名称附Id
IsHaveVideo = objvVideoLibENS.IsHaveVideo, //IsHaveVideo
};
 return objvVideoLibENT;
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
public static void CheckProperty4Condition(this clsvVideoLibEN objvVideoLibEN)
{
 clsvVideoLibBL.vVideoLibDA.CheckProperty4Condition(objvVideoLibEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLibEN objvVideoLibCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLibCond.IsUpdated(convVideoLib.IdVideoLib) == true)
{
string strComparisonOpIdVideoLib = objvVideoLibCond.dicFldComparisonOp[convVideoLib.IdVideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.IdVideoLib, objvVideoLibCond.IdVideoLib, strComparisonOpIdVideoLib);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvVideoLibCond.dicFldComparisonOp[convVideoLib.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.AppraiseCount, objvVideoLibCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.LikeNum) == true)
{
string strComparisonOpLikeNum = objvVideoLibCond.dicFldComparisonOp[convVideoLib.LikeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.LikeNum, objvVideoLibCond.LikeNum, strComparisonOpLikeNum);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.PlayNum) == true)
{
string strComparisonOpPlayNum = objvVideoLibCond.dicFldComparisonOp[convVideoLib.PlayNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.PlayNum, objvVideoLibCond.PlayNum, strComparisonOpPlayNum);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VideoLibID) == true)
{
string strComparisonOpVideoLibID = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibID, objvVideoLibCond.VideoLibID, strComparisonOpVideoLibID);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VideoLibName) == true)
{
string strComparisonOpVideoLibName = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibName, objvVideoLibCond.VideoLibName, strComparisonOpVideoLibName);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VideoLibTheme) == true)
{
string strComparisonOpVideoLibTheme = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibTheme, objvVideoLibCond.VideoLibTheme, strComparisonOpVideoLibTheme);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.IdVideoLibType) == true)
{
string strComparisonOpIdVideoLibType = objvVideoLibCond.dicFldComparisonOp[convVideoLib.IdVideoLibType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.IdVideoLibType, objvVideoLibCond.IdVideoLibType, strComparisonOpIdVideoLibType);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VideoLibTypeName) == true)
{
string strComparisonOpVideoLibTypeName = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VideoLibTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibTypeName, objvVideoLibCond.VideoLibTypeName, strComparisonOpVideoLibTypeName);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VideoLibText) == true)
{
string strComparisonOpVideoLibText = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VideoLibText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibText, objvVideoLibCond.VideoLibText, strComparisonOpVideoLibText);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VideoLibDate) == true)
{
string strComparisonOpVideoLibDate = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibDate, objvVideoLibCond.VideoLibDate, strComparisonOpVideoLibDate);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VideoLibTime) == true)
{
string strComparisonOpVideoLibTime = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibTime, objvVideoLibCond.VideoLibTime, strComparisonOpVideoLibTime);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VideoLibDateIn) == true)
{
string strComparisonOpVideoLibDateIn = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibDateIn, objvVideoLibCond.VideoLibDateIn, strComparisonOpVideoLibDateIn);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VideoLibTimeIn) == true)
{
string strComparisonOpVideoLibTimeIn = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoLibTimeIn, objvVideoLibCond.VideoLibTimeIn, strComparisonOpVideoLibTimeIn);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.OwnerId) == true)
{
string strComparisonOpOwnerId = objvVideoLibCond.dicFldComparisonOp[convVideoLib.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.OwnerId, objvVideoLibCond.OwnerId, strComparisonOpOwnerId);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvVideoLibCond.dicFldComparisonOp[convVideoLib.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.IdTeachingPlan, objvVideoLibCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvVideoLibCond.dicFldComparisonOp[convVideoLib.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.IdSenateGaugeVersion, objvVideoLibCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvVideoLibCond.dicFldComparisonOp[convVideoLib.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.senateGaugeVersionID, objvVideoLibCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvVideoLibCond.dicFldComparisonOp[convVideoLib.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.senateGaugeVersionName, objvVideoLibCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvVideoLibCond.dicFldComparisonOp[convVideoLib.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.senateGaugeVersionTtlScore, objvVideoLibCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.IsUse) == true)
{
if (objvVideoLibCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib.IsUse);
}
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VersionNo) == true)
{
string strComparisonOpVersionNo = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.VersionNo, objvVideoLibCond.VersionNo, strComparisonOpVersionNo);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvVideoLibCond.dicFldComparisonOp[convVideoLib.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CaseLevelId, objvVideoLibCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvVideoLibCond.dicFldComparisonOp[convVideoLib.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CaseLevelName, objvVideoLibCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.IsVisible) == true)
{
if (objvVideoLibCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib.IsVisible);
}
}
if (objvVideoLibCond.IsUpdated(convVideoLib.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvVideoLibCond.dicFldComparisonOp[convVideoLib.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.IdXzCollege, objvVideoLibCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.CollegeID) == true)
{
string strComparisonOpCollegeID = objvVideoLibCond.dicFldComparisonOp[convVideoLib.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CollegeID, objvVideoLibCond.CollegeID, strComparisonOpCollegeID);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.CollegeName) == true)
{
string strComparisonOpCollegeName = objvVideoLibCond.dicFldComparisonOp[convVideoLib.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CollegeName, objvVideoLibCond.CollegeName, strComparisonOpCollegeName);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvVideoLibCond.dicFldComparisonOp[convVideoLib.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CollegeNameA, objvVideoLibCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.ViewCount) == true)
{
string strComparisonOpViewCount = objvVideoLibCond.dicFldComparisonOp[convVideoLib.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.ViewCount, objvVideoLibCond.ViewCount, strComparisonOpViewCount);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvVideoLibCond.dicFldComparisonOp[convVideoLib.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.DownloadNumber, objvVideoLibCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvVideoLibCond.dicFldComparisonOp[convVideoLib.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.FileIntegration, objvVideoLibCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.LikeCount) == true)
{
string strComparisonOpLikeCount = objvVideoLibCond.dicFldComparisonOp[convVideoLib.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.LikeCount, objvVideoLibCond.LikeCount, strComparisonOpLikeCount);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvVideoLibCond.dicFldComparisonOp[convVideoLib.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.CollectionCount, objvVideoLibCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvVideoLibCond.dicFldComparisonOp[convVideoLib.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.RecommendedDegreeId, objvVideoLibCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvVideoLibCond.dicFldComparisonOp[convVideoLib.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.RecommendedDegreeName, objvVideoLibCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.CourseId) == true)
{
string strComparisonOpCourseId = objvVideoLibCond.dicFldComparisonOp[convVideoLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CourseId, objvVideoLibCond.CourseId, strComparisonOpCourseId);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.CourseCode) == true)
{
string strComparisonOpCourseCode = objvVideoLibCond.dicFldComparisonOp[convVideoLib.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CourseCode, objvVideoLibCond.CourseCode, strComparisonOpCourseCode);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.CourseName) == true)
{
string strComparisonOpCourseName = objvVideoLibCond.dicFldComparisonOp[convVideoLib.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CourseName, objvVideoLibCond.CourseName, strComparisonOpCourseName);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoUrl, objvVideoLibCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.VideoPath) == true)
{
string strComparisonOpVideoPath = objvVideoLibCond.dicFldComparisonOp[convVideoLib.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.VideoPath, objvVideoLibCond.VideoPath, strComparisonOpVideoPath);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.CoverPicUrl) == true)
{
string strComparisonOpCoverPicUrl = objvVideoLibCond.dicFldComparisonOp[convVideoLib.CoverPicUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CoverPicUrl, objvVideoLibCond.CoverPicUrl, strComparisonOpCoverPicUrl);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.CoverPicShortUrl) == true)
{
string strComparisonOpCoverPicShortUrl = objvVideoLibCond.dicFldComparisonOp[convVideoLib.CoverPicShortUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.CoverPicShortUrl, objvVideoLibCond.CoverPicShortUrl, strComparisonOpCoverPicShortUrl);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objvVideoLibCond.dicFldComparisonOp[convVideoLib.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.ResErrMsg, objvVideoLibCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.UpdDate) == true)
{
string strComparisonOpUpdDate = objvVideoLibCond.dicFldComparisonOp[convVideoLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.UpdDate, objvVideoLibCond.UpdDate, strComparisonOpUpdDate);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvVideoLibCond.dicFldComparisonOp[convVideoLib.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.UpdUserId, objvVideoLibCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.Memo) == true)
{
string strComparisonOpMemo = objvVideoLibCond.dicFldComparisonOp[convVideoLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.Memo, objvVideoLibCond.Memo, strComparisonOpMemo);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvVideoLibCond.dicFldComparisonOp[convVideoLib.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib.BrowseCount4Case, objvVideoLibCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.OwnerName) == true)
{
string strComparisonOpOwnerName = objvVideoLibCond.dicFldComparisonOp[convVideoLib.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.OwnerName, objvVideoLibCond.OwnerName, strComparisonOpOwnerName);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvVideoLibCond.dicFldComparisonOp[convVideoLib.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.OwnerNameWithId, objvVideoLibCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvVideoLibCond.IsUpdated(convVideoLib.IsHaveVideo) == true)
{
string strComparisonOpIsHaveVideo = objvVideoLibCond.dicFldComparisonOp[convVideoLib.IsHaveVideo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib.IsHaveVideo, objvVideoLibCond.IsHaveVideo, strComparisonOpIsHaveVideo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vVideoLib
{
public virtual bool UpdRelaTabDate(string strIdVideoLib, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v视频库(vVideoLib)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLibBL
{
public static RelatedActions_vVideoLib relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvVideoLibDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvVideoLibDA vVideoLibDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvVideoLibDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvVideoLibBL()
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
if (string.IsNullOrEmpty(clsvVideoLibEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLibEN._ConnectString);
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
public static DataTable GetDataTable_vVideoLib(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vVideoLibDA.GetDataTable_vVideoLib(strWhereCond);
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
objDT = vVideoLibDA.GetDataTable(strWhereCond);
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
objDT = vVideoLibDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vVideoLibDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vVideoLibDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vVideoLibDA.GetDataTable_Top(objTopPara);
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
objDT = vVideoLibDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vVideoLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vVideoLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdVideoLibLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvVideoLibEN> GetObjLstByIdVideoLibLst(List<string> arrIdVideoLibLst)
{
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdVideoLibLst, true);
 string strWhereCond = string.Format("IdVideoLib in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdVideoLibLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvVideoLibEN> GetObjLstByIdVideoLibLstCache(List<string> arrIdVideoLibLst)
{
string strKey = string.Format("{0}", clsvVideoLibEN._CurrTabName);
List<clsvVideoLibEN> arrvVideoLibObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibEN> arrvVideoLibObjLst_Sel =
arrvVideoLibObjLstCache
.Where(x => arrIdVideoLibLst.Contains(x.IdVideoLib));
return arrvVideoLibObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibEN> GetObjLst(string strWhereCond)
{
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibEN);
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
public static List<clsvVideoLibEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvVideoLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvVideoLibEN> GetSubObjLstCache(clsvVideoLibEN objvVideoLibCond)
{
List<clsvVideoLibEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLib.AttributeName)
{
if (objvVideoLibCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibCond[strFldName].ToString());
}
else
{
if (objvVideoLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLibCond[strFldName]));
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
public static List<clsvVideoLibEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibEN);
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
public static List<clsvVideoLibEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibEN);
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
List<clsvVideoLibEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvVideoLibEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvVideoLibEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
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
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibEN);
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
public static List<clsvVideoLibEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvVideoLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvVideoLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibEN);
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
public static List<clsvVideoLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvVideoLibEN> arrObjLst = new List<clsvVideoLibEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibEN objvVideoLibEN = new clsvVideoLibEN();
try
{
objvVideoLibEN.IdVideoLib = objRow[convVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibEN.AppraiseCount = objRow[convVideoLib.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.AppraiseCount].ToString().Trim()); //评论数
objvVideoLibEN.LikeNum = objRow[convVideoLib.LikeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeNum].ToString().Trim()); //点赞数
objvVideoLibEN.PlayNum = objRow[convVideoLib.PlayNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.PlayNum].ToString().Trim()); //播放数
objvVideoLibEN.VideoLibID = objRow[convVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibEN.VideoLibName = objRow[convVideoLib.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibEN.VideoLibTheme = objRow[convVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibEN.IdVideoLibType = objRow[convVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLibEN.VideoLibTypeName = objRow[convVideoLib.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibEN.VideoLibText = objRow[convVideoLib.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLibEN.VideoLibDate = objRow[convVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibEN.VideoLibTime = objRow[convVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibEN.VideoLibDateIn = objRow[convVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibEN.VideoLibTimeIn = objRow[convVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibEN.OwnerId = objRow[convVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLibEN.IdTeachingPlan = objRow[convVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLibEN.IdSenateGaugeVersion = objRow[convVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLibEN.senateGaugeVersionID = objRow[convVideoLib.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLibEN.senateGaugeVersionName = objRow[convVideoLib.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convVideoLib.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLibEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsUse].ToString().Trim()); //是否使用
objvVideoLibEN.VersionNo = objRow[convVideoLib.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.VersionNo].ToString().Trim()); //版本号
objvVideoLibEN.CaseLevelId = objRow[convVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLibEN.CaseLevelName = objRow[convVideoLib.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib.IsVisible].ToString().Trim()); //是否显示
objvVideoLibEN.IdXzCollege = objRow[convVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibEN.CollegeID = objRow[convVideoLib.CollegeID].ToString().Trim(); //学院ID
objvVideoLibEN.CollegeName = objRow[convVideoLib.CollegeName].ToString().Trim(); //学院名称
objvVideoLibEN.CollegeNameA = objRow[convVideoLib.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibEN.ViewCount = objRow[convVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.ViewCount].ToString().Trim()); //浏览量
objvVideoLibEN.DownloadNumber = objRow[convVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLibEN.FileIntegration = objRow[convVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.FileIntegration].ToString().Trim()); //文件积分
objvVideoLibEN.LikeCount = objRow[convVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLibEN.CollectionCount = objRow[convVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLibEN.RecommendedDegreeId = objRow[convVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLibEN.RecommendedDegreeName = objRow[convVideoLib.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLibEN.CourseId = objRow[convVideoLib.CourseId].ToString().Trim(); //课程Id
objvVideoLibEN.CourseCode = objRow[convVideoLib.CourseCode] == DBNull.Value ? null : objRow[convVideoLib.CourseCode].ToString().Trim(); //课程代码
objvVideoLibEN.CourseName = objRow[convVideoLib.CourseName] == DBNull.Value ? null : objRow[convVideoLib.CourseName].ToString().Trim(); //课程名称
objvVideoLibEN.VideoUrl = objRow[convVideoLib.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib.VideoUrl].ToString().Trim(); //视频Url
objvVideoLibEN.VideoPath = objRow[convVideoLib.VideoPath] == DBNull.Value ? null : objRow[convVideoLib.VideoPath].ToString().Trim(); //视频目录
objvVideoLibEN.CoverPicUrl = objRow[convVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLibEN.CoverPicShortUrl = objRow[convVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLibEN.ResErrMsg = objRow[convVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLibEN.UpdDate = objRow[convVideoLib.UpdDate] == DBNull.Value ? null : objRow[convVideoLib.UpdDate].ToString().Trim(); //修改日期
objvVideoLibEN.UpdUserId = objRow[convVideoLib.UpdUserId] == DBNull.Value ? null : objRow[convVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objvVideoLibEN.Memo = objRow[convVideoLib.Memo] == DBNull.Value ? null : objRow[convVideoLib.Memo].ToString().Trim(); //备注
objvVideoLibEN.BrowseCount4Case = objRow[convVideoLib.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibEN.OwnerName = objRow[convVideoLib.OwnerName] == DBNull.Value ? null : objRow[convVideoLib.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLibEN.OwnerNameWithId = objRow[convVideoLib.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLibEN.IsHaveVideo = objRow[convVideoLib.IsHaveVideo] == DBNull.Value ? null : objRow[convVideoLib.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvVideoLibEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvVideoLib(ref clsvVideoLibEN objvVideoLibEN)
{
bool bolResult = vVideoLibDA.GetvVideoLib(ref objvVideoLibEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdVideoLib">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibEN GetObjByIdVideoLib(string strIdVideoLib)
{
if (strIdVideoLib.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdVideoLib]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdVideoLib) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdVideoLib]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvVideoLibEN objvVideoLibEN = vVideoLibDA.GetObjByIdVideoLib(strIdVideoLib);
return objvVideoLibEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvVideoLibEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvVideoLibEN objvVideoLibEN = vVideoLibDA.GetFirstObj(strWhereCond);
 return objvVideoLibEN;
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
public static clsvVideoLibEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvVideoLibEN objvVideoLibEN = vVideoLibDA.GetObjByDataRow(objRow);
 return objvVideoLibEN;
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
public static clsvVideoLibEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvVideoLibEN objvVideoLibEN = vVideoLibDA.GetObjByDataRow(objRow);
 return objvVideoLibEN;
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
 /// <param name = "strIdVideoLib">所给的关键字</param>
 /// <param name = "lstvVideoLibObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLibEN GetObjByIdVideoLibFromList(string strIdVideoLib, List<clsvVideoLibEN> lstvVideoLibObjLst)
{
foreach (clsvVideoLibEN objvVideoLibEN in lstvVideoLibObjLst)
{
if (objvVideoLibEN.IdVideoLib == strIdVideoLib)
{
return objvVideoLibEN;
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
 string strIdVideoLib;
 try
 {
 strIdVideoLib = new clsvVideoLibDA().GetFirstID(strWhereCond);
 return strIdVideoLib;
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
 arrList = vVideoLibDA.GetID(strWhereCond);
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
bool bolIsExist = vVideoLibDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdVideoLib">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdVideoLib)
{
if (string.IsNullOrEmpty(strIdVideoLib) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdVideoLib]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vVideoLibDA.IsExist(strIdVideoLib);
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
 bolIsExist = clsvVideoLibDA.IsExistTable();
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
 bolIsExist = vVideoLibDA.IsExistTable(strTabName);
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
 /// <param name = "objvVideoLibENS">源对象</param>
 /// <param name = "objvVideoLibENT">目标对象</param>
 public static void CopyTo(clsvVideoLibEN objvVideoLibENS, clsvVideoLibEN objvVideoLibENT)
{
try
{
objvVideoLibENT.IdVideoLib = objvVideoLibENS.IdVideoLib; //视频库流水号
objvVideoLibENT.AppraiseCount = objvVideoLibENS.AppraiseCount; //评论数
objvVideoLibENT.LikeNum = objvVideoLibENS.LikeNum; //点赞数
objvVideoLibENT.PlayNum = objvVideoLibENS.PlayNum; //播放数
objvVideoLibENT.VideoLibID = objvVideoLibENS.VideoLibID; //视频库ID
objvVideoLibENT.VideoLibName = objvVideoLibENS.VideoLibName; //视频名称
objvVideoLibENT.VideoLibTheme = objvVideoLibENS.VideoLibTheme; //视频库主题词
objvVideoLibENT.IdVideoLibType = objvVideoLibENS.IdVideoLibType; //视频库类型流水号
objvVideoLibENT.VideoLibTypeName = objvVideoLibENS.VideoLibTypeName; //视频库类型名称
objvVideoLibENT.VideoLibText = objvVideoLibENS.VideoLibText; //案例文本内容
objvVideoLibENT.VideoLibDate = objvVideoLibENS.VideoLibDate; //视频资源日期
objvVideoLibENT.VideoLibTime = objvVideoLibENS.VideoLibTime; //视频资源时间
objvVideoLibENT.VideoLibDateIn = objvVideoLibENS.VideoLibDateIn; //案例入库日期
objvVideoLibENT.VideoLibTimeIn = objvVideoLibENS.VideoLibTimeIn; //案例入库时间
objvVideoLibENT.OwnerId = objvVideoLibENS.OwnerId; //拥有者Id
objvVideoLibENT.IdTeachingPlan = objvVideoLibENS.IdTeachingPlan; //教案流水号
objvVideoLibENT.IdSenateGaugeVersion = objvVideoLibENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoLibENT.senateGaugeVersionID = objvVideoLibENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLibENT.senateGaugeVersionName = objvVideoLibENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLibENT.senateGaugeVersionTtlScore = objvVideoLibENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLibENT.IsUse = objvVideoLibENS.IsUse; //是否使用
objvVideoLibENT.VersionNo = objvVideoLibENS.VersionNo; //版本号
objvVideoLibENT.CaseLevelId = objvVideoLibENS.CaseLevelId; //课例等级Id
objvVideoLibENT.CaseLevelName = objvVideoLibENS.CaseLevelName; //案例等级名称
objvVideoLibENT.IsVisible = objvVideoLibENS.IsVisible; //是否显示
objvVideoLibENT.IdXzCollege = objvVideoLibENS.IdXzCollege; //学院流水号
objvVideoLibENT.CollegeID = objvVideoLibENS.CollegeID; //学院ID
objvVideoLibENT.CollegeName = objvVideoLibENS.CollegeName; //学院名称
objvVideoLibENT.CollegeNameA = objvVideoLibENS.CollegeNameA; //学院名称简写
objvVideoLibENT.ViewCount = objvVideoLibENS.ViewCount; //浏览量
objvVideoLibENT.DownloadNumber = objvVideoLibENS.DownloadNumber; //下载数目
objvVideoLibENT.FileIntegration = objvVideoLibENS.FileIntegration; //文件积分
objvVideoLibENT.LikeCount = objvVideoLibENS.LikeCount; //资源喜欢数量
objvVideoLibENT.CollectionCount = objvVideoLibENS.CollectionCount; //收藏数量
objvVideoLibENT.RecommendedDegreeId = objvVideoLibENS.RecommendedDegreeId; //推荐度Id
objvVideoLibENT.RecommendedDegreeName = objvVideoLibENS.RecommendedDegreeName; //推荐度名称
objvVideoLibENT.CourseId = objvVideoLibENS.CourseId; //课程Id
objvVideoLibENT.CourseCode = objvVideoLibENS.CourseCode; //课程代码
objvVideoLibENT.CourseName = objvVideoLibENS.CourseName; //课程名称
objvVideoLibENT.VideoUrl = objvVideoLibENS.VideoUrl; //视频Url
objvVideoLibENT.VideoPath = objvVideoLibENS.VideoPath; //视频目录
objvVideoLibENT.CoverPicUrl = objvVideoLibENS.CoverPicUrl; //封面Url
objvVideoLibENT.CoverPicShortUrl = objvVideoLibENS.CoverPicShortUrl; //封面短Url
objvVideoLibENT.ResErrMsg = objvVideoLibENS.ResErrMsg; //资源错误信息
objvVideoLibENT.UpdDate = objvVideoLibENS.UpdDate; //修改日期
objvVideoLibENT.UpdUserId = objvVideoLibENS.UpdUserId; //修改用户Id
objvVideoLibENT.Memo = objvVideoLibENS.Memo; //备注
objvVideoLibENT.BrowseCount4Case = objvVideoLibENS.BrowseCount4Case; //课例浏览次数
objvVideoLibENT.OwnerName = objvVideoLibENS.OwnerName; //拥有者姓名
objvVideoLibENT.OwnerNameWithId = objvVideoLibENS.OwnerNameWithId; //拥有者名称附Id
objvVideoLibENT.IsHaveVideo = objvVideoLibENS.IsHaveVideo; //IsHaveVideo
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
 /// <param name = "objvVideoLibEN">源简化对象</param>
 public static void SetUpdFlag(clsvVideoLibEN objvVideoLibEN)
{
try
{
objvVideoLibEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvVideoLibEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convVideoLib.IdVideoLib, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.IdVideoLib = objvVideoLibEN.IdVideoLib; //视频库流水号
}
if (arrFldSet.Contains(convVideoLib.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.AppraiseCount = objvVideoLibEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convVideoLib.LikeNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.LikeNum = objvVideoLibEN.LikeNum; //点赞数
}
if (arrFldSet.Contains(convVideoLib.PlayNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.PlayNum = objvVideoLibEN.PlayNum; //播放数
}
if (arrFldSet.Contains(convVideoLib.VideoLibID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VideoLibID = objvVideoLibEN.VideoLibID; //视频库ID
}
if (arrFldSet.Contains(convVideoLib.VideoLibName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VideoLibName = objvVideoLibEN.VideoLibName; //视频名称
}
if (arrFldSet.Contains(convVideoLib.VideoLibTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VideoLibTheme = objvVideoLibEN.VideoLibTheme == "[null]" ? null :  objvVideoLibEN.VideoLibTheme; //视频库主题词
}
if (arrFldSet.Contains(convVideoLib.IdVideoLibType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.IdVideoLibType = objvVideoLibEN.IdVideoLibType; //视频库类型流水号
}
if (arrFldSet.Contains(convVideoLib.VideoLibTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VideoLibTypeName = objvVideoLibEN.VideoLibTypeName; //视频库类型名称
}
if (arrFldSet.Contains(convVideoLib.VideoLibText, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VideoLibText = objvVideoLibEN.VideoLibText == "[null]" ? null :  objvVideoLibEN.VideoLibText; //案例文本内容
}
if (arrFldSet.Contains(convVideoLib.VideoLibDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VideoLibDate = objvVideoLibEN.VideoLibDate == "[null]" ? null :  objvVideoLibEN.VideoLibDate; //视频资源日期
}
if (arrFldSet.Contains(convVideoLib.VideoLibTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VideoLibTime = objvVideoLibEN.VideoLibTime == "[null]" ? null :  objvVideoLibEN.VideoLibTime; //视频资源时间
}
if (arrFldSet.Contains(convVideoLib.VideoLibDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VideoLibDateIn = objvVideoLibEN.VideoLibDateIn == "[null]" ? null :  objvVideoLibEN.VideoLibDateIn; //案例入库日期
}
if (arrFldSet.Contains(convVideoLib.VideoLibTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VideoLibTimeIn = objvVideoLibEN.VideoLibTimeIn == "[null]" ? null :  objvVideoLibEN.VideoLibTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convVideoLib.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.OwnerId = objvVideoLibEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convVideoLib.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.IdTeachingPlan = objvVideoLibEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convVideoLib.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.IdSenateGaugeVersion = objvVideoLibEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convVideoLib.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.senateGaugeVersionID = objvVideoLibEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convVideoLib.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.senateGaugeVersionName = objvVideoLibEN.senateGaugeVersionName == "[null]" ? null :  objvVideoLibEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convVideoLib.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.senateGaugeVersionTtlScore = objvVideoLibEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convVideoLib.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.IsUse = objvVideoLibEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convVideoLib.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VersionNo = objvVideoLibEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convVideoLib.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.CaseLevelId = objvVideoLibEN.CaseLevelId == "[null]" ? null :  objvVideoLibEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convVideoLib.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.CaseLevelName = objvVideoLibEN.CaseLevelName == "[null]" ? null :  objvVideoLibEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convVideoLib.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.IsVisible = objvVideoLibEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convVideoLib.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.IdXzCollege = objvVideoLibEN.IdXzCollege == "[null]" ? null :  objvVideoLibEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convVideoLib.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.CollegeID = objvVideoLibEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convVideoLib.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.CollegeName = objvVideoLibEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convVideoLib.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.CollegeNameA = objvVideoLibEN.CollegeNameA == "[null]" ? null :  objvVideoLibEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convVideoLib.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.ViewCount = objvVideoLibEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convVideoLib.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.DownloadNumber = objvVideoLibEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convVideoLib.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.FileIntegration = objvVideoLibEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convVideoLib.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.LikeCount = objvVideoLibEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convVideoLib.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.CollectionCount = objvVideoLibEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convVideoLib.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.RecommendedDegreeId = objvVideoLibEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convVideoLib.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.RecommendedDegreeName = objvVideoLibEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convVideoLib.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.CourseId = objvVideoLibEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convVideoLib.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.CourseCode = objvVideoLibEN.CourseCode == "[null]" ? null :  objvVideoLibEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convVideoLib.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.CourseName = objvVideoLibEN.CourseName == "[null]" ? null :  objvVideoLibEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convVideoLib.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VideoUrl = objvVideoLibEN.VideoUrl == "[null]" ? null :  objvVideoLibEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convVideoLib.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.VideoPath = objvVideoLibEN.VideoPath == "[null]" ? null :  objvVideoLibEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convVideoLib.CoverPicUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.CoverPicUrl = objvVideoLibEN.CoverPicUrl == "[null]" ? null :  objvVideoLibEN.CoverPicUrl; //封面Url
}
if (arrFldSet.Contains(convVideoLib.CoverPicShortUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.CoverPicShortUrl = objvVideoLibEN.CoverPicShortUrl == "[null]" ? null :  objvVideoLibEN.CoverPicShortUrl; //封面短Url
}
if (arrFldSet.Contains(convVideoLib.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.ResErrMsg = objvVideoLibEN.ResErrMsg == "[null]" ? null :  objvVideoLibEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(convVideoLib.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.UpdDate = objvVideoLibEN.UpdDate == "[null]" ? null :  objvVideoLibEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convVideoLib.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.UpdUserId = objvVideoLibEN.UpdUserId == "[null]" ? null :  objvVideoLibEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convVideoLib.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.Memo = objvVideoLibEN.Memo == "[null]" ? null :  objvVideoLibEN.Memo; //备注
}
if (arrFldSet.Contains(convVideoLib.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.BrowseCount4Case = objvVideoLibEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convVideoLib.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.OwnerName = objvVideoLibEN.OwnerName == "[null]" ? null :  objvVideoLibEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convVideoLib.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.OwnerNameWithId = objvVideoLibEN.OwnerNameWithId == "[null]" ? null :  objvVideoLibEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convVideoLib.IsHaveVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibEN.IsHaveVideo = objvVideoLibEN.IsHaveVideo == "[null]" ? null :  objvVideoLibEN.IsHaveVideo; //IsHaveVideo
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
 /// <param name = "objvVideoLibEN">源简化对象</param>
 public static void AccessFldValueNull(clsvVideoLibEN objvVideoLibEN)
{
try
{
if (objvVideoLibEN.VideoLibTheme == "[null]") objvVideoLibEN.VideoLibTheme = null; //视频库主题词
if (objvVideoLibEN.VideoLibText == "[null]") objvVideoLibEN.VideoLibText = null; //案例文本内容
if (objvVideoLibEN.VideoLibDate == "[null]") objvVideoLibEN.VideoLibDate = null; //视频资源日期
if (objvVideoLibEN.VideoLibTime == "[null]") objvVideoLibEN.VideoLibTime = null; //视频资源时间
if (objvVideoLibEN.VideoLibDateIn == "[null]") objvVideoLibEN.VideoLibDateIn = null; //案例入库日期
if (objvVideoLibEN.VideoLibTimeIn == "[null]") objvVideoLibEN.VideoLibTimeIn = null; //案例入库时间
if (objvVideoLibEN.senateGaugeVersionName == "[null]") objvVideoLibEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvVideoLibEN.CaseLevelId == "[null]") objvVideoLibEN.CaseLevelId = null; //课例等级Id
if (objvVideoLibEN.CaseLevelName == "[null]") objvVideoLibEN.CaseLevelName = null; //案例等级名称
if (objvVideoLibEN.IdXzCollege == "[null]") objvVideoLibEN.IdXzCollege = null; //学院流水号
if (objvVideoLibEN.CollegeNameA == "[null]") objvVideoLibEN.CollegeNameA = null; //学院名称简写
if (objvVideoLibEN.CourseCode == "[null]") objvVideoLibEN.CourseCode = null; //课程代码
if (objvVideoLibEN.CourseName == "[null]") objvVideoLibEN.CourseName = null; //课程名称
if (objvVideoLibEN.VideoUrl == "[null]") objvVideoLibEN.VideoUrl = null; //视频Url
if (objvVideoLibEN.VideoPath == "[null]") objvVideoLibEN.VideoPath = null; //视频目录
if (objvVideoLibEN.CoverPicUrl == "[null]") objvVideoLibEN.CoverPicUrl = null; //封面Url
if (objvVideoLibEN.CoverPicShortUrl == "[null]") objvVideoLibEN.CoverPicShortUrl = null; //封面短Url
if (objvVideoLibEN.ResErrMsg == "[null]") objvVideoLibEN.ResErrMsg = null; //资源错误信息
if (objvVideoLibEN.UpdDate == "[null]") objvVideoLibEN.UpdDate = null; //修改日期
if (objvVideoLibEN.UpdUserId == "[null]") objvVideoLibEN.UpdUserId = null; //修改用户Id
if (objvVideoLibEN.Memo == "[null]") objvVideoLibEN.Memo = null; //备注
if (objvVideoLibEN.OwnerName == "[null]") objvVideoLibEN.OwnerName = null; //拥有者姓名
if (objvVideoLibEN.OwnerNameWithId == "[null]") objvVideoLibEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvVideoLibEN.IsHaveVideo == "[null]") objvVideoLibEN.IsHaveVideo = null; //IsHaveVideo
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
public static void CheckProperty4Condition(clsvVideoLibEN objvVideoLibEN)
{
 vVideoLibDA.CheckProperty4Condition(objvVideoLibEN);
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
//string strWhereCond = string.Format("1 = 1 order by IdVideoLib");
//if (arrvVideoLibObjLstCache == null)
//{
//arrvVideoLibObjLstCache = vVideoLibDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdVideoLib">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLibEN GetObjByIdVideoLibCache(string strIdVideoLib)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvVideoLibEN._CurrTabName);
List<clsvVideoLibEN> arrvVideoLibObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibEN> arrvVideoLibObjLst_Sel =
arrvVideoLibObjLstCache
.Where(x=> x.IdVideoLib == strIdVideoLib 
);
if (arrvVideoLibObjLst_Sel.Count() == 0)
{
   clsvVideoLibEN obj = clsvVideoLibBL.GetObjByIdVideoLib(strIdVideoLib);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvVideoLibObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLibEN> GetAllvVideoLibObjLstCache()
{
//获取缓存中的对象列表
List<clsvVideoLibEN> arrvVideoLibObjLstCache = GetObjLstCache(); 
return arrvVideoLibObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLibEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLibEN._CurrTabName);
List<clsvVideoLibEN> arrvVideoLibObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLibObjLstCache;
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
string strKey = string.Format("{0}", clsvVideoLibEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdVideoLib)
{
if (strInFldName != convVideoLib.IdVideoLib)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convVideoLib.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convVideoLib.AttributeName));
throw new Exception(strMsg);
}
var objvVideoLib = clsvVideoLibBL.GetObjByIdVideoLibCache(strIdVideoLib);
if (objvVideoLib == null) return "";
return objvVideoLib[strOutFldName].ToString();
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
int intRecCount = clsvVideoLibDA.GetRecCount(strTabName);
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
int intRecCount = clsvVideoLibDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvVideoLibDA.GetRecCount();
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
int intRecCount = clsvVideoLibDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvVideoLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvVideoLibEN objvVideoLibCond)
{
List<clsvVideoLibEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLib.AttributeName)
{
if (objvVideoLibCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibCond[strFldName].ToString());
}
else
{
if (objvVideoLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLibCond[strFldName]));
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
 List<string> arrList = clsvVideoLibDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vVideoLibDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vVideoLibDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}