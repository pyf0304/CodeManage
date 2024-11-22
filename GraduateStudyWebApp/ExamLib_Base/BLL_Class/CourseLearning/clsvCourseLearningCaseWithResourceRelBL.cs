
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseWithResourceRelBL
 表名:vCourseLearningCaseWithResourceRel(01120472)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:00
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
public static class  clsvCourseLearningCaseWithResourceRelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseWithResourceRelEN GetObj(this K_IdCourseLearningCase_vCourseLearningCaseWithResourceRel myKey)
{
clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = clsvCourseLearningCaseWithResourceRelBL.vCourseLearningCaseWithResourceRelDA.GetObjByIdCourseLearningCase(myKey.Value);
return objvCourseLearningCaseWithResourceRelEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdCourseLearningCase(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdCourseLearningCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCase, 8, convCourseLearningCaseWithResourceRel.IdCourseLearningCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCase, 8, convCourseLearningCaseWithResourceRel.IdCourseLearningCase);
}
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = strIdCourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdCourseLearningCase) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdCourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdCourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdMicroteachCaseResourceRel(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, long? lngIdMicroteachCaseResourceRel, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = lngIdMicroteachCaseResourceRel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetFuncModuleId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningCaseWithResourceRel.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningCaseWithResourceRel.FuncModuleId);
}
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.FuncModuleId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetFuncModuleName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningCaseWithResourceRel.FuncModuleName);
}
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.FuncModuleName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdResource(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convCourseLearningCaseWithResourceRel.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convCourseLearningCaseWithResourceRel.IdResource);
}
objvCourseLearningCaseWithResourceRelEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdResource) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdResource, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdResource] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetResourceID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convCourseLearningCaseWithResourceRel.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convCourseLearningCaseWithResourceRel.ResourceID);
}
objvCourseLearningCaseWithResourceRelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ResourceID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ResourceID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetResourceName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convCourseLearningCaseWithResourceRel.ResourceName);
}
objvCourseLearningCaseWithResourceRelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ResourceName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ResourceName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdFtpResource(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convCourseLearningCaseWithResourceRel.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convCourseLearningCaseWithResourceRel.IdFtpResource);
}
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdFtpResource) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdFtpResource, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdFtpResource] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdFile(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convCourseLearningCaseWithResourceRel.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convCourseLearningCaseWithResourceRel.IdFile);
}
objvCourseLearningCaseWithResourceRelEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdFile) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdFile, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdFile] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetFileSize(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convCourseLearningCaseWithResourceRel.FileSize);
}
objvCourseLearningCaseWithResourceRelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.FileSize) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.FileSize, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileSize] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetSaveTime(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convCourseLearningCaseWithResourceRel.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convCourseLearningCaseWithResourceRel.SaveTime);
}
objvCourseLearningCaseWithResourceRelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.SaveTime) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.SaveTime, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SaveTime] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdResourceType(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convCourseLearningCaseWithResourceRel.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convCourseLearningCaseWithResourceRel.IdResourceType);
}
objvCourseLearningCaseWithResourceRelEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdResourceType) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdResourceType, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdResourceType] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetResourceTypeID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convCourseLearningCaseWithResourceRel.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convCourseLearningCaseWithResourceRel.ResourceTypeID);
}
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ResourceTypeID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ResourceTypeID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceTypeID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetResourceTypeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convCourseLearningCaseWithResourceRel.ResourceTypeName);
}
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ResourceTypeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ResourceTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetResourceOwner(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convCourseLearningCaseWithResourceRel.ResourceOwner);
}
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ResourceOwner) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ResourceOwner, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceOwner] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsExistFile(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsExistFile) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsExistFile, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsExistFile] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetFileNewName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convCourseLearningCaseWithResourceRel.FileNewName);
}
objvCourseLearningCaseWithResourceRelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.FileNewName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.FileNewName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileNewName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsMain(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsMain, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsMain) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsMain, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsMain] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, convCourseLearningCaseWithResourceRel.CourseLearningCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseID);
}
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningCaseWithResourceRel.CourseLearningCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCaseWithResourceRel.CourseLearningCaseName);
}
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseText(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseText, 8000, convCourseLearningCaseWithResourceRel.CourseLearningCaseText);
}
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = strCourseLearningCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseText) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseText, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseTheme(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme);
}
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseDate(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseDate);
}
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseDate) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseDate, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseTime(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningCaseWithResourceRel.CourseLearningCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningCaseWithResourceRel.CourseLearningCaseTime);
}
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseTime) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTime, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseDateIn(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn);
}
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseTimeIn(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn);
}
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdCaseType(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convCourseLearningCaseWithResourceRel.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convCourseLearningCaseWithResourceRel.IdCaseType);
}
objvCourseLearningCaseWithResourceRelEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdCaseType) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdCaseType, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdCaseType] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdCourseLearningCaseType(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdCourseLearningCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCourseLearningCaseType, convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCaseType, 4, convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCaseType, 4, convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType);
}
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = strIdCourseLearningCaseType; //课程学习案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseTypeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName);
}
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = strCourseLearningCaseTypeName; //课程学习案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetOwnerId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCourseLearningCaseWithResourceRel.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCourseLearningCaseWithResourceRel.OwnerId);
}
objvCourseLearningCaseWithResourceRelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.OwnerId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.OwnerId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdStudyLevel(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convCourseLearningCaseWithResourceRel.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convCourseLearningCaseWithResourceRel.IdStudyLevel);
}
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdStudyLevel) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdStudyLevel, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdStudyLevel] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetStudyLevelName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCourseLearningCaseWithResourceRel.StudyLevelName);
}
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.StudyLevelName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.StudyLevelName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.StudyLevelName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdTeachingPlan(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convCourseLearningCaseWithResourceRel.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convCourseLearningCaseWithResourceRel.IdTeachingPlan);
}
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdTeachingPlan) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdTeachingPlan, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdTeachingPlan] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdDiscipline(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convCourseLearningCaseWithResourceRel.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convCourseLearningCaseWithResourceRel.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convCourseLearningCaseWithResourceRel.IdDiscipline);
}
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdDiscipline) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdDiscipline, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdDiscipline] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetDisciplineID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strDisciplineID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCourseLearningCaseWithResourceRel.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCourseLearningCaseWithResourceRel.DisciplineID);
}
objvCourseLearningCaseWithResourceRelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.DisciplineID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.DisciplineID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DisciplineID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetDisciplineName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strDisciplineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCourseLearningCaseWithResourceRel.DisciplineName);
}
objvCourseLearningCaseWithResourceRelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.DisciplineName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.DisciplineName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DisciplineName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetBrowseCount(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int? intBrowseCount, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.BrowseCount) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.BrowseCount, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.BrowseCount] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdSenateGaugeVersion(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion);
}
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetsenateGaugeVersionID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCourseLearningCaseWithResourceRel.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCourseLearningCaseWithResourceRel.senateGaugeVersionID);
}
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.senateGaugeVersionID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetsenateGaugeVersionName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCourseLearningCaseWithResourceRel.senateGaugeVersionName);
}
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.senateGaugeVersionName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetsenateGaugeVersionTtlScore(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetVersionNo(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int? intVersionNo, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.VersionNo) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.VersionNo, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.VersionNo] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdTeachSkill(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convCourseLearningCaseWithResourceRel.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convCourseLearningCaseWithResourceRel.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convCourseLearningCaseWithResourceRel.IdTeachSkill);
}
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdTeachSkill) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdTeachSkill, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdTeachSkill] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetTeachSkillID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strTeachSkillID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCourseLearningCaseWithResourceRel.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCourseLearningCaseWithResourceRel.TeachSkillID);
}
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.TeachSkillID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.TeachSkillID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetSkillTypeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCourseLearningCaseWithResourceRel.SkillTypeName);
}
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.SkillTypeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.SkillTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SkillTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetTeachSkillName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strTeachSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCourseLearningCaseWithResourceRel.TeachSkillName);
}
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.TeachSkillName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.TeachSkillName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetTeachSkillTheory(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCourseLearningCaseWithResourceRel.TeachSkillTheory);
}
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.TeachSkillTheory) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.TeachSkillTheory, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillTheory] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetTeachSkillOperMethod(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCourseLearningCaseWithResourceRel.TeachSkillOperMethod);
}
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.TeachSkillOperMethod) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdSkillType(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convCourseLearningCaseWithResourceRel.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convCourseLearningCaseWithResourceRel.IdSkillType);
}
objvCourseLearningCaseWithResourceRelEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdSkillType) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdSkillType, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdSkillType] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetSkillTypeID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCourseLearningCaseWithResourceRel.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCourseLearningCaseWithResourceRel.SkillTypeID);
}
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.SkillTypeID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.SkillTypeID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SkillTypeID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCaseLevelId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCourseLearningCaseWithResourceRel.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCourseLearningCaseWithResourceRel.CaseLevelId);
}
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CaseLevelId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CaseLevelId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseLevelId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCaseLevelName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCaseLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convCourseLearningCaseWithResourceRel.CaseLevelName);
}
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CaseLevelName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CaseLevelName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseLevelName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetDocFile(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCourseLearningCaseWithResourceRel.DocFile);
}
objvCourseLearningCaseWithResourceRelEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.DocFile) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.DocFile, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DocFile] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsNeedGeneWord(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsNeedGeneWord) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetWordCreateDate(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCourseLearningCaseWithResourceRel.WordCreateDate);
}
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.WordCreateDate) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.WordCreateDate, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.WordCreateDate] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsVisible(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsVisible) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsVisible, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsVisible] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsDualVideo(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsDualVideo) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsDualVideo, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsDualVideo] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdXzCollege(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, convCourseLearningCaseWithResourceRel.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCourseLearningCaseWithResourceRel.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCourseLearningCaseWithResourceRel.IdXzCollege);
}
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdXzCollege) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdXzCollege, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdXzCollege] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCollegeID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningCaseWithResourceRel.CollegeID);
}
objvCourseLearningCaseWithResourceRelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CollegeID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CollegeID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCollegeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCaseWithResourceRel.CollegeName);
}
objvCourseLearningCaseWithResourceRelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CollegeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCollegeNameA(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningCaseWithResourceRel.CollegeNameA);
}
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CollegeNameA) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CollegeNameA, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeNameA] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIdXzMajor(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convCourseLearningCaseWithResourceRel.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convCourseLearningCaseWithResourceRel.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convCourseLearningCaseWithResourceRel.IdXzMajor);
}
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IdXzMajor) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IdXzMajor, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdXzMajor] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetMajorID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCaseWithResourceRel.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCaseWithResourceRel.MajorID);
}
objvCourseLearningCaseWithResourceRelEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.MajorID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.MajorID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.MajorID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetMajorName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCaseWithResourceRel.MajorName);
}
objvCourseLearningCaseWithResourceRelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.MajorName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.MajorName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.MajorName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCourseLearningCaseWithResourceRel.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCaseWithResourceRel.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCaseWithResourceRel.CourseId);
}
objvCourseLearningCaseWithResourceRelEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseCode(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCaseWithResourceRel.CourseCode);
}
objvCourseLearningCaseWithResourceRelEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseCode) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCaseWithResourceRel.CourseName);
}
objvCourseLearningCaseWithResourceRelEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetTeachingSolutionId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionId, convCourseLearningCaseWithResourceRel.TeachingSolutionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCourseLearningCaseWithResourceRel.TeachingSolutionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCourseLearningCaseWithResourceRel.TeachingSolutionId);
}
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.TeachingSolutionId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.TeachingSolutionId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachingSolutionId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseChapterId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCaseWithResourceRel.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCaseWithResourceRel.CourseChapterId);
}
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseChapterId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseChapterId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseChapterName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCourseLearningCaseWithResourceRel.CourseChapterName);
}
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseChapterName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseChapterName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetParentNodeID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strParentNodeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convCourseLearningCaseWithResourceRel.ParentNodeID);
}
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ParentNodeID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ParentNodeID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetParentNodeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strParentNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convCourseLearningCaseWithResourceRel.ParentNodeName);
}
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ParentNodeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ParentNodeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseChapterReferred(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convCourseLearningCaseWithResourceRel.CourseChapterReferred);
}
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseChapterReferred) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseChapterReferred, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterReferred] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetParentNodeReferred(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strParentNodeReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convCourseLearningCaseWithResourceRel.ParentNodeReferred);
}
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ParentNodeReferred) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ParentNodeReferred, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeReferred] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetViewCount(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int? intViewCount, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ViewCount) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ViewCount, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ViewCount] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsShow(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsShow, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsShow) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsShow, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsShow] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetDownloadNumber(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.DownloadNumber) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.DownloadNumber, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DownloadNumber] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetFileIntegration(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int? intFileIntegration, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.FileIntegration) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.FileIntegration, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileIntegration] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetLikeCount(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, long? lngLikeCount, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.LikeCount) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.LikeCount, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.LikeCount] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCollectionCount(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CollectionCount) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CollectionCount, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollectionCount] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetRecommendedDegreeId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCourseLearningCaseWithResourceRel.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCourseLearningCaseWithResourceRel.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCourseLearningCaseWithResourceRel.RecommendedDegreeId);
}
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.RecommendedDegreeId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetRecommendedDegreeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCourseLearningCaseWithResourceRel.RecommendedDegreeName);
}
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.RecommendedDegreeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetMemo(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCaseWithResourceRel.Memo);
}
objvCourseLearningCaseWithResourceRelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.Memo) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.Memo, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.Memo] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetBrowseCount4Case(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.BrowseCount4Case) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.BrowseCount4Case, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.BrowseCount4Case] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetOwnerName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCourseLearningCaseWithResourceRel.OwnerName);
}
objvCourseLearningCaseWithResourceRelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.OwnerName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.OwnerName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetOwnerNameWithId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCourseLearningCaseWithResourceRel.OwnerNameWithId);
}
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.OwnerNameWithId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.OwnerNameWithId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerNameWithId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCaseTypeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTypeName, 50, convCourseLearningCaseWithResourceRel.CaseTypeName);
}
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = strCaseTypeName; //案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CaseTypeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelENS">源对象</param>
 /// <param name = "objvCourseLearningCaseWithResourceRelENT">目标对象</param>
 public static void CopyTo(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelENS, clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelENT)
{
try
{
objvCourseLearningCaseWithResourceRelENT.IdCourseLearningCase = objvCourseLearningCaseWithResourceRelENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseWithResourceRelENT.IdMicroteachCaseResourceRel = objvCourseLearningCaseWithResourceRelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelENT.FuncModuleId = objvCourseLearningCaseWithResourceRelENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseWithResourceRelENT.FuncModuleName = objvCourseLearningCaseWithResourceRelENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseWithResourceRelENT.IdResource = objvCourseLearningCaseWithResourceRelENS.IdResource; //资源流水号
objvCourseLearningCaseWithResourceRelENT.ResourceID = objvCourseLearningCaseWithResourceRelENS.ResourceID; //资源ID
objvCourseLearningCaseWithResourceRelENT.ResourceName = objvCourseLearningCaseWithResourceRelENS.ResourceName; //资源名称
objvCourseLearningCaseWithResourceRelENT.IdFtpResource = objvCourseLearningCaseWithResourceRelENS.IdFtpResource; //FTP资源流水号
objvCourseLearningCaseWithResourceRelENT.IdFile = objvCourseLearningCaseWithResourceRelENS.IdFile; //文件流水号
objvCourseLearningCaseWithResourceRelENT.FileSize = objvCourseLearningCaseWithResourceRelENS.FileSize; //文件大小
objvCourseLearningCaseWithResourceRelENT.SaveTime = objvCourseLearningCaseWithResourceRelENS.SaveTime; //创建时间
objvCourseLearningCaseWithResourceRelENT.IdResourceType = objvCourseLearningCaseWithResourceRelENS.IdResourceType; //资源类型流水号
objvCourseLearningCaseWithResourceRelENT.ResourceTypeID = objvCourseLearningCaseWithResourceRelENS.ResourceTypeID; //资源类型ID
objvCourseLearningCaseWithResourceRelENT.ResourceTypeName = objvCourseLearningCaseWithResourceRelENS.ResourceTypeName; //资源类型名称
objvCourseLearningCaseWithResourceRelENT.ResourceOwner = objvCourseLearningCaseWithResourceRelENS.ResourceOwner; //上传者
objvCourseLearningCaseWithResourceRelENT.IsExistFile = objvCourseLearningCaseWithResourceRelENS.IsExistFile; //是否存在文件
objvCourseLearningCaseWithResourceRelENT.FileNewName = objvCourseLearningCaseWithResourceRelENS.FileNewName; //新文件名
objvCourseLearningCaseWithResourceRelENT.IsMain = objvCourseLearningCaseWithResourceRelENS.IsMain; //是否主资源
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseID = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseName = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseText = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTheme = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseDate = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTime = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseDateIn = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTimeIn = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCaseWithResourceRelENT.IdCaseType = objvCourseLearningCaseWithResourceRelENS.IdCaseType; //案例类型流水号
objvCourseLearningCaseWithResourceRelENT.IdCourseLearningCaseType = objvCourseLearningCaseWithResourceRelENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTypeName = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelENT.OwnerId = objvCourseLearningCaseWithResourceRelENS.OwnerId; //拥有者Id
objvCourseLearningCaseWithResourceRelENT.IdStudyLevel = objvCourseLearningCaseWithResourceRelENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCaseWithResourceRelENT.StudyLevelName = objvCourseLearningCaseWithResourceRelENS.StudyLevelName; //学段名称
objvCourseLearningCaseWithResourceRelENT.IdTeachingPlan = objvCourseLearningCaseWithResourceRelENS.IdTeachingPlan; //教案流水号
objvCourseLearningCaseWithResourceRelENT.IdDiscipline = objvCourseLearningCaseWithResourceRelENS.IdDiscipline; //学科流水号
objvCourseLearningCaseWithResourceRelENT.DisciplineID = objvCourseLearningCaseWithResourceRelENS.DisciplineID; //学科ID
objvCourseLearningCaseWithResourceRelENT.DisciplineName = objvCourseLearningCaseWithResourceRelENS.DisciplineName; //学科名称
objvCourseLearningCaseWithResourceRelENT.BrowseCount = objvCourseLearningCaseWithResourceRelENS.BrowseCount; //浏览次数
objvCourseLearningCaseWithResourceRelENT.IdSenateGaugeVersion = objvCourseLearningCaseWithResourceRelENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionID = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionName = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionTtlScore = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCaseWithResourceRelENT.VersionNo = objvCourseLearningCaseWithResourceRelENS.VersionNo; //版本号
objvCourseLearningCaseWithResourceRelENT.IdTeachSkill = objvCourseLearningCaseWithResourceRelENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCaseWithResourceRelENT.TeachSkillID = objvCourseLearningCaseWithResourceRelENS.TeachSkillID; //教学技能ID
objvCourseLearningCaseWithResourceRelENT.SkillTypeName = objvCourseLearningCaseWithResourceRelENS.SkillTypeName; //技能类型名称
objvCourseLearningCaseWithResourceRelENT.TeachSkillName = objvCourseLearningCaseWithResourceRelENS.TeachSkillName; //教学技能名称
objvCourseLearningCaseWithResourceRelENT.TeachSkillTheory = objvCourseLearningCaseWithResourceRelENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCaseWithResourceRelENT.TeachSkillOperMethod = objvCourseLearningCaseWithResourceRelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelENT.IdSkillType = objvCourseLearningCaseWithResourceRelENS.IdSkillType; //技能类型流水号
objvCourseLearningCaseWithResourceRelENT.SkillTypeID = objvCourseLearningCaseWithResourceRelENS.SkillTypeID; //技能类型ID
objvCourseLearningCaseWithResourceRelENT.CaseLevelId = objvCourseLearningCaseWithResourceRelENS.CaseLevelId; //课例等级Id
objvCourseLearningCaseWithResourceRelENT.CaseLevelName = objvCourseLearningCaseWithResourceRelENS.CaseLevelName; //案例等级名称
objvCourseLearningCaseWithResourceRelENT.DocFile = objvCourseLearningCaseWithResourceRelENS.DocFile; //生成的Word文件名
objvCourseLearningCaseWithResourceRelENT.IsNeedGeneWord = objvCourseLearningCaseWithResourceRelENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCaseWithResourceRelENT.WordCreateDate = objvCourseLearningCaseWithResourceRelENS.WordCreateDate; //Word生成日期
objvCourseLearningCaseWithResourceRelENT.IsVisible = objvCourseLearningCaseWithResourceRelENS.IsVisible; //是否显示
objvCourseLearningCaseWithResourceRelENT.IsDualVideo = objvCourseLearningCaseWithResourceRelENS.IsDualVideo; //是否双视频
objvCourseLearningCaseWithResourceRelENT.IdXzCollege = objvCourseLearningCaseWithResourceRelENS.IdXzCollege; //学院流水号
objvCourseLearningCaseWithResourceRelENT.CollegeID = objvCourseLearningCaseWithResourceRelENS.CollegeID; //学院ID
objvCourseLearningCaseWithResourceRelENT.CollegeName = objvCourseLearningCaseWithResourceRelENS.CollegeName; //学院名称
objvCourseLearningCaseWithResourceRelENT.CollegeNameA = objvCourseLearningCaseWithResourceRelENS.CollegeNameA; //学院名称简写
objvCourseLearningCaseWithResourceRelENT.IdXzMajor = objvCourseLearningCaseWithResourceRelENS.IdXzMajor; //专业流水号
objvCourseLearningCaseWithResourceRelENT.MajorID = objvCourseLearningCaseWithResourceRelENS.MajorID; //专业ID
objvCourseLearningCaseWithResourceRelENT.MajorName = objvCourseLearningCaseWithResourceRelENS.MajorName; //专业名称
objvCourseLearningCaseWithResourceRelENT.CourseId = objvCourseLearningCaseWithResourceRelENS.CourseId; //课程Id
objvCourseLearningCaseWithResourceRelENT.CourseCode = objvCourseLearningCaseWithResourceRelENS.CourseCode; //课程代码
objvCourseLearningCaseWithResourceRelENT.CourseName = objvCourseLearningCaseWithResourceRelENS.CourseName; //课程名称
objvCourseLearningCaseWithResourceRelENT.TeachingSolutionId = objvCourseLearningCaseWithResourceRelENS.TeachingSolutionId; //教学方案Id
objvCourseLearningCaseWithResourceRelENT.CourseChapterId = objvCourseLearningCaseWithResourceRelENS.CourseChapterId; //课程章节ID
objvCourseLearningCaseWithResourceRelENT.CourseChapterName = objvCourseLearningCaseWithResourceRelENS.CourseChapterName; //课程章节名称
objvCourseLearningCaseWithResourceRelENT.ParentNodeID = objvCourseLearningCaseWithResourceRelENS.ParentNodeID; //父节点编号
objvCourseLearningCaseWithResourceRelENT.ParentNodeName = objvCourseLearningCaseWithResourceRelENS.ParentNodeName; //父节点名称
objvCourseLearningCaseWithResourceRelENT.CourseChapterReferred = objvCourseLearningCaseWithResourceRelENS.CourseChapterReferred; //节简称
objvCourseLearningCaseWithResourceRelENT.ParentNodeReferred = objvCourseLearningCaseWithResourceRelENS.ParentNodeReferred; //章简称
objvCourseLearningCaseWithResourceRelENT.ViewCount = objvCourseLearningCaseWithResourceRelENS.ViewCount; //浏览量
objvCourseLearningCaseWithResourceRelENT.IsShow = objvCourseLearningCaseWithResourceRelENS.IsShow; //是否启用
objvCourseLearningCaseWithResourceRelENT.DownloadNumber = objvCourseLearningCaseWithResourceRelENS.DownloadNumber; //下载数目
objvCourseLearningCaseWithResourceRelENT.FileIntegration = objvCourseLearningCaseWithResourceRelENS.FileIntegration; //文件积分
objvCourseLearningCaseWithResourceRelENT.LikeCount = objvCourseLearningCaseWithResourceRelENS.LikeCount; //资源喜欢数量
objvCourseLearningCaseWithResourceRelENT.CollectionCount = objvCourseLearningCaseWithResourceRelENS.CollectionCount; //收藏数量
objvCourseLearningCaseWithResourceRelENT.RecommendedDegreeId = objvCourseLearningCaseWithResourceRelENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCaseWithResourceRelENT.RecommendedDegreeName = objvCourseLearningCaseWithResourceRelENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCaseWithResourceRelENT.Memo = objvCourseLearningCaseWithResourceRelENS.Memo; //备注
objvCourseLearningCaseWithResourceRelENT.BrowseCount4Case = objvCourseLearningCaseWithResourceRelENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCaseWithResourceRelENT.OwnerName = objvCourseLearningCaseWithResourceRelENS.OwnerName; //拥有者姓名
objvCourseLearningCaseWithResourceRelENT.OwnerNameWithId = objvCourseLearningCaseWithResourceRelENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCaseWithResourceRelENT.CaseTypeName = objvCourseLearningCaseWithResourceRelENS.CaseTypeName; //案例类型名称
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
 /// <param name = "objvCourseLearningCaseWithResourceRelENS">源对象</param>
 /// <returns>目标对象=>clsvCourseLearningCaseWithResourceRelEN:objvCourseLearningCaseWithResourceRelENT</returns>
 public static clsvCourseLearningCaseWithResourceRelEN CopyTo(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelENS)
{
try
{
 clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelENT = new clsvCourseLearningCaseWithResourceRelEN()
{
IdCourseLearningCase = objvCourseLearningCaseWithResourceRelENS.IdCourseLearningCase, //课程学习案例流水号
IdMicroteachCaseResourceRel = objvCourseLearningCaseWithResourceRelENS.IdMicroteachCaseResourceRel, //微格案例资源关系流水号
FuncModuleId = objvCourseLearningCaseWithResourceRelENS.FuncModuleId, //功能模块Id
FuncModuleName = objvCourseLearningCaseWithResourceRelENS.FuncModuleName, //功能模块名称
IdResource = objvCourseLearningCaseWithResourceRelENS.IdResource, //资源流水号
ResourceID = objvCourseLearningCaseWithResourceRelENS.ResourceID, //资源ID
ResourceName = objvCourseLearningCaseWithResourceRelENS.ResourceName, //资源名称
IdFtpResource = objvCourseLearningCaseWithResourceRelENS.IdFtpResource, //FTP资源流水号
IdFile = objvCourseLearningCaseWithResourceRelENS.IdFile, //文件流水号
FileSize = objvCourseLearningCaseWithResourceRelENS.FileSize, //文件大小
SaveTime = objvCourseLearningCaseWithResourceRelENS.SaveTime, //创建时间
IdResourceType = objvCourseLearningCaseWithResourceRelENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvCourseLearningCaseWithResourceRelENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvCourseLearningCaseWithResourceRelENS.ResourceTypeName, //资源类型名称
ResourceOwner = objvCourseLearningCaseWithResourceRelENS.ResourceOwner, //上传者
IsExistFile = objvCourseLearningCaseWithResourceRelENS.IsExistFile, //是否存在文件
FileNewName = objvCourseLearningCaseWithResourceRelENS.FileNewName, //新文件名
IsMain = objvCourseLearningCaseWithResourceRelENS.IsMain, //是否主资源
CourseLearningCaseID = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseID, //课程学习案例ID
CourseLearningCaseName = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseName, //课程学习案例名称
CourseLearningCaseText = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseText, //案例文本内容
CourseLearningCaseTheme = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTheme, //课程学习案例主题词
CourseLearningCaseDate = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseDate, //课程学习日期
CourseLearningCaseTime = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTime, //课程学习时间
CourseLearningCaseDateIn = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseDateIn, //案例入库日期
CourseLearningCaseTimeIn = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTimeIn, //案例入库时间
IdCaseType = objvCourseLearningCaseWithResourceRelENS.IdCaseType, //案例类型流水号
IdCourseLearningCaseType = objvCourseLearningCaseWithResourceRelENS.IdCourseLearningCaseType, //课程学习案例类型流水号
CourseLearningCaseTypeName = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTypeName, //课程学习案例类型名称
OwnerId = objvCourseLearningCaseWithResourceRelENS.OwnerId, //拥有者Id
IdStudyLevel = objvCourseLearningCaseWithResourceRelENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvCourseLearningCaseWithResourceRelENS.StudyLevelName, //学段名称
IdTeachingPlan = objvCourseLearningCaseWithResourceRelENS.IdTeachingPlan, //教案流水号
IdDiscipline = objvCourseLearningCaseWithResourceRelENS.IdDiscipline, //学科流水号
DisciplineID = objvCourseLearningCaseWithResourceRelENS.DisciplineID, //学科ID
DisciplineName = objvCourseLearningCaseWithResourceRelENS.DisciplineName, //学科名称
BrowseCount = objvCourseLearningCaseWithResourceRelENS.BrowseCount, //浏览次数
IdSenateGaugeVersion = objvCourseLearningCaseWithResourceRelENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionTtlScore, //评价量表版本总分
VersionNo = objvCourseLearningCaseWithResourceRelENS.VersionNo, //版本号
IdTeachSkill = objvCourseLearningCaseWithResourceRelENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvCourseLearningCaseWithResourceRelENS.TeachSkillID, //教学技能ID
SkillTypeName = objvCourseLearningCaseWithResourceRelENS.SkillTypeName, //技能类型名称
TeachSkillName = objvCourseLearningCaseWithResourceRelENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvCourseLearningCaseWithResourceRelENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvCourseLearningCaseWithResourceRelENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvCourseLearningCaseWithResourceRelENS.IdSkillType, //技能类型流水号
SkillTypeID = objvCourseLearningCaseWithResourceRelENS.SkillTypeID, //技能类型ID
CaseLevelId = objvCourseLearningCaseWithResourceRelENS.CaseLevelId, //课例等级Id
CaseLevelName = objvCourseLearningCaseWithResourceRelENS.CaseLevelName, //案例等级名称
DocFile = objvCourseLearningCaseWithResourceRelENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvCourseLearningCaseWithResourceRelENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objvCourseLearningCaseWithResourceRelENS.WordCreateDate, //Word生成日期
IsVisible = objvCourseLearningCaseWithResourceRelENS.IsVisible, //是否显示
IsDualVideo = objvCourseLearningCaseWithResourceRelENS.IsDualVideo, //是否双视频
IdXzCollege = objvCourseLearningCaseWithResourceRelENS.IdXzCollege, //学院流水号
CollegeID = objvCourseLearningCaseWithResourceRelENS.CollegeID, //学院ID
CollegeName = objvCourseLearningCaseWithResourceRelENS.CollegeName, //学院名称
CollegeNameA = objvCourseLearningCaseWithResourceRelENS.CollegeNameA, //学院名称简写
IdXzMajor = objvCourseLearningCaseWithResourceRelENS.IdXzMajor, //专业流水号
MajorID = objvCourseLearningCaseWithResourceRelENS.MajorID, //专业ID
MajorName = objvCourseLearningCaseWithResourceRelENS.MajorName, //专业名称
CourseId = objvCourseLearningCaseWithResourceRelENS.CourseId, //课程Id
CourseCode = objvCourseLearningCaseWithResourceRelENS.CourseCode, //课程代码
CourseName = objvCourseLearningCaseWithResourceRelENS.CourseName, //课程名称
TeachingSolutionId = objvCourseLearningCaseWithResourceRelENS.TeachingSolutionId, //教学方案Id
CourseChapterId = objvCourseLearningCaseWithResourceRelENS.CourseChapterId, //课程章节ID
CourseChapterName = objvCourseLearningCaseWithResourceRelENS.CourseChapterName, //课程章节名称
ParentNodeID = objvCourseLearningCaseWithResourceRelENS.ParentNodeID, //父节点编号
ParentNodeName = objvCourseLearningCaseWithResourceRelENS.ParentNodeName, //父节点名称
CourseChapterReferred = objvCourseLearningCaseWithResourceRelENS.CourseChapterReferred, //节简称
ParentNodeReferred = objvCourseLearningCaseWithResourceRelENS.ParentNodeReferred, //章简称
ViewCount = objvCourseLearningCaseWithResourceRelENS.ViewCount, //浏览量
IsShow = objvCourseLearningCaseWithResourceRelENS.IsShow, //是否启用
DownloadNumber = objvCourseLearningCaseWithResourceRelENS.DownloadNumber, //下载数目
FileIntegration = objvCourseLearningCaseWithResourceRelENS.FileIntegration, //文件积分
LikeCount = objvCourseLearningCaseWithResourceRelENS.LikeCount, //资源喜欢数量
CollectionCount = objvCourseLearningCaseWithResourceRelENS.CollectionCount, //收藏数量
RecommendedDegreeId = objvCourseLearningCaseWithResourceRelENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvCourseLearningCaseWithResourceRelENS.RecommendedDegreeName, //推荐度名称
Memo = objvCourseLearningCaseWithResourceRelENS.Memo, //备注
BrowseCount4Case = objvCourseLearningCaseWithResourceRelENS.BrowseCount4Case, //课例浏览次数
OwnerName = objvCourseLearningCaseWithResourceRelENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvCourseLearningCaseWithResourceRelENS.OwnerNameWithId, //拥有者名称附Id
CaseTypeName = objvCourseLearningCaseWithResourceRelENS.CaseTypeName, //案例类型名称
};
 return objvCourseLearningCaseWithResourceRelENT;
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
public static void CheckProperty4Condition(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN)
{
 clsvCourseLearningCaseWithResourceRelBL.vCourseLearningCaseWithResourceRelDA.CheckProperty4Condition(objvCourseLearningCaseWithResourceRelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdCourseLearningCase) == true)
{
string strComparisonOpIdCourseLearningCase = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdCourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdCourseLearningCase, objvCourseLearningCaseWithResourceRelCond.IdCourseLearningCase, strComparisonOpIdCourseLearningCase);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel) == true)
{
string strComparisonOpIdMicroteachCaseResourceRel = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel, objvCourseLearningCaseWithResourceRelCond.IdMicroteachCaseResourceRel, strComparisonOpIdMicroteachCaseResourceRel);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.FuncModuleId, objvCourseLearningCaseWithResourceRelCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.FuncModuleName, objvCourseLearningCaseWithResourceRelCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdResource) == true)
{
string strComparisonOpIdResource = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdResource, objvCourseLearningCaseWithResourceRelCond.IdResource, strComparisonOpIdResource);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.ResourceID) == true)
{
string strComparisonOpResourceID = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ResourceID, objvCourseLearningCaseWithResourceRelCond.ResourceID, strComparisonOpResourceID);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.ResourceName) == true)
{
string strComparisonOpResourceName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ResourceName, objvCourseLearningCaseWithResourceRelCond.ResourceName, strComparisonOpResourceName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdFtpResource, objvCourseLearningCaseWithResourceRelCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdFile) == true)
{
string strComparisonOpIdFile = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdFile, objvCourseLearningCaseWithResourceRelCond.IdFile, strComparisonOpIdFile);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.FileSize) == true)
{
string strComparisonOpFileSize = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.FileSize, objvCourseLearningCaseWithResourceRelCond.FileSize, strComparisonOpFileSize);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.SaveTime) == true)
{
string strComparisonOpSaveTime = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.SaveTime, objvCourseLearningCaseWithResourceRelCond.SaveTime, strComparisonOpSaveTime);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdResourceType, objvCourseLearningCaseWithResourceRelCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ResourceTypeID, objvCourseLearningCaseWithResourceRelCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ResourceTypeName, objvCourseLearningCaseWithResourceRelCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ResourceOwner, objvCourseLearningCaseWithResourceRelCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IsExistFile) == true)
{
if (objvCourseLearningCaseWithResourceRelCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsExistFile);
}
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.FileNewName) == true)
{
string strComparisonOpFileNewName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.FileNewName, objvCourseLearningCaseWithResourceRelCond.FileNewName, strComparisonOpFileNewName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IsMain) == true)
{
if (objvCourseLearningCaseWithResourceRelCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsMain);
}
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseID) == true)
{
string strComparisonOpCourseLearningCaseID = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseID, objvCourseLearningCaseWithResourceRelCond.CourseLearningCaseID, strComparisonOpCourseLearningCaseID);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseName) == true)
{
string strComparisonOpCourseLearningCaseName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseName, objvCourseLearningCaseWithResourceRelCond.CourseLearningCaseName, strComparisonOpCourseLearningCaseName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseText) == true)
{
string strComparisonOpCourseLearningCaseText = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseText, objvCourseLearningCaseWithResourceRelCond.CourseLearningCaseText, strComparisonOpCourseLearningCaseText);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme) == true)
{
string strComparisonOpCourseLearningCaseTheme = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme, objvCourseLearningCaseWithResourceRelCond.CourseLearningCaseTheme, strComparisonOpCourseLearningCaseTheme);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseDate) == true)
{
string strComparisonOpCourseLearningCaseDate = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseDate, objvCourseLearningCaseWithResourceRelCond.CourseLearningCaseDate, strComparisonOpCourseLearningCaseDate);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseTime) == true)
{
string strComparisonOpCourseLearningCaseTime = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseTime, objvCourseLearningCaseWithResourceRelCond.CourseLearningCaseTime, strComparisonOpCourseLearningCaseTime);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn) == true)
{
string strComparisonOpCourseLearningCaseDateIn = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn, objvCourseLearningCaseWithResourceRelCond.CourseLearningCaseDateIn, strComparisonOpCourseLearningCaseDateIn);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn) == true)
{
string strComparisonOpCourseLearningCaseTimeIn = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn, objvCourseLearningCaseWithResourceRelCond.CourseLearningCaseTimeIn, strComparisonOpCourseLearningCaseTimeIn);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdCaseType, objvCourseLearningCaseWithResourceRelCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType) == true)
{
string strComparisonOpIdCourseLearningCaseType = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType, objvCourseLearningCaseWithResourceRelCond.IdCourseLearningCaseType, strComparisonOpIdCourseLearningCaseType);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName) == true)
{
string strComparisonOpCourseLearningCaseTypeName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName, objvCourseLearningCaseWithResourceRelCond.CourseLearningCaseTypeName, strComparisonOpCourseLearningCaseTypeName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.OwnerId) == true)
{
string strComparisonOpOwnerId = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.OwnerId, objvCourseLearningCaseWithResourceRelCond.OwnerId, strComparisonOpOwnerId);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdStudyLevel, objvCourseLearningCaseWithResourceRelCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.StudyLevelName, objvCourseLearningCaseWithResourceRelCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdTeachingPlan, objvCourseLearningCaseWithResourceRelCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdDiscipline, objvCourseLearningCaseWithResourceRelCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.DisciplineID, objvCourseLearningCaseWithResourceRelCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.DisciplineName, objvCourseLearningCaseWithResourceRelCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.BrowseCount, objvCourseLearningCaseWithResourceRelCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion, objvCourseLearningCaseWithResourceRelCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.senateGaugeVersionID, objvCourseLearningCaseWithResourceRelCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.senateGaugeVersionName, objvCourseLearningCaseWithResourceRelCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore, objvCourseLearningCaseWithResourceRelCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.VersionNo) == true)
{
string strComparisonOpVersionNo = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.VersionNo, objvCourseLearningCaseWithResourceRelCond.VersionNo, strComparisonOpVersionNo);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdTeachSkill, objvCourseLearningCaseWithResourceRelCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.TeachSkillID, objvCourseLearningCaseWithResourceRelCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.SkillTypeName, objvCourseLearningCaseWithResourceRelCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.TeachSkillName, objvCourseLearningCaseWithResourceRelCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.TeachSkillTheory, objvCourseLearningCaseWithResourceRelCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.TeachSkillOperMethod, objvCourseLearningCaseWithResourceRelCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdSkillType, objvCourseLearningCaseWithResourceRelCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.SkillTypeID, objvCourseLearningCaseWithResourceRelCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CaseLevelId, objvCourseLearningCaseWithResourceRelCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CaseLevelName) == true)
{
string strComparisonOpCaseLevelName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CaseLevelName, objvCourseLearningCaseWithResourceRelCond.CaseLevelName, strComparisonOpCaseLevelName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.DocFile) == true)
{
string strComparisonOpDocFile = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.DocFile, objvCourseLearningCaseWithResourceRelCond.DocFile, strComparisonOpDocFile);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IsNeedGeneWord) == true)
{
if (objvCourseLearningCaseWithResourceRelCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsNeedGeneWord);
}
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.WordCreateDate, objvCourseLearningCaseWithResourceRelCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IsVisible) == true)
{
if (objvCourseLearningCaseWithResourceRelCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsVisible);
}
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IsDualVideo) == true)
{
if (objvCourseLearningCaseWithResourceRelCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsDualVideo);
}
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdXzCollege, objvCourseLearningCaseWithResourceRelCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CollegeID) == true)
{
string strComparisonOpCollegeID = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CollegeID, objvCourseLearningCaseWithResourceRelCond.CollegeID, strComparisonOpCollegeID);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CollegeName) == true)
{
string strComparisonOpCollegeName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CollegeName, objvCourseLearningCaseWithResourceRelCond.CollegeName, strComparisonOpCollegeName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CollegeNameA, objvCourseLearningCaseWithResourceRelCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.IdXzMajor, objvCourseLearningCaseWithResourceRelCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.MajorID) == true)
{
string strComparisonOpMajorID = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.MajorID, objvCourseLearningCaseWithResourceRelCond.MajorID, strComparisonOpMajorID);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.MajorName) == true)
{
string strComparisonOpMajorName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.MajorName, objvCourseLearningCaseWithResourceRelCond.MajorName, strComparisonOpMajorName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseId) == true)
{
string strComparisonOpCourseId = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseId, objvCourseLearningCaseWithResourceRelCond.CourseId, strComparisonOpCourseId);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseCode, objvCourseLearningCaseWithResourceRelCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseName) == true)
{
string strComparisonOpCourseName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseName, objvCourseLearningCaseWithResourceRelCond.CourseName, strComparisonOpCourseName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.TeachingSolutionId) == true)
{
string strComparisonOpTeachingSolutionId = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.TeachingSolutionId, objvCourseLearningCaseWithResourceRelCond.TeachingSolutionId, strComparisonOpTeachingSolutionId);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseChapterId, objvCourseLearningCaseWithResourceRelCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseChapterName, objvCourseLearningCaseWithResourceRelCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.ParentNodeID) == true)
{
string strComparisonOpParentNodeID = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ParentNodeID, objvCourseLearningCaseWithResourceRelCond.ParentNodeID, strComparisonOpParentNodeID);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.ParentNodeName) == true)
{
string strComparisonOpParentNodeName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ParentNodeName, objvCourseLearningCaseWithResourceRelCond.ParentNodeName, strComparisonOpParentNodeName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseChapterReferred, objvCourseLearningCaseWithResourceRelCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.ParentNodeReferred) == true)
{
string strComparisonOpParentNodeReferred = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ParentNodeReferred, objvCourseLearningCaseWithResourceRelCond.ParentNodeReferred, strComparisonOpParentNodeReferred);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.ViewCount) == true)
{
string strComparisonOpViewCount = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.ViewCount, objvCourseLearningCaseWithResourceRelCond.ViewCount, strComparisonOpViewCount);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.IsShow) == true)
{
if (objvCourseLearningCaseWithResourceRelCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsShow);
}
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.DownloadNumber, objvCourseLearningCaseWithResourceRelCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.FileIntegration, objvCourseLearningCaseWithResourceRelCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.LikeCount) == true)
{
string strComparisonOpLikeCount = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.LikeCount, objvCourseLearningCaseWithResourceRelCond.LikeCount, strComparisonOpLikeCount);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.CollectionCount, objvCourseLearningCaseWithResourceRelCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.RecommendedDegreeId, objvCourseLearningCaseWithResourceRelCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.RecommendedDegreeName, objvCourseLearningCaseWithResourceRelCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.Memo) == true)
{
string strComparisonOpMemo = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.Memo, objvCourseLearningCaseWithResourceRelCond.Memo, strComparisonOpMemo);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.BrowseCount4Case, objvCourseLearningCaseWithResourceRelCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.OwnerName) == true)
{
string strComparisonOpOwnerName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.OwnerName, objvCourseLearningCaseWithResourceRelCond.OwnerName, strComparisonOpOwnerName);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.OwnerNameWithId, objvCourseLearningCaseWithResourceRelCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(convCourseLearningCaseWithResourceRel.CaseTypeName) == true)
{
string strComparisonOpCaseTypeName = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CaseTypeName, objvCourseLearningCaseWithResourceRelCond.CaseTypeName, strComparisonOpCaseTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCourseLearningCaseWithResourceRel
{
public virtual bool UpdRelaTabDate(string strIdCourseLearningCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程学习案例With资源关系(vCourseLearningCaseWithResourceRel)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCaseWithResourceRelBL
{
public static RelatedActions_vCourseLearningCaseWithResourceRel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCourseLearningCaseWithResourceRelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCourseLearningCaseWithResourceRelDA vCourseLearningCaseWithResourceRelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCourseLearningCaseWithResourceRelDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCourseLearningCaseWithResourceRelBL()
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
if (string.IsNullOrEmpty(clsvCourseLearningCaseWithResourceRelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseWithResourceRelEN._ConnectString);
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
public static DataTable GetDataTable_vCourseLearningCaseWithResourceRel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCourseLearningCaseWithResourceRelDA.GetDataTable_vCourseLearningCaseWithResourceRel(strWhereCond);
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
objDT = vCourseLearningCaseWithResourceRelDA.GetDataTable(strWhereCond);
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
objDT = vCourseLearningCaseWithResourceRelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCourseLearningCaseWithResourceRelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCourseLearningCaseWithResourceRelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCourseLearningCaseWithResourceRelDA.GetDataTable_Top(objTopPara);
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
objDT = vCourseLearningCaseWithResourceRelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCourseLearningCaseWithResourceRelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCourseLearningCaseWithResourceRelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCourseLearningCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstByIdCourseLearningCaseLst(List<string> arrIdCourseLearningCaseLst)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCourseLearningCaseLst, true);
 string strWhereCond = string.Format("IdCourseLearningCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCourseLearningCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCourseLearningCaseWithResourceRelEN> GetObjLstByIdCourseLearningCaseLstCache(List<string> arrIdCourseLearningCaseLst)
{
string strKey = string.Format("{0}", clsvCourseLearningCaseWithResourceRelEN._CurrTabName);
List<clsvCourseLearningCaseWithResourceRelEN> arrvCourseLearningCaseWithResourceRelObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseWithResourceRelEN> arrvCourseLearningCaseWithResourceRelObjLst_Sel =
arrvCourseLearningCaseWithResourceRelObjLstCache
.Where(x => arrIdCourseLearningCaseLst.Contains(x.IdCourseLearningCase));
return arrvCourseLearningCaseWithResourceRelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLst(string strWhereCond)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCourseLearningCaseWithResourceRelEN> GetSubObjLstCache(clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelCond)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseWithResourceRelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCaseWithResourceRel.AttributeName)
{
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseWithResourceRelCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseWithResourceRelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCaseWithResourceRelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseWithResourceRelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseWithResourceRelCond[strFldName]));
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
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
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseWithResourceRelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
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
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCourseLearningCaseWithResourceRel(ref clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN)
{
bool bolResult = vCourseLearningCaseWithResourceRelDA.GetvCourseLearningCaseWithResourceRel(ref objvCourseLearningCaseWithResourceRelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseWithResourceRelEN GetObjByIdCourseLearningCase(string strIdCourseLearningCase)
{
if (strIdCourseLearningCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCourseLearningCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCourseLearningCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = vCourseLearningCaseWithResourceRelDA.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
return objvCourseLearningCaseWithResourceRelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCourseLearningCaseWithResourceRelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = vCourseLearningCaseWithResourceRelDA.GetFirstObj(strWhereCond);
 return objvCourseLearningCaseWithResourceRelEN;
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
public static clsvCourseLearningCaseWithResourceRelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = vCourseLearningCaseWithResourceRelDA.GetObjByDataRow(objRow);
 return objvCourseLearningCaseWithResourceRelEN;
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
public static clsvCourseLearningCaseWithResourceRelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = vCourseLearningCaseWithResourceRelDA.GetObjByDataRow(objRow);
 return objvCourseLearningCaseWithResourceRelEN;
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
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <param name = "lstvCourseLearningCaseWithResourceRelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCaseWithResourceRelEN GetObjByIdCourseLearningCaseFromList(string strIdCourseLearningCase, List<clsvCourseLearningCaseWithResourceRelEN> lstvCourseLearningCaseWithResourceRelObjLst)
{
foreach (clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN in lstvCourseLearningCaseWithResourceRelObjLst)
{
if (objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase == strIdCourseLearningCase)
{
return objvCourseLearningCaseWithResourceRelEN;
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
 string strIdCourseLearningCase;
 try
 {
 strIdCourseLearningCase = new clsvCourseLearningCaseWithResourceRelDA().GetFirstID(strWhereCond);
 return strIdCourseLearningCase;
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
 arrList = vCourseLearningCaseWithResourceRelDA.GetID(strWhereCond);
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
bool bolIsExist = vCourseLearningCaseWithResourceRelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCourseLearningCase)
{
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCourseLearningCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCourseLearningCaseWithResourceRelDA.IsExist(strIdCourseLearningCase);
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
 bolIsExist = clsvCourseLearningCaseWithResourceRelDA.IsExistTable();
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
 bolIsExist = vCourseLearningCaseWithResourceRelDA.IsExistTable(strTabName);
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
 /// <param name = "objvCourseLearningCaseWithResourceRelENS">源对象</param>
 /// <param name = "objvCourseLearningCaseWithResourceRelENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelENS, clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelENT)
{
try
{
objvCourseLearningCaseWithResourceRelENT.IdCourseLearningCase = objvCourseLearningCaseWithResourceRelENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseWithResourceRelENT.IdMicroteachCaseResourceRel = objvCourseLearningCaseWithResourceRelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelENT.FuncModuleId = objvCourseLearningCaseWithResourceRelENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseWithResourceRelENT.FuncModuleName = objvCourseLearningCaseWithResourceRelENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseWithResourceRelENT.IdResource = objvCourseLearningCaseWithResourceRelENS.IdResource; //资源流水号
objvCourseLearningCaseWithResourceRelENT.ResourceID = objvCourseLearningCaseWithResourceRelENS.ResourceID; //资源ID
objvCourseLearningCaseWithResourceRelENT.ResourceName = objvCourseLearningCaseWithResourceRelENS.ResourceName; //资源名称
objvCourseLearningCaseWithResourceRelENT.IdFtpResource = objvCourseLearningCaseWithResourceRelENS.IdFtpResource; //FTP资源流水号
objvCourseLearningCaseWithResourceRelENT.IdFile = objvCourseLearningCaseWithResourceRelENS.IdFile; //文件流水号
objvCourseLearningCaseWithResourceRelENT.FileSize = objvCourseLearningCaseWithResourceRelENS.FileSize; //文件大小
objvCourseLearningCaseWithResourceRelENT.SaveTime = objvCourseLearningCaseWithResourceRelENS.SaveTime; //创建时间
objvCourseLearningCaseWithResourceRelENT.IdResourceType = objvCourseLearningCaseWithResourceRelENS.IdResourceType; //资源类型流水号
objvCourseLearningCaseWithResourceRelENT.ResourceTypeID = objvCourseLearningCaseWithResourceRelENS.ResourceTypeID; //资源类型ID
objvCourseLearningCaseWithResourceRelENT.ResourceTypeName = objvCourseLearningCaseWithResourceRelENS.ResourceTypeName; //资源类型名称
objvCourseLearningCaseWithResourceRelENT.ResourceOwner = objvCourseLearningCaseWithResourceRelENS.ResourceOwner; //上传者
objvCourseLearningCaseWithResourceRelENT.IsExistFile = objvCourseLearningCaseWithResourceRelENS.IsExistFile; //是否存在文件
objvCourseLearningCaseWithResourceRelENT.FileNewName = objvCourseLearningCaseWithResourceRelENS.FileNewName; //新文件名
objvCourseLearningCaseWithResourceRelENT.IsMain = objvCourseLearningCaseWithResourceRelENS.IsMain; //是否主资源
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseID = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseName = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseText = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTheme = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseDate = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTime = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseDateIn = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTimeIn = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCaseWithResourceRelENT.IdCaseType = objvCourseLearningCaseWithResourceRelENS.IdCaseType; //案例类型流水号
objvCourseLearningCaseWithResourceRelENT.IdCourseLearningCaseType = objvCourseLearningCaseWithResourceRelENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTypeName = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelENT.OwnerId = objvCourseLearningCaseWithResourceRelENS.OwnerId; //拥有者Id
objvCourseLearningCaseWithResourceRelENT.IdStudyLevel = objvCourseLearningCaseWithResourceRelENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCaseWithResourceRelENT.StudyLevelName = objvCourseLearningCaseWithResourceRelENS.StudyLevelName; //学段名称
objvCourseLearningCaseWithResourceRelENT.IdTeachingPlan = objvCourseLearningCaseWithResourceRelENS.IdTeachingPlan; //教案流水号
objvCourseLearningCaseWithResourceRelENT.IdDiscipline = objvCourseLearningCaseWithResourceRelENS.IdDiscipline; //学科流水号
objvCourseLearningCaseWithResourceRelENT.DisciplineID = objvCourseLearningCaseWithResourceRelENS.DisciplineID; //学科ID
objvCourseLearningCaseWithResourceRelENT.DisciplineName = objvCourseLearningCaseWithResourceRelENS.DisciplineName; //学科名称
objvCourseLearningCaseWithResourceRelENT.BrowseCount = objvCourseLearningCaseWithResourceRelENS.BrowseCount; //浏览次数
objvCourseLearningCaseWithResourceRelENT.IdSenateGaugeVersion = objvCourseLearningCaseWithResourceRelENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionID = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionName = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionTtlScore = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCaseWithResourceRelENT.VersionNo = objvCourseLearningCaseWithResourceRelENS.VersionNo; //版本号
objvCourseLearningCaseWithResourceRelENT.IdTeachSkill = objvCourseLearningCaseWithResourceRelENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCaseWithResourceRelENT.TeachSkillID = objvCourseLearningCaseWithResourceRelENS.TeachSkillID; //教学技能ID
objvCourseLearningCaseWithResourceRelENT.SkillTypeName = objvCourseLearningCaseWithResourceRelENS.SkillTypeName; //技能类型名称
objvCourseLearningCaseWithResourceRelENT.TeachSkillName = objvCourseLearningCaseWithResourceRelENS.TeachSkillName; //教学技能名称
objvCourseLearningCaseWithResourceRelENT.TeachSkillTheory = objvCourseLearningCaseWithResourceRelENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCaseWithResourceRelENT.TeachSkillOperMethod = objvCourseLearningCaseWithResourceRelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelENT.IdSkillType = objvCourseLearningCaseWithResourceRelENS.IdSkillType; //技能类型流水号
objvCourseLearningCaseWithResourceRelENT.SkillTypeID = objvCourseLearningCaseWithResourceRelENS.SkillTypeID; //技能类型ID
objvCourseLearningCaseWithResourceRelENT.CaseLevelId = objvCourseLearningCaseWithResourceRelENS.CaseLevelId; //课例等级Id
objvCourseLearningCaseWithResourceRelENT.CaseLevelName = objvCourseLearningCaseWithResourceRelENS.CaseLevelName; //案例等级名称
objvCourseLearningCaseWithResourceRelENT.DocFile = objvCourseLearningCaseWithResourceRelENS.DocFile; //生成的Word文件名
objvCourseLearningCaseWithResourceRelENT.IsNeedGeneWord = objvCourseLearningCaseWithResourceRelENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCaseWithResourceRelENT.WordCreateDate = objvCourseLearningCaseWithResourceRelENS.WordCreateDate; //Word生成日期
objvCourseLearningCaseWithResourceRelENT.IsVisible = objvCourseLearningCaseWithResourceRelENS.IsVisible; //是否显示
objvCourseLearningCaseWithResourceRelENT.IsDualVideo = objvCourseLearningCaseWithResourceRelENS.IsDualVideo; //是否双视频
objvCourseLearningCaseWithResourceRelENT.IdXzCollege = objvCourseLearningCaseWithResourceRelENS.IdXzCollege; //学院流水号
objvCourseLearningCaseWithResourceRelENT.CollegeID = objvCourseLearningCaseWithResourceRelENS.CollegeID; //学院ID
objvCourseLearningCaseWithResourceRelENT.CollegeName = objvCourseLearningCaseWithResourceRelENS.CollegeName; //学院名称
objvCourseLearningCaseWithResourceRelENT.CollegeNameA = objvCourseLearningCaseWithResourceRelENS.CollegeNameA; //学院名称简写
objvCourseLearningCaseWithResourceRelENT.IdXzMajor = objvCourseLearningCaseWithResourceRelENS.IdXzMajor; //专业流水号
objvCourseLearningCaseWithResourceRelENT.MajorID = objvCourseLearningCaseWithResourceRelENS.MajorID; //专业ID
objvCourseLearningCaseWithResourceRelENT.MajorName = objvCourseLearningCaseWithResourceRelENS.MajorName; //专业名称
objvCourseLearningCaseWithResourceRelENT.CourseId = objvCourseLearningCaseWithResourceRelENS.CourseId; //课程Id
objvCourseLearningCaseWithResourceRelENT.CourseCode = objvCourseLearningCaseWithResourceRelENS.CourseCode; //课程代码
objvCourseLearningCaseWithResourceRelENT.CourseName = objvCourseLearningCaseWithResourceRelENS.CourseName; //课程名称
objvCourseLearningCaseWithResourceRelENT.TeachingSolutionId = objvCourseLearningCaseWithResourceRelENS.TeachingSolutionId; //教学方案Id
objvCourseLearningCaseWithResourceRelENT.CourseChapterId = objvCourseLearningCaseWithResourceRelENS.CourseChapterId; //课程章节ID
objvCourseLearningCaseWithResourceRelENT.CourseChapterName = objvCourseLearningCaseWithResourceRelENS.CourseChapterName; //课程章节名称
objvCourseLearningCaseWithResourceRelENT.ParentNodeID = objvCourseLearningCaseWithResourceRelENS.ParentNodeID; //父节点编号
objvCourseLearningCaseWithResourceRelENT.ParentNodeName = objvCourseLearningCaseWithResourceRelENS.ParentNodeName; //父节点名称
objvCourseLearningCaseWithResourceRelENT.CourseChapterReferred = objvCourseLearningCaseWithResourceRelENS.CourseChapterReferred; //节简称
objvCourseLearningCaseWithResourceRelENT.ParentNodeReferred = objvCourseLearningCaseWithResourceRelENS.ParentNodeReferred; //章简称
objvCourseLearningCaseWithResourceRelENT.ViewCount = objvCourseLearningCaseWithResourceRelENS.ViewCount; //浏览量
objvCourseLearningCaseWithResourceRelENT.IsShow = objvCourseLearningCaseWithResourceRelENS.IsShow; //是否启用
objvCourseLearningCaseWithResourceRelENT.DownloadNumber = objvCourseLearningCaseWithResourceRelENS.DownloadNumber; //下载数目
objvCourseLearningCaseWithResourceRelENT.FileIntegration = objvCourseLearningCaseWithResourceRelENS.FileIntegration; //文件积分
objvCourseLearningCaseWithResourceRelENT.LikeCount = objvCourseLearningCaseWithResourceRelENS.LikeCount; //资源喜欢数量
objvCourseLearningCaseWithResourceRelENT.CollectionCount = objvCourseLearningCaseWithResourceRelENS.CollectionCount; //收藏数量
objvCourseLearningCaseWithResourceRelENT.RecommendedDegreeId = objvCourseLearningCaseWithResourceRelENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCaseWithResourceRelENT.RecommendedDegreeName = objvCourseLearningCaseWithResourceRelENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCaseWithResourceRelENT.Memo = objvCourseLearningCaseWithResourceRelENS.Memo; //备注
objvCourseLearningCaseWithResourceRelENT.BrowseCount4Case = objvCourseLearningCaseWithResourceRelENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCaseWithResourceRelENT.OwnerName = objvCourseLearningCaseWithResourceRelENS.OwnerName; //拥有者姓名
objvCourseLearningCaseWithResourceRelENT.OwnerNameWithId = objvCourseLearningCaseWithResourceRelENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCaseWithResourceRelENT.CaseTypeName = objvCourseLearningCaseWithResourceRelENS.CaseTypeName; //案例类型名称
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
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">源简化对象</param>
 public static void SetUpdFlag(clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN)
{
try
{
objvCourseLearningCaseWithResourceRelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCourseLearningCaseWithResourceRelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdCourseLearningCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase; //课程学习案例流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objvCourseLearningCaseWithResourceRelEN.FuncModuleId == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objvCourseLearningCaseWithResourceRelEN.FuncModuleName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdResource = objvCourseLearningCaseWithResourceRelEN.IdResource == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.ResourceID = objvCourseLearningCaseWithResourceRelEN.ResourceID == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.ResourceName = objvCourseLearningCaseWithResourceRelEN.ResourceName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objvCourseLearningCaseWithResourceRelEN.IdFtpResource == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdFile = objvCourseLearningCaseWithResourceRelEN.IdFile == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.FileSize = objvCourseLearningCaseWithResourceRelEN.FileSize == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.SaveTime = objvCourseLearningCaseWithResourceRelEN.SaveTime == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objvCourseLearningCaseWithResourceRelEN.IdResourceType == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objvCourseLearningCaseWithResourceRelEN.ResourceTypeID == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objvCourseLearningCaseWithResourceRelEN.ResourceTypeName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objvCourseLearningCaseWithResourceRelEN.ResourceOwner == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IsExistFile = objvCourseLearningCaseWithResourceRelEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.FileNewName = objvCourseLearningCaseWithResourceRelEN.FileNewName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IsMain = objvCourseLearningCaseWithResourceRelEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseLearningCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID; //课程学习案例ID
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseLearningCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName; //课程学习案例名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseLearningCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText; //案例文本内容
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme; //课程学习案例主题词
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseLearningCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate; //课程学习日期
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseLearningCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime; //课程学习时间
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objvCourseLearningCaseWithResourceRelEN.IdCaseType == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType; //课程学习案例类型流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName; //课程学习案例类型名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.OwnerId = objvCourseLearningCaseWithResourceRelEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objvCourseLearningCaseWithResourceRelEN.IdStudyLevel == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objvCourseLearningCaseWithResourceRelEN.StudyLevelName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objvCourseLearningCaseWithResourceRelEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objvCourseLearningCaseWithResourceRelEN.DisciplineID == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objvCourseLearningCaseWithResourceRelEN.DisciplineName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objvCourseLearningCaseWithResourceRelEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.VersionNo = objvCourseLearningCaseWithResourceRelEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objvCourseLearningCaseWithResourceRelEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objvCourseLearningCaseWithResourceRelEN.TeachSkillID == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objvCourseLearningCaseWithResourceRelEN.SkillTypeName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objvCourseLearningCaseWithResourceRelEN.TeachSkillName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objvCourseLearningCaseWithResourceRelEN.IdSkillType == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objvCourseLearningCaseWithResourceRelEN.SkillTypeID == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objvCourseLearningCaseWithResourceRelEN.CaseLevelId == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CaseLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objvCourseLearningCaseWithResourceRelEN.CaseLevelName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CaseLevelName; //案例等级名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.DocFile = objvCourseLearningCaseWithResourceRelEN.DocFile == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objvCourseLearningCaseWithResourceRelEN.WordCreateDate == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IsVisible = objvCourseLearningCaseWithResourceRelEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = objvCourseLearningCaseWithResourceRelEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objvCourseLearningCaseWithResourceRelEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CollegeID = objvCourseLearningCaseWithResourceRelEN.CollegeID == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CollegeName = objvCourseLearningCaseWithResourceRelEN.CollegeName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objvCourseLearningCaseWithResourceRelEN.CollegeNameA == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objvCourseLearningCaseWithResourceRelEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.MajorID = objvCourseLearningCaseWithResourceRelEN.MajorID == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.MajorName = objvCourseLearningCaseWithResourceRelEN.MajorName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseId = objvCourseLearningCaseWithResourceRelEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseCode = objvCourseLearningCaseWithResourceRelEN.CourseCode == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseName = objvCourseLearningCaseWithResourceRelEN.CourseName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.TeachingSolutionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId; //教学方案Id
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objvCourseLearningCaseWithResourceRelEN.CourseChapterId == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objvCourseLearningCaseWithResourceRelEN.CourseChapterName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.ParentNodeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objvCourseLearningCaseWithResourceRelEN.ParentNodeID == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.ParentNodeID; //父节点编号
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.ParentNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objvCourseLearningCaseWithResourceRelEN.ParentNodeName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.ParentNodeName; //父节点名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.ParentNodeReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred; //章简称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.ViewCount = objvCourseLearningCaseWithResourceRelEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.IsShow = objvCourseLearningCaseWithResourceRelEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objvCourseLearningCaseWithResourceRelEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objvCourseLearningCaseWithResourceRelEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.LikeCount = objvCourseLearningCaseWithResourceRelEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objvCourseLearningCaseWithResourceRelEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.Memo = objvCourseLearningCaseWithResourceRelEN.Memo == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.Memo; //备注
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.OwnerName = objvCourseLearningCaseWithResourceRelEN.OwnerName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convCourseLearningCaseWithResourceRel.CaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objvCourseLearningCaseWithResourceRelEN.CaseTypeName == "[null]" ? null :  objvCourseLearningCaseWithResourceRelEN.CaseTypeName; //案例类型名称
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
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN)
{
try
{
if (objvCourseLearningCaseWithResourceRelEN.FuncModuleId == "[null]") objvCourseLearningCaseWithResourceRelEN.FuncModuleId = null; //功能模块Id
if (objvCourseLearningCaseWithResourceRelEN.FuncModuleName == "[null]") objvCourseLearningCaseWithResourceRelEN.FuncModuleName = null; //功能模块名称
if (objvCourseLearningCaseWithResourceRelEN.IdResource == "[null]") objvCourseLearningCaseWithResourceRelEN.IdResource = null; //资源流水号
if (objvCourseLearningCaseWithResourceRelEN.ResourceID == "[null]") objvCourseLearningCaseWithResourceRelEN.ResourceID = null; //资源ID
if (objvCourseLearningCaseWithResourceRelEN.ResourceName == "[null]") objvCourseLearningCaseWithResourceRelEN.ResourceName = null; //资源名称
if (objvCourseLearningCaseWithResourceRelEN.IdFtpResource == "[null]") objvCourseLearningCaseWithResourceRelEN.IdFtpResource = null; //FTP资源流水号
if (objvCourseLearningCaseWithResourceRelEN.IdFile == "[null]") objvCourseLearningCaseWithResourceRelEN.IdFile = null; //文件流水号
if (objvCourseLearningCaseWithResourceRelEN.FileSize == "[null]") objvCourseLearningCaseWithResourceRelEN.FileSize = null; //文件大小
if (objvCourseLearningCaseWithResourceRelEN.SaveTime == "[null]") objvCourseLearningCaseWithResourceRelEN.SaveTime = null; //创建时间
if (objvCourseLearningCaseWithResourceRelEN.IdResourceType == "[null]") objvCourseLearningCaseWithResourceRelEN.IdResourceType = null; //资源类型流水号
if (objvCourseLearningCaseWithResourceRelEN.ResourceTypeID == "[null]") objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = null; //资源类型ID
if (objvCourseLearningCaseWithResourceRelEN.ResourceTypeName == "[null]") objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = null; //资源类型名称
if (objvCourseLearningCaseWithResourceRelEN.ResourceOwner == "[null]") objvCourseLearningCaseWithResourceRelEN.ResourceOwner = null; //上传者
if (objvCourseLearningCaseWithResourceRelEN.FileNewName == "[null]") objvCourseLearningCaseWithResourceRelEN.FileNewName = null; //新文件名
if (objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = null; //案例文本内容
if (objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = null; //课程学习案例主题词
if (objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = null; //课程学习日期
if (objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = null; //课程学习时间
if (objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = null; //案例入库日期
if (objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = null; //案例入库时间
if (objvCourseLearningCaseWithResourceRelEN.IdCaseType == "[null]") objvCourseLearningCaseWithResourceRelEN.IdCaseType = null; //案例类型流水号
if (objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = null; //课程学习案例类型名称
if (objvCourseLearningCaseWithResourceRelEN.IdStudyLevel == "[null]") objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = null; //id_StudyLevel
if (objvCourseLearningCaseWithResourceRelEN.StudyLevelName == "[null]") objvCourseLearningCaseWithResourceRelEN.StudyLevelName = null; //学段名称
if (objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan == "[null]") objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = null; //教案流水号
if (objvCourseLearningCaseWithResourceRelEN.DisciplineID == "[null]") objvCourseLearningCaseWithResourceRelEN.DisciplineID = null; //学科ID
if (objvCourseLearningCaseWithResourceRelEN.DisciplineName == "[null]") objvCourseLearningCaseWithResourceRelEN.DisciplineName = null; //学科名称
if (objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion == "[null]") objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID == "[null]") objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName == "[null]") objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvCourseLearningCaseWithResourceRelEN.TeachSkillID == "[null]") objvCourseLearningCaseWithResourceRelEN.TeachSkillID = null; //教学技能ID
if (objvCourseLearningCaseWithResourceRelEN.SkillTypeName == "[null]") objvCourseLearningCaseWithResourceRelEN.SkillTypeName = null; //技能类型名称
if (objvCourseLearningCaseWithResourceRelEN.TeachSkillName == "[null]") objvCourseLearningCaseWithResourceRelEN.TeachSkillName = null; //教学技能名称
if (objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory == "[null]") objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod == "[null]") objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvCourseLearningCaseWithResourceRelEN.IdSkillType == "[null]") objvCourseLearningCaseWithResourceRelEN.IdSkillType = null; //技能类型流水号
if (objvCourseLearningCaseWithResourceRelEN.SkillTypeID == "[null]") objvCourseLearningCaseWithResourceRelEN.SkillTypeID = null; //技能类型ID
if (objvCourseLearningCaseWithResourceRelEN.CaseLevelId == "[null]") objvCourseLearningCaseWithResourceRelEN.CaseLevelId = null; //课例等级Id
if (objvCourseLearningCaseWithResourceRelEN.CaseLevelName == "[null]") objvCourseLearningCaseWithResourceRelEN.CaseLevelName = null; //案例等级名称
if (objvCourseLearningCaseWithResourceRelEN.DocFile == "[null]") objvCourseLearningCaseWithResourceRelEN.DocFile = null; //生成的Word文件名
if (objvCourseLearningCaseWithResourceRelEN.WordCreateDate == "[null]") objvCourseLearningCaseWithResourceRelEN.WordCreateDate = null; //Word生成日期
if (objvCourseLearningCaseWithResourceRelEN.CollegeID == "[null]") objvCourseLearningCaseWithResourceRelEN.CollegeID = null; //学院ID
if (objvCourseLearningCaseWithResourceRelEN.CollegeName == "[null]") objvCourseLearningCaseWithResourceRelEN.CollegeName = null; //学院名称
if (objvCourseLearningCaseWithResourceRelEN.CollegeNameA == "[null]") objvCourseLearningCaseWithResourceRelEN.CollegeNameA = null; //学院名称简写
if (objvCourseLearningCaseWithResourceRelEN.MajorID == "[null]") objvCourseLearningCaseWithResourceRelEN.MajorID = null; //专业ID
if (objvCourseLearningCaseWithResourceRelEN.MajorName == "[null]") objvCourseLearningCaseWithResourceRelEN.MajorName = null; //专业名称
if (objvCourseLearningCaseWithResourceRelEN.CourseCode == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseCode = null; //课程代码
if (objvCourseLearningCaseWithResourceRelEN.CourseName == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseName = null; //课程名称
if (objvCourseLearningCaseWithResourceRelEN.CourseChapterId == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseChapterId = null; //课程章节ID
if (objvCourseLearningCaseWithResourceRelEN.CourseChapterName == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseChapterName = null; //课程章节名称
if (objvCourseLearningCaseWithResourceRelEN.ParentNodeID == "[null]") objvCourseLearningCaseWithResourceRelEN.ParentNodeID = null; //父节点编号
if (objvCourseLearningCaseWithResourceRelEN.ParentNodeName == "[null]") objvCourseLearningCaseWithResourceRelEN.ParentNodeName = null; //父节点名称
if (objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred == "[null]") objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = null; //节简称
if (objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred == "[null]") objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = null; //章简称
if (objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName == "[null]") objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = null; //推荐度名称
if (objvCourseLearningCaseWithResourceRelEN.Memo == "[null]") objvCourseLearningCaseWithResourceRelEN.Memo = null; //备注
if (objvCourseLearningCaseWithResourceRelEN.OwnerName == "[null]") objvCourseLearningCaseWithResourceRelEN.OwnerName = null; //拥有者姓名
if (objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId == "[null]") objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvCourseLearningCaseWithResourceRelEN.CaseTypeName == "[null]") objvCourseLearningCaseWithResourceRelEN.CaseTypeName = null; //案例类型名称
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
public static void CheckProperty4Condition(clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN)
{
 vCourseLearningCaseWithResourceRelDA.CheckProperty4Condition(objvCourseLearningCaseWithResourceRelEN);
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
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCourseLearningCase");
//if (arrvCourseLearningCaseWithResourceRelObjLstCache == null)
//{
//arrvCourseLearningCaseWithResourceRelObjLstCache = vCourseLearningCaseWithResourceRelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCaseWithResourceRelEN GetObjByIdCourseLearningCaseCache(string strIdCourseLearningCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCourseLearningCaseWithResourceRelEN._CurrTabName);
List<clsvCourseLearningCaseWithResourceRelEN> arrvCourseLearningCaseWithResourceRelObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseWithResourceRelEN> arrvCourseLearningCaseWithResourceRelObjLst_Sel =
arrvCourseLearningCaseWithResourceRelObjLstCache
.Where(x=> x.IdCourseLearningCase == strIdCourseLearningCase 
);
if (arrvCourseLearningCaseWithResourceRelObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCaseWithResourceRelEN obj = clsvCourseLearningCaseWithResourceRelBL.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCourseLearningCaseWithResourceRelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCaseWithResourceRelEN> GetAllvCourseLearningCaseWithResourceRelObjLstCache()
{
//获取缓存中的对象列表
List<clsvCourseLearningCaseWithResourceRelEN> arrvCourseLearningCaseWithResourceRelObjLstCache = GetObjLstCache(); 
return arrvCourseLearningCaseWithResourceRelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCaseWithResourceRelEN._CurrTabName);
List<clsvCourseLearningCaseWithResourceRelEN> arrvCourseLearningCaseWithResourceRelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCaseWithResourceRelObjLstCache;
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
string strKey = string.Format("{0}", clsvCourseLearningCaseWithResourceRelEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdCourseLearningCase)
{
if (strInFldName != convCourseLearningCaseWithResourceRel.IdCourseLearningCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCourseLearningCaseWithResourceRel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCourseLearningCaseWithResourceRel.AttributeName));
throw new Exception(strMsg);
}
var objvCourseLearningCaseWithResourceRel = clsvCourseLearningCaseWithResourceRelBL.GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase);
if (objvCourseLearningCaseWithResourceRel == null) return "";
return objvCourseLearningCaseWithResourceRel[strOutFldName].ToString();
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
int intRecCount = clsvCourseLearningCaseWithResourceRelDA.GetRecCount(strTabName);
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
int intRecCount = clsvCourseLearningCaseWithResourceRelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCourseLearningCaseWithResourceRelDA.GetRecCount();
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
int intRecCount = clsvCourseLearningCaseWithResourceRelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelCond)
{
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCaseWithResourceRelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCaseWithResourceRel.AttributeName)
{
if (objvCourseLearningCaseWithResourceRelCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseWithResourceRelCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCaseWithResourceRelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCaseWithResourceRelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCaseWithResourceRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCaseWithResourceRelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseWithResourceRelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCaseWithResourceRelCond[strFldName]));
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
 List<string> arrList = clsvCourseLearningCaseWithResourceRelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCaseWithResourceRelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCaseWithResourceRelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}