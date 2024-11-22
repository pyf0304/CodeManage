
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLib_BaseBL
 表名:vVideoLib_Base(01120329)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:34
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
public static class  clsvVideoLib_BaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdVideoLib">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLib_BaseEN GetObj(this K_IdVideoLib_vVideoLib_Base myKey)
{
clsvVideoLib_BaseEN objvVideoLib_BaseEN = clsvVideoLib_BaseBL.vVideoLib_BaseDA.GetObjByIdVideoLib(myKey.Value);
return objvVideoLib_BaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetIdVideoLib(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strIdVideoLib, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdVideoLib, 8, convVideoLib_Base.IdVideoLib);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdVideoLib, 8, convVideoLib_Base.IdVideoLib);
}
objvVideoLib_BaseEN.IdVideoLib = strIdVideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.IdVideoLib) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.IdVideoLib, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.IdVideoLib] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibID(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibID, convVideoLib_Base.VideoLibID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLib_Base.VideoLibID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLib_Base.VideoLibID);
}
objvVideoLib_BaseEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibID) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibID, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibID] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibName, convVideoLib_Base.VideoLibName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLib_Base.VideoLibName);
}
objvVideoLib_BaseEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibTheme(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, convVideoLib_Base.VideoLibTheme);
}
objvVideoLib_BaseEN.VideoLibTheme = strVideoLibTheme; //视频库主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibTheme) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibTheme, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibTheme] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetIdVideoLibType(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strIdVideoLibType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdVideoLibType, convVideoLib_Base.IdVideoLibType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdVideoLibType, 4, convVideoLib_Base.IdVideoLibType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdVideoLibType, 4, convVideoLib_Base.IdVideoLibType);
}
objvVideoLib_BaseEN.IdVideoLibType = strIdVideoLibType; //视频库类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.IdVideoLibType) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.IdVideoLibType, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.IdVideoLibType] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibTypeName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTypeName, 30, convVideoLib_Base.VideoLibTypeName);
}
objvVideoLib_BaseEN.VideoLibTypeName = strVideoLibTypeName; //视频库类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibTypeName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibTypeName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibTypeName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibText(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibText, 8000, convVideoLib_Base.VideoLibText);
}
objvVideoLib_BaseEN.VideoLibText = strVideoLibText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibText) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibText, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibText] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibDate(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDate, 20, convVideoLib_Base.VideoLibDate);
}
objvVideoLib_BaseEN.VideoLibDate = strVideoLibDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibDate) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibDate, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibDate] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibTime(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, convVideoLib_Base.VideoLibTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, convVideoLib_Base.VideoLibTime);
}
objvVideoLib_BaseEN.VideoLibTime = strVideoLibTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibTime) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibTime, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibTime] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibDateIn(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, convVideoLib_Base.VideoLibDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, convVideoLib_Base.VideoLibDateIn);
}
objvVideoLib_BaseEN.VideoLibDateIn = strVideoLibDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibDateIn) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibDateIn, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibDateIn] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoLibTimeIn(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, convVideoLib_Base.VideoLibTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, convVideoLib_Base.VideoLibTimeIn);
}
objvVideoLib_BaseEN.VideoLibTimeIn = strVideoLibTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoLibTimeIn) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoLibTimeIn, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoLibTimeIn] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetOwnerId(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convVideoLib_Base.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoLib_Base.OwnerId);
}
objvVideoLib_BaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.OwnerId) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.OwnerId, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.OwnerId] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetIdTeachingPlan(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convVideoLib_Base.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convVideoLib_Base.IdTeachingPlan);
}
objvVideoLib_BaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.IdTeachingPlan) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.IdTeachingPlan, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.IdTeachingPlan] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetIdSenateGaugeVersion(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convVideoLib_Base.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convVideoLib_Base.IdSenateGaugeVersion);
}
objvVideoLib_BaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.IdSenateGaugeVersion) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetsenateGaugeVersionID(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoLib_Base.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoLib_Base.senateGaugeVersionID);
}
objvVideoLib_BaseEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.senateGaugeVersionID) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetsenateGaugeVersionName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoLib_Base.senateGaugeVersionName);
}
objvVideoLib_BaseEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.senateGaugeVersionName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetsenateGaugeVersionTtlScore(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.senateGaugeVersionTtlScore) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVersionNo(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, int? intVersionNo, string strComparisonOp="")
	{
objvVideoLib_BaseEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VersionNo) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VersionNo, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VersionNo] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCaseLevelId(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convVideoLib_Base.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convVideoLib_Base.CaseLevelId);
}
objvVideoLib_BaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CaseLevelId) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CaseLevelId, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CaseLevelId] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCaseLevelName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convVideoLib_Base.CaseLevelName);
}
objvVideoLib_BaseEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CaseLevelName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CaseLevelName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CaseLevelName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetIsVisible(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvVideoLib_BaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.IsVisible) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.IsVisible, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.IsVisible] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetIdXzCollege(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, convVideoLib_Base.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convVideoLib_Base.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convVideoLib_Base.IdXzCollege);
}
objvVideoLib_BaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.IdXzCollege) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.IdXzCollege, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.IdXzCollege] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCollegeID(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLib_Base.CollegeID);
}
objvVideoLib_BaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CollegeID) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CollegeID, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CollegeID] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCollegeName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLib_Base.CollegeName);
}
objvVideoLib_BaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CollegeName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CollegeName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CollegeName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCollegeNameA(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoLib_Base.CollegeNameA);
}
objvVideoLib_BaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CollegeNameA) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CollegeNameA, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CollegeNameA] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetViewCount(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, int? intViewCount, string strComparisonOp="")
	{
objvVideoLib_BaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.ViewCount) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.ViewCount, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.ViewCount] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetDownloadNumber(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvVideoLib_BaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.DownloadNumber) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.DownloadNumber, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.DownloadNumber] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetFileIntegration(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, int? intFileIntegration, string strComparisonOp="")
	{
objvVideoLib_BaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.FileIntegration) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.FileIntegration, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.FileIntegration] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetLikeCount(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, long? lngLikeCount, string strComparisonOp="")
	{
objvVideoLib_BaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.LikeCount) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.LikeCount, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.LikeCount] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCollectionCount(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvVideoLib_BaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CollectionCount) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CollectionCount, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CollectionCount] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetRecommendedDegreeId(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convVideoLib_Base.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convVideoLib_Base.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convVideoLib_Base.RecommendedDegreeId);
}
objvVideoLib_BaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.RecommendedDegreeId) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.RecommendedDegreeId, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.RecommendedDegreeId] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetRecommendedDegreeName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convVideoLib_Base.RecommendedDegreeName);
}
objvVideoLib_BaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.RecommendedDegreeName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.RecommendedDegreeName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.RecommendedDegreeName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCourseId(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convVideoLib_Base.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLib_Base.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLib_Base.CourseId);
}
objvVideoLib_BaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CourseId) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CourseId, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CourseId] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCourseCode(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLib_Base.CourseCode);
}
objvVideoLib_BaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CourseCode) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CourseCode, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CourseCode] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCourseName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLib_Base.CourseName);
}
objvVideoLib_BaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CourseName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CourseName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CourseName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoUrl(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convVideoLib_Base.VideoUrl);
}
objvVideoLib_BaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoUrl) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoUrl, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoUrl] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetVideoPath(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convVideoLib_Base.VideoPath);
}
objvVideoLib_BaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.VideoPath) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.VideoPath, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.VideoPath] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCoverPicUrl(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCoverPicUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCoverPicUrl, 1000, convVideoLib_Base.CoverPicUrl);
}
objvVideoLib_BaseEN.CoverPicUrl = strCoverPicUrl; //封面Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CoverPicUrl) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CoverPicUrl, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CoverPicUrl] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetCoverPicShortUrl(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strCoverPicShortUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCoverPicShortUrl, 1000, convVideoLib_Base.CoverPicShortUrl);
}
objvVideoLib_BaseEN.CoverPicShortUrl = strCoverPicShortUrl; //封面短Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.CoverPicShortUrl) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.CoverPicShortUrl, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.CoverPicShortUrl] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetResErrMsg(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convVideoLib_Base.ResErrMsg);
}
objvVideoLib_BaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.ResErrMsg) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.ResErrMsg, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.ResErrMsg] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetMemo(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoLib_Base.Memo);
}
objvVideoLib_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.Memo) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.Memo, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.Memo] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetBrowseCount4Case(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvVideoLib_BaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.BrowseCount4Case) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.BrowseCount4Case, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.BrowseCount4Case] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetOwnerName(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoLib_Base.OwnerName);
}
objvVideoLib_BaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.OwnerName) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.OwnerName, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.OwnerName] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_BaseEN SetOwnerNameWithId(this clsvVideoLib_BaseEN objvVideoLib_BaseEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoLib_Base.OwnerNameWithId);
}
objvVideoLib_BaseEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_BaseEN.dicFldComparisonOp.ContainsKey(convVideoLib_Base.OwnerNameWithId) == false)
{
objvVideoLib_BaseEN.dicFldComparisonOp.Add(convVideoLib_Base.OwnerNameWithId, strComparisonOp);
}
else
{
objvVideoLib_BaseEN.dicFldComparisonOp[convVideoLib_Base.OwnerNameWithId] = strComparisonOp;
}
}
return objvVideoLib_BaseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvVideoLib_BaseENS">源对象</param>
 /// <param name = "objvVideoLib_BaseENT">目标对象</param>
 public static void CopyTo(this clsvVideoLib_BaseEN objvVideoLib_BaseENS, clsvVideoLib_BaseEN objvVideoLib_BaseENT)
{
try
{
objvVideoLib_BaseENT.IdVideoLib = objvVideoLib_BaseENS.IdVideoLib; //视频库流水号
objvVideoLib_BaseENT.VideoLibID = objvVideoLib_BaseENS.VideoLibID; //视频库ID
objvVideoLib_BaseENT.VideoLibName = objvVideoLib_BaseENS.VideoLibName; //视频名称
objvVideoLib_BaseENT.VideoLibTheme = objvVideoLib_BaseENS.VideoLibTheme; //视频库主题词
objvVideoLib_BaseENT.IdVideoLibType = objvVideoLib_BaseENS.IdVideoLibType; //视频库类型流水号
objvVideoLib_BaseENT.VideoLibTypeName = objvVideoLib_BaseENS.VideoLibTypeName; //视频库类型名称
objvVideoLib_BaseENT.VideoLibText = objvVideoLib_BaseENS.VideoLibText; //案例文本内容
objvVideoLib_BaseENT.VideoLibDate = objvVideoLib_BaseENS.VideoLibDate; //视频资源日期
objvVideoLib_BaseENT.VideoLibTime = objvVideoLib_BaseENS.VideoLibTime; //视频资源时间
objvVideoLib_BaseENT.VideoLibDateIn = objvVideoLib_BaseENS.VideoLibDateIn; //案例入库日期
objvVideoLib_BaseENT.VideoLibTimeIn = objvVideoLib_BaseENS.VideoLibTimeIn; //案例入库时间
objvVideoLib_BaseENT.OwnerId = objvVideoLib_BaseENS.OwnerId; //拥有者Id
objvVideoLib_BaseENT.IdTeachingPlan = objvVideoLib_BaseENS.IdTeachingPlan; //教案流水号
objvVideoLib_BaseENT.IdSenateGaugeVersion = objvVideoLib_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoLib_BaseENT.senateGaugeVersionID = objvVideoLib_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLib_BaseENT.senateGaugeVersionName = objvVideoLib_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLib_BaseENT.senateGaugeVersionTtlScore = objvVideoLib_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLib_BaseENT.VersionNo = objvVideoLib_BaseENS.VersionNo; //版本号
objvVideoLib_BaseENT.CaseLevelId = objvVideoLib_BaseENS.CaseLevelId; //课例等级Id
objvVideoLib_BaseENT.CaseLevelName = objvVideoLib_BaseENS.CaseLevelName; //案例等级名称
objvVideoLib_BaseENT.IsVisible = objvVideoLib_BaseENS.IsVisible; //是否显示
objvVideoLib_BaseENT.IdXzCollege = objvVideoLib_BaseENS.IdXzCollege; //学院流水号
objvVideoLib_BaseENT.CollegeID = objvVideoLib_BaseENS.CollegeID; //学院ID
objvVideoLib_BaseENT.CollegeName = objvVideoLib_BaseENS.CollegeName; //学院名称
objvVideoLib_BaseENT.CollegeNameA = objvVideoLib_BaseENS.CollegeNameA; //学院名称简写
objvVideoLib_BaseENT.ViewCount = objvVideoLib_BaseENS.ViewCount; //浏览量
objvVideoLib_BaseENT.DownloadNumber = objvVideoLib_BaseENS.DownloadNumber; //下载数目
objvVideoLib_BaseENT.FileIntegration = objvVideoLib_BaseENS.FileIntegration; //文件积分
objvVideoLib_BaseENT.LikeCount = objvVideoLib_BaseENS.LikeCount; //资源喜欢数量
objvVideoLib_BaseENT.CollectionCount = objvVideoLib_BaseENS.CollectionCount; //收藏数量
objvVideoLib_BaseENT.RecommendedDegreeId = objvVideoLib_BaseENS.RecommendedDegreeId; //推荐度Id
objvVideoLib_BaseENT.RecommendedDegreeName = objvVideoLib_BaseENS.RecommendedDegreeName; //推荐度名称
objvVideoLib_BaseENT.CourseId = objvVideoLib_BaseENS.CourseId; //课程Id
objvVideoLib_BaseENT.CourseCode = objvVideoLib_BaseENS.CourseCode; //课程代码
objvVideoLib_BaseENT.CourseName = objvVideoLib_BaseENS.CourseName; //课程名称
objvVideoLib_BaseENT.VideoUrl = objvVideoLib_BaseENS.VideoUrl; //视频Url
objvVideoLib_BaseENT.VideoPath = objvVideoLib_BaseENS.VideoPath; //视频目录
objvVideoLib_BaseENT.CoverPicUrl = objvVideoLib_BaseENS.CoverPicUrl; //封面Url
objvVideoLib_BaseENT.CoverPicShortUrl = objvVideoLib_BaseENS.CoverPicShortUrl; //封面短Url
objvVideoLib_BaseENT.ResErrMsg = objvVideoLib_BaseENS.ResErrMsg; //资源错误信息
objvVideoLib_BaseENT.Memo = objvVideoLib_BaseENS.Memo; //备注
objvVideoLib_BaseENT.BrowseCount4Case = objvVideoLib_BaseENS.BrowseCount4Case; //课例浏览次数
objvVideoLib_BaseENT.OwnerName = objvVideoLib_BaseENS.OwnerName; //拥有者姓名
objvVideoLib_BaseENT.OwnerNameWithId = objvVideoLib_BaseENS.OwnerNameWithId; //拥有者名称附Id
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
 /// <param name = "objvVideoLib_BaseENS">源对象</param>
 /// <returns>目标对象=>clsvVideoLib_BaseEN:objvVideoLib_BaseENT</returns>
 public static clsvVideoLib_BaseEN CopyTo(this clsvVideoLib_BaseEN objvVideoLib_BaseENS)
{
try
{
 clsvVideoLib_BaseEN objvVideoLib_BaseENT = new clsvVideoLib_BaseEN()
{
IdVideoLib = objvVideoLib_BaseENS.IdVideoLib, //视频库流水号
VideoLibID = objvVideoLib_BaseENS.VideoLibID, //视频库ID
VideoLibName = objvVideoLib_BaseENS.VideoLibName, //视频名称
VideoLibTheme = objvVideoLib_BaseENS.VideoLibTheme, //视频库主题词
IdVideoLibType = objvVideoLib_BaseENS.IdVideoLibType, //视频库类型流水号
VideoLibTypeName = objvVideoLib_BaseENS.VideoLibTypeName, //视频库类型名称
VideoLibText = objvVideoLib_BaseENS.VideoLibText, //案例文本内容
VideoLibDate = objvVideoLib_BaseENS.VideoLibDate, //视频资源日期
VideoLibTime = objvVideoLib_BaseENS.VideoLibTime, //视频资源时间
VideoLibDateIn = objvVideoLib_BaseENS.VideoLibDateIn, //案例入库日期
VideoLibTimeIn = objvVideoLib_BaseENS.VideoLibTimeIn, //案例入库时间
OwnerId = objvVideoLib_BaseENS.OwnerId, //拥有者Id
IdTeachingPlan = objvVideoLib_BaseENS.IdTeachingPlan, //教案流水号
IdSenateGaugeVersion = objvVideoLib_BaseENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvVideoLib_BaseENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvVideoLib_BaseENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvVideoLib_BaseENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvVideoLib_BaseENS.VersionNo, //版本号
CaseLevelId = objvVideoLib_BaseENS.CaseLevelId, //课例等级Id
CaseLevelName = objvVideoLib_BaseENS.CaseLevelName, //案例等级名称
IsVisible = objvVideoLib_BaseENS.IsVisible, //是否显示
IdXzCollege = objvVideoLib_BaseENS.IdXzCollege, //学院流水号
CollegeID = objvVideoLib_BaseENS.CollegeID, //学院ID
CollegeName = objvVideoLib_BaseENS.CollegeName, //学院名称
CollegeNameA = objvVideoLib_BaseENS.CollegeNameA, //学院名称简写
ViewCount = objvVideoLib_BaseENS.ViewCount, //浏览量
DownloadNumber = objvVideoLib_BaseENS.DownloadNumber, //下载数目
FileIntegration = objvVideoLib_BaseENS.FileIntegration, //文件积分
LikeCount = objvVideoLib_BaseENS.LikeCount, //资源喜欢数量
CollectionCount = objvVideoLib_BaseENS.CollectionCount, //收藏数量
RecommendedDegreeId = objvVideoLib_BaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvVideoLib_BaseENS.RecommendedDegreeName, //推荐度名称
CourseId = objvVideoLib_BaseENS.CourseId, //课程Id
CourseCode = objvVideoLib_BaseENS.CourseCode, //课程代码
CourseName = objvVideoLib_BaseENS.CourseName, //课程名称
VideoUrl = objvVideoLib_BaseENS.VideoUrl, //视频Url
VideoPath = objvVideoLib_BaseENS.VideoPath, //视频目录
CoverPicUrl = objvVideoLib_BaseENS.CoverPicUrl, //封面Url
CoverPicShortUrl = objvVideoLib_BaseENS.CoverPicShortUrl, //封面短Url
ResErrMsg = objvVideoLib_BaseENS.ResErrMsg, //资源错误信息
Memo = objvVideoLib_BaseENS.Memo, //备注
BrowseCount4Case = objvVideoLib_BaseENS.BrowseCount4Case, //课例浏览次数
OwnerName = objvVideoLib_BaseENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvVideoLib_BaseENS.OwnerNameWithId, //拥有者名称附Id
};
 return objvVideoLib_BaseENT;
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
public static void CheckProperty4Condition(this clsvVideoLib_BaseEN objvVideoLib_BaseEN)
{
 clsvVideoLib_BaseBL.vVideoLib_BaseDA.CheckProperty4Condition(objvVideoLib_BaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLib_BaseEN objvVideoLib_BaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.IdVideoLib) == true)
{
string strComparisonOpIdVideoLib = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.IdVideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.IdVideoLib, objvVideoLib_BaseCond.IdVideoLib, strComparisonOpIdVideoLib);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VideoLibID) == true)
{
string strComparisonOpVideoLibID = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibID, objvVideoLib_BaseCond.VideoLibID, strComparisonOpVideoLibID);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VideoLibName) == true)
{
string strComparisonOpVideoLibName = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibName, objvVideoLib_BaseCond.VideoLibName, strComparisonOpVideoLibName);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VideoLibTheme) == true)
{
string strComparisonOpVideoLibTheme = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibTheme, objvVideoLib_BaseCond.VideoLibTheme, strComparisonOpVideoLibTheme);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.IdVideoLibType) == true)
{
string strComparisonOpIdVideoLibType = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.IdVideoLibType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.IdVideoLibType, objvVideoLib_BaseCond.IdVideoLibType, strComparisonOpIdVideoLibType);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VideoLibTypeName) == true)
{
string strComparisonOpVideoLibTypeName = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VideoLibTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibTypeName, objvVideoLib_BaseCond.VideoLibTypeName, strComparisonOpVideoLibTypeName);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VideoLibText) == true)
{
string strComparisonOpVideoLibText = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VideoLibText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibText, objvVideoLib_BaseCond.VideoLibText, strComparisonOpVideoLibText);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VideoLibDate) == true)
{
string strComparisonOpVideoLibDate = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibDate, objvVideoLib_BaseCond.VideoLibDate, strComparisonOpVideoLibDate);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VideoLibTime) == true)
{
string strComparisonOpVideoLibTime = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibTime, objvVideoLib_BaseCond.VideoLibTime, strComparisonOpVideoLibTime);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VideoLibDateIn) == true)
{
string strComparisonOpVideoLibDateIn = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibDateIn, objvVideoLib_BaseCond.VideoLibDateIn, strComparisonOpVideoLibDateIn);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VideoLibTimeIn) == true)
{
string strComparisonOpVideoLibTimeIn = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoLibTimeIn, objvVideoLib_BaseCond.VideoLibTimeIn, strComparisonOpVideoLibTimeIn);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.OwnerId) == true)
{
string strComparisonOpOwnerId = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.OwnerId, objvVideoLib_BaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.IdTeachingPlan, objvVideoLib_BaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.IdSenateGaugeVersion, objvVideoLib_BaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.senateGaugeVersionID, objvVideoLib_BaseCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.senateGaugeVersionName, objvVideoLib_BaseCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.senateGaugeVersionTtlScore, objvVideoLib_BaseCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VersionNo) == true)
{
string strComparisonOpVersionNo = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.VersionNo, objvVideoLib_BaseCond.VersionNo, strComparisonOpVersionNo);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CaseLevelId, objvVideoLib_BaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CaseLevelName, objvVideoLib_BaseCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.IsVisible) == true)
{
if (objvVideoLib_BaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib_Base.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib_Base.IsVisible);
}
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.IdXzCollege, objvVideoLib_BaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.CollegeID) == true)
{
string strComparisonOpCollegeID = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CollegeID, objvVideoLib_BaseCond.CollegeID, strComparisonOpCollegeID);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.CollegeName) == true)
{
string strComparisonOpCollegeName = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CollegeName, objvVideoLib_BaseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CollegeNameA, objvVideoLib_BaseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.ViewCount) == true)
{
string strComparisonOpViewCount = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.ViewCount, objvVideoLib_BaseCond.ViewCount, strComparisonOpViewCount);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.DownloadNumber, objvVideoLib_BaseCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.FileIntegration, objvVideoLib_BaseCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.LikeCount) == true)
{
string strComparisonOpLikeCount = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.LikeCount, objvVideoLib_BaseCond.LikeCount, strComparisonOpLikeCount);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.CollectionCount, objvVideoLib_BaseCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.RecommendedDegreeId, objvVideoLib_BaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.RecommendedDegreeName, objvVideoLib_BaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.CourseId) == true)
{
string strComparisonOpCourseId = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CourseId, objvVideoLib_BaseCond.CourseId, strComparisonOpCourseId);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.CourseCode) == true)
{
string strComparisonOpCourseCode = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CourseCode, objvVideoLib_BaseCond.CourseCode, strComparisonOpCourseCode);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.CourseName) == true)
{
string strComparisonOpCourseName = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CourseName, objvVideoLib_BaseCond.CourseName, strComparisonOpCourseName);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoUrl, objvVideoLib_BaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.VideoPath) == true)
{
string strComparisonOpVideoPath = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.VideoPath, objvVideoLib_BaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.CoverPicUrl) == true)
{
string strComparisonOpCoverPicUrl = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.CoverPicUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CoverPicUrl, objvVideoLib_BaseCond.CoverPicUrl, strComparisonOpCoverPicUrl);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.CoverPicShortUrl) == true)
{
string strComparisonOpCoverPicShortUrl = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.CoverPicShortUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.CoverPicShortUrl, objvVideoLib_BaseCond.CoverPicShortUrl, strComparisonOpCoverPicShortUrl);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.ResErrMsg, objvVideoLib_BaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.Memo) == true)
{
string strComparisonOpMemo = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.Memo, objvVideoLib_BaseCond.Memo, strComparisonOpMemo);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Base.BrowseCount4Case, objvVideoLib_BaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.OwnerName) == true)
{
string strComparisonOpOwnerName = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.OwnerName, objvVideoLib_BaseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvVideoLib_BaseCond.IsUpdated(convVideoLib_Base.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvVideoLib_BaseCond.dicFldComparisonOp[convVideoLib_Base.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Base.OwnerNameWithId, objvVideoLib_BaseCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vVideoLib_Base
{
public virtual bool UpdRelaTabDate(string strIdVideoLib, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v视频库_Base(vVideoLib_Base)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLib_BaseBL
{
public static RelatedActions_vVideoLib_Base relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvVideoLib_BaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvVideoLib_BaseDA vVideoLib_BaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvVideoLib_BaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvVideoLib_BaseBL()
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
if (string.IsNullOrEmpty(clsvVideoLib_BaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLib_BaseEN._ConnectString);
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
public static DataTable GetDataTable_vVideoLib_Base(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vVideoLib_BaseDA.GetDataTable_vVideoLib_Base(strWhereCond);
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
objDT = vVideoLib_BaseDA.GetDataTable(strWhereCond);
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
objDT = vVideoLib_BaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vVideoLib_BaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vVideoLib_BaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vVideoLib_BaseDA.GetDataTable_Top(objTopPara);
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
objDT = vVideoLib_BaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vVideoLib_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vVideoLib_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvVideoLib_BaseEN> GetObjLstByIdVideoLibLst(List<string> arrIdVideoLibLst)
{
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
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
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_BaseEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdVideoLibLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvVideoLib_BaseEN> GetObjLstByIdVideoLibLstCache(List<string> arrIdVideoLibLst)
{
string strKey = string.Format("{0}", clsvVideoLib_BaseEN._CurrTabName);
List<clsvVideoLib_BaseEN> arrvVideoLib_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLib_BaseEN> arrvVideoLib_BaseObjLst_Sel =
arrvVideoLib_BaseObjLstCache
.Where(x => arrIdVideoLibLst.Contains(x.IdVideoLib));
return arrvVideoLib_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLib_BaseEN> GetObjLst(string strWhereCond)
{
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_BaseEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_BaseEN);
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
public static List<clsvVideoLib_BaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_BaseEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvVideoLib_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvVideoLib_BaseEN> GetSubObjLstCache(clsvVideoLib_BaseEN objvVideoLib_BaseCond)
{
List<clsvVideoLib_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLib_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLib_Base.AttributeName)
{
if (objvVideoLib_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLib_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLib_BaseCond[strFldName].ToString());
}
else
{
if (objvVideoLib_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLib_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLib_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLib_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLib_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLib_BaseCond[strFldName]));
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
public static List<clsvVideoLib_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_BaseEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_BaseEN);
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
public static List<clsvVideoLib_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_BaseEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_BaseEN);
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
List<clsvVideoLib_BaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvVideoLib_BaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLib_BaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvVideoLib_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
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
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_BaseEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_BaseEN);
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
public static List<clsvVideoLib_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_BaseEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvVideoLib_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvVideoLib_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_BaseEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_BaseEN);
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
public static List<clsvVideoLib_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_BaseEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLib_BaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvVideoLib_BaseEN> arrObjLst = new List<clsvVideoLib_BaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_BaseEN objvVideoLib_BaseEN = new clsvVideoLib_BaseEN();
try
{
objvVideoLib_BaseEN.IdVideoLib = objRow[convVideoLib_Base.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLib_BaseEN.VideoLibID = objRow[convVideoLib_Base.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_BaseEN.VideoLibName = objRow[convVideoLib_Base.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_BaseEN.VideoLibTheme = objRow[convVideoLib_Base.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_BaseEN.IdVideoLibType = objRow[convVideoLib_Base.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_BaseEN.VideoLibTypeName = objRow[convVideoLib_Base.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_BaseEN.VideoLibText = objRow[convVideoLib_Base.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_BaseEN.VideoLibDate = objRow[convVideoLib_Base.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_BaseEN.VideoLibTime = objRow[convVideoLib_Base.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_BaseEN.VideoLibDateIn = objRow[convVideoLib_Base.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_BaseEN.VideoLibTimeIn = objRow[convVideoLib_Base.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_BaseEN.OwnerId = objRow[convVideoLib_Base.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_BaseEN.IdTeachingPlan = objRow[convVideoLib_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_BaseEN.IdSenateGaugeVersion = objRow[convVideoLib_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoLib_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoLib_BaseEN.senateGaugeVersionID = objRow[convVideoLib_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_BaseEN.senateGaugeVersionName = objRow[convVideoLib_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_BaseEN.VersionNo = objRow[convVideoLib_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.VersionNo].ToString().Trim()); //版本号
objvVideoLib_BaseEN.CaseLevelId = objRow[convVideoLib_Base.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_BaseEN.CaseLevelName = objRow[convVideoLib_Base.CaseLevelName] == DBNull.Value ? null : objRow[convVideoLib_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvVideoLib_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Base.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_BaseEN.IdXzCollege = objRow[convVideoLib_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_BaseEN.CollegeID = objRow[convVideoLib_Base.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_BaseEN.CollegeName = objRow[convVideoLib_Base.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_BaseEN.CollegeNameA = objRow[convVideoLib_Base.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_BaseEN.ViewCount = objRow[convVideoLib_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_BaseEN.DownloadNumber = objRow[convVideoLib_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_BaseEN.FileIntegration = objRow[convVideoLib_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_BaseEN.LikeCount = objRow[convVideoLib_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_BaseEN.CollectionCount = objRow[convVideoLib_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_BaseEN.RecommendedDegreeId = objRow[convVideoLib_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_BaseEN.RecommendedDegreeName = objRow[convVideoLib_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_BaseEN.CourseId = objRow[convVideoLib_Base.CourseId].ToString().Trim(); //课程Id
objvVideoLib_BaseEN.CourseCode = objRow[convVideoLib_Base.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_BaseEN.CourseName = objRow[convVideoLib_Base.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Base.CourseName].ToString().Trim(); //课程名称
objvVideoLib_BaseEN.VideoUrl = objRow[convVideoLib_Base.VideoUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoUrl].ToString().Trim(); //视频Url
objvVideoLib_BaseEN.VideoPath = objRow[convVideoLib_Base.VideoPath] == DBNull.Value ? null : objRow[convVideoLib_Base.VideoPath].ToString().Trim(); //视频目录
objvVideoLib_BaseEN.CoverPicUrl = objRow[convVideoLib_Base.CoverPicUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicUrl].ToString().Trim(); //封面Url
objvVideoLib_BaseEN.CoverPicShortUrl = objRow[convVideoLib_Base.CoverPicShortUrl] == DBNull.Value ? null : objRow[convVideoLib_Base.CoverPicShortUrl].ToString().Trim(); //封面短Url
objvVideoLib_BaseEN.ResErrMsg = objRow[convVideoLib_Base.ResErrMsg] == DBNull.Value ? null : objRow[convVideoLib_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvVideoLib_BaseEN.Memo = objRow[convVideoLib_Base.Memo] == DBNull.Value ? null : objRow[convVideoLib_Base.Memo].ToString().Trim(); //备注
objvVideoLib_BaseEN.BrowseCount4Case = objRow[convVideoLib_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_BaseEN.OwnerName = objRow[convVideoLib_Base.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_BaseEN.OwnerNameWithId = objRow[convVideoLib_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_BaseEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_BaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvVideoLib_BaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvVideoLib_Base(ref clsvVideoLib_BaseEN objvVideoLib_BaseEN)
{
bool bolResult = vVideoLib_BaseDA.GetvVideoLib_Base(ref objvVideoLib_BaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdVideoLib">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLib_BaseEN GetObjByIdVideoLib(string strIdVideoLib)
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
clsvVideoLib_BaseEN objvVideoLib_BaseEN = vVideoLib_BaseDA.GetObjByIdVideoLib(strIdVideoLib);
return objvVideoLib_BaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvVideoLib_BaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvVideoLib_BaseEN objvVideoLib_BaseEN = vVideoLib_BaseDA.GetFirstObj(strWhereCond);
 return objvVideoLib_BaseEN;
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
public static clsvVideoLib_BaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvVideoLib_BaseEN objvVideoLib_BaseEN = vVideoLib_BaseDA.GetObjByDataRow(objRow);
 return objvVideoLib_BaseEN;
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
public static clsvVideoLib_BaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvVideoLib_BaseEN objvVideoLib_BaseEN = vVideoLib_BaseDA.GetObjByDataRow(objRow);
 return objvVideoLib_BaseEN;
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
 /// <param name = "lstvVideoLib_BaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLib_BaseEN GetObjByIdVideoLibFromList(string strIdVideoLib, List<clsvVideoLib_BaseEN> lstvVideoLib_BaseObjLst)
{
foreach (clsvVideoLib_BaseEN objvVideoLib_BaseEN in lstvVideoLib_BaseObjLst)
{
if (objvVideoLib_BaseEN.IdVideoLib == strIdVideoLib)
{
return objvVideoLib_BaseEN;
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
 strIdVideoLib = new clsvVideoLib_BaseDA().GetFirstID(strWhereCond);
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
 arrList = vVideoLib_BaseDA.GetID(strWhereCond);
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
bool bolIsExist = vVideoLib_BaseDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vVideoLib_BaseDA.IsExist(strIdVideoLib);
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
 bolIsExist = clsvVideoLib_BaseDA.IsExistTable();
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
 bolIsExist = vVideoLib_BaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvVideoLib_BaseENS">源对象</param>
 /// <param name = "objvVideoLib_BaseENT">目标对象</param>
 public static void CopyTo(clsvVideoLib_BaseEN objvVideoLib_BaseENS, clsvVideoLib_BaseEN objvVideoLib_BaseENT)
{
try
{
objvVideoLib_BaseENT.IdVideoLib = objvVideoLib_BaseENS.IdVideoLib; //视频库流水号
objvVideoLib_BaseENT.VideoLibID = objvVideoLib_BaseENS.VideoLibID; //视频库ID
objvVideoLib_BaseENT.VideoLibName = objvVideoLib_BaseENS.VideoLibName; //视频名称
objvVideoLib_BaseENT.VideoLibTheme = objvVideoLib_BaseENS.VideoLibTheme; //视频库主题词
objvVideoLib_BaseENT.IdVideoLibType = objvVideoLib_BaseENS.IdVideoLibType; //视频库类型流水号
objvVideoLib_BaseENT.VideoLibTypeName = objvVideoLib_BaseENS.VideoLibTypeName; //视频库类型名称
objvVideoLib_BaseENT.VideoLibText = objvVideoLib_BaseENS.VideoLibText; //案例文本内容
objvVideoLib_BaseENT.VideoLibDate = objvVideoLib_BaseENS.VideoLibDate; //视频资源日期
objvVideoLib_BaseENT.VideoLibTime = objvVideoLib_BaseENS.VideoLibTime; //视频资源时间
objvVideoLib_BaseENT.VideoLibDateIn = objvVideoLib_BaseENS.VideoLibDateIn; //案例入库日期
objvVideoLib_BaseENT.VideoLibTimeIn = objvVideoLib_BaseENS.VideoLibTimeIn; //案例入库时间
objvVideoLib_BaseENT.OwnerId = objvVideoLib_BaseENS.OwnerId; //拥有者Id
objvVideoLib_BaseENT.IdTeachingPlan = objvVideoLib_BaseENS.IdTeachingPlan; //教案流水号
objvVideoLib_BaseENT.IdSenateGaugeVersion = objvVideoLib_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoLib_BaseENT.senateGaugeVersionID = objvVideoLib_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLib_BaseENT.senateGaugeVersionName = objvVideoLib_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLib_BaseENT.senateGaugeVersionTtlScore = objvVideoLib_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLib_BaseENT.VersionNo = objvVideoLib_BaseENS.VersionNo; //版本号
objvVideoLib_BaseENT.CaseLevelId = objvVideoLib_BaseENS.CaseLevelId; //课例等级Id
objvVideoLib_BaseENT.CaseLevelName = objvVideoLib_BaseENS.CaseLevelName; //案例等级名称
objvVideoLib_BaseENT.IsVisible = objvVideoLib_BaseENS.IsVisible; //是否显示
objvVideoLib_BaseENT.IdXzCollege = objvVideoLib_BaseENS.IdXzCollege; //学院流水号
objvVideoLib_BaseENT.CollegeID = objvVideoLib_BaseENS.CollegeID; //学院ID
objvVideoLib_BaseENT.CollegeName = objvVideoLib_BaseENS.CollegeName; //学院名称
objvVideoLib_BaseENT.CollegeNameA = objvVideoLib_BaseENS.CollegeNameA; //学院名称简写
objvVideoLib_BaseENT.ViewCount = objvVideoLib_BaseENS.ViewCount; //浏览量
objvVideoLib_BaseENT.DownloadNumber = objvVideoLib_BaseENS.DownloadNumber; //下载数目
objvVideoLib_BaseENT.FileIntegration = objvVideoLib_BaseENS.FileIntegration; //文件积分
objvVideoLib_BaseENT.LikeCount = objvVideoLib_BaseENS.LikeCount; //资源喜欢数量
objvVideoLib_BaseENT.CollectionCount = objvVideoLib_BaseENS.CollectionCount; //收藏数量
objvVideoLib_BaseENT.RecommendedDegreeId = objvVideoLib_BaseENS.RecommendedDegreeId; //推荐度Id
objvVideoLib_BaseENT.RecommendedDegreeName = objvVideoLib_BaseENS.RecommendedDegreeName; //推荐度名称
objvVideoLib_BaseENT.CourseId = objvVideoLib_BaseENS.CourseId; //课程Id
objvVideoLib_BaseENT.CourseCode = objvVideoLib_BaseENS.CourseCode; //课程代码
objvVideoLib_BaseENT.CourseName = objvVideoLib_BaseENS.CourseName; //课程名称
objvVideoLib_BaseENT.VideoUrl = objvVideoLib_BaseENS.VideoUrl; //视频Url
objvVideoLib_BaseENT.VideoPath = objvVideoLib_BaseENS.VideoPath; //视频目录
objvVideoLib_BaseENT.CoverPicUrl = objvVideoLib_BaseENS.CoverPicUrl; //封面Url
objvVideoLib_BaseENT.CoverPicShortUrl = objvVideoLib_BaseENS.CoverPicShortUrl; //封面短Url
objvVideoLib_BaseENT.ResErrMsg = objvVideoLib_BaseENS.ResErrMsg; //资源错误信息
objvVideoLib_BaseENT.Memo = objvVideoLib_BaseENS.Memo; //备注
objvVideoLib_BaseENT.BrowseCount4Case = objvVideoLib_BaseENS.BrowseCount4Case; //课例浏览次数
objvVideoLib_BaseENT.OwnerName = objvVideoLib_BaseENS.OwnerName; //拥有者姓名
objvVideoLib_BaseENT.OwnerNameWithId = objvVideoLib_BaseENS.OwnerNameWithId; //拥有者名称附Id
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
 /// <param name = "objvVideoLib_BaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvVideoLib_BaseEN objvVideoLib_BaseEN)
{
try
{
objvVideoLib_BaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvVideoLib_BaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convVideoLib_Base.IdVideoLib, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.IdVideoLib = objvVideoLib_BaseEN.IdVideoLib; //视频库流水号
}
if (arrFldSet.Contains(convVideoLib_Base.VideoLibID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VideoLibID = objvVideoLib_BaseEN.VideoLibID; //视频库ID
}
if (arrFldSet.Contains(convVideoLib_Base.VideoLibName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VideoLibName = objvVideoLib_BaseEN.VideoLibName; //视频名称
}
if (arrFldSet.Contains(convVideoLib_Base.VideoLibTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VideoLibTheme = objvVideoLib_BaseEN.VideoLibTheme == "[null]" ? null :  objvVideoLib_BaseEN.VideoLibTheme; //视频库主题词
}
if (arrFldSet.Contains(convVideoLib_Base.IdVideoLibType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.IdVideoLibType = objvVideoLib_BaseEN.IdVideoLibType; //视频库类型流水号
}
if (arrFldSet.Contains(convVideoLib_Base.VideoLibTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VideoLibTypeName = objvVideoLib_BaseEN.VideoLibTypeName == "[null]" ? null :  objvVideoLib_BaseEN.VideoLibTypeName; //视频库类型名称
}
if (arrFldSet.Contains(convVideoLib_Base.VideoLibText, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VideoLibText = objvVideoLib_BaseEN.VideoLibText == "[null]" ? null :  objvVideoLib_BaseEN.VideoLibText; //案例文本内容
}
if (arrFldSet.Contains(convVideoLib_Base.VideoLibDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VideoLibDate = objvVideoLib_BaseEN.VideoLibDate == "[null]" ? null :  objvVideoLib_BaseEN.VideoLibDate; //视频资源日期
}
if (arrFldSet.Contains(convVideoLib_Base.VideoLibTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VideoLibTime = objvVideoLib_BaseEN.VideoLibTime == "[null]" ? null :  objvVideoLib_BaseEN.VideoLibTime; //视频资源时间
}
if (arrFldSet.Contains(convVideoLib_Base.VideoLibDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VideoLibDateIn = objvVideoLib_BaseEN.VideoLibDateIn == "[null]" ? null :  objvVideoLib_BaseEN.VideoLibDateIn; //案例入库日期
}
if (arrFldSet.Contains(convVideoLib_Base.VideoLibTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VideoLibTimeIn = objvVideoLib_BaseEN.VideoLibTimeIn == "[null]" ? null :  objvVideoLib_BaseEN.VideoLibTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convVideoLib_Base.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.OwnerId = objvVideoLib_BaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convVideoLib_Base.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.IdTeachingPlan = objvVideoLib_BaseEN.IdTeachingPlan == "[null]" ? null :  objvVideoLib_BaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convVideoLib_Base.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.IdSenateGaugeVersion = objvVideoLib_BaseEN.IdSenateGaugeVersion == "[null]" ? null :  objvVideoLib_BaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convVideoLib_Base.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.senateGaugeVersionID = objvVideoLib_BaseEN.senateGaugeVersionID == "[null]" ? null :  objvVideoLib_BaseEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convVideoLib_Base.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.senateGaugeVersionName = objvVideoLib_BaseEN.senateGaugeVersionName == "[null]" ? null :  objvVideoLib_BaseEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convVideoLib_Base.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.senateGaugeVersionTtlScore = objvVideoLib_BaseEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convVideoLib_Base.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VersionNo = objvVideoLib_BaseEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convVideoLib_Base.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.CaseLevelId = objvVideoLib_BaseEN.CaseLevelId == "[null]" ? null :  objvVideoLib_BaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convVideoLib_Base.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.CaseLevelName = objvVideoLib_BaseEN.CaseLevelName == "[null]" ? null :  objvVideoLib_BaseEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convVideoLib_Base.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.IsVisible = objvVideoLib_BaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convVideoLib_Base.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.IdXzCollege = objvVideoLib_BaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convVideoLib_Base.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.CollegeID = objvVideoLib_BaseEN.CollegeID == "[null]" ? null :  objvVideoLib_BaseEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convVideoLib_Base.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.CollegeName = objvVideoLib_BaseEN.CollegeName == "[null]" ? null :  objvVideoLib_BaseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convVideoLib_Base.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.CollegeNameA = objvVideoLib_BaseEN.CollegeNameA == "[null]" ? null :  objvVideoLib_BaseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convVideoLib_Base.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.ViewCount = objvVideoLib_BaseEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convVideoLib_Base.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.DownloadNumber = objvVideoLib_BaseEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convVideoLib_Base.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.FileIntegration = objvVideoLib_BaseEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convVideoLib_Base.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.LikeCount = objvVideoLib_BaseEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convVideoLib_Base.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.CollectionCount = objvVideoLib_BaseEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convVideoLib_Base.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.RecommendedDegreeId = objvVideoLib_BaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convVideoLib_Base.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.RecommendedDegreeName = objvVideoLib_BaseEN.RecommendedDegreeName == "[null]" ? null :  objvVideoLib_BaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convVideoLib_Base.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.CourseId = objvVideoLib_BaseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convVideoLib_Base.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.CourseCode = objvVideoLib_BaseEN.CourseCode == "[null]" ? null :  objvVideoLib_BaseEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convVideoLib_Base.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.CourseName = objvVideoLib_BaseEN.CourseName == "[null]" ? null :  objvVideoLib_BaseEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convVideoLib_Base.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VideoUrl = objvVideoLib_BaseEN.VideoUrl == "[null]" ? null :  objvVideoLib_BaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convVideoLib_Base.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.VideoPath = objvVideoLib_BaseEN.VideoPath == "[null]" ? null :  objvVideoLib_BaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convVideoLib_Base.CoverPicUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.CoverPicUrl = objvVideoLib_BaseEN.CoverPicUrl == "[null]" ? null :  objvVideoLib_BaseEN.CoverPicUrl; //封面Url
}
if (arrFldSet.Contains(convVideoLib_Base.CoverPicShortUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.CoverPicShortUrl = objvVideoLib_BaseEN.CoverPicShortUrl == "[null]" ? null :  objvVideoLib_BaseEN.CoverPicShortUrl; //封面短Url
}
if (arrFldSet.Contains(convVideoLib_Base.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.ResErrMsg = objvVideoLib_BaseEN.ResErrMsg == "[null]" ? null :  objvVideoLib_BaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(convVideoLib_Base.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.Memo = objvVideoLib_BaseEN.Memo == "[null]" ? null :  objvVideoLib_BaseEN.Memo; //备注
}
if (arrFldSet.Contains(convVideoLib_Base.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.BrowseCount4Case = objvVideoLib_BaseEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convVideoLib_Base.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.OwnerName = objvVideoLib_BaseEN.OwnerName == "[null]" ? null :  objvVideoLib_BaseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convVideoLib_Base.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_BaseEN.OwnerNameWithId = objvVideoLib_BaseEN.OwnerNameWithId == "[null]" ? null :  objvVideoLib_BaseEN.OwnerNameWithId; //拥有者名称附Id
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
 /// <param name = "objvVideoLib_BaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvVideoLib_BaseEN objvVideoLib_BaseEN)
{
try
{
if (objvVideoLib_BaseEN.VideoLibTheme == "[null]") objvVideoLib_BaseEN.VideoLibTheme = null; //视频库主题词
if (objvVideoLib_BaseEN.VideoLibTypeName == "[null]") objvVideoLib_BaseEN.VideoLibTypeName = null; //视频库类型名称
if (objvVideoLib_BaseEN.VideoLibText == "[null]") objvVideoLib_BaseEN.VideoLibText = null; //案例文本内容
if (objvVideoLib_BaseEN.VideoLibDate == "[null]") objvVideoLib_BaseEN.VideoLibDate = null; //视频资源日期
if (objvVideoLib_BaseEN.VideoLibTime == "[null]") objvVideoLib_BaseEN.VideoLibTime = null; //视频资源时间
if (objvVideoLib_BaseEN.VideoLibDateIn == "[null]") objvVideoLib_BaseEN.VideoLibDateIn = null; //案例入库日期
if (objvVideoLib_BaseEN.VideoLibTimeIn == "[null]") objvVideoLib_BaseEN.VideoLibTimeIn = null; //案例入库时间
if (objvVideoLib_BaseEN.IdTeachingPlan == "[null]") objvVideoLib_BaseEN.IdTeachingPlan = null; //教案流水号
if (objvVideoLib_BaseEN.IdSenateGaugeVersion == "[null]") objvVideoLib_BaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvVideoLib_BaseEN.senateGaugeVersionID == "[null]") objvVideoLib_BaseEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvVideoLib_BaseEN.senateGaugeVersionName == "[null]") objvVideoLib_BaseEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvVideoLib_BaseEN.CaseLevelId == "[null]") objvVideoLib_BaseEN.CaseLevelId = null; //课例等级Id
if (objvVideoLib_BaseEN.CaseLevelName == "[null]") objvVideoLib_BaseEN.CaseLevelName = null; //案例等级名称
if (objvVideoLib_BaseEN.CollegeID == "[null]") objvVideoLib_BaseEN.CollegeID = null; //学院ID
if (objvVideoLib_BaseEN.CollegeName == "[null]") objvVideoLib_BaseEN.CollegeName = null; //学院名称
if (objvVideoLib_BaseEN.CollegeNameA == "[null]") objvVideoLib_BaseEN.CollegeNameA = null; //学院名称简写
if (objvVideoLib_BaseEN.RecommendedDegreeName == "[null]") objvVideoLib_BaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvVideoLib_BaseEN.CourseCode == "[null]") objvVideoLib_BaseEN.CourseCode = null; //课程代码
if (objvVideoLib_BaseEN.CourseName == "[null]") objvVideoLib_BaseEN.CourseName = null; //课程名称
if (objvVideoLib_BaseEN.VideoUrl == "[null]") objvVideoLib_BaseEN.VideoUrl = null; //视频Url
if (objvVideoLib_BaseEN.VideoPath == "[null]") objvVideoLib_BaseEN.VideoPath = null; //视频目录
if (objvVideoLib_BaseEN.CoverPicUrl == "[null]") objvVideoLib_BaseEN.CoverPicUrl = null; //封面Url
if (objvVideoLib_BaseEN.CoverPicShortUrl == "[null]") objvVideoLib_BaseEN.CoverPicShortUrl = null; //封面短Url
if (objvVideoLib_BaseEN.ResErrMsg == "[null]") objvVideoLib_BaseEN.ResErrMsg = null; //资源错误信息
if (objvVideoLib_BaseEN.Memo == "[null]") objvVideoLib_BaseEN.Memo = null; //备注
if (objvVideoLib_BaseEN.OwnerName == "[null]") objvVideoLib_BaseEN.OwnerName = null; //拥有者姓名
if (objvVideoLib_BaseEN.OwnerNameWithId == "[null]") objvVideoLib_BaseEN.OwnerNameWithId = null; //拥有者名称附Id
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
public static void CheckProperty4Condition(clsvVideoLib_BaseEN objvVideoLib_BaseEN)
{
 vVideoLib_BaseDA.CheckProperty4Condition(objvVideoLib_BaseEN);
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
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdVideoLib");
//if (arrvVideoLib_BaseObjLstCache == null)
//{
//arrvVideoLib_BaseObjLstCache = vVideoLib_BaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdVideoLib">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLib_BaseEN GetObjByIdVideoLibCache(string strIdVideoLib)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvVideoLib_BaseEN._CurrTabName);
List<clsvVideoLib_BaseEN> arrvVideoLib_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLib_BaseEN> arrvVideoLib_BaseObjLst_Sel =
arrvVideoLib_BaseObjLstCache
.Where(x=> x.IdVideoLib == strIdVideoLib 
);
if (arrvVideoLib_BaseObjLst_Sel.Count() == 0)
{
   clsvVideoLib_BaseEN obj = clsvVideoLib_BaseBL.GetObjByIdVideoLib(strIdVideoLib);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvVideoLib_BaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLib_BaseEN> GetAllvVideoLib_BaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvVideoLib_BaseEN> arrvVideoLib_BaseObjLstCache = GetObjLstCache(); 
return arrvVideoLib_BaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLib_BaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLib_BaseEN._CurrTabName);
List<clsvVideoLib_BaseEN> arrvVideoLib_BaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLib_BaseObjLstCache;
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
string strKey = string.Format("{0}", clsvVideoLib_BaseEN._CurrTabName);
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
if (strInFldName != convVideoLib_Base.IdVideoLib)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convVideoLib_Base.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convVideoLib_Base.AttributeName));
throw new Exception(strMsg);
}
var objvVideoLib_Base = clsvVideoLib_BaseBL.GetObjByIdVideoLibCache(strIdVideoLib);
if (objvVideoLib_Base == null) return "";
return objvVideoLib_Base[strOutFldName].ToString();
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
int intRecCount = clsvVideoLib_BaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvVideoLib_BaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvVideoLib_BaseDA.GetRecCount();
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
int intRecCount = clsvVideoLib_BaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvVideoLib_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvVideoLib_BaseEN objvVideoLib_BaseCond)
{
List<clsvVideoLib_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLib_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLib_Base.AttributeName)
{
if (objvVideoLib_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLib_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLib_BaseCond[strFldName].ToString());
}
else
{
if (objvVideoLib_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLib_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLib_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLib_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLib_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLib_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLib_BaseCond[strFldName]));
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
 List<string> arrList = clsvVideoLib_BaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vVideoLib_BaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vVideoLib_BaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}