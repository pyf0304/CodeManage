
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel_BaseBL
 表名:vMicroteachCase_Resource_Rel_Base(01120490)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:31
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
public static class  clsvMicroteachCase_Resource_Rel_BaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN GetObj(this K_IdMicroteachCaseResourceRel_vMicroteachCase_Resource_Rel_Base myKey)
{
clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = clsvMicroteachCase_Resource_Rel_BaseBL.vMicroteachCase_Resource_Rel_BaseDA.GetObjByIdMicroteachCaseResourceRel(myKey.Value);
return objvMicroteachCase_Resource_Rel_BaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIdMicroteachCaseResourceRel(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, long lngIdMicroteachCaseResourceRel, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = lngIdMicroteachCaseResourceRel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFuncModuleId(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachCase_Resource_Rel_Base.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCase_Resource_Rel_Base.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCase_Resource_Rel_Base.FuncModuleId);
}
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FuncModuleId) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FuncModuleId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FuncModuleId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFuncModuleName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachCase_Resource_Rel_Base.FuncModuleName);
}
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FuncModuleName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FuncModuleName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FuncModuleName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIdMicroteachCase(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convMicroteachCase_Resource_Rel_Base.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroteachCase_Resource_Rel_Base.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroteachCase_Resource_Rel_Base.IdMicroteachCase);
}
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IdMicroteachCase) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIdResource(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convMicroteachCase_Resource_Rel_Base.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convMicroteachCase_Resource_Rel_Base.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convMicroteachCase_Resource_Rel_Base.IdResource);
}
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IdResource) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IdResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetResourceID(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroteachCase_Resource_Rel_Base.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroteachCase_Resource_Rel_Base.ResourceID);
}
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ResourceID) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ResourceID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetResourceName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroteachCase_Resource_Rel_Base.ResourceName);
}
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ResourceName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ResourceName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIdFtpResource(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convMicroteachCase_Resource_Rel_Base.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convMicroteachCase_Resource_Rel_Base.IdFtpResource);
}
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IdFtpResource) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IdFtpResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdFtpResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIdFile(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convMicroteachCase_Resource_Rel_Base.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convMicroteachCase_Resource_Rel_Base.IdFile);
}
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IdFile) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IdFile, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdFile] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroteachCase_Resource_Rel_Base.FileName);
}
objvMicroteachCase_Resource_Rel_BaseEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileType(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroteachCase_Resource_Rel_Base.FileType);
}
objvMicroteachCase_Resource_Rel_BaseEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileType) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetSaveDate(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroteachCase_Resource_Rel_Base.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroteachCase_Resource_Rel_Base.SaveDate);
}
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.SaveDate) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.SaveDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.SaveDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileSize(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroteachCase_Resource_Rel_Base.FileSize);
}
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileSize) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileSize, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileSize] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetSaveTime(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroteachCase_Resource_Rel_Base.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroteachCase_Resource_Rel_Base.SaveTime);
}
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.SaveTime) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.SaveTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.SaveTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFtpResourceID(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFtpResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroteachCase_Resource_Rel_Base.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroteachCase_Resource_Rel_Base.FtpResourceID);
}
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FtpResourceID) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FtpResourceID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FtpResourceID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileOriginalName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroteachCase_Resource_Rel_Base.FileOriginalName);
}
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileOriginalName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileOriginalName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOriginalName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileDirName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroteachCase_Resource_Rel_Base.FileDirName);
}
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileDirName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileDirName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileDirName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileRename(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroteachCase_Resource_Rel_Base.FileRename);
}
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileRename) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileRename, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileRename] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileUpDate(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroteachCase_Resource_Rel_Base.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroteachCase_Resource_Rel_Base.FileUpDate);
}
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileUpDate) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileUpDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileUpDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileUpTime(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroteachCase_Resource_Rel_Base.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroteachCase_Resource_Rel_Base.FileUpTime);
}
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileUpTime) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileUpTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileUpTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetSaveMode(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, bool bolSaveMode, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.SaveMode) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.SaveMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.SaveMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIdResourceType(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convMicroteachCase_Resource_Rel_Base.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convMicroteachCase_Resource_Rel_Base.IdResourceType);
}
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IdResourceType) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IdResourceType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdResourceType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetResourceTypeID(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroteachCase_Resource_Rel_Base.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroteachCase_Resource_Rel_Base.ResourceTypeID);
}
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ResourceTypeID) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ResourceTypeID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetResourceTypeName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroteachCase_Resource_Rel_Base.ResourceTypeName);
}
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ResourceTypeName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ResourceTypeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetResourceOwner(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroteachCase_Resource_Rel_Base.ResourceOwner);
}
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ResourceOwner) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetftpFileType(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase_Resource_Rel_Base.ftpFileType);
}
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ftpFileType) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ftpFileType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpFileType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetftpFileSize(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroteachCase_Resource_Rel_Base.ftpFileSize);
}
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ftpFileSize) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ftpFileSize, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpFileSize] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetftpResourceOwner(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroteachCase_Resource_Rel_Base.ftpResourceOwner);
}
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ftpResourceOwner) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ftpResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileOriginName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroteachCase_Resource_Rel_Base.FileOriginName);
}
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileOriginName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileOriginName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOriginName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIsExistFile(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IsExistFile) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IsExistFile, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IsExistFile] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileNewName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroteachCase_Resource_Rel_Base.FileNewName);
}
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileNewName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileNewName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileNewName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileOldName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroteachCase_Resource_Rel_Base.FileOldName);
}
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileOldName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileOldName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOldName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIsMain(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, bool bolIsMain, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IsMain) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IsMain, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IsMain] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIdUsingMode(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strIdUsingMode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUsingMode, 4, convMicroteachCase_Resource_Rel_Base.IdUsingMode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUsingMode, 4, convMicroteachCase_Resource_Rel_Base.IdUsingMode);
}
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = strIdUsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IdUsingMode) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IdUsingMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdUsingMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIndexNO(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, int? intIndexNO, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IndexNO) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IndexNO, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IndexNO] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetBrowseCount(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, int? intBrowseCount, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.BrowseCount) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.BrowseCount, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.BrowseCount] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetUpdDate(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroteachCase_Resource_Rel_Base.UpdDate);
}
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.UpdDate) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.UpdDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.UpdDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetUpdUser(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCase_Resource_Rel_Base.UpdUser);
}
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.UpdUser) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.UpdUser, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.UpdUser] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetMemo(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase_Resource_Rel_Base.Memo);
}
objvMicroteachCase_Resource_Rel_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.Memo) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.Memo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.Memo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseENS, clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseENT)
{
try
{
objvMicroteachCase_Resource_Rel_BaseENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel_BaseENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseENT.FuncModuleId = objvMicroteachCase_Resource_Rel_BaseENS.FuncModuleId; //功能模块Id
objvMicroteachCase_Resource_Rel_BaseENT.FuncModuleName = objvMicroteachCase_Resource_Rel_BaseENS.FuncModuleName; //功能模块名称
objvMicroteachCase_Resource_Rel_BaseENT.IdMicroteachCase = objvMicroteachCase_Resource_Rel_BaseENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseENT.IdResource = objvMicroteachCase_Resource_Rel_BaseENS.IdResource; //资源流水号
objvMicroteachCase_Resource_Rel_BaseENT.ResourceID = objvMicroteachCase_Resource_Rel_BaseENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel_BaseENT.ResourceName = objvMicroteachCase_Resource_Rel_BaseENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel_BaseENT.IdFtpResource = objvMicroteachCase_Resource_Rel_BaseENS.IdFtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseENT.IdFile = objvMicroteachCase_Resource_Rel_BaseENS.IdFile; //文件流水号
objvMicroteachCase_Resource_Rel_BaseENT.FileName = objvMicroteachCase_Resource_Rel_BaseENS.FileName; //文件名称
objvMicroteachCase_Resource_Rel_BaseENT.FileType = objvMicroteachCase_Resource_Rel_BaseENS.FileType; //文件类型
objvMicroteachCase_Resource_Rel_BaseENT.SaveDate = objvMicroteachCase_Resource_Rel_BaseENS.SaveDate; //创建日期
objvMicroteachCase_Resource_Rel_BaseENT.FileSize = objvMicroteachCase_Resource_Rel_BaseENS.FileSize; //文件大小
objvMicroteachCase_Resource_Rel_BaseENT.SaveTime = objvMicroteachCase_Resource_Rel_BaseENS.SaveTime; //创建时间
objvMicroteachCase_Resource_Rel_BaseENT.FtpResourceID = objvMicroteachCase_Resource_Rel_BaseENS.FtpResourceID; //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseENT.FileOriginalName = objvMicroteachCase_Resource_Rel_BaseENS.FileOriginalName; //文件原名
objvMicroteachCase_Resource_Rel_BaseENT.FileDirName = objvMicroteachCase_Resource_Rel_BaseENS.FileDirName; //文件目录名
objvMicroteachCase_Resource_Rel_BaseENT.FileRename = objvMicroteachCase_Resource_Rel_BaseENS.FileRename; //文件新名
objvMicroteachCase_Resource_Rel_BaseENT.FileUpDate = objvMicroteachCase_Resource_Rel_BaseENS.FileUpDate; //创建日期
objvMicroteachCase_Resource_Rel_BaseENT.FileUpTime = objvMicroteachCase_Resource_Rel_BaseENS.FileUpTime; //创建时间
objvMicroteachCase_Resource_Rel_BaseENT.SaveMode = objvMicroteachCase_Resource_Rel_BaseENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_Rel_BaseENT.IdResourceType = objvMicroteachCase_Resource_Rel_BaseENS.IdResourceType; //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseENT.ResourceTypeID = objvMicroteachCase_Resource_Rel_BaseENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_Rel_BaseENT.ResourceTypeName = objvMicroteachCase_Resource_Rel_BaseENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_Rel_BaseENT.ResourceOwner = objvMicroteachCase_Resource_Rel_BaseENS.ResourceOwner; //上传者
objvMicroteachCase_Resource_Rel_BaseENT.ftpFileType = objvMicroteachCase_Resource_Rel_BaseENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseENT.ftpFileSize = objvMicroteachCase_Resource_Rel_BaseENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseENT.ftpResourceOwner = objvMicroteachCase_Resource_Rel_BaseENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseENT.FileOriginName = objvMicroteachCase_Resource_Rel_BaseENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_Rel_BaseENT.IsExistFile = objvMicroteachCase_Resource_Rel_BaseENS.IsExistFile; //是否存在文件
objvMicroteachCase_Resource_Rel_BaseENT.FileNewName = objvMicroteachCase_Resource_Rel_BaseENS.FileNewName; //新文件名
objvMicroteachCase_Resource_Rel_BaseENT.FileOldName = objvMicroteachCase_Resource_Rel_BaseENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_Rel_BaseENT.IsMain = objvMicroteachCase_Resource_Rel_BaseENS.IsMain; //是否主资源
objvMicroteachCase_Resource_Rel_BaseENT.IdUsingMode = objvMicroteachCase_Resource_Rel_BaseENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseENT.IndexNO = objvMicroteachCase_Resource_Rel_BaseENS.IndexNO; //序号
objvMicroteachCase_Resource_Rel_BaseENT.BrowseCount = objvMicroteachCase_Resource_Rel_BaseENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_Rel_BaseENT.UpdDate = objvMicroteachCase_Resource_Rel_BaseENS.UpdDate; //修改日期
objvMicroteachCase_Resource_Rel_BaseENT.UpdUser = objvMicroteachCase_Resource_Rel_BaseENS.UpdUser; //修改人
objvMicroteachCase_Resource_Rel_BaseENT.Memo = objvMicroteachCase_Resource_Rel_BaseENS.Memo; //备注
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
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCase_Resource_Rel_BaseEN:objvMicroteachCase_Resource_Rel_BaseENT</returns>
 public static clsvMicroteachCase_Resource_Rel_BaseEN CopyTo(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseENS)
{
try
{
 clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseENT = new clsvMicroteachCase_Resource_Rel_BaseEN()
{
IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel_BaseENS.IdMicroteachCaseResourceRel, //微格案例资源关系流水号
FuncModuleId = objvMicroteachCase_Resource_Rel_BaseENS.FuncModuleId, //功能模块Id
FuncModuleName = objvMicroteachCase_Resource_Rel_BaseENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvMicroteachCase_Resource_Rel_BaseENS.IdMicroteachCase, //微格教学案例流水号
IdResource = objvMicroteachCase_Resource_Rel_BaseENS.IdResource, //资源流水号
ResourceID = objvMicroteachCase_Resource_Rel_BaseENS.ResourceID, //资源ID
ResourceName = objvMicroteachCase_Resource_Rel_BaseENS.ResourceName, //资源名称
IdFtpResource = objvMicroteachCase_Resource_Rel_BaseENS.IdFtpResource, //FTP资源流水号
IdFile = objvMicroteachCase_Resource_Rel_BaseENS.IdFile, //文件流水号
FileName = objvMicroteachCase_Resource_Rel_BaseENS.FileName, //文件名称
FileType = objvMicroteachCase_Resource_Rel_BaseENS.FileType, //文件类型
SaveDate = objvMicroteachCase_Resource_Rel_BaseENS.SaveDate, //创建日期
FileSize = objvMicroteachCase_Resource_Rel_BaseENS.FileSize, //文件大小
SaveTime = objvMicroteachCase_Resource_Rel_BaseENS.SaveTime, //创建时间
FtpResourceID = objvMicroteachCase_Resource_Rel_BaseENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvMicroteachCase_Resource_Rel_BaseENS.FileOriginalName, //文件原名
FileDirName = objvMicroteachCase_Resource_Rel_BaseENS.FileDirName, //文件目录名
FileRename = objvMicroteachCase_Resource_Rel_BaseENS.FileRename, //文件新名
FileUpDate = objvMicroteachCase_Resource_Rel_BaseENS.FileUpDate, //创建日期
FileUpTime = objvMicroteachCase_Resource_Rel_BaseENS.FileUpTime, //创建时间
SaveMode = objvMicroteachCase_Resource_Rel_BaseENS.SaveMode, //文件存放方式
IdResourceType = objvMicroteachCase_Resource_Rel_BaseENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvMicroteachCase_Resource_Rel_BaseENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvMicroteachCase_Resource_Rel_BaseENS.ResourceTypeName, //资源类型名称
ResourceOwner = objvMicroteachCase_Resource_Rel_BaseENS.ResourceOwner, //上传者
ftpFileType = objvMicroteachCase_Resource_Rel_BaseENS.ftpFileType, //ftp文件类型
ftpFileSize = objvMicroteachCase_Resource_Rel_BaseENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvMicroteachCase_Resource_Rel_BaseENS.ftpResourceOwner, //Ftp资源拥有者
FileOriginName = objvMicroteachCase_Resource_Rel_BaseENS.FileOriginName, //原文件名
IsExistFile = objvMicroteachCase_Resource_Rel_BaseENS.IsExistFile, //是否存在文件
FileNewName = objvMicroteachCase_Resource_Rel_BaseENS.FileNewName, //新文件名
FileOldName = objvMicroteachCase_Resource_Rel_BaseENS.FileOldName, //旧文件名
IsMain = objvMicroteachCase_Resource_Rel_BaseENS.IsMain, //是否主资源
IdUsingMode = objvMicroteachCase_Resource_Rel_BaseENS.IdUsingMode, //资源使用模式流水号
IndexNO = objvMicroteachCase_Resource_Rel_BaseENS.IndexNO, //序号
BrowseCount = objvMicroteachCase_Resource_Rel_BaseENS.BrowseCount, //浏览次数
UpdDate = objvMicroteachCase_Resource_Rel_BaseENS.UpdDate, //修改日期
UpdUser = objvMicroteachCase_Resource_Rel_BaseENS.UpdUser, //修改人
Memo = objvMicroteachCase_Resource_Rel_BaseENS.Memo, //备注
};
 return objvMicroteachCase_Resource_Rel_BaseENT;
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
public static void CheckProperty4Condition(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN)
{
 clsvMicroteachCase_Resource_Rel_BaseBL.vMicroteachCase_Resource_Rel_BaseDA.CheckProperty4Condition(objvMicroteachCase_Resource_Rel_BaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel) == true)
{
string strComparisonOpIdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel, objvMicroteachCase_Resource_Rel_BaseCond.IdMicroteachCaseResourceRel, strComparisonOpIdMicroteachCaseResourceRel);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FuncModuleId, objvMicroteachCase_Resource_Rel_BaseCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FuncModuleName, objvMicroteachCase_Resource_Rel_BaseCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.IdMicroteachCase, objvMicroteachCase_Resource_Rel_BaseCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IdResource) == true)
{
string strComparisonOpIdResource = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.IdResource, objvMicroteachCase_Resource_Rel_BaseCond.IdResource, strComparisonOpIdResource);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ResourceID) == true)
{
string strComparisonOpResourceID = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ResourceID, objvMicroteachCase_Resource_Rel_BaseCond.ResourceID, strComparisonOpResourceID);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ResourceName) == true)
{
string strComparisonOpResourceName = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ResourceName, objvMicroteachCase_Resource_Rel_BaseCond.ResourceName, strComparisonOpResourceName);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.IdFtpResource, objvMicroteachCase_Resource_Rel_BaseCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IdFile) == true)
{
string strComparisonOpIdFile = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.IdFile, objvMicroteachCase_Resource_Rel_BaseCond.IdFile, strComparisonOpIdFile);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileName) == true)
{
string strComparisonOpFileName = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileName, objvMicroteachCase_Resource_Rel_BaseCond.FileName, strComparisonOpFileName);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileType) == true)
{
string strComparisonOpFileType = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileType, objvMicroteachCase_Resource_Rel_BaseCond.FileType, strComparisonOpFileType);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.SaveDate) == true)
{
string strComparisonOpSaveDate = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.SaveDate, objvMicroteachCase_Resource_Rel_BaseCond.SaveDate, strComparisonOpSaveDate);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileSize) == true)
{
string strComparisonOpFileSize = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileSize, objvMicroteachCase_Resource_Rel_BaseCond.FileSize, strComparisonOpFileSize);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.SaveTime) == true)
{
string strComparisonOpSaveTime = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.SaveTime, objvMicroteachCase_Resource_Rel_BaseCond.SaveTime, strComparisonOpSaveTime);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FtpResourceID, objvMicroteachCase_Resource_Rel_BaseCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileOriginalName, objvMicroteachCase_Resource_Rel_BaseCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileDirName) == true)
{
string strComparisonOpFileDirName = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileDirName, objvMicroteachCase_Resource_Rel_BaseCond.FileDirName, strComparisonOpFileDirName);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileRename) == true)
{
string strComparisonOpFileRename = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileRename, objvMicroteachCase_Resource_Rel_BaseCond.FileRename, strComparisonOpFileRename);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileUpDate, objvMicroteachCase_Resource_Rel_BaseCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileUpTime, objvMicroteachCase_Resource_Rel_BaseCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.SaveMode) == true)
{
if (objvMicroteachCase_Resource_Rel_BaseCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel_Base.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel_Base.SaveMode);
}
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.IdResourceType, objvMicroteachCase_Resource_Rel_BaseCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ResourceTypeID, objvMicroteachCase_Resource_Rel_BaseCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ResourceTypeName, objvMicroteachCase_Resource_Rel_BaseCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ResourceOwner, objvMicroteachCase_Resource_Rel_BaseCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ftpFileType, objvMicroteachCase_Resource_Rel_BaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ftpFileSize, objvMicroteachCase_Resource_Rel_BaseCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ftpResourceOwner, objvMicroteachCase_Resource_Rel_BaseCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileOriginName, objvMicroteachCase_Resource_Rel_BaseCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IsExistFile) == true)
{
if (objvMicroteachCase_Resource_Rel_BaseCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel_Base.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel_Base.IsExistFile);
}
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileNewName) == true)
{
string strComparisonOpFileNewName = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileNewName, objvMicroteachCase_Resource_Rel_BaseCond.FileNewName, strComparisonOpFileNewName);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileOldName) == true)
{
string strComparisonOpFileOldName = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileOldName, objvMicroteachCase_Resource_Rel_BaseCond.FileOldName, strComparisonOpFileOldName);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IsMain) == true)
{
if (objvMicroteachCase_Resource_Rel_BaseCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel_Base.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel_Base.IsMain);
}
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IdUsingMode) == true)
{
string strComparisonOpIdUsingMode = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IdUsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.IdUsingMode, objvMicroteachCase_Resource_Rel_BaseCond.IdUsingMode, strComparisonOpIdUsingMode);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IndexNO) == true)
{
string strComparisonOpIndexNO = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel_Base.IndexNO, objvMicroteachCase_Resource_Rel_BaseCond.IndexNO, strComparisonOpIndexNO);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel_Base.BrowseCount, objvMicroteachCase_Resource_Rel_BaseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.UpdDate) == true)
{
string strComparisonOpUpdDate = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.UpdDate, objvMicroteachCase_Resource_Rel_BaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.UpdUser) == true)
{
string strComparisonOpUpdUser = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.UpdUser, objvMicroteachCase_Resource_Rel_BaseCond.UpdUser, strComparisonOpUpdUser);
}
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(convMicroteachCase_Resource_Rel_Base.Memo) == true)
{
string strComparisonOpMemo = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.Memo, objvMicroteachCase_Resource_Rel_BaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachCase_Resource_Rel_Base
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vMicroteachCase_Resource_Rel_Base(vMicroteachCase_Resource_Rel_Base)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase_Resource_Rel_BaseBL
{
public static RelatedActions_vMicroteachCase_Resource_Rel_Base relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachCase_Resource_Rel_BaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachCase_Resource_Rel_BaseDA vMicroteachCase_Resource_Rel_BaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachCase_Resource_Rel_BaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachCase_Resource_Rel_BaseBL()
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
if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_Rel_BaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_Rel_BaseEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachCase_Resource_Rel_Base(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachCase_Resource_Rel_BaseDA.GetDataTable_vMicroteachCase_Resource_Rel_Base(strWhereCond);
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
objDT = vMicroteachCase_Resource_Rel_BaseDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachCase_Resource_Rel_BaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachCase_Resource_Rel_BaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachCase_Resource_Rel_BaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachCase_Resource_Rel_BaseDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachCase_Resource_Rel_BaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachCase_Resource_Rel_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachCase_Resource_Rel_BaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstByIdMicroteachCaseResourceRelLst(List<long> arrIdMicroteachCaseResourceRelLst)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
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
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstByIdMicroteachCaseResourceRelLstCache(List<long> arrIdMicroteachCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName);
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrvMicroteachCase_Resource_Rel_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel_BaseEN> arrvMicroteachCase_Resource_Rel_BaseObjLst_Sel =
arrvMicroteachCase_Resource_Rel_BaseObjLstCache
.Where(x => arrIdMicroteachCaseResourceRelLst.Contains(x.IdMicroteachCaseResourceRel));
return arrvMicroteachCase_Resource_Rel_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachCase_Resource_Rel_BaseEN> GetSubObjLstCache(clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseCond)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase_Resource_Rel_Base.AttributeName)
{
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel_BaseCond[strFldName]));
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
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
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
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
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel_BaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = new clsvMicroteachCase_Resource_Rel_BaseEN();
try
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel_Base.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objRow[convMicroteachCase_Resource_Rel_Base.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objRow[convMicroteachCase_Resource_Rel_Base.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objRow[convMicroteachCase_Resource_Rel_Base.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objRow[convMicroteachCase_Resource_Rel_Base.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objRow[convMicroteachCase_Resource_Rel_Base.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objRow[convMicroteachCase_Resource_Rel_Base.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objRow[convMicroteachCase_Resource_Rel_Base.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objRow[convMicroteachCase_Resource_Rel_Base.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objRow[convMicroteachCase_Resource_Rel_Base.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objRow[convMicroteachCase_Resource_Rel_Base.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objRow[convMicroteachCase_Resource_Rel_Base.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel_Base.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objRow[convMicroteachCase_Resource_Rel_Base.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel_Base.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objRow[convMicroteachCase_Resource_Rel_Base.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objRow[convMicroteachCase_Resource_Rel_Base.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objRow[convMicroteachCase_Resource_Rel_Base.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel_Base.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_Rel_BaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachCase_Resource_Rel_Base(ref clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN)
{
bool bolResult = vMicroteachCase_Resource_Rel_BaseDA.GetvMicroteachCase_Resource_Rel_Base(ref objvMicroteachCase_Resource_Rel_BaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = vMicroteachCase_Resource_Rel_BaseDA.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
return objvMicroteachCase_Resource_Rel_BaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = vMicroteachCase_Resource_Rel_BaseDA.GetFirstObj(strWhereCond);
 return objvMicroteachCase_Resource_Rel_BaseEN;
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
public static clsvMicroteachCase_Resource_Rel_BaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = vMicroteachCase_Resource_Rel_BaseDA.GetObjByDataRow(objRow);
 return objvMicroteachCase_Resource_Rel_BaseEN;
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
public static clsvMicroteachCase_Resource_Rel_BaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = vMicroteachCase_Resource_Rel_BaseDA.GetObjByDataRow(objRow);
 return objvMicroteachCase_Resource_Rel_BaseEN;
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
 /// <param name = "lstvMicroteachCase_Resource_Rel_BaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN GetObjByIdMicroteachCaseResourceRelFromList(long lngIdMicroteachCaseResourceRel, List<clsvMicroteachCase_Resource_Rel_BaseEN> lstvMicroteachCase_Resource_Rel_BaseObjLst)
{
foreach (clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN in lstvMicroteachCase_Resource_Rel_BaseObjLst)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel)
{
return objvMicroteachCase_Resource_Rel_BaseEN;
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
 lngIdMicroteachCaseResourceRel = new clsvMicroteachCase_Resource_Rel_BaseDA().GetFirstID(strWhereCond);
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
 arrList = vMicroteachCase_Resource_Rel_BaseDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachCase_Resource_Rel_BaseDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vMicroteachCase_Resource_Rel_BaseDA.IsExist(lngIdMicroteachCaseResourceRel);
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
 bolIsExist = clsvMicroteachCase_Resource_Rel_BaseDA.IsExistTable();
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
 bolIsExist = vMicroteachCase_Resource_Rel_BaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseENS, clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseENT)
{
try
{
objvMicroteachCase_Resource_Rel_BaseENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel_BaseENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseENT.FuncModuleId = objvMicroteachCase_Resource_Rel_BaseENS.FuncModuleId; //功能模块Id
objvMicroteachCase_Resource_Rel_BaseENT.FuncModuleName = objvMicroteachCase_Resource_Rel_BaseENS.FuncModuleName; //功能模块名称
objvMicroteachCase_Resource_Rel_BaseENT.IdMicroteachCase = objvMicroteachCase_Resource_Rel_BaseENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseENT.IdResource = objvMicroteachCase_Resource_Rel_BaseENS.IdResource; //资源流水号
objvMicroteachCase_Resource_Rel_BaseENT.ResourceID = objvMicroteachCase_Resource_Rel_BaseENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel_BaseENT.ResourceName = objvMicroteachCase_Resource_Rel_BaseENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel_BaseENT.IdFtpResource = objvMicroteachCase_Resource_Rel_BaseENS.IdFtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseENT.IdFile = objvMicroteachCase_Resource_Rel_BaseENS.IdFile; //文件流水号
objvMicroteachCase_Resource_Rel_BaseENT.FileName = objvMicroteachCase_Resource_Rel_BaseENS.FileName; //文件名称
objvMicroteachCase_Resource_Rel_BaseENT.FileType = objvMicroteachCase_Resource_Rel_BaseENS.FileType; //文件类型
objvMicroteachCase_Resource_Rel_BaseENT.SaveDate = objvMicroteachCase_Resource_Rel_BaseENS.SaveDate; //创建日期
objvMicroteachCase_Resource_Rel_BaseENT.FileSize = objvMicroteachCase_Resource_Rel_BaseENS.FileSize; //文件大小
objvMicroteachCase_Resource_Rel_BaseENT.SaveTime = objvMicroteachCase_Resource_Rel_BaseENS.SaveTime; //创建时间
objvMicroteachCase_Resource_Rel_BaseENT.FtpResourceID = objvMicroteachCase_Resource_Rel_BaseENS.FtpResourceID; //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseENT.FileOriginalName = objvMicroteachCase_Resource_Rel_BaseENS.FileOriginalName; //文件原名
objvMicroteachCase_Resource_Rel_BaseENT.FileDirName = objvMicroteachCase_Resource_Rel_BaseENS.FileDirName; //文件目录名
objvMicroteachCase_Resource_Rel_BaseENT.FileRename = objvMicroteachCase_Resource_Rel_BaseENS.FileRename; //文件新名
objvMicroteachCase_Resource_Rel_BaseENT.FileUpDate = objvMicroteachCase_Resource_Rel_BaseENS.FileUpDate; //创建日期
objvMicroteachCase_Resource_Rel_BaseENT.FileUpTime = objvMicroteachCase_Resource_Rel_BaseENS.FileUpTime; //创建时间
objvMicroteachCase_Resource_Rel_BaseENT.SaveMode = objvMicroteachCase_Resource_Rel_BaseENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_Rel_BaseENT.IdResourceType = objvMicroteachCase_Resource_Rel_BaseENS.IdResourceType; //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseENT.ResourceTypeID = objvMicroteachCase_Resource_Rel_BaseENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_Rel_BaseENT.ResourceTypeName = objvMicroteachCase_Resource_Rel_BaseENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_Rel_BaseENT.ResourceOwner = objvMicroteachCase_Resource_Rel_BaseENS.ResourceOwner; //上传者
objvMicroteachCase_Resource_Rel_BaseENT.ftpFileType = objvMicroteachCase_Resource_Rel_BaseENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseENT.ftpFileSize = objvMicroteachCase_Resource_Rel_BaseENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseENT.ftpResourceOwner = objvMicroteachCase_Resource_Rel_BaseENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseENT.FileOriginName = objvMicroteachCase_Resource_Rel_BaseENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_Rel_BaseENT.IsExistFile = objvMicroteachCase_Resource_Rel_BaseENS.IsExistFile; //是否存在文件
objvMicroteachCase_Resource_Rel_BaseENT.FileNewName = objvMicroteachCase_Resource_Rel_BaseENS.FileNewName; //新文件名
objvMicroteachCase_Resource_Rel_BaseENT.FileOldName = objvMicroteachCase_Resource_Rel_BaseENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_Rel_BaseENT.IsMain = objvMicroteachCase_Resource_Rel_BaseENS.IsMain; //是否主资源
objvMicroteachCase_Resource_Rel_BaseENT.IdUsingMode = objvMicroteachCase_Resource_Rel_BaseENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseENT.IndexNO = objvMicroteachCase_Resource_Rel_BaseENS.IndexNO; //序号
objvMicroteachCase_Resource_Rel_BaseENT.BrowseCount = objvMicroteachCase_Resource_Rel_BaseENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_Rel_BaseENT.UpdDate = objvMicroteachCase_Resource_Rel_BaseENS.UpdDate; //修改日期
objvMicroteachCase_Resource_Rel_BaseENT.UpdUser = objvMicroteachCase_Resource_Rel_BaseENS.UpdUser; //修改人
objvMicroteachCase_Resource_Rel_BaseENT.Memo = objvMicroteachCase_Resource_Rel_BaseENS.Memo; //备注
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
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN)
{
try
{
objvMicroteachCase_Resource_Rel_BaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachCase_Resource_Rel_BaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase = objvMicroteachCase_Resource_Rel_BaseEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.IdResource = objvMicroteachCase_Resource_Rel_BaseEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = objvMicroteachCase_Resource_Rel_BaseEN.ResourceID == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = objvMicroteachCase_Resource_Rel_BaseEN.ResourceName == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.IdFile = objvMicroteachCase_Resource_Rel_BaseEN.IdFile == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FileName = objvMicroteachCase_Resource_Rel_BaseEN.FileName == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FileName; //文件名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FileType = objvMicroteachCase_Resource_Rel_BaseEN.FileType == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FileType; //文件类型
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = objvMicroteachCase_Resource_Rel_BaseEN.SaveDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = objvMicroteachCase_Resource_Rel_BaseEN.FileSize == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = objvMicroteachCase_Resource_Rel_BaseEN.SaveTime == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = objvMicroteachCase_Resource_Rel_BaseEN.FileDirName == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = objvMicroteachCase_Resource_Rel_BaseEN.FileRename == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = objvMicroteachCase_Resource_Rel_BaseEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = objvMicroteachCase_Resource_Rel_BaseEN.FileNewName == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = objvMicroteachCase_Resource_Rel_BaseEN.FileOldName == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = objvMicroteachCase_Resource_Rel_BaseEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.IdUsingMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode; //资源使用模式流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = objvMicroteachCase_Resource_Rel_BaseEN.IndexNO; //序号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = objvMicroteachCase_Resource_Rel_BaseEN.UpdDate == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = objvMicroteachCase_Resource_Rel_BaseEN.UpdUser == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convMicroteachCase_Resource_Rel_Base.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_Rel_BaseEN.Memo = objvMicroteachCase_Resource_Rel_BaseEN.Memo == "[null]" ? null :  objvMicroteachCase_Resource_Rel_BaseEN.Memo; //备注
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
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN)
{
try
{
if (objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = null; //功能模块名称
if (objvMicroteachCase_Resource_Rel_BaseEN.ResourceID == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = null; //资源ID
if (objvMicroteachCase_Resource_Rel_BaseEN.ResourceName == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = null; //资源名称
if (objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.IdFtpResource = null; //FTP资源流水号
if (objvMicroteachCase_Resource_Rel_BaseEN.IdFile == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.IdFile = null; //文件流水号
if (objvMicroteachCase_Resource_Rel_BaseEN.FileName == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FileName = null; //文件名称
if (objvMicroteachCase_Resource_Rel_BaseEN.FileType == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FileType = null; //文件类型
if (objvMicroteachCase_Resource_Rel_BaseEN.SaveDate == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = null; //创建日期
if (objvMicroteachCase_Resource_Rel_BaseEN.FileSize == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FileSize = null; //文件大小
if (objvMicroteachCase_Resource_Rel_BaseEN.SaveTime == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = null; //创建时间
if (objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = null; //FTP资源ID
if (objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = null; //文件原名
if (objvMicroteachCase_Resource_Rel_BaseEN.FileDirName == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = null; //文件目录名
if (objvMicroteachCase_Resource_Rel_BaseEN.FileRename == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FileRename = null; //文件新名
if (objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = null; //创建日期
if (objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = null; //创建时间
if (objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.IdResourceType = null; //资源类型流水号
if (objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = null; //资源类型ID
if (objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = null; //资源类型名称
if (objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = null; //上传者
if (objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = null; //ftp文件类型
if (objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = null; //ftp文件大小
if (objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = null; //原文件名
if (objvMicroteachCase_Resource_Rel_BaseEN.FileNewName == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = null; //新文件名
if (objvMicroteachCase_Resource_Rel_BaseEN.FileOldName == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = null; //旧文件名
if (objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.IdUsingMode = null; //资源使用模式流水号
if (objvMicroteachCase_Resource_Rel_BaseEN.UpdDate == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = null; //修改日期
if (objvMicroteachCase_Resource_Rel_BaseEN.UpdUser == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = null; //修改人
if (objvMicroteachCase_Resource_Rel_BaseEN.Memo == "[null]") objvMicroteachCase_Resource_Rel_BaseEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN)
{
 vMicroteachCase_Resource_Rel_BaseDA.CheckProperty4Condition(objvMicroteachCase_Resource_Rel_BaseEN);
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCaseResourceRel");
//if (arrvMicroteachCase_Resource_Rel_BaseObjLstCache == null)
//{
//arrvMicroteachCase_Resource_Rel_BaseObjLstCache = vMicroteachCase_Resource_Rel_BaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN GetObjByIdMicroteachCaseResourceRelCache(long lngIdMicroteachCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName);
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrvMicroteachCase_Resource_Rel_BaseObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel_BaseEN> arrvMicroteachCase_Resource_Rel_BaseObjLst_Sel =
arrvMicroteachCase_Resource_Rel_BaseObjLstCache
.Where(x=> x.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel 
);
if (arrvMicroteachCase_Resource_Rel_BaseObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase_Resource_Rel_BaseEN obj = clsvMicroteachCase_Resource_Rel_BaseBL.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachCase_Resource_Rel_BaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetAllvMicroteachCase_Resource_Rel_BaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrvMicroteachCase_Resource_Rel_BaseObjLstCache = GetObjLstCache(); 
return arrvMicroteachCase_Resource_Rel_BaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName);
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrvMicroteachCase_Resource_Rel_BaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase_Resource_Rel_BaseObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName);
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
if (strInFldName != convMicroteachCase_Resource_Rel_Base.IdMicroteachCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachCase_Resource_Rel_Base.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachCase_Resource_Rel_Base.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachCase_Resource_Rel_Base = clsvMicroteachCase_Resource_Rel_BaseBL.GetObjByIdMicroteachCaseResourceRelCache(lngIdMicroteachCaseResourceRel);
if (objvMicroteachCase_Resource_Rel_Base == null) return "";
return objvMicroteachCase_Resource_Rel_Base[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachCase_Resource_Rel_BaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachCase_Resource_Rel_BaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachCase_Resource_Rel_BaseDA.GetRecCount();
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
int intRecCount = clsvMicroteachCase_Resource_Rel_BaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseCond)
{
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase_Resource_Rel_Base.AttributeName)
{
if (objvMicroteachCase_Resource_Rel_BaseCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase_Resource_Rel_BaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase_Resource_Rel_BaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel_BaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_Rel_BaseCond[strFldName]));
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
 List<string> arrList = clsvMicroteachCase_Resource_Rel_BaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase_Resource_Rel_BaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase_Resource_Rel_BaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}