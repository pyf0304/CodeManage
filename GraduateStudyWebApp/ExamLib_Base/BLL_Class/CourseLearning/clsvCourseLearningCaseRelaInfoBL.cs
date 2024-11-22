
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseRelaInfoBL
 表名:vCourseLearningCaseRelaInfo(01120270)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsvCourseLearningCaseRelaInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseRelaInfoEN GetObj(this K_IdMicroTeachCaseRelaInfo_vCourseLearningCaseRelaInfo myKey)
{
clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = clsvCourseLearningCaseRelaInfoBL.vCourseLearningCaseRelaInfoDA.GetObjByIdMicroTeachCaseRelaInfo(myKey.Value);
return objvCourseLearningCaseRelaInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIdMicroTeachCaseRelaInfo(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, long lngIdMicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = lngIdMicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFuncModuleId(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCourseLearningCaseRelaInfo.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningCaseRelaInfo.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningCaseRelaInfo.FuncModuleId);
}
objvCourseLearningCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FuncModuleId) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFuncModuleName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningCaseRelaInfo.FuncModuleName);
}
objvCourseLearningCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FuncModuleName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIdCourseLearningCase(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strIdCourseLearningCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCase, 8, convCourseLearningCaseRelaInfo.IdCourseLearningCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCase, 8, convCourseLearningCaseRelaInfo.IdCourseLearningCase);
}
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = strIdCourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IdCourseLearningCase) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IdCourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdCourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIdMicroteachCase(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convCourseLearningCaseRelaInfo.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convCourseLearningCaseRelaInfo.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convCourseLearningCaseRelaInfo.IdMicroteachCase);
}
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IdMicroteachCase) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IdMicroteachCase, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdMicroteachCase] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCourseLearningCaseName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCaseRelaInfo.CourseLearningCaseName);
}
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CourseLearningCaseName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIdMicroTeachCaseRelaInfoType(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strIdMicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroTeachCaseRelaInfoType, 4, convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroTeachCaseRelaInfoType, 4, convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = strIdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIdFile(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convCourseLearningCaseRelaInfo.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convCourseLearningCaseRelaInfo.IdFile);
}
objvCourseLearningCaseRelaInfoEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IdFile) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IdFile, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdFile] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convCourseLearningCaseRelaInfo.FileName);
}
objvCourseLearningCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileType(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convCourseLearningCaseRelaInfo.FileType);
}
objvCourseLearningCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileType) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetSaveDate(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convCourseLearningCaseRelaInfo.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convCourseLearningCaseRelaInfo.SaveDate);
}
objvCourseLearningCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.SaveDate) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileSize(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convCourseLearningCaseRelaInfo.FileSize);
}
objvCourseLearningCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileSize) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetSaveTime(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convCourseLearningCaseRelaInfo.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convCourseLearningCaseRelaInfo.SaveTime);
}
objvCourseLearningCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.SaveTime) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIdFtpResource(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convCourseLearningCaseRelaInfo.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convCourseLearningCaseRelaInfo.IdFtpResource);
}
objvCourseLearningCaseRelaInfoEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IdFtpResource) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IdFtpResource, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdFtpResource] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFtpResourceID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convCourseLearningCaseRelaInfo.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convCourseLearningCaseRelaInfo.FtpResourceID);
}
objvCourseLearningCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FtpResourceID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileOriginalName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convCourseLearningCaseRelaInfo.FileOriginalName);
}
objvCourseLearningCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileOriginalName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileDirName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convCourseLearningCaseRelaInfo.FileDirName);
}
objvCourseLearningCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileDirName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileRename(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convCourseLearningCaseRelaInfo.FileRename);
}
objvCourseLearningCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileRename) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileUpDate(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convCourseLearningCaseRelaInfo.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convCourseLearningCaseRelaInfo.FileUpDate);
}
objvCourseLearningCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileUpDate) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileUpTime(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convCourseLearningCaseRelaInfo.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convCourseLearningCaseRelaInfo.FileUpTime);
}
objvCourseLearningCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileUpTime) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIdResource(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convCourseLearningCaseRelaInfo.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convCourseLearningCaseRelaInfo.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convCourseLearningCaseRelaInfo.IdResource);
}
objvCourseLearningCaseRelaInfoEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IdResource) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IdResource, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdResource] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetResourceID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convCourseLearningCaseRelaInfo.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convCourseLearningCaseRelaInfo.ResourceID);
}
objvCourseLearningCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ResourceID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetSaveMode(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvCourseLearningCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.SaveMode) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIdResourceType(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convCourseLearningCaseRelaInfo.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convCourseLearningCaseRelaInfo.IdResourceType);
}
objvCourseLearningCaseRelaInfoEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IdResourceType) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IdResourceType, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdResourceType] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetResourceTypeID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convCourseLearningCaseRelaInfo.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convCourseLearningCaseRelaInfo.ResourceTypeID);
}
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ResourceTypeID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetResourceTypeName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convCourseLearningCaseRelaInfo.ResourceTypeName);
}
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ResourceTypeName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetMajorID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCaseRelaInfo.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCaseRelaInfo.MajorID);
}
objvCourseLearningCaseRelaInfoEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.MajorID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.MajorID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MajorID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetMajorName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCaseRelaInfo.MajorName);
}
objvCourseLearningCaseRelaInfoEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.MajorName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.MajorName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MajorName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIdXzCollege(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCourseLearningCaseRelaInfo.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCourseLearningCaseRelaInfo.IdXzCollege);
}
objvCourseLearningCaseRelaInfoEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IdXzCollege) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IdXzCollege, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdXzCollege] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCollegeID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningCaseRelaInfo.CollegeID);
}
objvCourseLearningCaseRelaInfoEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CollegeID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CollegeID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CollegeID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCollegeName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCaseRelaInfo.CollegeName);
}
objvCourseLearningCaseRelaInfoEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CollegeName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCourseId(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCaseRelaInfo.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCaseRelaInfo.CourseId);
}
objvCourseLearningCaseRelaInfoEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CourseId) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCourseCode(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCaseRelaInfo.CourseCode);
}
objvCourseLearningCaseRelaInfoEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CourseCode) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCourseName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCaseRelaInfo.CourseName);
}
objvCourseLearningCaseRelaInfoEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CourseName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetBrowseCount(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, int? intBrowseCount, string strComparisonOp="")
	{
objvCourseLearningCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.BrowseCount) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetResourceOwner(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convCourseLearningCaseRelaInfo.ResourceOwner);
}
objvCourseLearningCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ResourceOwner) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetftpFileType(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCourseLearningCaseRelaInfo.ftpFileType);
}
objvCourseLearningCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ftpFileType) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetftpFileSize(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convCourseLearningCaseRelaInfo.ftpFileSize);
}
objvCourseLearningCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ftpFileSize) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetftpResourceOwner(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convCourseLearningCaseRelaInfo.ftpResourceOwner);
}
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ftpResourceOwner) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileOriginName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convCourseLearningCaseRelaInfo.FileOriginName);
}
objvCourseLearningCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileOriginName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIsExistFile(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvCourseLearningCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IsExistFile) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFlag(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFlag, 50, convCourseLearningCaseRelaInfo.Flag);
}
objvCourseLearningCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.Flag) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileNewName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convCourseLearningCaseRelaInfo.FileNewName);
}
objvCourseLearningCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileNewName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileOldName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convCourseLearningCaseRelaInfo.FileOldName);
}
objvCourseLearningCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileOldName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIsVisible(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCourseLearningCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IsVisible) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetUpdDate(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCourseLearningCaseRelaInfo.UpdDate);
}
objvCourseLearningCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.UpdDate) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetUpdUser(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCourseLearningCaseRelaInfo.UpdUser);
}
objvCourseLearningCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.UpdUser) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetMemo(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCaseRelaInfo.Memo);
}
objvCourseLearningCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.Memo) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCourseLearningCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoENS, clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoENT)
{
try
{
objvCourseLearningCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvCourseLearningCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvCourseLearningCaseRelaInfoENT.FuncModuleId = objvCourseLearningCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseRelaInfoENT.FuncModuleName = objvCourseLearningCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseRelaInfoENT.IdCourseLearningCase = objvCourseLearningCaseRelaInfoENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseRelaInfoENT.IdMicroteachCase = objvCourseLearningCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningCaseRelaInfoENT.CourseLearningCaseName = objvCourseLearningCaseRelaInfoENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvCourseLearningCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvCourseLearningCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvCourseLearningCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoENT.IdFile = objvCourseLearningCaseRelaInfoENS.IdFile; //文件流水号
objvCourseLearningCaseRelaInfoENT.FileName = objvCourseLearningCaseRelaInfoENS.FileName; //文件名称
objvCourseLearningCaseRelaInfoENT.FileType = objvCourseLearningCaseRelaInfoENS.FileType; //文件类型
objvCourseLearningCaseRelaInfoENT.SaveDate = objvCourseLearningCaseRelaInfoENS.SaveDate; //创建日期
objvCourseLearningCaseRelaInfoENT.FileSize = objvCourseLearningCaseRelaInfoENS.FileSize; //文件大小
objvCourseLearningCaseRelaInfoENT.SaveTime = objvCourseLearningCaseRelaInfoENS.SaveTime; //创建时间
objvCourseLearningCaseRelaInfoENT.IdFtpResource = objvCourseLearningCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvCourseLearningCaseRelaInfoENT.FtpResourceID = objvCourseLearningCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvCourseLearningCaseRelaInfoENT.FileOriginalName = objvCourseLearningCaseRelaInfoENS.FileOriginalName; //文件原名
objvCourseLearningCaseRelaInfoENT.FileDirName = objvCourseLearningCaseRelaInfoENS.FileDirName; //文件目录名
objvCourseLearningCaseRelaInfoENT.FileRename = objvCourseLearningCaseRelaInfoENS.FileRename; //文件新名
objvCourseLearningCaseRelaInfoENT.FileUpDate = objvCourseLearningCaseRelaInfoENS.FileUpDate; //创建日期
objvCourseLearningCaseRelaInfoENT.FileUpTime = objvCourseLearningCaseRelaInfoENS.FileUpTime; //创建时间
objvCourseLearningCaseRelaInfoENT.IdResource = objvCourseLearningCaseRelaInfoENS.IdResource; //资源流水号
objvCourseLearningCaseRelaInfoENT.ResourceID = objvCourseLearningCaseRelaInfoENS.ResourceID; //资源ID
objvCourseLearningCaseRelaInfoENT.SaveMode = objvCourseLearningCaseRelaInfoENS.SaveMode; //文件存放方式
objvCourseLearningCaseRelaInfoENT.IdResourceType = objvCourseLearningCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvCourseLearningCaseRelaInfoENT.ResourceTypeID = objvCourseLearningCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvCourseLearningCaseRelaInfoENT.ResourceTypeName = objvCourseLearningCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvCourseLearningCaseRelaInfoENT.MajorID = objvCourseLearningCaseRelaInfoENS.MajorID; //专业ID
objvCourseLearningCaseRelaInfoENT.MajorName = objvCourseLearningCaseRelaInfoENS.MajorName; //专业名称
objvCourseLearningCaseRelaInfoENT.IdXzCollege = objvCourseLearningCaseRelaInfoENS.IdXzCollege; //学院流水号
objvCourseLearningCaseRelaInfoENT.CollegeID = objvCourseLearningCaseRelaInfoENS.CollegeID; //学院ID
objvCourseLearningCaseRelaInfoENT.CollegeName = objvCourseLearningCaseRelaInfoENS.CollegeName; //学院名称
objvCourseLearningCaseRelaInfoENT.CourseId = objvCourseLearningCaseRelaInfoENS.CourseId; //课程Id
objvCourseLearningCaseRelaInfoENT.CourseCode = objvCourseLearningCaseRelaInfoENS.CourseCode; //课程代码
objvCourseLearningCaseRelaInfoENT.CourseName = objvCourseLearningCaseRelaInfoENS.CourseName; //课程名称
objvCourseLearningCaseRelaInfoENT.BrowseCount = objvCourseLearningCaseRelaInfoENS.BrowseCount; //浏览次数
objvCourseLearningCaseRelaInfoENT.ResourceOwner = objvCourseLearningCaseRelaInfoENS.ResourceOwner; //上传者
objvCourseLearningCaseRelaInfoENT.ftpFileType = objvCourseLearningCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvCourseLearningCaseRelaInfoENT.ftpFileSize = objvCourseLearningCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvCourseLearningCaseRelaInfoENT.ftpResourceOwner = objvCourseLearningCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvCourseLearningCaseRelaInfoENT.FileOriginName = objvCourseLearningCaseRelaInfoENS.FileOriginName; //原文件名
objvCourseLearningCaseRelaInfoENT.IsExistFile = objvCourseLearningCaseRelaInfoENS.IsExistFile; //是否存在文件
objvCourseLearningCaseRelaInfoENT.Flag = objvCourseLearningCaseRelaInfoENS.Flag; //标志
objvCourseLearningCaseRelaInfoENT.FileNewName = objvCourseLearningCaseRelaInfoENS.FileNewName; //新文件名
objvCourseLearningCaseRelaInfoENT.FileOldName = objvCourseLearningCaseRelaInfoENS.FileOldName; //旧文件名
objvCourseLearningCaseRelaInfoENT.IsVisible = objvCourseLearningCaseRelaInfoENS.IsVisible; //是否显示
objvCourseLearningCaseRelaInfoENT.UpdDate = objvCourseLearningCaseRelaInfoENS.UpdDate; //修改日期
objvCourseLearningCaseRelaInfoENT.UpdUser = objvCourseLearningCaseRelaInfoENS.UpdUser; //修改人
objvCourseLearningCaseRelaInfoENT.Memo = objvCourseLearningCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objvCourseLearningCaseRelaInfoENS">源对象</param>
 /// <returns>目标对象=>clsvCourseLearningCaseRelaInfoEN:objvCourseLearningCaseRelaInfoENT</returns>
 public static clsvCourseLearningCaseRelaInfoEN CopyTo(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoENS)
{
try
{
 clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoENT = new clsvCourseLearningCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = objvCourseLearningCaseRelaInfoENS.IdMicroTeachCaseRelaInfo, //案例相关信息流水号
FuncModuleId = objvCourseLearningCaseRelaInfoENS.FuncModuleId, //功能模块Id
FuncModuleName = objvCourseLearningCaseRelaInfoENS.FuncModuleName, //功能模块名称
IdCourseLearningCase = objvCourseLearningCaseRelaInfoENS.IdCourseLearningCase, //课程学习案例流水号
IdMicroteachCase = objvCourseLearningCaseRelaInfoENS.IdMicroteachCase, //微格教学案例流水号
CourseLearningCaseName = objvCourseLearningCaseRelaInfoENS.CourseLearningCaseName, //课程学习案例名称
IdMicroTeachCaseRelaInfoType = objvCourseLearningCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType, //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objvCourseLearningCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID, //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objvCourseLearningCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName, //微格案例相关信息类型名称
IdFile = objvCourseLearningCaseRelaInfoENS.IdFile, //文件流水号
FileName = objvCourseLearningCaseRelaInfoENS.FileName, //文件名称
FileType = objvCourseLearningCaseRelaInfoENS.FileType, //文件类型
SaveDate = objvCourseLearningCaseRelaInfoENS.SaveDate, //创建日期
FileSize = objvCourseLearningCaseRelaInfoENS.FileSize, //文件大小
SaveTime = objvCourseLearningCaseRelaInfoENS.SaveTime, //创建时间
IdFtpResource = objvCourseLearningCaseRelaInfoENS.IdFtpResource, //FTP资源流水号
FtpResourceID = objvCourseLearningCaseRelaInfoENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvCourseLearningCaseRelaInfoENS.FileOriginalName, //文件原名
FileDirName = objvCourseLearningCaseRelaInfoENS.FileDirName, //文件目录名
FileRename = objvCourseLearningCaseRelaInfoENS.FileRename, //文件新名
FileUpDate = objvCourseLearningCaseRelaInfoENS.FileUpDate, //创建日期
FileUpTime = objvCourseLearningCaseRelaInfoENS.FileUpTime, //创建时间
IdResource = objvCourseLearningCaseRelaInfoENS.IdResource, //资源流水号
ResourceID = objvCourseLearningCaseRelaInfoENS.ResourceID, //资源ID
SaveMode = objvCourseLearningCaseRelaInfoENS.SaveMode, //文件存放方式
IdResourceType = objvCourseLearningCaseRelaInfoENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvCourseLearningCaseRelaInfoENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvCourseLearningCaseRelaInfoENS.ResourceTypeName, //资源类型名称
MajorID = objvCourseLearningCaseRelaInfoENS.MajorID, //专业ID
MajorName = objvCourseLearningCaseRelaInfoENS.MajorName, //专业名称
IdXzCollege = objvCourseLearningCaseRelaInfoENS.IdXzCollege, //学院流水号
CollegeID = objvCourseLearningCaseRelaInfoENS.CollegeID, //学院ID
CollegeName = objvCourseLearningCaseRelaInfoENS.CollegeName, //学院名称
CourseId = objvCourseLearningCaseRelaInfoENS.CourseId, //课程Id
CourseCode = objvCourseLearningCaseRelaInfoENS.CourseCode, //课程代码
CourseName = objvCourseLearningCaseRelaInfoENS.CourseName, //课程名称
BrowseCount = objvCourseLearningCaseRelaInfoENS.BrowseCount, //浏览次数
ResourceOwner = objvCourseLearningCaseRelaInfoENS.ResourceOwner, //上传者
ftpFileType = objvCourseLearningCaseRelaInfoENS.ftpFileType, //ftp文件类型
ftpFileSize = objvCourseLearningCaseRelaInfoENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvCourseLearningCaseRelaInfoENS.ftpResourceOwner, //Ftp资源拥有者
FileOriginName = objvCourseLearningCaseRelaInfoENS.FileOriginName, //原文件名
IsExistFile = objvCourseLearningCaseRelaInfoENS.IsExistFile, //是否存在文件
Flag = objvCourseLearningCaseRelaInfoENS.Flag, //标志
FileNewName = objvCourseLearningCaseRelaInfoENS.FileNewName, //新文件名
FileOldName = objvCourseLearningCaseRelaInfoENS.FileOldName, //旧文件名
IsVisible = objvCourseLearningCaseRelaInfoENS.IsVisible, //是否显示
UpdDate = objvCourseLearningCaseRelaInfoENS.UpdDate, //修改日期
UpdUser = objvCourseLearningCaseRelaInfoENS.UpdUser, //修改人
Memo = objvCourseLearningCaseRelaInfoENS.Memo, //备注
};
 return objvCourseLearningCaseRelaInfoENT;
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
public static void CheckProperty4Condition(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN)
{
 clsvCourseLearningCaseRelaInfoBL.vCourseLearningCaseRelaInfoDA.CheckProperty4Condition(objvCourseLearningCaseRelaInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo) == true)
{
string strComparisonOpIdMicroTeachCaseRelaInfo = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo, objvCourseLearningCaseRelaInfoCond.IdMicroTeachCaseRelaInfo, strComparisonOpIdMicroTeachCaseRelaInfo);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FuncModuleId, objvCourseLearningCaseRelaInfoCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FuncModuleName, objvCourseLearningCaseRelaInfoCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.IdCourseLearningCase) == true)
{
string strComparisonOpIdCourseLearningCase = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdCourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.IdCourseLearningCase, objvCourseLearningCaseRelaInfoCond.IdCourseLearningCase, strComparisonOpIdCourseLearningCase);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.IdMicroteachCase, objvCourseLearningCaseRelaInfoCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.CourseLearningCaseName) == true)
{
string strComparisonOpCourseLearningCaseName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CourseLearningCaseName, objvCourseLearningCaseRelaInfoCond.CourseLearningCaseName, strComparisonOpCourseLearningCaseName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType) == true)
{
string strComparisonOpIdMicroTeachCaseRelaInfoType = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType, objvCourseLearningCaseRelaInfoCond.IdMicroTeachCaseRelaInfoType, strComparisonOpIdMicroTeachCaseRelaInfoType);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOpMicroTeachCaseRelaInfoTypeID = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, objvCourseLearningCaseRelaInfoCond.MicroTeachCaseRelaInfoTypeID, strComparisonOpMicroTeachCaseRelaInfoTypeID);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOpMicroTeachCaseRelaInfoTypeName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvCourseLearningCaseRelaInfoCond.MicroTeachCaseRelaInfoTypeName, strComparisonOpMicroTeachCaseRelaInfoTypeName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.IdFile) == true)
{
string strComparisonOpIdFile = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.IdFile, objvCourseLearningCaseRelaInfoCond.IdFile, strComparisonOpIdFile);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FileName) == true)
{
string strComparisonOpFileName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileName, objvCourseLearningCaseRelaInfoCond.FileName, strComparisonOpFileName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FileType) == true)
{
string strComparisonOpFileType = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileType, objvCourseLearningCaseRelaInfoCond.FileType, strComparisonOpFileType);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.SaveDate) == true)
{
string strComparisonOpSaveDate = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.SaveDate, objvCourseLearningCaseRelaInfoCond.SaveDate, strComparisonOpSaveDate);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FileSize) == true)
{
string strComparisonOpFileSize = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileSize, objvCourseLearningCaseRelaInfoCond.FileSize, strComparisonOpFileSize);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.SaveTime) == true)
{
string strComparisonOpSaveTime = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.SaveTime, objvCourseLearningCaseRelaInfoCond.SaveTime, strComparisonOpSaveTime);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.IdFtpResource, objvCourseLearningCaseRelaInfoCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FtpResourceID, objvCourseLearningCaseRelaInfoCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileOriginalName, objvCourseLearningCaseRelaInfoCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FileDirName) == true)
{
string strComparisonOpFileDirName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileDirName, objvCourseLearningCaseRelaInfoCond.FileDirName, strComparisonOpFileDirName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FileRename) == true)
{
string strComparisonOpFileRename = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileRename, objvCourseLearningCaseRelaInfoCond.FileRename, strComparisonOpFileRename);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileUpDate, objvCourseLearningCaseRelaInfoCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileUpTime, objvCourseLearningCaseRelaInfoCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.IdResource) == true)
{
string strComparisonOpIdResource = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.IdResource, objvCourseLearningCaseRelaInfoCond.IdResource, strComparisonOpIdResource);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.ResourceID) == true)
{
string strComparisonOpResourceID = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ResourceID, objvCourseLearningCaseRelaInfoCond.ResourceID, strComparisonOpResourceID);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.SaveMode) == true)
{
if (objvCourseLearningCaseRelaInfoCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseRelaInfo.SaveMode);
}
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.IdResourceType, objvCourseLearningCaseRelaInfoCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ResourceTypeID, objvCourseLearningCaseRelaInfoCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ResourceTypeName, objvCourseLearningCaseRelaInfoCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.MajorID) == true)
{
string strComparisonOpMajorID = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.MajorID, objvCourseLearningCaseRelaInfoCond.MajorID, strComparisonOpMajorID);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.MajorName) == true)
{
string strComparisonOpMajorName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.MajorName, objvCourseLearningCaseRelaInfoCond.MajorName, strComparisonOpMajorName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.IdXzCollege, objvCourseLearningCaseRelaInfoCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.CollegeID) == true)
{
string strComparisonOpCollegeID = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CollegeID, objvCourseLearningCaseRelaInfoCond.CollegeID, strComparisonOpCollegeID);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.CollegeName) == true)
{
string strComparisonOpCollegeName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CollegeName, objvCourseLearningCaseRelaInfoCond.CollegeName, strComparisonOpCollegeName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.CourseId) == true)
{
string strComparisonOpCourseId = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CourseId, objvCourseLearningCaseRelaInfoCond.CourseId, strComparisonOpCourseId);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CourseCode, objvCourseLearningCaseRelaInfoCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.CourseName) == true)
{
string strComparisonOpCourseName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CourseName, objvCourseLearningCaseRelaInfoCond.CourseName, strComparisonOpCourseName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseRelaInfo.BrowseCount, objvCourseLearningCaseRelaInfoCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ResourceOwner, objvCourseLearningCaseRelaInfoCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ftpFileType, objvCourseLearningCaseRelaInfoCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ftpFileSize, objvCourseLearningCaseRelaInfoCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ftpResourceOwner, objvCourseLearningCaseRelaInfoCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileOriginName, objvCourseLearningCaseRelaInfoCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.IsExistFile) == true)
{
if (objvCourseLearningCaseRelaInfoCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseRelaInfo.IsExistFile);
}
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.Flag) == true)
{
string strComparisonOpFlag = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.Flag, objvCourseLearningCaseRelaInfoCond.Flag, strComparisonOpFlag);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FileNewName) == true)
{
string strComparisonOpFileNewName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileNewName, objvCourseLearningCaseRelaInfoCond.FileNewName, strComparisonOpFileNewName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.FileOldName) == true)
{
string strComparisonOpFileOldName = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileOldName, objvCourseLearningCaseRelaInfoCond.FileOldName, strComparisonOpFileOldName);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.IsVisible) == true)
{
if (objvCourseLearningCaseRelaInfoCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseRelaInfo.IsVisible);
}
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.UpdDate, objvCourseLearningCaseRelaInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.UpdUser, objvCourseLearningCaseRelaInfoCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(convCourseLearningCaseRelaInfo.Memo) == true)
{
string strComparisonOpMemo = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.Memo, objvCourseLearningCaseRelaInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCourseLearningCaseRelaInfo
{
public virtual bool UpdRelaTabDate(long lngIdMicroTeachCaseRelaInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程学习案例相关信息(vCourseLearningCaseRelaInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCaseRelaInfoBL
{
public static RelatedActions_vCourseLearningCaseRelaInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCourseLearningCaseRelaInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCourseLearningCaseRelaInfoDA vCourseLearningCaseRelaInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCourseLearningCaseRelaInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCourseLearningCaseRelaInfoBL()
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
if (string.IsNullOrEmpty(clsvCourseLearningCaseRelaInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseRelaInfoEN._ConnectString);
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
public static DataTable GetDataTable_vCourseLearningCaseRelaInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCourseLearningCaseRelaInfoDA.GetDataTable_vCourseLearningCaseRelaInfo(strWhereCond);
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
objDT = vCourseLearningCaseRelaInfoDA.GetDataTable(strWhereCond);
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
objDT = vCourseLearningCaseRelaInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCourseLearningCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCourseLearningCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCourseLearningCaseRelaInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vCourseLearningCaseRelaInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCourseLearningCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCourseLearningCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstByIdMicroTeachCaseRelaInfoLst(List<long> arrIdMicroTeachCaseRelaInfoLst)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroTeachCaseRelaInfoLst);
 string strWhereCond = string.Format("IdMicroTeachCaseRelaInfo in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCourseLearningCaseRelaInfoEN> GetObjLstByIdMicroTeachCaseRelaInfoLstCache(List<long> arrIdMicroTeachCaseRelaInfoLst)
{
string strKey = string.Format("{0}", clsvCourseLearningCaseRelaInfoEN._CurrTabName);
List<clsvCourseLearningCaseRelaInfoEN> arrvCourseLearningCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseRelaInfoEN> arrvCourseLearningCaseRelaInfoObjLst_Sel =
arrvCourseLearningCaseRelaInfoObjLstCache
.Where(x => arrIdMicroTeachCaseRelaInfoLst.Contains(x.IdMicroTeachCaseRelaInfo));
return arrvCourseLearningCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCourseLearningCaseRelaInfoEN> GetSubObjLstCache(clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoCond)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCaseRelaInfo.AttributeName)
{
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseRelaInfoCond[strFldName]));
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
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
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
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
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = new List<clsvCourseLearningCaseRelaInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = new clsvCourseLearningCaseRelaInfoEN();
try
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objRow[convCourseLearningCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objRow[convCourseLearningCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objRow[convCourseLearningCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoEN.IdFile = objRow[convCourseLearningCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseRelaInfoEN.FileName = objRow[convCourseLearningCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvCourseLearningCaseRelaInfoEN.FileType = objRow[convCourseLearningCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvCourseLearningCaseRelaInfoEN.SaveDate = objRow[convCourseLearningCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileSize = objRow[convCourseLearningCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseRelaInfoEN.SaveTime = objRow[convCourseLearningCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objRow[convCourseLearningCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objRow[convCourseLearningCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objRow[convCourseLearningCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvCourseLearningCaseRelaInfoEN.FileDirName = objRow[convCourseLearningCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvCourseLearningCaseRelaInfoEN.FileRename = objRow[convCourseLearningCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvCourseLearningCaseRelaInfoEN.FileUpDate = objRow[convCourseLearningCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvCourseLearningCaseRelaInfoEN.FileUpTime = objRow[convCourseLearningCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvCourseLearningCaseRelaInfoEN.IdResource = objRow[convCourseLearningCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseRelaInfoEN.ResourceID = objRow[convCourseLearningCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvCourseLearningCaseRelaInfoEN.IdResourceType = objRow[convCourseLearningCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objRow[convCourseLearningCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objRow[convCourseLearningCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseRelaInfoEN.MajorID = objRow[convCourseLearningCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseRelaInfoEN.MajorName = objRow[convCourseLearningCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objRow[convCourseLearningCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseRelaInfoEN.CollegeID = objRow[convCourseLearningCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseRelaInfoEN.CollegeName = objRow[convCourseLearningCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseRelaInfoEN.CourseId = objRow[convCourseLearningCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseRelaInfoEN.CourseCode = objRow[convCourseLearningCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseRelaInfoEN.CourseName = objRow[convCourseLearningCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseRelaInfoEN.BrowseCount = objRow[convCourseLearningCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objRow[convCourseLearningCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseRelaInfoEN.ftpFileType = objRow[convCourseLearningCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objRow[convCourseLearningCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCourseLearningCaseRelaInfoEN.FileOriginName = objRow[convCourseLearningCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvCourseLearningCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseRelaInfoEN.Flag = objRow[convCourseLearningCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Flag].ToString().Trim(); //标志
objvCourseLearningCaseRelaInfoEN.FileNewName = objRow[convCourseLearningCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseRelaInfoEN.FileOldName = objRow[convCourseLearningCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvCourseLearningCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseRelaInfoEN.UpdDate = objRow[convCourseLearningCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCaseRelaInfoEN.UpdUser = objRow[convCourseLearningCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvCourseLearningCaseRelaInfoEN.Memo = objRow[convCourseLearningCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseRelaInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCourseLearningCaseRelaInfo(ref clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN)
{
bool bolResult = vCourseLearningCaseRelaInfoDA.GetvCourseLearningCaseRelaInfo(ref objvCourseLearningCaseRelaInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = vCourseLearningCaseRelaInfoDA.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);
return objvCourseLearningCaseRelaInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCourseLearningCaseRelaInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = vCourseLearningCaseRelaInfoDA.GetFirstObj(strWhereCond);
 return objvCourseLearningCaseRelaInfoEN;
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
public static clsvCourseLearningCaseRelaInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = vCourseLearningCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvCourseLearningCaseRelaInfoEN;
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
public static clsvCourseLearningCaseRelaInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = vCourseLearningCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvCourseLearningCaseRelaInfoEN;
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">所给的关键字</param>
 /// <param name = "lstvCourseLearningCaseRelaInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfoFromList(long lngIdMicroTeachCaseRelaInfo, List<clsvCourseLearningCaseRelaInfoEN> lstvCourseLearningCaseRelaInfoObjLst)
{
foreach (clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN in lstvCourseLearningCaseRelaInfoObjLst)
{
if (objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo == lngIdMicroTeachCaseRelaInfo)
{
return objvCourseLearningCaseRelaInfoEN;
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
 long lngIdMicroTeachCaseRelaInfo;
 try
 {
 lngIdMicroTeachCaseRelaInfo = new clsvCourseLearningCaseRelaInfoDA().GetFirstID(strWhereCond);
 return lngIdMicroTeachCaseRelaInfo;
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
 arrList = vCourseLearningCaseRelaInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vCourseLearningCaseRelaInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroTeachCaseRelaInfo)
{
//检测记录是否存在
bool bolIsExist = vCourseLearningCaseRelaInfoDA.IsExist(lngIdMicroTeachCaseRelaInfo);
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
 bolIsExist = clsvCourseLearningCaseRelaInfoDA.IsExistTable();
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
 bolIsExist = vCourseLearningCaseRelaInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvCourseLearningCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCourseLearningCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoENS, clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoENT)
{
try
{
objvCourseLearningCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvCourseLearningCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvCourseLearningCaseRelaInfoENT.FuncModuleId = objvCourseLearningCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseRelaInfoENT.FuncModuleName = objvCourseLearningCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseRelaInfoENT.IdCourseLearningCase = objvCourseLearningCaseRelaInfoENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseRelaInfoENT.IdMicroteachCase = objvCourseLearningCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningCaseRelaInfoENT.CourseLearningCaseName = objvCourseLearningCaseRelaInfoENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvCourseLearningCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvCourseLearningCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvCourseLearningCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoENT.IdFile = objvCourseLearningCaseRelaInfoENS.IdFile; //文件流水号
objvCourseLearningCaseRelaInfoENT.FileName = objvCourseLearningCaseRelaInfoENS.FileName; //文件名称
objvCourseLearningCaseRelaInfoENT.FileType = objvCourseLearningCaseRelaInfoENS.FileType; //文件类型
objvCourseLearningCaseRelaInfoENT.SaveDate = objvCourseLearningCaseRelaInfoENS.SaveDate; //创建日期
objvCourseLearningCaseRelaInfoENT.FileSize = objvCourseLearningCaseRelaInfoENS.FileSize; //文件大小
objvCourseLearningCaseRelaInfoENT.SaveTime = objvCourseLearningCaseRelaInfoENS.SaveTime; //创建时间
objvCourseLearningCaseRelaInfoENT.IdFtpResource = objvCourseLearningCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvCourseLearningCaseRelaInfoENT.FtpResourceID = objvCourseLearningCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvCourseLearningCaseRelaInfoENT.FileOriginalName = objvCourseLearningCaseRelaInfoENS.FileOriginalName; //文件原名
objvCourseLearningCaseRelaInfoENT.FileDirName = objvCourseLearningCaseRelaInfoENS.FileDirName; //文件目录名
objvCourseLearningCaseRelaInfoENT.FileRename = objvCourseLearningCaseRelaInfoENS.FileRename; //文件新名
objvCourseLearningCaseRelaInfoENT.FileUpDate = objvCourseLearningCaseRelaInfoENS.FileUpDate; //创建日期
objvCourseLearningCaseRelaInfoENT.FileUpTime = objvCourseLearningCaseRelaInfoENS.FileUpTime; //创建时间
objvCourseLearningCaseRelaInfoENT.IdResource = objvCourseLearningCaseRelaInfoENS.IdResource; //资源流水号
objvCourseLearningCaseRelaInfoENT.ResourceID = objvCourseLearningCaseRelaInfoENS.ResourceID; //资源ID
objvCourseLearningCaseRelaInfoENT.SaveMode = objvCourseLearningCaseRelaInfoENS.SaveMode; //文件存放方式
objvCourseLearningCaseRelaInfoENT.IdResourceType = objvCourseLearningCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvCourseLearningCaseRelaInfoENT.ResourceTypeID = objvCourseLearningCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvCourseLearningCaseRelaInfoENT.ResourceTypeName = objvCourseLearningCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvCourseLearningCaseRelaInfoENT.MajorID = objvCourseLearningCaseRelaInfoENS.MajorID; //专业ID
objvCourseLearningCaseRelaInfoENT.MajorName = objvCourseLearningCaseRelaInfoENS.MajorName; //专业名称
objvCourseLearningCaseRelaInfoENT.IdXzCollege = objvCourseLearningCaseRelaInfoENS.IdXzCollege; //学院流水号
objvCourseLearningCaseRelaInfoENT.CollegeID = objvCourseLearningCaseRelaInfoENS.CollegeID; //学院ID
objvCourseLearningCaseRelaInfoENT.CollegeName = objvCourseLearningCaseRelaInfoENS.CollegeName; //学院名称
objvCourseLearningCaseRelaInfoENT.CourseId = objvCourseLearningCaseRelaInfoENS.CourseId; //课程Id
objvCourseLearningCaseRelaInfoENT.CourseCode = objvCourseLearningCaseRelaInfoENS.CourseCode; //课程代码
objvCourseLearningCaseRelaInfoENT.CourseName = objvCourseLearningCaseRelaInfoENS.CourseName; //课程名称
objvCourseLearningCaseRelaInfoENT.BrowseCount = objvCourseLearningCaseRelaInfoENS.BrowseCount; //浏览次数
objvCourseLearningCaseRelaInfoENT.ResourceOwner = objvCourseLearningCaseRelaInfoENS.ResourceOwner; //上传者
objvCourseLearningCaseRelaInfoENT.ftpFileType = objvCourseLearningCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvCourseLearningCaseRelaInfoENT.ftpFileSize = objvCourseLearningCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvCourseLearningCaseRelaInfoENT.ftpResourceOwner = objvCourseLearningCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvCourseLearningCaseRelaInfoENT.FileOriginName = objvCourseLearningCaseRelaInfoENS.FileOriginName; //原文件名
objvCourseLearningCaseRelaInfoENT.IsExistFile = objvCourseLearningCaseRelaInfoENS.IsExistFile; //是否存在文件
objvCourseLearningCaseRelaInfoENT.Flag = objvCourseLearningCaseRelaInfoENS.Flag; //标志
objvCourseLearningCaseRelaInfoENT.FileNewName = objvCourseLearningCaseRelaInfoENS.FileNewName; //新文件名
objvCourseLearningCaseRelaInfoENT.FileOldName = objvCourseLearningCaseRelaInfoENS.FileOldName; //旧文件名
objvCourseLearningCaseRelaInfoENT.IsVisible = objvCourseLearningCaseRelaInfoENS.IsVisible; //是否显示
objvCourseLearningCaseRelaInfoENT.UpdDate = objvCourseLearningCaseRelaInfoENS.UpdDate; //修改日期
objvCourseLearningCaseRelaInfoENT.UpdUser = objvCourseLearningCaseRelaInfoENS.UpdUser; //修改人
objvCourseLearningCaseRelaInfoENT.Memo = objvCourseLearningCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objvCourseLearningCaseRelaInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN)
{
try
{
objvCourseLearningCaseRelaInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCourseLearningCaseRelaInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FuncModuleId = objvCourseLearningCaseRelaInfoEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FuncModuleName = objvCourseLearningCaseRelaInfoEN.FuncModuleName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.IdCourseLearningCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase; //课程学习案例流水号
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.IdMicroteachCase = objvCourseLearningCaseRelaInfoEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.CourseLearningCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName; //课程学习案例名称
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfoType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.IdFile = objvCourseLearningCaseRelaInfoEN.IdFile == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FileName = objvCourseLearningCaseRelaInfoEN.FileName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FileName; //文件名称
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FileType = objvCourseLearningCaseRelaInfoEN.FileType == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FileType; //文件类型
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.SaveDate = objvCourseLearningCaseRelaInfoEN.SaveDate == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FileSize = objvCourseLearningCaseRelaInfoEN.FileSize == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.SaveTime = objvCourseLearningCaseRelaInfoEN.SaveTime == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.IdFtpResource = objvCourseLearningCaseRelaInfoEN.IdFtpResource == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FtpResourceID = objvCourseLearningCaseRelaInfoEN.FtpResourceID == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FileOriginalName = objvCourseLearningCaseRelaInfoEN.FileOriginalName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FileDirName = objvCourseLearningCaseRelaInfoEN.FileDirName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FileRename = objvCourseLearningCaseRelaInfoEN.FileRename == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FileUpDate = objvCourseLearningCaseRelaInfoEN.FileUpDate == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FileUpTime = objvCourseLearningCaseRelaInfoEN.FileUpTime == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.IdResource = objvCourseLearningCaseRelaInfoEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.ResourceID = objvCourseLearningCaseRelaInfoEN.ResourceID == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.SaveMode = objvCourseLearningCaseRelaInfoEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.IdResourceType = objvCourseLearningCaseRelaInfoEN.IdResourceType == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = objvCourseLearningCaseRelaInfoEN.ResourceTypeID == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = objvCourseLearningCaseRelaInfoEN.ResourceTypeName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.MajorID = objvCourseLearningCaseRelaInfoEN.MajorID == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.MajorName = objvCourseLearningCaseRelaInfoEN.MajorName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.IdXzCollege = objvCourseLearningCaseRelaInfoEN.IdXzCollege == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.CollegeID = objvCourseLearningCaseRelaInfoEN.CollegeID == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.CollegeName = objvCourseLearningCaseRelaInfoEN.CollegeName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.CourseId = objvCourseLearningCaseRelaInfoEN.CourseId == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.CourseCode = objvCourseLearningCaseRelaInfoEN.CourseCode == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.CourseName = objvCourseLearningCaseRelaInfoEN.CourseName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.BrowseCount = objvCourseLearningCaseRelaInfoEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.ResourceOwner = objvCourseLearningCaseRelaInfoEN.ResourceOwner == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.ftpFileType = objvCourseLearningCaseRelaInfoEN.ftpFileType == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.ftpFileSize = objvCourseLearningCaseRelaInfoEN.ftpFileSize == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = objvCourseLearningCaseRelaInfoEN.ftpResourceOwner == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FileOriginName = objvCourseLearningCaseRelaInfoEN.FileOriginName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.IsExistFile = objvCourseLearningCaseRelaInfoEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.Flag, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.Flag = objvCourseLearningCaseRelaInfoEN.Flag == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.Flag; //标志
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FileNewName = objvCourseLearningCaseRelaInfoEN.FileNewName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.FileOldName = objvCourseLearningCaseRelaInfoEN.FileOldName == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.IsVisible = objvCourseLearningCaseRelaInfoEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.UpdDate = objvCourseLearningCaseRelaInfoEN.UpdDate == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.UpdUser = objvCourseLearningCaseRelaInfoEN.UpdUser == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convCourseLearningCaseRelaInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseRelaInfoEN.Memo = objvCourseLearningCaseRelaInfoEN.Memo == "[null]" ? null :  objvCourseLearningCaseRelaInfoEN.Memo; //备注
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
 /// <param name = "objvCourseLearningCaseRelaInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN)
{
try
{
if (objvCourseLearningCaseRelaInfoEN.FuncModuleName == "[null]") objvCourseLearningCaseRelaInfoEN.FuncModuleName = null; //功能模块名称
if (objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase == "[null]") objvCourseLearningCaseRelaInfoEN.IdCourseLearningCase = null; //课程学习案例流水号
if (objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName == "[null]") objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = null; //课程学习案例名称
if (objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType == "[null]") objvCourseLearningCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = null; //微格案例相关信息类型流水号
if (objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID == "[null]") objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = null; //微格案例相关信息类型ID
if (objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName == "[null]") objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = null; //微格案例相关信息类型名称
if (objvCourseLearningCaseRelaInfoEN.IdFile == "[null]") objvCourseLearningCaseRelaInfoEN.IdFile = null; //文件流水号
if (objvCourseLearningCaseRelaInfoEN.FileName == "[null]") objvCourseLearningCaseRelaInfoEN.FileName = null; //文件名称
if (objvCourseLearningCaseRelaInfoEN.FileType == "[null]") objvCourseLearningCaseRelaInfoEN.FileType = null; //文件类型
if (objvCourseLearningCaseRelaInfoEN.SaveDate == "[null]") objvCourseLearningCaseRelaInfoEN.SaveDate = null; //创建日期
if (objvCourseLearningCaseRelaInfoEN.FileSize == "[null]") objvCourseLearningCaseRelaInfoEN.FileSize = null; //文件大小
if (objvCourseLearningCaseRelaInfoEN.SaveTime == "[null]") objvCourseLearningCaseRelaInfoEN.SaveTime = null; //创建时间
if (objvCourseLearningCaseRelaInfoEN.IdFtpResource == "[null]") objvCourseLearningCaseRelaInfoEN.IdFtpResource = null; //FTP资源流水号
if (objvCourseLearningCaseRelaInfoEN.FtpResourceID == "[null]") objvCourseLearningCaseRelaInfoEN.FtpResourceID = null; //FTP资源ID
if (objvCourseLearningCaseRelaInfoEN.FileOriginalName == "[null]") objvCourseLearningCaseRelaInfoEN.FileOriginalName = null; //文件原名
if (objvCourseLearningCaseRelaInfoEN.FileDirName == "[null]") objvCourseLearningCaseRelaInfoEN.FileDirName = null; //文件目录名
if (objvCourseLearningCaseRelaInfoEN.FileRename == "[null]") objvCourseLearningCaseRelaInfoEN.FileRename = null; //文件新名
if (objvCourseLearningCaseRelaInfoEN.FileUpDate == "[null]") objvCourseLearningCaseRelaInfoEN.FileUpDate = null; //创建日期
if (objvCourseLearningCaseRelaInfoEN.FileUpTime == "[null]") objvCourseLearningCaseRelaInfoEN.FileUpTime = null; //创建时间
if (objvCourseLearningCaseRelaInfoEN.ResourceID == "[null]") objvCourseLearningCaseRelaInfoEN.ResourceID = null; //资源ID
if (objvCourseLearningCaseRelaInfoEN.IdResourceType == "[null]") objvCourseLearningCaseRelaInfoEN.IdResourceType = null; //资源类型流水号
if (objvCourseLearningCaseRelaInfoEN.ResourceTypeID == "[null]") objvCourseLearningCaseRelaInfoEN.ResourceTypeID = null; //资源类型ID
if (objvCourseLearningCaseRelaInfoEN.ResourceTypeName == "[null]") objvCourseLearningCaseRelaInfoEN.ResourceTypeName = null; //资源类型名称
if (objvCourseLearningCaseRelaInfoEN.MajorID == "[null]") objvCourseLearningCaseRelaInfoEN.MajorID = null; //专业ID
if (objvCourseLearningCaseRelaInfoEN.MajorName == "[null]") objvCourseLearningCaseRelaInfoEN.MajorName = null; //专业名称
if (objvCourseLearningCaseRelaInfoEN.IdXzCollege == "[null]") objvCourseLearningCaseRelaInfoEN.IdXzCollege = null; //学院流水号
if (objvCourseLearningCaseRelaInfoEN.CollegeID == "[null]") objvCourseLearningCaseRelaInfoEN.CollegeID = null; //学院ID
if (objvCourseLearningCaseRelaInfoEN.CollegeName == "[null]") objvCourseLearningCaseRelaInfoEN.CollegeName = null; //学院名称
if (objvCourseLearningCaseRelaInfoEN.CourseId == "[null]") objvCourseLearningCaseRelaInfoEN.CourseId = null; //课程Id
if (objvCourseLearningCaseRelaInfoEN.CourseCode == "[null]") objvCourseLearningCaseRelaInfoEN.CourseCode = null; //课程代码
if (objvCourseLearningCaseRelaInfoEN.CourseName == "[null]") objvCourseLearningCaseRelaInfoEN.CourseName = null; //课程名称
if (objvCourseLearningCaseRelaInfoEN.ResourceOwner == "[null]") objvCourseLearningCaseRelaInfoEN.ResourceOwner = null; //上传者
if (objvCourseLearningCaseRelaInfoEN.ftpFileType == "[null]") objvCourseLearningCaseRelaInfoEN.ftpFileType = null; //ftp文件类型
if (objvCourseLearningCaseRelaInfoEN.ftpFileSize == "[null]") objvCourseLearningCaseRelaInfoEN.ftpFileSize = null; //ftp文件大小
if (objvCourseLearningCaseRelaInfoEN.ftpResourceOwner == "[null]") objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvCourseLearningCaseRelaInfoEN.FileOriginName == "[null]") objvCourseLearningCaseRelaInfoEN.FileOriginName = null; //原文件名
if (objvCourseLearningCaseRelaInfoEN.Flag == "[null]") objvCourseLearningCaseRelaInfoEN.Flag = null; //标志
if (objvCourseLearningCaseRelaInfoEN.FileNewName == "[null]") objvCourseLearningCaseRelaInfoEN.FileNewName = null; //新文件名
if (objvCourseLearningCaseRelaInfoEN.FileOldName == "[null]") objvCourseLearningCaseRelaInfoEN.FileOldName = null; //旧文件名
if (objvCourseLearningCaseRelaInfoEN.UpdDate == "[null]") objvCourseLearningCaseRelaInfoEN.UpdDate = null; //修改日期
if (objvCourseLearningCaseRelaInfoEN.UpdUser == "[null]") objvCourseLearningCaseRelaInfoEN.UpdUser = null; //修改人
if (objvCourseLearningCaseRelaInfoEN.Memo == "[null]") objvCourseLearningCaseRelaInfoEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN)
{
 vCourseLearningCaseRelaInfoDA.CheckProperty4Condition(objvCourseLearningCaseRelaInfoEN);
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
if (clsMicroTeachCaseRelaInfoTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoTypeBL没有刷新缓存机制(clsMicroTeachCaseRelaInfoTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroTeachCaseRelaInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoBL没有刷新缓存机制(clsMicroTeachCaseRelaInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseBL没有刷新缓存机制(clsCourseLearningCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseTypeBL没有刷新缓存机制(clsCourseLearningCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseTypeBL没有刷新缓存机制(clsCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeBL没有刷新缓存机制(clsXzDegreeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeBL没有刷新缓存机制(clsXzMajorTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeBL没有刷新缓存机制(clsXzMajorShoolTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeBL没有刷新缓存机制(clsSkillTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillBL没有刷新缓存机制(clsTeachSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroTeachCaseRelaInfo");
//if (arrvCourseLearningCaseRelaInfoObjLstCache == null)
//{
//arrvCourseLearningCaseRelaInfoObjLstCache = vCourseLearningCaseRelaInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfoCache(long lngIdMicroTeachCaseRelaInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCourseLearningCaseRelaInfoEN._CurrTabName);
List<clsvCourseLearningCaseRelaInfoEN> arrvCourseLearningCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseRelaInfoEN> arrvCourseLearningCaseRelaInfoObjLst_Sel =
arrvCourseLearningCaseRelaInfoObjLstCache
.Where(x=> x.IdMicroTeachCaseRelaInfo == lngIdMicroTeachCaseRelaInfo 
);
if (arrvCourseLearningCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCaseRelaInfoEN obj = clsvCourseLearningCaseRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCourseLearningCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCaseRelaInfoEN> GetAllvCourseLearningCaseRelaInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsvCourseLearningCaseRelaInfoEN> arrvCourseLearningCaseRelaInfoObjLstCache = GetObjLstCache(); 
return arrvCourseLearningCaseRelaInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCaseRelaInfoEN._CurrTabName);
List<clsvCourseLearningCaseRelaInfoEN> arrvCourseLearningCaseRelaInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCaseRelaInfoObjLstCache;
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
string strKey = string.Format("{0}", clsvCourseLearningCaseRelaInfoEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroTeachCaseRelaInfo)
{
if (strInFldName != convCourseLearningCaseRelaInfo.IdMicroTeachCaseRelaInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCourseLearningCaseRelaInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCourseLearningCaseRelaInfo.AttributeName));
throw new Exception(strMsg);
}
var objvCourseLearningCaseRelaInfo = clsvCourseLearningCaseRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfoCache(lngIdMicroTeachCaseRelaInfo);
if (objvCourseLearningCaseRelaInfo == null) return "";
return objvCourseLearningCaseRelaInfo[strOutFldName].ToString();
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
int intRecCount = clsvCourseLearningCaseRelaInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvCourseLearningCaseRelaInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCourseLearningCaseRelaInfoDA.GetRecCount();
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
int intRecCount = clsvCourseLearningCaseRelaInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoCond)
{
List<clsvCourseLearningCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCaseRelaInfo.AttributeName)
{
if (objvCourseLearningCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseRelaInfoCond[strFldName]));
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
 List<string> arrList = clsvCourseLearningCaseRelaInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCaseRelaInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCaseRelaInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}