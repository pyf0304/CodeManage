
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLib_Resource_RelBL
 表名:vVideoLib_Resource_Rel(01120442)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:36
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
public static class  clsvVideoLib_Resource_RelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLib_Resource_RelEN GetObj(this K_IdMicroteachCaseResourceRel_vVideoLib_Resource_Rel myKey)
{
clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = clsvVideoLib_Resource_RelBL.vVideoLib_Resource_RelDA.GetObjByIdMicroteachCaseResourceRel(myKey.Value);
return objvVideoLib_Resource_RelEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIdMicroteachCaseResourceRel(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, long lngIdMicroteachCaseResourceRel, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = lngIdMicroteachCaseResourceRel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFuncModuleId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoLib_Resource_Rel.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoLib_Resource_Rel.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoLib_Resource_Rel.FuncModuleId);
}
objvVideoLib_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FuncModuleId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFuncModuleName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoLib_Resource_Rel.FuncModuleName);
}
objvVideoLib_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FuncModuleName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIdMicroteachCase(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convVideoLib_Resource_Rel.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convVideoLib_Resource_Rel.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convVideoLib_Resource_Rel.IdMicroteachCase);
}
objvVideoLib_Resource_RelEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IdMicroteachCase) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IdMicroteachCase, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IdMicroteachCase] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLib_Resource_Rel.VideoLibID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLib_Resource_Rel.VideoLibID);
}
objvVideoLib_Resource_RelEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLib_Resource_Rel.VideoLibName);
}
objvVideoLib_Resource_RelEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibTheme(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, convVideoLib_Resource_Rel.VideoLibTheme);
}
objvVideoLib_Resource_RelEN.VideoLibTheme = strVideoLibTheme; //视频库主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibTheme) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibTheme, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTheme] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIdVideoLibType(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strIdVideoLibType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdVideoLibType, 4, convVideoLib_Resource_Rel.IdVideoLibType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdVideoLibType, 4, convVideoLib_Resource_Rel.IdVideoLibType);
}
objvVideoLib_Resource_RelEN.IdVideoLibType = strIdVideoLibType; //视频库类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IdVideoLibType) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IdVideoLibType, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IdVideoLibType] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibTypeName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTypeName, 30, convVideoLib_Resource_Rel.VideoLibTypeName);
}
objvVideoLib_Resource_RelEN.VideoLibTypeName = strVideoLibTypeName; //视频库类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibTypeName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibTypeName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTypeName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibText(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibText, 8000, convVideoLib_Resource_Rel.VideoLibText);
}
objvVideoLib_Resource_RelEN.VideoLibText = strVideoLibText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibText) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibText, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibText] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibDate(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDate, 8, convVideoLib_Resource_Rel.VideoLibDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibDate, 8, convVideoLib_Resource_Rel.VideoLibDate);
}
objvVideoLib_Resource_RelEN.VideoLibDate = strVideoLibDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibDate) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibDate, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibDate] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibTime(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, convVideoLib_Resource_Rel.VideoLibTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, convVideoLib_Resource_Rel.VideoLibTime);
}
objvVideoLib_Resource_RelEN.VideoLibTime = strVideoLibTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibTime) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibTime, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTime] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibDateIn(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, convVideoLib_Resource_Rel.VideoLibDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, convVideoLib_Resource_Rel.VideoLibDateIn);
}
objvVideoLib_Resource_RelEN.VideoLibDateIn = strVideoLibDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibDateIn) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibDateIn, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibDateIn] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVideoLibTimeIn(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, convVideoLib_Resource_Rel.VideoLibTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, convVideoLib_Resource_Rel.VideoLibTimeIn);
}
objvVideoLib_Resource_RelEN.VideoLibTimeIn = strVideoLibTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VideoLibTimeIn) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VideoLibTimeIn, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTimeIn] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetOwnerId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convVideoLib_Resource_Rel.OwnerId);
}
objvVideoLib_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.OwnerId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIdTeachingPlan(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convVideoLib_Resource_Rel.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convVideoLib_Resource_Rel.IdTeachingPlan);
}
objvVideoLib_Resource_RelEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IdTeachingPlan) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IdTeachingPlan, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IdTeachingPlan] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetsenateGaugeVersionID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoLib_Resource_Rel.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoLib_Resource_Rel.senateGaugeVersionID);
}
objvVideoLib_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.senateGaugeVersionID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetsenateGaugeVersionName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoLib_Resource_Rel.senateGaugeVersionName);
}
objvVideoLib_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.senateGaugeVersionName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetVersionNo(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int? intVersionNo, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.VersionNo) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCaseLevelId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convVideoLib_Resource_Rel.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convVideoLib_Resource_Rel.CaseLevelId);
}
objvVideoLib_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CaseLevelId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIdXzCollege(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convVideoLib_Resource_Rel.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convVideoLib_Resource_Rel.IdXzCollege);
}
objvVideoLib_Resource_RelEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IdXzCollege) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IdXzCollege, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IdXzCollege] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCollegeID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLib_Resource_Rel.CollegeID);
}
objvVideoLib_Resource_RelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CollegeID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CollegeID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCollegeName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLib_Resource_Rel.CollegeName);
}
objvVideoLib_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CollegeName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCollegeNameA(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoLib_Resource_Rel.CollegeNameA);
}
objvVideoLib_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CollegeNameA) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetViewCount(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int? intViewCount, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ViewCount) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ViewCount, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ViewCount] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetDownloadNumber(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.DownloadNumber) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.DownloadNumber, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.DownloadNumber] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileIntegration(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int? intFileIntegration, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileIntegration) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileIntegration, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileIntegration] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetLikeCount(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, long? lngLikeCount, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.LikeCount) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.LikeCount, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.LikeCount] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCollectionCount(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CollectionCount) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CollectionCount, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CollectionCount] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetRecommendedDegreeId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convVideoLib_Resource_Rel.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convVideoLib_Resource_Rel.RecommendedDegreeId);
}
objvVideoLib_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.RecommendedDegreeId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetRecommendedDegreeName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convVideoLib_Resource_Rel.RecommendedDegreeName);
}
objvVideoLib_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.RecommendedDegreeName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCourseId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLib_Resource_Rel.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLib_Resource_Rel.CourseId);
}
objvVideoLib_Resource_RelEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CourseId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CourseId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCourseCode(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLib_Resource_Rel.CourseCode);
}
objvVideoLib_Resource_RelEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CourseCode) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CourseCode, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseCode] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetCourseName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLib_Resource_Rel.CourseName);
}
objvVideoLib_Resource_RelEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.CourseName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.CourseName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetBrowseCount4Case(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.BrowseCount4Case) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetOwnerName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convVideoLib_Resource_Rel.OwnerName);
}
objvVideoLib_Resource_RelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.OwnerName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.OwnerName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetOwnerNameWithId(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convVideoLib_Resource_Rel.OwnerNameWithId);
}
objvVideoLib_Resource_RelEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.OwnerNameWithId) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.OwnerNameWithId, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerNameWithId] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIdResource(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convVideoLib_Resource_Rel.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convVideoLib_Resource_Rel.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convVideoLib_Resource_Rel.IdResource);
}
objvVideoLib_Resource_RelEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IdResource) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IdResource, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IdResource] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetResourceID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convVideoLib_Resource_Rel.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convVideoLib_Resource_Rel.ResourceID);
}
objvVideoLib_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ResourceID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetResourceName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convVideoLib_Resource_Rel.ResourceName);
}
objvVideoLib_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ResourceName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetSaveMode(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.SaveMode) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIdFtpResource(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convVideoLib_Resource_Rel.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convVideoLib_Resource_Rel.IdFtpResource);
}
objvVideoLib_Resource_RelEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IdFtpResource) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IdFtpResource, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IdFtpResource] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFtpResourceID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convVideoLib_Resource_Rel.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convVideoLib_Resource_Rel.FtpResourceID);
}
objvVideoLib_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FtpResourceID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileOriginalName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convVideoLib_Resource_Rel.FileOriginalName);
}
objvVideoLib_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileOriginalName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileDirName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convVideoLib_Resource_Rel.FileDirName);
}
objvVideoLib_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileDirName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileRename(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convVideoLib_Resource_Rel.FileRename);
}
objvVideoLib_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileRename) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileUpDate(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convVideoLib_Resource_Rel.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convVideoLib_Resource_Rel.FileUpDate);
}
objvVideoLib_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileUpDate) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileUpTime(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convVideoLib_Resource_Rel.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convVideoLib_Resource_Rel.FileUpTime);
}
objvVideoLib_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileUpTime) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileSize(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convVideoLib_Resource_Rel.FileSize);
}
objvVideoLib_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileSize) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileType(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convVideoLib_Resource_Rel.FileType);
}
objvVideoLib_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileType) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetResourceOwner(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convVideoLib_Resource_Rel.ResourceOwner);
}
objvVideoLib_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ResourceOwner) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIsExistFile(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IsExistFile) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIdFile(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convVideoLib_Resource_Rel.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convVideoLib_Resource_Rel.IdFile);
}
objvVideoLib_Resource_RelEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IdFile) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IdFile, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IdFile] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convVideoLib_Resource_Rel.FileName);
}
objvVideoLib_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetSaveDate(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convVideoLib_Resource_Rel.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convVideoLib_Resource_Rel.SaveDate);
}
objvVideoLib_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.SaveDate) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetSaveTime(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convVideoLib_Resource_Rel.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convVideoLib_Resource_Rel.SaveTime);
}
objvVideoLib_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.SaveTime) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileOriginName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convVideoLib_Resource_Rel.FileOriginName);
}
objvVideoLib_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileOriginName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIdResourceType(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convVideoLib_Resource_Rel.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convVideoLib_Resource_Rel.IdResourceType);
}
objvVideoLib_Resource_RelEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IdResourceType) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IdResourceType, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IdResourceType] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetResourceTypeID(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convVideoLib_Resource_Rel.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convVideoLib_Resource_Rel.ResourceTypeID);
}
objvVideoLib_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ResourceTypeID) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetResourceTypeName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convVideoLib_Resource_Rel.ResourceTypeName);
}
objvVideoLib_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ResourceTypeName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileNewName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convVideoLib_Resource_Rel.FileNewName);
}
objvVideoLib_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileNewName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetFileOldName(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convVideoLib_Resource_Rel.FileOldName);
}
objvVideoLib_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.FileOldName) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetftpFileType(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convVideoLib_Resource_Rel.ftpFileType);
}
objvVideoLib_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ftpFileType) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetftpFileSize(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convVideoLib_Resource_Rel.ftpFileSize);
}
objvVideoLib_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ftpFileSize) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetftpResourceOwner(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convVideoLib_Resource_Rel.ftpResourceOwner);
}
objvVideoLib_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.ftpResourceOwner) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIsMain(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IsMain) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIdUsingMode(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strIdUsingMode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUsingMode, 4, convVideoLib_Resource_Rel.IdUsingMode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUsingMode, 4, convVideoLib_Resource_Rel.IdUsingMode);
}
objvVideoLib_Resource_RelEN.IdUsingMode = strIdUsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IdUsingMode) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IdUsingMode, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IdUsingMode] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIsVisible(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IsVisible) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetIndexNO(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int? intIndexNO, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.IndexNO) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetBrowseCount(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, int? intBrowseCount, string strComparisonOp="")
	{
objvVideoLib_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.BrowseCount) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetUpdDate(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convVideoLib_Resource_Rel.UpdDate);
}
objvVideoLib_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.UpdDate) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetUpdUser(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convVideoLib_Resource_Rel.UpdUser);
}
objvVideoLib_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.UpdUser) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLib_Resource_RelEN SetMemo(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoLib_Resource_Rel.Memo);
}
objvVideoLib_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLib_Resource_RelEN.dicFldComparisonOp.ContainsKey(convVideoLib_Resource_Rel.Memo) == false)
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp.Add(convVideoLib_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvVideoLib_Resource_RelEN.dicFldComparisonOp[convVideoLib_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvVideoLib_Resource_RelEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelENS">源对象</param>
 /// <param name = "objvVideoLib_Resource_RelENT">目标对象</param>
 public static void CopyTo(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelENS, clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelENT)
{
try
{
objvVideoLib_Resource_RelENT.IdMicroteachCaseResourceRel = objvVideoLib_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvVideoLib_Resource_RelENT.FuncModuleId = objvVideoLib_Resource_RelENS.FuncModuleId; //功能模块Id
objvVideoLib_Resource_RelENT.FuncModuleName = objvVideoLib_Resource_RelENS.FuncModuleName; //功能模块名称
objvVideoLib_Resource_RelENT.IdMicroteachCase = objvVideoLib_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLib_Resource_RelENT.VideoLibID = objvVideoLib_Resource_RelENS.VideoLibID; //视频库ID
objvVideoLib_Resource_RelENT.VideoLibName = objvVideoLib_Resource_RelENS.VideoLibName; //视频名称
objvVideoLib_Resource_RelENT.VideoLibTheme = objvVideoLib_Resource_RelENS.VideoLibTheme; //视频库主题词
objvVideoLib_Resource_RelENT.IdVideoLibType = objvVideoLib_Resource_RelENS.IdVideoLibType; //视频库类型流水号
objvVideoLib_Resource_RelENT.VideoLibTypeName = objvVideoLib_Resource_RelENS.VideoLibTypeName; //视频库类型名称
objvVideoLib_Resource_RelENT.VideoLibText = objvVideoLib_Resource_RelENS.VideoLibText; //案例文本内容
objvVideoLib_Resource_RelENT.VideoLibDate = objvVideoLib_Resource_RelENS.VideoLibDate; //视频资源日期
objvVideoLib_Resource_RelENT.VideoLibTime = objvVideoLib_Resource_RelENS.VideoLibTime; //视频资源时间
objvVideoLib_Resource_RelENT.VideoLibDateIn = objvVideoLib_Resource_RelENS.VideoLibDateIn; //案例入库日期
objvVideoLib_Resource_RelENT.VideoLibTimeIn = objvVideoLib_Resource_RelENS.VideoLibTimeIn; //案例入库时间
objvVideoLib_Resource_RelENT.OwnerId = objvVideoLib_Resource_RelENS.OwnerId; //拥有者Id
objvVideoLib_Resource_RelENT.IdTeachingPlan = objvVideoLib_Resource_RelENS.IdTeachingPlan; //教案流水号
objvVideoLib_Resource_RelENT.senateGaugeVersionID = objvVideoLib_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLib_Resource_RelENT.senateGaugeVersionName = objvVideoLib_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLib_Resource_RelENT.senateGaugeVersionTtlScore = objvVideoLib_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLib_Resource_RelENT.VersionNo = objvVideoLib_Resource_RelENS.VersionNo; //版本号
objvVideoLib_Resource_RelENT.CaseLevelId = objvVideoLib_Resource_RelENS.CaseLevelId; //课例等级Id
objvVideoLib_Resource_RelENT.IdXzCollege = objvVideoLib_Resource_RelENS.IdXzCollege; //学院流水号
objvVideoLib_Resource_RelENT.CollegeID = objvVideoLib_Resource_RelENS.CollegeID; //学院ID
objvVideoLib_Resource_RelENT.CollegeName = objvVideoLib_Resource_RelENS.CollegeName; //学院名称
objvVideoLib_Resource_RelENT.CollegeNameA = objvVideoLib_Resource_RelENS.CollegeNameA; //学院名称简写
objvVideoLib_Resource_RelENT.ViewCount = objvVideoLib_Resource_RelENS.ViewCount; //浏览量
objvVideoLib_Resource_RelENT.DownloadNumber = objvVideoLib_Resource_RelENS.DownloadNumber; //下载数目
objvVideoLib_Resource_RelENT.FileIntegration = objvVideoLib_Resource_RelENS.FileIntegration; //文件积分
objvVideoLib_Resource_RelENT.LikeCount = objvVideoLib_Resource_RelENS.LikeCount; //资源喜欢数量
objvVideoLib_Resource_RelENT.CollectionCount = objvVideoLib_Resource_RelENS.CollectionCount; //收藏数量
objvVideoLib_Resource_RelENT.RecommendedDegreeId = objvVideoLib_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvVideoLib_Resource_RelENT.RecommendedDegreeName = objvVideoLib_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvVideoLib_Resource_RelENT.CourseId = objvVideoLib_Resource_RelENS.CourseId; //课程Id
objvVideoLib_Resource_RelENT.CourseCode = objvVideoLib_Resource_RelENS.CourseCode; //课程代码
objvVideoLib_Resource_RelENT.CourseName = objvVideoLib_Resource_RelENS.CourseName; //课程名称
objvVideoLib_Resource_RelENT.BrowseCount4Case = objvVideoLib_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvVideoLib_Resource_RelENT.OwnerName = objvVideoLib_Resource_RelENS.OwnerName; //拥有者姓名
objvVideoLib_Resource_RelENT.OwnerNameWithId = objvVideoLib_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvVideoLib_Resource_RelENT.IdResource = objvVideoLib_Resource_RelENS.IdResource; //资源流水号
objvVideoLib_Resource_RelENT.ResourceID = objvVideoLib_Resource_RelENS.ResourceID; //资源ID
objvVideoLib_Resource_RelENT.ResourceName = objvVideoLib_Resource_RelENS.ResourceName; //资源名称
objvVideoLib_Resource_RelENT.SaveMode = objvVideoLib_Resource_RelENS.SaveMode; //文件存放方式
objvVideoLib_Resource_RelENT.IdFtpResource = objvVideoLib_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvVideoLib_Resource_RelENT.FtpResourceID = objvVideoLib_Resource_RelENS.FtpResourceID; //FTP资源ID
objvVideoLib_Resource_RelENT.FileOriginalName = objvVideoLib_Resource_RelENS.FileOriginalName; //文件原名
objvVideoLib_Resource_RelENT.FileDirName = objvVideoLib_Resource_RelENS.FileDirName; //文件目录名
objvVideoLib_Resource_RelENT.FileRename = objvVideoLib_Resource_RelENS.FileRename; //文件新名
objvVideoLib_Resource_RelENT.FileUpDate = objvVideoLib_Resource_RelENS.FileUpDate; //创建日期
objvVideoLib_Resource_RelENT.FileUpTime = objvVideoLib_Resource_RelENS.FileUpTime; //创建时间
objvVideoLib_Resource_RelENT.FileSize = objvVideoLib_Resource_RelENS.FileSize; //文件大小
objvVideoLib_Resource_RelENT.FileType = objvVideoLib_Resource_RelENS.FileType; //文件类型
objvVideoLib_Resource_RelENT.ResourceOwner = objvVideoLib_Resource_RelENS.ResourceOwner; //上传者
objvVideoLib_Resource_RelENT.IsExistFile = objvVideoLib_Resource_RelENS.IsExistFile; //是否存在文件
objvVideoLib_Resource_RelENT.IdFile = objvVideoLib_Resource_RelENS.IdFile; //文件流水号
objvVideoLib_Resource_RelENT.FileName = objvVideoLib_Resource_RelENS.FileName; //文件名称
objvVideoLib_Resource_RelENT.SaveDate = objvVideoLib_Resource_RelENS.SaveDate; //创建日期
objvVideoLib_Resource_RelENT.SaveTime = objvVideoLib_Resource_RelENS.SaveTime; //创建时间
objvVideoLib_Resource_RelENT.FileOriginName = objvVideoLib_Resource_RelENS.FileOriginName; //原文件名
objvVideoLib_Resource_RelENT.IdResourceType = objvVideoLib_Resource_RelENS.IdResourceType; //资源类型流水号
objvVideoLib_Resource_RelENT.ResourceTypeID = objvVideoLib_Resource_RelENS.ResourceTypeID; //资源类型ID
objvVideoLib_Resource_RelENT.ResourceTypeName = objvVideoLib_Resource_RelENS.ResourceTypeName; //资源类型名称
objvVideoLib_Resource_RelENT.FileNewName = objvVideoLib_Resource_RelENS.FileNewName; //新文件名
objvVideoLib_Resource_RelENT.FileOldName = objvVideoLib_Resource_RelENS.FileOldName; //旧文件名
objvVideoLib_Resource_RelENT.ftpFileType = objvVideoLib_Resource_RelENS.ftpFileType; //ftp文件类型
objvVideoLib_Resource_RelENT.ftpFileSize = objvVideoLib_Resource_RelENS.ftpFileSize; //ftp文件大小
objvVideoLib_Resource_RelENT.ftpResourceOwner = objvVideoLib_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoLib_Resource_RelENT.IsMain = objvVideoLib_Resource_RelENS.IsMain; //是否主资源
objvVideoLib_Resource_RelENT.IdUsingMode = objvVideoLib_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvVideoLib_Resource_RelENT.IsVisible = objvVideoLib_Resource_RelENS.IsVisible; //是否显示
objvVideoLib_Resource_RelENT.IndexNO = objvVideoLib_Resource_RelENS.IndexNO; //序号
objvVideoLib_Resource_RelENT.BrowseCount = objvVideoLib_Resource_RelENS.BrowseCount; //浏览次数
objvVideoLib_Resource_RelENT.UpdDate = objvVideoLib_Resource_RelENS.UpdDate; //修改日期
objvVideoLib_Resource_RelENT.UpdUser = objvVideoLib_Resource_RelENS.UpdUser; //修改人
objvVideoLib_Resource_RelENT.Memo = objvVideoLib_Resource_RelENS.Memo; //备注
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
 /// <param name = "objvVideoLib_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsvVideoLib_Resource_RelEN:objvVideoLib_Resource_RelENT</returns>
 public static clsvVideoLib_Resource_RelEN CopyTo(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelENS)
{
try
{
 clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelENT = new clsvVideoLib_Resource_RelEN()
{
IdMicroteachCaseResourceRel = objvVideoLib_Resource_RelENS.IdMicroteachCaseResourceRel, //微格案例资源关系流水号
FuncModuleId = objvVideoLib_Resource_RelENS.FuncModuleId, //功能模块Id
FuncModuleName = objvVideoLib_Resource_RelENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvVideoLib_Resource_RelENS.IdMicroteachCase, //微格教学案例流水号
VideoLibID = objvVideoLib_Resource_RelENS.VideoLibID, //视频库ID
VideoLibName = objvVideoLib_Resource_RelENS.VideoLibName, //视频名称
VideoLibTheme = objvVideoLib_Resource_RelENS.VideoLibTheme, //视频库主题词
IdVideoLibType = objvVideoLib_Resource_RelENS.IdVideoLibType, //视频库类型流水号
VideoLibTypeName = objvVideoLib_Resource_RelENS.VideoLibTypeName, //视频库类型名称
VideoLibText = objvVideoLib_Resource_RelENS.VideoLibText, //案例文本内容
VideoLibDate = objvVideoLib_Resource_RelENS.VideoLibDate, //视频资源日期
VideoLibTime = objvVideoLib_Resource_RelENS.VideoLibTime, //视频资源时间
VideoLibDateIn = objvVideoLib_Resource_RelENS.VideoLibDateIn, //案例入库日期
VideoLibTimeIn = objvVideoLib_Resource_RelENS.VideoLibTimeIn, //案例入库时间
OwnerId = objvVideoLib_Resource_RelENS.OwnerId, //拥有者Id
IdTeachingPlan = objvVideoLib_Resource_RelENS.IdTeachingPlan, //教案流水号
senateGaugeVersionID = objvVideoLib_Resource_RelENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvVideoLib_Resource_RelENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvVideoLib_Resource_RelENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvVideoLib_Resource_RelENS.VersionNo, //版本号
CaseLevelId = objvVideoLib_Resource_RelENS.CaseLevelId, //课例等级Id
IdXzCollege = objvVideoLib_Resource_RelENS.IdXzCollege, //学院流水号
CollegeID = objvVideoLib_Resource_RelENS.CollegeID, //学院ID
CollegeName = objvVideoLib_Resource_RelENS.CollegeName, //学院名称
CollegeNameA = objvVideoLib_Resource_RelENS.CollegeNameA, //学院名称简写
ViewCount = objvVideoLib_Resource_RelENS.ViewCount, //浏览量
DownloadNumber = objvVideoLib_Resource_RelENS.DownloadNumber, //下载数目
FileIntegration = objvVideoLib_Resource_RelENS.FileIntegration, //文件积分
LikeCount = objvVideoLib_Resource_RelENS.LikeCount, //资源喜欢数量
CollectionCount = objvVideoLib_Resource_RelENS.CollectionCount, //收藏数量
RecommendedDegreeId = objvVideoLib_Resource_RelENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvVideoLib_Resource_RelENS.RecommendedDegreeName, //推荐度名称
CourseId = objvVideoLib_Resource_RelENS.CourseId, //课程Id
CourseCode = objvVideoLib_Resource_RelENS.CourseCode, //课程代码
CourseName = objvVideoLib_Resource_RelENS.CourseName, //课程名称
BrowseCount4Case = objvVideoLib_Resource_RelENS.BrowseCount4Case, //课例浏览次数
OwnerName = objvVideoLib_Resource_RelENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvVideoLib_Resource_RelENS.OwnerNameWithId, //拥有者名称附Id
IdResource = objvVideoLib_Resource_RelENS.IdResource, //资源流水号
ResourceID = objvVideoLib_Resource_RelENS.ResourceID, //资源ID
ResourceName = objvVideoLib_Resource_RelENS.ResourceName, //资源名称
SaveMode = objvVideoLib_Resource_RelENS.SaveMode, //文件存放方式
IdFtpResource = objvVideoLib_Resource_RelENS.IdFtpResource, //FTP资源流水号
FtpResourceID = objvVideoLib_Resource_RelENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvVideoLib_Resource_RelENS.FileOriginalName, //文件原名
FileDirName = objvVideoLib_Resource_RelENS.FileDirName, //文件目录名
FileRename = objvVideoLib_Resource_RelENS.FileRename, //文件新名
FileUpDate = objvVideoLib_Resource_RelENS.FileUpDate, //创建日期
FileUpTime = objvVideoLib_Resource_RelENS.FileUpTime, //创建时间
FileSize = objvVideoLib_Resource_RelENS.FileSize, //文件大小
FileType = objvVideoLib_Resource_RelENS.FileType, //文件类型
ResourceOwner = objvVideoLib_Resource_RelENS.ResourceOwner, //上传者
IsExistFile = objvVideoLib_Resource_RelENS.IsExistFile, //是否存在文件
IdFile = objvVideoLib_Resource_RelENS.IdFile, //文件流水号
FileName = objvVideoLib_Resource_RelENS.FileName, //文件名称
SaveDate = objvVideoLib_Resource_RelENS.SaveDate, //创建日期
SaveTime = objvVideoLib_Resource_RelENS.SaveTime, //创建时间
FileOriginName = objvVideoLib_Resource_RelENS.FileOriginName, //原文件名
IdResourceType = objvVideoLib_Resource_RelENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvVideoLib_Resource_RelENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvVideoLib_Resource_RelENS.ResourceTypeName, //资源类型名称
FileNewName = objvVideoLib_Resource_RelENS.FileNewName, //新文件名
FileOldName = objvVideoLib_Resource_RelENS.FileOldName, //旧文件名
ftpFileType = objvVideoLib_Resource_RelENS.ftpFileType, //ftp文件类型
ftpFileSize = objvVideoLib_Resource_RelENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvVideoLib_Resource_RelENS.ftpResourceOwner, //Ftp资源拥有者
IsMain = objvVideoLib_Resource_RelENS.IsMain, //是否主资源
IdUsingMode = objvVideoLib_Resource_RelENS.IdUsingMode, //资源使用模式流水号
IsVisible = objvVideoLib_Resource_RelENS.IsVisible, //是否显示
IndexNO = objvVideoLib_Resource_RelENS.IndexNO, //序号
BrowseCount = objvVideoLib_Resource_RelENS.BrowseCount, //浏览次数
UpdDate = objvVideoLib_Resource_RelENS.UpdDate, //修改日期
UpdUser = objvVideoLib_Resource_RelENS.UpdUser, //修改人
Memo = objvVideoLib_Resource_RelENS.Memo, //备注
};
 return objvVideoLib_Resource_RelENT;
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
public static void CheckProperty4Condition(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN)
{
 clsvVideoLib_Resource_RelBL.vVideoLib_Resource_RelDA.CheckProperty4Condition(objvVideoLib_Resource_RelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel) == true)
{
string strComparisonOpIdMicroteachCaseResourceRel = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel, objvVideoLib_Resource_RelCond.IdMicroteachCaseResourceRel, strComparisonOpIdMicroteachCaseResourceRel);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FuncModuleId, objvVideoLib_Resource_RelCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FuncModuleName, objvVideoLib_Resource_RelCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.IdMicroteachCase, objvVideoLib_Resource_RelCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.VideoLibID) == true)
{
string strComparisonOpVideoLibID = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibID, objvVideoLib_Resource_RelCond.VideoLibID, strComparisonOpVideoLibID);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.VideoLibName) == true)
{
string strComparisonOpVideoLibName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibName, objvVideoLib_Resource_RelCond.VideoLibName, strComparisonOpVideoLibName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.VideoLibTheme) == true)
{
string strComparisonOpVideoLibTheme = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibTheme, objvVideoLib_Resource_RelCond.VideoLibTheme, strComparisonOpVideoLibTheme);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IdVideoLibType) == true)
{
string strComparisonOpIdVideoLibType = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.IdVideoLibType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.IdVideoLibType, objvVideoLib_Resource_RelCond.IdVideoLibType, strComparisonOpIdVideoLibType);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.VideoLibTypeName) == true)
{
string strComparisonOpVideoLibTypeName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibTypeName, objvVideoLib_Resource_RelCond.VideoLibTypeName, strComparisonOpVideoLibTypeName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.VideoLibText) == true)
{
string strComparisonOpVideoLibText = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibText, objvVideoLib_Resource_RelCond.VideoLibText, strComparisonOpVideoLibText);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.VideoLibDate) == true)
{
string strComparisonOpVideoLibDate = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibDate, objvVideoLib_Resource_RelCond.VideoLibDate, strComparisonOpVideoLibDate);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.VideoLibTime) == true)
{
string strComparisonOpVideoLibTime = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibTime, objvVideoLib_Resource_RelCond.VideoLibTime, strComparisonOpVideoLibTime);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.VideoLibDateIn) == true)
{
string strComparisonOpVideoLibDateIn = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibDateIn, objvVideoLib_Resource_RelCond.VideoLibDateIn, strComparisonOpVideoLibDateIn);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.VideoLibTimeIn) == true)
{
string strComparisonOpVideoLibTimeIn = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.VideoLibTimeIn, objvVideoLib_Resource_RelCond.VideoLibTimeIn, strComparisonOpVideoLibTimeIn);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.OwnerId) == true)
{
string strComparisonOpOwnerId = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.OwnerId, objvVideoLib_Resource_RelCond.OwnerId, strComparisonOpOwnerId);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.IdTeachingPlan, objvVideoLib_Resource_RelCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.senateGaugeVersionID, objvVideoLib_Resource_RelCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.senateGaugeVersionName, objvVideoLib_Resource_RelCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.senateGaugeVersionTtlScore, objvVideoLib_Resource_RelCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.VersionNo) == true)
{
string strComparisonOpVersionNo = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.VersionNo, objvVideoLib_Resource_RelCond.VersionNo, strComparisonOpVersionNo);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CaseLevelId, objvVideoLib_Resource_RelCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.IdXzCollege, objvVideoLib_Resource_RelCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.CollegeID) == true)
{
string strComparisonOpCollegeID = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CollegeID, objvVideoLib_Resource_RelCond.CollegeID, strComparisonOpCollegeID);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.CollegeName) == true)
{
string strComparisonOpCollegeName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CollegeName, objvVideoLib_Resource_RelCond.CollegeName, strComparisonOpCollegeName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CollegeNameA, objvVideoLib_Resource_RelCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.ViewCount) == true)
{
string strComparisonOpViewCount = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.ViewCount, objvVideoLib_Resource_RelCond.ViewCount, strComparisonOpViewCount);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.DownloadNumber, objvVideoLib_Resource_RelCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.FileIntegration, objvVideoLib_Resource_RelCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.LikeCount) == true)
{
string strComparisonOpLikeCount = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.LikeCount, objvVideoLib_Resource_RelCond.LikeCount, strComparisonOpLikeCount);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.CollectionCount, objvVideoLib_Resource_RelCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.RecommendedDegreeId, objvVideoLib_Resource_RelCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.RecommendedDegreeName, objvVideoLib_Resource_RelCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.CourseId) == true)
{
string strComparisonOpCourseId = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CourseId, objvVideoLib_Resource_RelCond.CourseId, strComparisonOpCourseId);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.CourseCode) == true)
{
string strComparisonOpCourseCode = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CourseCode, objvVideoLib_Resource_RelCond.CourseCode, strComparisonOpCourseCode);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.CourseName) == true)
{
string strComparisonOpCourseName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.CourseName, objvVideoLib_Resource_RelCond.CourseName, strComparisonOpCourseName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.BrowseCount4Case, objvVideoLib_Resource_RelCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.OwnerName) == true)
{
string strComparisonOpOwnerName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.OwnerName, objvVideoLib_Resource_RelCond.OwnerName, strComparisonOpOwnerName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.OwnerNameWithId, objvVideoLib_Resource_RelCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IdResource) == true)
{
string strComparisonOpIdResource = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.IdResource, objvVideoLib_Resource_RelCond.IdResource, strComparisonOpIdResource);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.ResourceID) == true)
{
string strComparisonOpResourceID = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ResourceID, objvVideoLib_Resource_RelCond.ResourceID, strComparisonOpResourceID);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.ResourceName) == true)
{
string strComparisonOpResourceName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ResourceName, objvVideoLib_Resource_RelCond.ResourceName, strComparisonOpResourceName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.SaveMode) == true)
{
if (objvVideoLib_Resource_RelCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib_Resource_Rel.SaveMode);
}
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.IdFtpResource, objvVideoLib_Resource_RelCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FtpResourceID, objvVideoLib_Resource_RelCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileOriginalName, objvVideoLib_Resource_RelCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileDirName) == true)
{
string strComparisonOpFileDirName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileDirName, objvVideoLib_Resource_RelCond.FileDirName, strComparisonOpFileDirName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileRename) == true)
{
string strComparisonOpFileRename = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileRename, objvVideoLib_Resource_RelCond.FileRename, strComparisonOpFileRename);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileUpDate, objvVideoLib_Resource_RelCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileUpTime, objvVideoLib_Resource_RelCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileSize) == true)
{
string strComparisonOpFileSize = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileSize, objvVideoLib_Resource_RelCond.FileSize, strComparisonOpFileSize);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileType) == true)
{
string strComparisonOpFileType = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileType, objvVideoLib_Resource_RelCond.FileType, strComparisonOpFileType);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ResourceOwner, objvVideoLib_Resource_RelCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IsExistFile) == true)
{
if (objvVideoLib_Resource_RelCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib_Resource_Rel.IsExistFile);
}
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IdFile) == true)
{
string strComparisonOpIdFile = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.IdFile, objvVideoLib_Resource_RelCond.IdFile, strComparisonOpIdFile);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileName) == true)
{
string strComparisonOpFileName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileName, objvVideoLib_Resource_RelCond.FileName, strComparisonOpFileName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.SaveDate) == true)
{
string strComparisonOpSaveDate = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.SaveDate, objvVideoLib_Resource_RelCond.SaveDate, strComparisonOpSaveDate);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.SaveTime) == true)
{
string strComparisonOpSaveTime = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.SaveTime, objvVideoLib_Resource_RelCond.SaveTime, strComparisonOpSaveTime);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileOriginName, objvVideoLib_Resource_RelCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.IdResourceType, objvVideoLib_Resource_RelCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ResourceTypeID, objvVideoLib_Resource_RelCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ResourceTypeName, objvVideoLib_Resource_RelCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileNewName) == true)
{
string strComparisonOpFileNewName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileNewName, objvVideoLib_Resource_RelCond.FileNewName, strComparisonOpFileNewName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.FileOldName) == true)
{
string strComparisonOpFileOldName = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.FileOldName, objvVideoLib_Resource_RelCond.FileOldName, strComparisonOpFileOldName);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ftpFileType, objvVideoLib_Resource_RelCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ftpFileSize, objvVideoLib_Resource_RelCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.ftpResourceOwner, objvVideoLib_Resource_RelCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IsMain) == true)
{
if (objvVideoLib_Resource_RelCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib_Resource_Rel.IsMain);
}
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IdUsingMode) == true)
{
string strComparisonOpIdUsingMode = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.IdUsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.IdUsingMode, objvVideoLib_Resource_RelCond.IdUsingMode, strComparisonOpIdUsingMode);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IsVisible) == true)
{
if (objvVideoLib_Resource_RelCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLib_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLib_Resource_Rel.IsVisible);
}
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.IndexNO) == true)
{
string strComparisonOpIndexNO = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.IndexNO, objvVideoLib_Resource_RelCond.IndexNO, strComparisonOpIndexNO);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLib_Resource_Rel.BrowseCount, objvVideoLib_Resource_RelCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.UpdDate) == true)
{
string strComparisonOpUpdDate = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.UpdDate, objvVideoLib_Resource_RelCond.UpdDate, strComparisonOpUpdDate);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.UpdUser) == true)
{
string strComparisonOpUpdUser = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.UpdUser, objvVideoLib_Resource_RelCond.UpdUser, strComparisonOpUpdUser);
}
if (objvVideoLib_Resource_RelCond.IsUpdated(convVideoLib_Resource_Rel.Memo) == true)
{
string strComparisonOpMemo = objvVideoLib_Resource_RelCond.dicFldComparisonOp[convVideoLib_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLib_Resource_Rel.Memo, objvVideoLib_Resource_RelCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vVideoLib_Resource_Rel
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v视频库资源关系(vVideoLib_Resource_Rel)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLib_Resource_RelBL
{
public static RelatedActions_vVideoLib_Resource_Rel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvVideoLib_Resource_RelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvVideoLib_Resource_RelDA vVideoLib_Resource_RelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvVideoLib_Resource_RelDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvVideoLib_Resource_RelBL()
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
if (string.IsNullOrEmpty(clsvVideoLib_Resource_RelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLib_Resource_RelEN._ConnectString);
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
public static DataTable GetDataTable_vVideoLib_Resource_Rel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vVideoLib_Resource_RelDA.GetDataTable_vVideoLib_Resource_Rel(strWhereCond);
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
objDT = vVideoLib_Resource_RelDA.GetDataTable(strWhereCond);
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
objDT = vVideoLib_Resource_RelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vVideoLib_Resource_RelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vVideoLib_Resource_RelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vVideoLib_Resource_RelDA.GetDataTable_Top(objTopPara);
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
objDT = vVideoLib_Resource_RelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vVideoLib_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vVideoLib_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvVideoLib_Resource_RelEN> GetObjLstByIdMicroteachCaseResourceRelLst(List<long> arrIdMicroteachCaseResourceRelLst)
{
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseResourceRelLst);
 string strWhereCond = string.Format("IdMicroteachCaseResourceRel in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvVideoLib_Resource_RelEN> GetObjLstByIdMicroteachCaseResourceRelLstCache(List<long> arrIdMicroteachCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsvVideoLib_Resource_RelEN._CurrTabName);
List<clsvVideoLib_Resource_RelEN> arrvVideoLib_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLib_Resource_RelEN> arrvVideoLib_Resource_RelObjLst_Sel =
arrvVideoLib_Resource_RelObjLstCache
.Where(x => arrIdMicroteachCaseResourceRelLst.Contains(x.IdMicroteachCaseResourceRel));
return arrvVideoLib_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLib_Resource_RelEN> GetObjLst(string strWhereCond)
{
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
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
public static List<clsvVideoLib_Resource_RelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvVideoLib_Resource_RelEN> GetSubObjLstCache(clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelCond)
{
List<clsvVideoLib_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLib_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLib_Resource_Rel.AttributeName)
{
if (objvVideoLib_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLib_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLib_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvVideoLib_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLib_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLib_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLib_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLib_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLib_Resource_RelCond[strFldName]));
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
public static List<clsvVideoLib_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
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
public static List<clsvVideoLib_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
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
List<clsvVideoLib_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvVideoLib_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLib_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvVideoLib_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
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
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
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
public static List<clsvVideoLib_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvVideoLib_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvVideoLib_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
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
public static List<clsvVideoLib_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLib_Resource_RelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvVideoLib_Resource_RelEN> arrObjLst = new List<clsvVideoLib_Resource_RelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = new clsvVideoLib_Resource_RelEN();
try
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvVideoLib_Resource_RelEN.FuncModuleId = objRow[convVideoLib_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLib_Resource_RelEN.FuncModuleName = objRow[convVideoLib_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLib_Resource_RelEN.IdMicroteachCase = objRow[convVideoLib_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLib_Resource_RelEN.VideoLibID = objRow[convVideoLib_Resource_Rel.VideoLibID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLib_Resource_RelEN.VideoLibName = objRow[convVideoLib_Resource_Rel.VideoLibName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibName].ToString().Trim(); //视频名称
objvVideoLib_Resource_RelEN.VideoLibTheme = objRow[convVideoLib_Resource_Rel.VideoLibTheme] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTheme].ToString().Trim(); //视频库主题词
objvVideoLib_Resource_RelEN.IdVideoLibType = objRow[convVideoLib_Resource_Rel.IdVideoLibType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objvVideoLib_Resource_RelEN.VideoLibTypeName = objRow[convVideoLib_Resource_Rel.VideoLibTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTypeName].ToString().Trim(); //视频库类型名称
objvVideoLib_Resource_RelEN.VideoLibText = objRow[convVideoLib_Resource_Rel.VideoLibText] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibText].ToString().Trim(); //案例文本内容
objvVideoLib_Resource_RelEN.VideoLibDate = objRow[convVideoLib_Resource_Rel.VideoLibDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDate].ToString().Trim(); //视频资源日期
objvVideoLib_Resource_RelEN.VideoLibTime = objRow[convVideoLib_Resource_Rel.VideoLibTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTime].ToString().Trim(); //视频资源时间
objvVideoLib_Resource_RelEN.VideoLibDateIn = objRow[convVideoLib_Resource_Rel.VideoLibDateIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibDateIn].ToString().Trim(); //案例入库日期
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objRow[convVideoLib_Resource_Rel.VideoLibTimeIn] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objvVideoLib_Resource_RelEN.OwnerId = objRow[convVideoLib_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvVideoLib_Resource_RelEN.IdTeachingPlan = objRow[convVideoLib_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objRow[convVideoLib_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objRow[convVideoLib_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLib_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoLib_Resource_RelEN.VersionNo = objRow[convVideoLib_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvVideoLib_Resource_RelEN.CaseLevelId = objRow[convVideoLib_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvVideoLib_Resource_RelEN.IdXzCollege = objRow[convVideoLib_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLib_Resource_RelEN.CollegeID = objRow[convVideoLib_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvVideoLib_Resource_RelEN.CollegeName = objRow[convVideoLib_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvVideoLib_Resource_RelEN.CollegeNameA = objRow[convVideoLib_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLib_Resource_RelEN.ViewCount = objRow[convVideoLib_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvVideoLib_Resource_RelEN.DownloadNumber = objRow[convVideoLib_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvVideoLib_Resource_RelEN.FileIntegration = objRow[convVideoLib_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvVideoLib_Resource_RelEN.LikeCount = objRow[convVideoLib_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvVideoLib_Resource_RelEN.CollectionCount = objRow[convVideoLib_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objRow[convVideoLib_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objRow[convVideoLib_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvVideoLib_Resource_RelEN.CourseId = objRow[convVideoLib_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvVideoLib_Resource_RelEN.CourseCode = objRow[convVideoLib_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvVideoLib_Resource_RelEN.CourseName = objRow[convVideoLib_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvVideoLib_Resource_RelEN.BrowseCount4Case = objRow[convVideoLib_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvVideoLib_Resource_RelEN.OwnerName = objRow[convVideoLib_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvVideoLib_Resource_RelEN.OwnerNameWithId = objRow[convVideoLib_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvVideoLib_Resource_RelEN.IdResource = objRow[convVideoLib_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvVideoLib_Resource_RelEN.ResourceID = objRow[convVideoLib_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvVideoLib_Resource_RelEN.ResourceName = objRow[convVideoLib_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvVideoLib_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLib_Resource_RelEN.IdFtpResource = objRow[convVideoLib_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLib_Resource_RelEN.FtpResourceID = objRow[convVideoLib_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLib_Resource_RelEN.FileOriginalName = objRow[convVideoLib_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLib_Resource_RelEN.FileDirName = objRow[convVideoLib_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvVideoLib_Resource_RelEN.FileRename = objRow[convVideoLib_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvVideoLib_Resource_RelEN.FileUpDate = objRow[convVideoLib_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.FileUpTime = objRow[convVideoLib_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileSize = objRow[convVideoLib_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvVideoLib_Resource_RelEN.FileType = objRow[convVideoLib_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvVideoLib_Resource_RelEN.ResourceOwner = objRow[convVideoLib_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvVideoLib_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLib_Resource_RelEN.IdFile = objRow[convVideoLib_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvVideoLib_Resource_RelEN.FileName = objRow[convVideoLib_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvVideoLib_Resource_RelEN.SaveDate = objRow[convVideoLib_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvVideoLib_Resource_RelEN.SaveTime = objRow[convVideoLib_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvVideoLib_Resource_RelEN.FileOriginName = objRow[convVideoLib_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvVideoLib_Resource_RelEN.IdResourceType = objRow[convVideoLib_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLib_Resource_RelEN.ResourceTypeID = objRow[convVideoLib_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLib_Resource_RelEN.ResourceTypeName = objRow[convVideoLib_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLib_Resource_RelEN.FileNewName = objRow[convVideoLib_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvVideoLib_Resource_RelEN.FileOldName = objRow[convVideoLib_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvVideoLib_Resource_RelEN.ftpFileType = objRow[convVideoLib_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLib_Resource_RelEN.ftpFileSize = objRow[convVideoLib_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLib_Resource_RelEN.ftpResourceOwner = objRow[convVideoLib_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLib_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvVideoLib_Resource_RelEN.IdUsingMode = objRow[convVideoLib_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvVideoLib_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLib_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvVideoLib_Resource_RelEN.IndexNO = objRow[convVideoLib_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvVideoLib_Resource_RelEN.BrowseCount = objRow[convVideoLib_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLib_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLib_Resource_RelEN.UpdDate = objRow[convVideoLib_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvVideoLib_Resource_RelEN.UpdUser = objRow[convVideoLib_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvVideoLib_Resource_RelEN.Memo = objRow[convVideoLib_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convVideoLib_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLib_Resource_RelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvVideoLib_Resource_Rel(ref clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN)
{
bool bolResult = vVideoLib_Resource_RelDA.GetvVideoLib_Resource_Rel(ref objvVideoLib_Resource_RelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLib_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = vVideoLib_Resource_RelDA.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
return objvVideoLib_Resource_RelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvVideoLib_Resource_RelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = vVideoLib_Resource_RelDA.GetFirstObj(strWhereCond);
 return objvVideoLib_Resource_RelEN;
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
public static clsvVideoLib_Resource_RelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = vVideoLib_Resource_RelDA.GetObjByDataRow(objRow);
 return objvVideoLib_Resource_RelEN;
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
public static clsvVideoLib_Resource_RelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN = vVideoLib_Resource_RelDA.GetObjByDataRow(objRow);
 return objvVideoLib_Resource_RelEN;
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
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <param name = "lstvVideoLib_Resource_RelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLib_Resource_RelEN GetObjByIdMicroteachCaseResourceRelFromList(long lngIdMicroteachCaseResourceRel, List<clsvVideoLib_Resource_RelEN> lstvVideoLib_Resource_RelObjLst)
{
foreach (clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN in lstvVideoLib_Resource_RelObjLst)
{
if (objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel)
{
return objvVideoLib_Resource_RelEN;
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
 long lngIdMicroteachCaseResourceRel;
 try
 {
 lngIdMicroteachCaseResourceRel = new clsvVideoLib_Resource_RelDA().GetFirstID(strWhereCond);
 return lngIdMicroteachCaseResourceRel;
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
 arrList = vVideoLib_Resource_RelDA.GetID(strWhereCond);
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
bool bolIsExist = vVideoLib_Resource_RelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachCaseResourceRel)
{
//检测记录是否存在
bool bolIsExist = vVideoLib_Resource_RelDA.IsExist(lngIdMicroteachCaseResourceRel);
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
 bolIsExist = clsvVideoLib_Resource_RelDA.IsExistTable();
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
 bolIsExist = vVideoLib_Resource_RelDA.IsExistTable(strTabName);
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
 /// <param name = "objvVideoLib_Resource_RelENS">源对象</param>
 /// <param name = "objvVideoLib_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelENS, clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelENT)
{
try
{
objvVideoLib_Resource_RelENT.IdMicroteachCaseResourceRel = objvVideoLib_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvVideoLib_Resource_RelENT.FuncModuleId = objvVideoLib_Resource_RelENS.FuncModuleId; //功能模块Id
objvVideoLib_Resource_RelENT.FuncModuleName = objvVideoLib_Resource_RelENS.FuncModuleName; //功能模块名称
objvVideoLib_Resource_RelENT.IdMicroteachCase = objvVideoLib_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLib_Resource_RelENT.VideoLibID = objvVideoLib_Resource_RelENS.VideoLibID; //视频库ID
objvVideoLib_Resource_RelENT.VideoLibName = objvVideoLib_Resource_RelENS.VideoLibName; //视频名称
objvVideoLib_Resource_RelENT.VideoLibTheme = objvVideoLib_Resource_RelENS.VideoLibTheme; //视频库主题词
objvVideoLib_Resource_RelENT.IdVideoLibType = objvVideoLib_Resource_RelENS.IdVideoLibType; //视频库类型流水号
objvVideoLib_Resource_RelENT.VideoLibTypeName = objvVideoLib_Resource_RelENS.VideoLibTypeName; //视频库类型名称
objvVideoLib_Resource_RelENT.VideoLibText = objvVideoLib_Resource_RelENS.VideoLibText; //案例文本内容
objvVideoLib_Resource_RelENT.VideoLibDate = objvVideoLib_Resource_RelENS.VideoLibDate; //视频资源日期
objvVideoLib_Resource_RelENT.VideoLibTime = objvVideoLib_Resource_RelENS.VideoLibTime; //视频资源时间
objvVideoLib_Resource_RelENT.VideoLibDateIn = objvVideoLib_Resource_RelENS.VideoLibDateIn; //案例入库日期
objvVideoLib_Resource_RelENT.VideoLibTimeIn = objvVideoLib_Resource_RelENS.VideoLibTimeIn; //案例入库时间
objvVideoLib_Resource_RelENT.OwnerId = objvVideoLib_Resource_RelENS.OwnerId; //拥有者Id
objvVideoLib_Resource_RelENT.IdTeachingPlan = objvVideoLib_Resource_RelENS.IdTeachingPlan; //教案流水号
objvVideoLib_Resource_RelENT.senateGaugeVersionID = objvVideoLib_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvVideoLib_Resource_RelENT.senateGaugeVersionName = objvVideoLib_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLib_Resource_RelENT.senateGaugeVersionTtlScore = objvVideoLib_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoLib_Resource_RelENT.VersionNo = objvVideoLib_Resource_RelENS.VersionNo; //版本号
objvVideoLib_Resource_RelENT.CaseLevelId = objvVideoLib_Resource_RelENS.CaseLevelId; //课例等级Id
objvVideoLib_Resource_RelENT.IdXzCollege = objvVideoLib_Resource_RelENS.IdXzCollege; //学院流水号
objvVideoLib_Resource_RelENT.CollegeID = objvVideoLib_Resource_RelENS.CollegeID; //学院ID
objvVideoLib_Resource_RelENT.CollegeName = objvVideoLib_Resource_RelENS.CollegeName; //学院名称
objvVideoLib_Resource_RelENT.CollegeNameA = objvVideoLib_Resource_RelENS.CollegeNameA; //学院名称简写
objvVideoLib_Resource_RelENT.ViewCount = objvVideoLib_Resource_RelENS.ViewCount; //浏览量
objvVideoLib_Resource_RelENT.DownloadNumber = objvVideoLib_Resource_RelENS.DownloadNumber; //下载数目
objvVideoLib_Resource_RelENT.FileIntegration = objvVideoLib_Resource_RelENS.FileIntegration; //文件积分
objvVideoLib_Resource_RelENT.LikeCount = objvVideoLib_Resource_RelENS.LikeCount; //资源喜欢数量
objvVideoLib_Resource_RelENT.CollectionCount = objvVideoLib_Resource_RelENS.CollectionCount; //收藏数量
objvVideoLib_Resource_RelENT.RecommendedDegreeId = objvVideoLib_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvVideoLib_Resource_RelENT.RecommendedDegreeName = objvVideoLib_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvVideoLib_Resource_RelENT.CourseId = objvVideoLib_Resource_RelENS.CourseId; //课程Id
objvVideoLib_Resource_RelENT.CourseCode = objvVideoLib_Resource_RelENS.CourseCode; //课程代码
objvVideoLib_Resource_RelENT.CourseName = objvVideoLib_Resource_RelENS.CourseName; //课程名称
objvVideoLib_Resource_RelENT.BrowseCount4Case = objvVideoLib_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvVideoLib_Resource_RelENT.OwnerName = objvVideoLib_Resource_RelENS.OwnerName; //拥有者姓名
objvVideoLib_Resource_RelENT.OwnerNameWithId = objvVideoLib_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvVideoLib_Resource_RelENT.IdResource = objvVideoLib_Resource_RelENS.IdResource; //资源流水号
objvVideoLib_Resource_RelENT.ResourceID = objvVideoLib_Resource_RelENS.ResourceID; //资源ID
objvVideoLib_Resource_RelENT.ResourceName = objvVideoLib_Resource_RelENS.ResourceName; //资源名称
objvVideoLib_Resource_RelENT.SaveMode = objvVideoLib_Resource_RelENS.SaveMode; //文件存放方式
objvVideoLib_Resource_RelENT.IdFtpResource = objvVideoLib_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvVideoLib_Resource_RelENT.FtpResourceID = objvVideoLib_Resource_RelENS.FtpResourceID; //FTP资源ID
objvVideoLib_Resource_RelENT.FileOriginalName = objvVideoLib_Resource_RelENS.FileOriginalName; //文件原名
objvVideoLib_Resource_RelENT.FileDirName = objvVideoLib_Resource_RelENS.FileDirName; //文件目录名
objvVideoLib_Resource_RelENT.FileRename = objvVideoLib_Resource_RelENS.FileRename; //文件新名
objvVideoLib_Resource_RelENT.FileUpDate = objvVideoLib_Resource_RelENS.FileUpDate; //创建日期
objvVideoLib_Resource_RelENT.FileUpTime = objvVideoLib_Resource_RelENS.FileUpTime; //创建时间
objvVideoLib_Resource_RelENT.FileSize = objvVideoLib_Resource_RelENS.FileSize; //文件大小
objvVideoLib_Resource_RelENT.FileType = objvVideoLib_Resource_RelENS.FileType; //文件类型
objvVideoLib_Resource_RelENT.ResourceOwner = objvVideoLib_Resource_RelENS.ResourceOwner; //上传者
objvVideoLib_Resource_RelENT.IsExistFile = objvVideoLib_Resource_RelENS.IsExistFile; //是否存在文件
objvVideoLib_Resource_RelENT.IdFile = objvVideoLib_Resource_RelENS.IdFile; //文件流水号
objvVideoLib_Resource_RelENT.FileName = objvVideoLib_Resource_RelENS.FileName; //文件名称
objvVideoLib_Resource_RelENT.SaveDate = objvVideoLib_Resource_RelENS.SaveDate; //创建日期
objvVideoLib_Resource_RelENT.SaveTime = objvVideoLib_Resource_RelENS.SaveTime; //创建时间
objvVideoLib_Resource_RelENT.FileOriginName = objvVideoLib_Resource_RelENS.FileOriginName; //原文件名
objvVideoLib_Resource_RelENT.IdResourceType = objvVideoLib_Resource_RelENS.IdResourceType; //资源类型流水号
objvVideoLib_Resource_RelENT.ResourceTypeID = objvVideoLib_Resource_RelENS.ResourceTypeID; //资源类型ID
objvVideoLib_Resource_RelENT.ResourceTypeName = objvVideoLib_Resource_RelENS.ResourceTypeName; //资源类型名称
objvVideoLib_Resource_RelENT.FileNewName = objvVideoLib_Resource_RelENS.FileNewName; //新文件名
objvVideoLib_Resource_RelENT.FileOldName = objvVideoLib_Resource_RelENS.FileOldName; //旧文件名
objvVideoLib_Resource_RelENT.ftpFileType = objvVideoLib_Resource_RelENS.ftpFileType; //ftp文件类型
objvVideoLib_Resource_RelENT.ftpFileSize = objvVideoLib_Resource_RelENS.ftpFileSize; //ftp文件大小
objvVideoLib_Resource_RelENT.ftpResourceOwner = objvVideoLib_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoLib_Resource_RelENT.IsMain = objvVideoLib_Resource_RelENS.IsMain; //是否主资源
objvVideoLib_Resource_RelENT.IdUsingMode = objvVideoLib_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvVideoLib_Resource_RelENT.IsVisible = objvVideoLib_Resource_RelENS.IsVisible; //是否显示
objvVideoLib_Resource_RelENT.IndexNO = objvVideoLib_Resource_RelENS.IndexNO; //序号
objvVideoLib_Resource_RelENT.BrowseCount = objvVideoLib_Resource_RelENS.BrowseCount; //浏览次数
objvVideoLib_Resource_RelENT.UpdDate = objvVideoLib_Resource_RelENS.UpdDate; //修改日期
objvVideoLib_Resource_RelENT.UpdUser = objvVideoLib_Resource_RelENS.UpdUser; //修改人
objvVideoLib_Resource_RelENT.Memo = objvVideoLib_Resource_RelENS.Memo; //备注
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
 /// <param name = "objvVideoLib_Resource_RelEN">源简化对象</param>
 public static void SetUpdFlag(clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN)
{
try
{
objvVideoLib_Resource_RelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvVideoLib_Resource_RelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel = objvVideoLib_Resource_RelEN.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FuncModuleId = objvVideoLib_Resource_RelEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FuncModuleName = objvVideoLib_Resource_RelEN.FuncModuleName == "[null]" ? null :  objvVideoLib_Resource_RelEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IdMicroteachCase = objvVideoLib_Resource_RelEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.VideoLibID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.VideoLibID = objvVideoLib_Resource_RelEN.VideoLibID == "[null]" ? null :  objvVideoLib_Resource_RelEN.VideoLibID; //视频库ID
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.VideoLibName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.VideoLibName = objvVideoLib_Resource_RelEN.VideoLibName == "[null]" ? null :  objvVideoLib_Resource_RelEN.VideoLibName; //视频名称
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.VideoLibTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.VideoLibTheme = objvVideoLib_Resource_RelEN.VideoLibTheme == "[null]" ? null :  objvVideoLib_Resource_RelEN.VideoLibTheme; //视频库主题词
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IdVideoLibType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IdVideoLibType = objvVideoLib_Resource_RelEN.IdVideoLibType == "[null]" ? null :  objvVideoLib_Resource_RelEN.IdVideoLibType; //视频库类型流水号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.VideoLibTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.VideoLibTypeName = objvVideoLib_Resource_RelEN.VideoLibTypeName == "[null]" ? null :  objvVideoLib_Resource_RelEN.VideoLibTypeName; //视频库类型名称
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.VideoLibText, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.VideoLibText = objvVideoLib_Resource_RelEN.VideoLibText == "[null]" ? null :  objvVideoLib_Resource_RelEN.VideoLibText; //案例文本内容
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.VideoLibDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.VideoLibDate = objvVideoLib_Resource_RelEN.VideoLibDate == "[null]" ? null :  objvVideoLib_Resource_RelEN.VideoLibDate; //视频资源日期
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.VideoLibTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.VideoLibTime = objvVideoLib_Resource_RelEN.VideoLibTime == "[null]" ? null :  objvVideoLib_Resource_RelEN.VideoLibTime; //视频资源时间
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.VideoLibDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.VideoLibDateIn = objvVideoLib_Resource_RelEN.VideoLibDateIn == "[null]" ? null :  objvVideoLib_Resource_RelEN.VideoLibDateIn; //案例入库日期
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.VideoLibTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.VideoLibTimeIn = objvVideoLib_Resource_RelEN.VideoLibTimeIn == "[null]" ? null :  objvVideoLib_Resource_RelEN.VideoLibTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.OwnerId = objvVideoLib_Resource_RelEN.OwnerId == "[null]" ? null :  objvVideoLib_Resource_RelEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IdTeachingPlan = objvVideoLib_Resource_RelEN.IdTeachingPlan == "[null]" ? null :  objvVideoLib_Resource_RelEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.senateGaugeVersionID = objvVideoLib_Resource_RelEN.senateGaugeVersionID == "[null]" ? null :  objvVideoLib_Resource_RelEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.senateGaugeVersionName = objvVideoLib_Resource_RelEN.senateGaugeVersionName == "[null]" ? null :  objvVideoLib_Resource_RelEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore = objvVideoLib_Resource_RelEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.VersionNo = objvVideoLib_Resource_RelEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.CaseLevelId = objvVideoLib_Resource_RelEN.CaseLevelId == "[null]" ? null :  objvVideoLib_Resource_RelEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IdXzCollege = objvVideoLib_Resource_RelEN.IdXzCollege == "[null]" ? null :  objvVideoLib_Resource_RelEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.CollegeID = objvVideoLib_Resource_RelEN.CollegeID == "[null]" ? null :  objvVideoLib_Resource_RelEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.CollegeName = objvVideoLib_Resource_RelEN.CollegeName == "[null]" ? null :  objvVideoLib_Resource_RelEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.CollegeNameA = objvVideoLib_Resource_RelEN.CollegeNameA == "[null]" ? null :  objvVideoLib_Resource_RelEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.ViewCount = objvVideoLib_Resource_RelEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.DownloadNumber = objvVideoLib_Resource_RelEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileIntegration = objvVideoLib_Resource_RelEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.LikeCount = objvVideoLib_Resource_RelEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.CollectionCount = objvVideoLib_Resource_RelEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.RecommendedDegreeId = objvVideoLib_Resource_RelEN.RecommendedDegreeId == "[null]" ? null :  objvVideoLib_Resource_RelEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.RecommendedDegreeName = objvVideoLib_Resource_RelEN.RecommendedDegreeName == "[null]" ? null :  objvVideoLib_Resource_RelEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.CourseId = objvVideoLib_Resource_RelEN.CourseId == "[null]" ? null :  objvVideoLib_Resource_RelEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.CourseCode = objvVideoLib_Resource_RelEN.CourseCode == "[null]" ? null :  objvVideoLib_Resource_RelEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.CourseName = objvVideoLib_Resource_RelEN.CourseName == "[null]" ? null :  objvVideoLib_Resource_RelEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.BrowseCount4Case = objvVideoLib_Resource_RelEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.OwnerName = objvVideoLib_Resource_RelEN.OwnerName == "[null]" ? null :  objvVideoLib_Resource_RelEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.OwnerNameWithId = objvVideoLib_Resource_RelEN.OwnerNameWithId == "[null]" ? null :  objvVideoLib_Resource_RelEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IdResource = objvVideoLib_Resource_RelEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.ResourceID = objvVideoLib_Resource_RelEN.ResourceID == "[null]" ? null :  objvVideoLib_Resource_RelEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.ResourceName = objvVideoLib_Resource_RelEN.ResourceName == "[null]" ? null :  objvVideoLib_Resource_RelEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.SaveMode = objvVideoLib_Resource_RelEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IdFtpResource = objvVideoLib_Resource_RelEN.IdFtpResource == "[null]" ? null :  objvVideoLib_Resource_RelEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FtpResourceID = objvVideoLib_Resource_RelEN.FtpResourceID == "[null]" ? null :  objvVideoLib_Resource_RelEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileOriginalName = objvVideoLib_Resource_RelEN.FileOriginalName == "[null]" ? null :  objvVideoLib_Resource_RelEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileDirName = objvVideoLib_Resource_RelEN.FileDirName == "[null]" ? null :  objvVideoLib_Resource_RelEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileRename = objvVideoLib_Resource_RelEN.FileRename == "[null]" ? null :  objvVideoLib_Resource_RelEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileUpDate = objvVideoLib_Resource_RelEN.FileUpDate == "[null]" ? null :  objvVideoLib_Resource_RelEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileUpTime = objvVideoLib_Resource_RelEN.FileUpTime == "[null]" ? null :  objvVideoLib_Resource_RelEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileSize = objvVideoLib_Resource_RelEN.FileSize == "[null]" ? null :  objvVideoLib_Resource_RelEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileType = objvVideoLib_Resource_RelEN.FileType == "[null]" ? null :  objvVideoLib_Resource_RelEN.FileType; //文件类型
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.ResourceOwner = objvVideoLib_Resource_RelEN.ResourceOwner == "[null]" ? null :  objvVideoLib_Resource_RelEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IsExistFile = objvVideoLib_Resource_RelEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IdFile = objvVideoLib_Resource_RelEN.IdFile == "[null]" ? null :  objvVideoLib_Resource_RelEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileName = objvVideoLib_Resource_RelEN.FileName == "[null]" ? null :  objvVideoLib_Resource_RelEN.FileName; //文件名称
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.SaveDate = objvVideoLib_Resource_RelEN.SaveDate == "[null]" ? null :  objvVideoLib_Resource_RelEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.SaveTime = objvVideoLib_Resource_RelEN.SaveTime == "[null]" ? null :  objvVideoLib_Resource_RelEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileOriginName = objvVideoLib_Resource_RelEN.FileOriginName == "[null]" ? null :  objvVideoLib_Resource_RelEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IdResourceType = objvVideoLib_Resource_RelEN.IdResourceType == "[null]" ? null :  objvVideoLib_Resource_RelEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.ResourceTypeID = objvVideoLib_Resource_RelEN.ResourceTypeID == "[null]" ? null :  objvVideoLib_Resource_RelEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.ResourceTypeName = objvVideoLib_Resource_RelEN.ResourceTypeName == "[null]" ? null :  objvVideoLib_Resource_RelEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileNewName = objvVideoLib_Resource_RelEN.FileNewName == "[null]" ? null :  objvVideoLib_Resource_RelEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.FileOldName = objvVideoLib_Resource_RelEN.FileOldName == "[null]" ? null :  objvVideoLib_Resource_RelEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.ftpFileType = objvVideoLib_Resource_RelEN.ftpFileType == "[null]" ? null :  objvVideoLib_Resource_RelEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.ftpFileSize = objvVideoLib_Resource_RelEN.ftpFileSize == "[null]" ? null :  objvVideoLib_Resource_RelEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.ftpResourceOwner = objvVideoLib_Resource_RelEN.ftpResourceOwner == "[null]" ? null :  objvVideoLib_Resource_RelEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IsMain = objvVideoLib_Resource_RelEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IdUsingMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IdUsingMode = objvVideoLib_Resource_RelEN.IdUsingMode == "[null]" ? null :  objvVideoLib_Resource_RelEN.IdUsingMode; //资源使用模式流水号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IsVisible = objvVideoLib_Resource_RelEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.IndexNO = objvVideoLib_Resource_RelEN.IndexNO; //序号
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.BrowseCount = objvVideoLib_Resource_RelEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.UpdDate = objvVideoLib_Resource_RelEN.UpdDate == "[null]" ? null :  objvVideoLib_Resource_RelEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.UpdUser = objvVideoLib_Resource_RelEN.UpdUser == "[null]" ? null :  objvVideoLib_Resource_RelEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convVideoLib_Resource_Rel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLib_Resource_RelEN.Memo = objvVideoLib_Resource_RelEN.Memo == "[null]" ? null :  objvVideoLib_Resource_RelEN.Memo; //备注
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
 /// <param name = "objvVideoLib_Resource_RelEN">源简化对象</param>
 public static void AccessFldValueNull(clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN)
{
try
{
if (objvVideoLib_Resource_RelEN.FuncModuleName == "[null]") objvVideoLib_Resource_RelEN.FuncModuleName = null; //功能模块名称
if (objvVideoLib_Resource_RelEN.VideoLibID == "[null]") objvVideoLib_Resource_RelEN.VideoLibID = null; //视频库ID
if (objvVideoLib_Resource_RelEN.VideoLibName == "[null]") objvVideoLib_Resource_RelEN.VideoLibName = null; //视频名称
if (objvVideoLib_Resource_RelEN.VideoLibTheme == "[null]") objvVideoLib_Resource_RelEN.VideoLibTheme = null; //视频库主题词
if (objvVideoLib_Resource_RelEN.IdVideoLibType == "[null]") objvVideoLib_Resource_RelEN.IdVideoLibType = null; //视频库类型流水号
if (objvVideoLib_Resource_RelEN.VideoLibTypeName == "[null]") objvVideoLib_Resource_RelEN.VideoLibTypeName = null; //视频库类型名称
if (objvVideoLib_Resource_RelEN.VideoLibText == "[null]") objvVideoLib_Resource_RelEN.VideoLibText = null; //案例文本内容
if (objvVideoLib_Resource_RelEN.VideoLibDate == "[null]") objvVideoLib_Resource_RelEN.VideoLibDate = null; //视频资源日期
if (objvVideoLib_Resource_RelEN.VideoLibTime == "[null]") objvVideoLib_Resource_RelEN.VideoLibTime = null; //视频资源时间
if (objvVideoLib_Resource_RelEN.VideoLibDateIn == "[null]") objvVideoLib_Resource_RelEN.VideoLibDateIn = null; //案例入库日期
if (objvVideoLib_Resource_RelEN.VideoLibTimeIn == "[null]") objvVideoLib_Resource_RelEN.VideoLibTimeIn = null; //案例入库时间
if (objvVideoLib_Resource_RelEN.OwnerId == "[null]") objvVideoLib_Resource_RelEN.OwnerId = null; //拥有者Id
if (objvVideoLib_Resource_RelEN.IdTeachingPlan == "[null]") objvVideoLib_Resource_RelEN.IdTeachingPlan = null; //教案流水号
if (objvVideoLib_Resource_RelEN.senateGaugeVersionID == "[null]") objvVideoLib_Resource_RelEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvVideoLib_Resource_RelEN.senateGaugeVersionName == "[null]") objvVideoLib_Resource_RelEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvVideoLib_Resource_RelEN.CaseLevelId == "[null]") objvVideoLib_Resource_RelEN.CaseLevelId = null; //课例等级Id
if (objvVideoLib_Resource_RelEN.IdXzCollege == "[null]") objvVideoLib_Resource_RelEN.IdXzCollege = null; //学院流水号
if (objvVideoLib_Resource_RelEN.CollegeID == "[null]") objvVideoLib_Resource_RelEN.CollegeID = null; //学院ID
if (objvVideoLib_Resource_RelEN.CollegeName == "[null]") objvVideoLib_Resource_RelEN.CollegeName = null; //学院名称
if (objvVideoLib_Resource_RelEN.CollegeNameA == "[null]") objvVideoLib_Resource_RelEN.CollegeNameA = null; //学院名称简写
if (objvVideoLib_Resource_RelEN.RecommendedDegreeId == "[null]") objvVideoLib_Resource_RelEN.RecommendedDegreeId = null; //推荐度Id
if (objvVideoLib_Resource_RelEN.RecommendedDegreeName == "[null]") objvVideoLib_Resource_RelEN.RecommendedDegreeName = null; //推荐度名称
if (objvVideoLib_Resource_RelEN.CourseId == "[null]") objvVideoLib_Resource_RelEN.CourseId = null; //课程Id
if (objvVideoLib_Resource_RelEN.CourseCode == "[null]") objvVideoLib_Resource_RelEN.CourseCode = null; //课程代码
if (objvVideoLib_Resource_RelEN.CourseName == "[null]") objvVideoLib_Resource_RelEN.CourseName = null; //课程名称
if (objvVideoLib_Resource_RelEN.OwnerName == "[null]") objvVideoLib_Resource_RelEN.OwnerName = null; //拥有者姓名
if (objvVideoLib_Resource_RelEN.OwnerNameWithId == "[null]") objvVideoLib_Resource_RelEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvVideoLib_Resource_RelEN.ResourceID == "[null]") objvVideoLib_Resource_RelEN.ResourceID = null; //资源ID
if (objvVideoLib_Resource_RelEN.ResourceName == "[null]") objvVideoLib_Resource_RelEN.ResourceName = null; //资源名称
if (objvVideoLib_Resource_RelEN.IdFtpResource == "[null]") objvVideoLib_Resource_RelEN.IdFtpResource = null; //FTP资源流水号
if (objvVideoLib_Resource_RelEN.FtpResourceID == "[null]") objvVideoLib_Resource_RelEN.FtpResourceID = null; //FTP资源ID
if (objvVideoLib_Resource_RelEN.FileOriginalName == "[null]") objvVideoLib_Resource_RelEN.FileOriginalName = null; //文件原名
if (objvVideoLib_Resource_RelEN.FileDirName == "[null]") objvVideoLib_Resource_RelEN.FileDirName = null; //文件目录名
if (objvVideoLib_Resource_RelEN.FileRename == "[null]") objvVideoLib_Resource_RelEN.FileRename = null; //文件新名
if (objvVideoLib_Resource_RelEN.FileUpDate == "[null]") objvVideoLib_Resource_RelEN.FileUpDate = null; //创建日期
if (objvVideoLib_Resource_RelEN.FileUpTime == "[null]") objvVideoLib_Resource_RelEN.FileUpTime = null; //创建时间
if (objvVideoLib_Resource_RelEN.FileSize == "[null]") objvVideoLib_Resource_RelEN.FileSize = null; //文件大小
if (objvVideoLib_Resource_RelEN.FileType == "[null]") objvVideoLib_Resource_RelEN.FileType = null; //文件类型
if (objvVideoLib_Resource_RelEN.ResourceOwner == "[null]") objvVideoLib_Resource_RelEN.ResourceOwner = null; //上传者
if (objvVideoLib_Resource_RelEN.IdFile == "[null]") objvVideoLib_Resource_RelEN.IdFile = null; //文件流水号
if (objvVideoLib_Resource_RelEN.FileName == "[null]") objvVideoLib_Resource_RelEN.FileName = null; //文件名称
if (objvVideoLib_Resource_RelEN.SaveDate == "[null]") objvVideoLib_Resource_RelEN.SaveDate = null; //创建日期
if (objvVideoLib_Resource_RelEN.SaveTime == "[null]") objvVideoLib_Resource_RelEN.SaveTime = null; //创建时间
if (objvVideoLib_Resource_RelEN.FileOriginName == "[null]") objvVideoLib_Resource_RelEN.FileOriginName = null; //原文件名
if (objvVideoLib_Resource_RelEN.IdResourceType == "[null]") objvVideoLib_Resource_RelEN.IdResourceType = null; //资源类型流水号
if (objvVideoLib_Resource_RelEN.ResourceTypeID == "[null]") objvVideoLib_Resource_RelEN.ResourceTypeID = null; //资源类型ID
if (objvVideoLib_Resource_RelEN.ResourceTypeName == "[null]") objvVideoLib_Resource_RelEN.ResourceTypeName = null; //资源类型名称
if (objvVideoLib_Resource_RelEN.FileNewName == "[null]") objvVideoLib_Resource_RelEN.FileNewName = null; //新文件名
if (objvVideoLib_Resource_RelEN.FileOldName == "[null]") objvVideoLib_Resource_RelEN.FileOldName = null; //旧文件名
if (objvVideoLib_Resource_RelEN.ftpFileType == "[null]") objvVideoLib_Resource_RelEN.ftpFileType = null; //ftp文件类型
if (objvVideoLib_Resource_RelEN.ftpFileSize == "[null]") objvVideoLib_Resource_RelEN.ftpFileSize = null; //ftp文件大小
if (objvVideoLib_Resource_RelEN.ftpResourceOwner == "[null]") objvVideoLib_Resource_RelEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvVideoLib_Resource_RelEN.IdUsingMode == "[null]") objvVideoLib_Resource_RelEN.IdUsingMode = null; //资源使用模式流水号
if (objvVideoLib_Resource_RelEN.UpdDate == "[null]") objvVideoLib_Resource_RelEN.UpdDate = null; //修改日期
if (objvVideoLib_Resource_RelEN.UpdUser == "[null]") objvVideoLib_Resource_RelEN.UpdUser = null; //修改人
if (objvVideoLib_Resource_RelEN.Memo == "[null]") objvVideoLib_Resource_RelEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelEN)
{
 vVideoLib_Resource_RelDA.CheckProperty4Condition(objvVideoLib_Resource_RelEN);
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
if (clsMicroteachCase_Resource_RelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCase_Resource_RelBL没有刷新缓存机制(clsMicroteachCase_Resource_RelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceBL没有刷新缓存机制(clsResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerBL没有刷新缓存机制(clsFileServerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceBL没有刷新缓存机制(clsFtpResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCaseResourceRel");
//if (arrvVideoLib_Resource_RelObjLstCache == null)
//{
//arrvVideoLib_Resource_RelObjLstCache = vVideoLib_Resource_RelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLib_Resource_RelEN GetObjByIdMicroteachCaseResourceRelCache(long lngIdMicroteachCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvVideoLib_Resource_RelEN._CurrTabName);
List<clsvVideoLib_Resource_RelEN> arrvVideoLib_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLib_Resource_RelEN> arrvVideoLib_Resource_RelObjLst_Sel =
arrvVideoLib_Resource_RelObjLstCache
.Where(x=> x.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel 
);
if (arrvVideoLib_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvVideoLib_Resource_RelEN obj = clsvVideoLib_Resource_RelBL.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvVideoLib_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLib_Resource_RelEN> GetAllvVideoLib_Resource_RelObjLstCache()
{
//获取缓存中的对象列表
List<clsvVideoLib_Resource_RelEN> arrvVideoLib_Resource_RelObjLstCache = GetObjLstCache(); 
return arrvVideoLib_Resource_RelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLib_Resource_RelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLib_Resource_RelEN._CurrTabName);
List<clsvVideoLib_Resource_RelEN> arrvVideoLib_Resource_RelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLib_Resource_RelObjLstCache;
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
string strKey = string.Format("{0}", clsvVideoLib_Resource_RelEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachCaseResourceRel)
{
if (strInFldName != convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convVideoLib_Resource_Rel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convVideoLib_Resource_Rel.AttributeName));
throw new Exception(strMsg);
}
var objvVideoLib_Resource_Rel = clsvVideoLib_Resource_RelBL.GetObjByIdMicroteachCaseResourceRelCache(lngIdMicroteachCaseResourceRel);
if (objvVideoLib_Resource_Rel == null) return "";
return objvVideoLib_Resource_Rel[strOutFldName].ToString();
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
int intRecCount = clsvVideoLib_Resource_RelDA.GetRecCount(strTabName);
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
int intRecCount = clsvVideoLib_Resource_RelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvVideoLib_Resource_RelDA.GetRecCount();
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
int intRecCount = clsvVideoLib_Resource_RelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvVideoLib_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvVideoLib_Resource_RelEN objvVideoLib_Resource_RelCond)
{
List<clsvVideoLib_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLib_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLib_Resource_Rel.AttributeName)
{
if (objvVideoLib_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLib_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLib_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvVideoLib_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLib_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLib_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLib_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLib_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLib_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLib_Resource_RelCond[strFldName]));
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
 List<string> arrList = clsvVideoLib_Resource_RelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vVideoLib_Resource_RelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vVideoLib_Resource_RelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}