
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibQuantitySenateItems_Avg_VBL
 表名:vVideoLibQuantitySenateItems_Avg_V(01120471)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:44
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
public static class  clsvVideoLibQuantitySenateItems_Avg_VBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN GetObj(this K_IdmicroteachCaseQuantitySenate_vVideoLibQuantitySenateItems_Avg_V myKey)
{
clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = clsvVideoLibQuantitySenateItems_Avg_VBL.vVideoLibQuantitySenateItems_Avg_VDA.GetObjByIdmicroteachCaseQuantitySenate(myKey.Value);
return objvVideoLibQuantitySenateItems_Avg_VEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetIdmicroteachCaseQuantitySenate(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, long lngIdmicroteachCaseQuantitySenate, string strComparisonOp="")
	{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = lngIdmicroteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetFuncModuleId(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoLibQuantitySenateItems_Avg_V.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoLibQuantitySenateItems_Avg_V.FuncModuleId);
}
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.FuncModuleId) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.FuncModuleId, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetFuncModuleName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoLibQuantitySenateItems_Avg_V.FuncModuleName);
}
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.FuncModuleName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.FuncModuleName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetIdMicroteachCase(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strIdMicroteachCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase);
}
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetVideoLibID(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strVideoLibID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLibQuantitySenateItems_Avg_V.VideoLibID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLibQuantitySenateItems_Avg_V.VideoLibID);
}
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.VideoLibID) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.VideoLibID, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetVideoLibName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strVideoLibName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLibQuantitySenateItems_Avg_V.VideoLibName);
}
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.VideoLibName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.VideoLibName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetIdAppraiseType(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strIdAppraiseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType);
}
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetAppraiseTypeName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strAppraiseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName);
}
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetSenateDate(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strSenateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convVideoLibQuantitySenateItems_Avg_V.SenateDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convVideoLibQuantitySenateItems_Avg_V.SenateDate);
}
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.SenateDate) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.SenateDate, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.SenateDate] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetsenateGaugeVersionName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName);
}
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetUserName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convVideoLibQuantitySenateItems_Avg_V.UserName);
}
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.UserName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.UserName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.UserName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetIdSenateGaugeItem(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strIdSenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeItem, convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeItem, 4, convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeItem, 4, convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem);
}
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = strIdSenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetsenateGaugeItemName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName);
}
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = strsenateGaugeItemName; //量表指标名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetsenateGaugeItemWeight(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, float? fltsenateGaugeItemWeight, string strComparisonOp="")
	{
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = fltsenateGaugeItemWeight; //量表指标权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetSenateScoreAvg(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, float? fltSenateScoreAvg, string strComparisonOp="")
	{
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = fltSenateScoreAvg; //评议平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VENS">源对象</param>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VENT">目标对象</param>
 public static void CopyTo(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VENS, clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VENT)
{
try
{
objvVideoLibQuantitySenateItems_Avg_VENT.IdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateItems_Avg_VENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VENT.FuncModuleId = objvVideoLibQuantitySenateItems_Avg_VENS.FuncModuleId; //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VENT.FuncModuleName = objvVideoLibQuantitySenateItems_Avg_VENS.FuncModuleName; //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VENT.IdMicroteachCase = objvVideoLibQuantitySenateItems_Avg_VENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VENT.VideoLibID = objvVideoLibQuantitySenateItems_Avg_VENS.VideoLibID; //视频库ID
objvVideoLibQuantitySenateItems_Avg_VENT.VideoLibName = objvVideoLibQuantitySenateItems_Avg_VENS.VideoLibName; //视频名称
objvVideoLibQuantitySenateItems_Avg_VENT.IdAppraiseType = objvVideoLibQuantitySenateItems_Avg_VENS.IdAppraiseType; //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VENT.AppraiseTypeName = objvVideoLibQuantitySenateItems_Avg_VENS.AppraiseTypeName; //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VENT.SenateDate = objvVideoLibQuantitySenateItems_Avg_VENS.SenateDate; //评价日期
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeVersionName = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VENT.UserName = objvVideoLibQuantitySenateItems_Avg_VENS.UserName; //用户名
objvVideoLibQuantitySenateItems_Avg_VENT.IdSenateGaugeItem = objvVideoLibQuantitySenateItems_Avg_VENS.IdSenateGaugeItem; //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeItemName = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeItemName; //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeItemWeight = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeItemWeight; //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VENT.SenateScoreAvg = objvVideoLibQuantitySenateItems_Avg_VENS.SenateScoreAvg; //评议平均分
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
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VENS">源对象</param>
 /// <returns>目标对象=>clsvVideoLibQuantitySenateItems_Avg_VEN:objvVideoLibQuantitySenateItems_Avg_VENT</returns>
 public static clsvVideoLibQuantitySenateItems_Avg_VEN CopyTo(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VENS)
{
try
{
 clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VENT = new clsvVideoLibQuantitySenateItems_Avg_VEN()
{
IdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateItems_Avg_VENS.IdmicroteachCaseQuantitySenate, //微格量化评价流水号
FuncModuleId = objvVideoLibQuantitySenateItems_Avg_VENS.FuncModuleId, //功能模块Id
FuncModuleName = objvVideoLibQuantitySenateItems_Avg_VENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvVideoLibQuantitySenateItems_Avg_VENS.IdMicroteachCase, //微格教学案例流水号
VideoLibID = objvVideoLibQuantitySenateItems_Avg_VENS.VideoLibID, //视频库ID
VideoLibName = objvVideoLibQuantitySenateItems_Avg_VENS.VideoLibName, //视频名称
IdAppraiseType = objvVideoLibQuantitySenateItems_Avg_VENS.IdAppraiseType, //评议类型流水号
AppraiseTypeName = objvVideoLibQuantitySenateItems_Avg_VENS.AppraiseTypeName, //评议类型名称
SenateDate = objvVideoLibQuantitySenateItems_Avg_VENS.SenateDate, //评价日期
senateGaugeVersionName = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeVersionName, //评价量表版本名称
UserName = objvVideoLibQuantitySenateItems_Avg_VENS.UserName, //用户名
IdSenateGaugeItem = objvVideoLibQuantitySenateItems_Avg_VENS.IdSenateGaugeItem, //量表指标流水号
senateGaugeItemName = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeItemName, //量表指标名称
senateGaugeItemWeight = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeItemWeight, //量表指标权重
SenateScoreAvg = objvVideoLibQuantitySenateItems_Avg_VENS.SenateScoreAvg, //评议平均分
};
 return objvVideoLibQuantitySenateItems_Avg_VENT;
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
public static void CheckProperty4Condition(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN)
{
 clsvVideoLibQuantitySenateItems_Avg_VBL.vVideoLibQuantitySenateItems_Avg_VDA.CheckProperty4Condition(objvVideoLibQuantitySenateItems_Avg_VEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate) == true)
{
string strComparisonOpIdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate, objvVideoLibQuantitySenateItems_Avg_VCond.IdmicroteachCaseQuantitySenate, strComparisonOpIdmicroteachCaseQuantitySenate);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.FuncModuleId, objvVideoLibQuantitySenateItems_Avg_VCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.FuncModuleName, objvVideoLibQuantitySenateItems_Avg_VCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase, objvVideoLibQuantitySenateItems_Avg_VCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.VideoLibID) == true)
{
string strComparisonOpVideoLibID = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.VideoLibID, objvVideoLibQuantitySenateItems_Avg_VCond.VideoLibID, strComparisonOpVideoLibID);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.VideoLibName) == true)
{
string strComparisonOpVideoLibName = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.VideoLibName, objvVideoLibQuantitySenateItems_Avg_VCond.VideoLibName, strComparisonOpVideoLibName);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType, objvVideoLibQuantitySenateItems_Avg_VCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName, objvVideoLibQuantitySenateItems_Avg_VCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.SenateDate) == true)
{
string strComparisonOpSenateDate = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.SenateDate, objvVideoLibQuantitySenateItems_Avg_VCond.SenateDate, strComparisonOpSenateDate);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName, objvVideoLibQuantitySenateItems_Avg_VCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.UserName) == true)
{
string strComparisonOpUserName = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.UserName, objvVideoLibQuantitySenateItems_Avg_VCond.UserName, strComparisonOpUserName);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem) == true)
{
string strComparisonOpIdSenateGaugeItem = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem, objvVideoLibQuantitySenateItems_Avg_VCond.IdSenateGaugeItem, strComparisonOpIdSenateGaugeItem);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName) == true)
{
string strComparisonOpsenateGaugeItemName = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName, objvVideoLibQuantitySenateItems_Avg_VCond.senateGaugeItemName, strComparisonOpsenateGaugeItemName);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight) == true)
{
string strComparisonOpsenateGaugeItemWeight = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight, objvVideoLibQuantitySenateItems_Avg_VCond.senateGaugeItemWeight, strComparisonOpsenateGaugeItemWeight);
}
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg) == true)
{
string strComparisonOpSenateScoreAvg = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg, objvVideoLibQuantitySenateItems_Avg_VCond.SenateScoreAvg, strComparisonOpSenateScoreAvg);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vVideoLibQuantitySenateItems_Avg_V
{
public virtual bool UpdRelaTabDate(long lngIdmicroteachCaseQuantitySenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v视频库量化评价详细表_Avg_V(vVideoLibQuantitySenateItems_Avg_V)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLibQuantitySenateItems_Avg_VBL
{
public static RelatedActions_vVideoLibQuantitySenateItems_Avg_V relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvVideoLibQuantitySenateItems_Avg_VDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvVideoLibQuantitySenateItems_Avg_VDA vVideoLibQuantitySenateItems_Avg_VDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvVideoLibQuantitySenateItems_Avg_VDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvVideoLibQuantitySenateItems_Avg_VBL()
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
if (string.IsNullOrEmpty(clsvVideoLibQuantitySenateItems_Avg_VEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLibQuantitySenateItems_Avg_VEN._ConnectString);
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
public static DataTable GetDataTable_vVideoLibQuantitySenateItems_Avg_V(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vVideoLibQuantitySenateItems_Avg_VDA.GetDataTable_vVideoLibQuantitySenateItems_Avg_V(strWhereCond);
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
objDT = vVideoLibQuantitySenateItems_Avg_VDA.GetDataTable(strWhereCond);
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
objDT = vVideoLibQuantitySenateItems_Avg_VDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vVideoLibQuantitySenateItems_Avg_VDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vVideoLibQuantitySenateItems_Avg_VDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vVideoLibQuantitySenateItems_Avg_VDA.GetDataTable_Top(objTopPara);
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
objDT = vVideoLibQuantitySenateItems_Avg_VDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vVideoLibQuantitySenateItems_Avg_VDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vVideoLibQuantitySenateItems_Avg_VDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdmicroteachCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstByIdmicroteachCaseQuantitySenateLst(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdmicroteachCaseQuantitySenateLst);
 string strWhereCond = string.Format("IdmicroteachCaseQuantitySenate in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdmicroteachCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstByIdmicroteachCaseQuantitySenateLstCache(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName);
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrvVideoLibQuantitySenateItems_Avg_VObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibQuantitySenateItems_Avg_VEN> arrvVideoLibQuantitySenateItems_Avg_VObjLst_Sel =
arrvVideoLibQuantitySenateItems_Avg_VObjLstCache
.Where(x => arrIdmicroteachCaseQuantitySenateLst.Contains(x.IdmicroteachCaseQuantitySenate));
return arrvVideoLibQuantitySenateItems_Avg_VObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLst(string strWhereCond)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvVideoLibQuantitySenateItems_Avg_VEN> GetSubObjLstCache(clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VCond)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLibQuantitySenateItems_Avg_V.AttributeName)
{
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString());
}
else
{
if (objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName]));
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
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
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
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
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = new List<clsvVideoLibQuantitySenateItems_Avg_VEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = new clsvVideoLibQuantitySenateItems_Avg_VEN();
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibID].ToString().Trim(); //视频库ID
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.SenateDate].ToString().Trim(); //评价日期
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objRow[convVideoLibQuantitySenateItems_Avg_V.UserName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.UserName].ToString().Trim(); //用户名
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objRow[convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibQuantitySenateItems_Avg_VEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvVideoLibQuantitySenateItems_Avg_V(ref clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN)
{
bool bolResult = vVideoLibQuantitySenateItems_Avg_VDA.GetvVideoLibQuantitySenateItems_Avg_V(ref objvVideoLibQuantitySenateItems_Avg_VEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = vVideoLibQuantitySenateItems_Avg_VDA.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
return objvVideoLibQuantitySenateItems_Avg_VEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = vVideoLibQuantitySenateItems_Avg_VDA.GetFirstObj(strWhereCond);
 return objvVideoLibQuantitySenateItems_Avg_VEN;
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
public static clsvVideoLibQuantitySenateItems_Avg_VEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = vVideoLibQuantitySenateItems_Avg_VDA.GetObjByDataRow(objRow);
 return objvVideoLibQuantitySenateItems_Avg_VEN;
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
public static clsvVideoLibQuantitySenateItems_Avg_VEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = vVideoLibQuantitySenateItems_Avg_VDA.GetObjByDataRow(objRow);
 return objvVideoLibQuantitySenateItems_Avg_VEN;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">所给的关键字</param>
 /// <param name = "lstvVideoLibQuantitySenateItems_Avg_VObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN GetObjByIdmicroteachCaseQuantitySenateFromList(long lngIdmicroteachCaseQuantitySenate, List<clsvVideoLibQuantitySenateItems_Avg_VEN> lstvVideoLibQuantitySenateItems_Avg_VObjLst)
{
foreach (clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN in lstvVideoLibQuantitySenateItems_Avg_VObjLst)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate)
{
return objvVideoLibQuantitySenateItems_Avg_VEN;
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
 long lngIdmicroteachCaseQuantitySenate;
 try
 {
 lngIdmicroteachCaseQuantitySenate = new clsvVideoLibQuantitySenateItems_Avg_VDA().GetFirstID(strWhereCond);
 return lngIdmicroteachCaseQuantitySenate;
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
 arrList = vVideoLibQuantitySenateItems_Avg_VDA.GetID(strWhereCond);
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
bool bolIsExist = vVideoLibQuantitySenateItems_Avg_VDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdmicroteachCaseQuantitySenate)
{
//检测记录是否存在
bool bolIsExist = vVideoLibQuantitySenateItems_Avg_VDA.IsExist(lngIdmicroteachCaseQuantitySenate);
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
 bolIsExist = clsvVideoLibQuantitySenateItems_Avg_VDA.IsExistTable();
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
 bolIsExist = vVideoLibQuantitySenateItems_Avg_VDA.IsExistTable(strTabName);
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
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VENS">源对象</param>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VENT">目标对象</param>
 public static void CopyTo(clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VENS, clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VENT)
{
try
{
objvVideoLibQuantitySenateItems_Avg_VENT.IdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateItems_Avg_VENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VENT.FuncModuleId = objvVideoLibQuantitySenateItems_Avg_VENS.FuncModuleId; //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VENT.FuncModuleName = objvVideoLibQuantitySenateItems_Avg_VENS.FuncModuleName; //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VENT.IdMicroteachCase = objvVideoLibQuantitySenateItems_Avg_VENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VENT.VideoLibID = objvVideoLibQuantitySenateItems_Avg_VENS.VideoLibID; //视频库ID
objvVideoLibQuantitySenateItems_Avg_VENT.VideoLibName = objvVideoLibQuantitySenateItems_Avg_VENS.VideoLibName; //视频名称
objvVideoLibQuantitySenateItems_Avg_VENT.IdAppraiseType = objvVideoLibQuantitySenateItems_Avg_VENS.IdAppraiseType; //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VENT.AppraiseTypeName = objvVideoLibQuantitySenateItems_Avg_VENS.AppraiseTypeName; //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VENT.SenateDate = objvVideoLibQuantitySenateItems_Avg_VENS.SenateDate; //评价日期
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeVersionName = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VENT.UserName = objvVideoLibQuantitySenateItems_Avg_VENS.UserName; //用户名
objvVideoLibQuantitySenateItems_Avg_VENT.IdSenateGaugeItem = objvVideoLibQuantitySenateItems_Avg_VENS.IdSenateGaugeItem; //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeItemName = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeItemName; //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeItemWeight = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeItemWeight; //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VENT.SenateScoreAvg = objvVideoLibQuantitySenateItems_Avg_VENS.SenateScoreAvg; //评议平均分
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
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">源简化对象</param>
 public static void SetUpdFlag(clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN)
{
try
{
objvVideoLibQuantitySenateItems_Avg_VEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvVideoLibQuantitySenateItems_Avg_VEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate = objvVideoLibQuantitySenateItems_Avg_VEN.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId == "[null]" ? null :  objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName == "[null]" ? null :  objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase == "[null]" ? null :  objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.VideoLibID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID == "[null]" ? null :  objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID; //视频库ID
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.VideoLibName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName == "[null]" ? null :  objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName; //视频名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType == "[null]" ? null :  objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName == "[null]" ? null :  objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.SenateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate == "[null]" ? null :  objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate; //评价日期
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName == "[null]" ? null :  objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = objvVideoLibQuantitySenateItems_Avg_VEN.UserName == "[null]" ? null :  objvVideoLibQuantitySenateItems_Avg_VEN.UserName; //用户名
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.IdSenateGaugeItem, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem = objvVideoLibQuantitySenateItems_Avg_VEN.IdSenateGaugeItem; //量表指标流水号
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName == "[null]" ? null :  objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName; //量表指标名称
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight; //量表指标权重
}
if (arrFldSet.Contains(convVideoLibQuantitySenateItems_Avg_V.SenateScoreAvg, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg = objvVideoLibQuantitySenateItems_Avg_VEN.SenateScoreAvg; //评议平均分
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
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">源简化对象</param>
 public static void AccessFldValueNull(clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN)
{
try
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId == "[null]") objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = null; //功能模块Id
if (objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName == "[null]") objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = null; //功能模块名称
if (objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase == "[null]") objvVideoLibQuantitySenateItems_Avg_VEN.IdMicroteachCase = null; //微格教学案例流水号
if (objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID == "[null]") objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = null; //视频库ID
if (objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName == "[null]") objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = null; //视频名称
if (objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType == "[null]") objvVideoLibQuantitySenateItems_Avg_VEN.IdAppraiseType = null; //评议类型流水号
if (objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName == "[null]") objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = null; //评议类型名称
if (objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate == "[null]") objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = null; //评价日期
if (objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName == "[null]") objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvVideoLibQuantitySenateItems_Avg_VEN.UserName == "[null]") objvVideoLibQuantitySenateItems_Avg_VEN.UserName = null; //用户名
if (objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName == "[null]") objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = null; //量表指标名称
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
public static void CheckProperty4Condition(clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN)
{
 vVideoLibQuantitySenateItems_Avg_VDA.CheckProperty4Condition(objvVideoLibQuantitySenateItems_Avg_VEN);
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
if (clsSenateGaugeItemsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeItemsBL没有刷新缓存机制(clsSenateGaugeItemsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoBL没有刷新缓存机制(clsTeacherInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeBL没有刷新缓存机制(clsAppraiseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindBL没有刷新缓存机制(clsUserKindBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateBL没有刷新缓存机制(clsMicroteachCaseQuantitySenateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateItemsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateItemsBL没有刷新缓存机制(clsMicroteachCaseQuantitySenateItemsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdmicroteachCaseQuantitySenate");
//if (arrvVideoLibQuantitySenateItems_Avg_VObjLstCache == null)
//{
//arrvVideoLibQuantitySenateItems_Avg_VObjLstCache = vVideoLibQuantitySenateItems_Avg_VDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN GetObjByIdmicroteachCaseQuantitySenateCache(long lngIdmicroteachCaseQuantitySenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName);
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrvVideoLibQuantitySenateItems_Avg_VObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibQuantitySenateItems_Avg_VEN> arrvVideoLibQuantitySenateItems_Avg_VObjLst_Sel =
arrvVideoLibQuantitySenateItems_Avg_VObjLstCache
.Where(x=> x.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate 
);
if (arrvVideoLibQuantitySenateItems_Avg_VObjLst_Sel.Count() == 0)
{
   clsvVideoLibQuantitySenateItems_Avg_VEN obj = clsvVideoLibQuantitySenateItems_Avg_VBL.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvVideoLibQuantitySenateItems_Avg_VObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetAllvVideoLibQuantitySenateItems_Avg_VObjLstCache()
{
//获取缓存中的对象列表
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrvVideoLibQuantitySenateItems_Avg_VObjLstCache = GetObjLstCache(); 
return arrvVideoLibQuantitySenateItems_Avg_VObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName);
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrvVideoLibQuantitySenateItems_Avg_VObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLibQuantitySenateItems_Avg_VObjLstCache;
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
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdmicroteachCaseQuantitySenate)
{
if (strInFldName != convVideoLibQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convVideoLibQuantitySenateItems_Avg_V.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convVideoLibQuantitySenateItems_Avg_V.AttributeName));
throw new Exception(strMsg);
}
var objvVideoLibQuantitySenateItems_Avg_V = clsvVideoLibQuantitySenateItems_Avg_VBL.GetObjByIdmicroteachCaseQuantitySenateCache(lngIdmicroteachCaseQuantitySenate);
if (objvVideoLibQuantitySenateItems_Avg_V == null) return "";
return objvVideoLibQuantitySenateItems_Avg_V[strOutFldName].ToString();
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
int intRecCount = clsvVideoLibQuantitySenateItems_Avg_VDA.GetRecCount(strTabName);
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
int intRecCount = clsvVideoLibQuantitySenateItems_Avg_VDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvVideoLibQuantitySenateItems_Avg_VDA.GetRecCount();
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
int intRecCount = clsvVideoLibQuantitySenateItems_Avg_VDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VCond)
{
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLibQuantitySenateItems_Avg_V.AttributeName)
{
if (objvVideoLibQuantitySenateItems_Avg_VCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString());
}
else
{
if (objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLibQuantitySenateItems_Avg_VCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLibQuantitySenateItems_Avg_VCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLibQuantitySenateItems_Avg_VCond[strFldName]));
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
 List<string> arrList = clsvVideoLibQuantitySenateItems_Avg_VDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vVideoLibQuantitySenateItems_Avg_VDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vVideoLibQuantitySenateItems_Avg_VDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}