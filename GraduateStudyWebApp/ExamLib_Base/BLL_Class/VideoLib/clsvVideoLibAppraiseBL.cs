
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibAppraiseBL
 表名:vVideoLibAppraise(01120266)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:39
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
public static class  clsvVideoLibAppraiseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibAppraiseEN GetObj(this K_IdMicroteachAppraise_vVideoLibAppraise myKey)
{
clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = clsvVideoLibAppraiseBL.vVideoLibAppraiseDA.GetObjByIdMicroteachAppraise(myKey.Value);
return objvVideoLibAppraiseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetIdMicroteachAppraise(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, long lngIdMicroteachAppraise, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.IdMicroteachAppraise = lngIdMicroteachAppraise; //评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.IdMicroteachAppraise) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.IdMicroteachAppraise, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.IdMicroteachAppraise] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetFuncModuleId(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoLibAppraise.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoLibAppraise.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoLibAppraise.FuncModuleId);
}
objvVideoLibAppraiseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.FuncModuleId) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.FuncModuleId, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.FuncModuleId] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetFuncModuleName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoLibAppraise.FuncModuleName);
}
objvVideoLibAppraiseEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.FuncModuleName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.FuncModuleName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.FuncModuleName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetIdMicroteachCase(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convVideoLibAppraise.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convVideoLibAppraise.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convVideoLibAppraise.IdMicroteachCase);
}
objvVideoLibAppraiseEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.IdMicroteachCase) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.IdMicroteachCase, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.IdMicroteachCase] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetIdVideoLib(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strIdVideoLib, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdVideoLib, 8, convVideoLibAppraise.IdVideoLib);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdVideoLib, 8, convVideoLibAppraise.IdVideoLib);
}
objvVideoLibAppraiseEN.IdVideoLib = strIdVideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.IdVideoLib) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.IdVideoLib, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.IdVideoLib] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibID(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLibAppraise.VideoLibID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLibAppraise.VideoLibID);
}
objvVideoLibAppraiseEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibID) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibID, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibID] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLibAppraise.VideoLibName);
}
objvVideoLibAppraiseEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibTheme(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, convVideoLibAppraise.VideoLibTheme);
}
objvVideoLibAppraiseEN.VideoLibTheme = strVideoLibTheme; //视频库主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibTheme) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibTheme, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibTheme] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibTypeName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTypeName, 30, convVideoLibAppraise.VideoLibTypeName);
}
objvVideoLibAppraiseEN.VideoLibTypeName = strVideoLibTypeName; //视频库类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibTypeName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibTypeName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibTypeName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibDate(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDate, 20, convVideoLibAppraise.VideoLibDate);
}
objvVideoLibAppraiseEN.VideoLibDate = strVideoLibDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibDate) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibDate, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibDate] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibTime(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, convVideoLibAppraise.VideoLibTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, convVideoLibAppraise.VideoLibTime);
}
objvVideoLibAppraiseEN.VideoLibTime = strVideoLibTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibTime) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibTime, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibTime] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibDateIn(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, convVideoLibAppraise.VideoLibDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, convVideoLibAppraise.VideoLibDateIn);
}
objvVideoLibAppraiseEN.VideoLibDateIn = strVideoLibDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibDateIn) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibDateIn, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibDateIn] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibTimeIn(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, convVideoLibAppraise.VideoLibTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, convVideoLibAppraise.VideoLibTimeIn);
}
objvVideoLibAppraiseEN.VideoLibTimeIn = strVideoLibTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibTimeIn) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibTimeIn, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibTimeIn] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetIdXzCollege(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convVideoLibAppraise.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convVideoLibAppraise.IdXzCollege);
}
objvVideoLibAppraiseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.IdXzCollege) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.IdXzCollege, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.IdXzCollege] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetCollegeID(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLibAppraise.CollegeID);
}
objvVideoLibAppraiseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.CollegeID) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.CollegeID, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.CollegeID] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetCollegeName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLibAppraise.CollegeName);
}
objvVideoLibAppraiseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.CollegeName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.CollegeName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.CollegeName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetCourseId(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLibAppraise.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLibAppraise.CourseId);
}
objvVideoLibAppraiseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.CourseId) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.CourseId, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.CourseId] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetCourseCode(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLibAppraise.CourseCode);
}
objvVideoLibAppraiseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.CourseCode) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.CourseCode, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.CourseCode] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetCourseName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLibAppraise.CourseName);
}
objvVideoLibAppraiseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.CourseName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.CourseName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.CourseName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetBrowseCount4Case(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.BrowseCount4Case) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.BrowseCount4Case, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.BrowseCount4Case] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetIdAppraiseType(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strIdAppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAppraiseType, convVideoLibAppraise.IdAppraiseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convVideoLibAppraise.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convVideoLibAppraise.IdAppraiseType);
}
objvVideoLibAppraiseEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.IdAppraiseType) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.IdAppraiseType, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.IdAppraiseType] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetAppraiseTypeName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strAppraiseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convVideoLibAppraise.AppraiseTypeName);
}
objvVideoLibAppraiseEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.AppraiseTypeName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.AppraiseTypeName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.AppraiseTypeName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetAppraiseTheme(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strAppraiseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, convVideoLibAppraise.AppraiseTheme);
}
objvVideoLibAppraiseEN.AppraiseTheme = strAppraiseTheme; //评议主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.AppraiseTheme) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.AppraiseTheme, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.AppraiseTheme] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetAppraiseContent(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convVideoLibAppraise.AppraiseContent);
}
objvVideoLibAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.AppraiseContent) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.AppraiseContent, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.AppraiseContent] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetAppraiseDate(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strAppraiseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseDate, 8, convVideoLibAppraise.AppraiseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseDate, 8, convVideoLibAppraise.AppraiseDate);
}
objvVideoLibAppraiseEN.AppraiseDate = strAppraiseDate; //评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.AppraiseDate) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.AppraiseDate, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.AppraiseDate] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetAppraiseTime(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strAppraiseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTime, 6, convVideoLibAppraise.AppraiseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseTime, 6, convVideoLibAppraise.AppraiseTime);
}
objvVideoLibAppraiseEN.AppraiseTime = strAppraiseTime; //评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.AppraiseTime) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.AppraiseTime, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.AppraiseTime] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetIsVisual(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, bool bolIsVisual, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.IsVisual = bolIsVisual; //隐藏标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.IsVisual) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.IsVisual, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.IsVisual] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetIsElite(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, bool bolIsElite, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.IsElite = bolIsElite; //精华标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.IsElite) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.IsElite, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.IsElite] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetExcellentOne(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strExcellentOne, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentOne, 1000, convVideoLibAppraise.ExcellentOne);
}
objvVideoLibAppraiseEN.ExcellentOne = strExcellentOne; //优点1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.ExcellentOne) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.ExcellentOne, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.ExcellentOne] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetExcellentTwo(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strExcellentTwo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTwo, 1000, convVideoLibAppraise.ExcellentTwo);
}
objvVideoLibAppraiseEN.ExcellentTwo = strExcellentTwo; //优点2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.ExcellentTwo) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.ExcellentTwo, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.ExcellentTwo] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetSuggestOne(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strSuggestOne, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSuggestOne, 1000, convVideoLibAppraise.SuggestOne);
}
objvVideoLibAppraiseEN.SuggestOne = strSuggestOne; //建议1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.SuggestOne) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.SuggestOne, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.SuggestOne] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetSuggestTwo(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strSuggestTwo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSuggestTwo, 1000, convVideoLibAppraise.SuggestTwo);
}
objvVideoLibAppraiseEN.SuggestTwo = strSuggestTwo; //建议2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.SuggestTwo) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.SuggestTwo, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.SuggestTwo] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetMicroteachAppriseScore(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, float? fltMicroteachAppriseScore, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.MicroteachAppriseScore = fltMicroteachAppriseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.MicroteachAppriseScore) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.MicroteachAppriseScore, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.MicroteachAppriseScore] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoStopTime(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoStopTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, convVideoLibAppraise.VideoStopTime);
}
objvVideoLibAppraiseEN.VideoStopTime = strVideoStopTime; //公开课案例视频暂停时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoStopTime) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoStopTime, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoStopTime] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetBrowseCount(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, int? intBrowseCount, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.BrowseCount) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.BrowseCount, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.BrowseCount] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetUserId(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convVideoLibAppraise.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convVideoLibAppraise.UserId);
}
objvVideoLibAppraiseEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.UserId) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.UserId, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.UserId] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetUserName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convVideoLibAppraise.UserName);
}
objvVideoLibAppraiseEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.UserName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.UserName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.UserName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetUserNameWithUserId(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strUserNameWithUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convVideoLibAppraise.UserNameWithUserId);
}
objvVideoLibAppraiseEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.UserNameWithUserId) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.UserNameWithUserId, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.UserNameWithUserId] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseENS">源对象</param>
 /// <param name = "objvVideoLibAppraiseENT">目标对象</param>
 public static void CopyTo(this clsvVideoLibAppraiseEN objvVideoLibAppraiseENS, clsvVideoLibAppraiseEN objvVideoLibAppraiseENT)
{
try
{
objvVideoLibAppraiseENT.IdMicroteachAppraise = objvVideoLibAppraiseENS.IdMicroteachAppraise; //评议流水号
objvVideoLibAppraiseENT.FuncModuleId = objvVideoLibAppraiseENS.FuncModuleId; //功能模块Id
objvVideoLibAppraiseENT.FuncModuleName = objvVideoLibAppraiseENS.FuncModuleName; //功能模块名称
objvVideoLibAppraiseENT.IdMicroteachCase = objvVideoLibAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibAppraiseENT.IdVideoLib = objvVideoLibAppraiseENS.IdVideoLib; //视频库流水号
objvVideoLibAppraiseENT.VideoLibID = objvVideoLibAppraiseENS.VideoLibID; //视频库ID
objvVideoLibAppraiseENT.VideoLibName = objvVideoLibAppraiseENS.VideoLibName; //视频名称
objvVideoLibAppraiseENT.VideoLibTheme = objvVideoLibAppraiseENS.VideoLibTheme; //视频库主题词
objvVideoLibAppraiseENT.VideoLibTypeName = objvVideoLibAppraiseENS.VideoLibTypeName; //视频库类型名称
objvVideoLibAppraiseENT.VideoLibDate = objvVideoLibAppraiseENS.VideoLibDate; //视频资源日期
objvVideoLibAppraiseENT.VideoLibTime = objvVideoLibAppraiseENS.VideoLibTime; //视频资源时间
objvVideoLibAppraiseENT.VideoLibDateIn = objvVideoLibAppraiseENS.VideoLibDateIn; //案例入库日期
objvVideoLibAppraiseENT.VideoLibTimeIn = objvVideoLibAppraiseENS.VideoLibTimeIn; //案例入库时间
objvVideoLibAppraiseENT.IdXzCollege = objvVideoLibAppraiseENS.IdXzCollege; //学院流水号
objvVideoLibAppraiseENT.CollegeID = objvVideoLibAppraiseENS.CollegeID; //学院ID
objvVideoLibAppraiseENT.CollegeName = objvVideoLibAppraiseENS.CollegeName; //学院名称
objvVideoLibAppraiseENT.CourseId = objvVideoLibAppraiseENS.CourseId; //课程Id
objvVideoLibAppraiseENT.CourseCode = objvVideoLibAppraiseENS.CourseCode; //课程代码
objvVideoLibAppraiseENT.CourseName = objvVideoLibAppraiseENS.CourseName; //课程名称
objvVideoLibAppraiseENT.BrowseCount4Case = objvVideoLibAppraiseENS.BrowseCount4Case; //课例浏览次数
objvVideoLibAppraiseENT.IdAppraiseType = objvVideoLibAppraiseENS.IdAppraiseType; //评议类型流水号
objvVideoLibAppraiseENT.AppraiseTypeName = objvVideoLibAppraiseENS.AppraiseTypeName; //评议类型名称
objvVideoLibAppraiseENT.AppraiseTheme = objvVideoLibAppraiseENS.AppraiseTheme; //评议主题
objvVideoLibAppraiseENT.AppraiseContent = objvVideoLibAppraiseENS.AppraiseContent; //评议内容
objvVideoLibAppraiseENT.AppraiseDate = objvVideoLibAppraiseENS.AppraiseDate; //评议日期
objvVideoLibAppraiseENT.AppraiseTime = objvVideoLibAppraiseENS.AppraiseTime; //评议时间
objvVideoLibAppraiseENT.IsVisual = objvVideoLibAppraiseENS.IsVisual; //隐藏标志
objvVideoLibAppraiseENT.IsElite = objvVideoLibAppraiseENS.IsElite; //精华标志
objvVideoLibAppraiseENT.ExcellentOne = objvVideoLibAppraiseENS.ExcellentOne; //优点1
objvVideoLibAppraiseENT.ExcellentTwo = objvVideoLibAppraiseENS.ExcellentTwo; //优点2
objvVideoLibAppraiseENT.SuggestOne = objvVideoLibAppraiseENS.SuggestOne; //建议1
objvVideoLibAppraiseENT.SuggestTwo = objvVideoLibAppraiseENS.SuggestTwo; //建议2
objvVideoLibAppraiseENT.MicroteachAppriseScore = objvVideoLibAppraiseENS.MicroteachAppriseScore; //打分
objvVideoLibAppraiseENT.VideoStopTime = objvVideoLibAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objvVideoLibAppraiseENT.BrowseCount = objvVideoLibAppraiseENS.BrowseCount; //浏览次数
objvVideoLibAppraiseENT.UserId = objvVideoLibAppraiseENS.UserId; //用户ID
objvVideoLibAppraiseENT.UserName = objvVideoLibAppraiseENS.UserName; //用户名
objvVideoLibAppraiseENT.UserNameWithUserId = objvVideoLibAppraiseENS.UserNameWithUserId; //UserNameWithUserId
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
 /// <param name = "objvVideoLibAppraiseENS">源对象</param>
 /// <returns>目标对象=>clsvVideoLibAppraiseEN:objvVideoLibAppraiseENT</returns>
 public static clsvVideoLibAppraiseEN CopyTo(this clsvVideoLibAppraiseEN objvVideoLibAppraiseENS)
{
try
{
 clsvVideoLibAppraiseEN objvVideoLibAppraiseENT = new clsvVideoLibAppraiseEN()
{
IdMicroteachAppraise = objvVideoLibAppraiseENS.IdMicroteachAppraise, //评议流水号
FuncModuleId = objvVideoLibAppraiseENS.FuncModuleId, //功能模块Id
FuncModuleName = objvVideoLibAppraiseENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvVideoLibAppraiseENS.IdMicroteachCase, //微格教学案例流水号
IdVideoLib = objvVideoLibAppraiseENS.IdVideoLib, //视频库流水号
VideoLibID = objvVideoLibAppraiseENS.VideoLibID, //视频库ID
VideoLibName = objvVideoLibAppraiseENS.VideoLibName, //视频名称
VideoLibTheme = objvVideoLibAppraiseENS.VideoLibTheme, //视频库主题词
VideoLibTypeName = objvVideoLibAppraiseENS.VideoLibTypeName, //视频库类型名称
VideoLibDate = objvVideoLibAppraiseENS.VideoLibDate, //视频资源日期
VideoLibTime = objvVideoLibAppraiseENS.VideoLibTime, //视频资源时间
VideoLibDateIn = objvVideoLibAppraiseENS.VideoLibDateIn, //案例入库日期
VideoLibTimeIn = objvVideoLibAppraiseENS.VideoLibTimeIn, //案例入库时间
IdXzCollege = objvVideoLibAppraiseENS.IdXzCollege, //学院流水号
CollegeID = objvVideoLibAppraiseENS.CollegeID, //学院ID
CollegeName = objvVideoLibAppraiseENS.CollegeName, //学院名称
CourseId = objvVideoLibAppraiseENS.CourseId, //课程Id
CourseCode = objvVideoLibAppraiseENS.CourseCode, //课程代码
CourseName = objvVideoLibAppraiseENS.CourseName, //课程名称
BrowseCount4Case = objvVideoLibAppraiseENS.BrowseCount4Case, //课例浏览次数
IdAppraiseType = objvVideoLibAppraiseENS.IdAppraiseType, //评议类型流水号
AppraiseTypeName = objvVideoLibAppraiseENS.AppraiseTypeName, //评议类型名称
AppraiseTheme = objvVideoLibAppraiseENS.AppraiseTheme, //评议主题
AppraiseContent = objvVideoLibAppraiseENS.AppraiseContent, //评议内容
AppraiseDate = objvVideoLibAppraiseENS.AppraiseDate, //评议日期
AppraiseTime = objvVideoLibAppraiseENS.AppraiseTime, //评议时间
IsVisual = objvVideoLibAppraiseENS.IsVisual, //隐藏标志
IsElite = objvVideoLibAppraiseENS.IsElite, //精华标志
ExcellentOne = objvVideoLibAppraiseENS.ExcellentOne, //优点1
ExcellentTwo = objvVideoLibAppraiseENS.ExcellentTwo, //优点2
SuggestOne = objvVideoLibAppraiseENS.SuggestOne, //建议1
SuggestTwo = objvVideoLibAppraiseENS.SuggestTwo, //建议2
MicroteachAppriseScore = objvVideoLibAppraiseENS.MicroteachAppriseScore, //打分
VideoStopTime = objvVideoLibAppraiseENS.VideoStopTime, //公开课案例视频暂停时间
BrowseCount = objvVideoLibAppraiseENS.BrowseCount, //浏览次数
UserId = objvVideoLibAppraiseENS.UserId, //用户ID
UserName = objvVideoLibAppraiseENS.UserName, //用户名
UserNameWithUserId = objvVideoLibAppraiseENS.UserNameWithUserId, //UserNameWithUserId
};
 return objvVideoLibAppraiseENT;
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
public static void CheckProperty4Condition(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN)
{
 clsvVideoLibAppraiseBL.vVideoLibAppraiseDA.CheckProperty4Condition(objvVideoLibAppraiseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLibAppraiseEN objvVideoLibAppraiseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.IdMicroteachAppraise) == true)
{
string strComparisonOpIdMicroteachAppraise = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.IdMicroteachAppraise];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibAppraise.IdMicroteachAppraise, objvVideoLibAppraiseCond.IdMicroteachAppraise, strComparisonOpIdMicroteachAppraise);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.FuncModuleId, objvVideoLibAppraiseCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.FuncModuleName, objvVideoLibAppraiseCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.IdMicroteachCase, objvVideoLibAppraiseCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.IdVideoLib) == true)
{
string strComparisonOpIdVideoLib = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.IdVideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.IdVideoLib, objvVideoLibAppraiseCond.IdVideoLib, strComparisonOpIdVideoLib);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.VideoLibID) == true)
{
string strComparisonOpVideoLibID = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibID, objvVideoLibAppraiseCond.VideoLibID, strComparisonOpVideoLibID);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.VideoLibName) == true)
{
string strComparisonOpVideoLibName = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibName, objvVideoLibAppraiseCond.VideoLibName, strComparisonOpVideoLibName);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.VideoLibTheme) == true)
{
string strComparisonOpVideoLibTheme = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibTheme, objvVideoLibAppraiseCond.VideoLibTheme, strComparisonOpVideoLibTheme);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.VideoLibTypeName) == true)
{
string strComparisonOpVideoLibTypeName = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.VideoLibTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibTypeName, objvVideoLibAppraiseCond.VideoLibTypeName, strComparisonOpVideoLibTypeName);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.VideoLibDate) == true)
{
string strComparisonOpVideoLibDate = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibDate, objvVideoLibAppraiseCond.VideoLibDate, strComparisonOpVideoLibDate);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.VideoLibTime) == true)
{
string strComparisonOpVideoLibTime = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibTime, objvVideoLibAppraiseCond.VideoLibTime, strComparisonOpVideoLibTime);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.VideoLibDateIn) == true)
{
string strComparisonOpVideoLibDateIn = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibDateIn, objvVideoLibAppraiseCond.VideoLibDateIn, strComparisonOpVideoLibDateIn);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.VideoLibTimeIn) == true)
{
string strComparisonOpVideoLibTimeIn = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibTimeIn, objvVideoLibAppraiseCond.VideoLibTimeIn, strComparisonOpVideoLibTimeIn);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.IdXzCollege, objvVideoLibAppraiseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.CollegeID) == true)
{
string strComparisonOpCollegeID = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.CollegeID, objvVideoLibAppraiseCond.CollegeID, strComparisonOpCollegeID);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.CollegeName) == true)
{
string strComparisonOpCollegeName = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.CollegeName, objvVideoLibAppraiseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.CourseId) == true)
{
string strComparisonOpCourseId = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.CourseId, objvVideoLibAppraiseCond.CourseId, strComparisonOpCourseId);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.CourseCode) == true)
{
string strComparisonOpCourseCode = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.CourseCode, objvVideoLibAppraiseCond.CourseCode, strComparisonOpCourseCode);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.CourseName) == true)
{
string strComparisonOpCourseName = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.CourseName, objvVideoLibAppraiseCond.CourseName, strComparisonOpCourseName);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibAppraise.BrowseCount4Case, objvVideoLibAppraiseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.IdAppraiseType, objvVideoLibAppraiseCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.AppraiseTypeName, objvVideoLibAppraiseCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.AppraiseTheme) == true)
{
string strComparisonOpAppraiseTheme = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.AppraiseTheme, objvVideoLibAppraiseCond.AppraiseTheme, strComparisonOpAppraiseTheme);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.AppraiseContent) == true)
{
string strComparisonOpAppraiseContent = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.AppraiseContent, objvVideoLibAppraiseCond.AppraiseContent, strComparisonOpAppraiseContent);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.AppraiseDate) == true)
{
string strComparisonOpAppraiseDate = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.AppraiseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.AppraiseDate, objvVideoLibAppraiseCond.AppraiseDate, strComparisonOpAppraiseDate);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.AppraiseTime) == true)
{
string strComparisonOpAppraiseTime = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.AppraiseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.AppraiseTime, objvVideoLibAppraiseCond.AppraiseTime, strComparisonOpAppraiseTime);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.IsVisual) == true)
{
if (objvVideoLibAppraiseCond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLibAppraise.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLibAppraise.IsVisual);
}
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.IsElite) == true)
{
if (objvVideoLibAppraiseCond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLibAppraise.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLibAppraise.IsElite);
}
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.ExcellentOne) == true)
{
string strComparisonOpExcellentOne = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.ExcellentOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.ExcellentOne, objvVideoLibAppraiseCond.ExcellentOne, strComparisonOpExcellentOne);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.ExcellentTwo) == true)
{
string strComparisonOpExcellentTwo = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.ExcellentTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.ExcellentTwo, objvVideoLibAppraiseCond.ExcellentTwo, strComparisonOpExcellentTwo);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.SuggestOne) == true)
{
string strComparisonOpSuggestOne = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.SuggestOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.SuggestOne, objvVideoLibAppraiseCond.SuggestOne, strComparisonOpSuggestOne);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.SuggestTwo) == true)
{
string strComparisonOpSuggestTwo = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.SuggestTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.SuggestTwo, objvVideoLibAppraiseCond.SuggestTwo, strComparisonOpSuggestTwo);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.MicroteachAppriseScore) == true)
{
string strComparisonOpMicroteachAppriseScore = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.MicroteachAppriseScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibAppraise.MicroteachAppriseScore, objvVideoLibAppraiseCond.MicroteachAppriseScore, strComparisonOpMicroteachAppriseScore);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.VideoStopTime) == true)
{
string strComparisonOpVideoStopTime = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoStopTime, objvVideoLibAppraiseCond.VideoStopTime, strComparisonOpVideoStopTime);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibAppraise.BrowseCount, objvVideoLibAppraiseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.UserId) == true)
{
string strComparisonOpUserId = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.UserId, objvVideoLibAppraiseCond.UserId, strComparisonOpUserId);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.UserName) == true)
{
string strComparisonOpUserName = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.UserName, objvVideoLibAppraiseCond.UserName, strComparisonOpUserName);
}
if (objvVideoLibAppraiseCond.IsUpdated(convVideoLibAppraise.UserNameWithUserId) == true)
{
string strComparisonOpUserNameWithUserId = objvVideoLibAppraiseCond.dicFldComparisonOp[convVideoLibAppraise.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.UserNameWithUserId, objvVideoLibAppraiseCond.UserNameWithUserId, strComparisonOpUserNameWithUserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vVideoLibAppraise
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachAppraise, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v视频库定性评议(vVideoLibAppraise)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLibAppraiseBL
{
public static RelatedActions_vVideoLibAppraise relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvVideoLibAppraiseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvVideoLibAppraiseDA vVideoLibAppraiseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvVideoLibAppraiseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvVideoLibAppraiseBL()
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
if (string.IsNullOrEmpty(clsvVideoLibAppraiseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLibAppraiseEN._ConnectString);
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
public static DataTable GetDataTable_vVideoLibAppraise(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vVideoLibAppraiseDA.GetDataTable_vVideoLibAppraise(strWhereCond);
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
objDT = vVideoLibAppraiseDA.GetDataTable(strWhereCond);
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
objDT = vVideoLibAppraiseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vVideoLibAppraiseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vVideoLibAppraiseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vVideoLibAppraiseDA.GetDataTable_Top(objTopPara);
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
objDT = vVideoLibAppraiseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vVideoLibAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vVideoLibAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachAppraiseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvVideoLibAppraiseEN> GetObjLstByIdMicroteachAppraiseLst(List<long> arrIdMicroteachAppraiseLst)
{
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachAppraiseLst);
 string strWhereCond = string.Format("IdMicroteachAppraise in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachAppraiseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvVideoLibAppraiseEN> GetObjLstByIdMicroteachAppraiseLstCache(List<long> arrIdMicroteachAppraiseLst)
{
string strKey = string.Format("{0}", clsvVideoLibAppraiseEN._CurrTabName);
List<clsvVideoLibAppraiseEN> arrvVideoLibAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibAppraiseEN> arrvVideoLibAppraiseObjLst_Sel =
arrvVideoLibAppraiseObjLstCache
.Where(x => arrIdMicroteachAppraiseLst.Contains(x.IdMicroteachAppraise));
return arrvVideoLibAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibAppraiseEN> GetObjLst(string strWhereCond)
{
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibAppraiseEN);
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
public static List<clsvVideoLibAppraiseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvVideoLibAppraiseEN> GetSubObjLstCache(clsvVideoLibAppraiseEN objvVideoLibAppraiseCond)
{
List<clsvVideoLibAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLibAppraise.AttributeName)
{
if (objvVideoLibAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLibAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibAppraiseCond[strFldName].ToString());
}
else
{
if (objvVideoLibAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLibAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLibAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLibAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLibAppraiseCond[strFldName]));
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
public static List<clsvVideoLibAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibAppraiseEN);
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
public static List<clsvVideoLibAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibAppraiseEN);
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
List<clsvVideoLibAppraiseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvVideoLibAppraiseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvVideoLibAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
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
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibAppraiseEN);
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
public static List<clsvVideoLibAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvVideoLibAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvVideoLibAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibAppraiseEN);
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
public static List<clsvVideoLibAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibAppraiseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvVideoLibAppraiseEN> arrObjLst = new List<clsvVideoLibAppraiseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = new clsvVideoLibAppraiseEN();
try
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convVideoLibAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvVideoLibAppraiseEN.FuncModuleId = objRow[convVideoLibAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibAppraiseEN.FuncModuleName = objRow[convVideoLibAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibAppraiseEN.IdMicroteachCase = objRow[convVideoLibAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibAppraiseEN.IdVideoLib = objRow[convVideoLibAppraise.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibAppraiseEN.VideoLibID = objRow[convVideoLibAppraise.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibAppraiseEN.VideoLibName = objRow[convVideoLibAppraise.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibAppraiseEN.VideoLibTheme = objRow[convVideoLibAppraise.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLibAppraiseEN.VideoLibTypeName = objRow[convVideoLibAppraise.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLibAppraiseEN.VideoLibDate = objRow[convVideoLibAppraise.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLibAppraiseEN.VideoLibTime = objRow[convVideoLibAppraise.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLibAppraiseEN.VideoLibDateIn = objRow[convVideoLibAppraise.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLibAppraiseEN.VideoLibTimeIn = objRow[convVideoLibAppraise.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLibAppraiseEN.IdXzCollege = objRow[convVideoLibAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibAppraiseEN.CollegeID = objRow[convVideoLibAppraise.CollegeID] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeID].ToString().Trim(); //学院ID
objvVideoLibAppraiseEN.CollegeName = objRow[convVideoLibAppraise.CollegeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CollegeName].ToString().Trim(); //学院名称
objvVideoLibAppraiseEN.CourseId = objRow[convVideoLibAppraise.CourseId] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseId].ToString().Trim(); //课程Id
objvVideoLibAppraiseEN.CourseCode = objRow[convVideoLibAppraise.CourseCode] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseCode].ToString().Trim(); //课程代码
objvVideoLibAppraiseEN.CourseName = objRow[convVideoLibAppraise.CourseName] == DBNull.Value ? null : objRow[convVideoLibAppraise.CourseName].ToString().Trim(); //课程名称
objvVideoLibAppraiseEN.BrowseCount4Case = objRow[convVideoLibAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLibAppraiseEN.IdAppraiseType = objRow[convVideoLibAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibAppraiseEN.AppraiseTypeName = objRow[convVideoLibAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibAppraiseEN.AppraiseTheme = objRow[convVideoLibAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvVideoLibAppraiseEN.AppraiseContent = objRow[convVideoLibAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvVideoLibAppraiseEN.AppraiseDate = objRow[convVideoLibAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvVideoLibAppraiseEN.AppraiseTime = objRow[convVideoLibAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvVideoLibAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvVideoLibAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibAppraise.IsElite].ToString().Trim()); //精华标志
objvVideoLibAppraiseEN.ExcellentOne = objRow[convVideoLibAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentOne].ToString().Trim(); //优点1
objvVideoLibAppraiseEN.ExcellentTwo = objRow[convVideoLibAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvVideoLibAppraiseEN.SuggestOne = objRow[convVideoLibAppraise.SuggestOne] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestOne].ToString().Trim(); //建议1
objvVideoLibAppraiseEN.SuggestTwo = objRow[convVideoLibAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convVideoLibAppraise.SuggestTwo].ToString().Trim(); //建议2
objvVideoLibAppraiseEN.MicroteachAppriseScore = objRow[convVideoLibAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvVideoLibAppraiseEN.VideoStopTime = objRow[convVideoLibAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convVideoLibAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvVideoLibAppraiseEN.BrowseCount = objRow[convVideoLibAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibAppraiseEN.UserId = objRow[convVideoLibAppraise.UserId].ToString().Trim(); //用户ID
objvVideoLibAppraiseEN.UserName = objRow[convVideoLibAppraise.UserName] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserName].ToString().Trim(); //用户名
objvVideoLibAppraiseEN.UserNameWithUserId = objRow[convVideoLibAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoLibAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibAppraiseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvVideoLibAppraise(ref clsvVideoLibAppraiseEN objvVideoLibAppraiseEN)
{
bool bolResult = vVideoLibAppraiseDA.GetvVideoLibAppraise(ref objvVideoLibAppraiseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibAppraiseEN GetObjByIdMicroteachAppraise(long lngIdMicroteachAppraise)
{
clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = vVideoLibAppraiseDA.GetObjByIdMicroteachAppraise(lngIdMicroteachAppraise);
return objvVideoLibAppraiseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvVideoLibAppraiseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = vVideoLibAppraiseDA.GetFirstObj(strWhereCond);
 return objvVideoLibAppraiseEN;
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
public static clsvVideoLibAppraiseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = vVideoLibAppraiseDA.GetObjByDataRow(objRow);
 return objvVideoLibAppraiseEN;
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
public static clsvVideoLibAppraiseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = vVideoLibAppraiseDA.GetObjByDataRow(objRow);
 return objvVideoLibAppraiseEN;
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
 /// <param name = "lngIdMicroteachAppraise">所给的关键字</param>
 /// <param name = "lstvVideoLibAppraiseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLibAppraiseEN GetObjByIdMicroteachAppraiseFromList(long lngIdMicroteachAppraise, List<clsvVideoLibAppraiseEN> lstvVideoLibAppraiseObjLst)
{
foreach (clsvVideoLibAppraiseEN objvVideoLibAppraiseEN in lstvVideoLibAppraiseObjLst)
{
if (objvVideoLibAppraiseEN.IdMicroteachAppraise == lngIdMicroteachAppraise)
{
return objvVideoLibAppraiseEN;
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
 long lngIdMicroteachAppraise;
 try
 {
 lngIdMicroteachAppraise = new clsvVideoLibAppraiseDA().GetFirstID(strWhereCond);
 return lngIdMicroteachAppraise;
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
 arrList = vVideoLibAppraiseDA.GetID(strWhereCond);
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
bool bolIsExist = vVideoLibAppraiseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachAppraise)
{
//检测记录是否存在
bool bolIsExist = vVideoLibAppraiseDA.IsExist(lngIdMicroteachAppraise);
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
 bolIsExist = clsvVideoLibAppraiseDA.IsExistTable();
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
 bolIsExist = vVideoLibAppraiseDA.IsExistTable(strTabName);
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
 /// <param name = "objvVideoLibAppraiseENS">源对象</param>
 /// <param name = "objvVideoLibAppraiseENT">目标对象</param>
 public static void CopyTo(clsvVideoLibAppraiseEN objvVideoLibAppraiseENS, clsvVideoLibAppraiseEN objvVideoLibAppraiseENT)
{
try
{
objvVideoLibAppraiseENT.IdMicroteachAppraise = objvVideoLibAppraiseENS.IdMicroteachAppraise; //评议流水号
objvVideoLibAppraiseENT.FuncModuleId = objvVideoLibAppraiseENS.FuncModuleId; //功能模块Id
objvVideoLibAppraiseENT.FuncModuleName = objvVideoLibAppraiseENS.FuncModuleName; //功能模块名称
objvVideoLibAppraiseENT.IdMicroteachCase = objvVideoLibAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibAppraiseENT.IdVideoLib = objvVideoLibAppraiseENS.IdVideoLib; //视频库流水号
objvVideoLibAppraiseENT.VideoLibID = objvVideoLibAppraiseENS.VideoLibID; //视频库ID
objvVideoLibAppraiseENT.VideoLibName = objvVideoLibAppraiseENS.VideoLibName; //视频名称
objvVideoLibAppraiseENT.VideoLibTheme = objvVideoLibAppraiseENS.VideoLibTheme; //视频库主题词
objvVideoLibAppraiseENT.VideoLibTypeName = objvVideoLibAppraiseENS.VideoLibTypeName; //视频库类型名称
objvVideoLibAppraiseENT.VideoLibDate = objvVideoLibAppraiseENS.VideoLibDate; //视频资源日期
objvVideoLibAppraiseENT.VideoLibTime = objvVideoLibAppraiseENS.VideoLibTime; //视频资源时间
objvVideoLibAppraiseENT.VideoLibDateIn = objvVideoLibAppraiseENS.VideoLibDateIn; //案例入库日期
objvVideoLibAppraiseENT.VideoLibTimeIn = objvVideoLibAppraiseENS.VideoLibTimeIn; //案例入库时间
objvVideoLibAppraiseENT.IdXzCollege = objvVideoLibAppraiseENS.IdXzCollege; //学院流水号
objvVideoLibAppraiseENT.CollegeID = objvVideoLibAppraiseENS.CollegeID; //学院ID
objvVideoLibAppraiseENT.CollegeName = objvVideoLibAppraiseENS.CollegeName; //学院名称
objvVideoLibAppraiseENT.CourseId = objvVideoLibAppraiseENS.CourseId; //课程Id
objvVideoLibAppraiseENT.CourseCode = objvVideoLibAppraiseENS.CourseCode; //课程代码
objvVideoLibAppraiseENT.CourseName = objvVideoLibAppraiseENS.CourseName; //课程名称
objvVideoLibAppraiseENT.BrowseCount4Case = objvVideoLibAppraiseENS.BrowseCount4Case; //课例浏览次数
objvVideoLibAppraiseENT.IdAppraiseType = objvVideoLibAppraiseENS.IdAppraiseType; //评议类型流水号
objvVideoLibAppraiseENT.AppraiseTypeName = objvVideoLibAppraiseENS.AppraiseTypeName; //评议类型名称
objvVideoLibAppraiseENT.AppraiseTheme = objvVideoLibAppraiseENS.AppraiseTheme; //评议主题
objvVideoLibAppraiseENT.AppraiseContent = objvVideoLibAppraiseENS.AppraiseContent; //评议内容
objvVideoLibAppraiseENT.AppraiseDate = objvVideoLibAppraiseENS.AppraiseDate; //评议日期
objvVideoLibAppraiseENT.AppraiseTime = objvVideoLibAppraiseENS.AppraiseTime; //评议时间
objvVideoLibAppraiseENT.IsVisual = objvVideoLibAppraiseENS.IsVisual; //隐藏标志
objvVideoLibAppraiseENT.IsElite = objvVideoLibAppraiseENS.IsElite; //精华标志
objvVideoLibAppraiseENT.ExcellentOne = objvVideoLibAppraiseENS.ExcellentOne; //优点1
objvVideoLibAppraiseENT.ExcellentTwo = objvVideoLibAppraiseENS.ExcellentTwo; //优点2
objvVideoLibAppraiseENT.SuggestOne = objvVideoLibAppraiseENS.SuggestOne; //建议1
objvVideoLibAppraiseENT.SuggestTwo = objvVideoLibAppraiseENS.SuggestTwo; //建议2
objvVideoLibAppraiseENT.MicroteachAppriseScore = objvVideoLibAppraiseENS.MicroteachAppriseScore; //打分
objvVideoLibAppraiseENT.VideoStopTime = objvVideoLibAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objvVideoLibAppraiseENT.BrowseCount = objvVideoLibAppraiseENS.BrowseCount; //浏览次数
objvVideoLibAppraiseENT.UserId = objvVideoLibAppraiseENS.UserId; //用户ID
objvVideoLibAppraiseENT.UserName = objvVideoLibAppraiseENS.UserName; //用户名
objvVideoLibAppraiseENT.UserNameWithUserId = objvVideoLibAppraiseENS.UserNameWithUserId; //UserNameWithUserId
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
 /// <param name = "objvVideoLibAppraiseEN">源简化对象</param>
 public static void SetUpdFlag(clsvVideoLibAppraiseEN objvVideoLibAppraiseEN)
{
try
{
objvVideoLibAppraiseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvVideoLibAppraiseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convVideoLibAppraise.IdMicroteachAppraise, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.IdMicroteachAppraise = objvVideoLibAppraiseEN.IdMicroteachAppraise; //评议流水号
}
if (arrFldSet.Contains(convVideoLibAppraise.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.FuncModuleId = objvVideoLibAppraiseEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convVideoLibAppraise.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.FuncModuleName = objvVideoLibAppraiseEN.FuncModuleName == "[null]" ? null :  objvVideoLibAppraiseEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convVideoLibAppraise.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.IdMicroteachCase = objvVideoLibAppraiseEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convVideoLibAppraise.IdVideoLib, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.IdVideoLib = objvVideoLibAppraiseEN.IdVideoLib == "[null]" ? null :  objvVideoLibAppraiseEN.IdVideoLib; //视频库流水号
}
if (arrFldSet.Contains(convVideoLibAppraise.VideoLibID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.VideoLibID = objvVideoLibAppraiseEN.VideoLibID == "[null]" ? null :  objvVideoLibAppraiseEN.VideoLibID; //视频库ID
}
if (arrFldSet.Contains(convVideoLibAppraise.VideoLibName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.VideoLibName = objvVideoLibAppraiseEN.VideoLibName == "[null]" ? null :  objvVideoLibAppraiseEN.VideoLibName; //视频名称
}
if (arrFldSet.Contains(convVideoLibAppraise.VideoLibTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.VideoLibTheme = objvVideoLibAppraiseEN.VideoLibTheme == "[null]" ? null :  objvVideoLibAppraiseEN.VideoLibTheme; //视频库主题词
}
if (arrFldSet.Contains(convVideoLibAppraise.VideoLibTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.VideoLibTypeName = objvVideoLibAppraiseEN.VideoLibTypeName == "[null]" ? null :  objvVideoLibAppraiseEN.VideoLibTypeName; //视频库类型名称
}
if (arrFldSet.Contains(convVideoLibAppraise.VideoLibDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.VideoLibDate = objvVideoLibAppraiseEN.VideoLibDate == "[null]" ? null :  objvVideoLibAppraiseEN.VideoLibDate; //视频资源日期
}
if (arrFldSet.Contains(convVideoLibAppraise.VideoLibTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.VideoLibTime = objvVideoLibAppraiseEN.VideoLibTime == "[null]" ? null :  objvVideoLibAppraiseEN.VideoLibTime; //视频资源时间
}
if (arrFldSet.Contains(convVideoLibAppraise.VideoLibDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.VideoLibDateIn = objvVideoLibAppraiseEN.VideoLibDateIn == "[null]" ? null :  objvVideoLibAppraiseEN.VideoLibDateIn; //案例入库日期
}
if (arrFldSet.Contains(convVideoLibAppraise.VideoLibTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.VideoLibTimeIn = objvVideoLibAppraiseEN.VideoLibTimeIn == "[null]" ? null :  objvVideoLibAppraiseEN.VideoLibTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convVideoLibAppraise.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.IdXzCollege = objvVideoLibAppraiseEN.IdXzCollege == "[null]" ? null :  objvVideoLibAppraiseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convVideoLibAppraise.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.CollegeID = objvVideoLibAppraiseEN.CollegeID == "[null]" ? null :  objvVideoLibAppraiseEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convVideoLibAppraise.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.CollegeName = objvVideoLibAppraiseEN.CollegeName == "[null]" ? null :  objvVideoLibAppraiseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convVideoLibAppraise.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.CourseId = objvVideoLibAppraiseEN.CourseId == "[null]" ? null :  objvVideoLibAppraiseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convVideoLibAppraise.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.CourseCode = objvVideoLibAppraiseEN.CourseCode == "[null]" ? null :  objvVideoLibAppraiseEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convVideoLibAppraise.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.CourseName = objvVideoLibAppraiseEN.CourseName == "[null]" ? null :  objvVideoLibAppraiseEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convVideoLibAppraise.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.BrowseCount4Case = objvVideoLibAppraiseEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convVideoLibAppraise.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.IdAppraiseType = objvVideoLibAppraiseEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convVideoLibAppraise.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.AppraiseTypeName = objvVideoLibAppraiseEN.AppraiseTypeName == "[null]" ? null :  objvVideoLibAppraiseEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convVideoLibAppraise.AppraiseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.AppraiseTheme = objvVideoLibAppraiseEN.AppraiseTheme == "[null]" ? null :  objvVideoLibAppraiseEN.AppraiseTheme; //评议主题
}
if (arrFldSet.Contains(convVideoLibAppraise.AppraiseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.AppraiseContent = objvVideoLibAppraiseEN.AppraiseContent == "[null]" ? null :  objvVideoLibAppraiseEN.AppraiseContent; //评议内容
}
if (arrFldSet.Contains(convVideoLibAppraise.AppraiseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.AppraiseDate = objvVideoLibAppraiseEN.AppraiseDate == "[null]" ? null :  objvVideoLibAppraiseEN.AppraiseDate; //评议日期
}
if (arrFldSet.Contains(convVideoLibAppraise.AppraiseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.AppraiseTime = objvVideoLibAppraiseEN.AppraiseTime == "[null]" ? null :  objvVideoLibAppraiseEN.AppraiseTime; //评议时间
}
if (arrFldSet.Contains(convVideoLibAppraise.IsVisual, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.IsVisual = objvVideoLibAppraiseEN.IsVisual; //隐藏标志
}
if (arrFldSet.Contains(convVideoLibAppraise.IsElite, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.IsElite = objvVideoLibAppraiseEN.IsElite; //精华标志
}
if (arrFldSet.Contains(convVideoLibAppraise.ExcellentOne, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.ExcellentOne = objvVideoLibAppraiseEN.ExcellentOne == "[null]" ? null :  objvVideoLibAppraiseEN.ExcellentOne; //优点1
}
if (arrFldSet.Contains(convVideoLibAppraise.ExcellentTwo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.ExcellentTwo = objvVideoLibAppraiseEN.ExcellentTwo == "[null]" ? null :  objvVideoLibAppraiseEN.ExcellentTwo; //优点2
}
if (arrFldSet.Contains(convVideoLibAppraise.SuggestOne, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.SuggestOne = objvVideoLibAppraiseEN.SuggestOne == "[null]" ? null :  objvVideoLibAppraiseEN.SuggestOne; //建议1
}
if (arrFldSet.Contains(convVideoLibAppraise.SuggestTwo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.SuggestTwo = objvVideoLibAppraiseEN.SuggestTwo == "[null]" ? null :  objvVideoLibAppraiseEN.SuggestTwo; //建议2
}
if (arrFldSet.Contains(convVideoLibAppraise.MicroteachAppriseScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.MicroteachAppriseScore = objvVideoLibAppraiseEN.MicroteachAppriseScore; //打分
}
if (arrFldSet.Contains(convVideoLibAppraise.VideoStopTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.VideoStopTime = objvVideoLibAppraiseEN.VideoStopTime == "[null]" ? null :  objvVideoLibAppraiseEN.VideoStopTime; //公开课案例视频暂停时间
}
if (arrFldSet.Contains(convVideoLibAppraise.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.BrowseCount = objvVideoLibAppraiseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convVideoLibAppraise.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.UserId = objvVideoLibAppraiseEN.UserId; //用户ID
}
if (arrFldSet.Contains(convVideoLibAppraise.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.UserName = objvVideoLibAppraiseEN.UserName == "[null]" ? null :  objvVideoLibAppraiseEN.UserName; //用户名
}
if (arrFldSet.Contains(convVideoLibAppraise.UserNameWithUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibAppraiseEN.UserNameWithUserId = objvVideoLibAppraiseEN.UserNameWithUserId == "[null]" ? null :  objvVideoLibAppraiseEN.UserNameWithUserId; //UserNameWithUserId
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
 /// <param name = "objvVideoLibAppraiseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvVideoLibAppraiseEN objvVideoLibAppraiseEN)
{
try
{
if (objvVideoLibAppraiseEN.FuncModuleName == "[null]") objvVideoLibAppraiseEN.FuncModuleName = null; //功能模块名称
if (objvVideoLibAppraiseEN.IdVideoLib == "[null]") objvVideoLibAppraiseEN.IdVideoLib = null; //视频库流水号
if (objvVideoLibAppraiseEN.VideoLibID == "[null]") objvVideoLibAppraiseEN.VideoLibID = null; //视频库ID
if (objvVideoLibAppraiseEN.VideoLibName == "[null]") objvVideoLibAppraiseEN.VideoLibName = null; //视频名称
if (objvVideoLibAppraiseEN.VideoLibTheme == "[null]") objvVideoLibAppraiseEN.VideoLibTheme = null; //视频库主题词
if (objvVideoLibAppraiseEN.VideoLibTypeName == "[null]") objvVideoLibAppraiseEN.VideoLibTypeName = null; //视频库类型名称
if (objvVideoLibAppraiseEN.VideoLibDate == "[null]") objvVideoLibAppraiseEN.VideoLibDate = null; //视频资源日期
if (objvVideoLibAppraiseEN.VideoLibTime == "[null]") objvVideoLibAppraiseEN.VideoLibTime = null; //视频资源时间
if (objvVideoLibAppraiseEN.VideoLibDateIn == "[null]") objvVideoLibAppraiseEN.VideoLibDateIn = null; //案例入库日期
if (objvVideoLibAppraiseEN.VideoLibTimeIn == "[null]") objvVideoLibAppraiseEN.VideoLibTimeIn = null; //案例入库时间
if (objvVideoLibAppraiseEN.IdXzCollege == "[null]") objvVideoLibAppraiseEN.IdXzCollege = null; //学院流水号
if (objvVideoLibAppraiseEN.CollegeID == "[null]") objvVideoLibAppraiseEN.CollegeID = null; //学院ID
if (objvVideoLibAppraiseEN.CollegeName == "[null]") objvVideoLibAppraiseEN.CollegeName = null; //学院名称
if (objvVideoLibAppraiseEN.CourseId == "[null]") objvVideoLibAppraiseEN.CourseId = null; //课程Id
if (objvVideoLibAppraiseEN.CourseCode == "[null]") objvVideoLibAppraiseEN.CourseCode = null; //课程代码
if (objvVideoLibAppraiseEN.CourseName == "[null]") objvVideoLibAppraiseEN.CourseName = null; //课程名称
if (objvVideoLibAppraiseEN.AppraiseTypeName == "[null]") objvVideoLibAppraiseEN.AppraiseTypeName = null; //评议类型名称
if (objvVideoLibAppraiseEN.AppraiseTheme == "[null]") objvVideoLibAppraiseEN.AppraiseTheme = null; //评议主题
if (objvVideoLibAppraiseEN.AppraiseContent == "[null]") objvVideoLibAppraiseEN.AppraiseContent = null; //评议内容
if (objvVideoLibAppraiseEN.AppraiseDate == "[null]") objvVideoLibAppraiseEN.AppraiseDate = null; //评议日期
if (objvVideoLibAppraiseEN.AppraiseTime == "[null]") objvVideoLibAppraiseEN.AppraiseTime = null; //评议时间
if (objvVideoLibAppraiseEN.ExcellentOne == "[null]") objvVideoLibAppraiseEN.ExcellentOne = null; //优点1
if (objvVideoLibAppraiseEN.ExcellentTwo == "[null]") objvVideoLibAppraiseEN.ExcellentTwo = null; //优点2
if (objvVideoLibAppraiseEN.SuggestOne == "[null]") objvVideoLibAppraiseEN.SuggestOne = null; //建议1
if (objvVideoLibAppraiseEN.SuggestTwo == "[null]") objvVideoLibAppraiseEN.SuggestTwo = null; //建议2
if (objvVideoLibAppraiseEN.VideoStopTime == "[null]") objvVideoLibAppraiseEN.VideoStopTime = null; //公开课案例视频暂停时间
if (objvVideoLibAppraiseEN.UserName == "[null]") objvVideoLibAppraiseEN.UserName = null; //用户名
if (objvVideoLibAppraiseEN.UserNameWithUserId == "[null]") objvVideoLibAppraiseEN.UserNameWithUserId = null; //UserNameWithUserId
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
public static void CheckProperty4Condition(clsvVideoLibAppraiseEN objvVideoLibAppraiseEN)
{
 vVideoLibAppraiseDA.CheckProperty4Condition(objvVideoLibAppraiseEN);
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
if (clsMicroteachAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseBL没有刷新缓存机制(clsMicroteachAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeBL没有刷新缓存机制(clsAppraiseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachAppraise");
//if (arrvVideoLibAppraiseObjLstCache == null)
//{
//arrvVideoLibAppraiseObjLstCache = vVideoLibAppraiseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLibAppraiseEN GetObjByIdMicroteachAppraiseCache(long lngIdMicroteachAppraise)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvVideoLibAppraiseEN._CurrTabName);
List<clsvVideoLibAppraiseEN> arrvVideoLibAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibAppraiseEN> arrvVideoLibAppraiseObjLst_Sel =
arrvVideoLibAppraiseObjLstCache
.Where(x=> x.IdMicroteachAppraise == lngIdMicroteachAppraise 
);
if (arrvVideoLibAppraiseObjLst_Sel.Count() == 0)
{
   clsvVideoLibAppraiseEN obj = clsvVideoLibAppraiseBL.GetObjByIdMicroteachAppraise(lngIdMicroteachAppraise);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvVideoLibAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLibAppraiseEN> GetAllvVideoLibAppraiseObjLstCache()
{
//获取缓存中的对象列表
List<clsvVideoLibAppraiseEN> arrvVideoLibAppraiseObjLstCache = GetObjLstCache(); 
return arrvVideoLibAppraiseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLibAppraiseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLibAppraiseEN._CurrTabName);
List<clsvVideoLibAppraiseEN> arrvVideoLibAppraiseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLibAppraiseObjLstCache;
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
string strKey = string.Format("{0}", clsvVideoLibAppraiseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachAppraise)
{
if (strInFldName != convVideoLibAppraise.IdMicroteachAppraise)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convVideoLibAppraise.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convVideoLibAppraise.AttributeName));
throw new Exception(strMsg);
}
var objvVideoLibAppraise = clsvVideoLibAppraiseBL.GetObjByIdMicroteachAppraiseCache(lngIdMicroteachAppraise);
if (objvVideoLibAppraise == null) return "";
return objvVideoLibAppraise[strOutFldName].ToString();
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
int intRecCount = clsvVideoLibAppraiseDA.GetRecCount(strTabName);
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
int intRecCount = clsvVideoLibAppraiseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvVideoLibAppraiseDA.GetRecCount();
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
int intRecCount = clsvVideoLibAppraiseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvVideoLibAppraiseEN objvVideoLibAppraiseCond)
{
List<clsvVideoLibAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLibAppraise.AttributeName)
{
if (objvVideoLibAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLibAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibAppraiseCond[strFldName].ToString());
}
else
{
if (objvVideoLibAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLibAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLibAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLibAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLibAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLibAppraiseCond[strFldName]));
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
 List<string> arrList = clsvVideoLibAppraiseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vVideoLibAppraiseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vVideoLibAppraiseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}