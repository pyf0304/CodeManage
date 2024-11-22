
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroTeachCaseRelaInfoBL
 表名:vMicroTeachCaseRelaInfo(01120319)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:00
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
public static class  clsvMicroTeachCaseRelaInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroTeachCaseRelaInfoEN GetObj(this K_IdMicroTeachCaseRelaInfo_vMicroTeachCaseRelaInfo myKey)
{
clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = clsvMicroTeachCaseRelaInfoBL.vMicroTeachCaseRelaInfoDA.GetObjByIdMicroTeachCaseRelaInfo(myKey.Value);
return objvMicroTeachCaseRelaInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetIdMicroTeachCaseRelaInfo(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, long lngIdMicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = lngIdMicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFuncModuleId(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroTeachCaseRelaInfo.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroTeachCaseRelaInfo.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroTeachCaseRelaInfo.FuncModuleId);
}
objvMicroTeachCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FuncModuleId) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFuncModuleName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroTeachCaseRelaInfo.FuncModuleName);
}
objvMicroTeachCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FuncModuleName) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetIdMicroTeachCaseRelaInfoType(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strIdMicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroTeachCaseRelaInfoType, convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroTeachCaseRelaInfoType, 4, convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroTeachCaseRelaInfoType, 4, convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = strIdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroTeachCaseRelaInfoTypeName, convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetBrowseCount(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, int? intBrowseCount, string strComparisonOp="")
	{
objvMicroTeachCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.BrowseCount) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetResourceOwner(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convMicroTeachCaseRelaInfo.ResourceOwner);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroTeachCaseRelaInfo.ResourceOwner);
}
objvMicroTeachCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.ResourceOwner) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetftpFileType(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroTeachCaseRelaInfo.ftpFileType);
}
objvMicroTeachCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.ftpFileType) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetftpFileSize(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroTeachCaseRelaInfo.ftpFileSize);
}
objvMicroTeachCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.ftpFileSize) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetftpResourceOwner(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroTeachCaseRelaInfo.ftpResourceOwner);
}
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.ftpResourceOwner) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileOriginName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroTeachCaseRelaInfo.FileOriginName);
}
objvMicroTeachCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FileOriginName) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetIdFile(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convMicroTeachCaseRelaInfo.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convMicroTeachCaseRelaInfo.IdFile);
}
objvMicroTeachCaseRelaInfoEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.IdFile) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.IdFile, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdFile] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroTeachCaseRelaInfo.FileName);
}
objvMicroTeachCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FileName) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileType(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroTeachCaseRelaInfo.FileType);
}
objvMicroTeachCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FileType) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetSaveDate(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroTeachCaseRelaInfo.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroTeachCaseRelaInfo.SaveDate);
}
objvMicroTeachCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.SaveDate) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileSize(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroTeachCaseRelaInfo.FileSize);
}
objvMicroTeachCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FileSize) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetSaveTime(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroTeachCaseRelaInfo.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroTeachCaseRelaInfo.SaveTime);
}
objvMicroTeachCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.SaveTime) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetIdMicroteachCase(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convMicroTeachCaseRelaInfo.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroTeachCaseRelaInfo.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroTeachCaseRelaInfo.IdMicroteachCase);
}
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.IdMicroteachCase) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetMicroteachCaseName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroTeachCaseRelaInfo.MicroteachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroTeachCaseRelaInfo.MicroteachCaseName);
}
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.MicroteachCaseName) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetIdFtpResource(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convMicroTeachCaseRelaInfo.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convMicroTeachCaseRelaInfo.IdFtpResource);
}
objvMicroTeachCaseRelaInfoEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.IdFtpResource) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.IdFtpResource, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdFtpResource] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFtpResourceID(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convMicroTeachCaseRelaInfo.FtpResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroTeachCaseRelaInfo.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroTeachCaseRelaInfo.FtpResourceID);
}
objvMicroTeachCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FtpResourceID) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileOriginalName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroTeachCaseRelaInfo.FileOriginalName);
}
objvMicroTeachCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FileOriginalName) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileDirName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroTeachCaseRelaInfo.FileDirName);
}
objvMicroTeachCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FileDirName) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileRename(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroTeachCaseRelaInfo.FileRename);
}
objvMicroTeachCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FileRename) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileUpDate(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroTeachCaseRelaInfo.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroTeachCaseRelaInfo.FileUpDate);
}
objvMicroTeachCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FileUpDate) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileUpTime(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroTeachCaseRelaInfo.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroTeachCaseRelaInfo.FileUpTime);
}
objvMicroTeachCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FileUpTime) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetIdResource(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convMicroTeachCaseRelaInfo.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convMicroTeachCaseRelaInfo.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convMicroTeachCaseRelaInfo.IdResource);
}
objvMicroTeachCaseRelaInfoEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.IdResource) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.IdResource, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdResource] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetResourceID(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convMicroTeachCaseRelaInfo.ResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroTeachCaseRelaInfo.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroTeachCaseRelaInfo.ResourceID);
}
objvMicroTeachCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.ResourceID) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetSaveMode(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvMicroTeachCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.SaveMode) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetIdResourceType(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, convMicroTeachCaseRelaInfo.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convMicroTeachCaseRelaInfo.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convMicroTeachCaseRelaInfo.IdResourceType);
}
objvMicroTeachCaseRelaInfoEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.IdResourceType) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.IdResourceType, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdResourceType] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetResourceTypeID(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convMicroTeachCaseRelaInfo.ResourceTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroTeachCaseRelaInfo.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroTeachCaseRelaInfo.ResourceTypeID);
}
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.ResourceTypeID) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetResourceTypeName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convMicroTeachCaseRelaInfo.ResourceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroTeachCaseRelaInfo.ResourceTypeName);
}
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.ResourceTypeName) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFlag(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFlag, 50, convMicroTeachCaseRelaInfo.Flag);
}
objvMicroTeachCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.Flag) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileNewName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroTeachCaseRelaInfo.FileNewName);
}
objvMicroTeachCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FileNewName) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileOldName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroTeachCaseRelaInfo.FileOldName);
}
objvMicroTeachCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.FileOldName) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetIsExistFile(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvMicroTeachCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.IsExistFile) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetResourceName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroTeachCaseRelaInfo.ResourceName);
}
objvMicroTeachCaseRelaInfoEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.ResourceName) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.ResourceName, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceName] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetIsVisible(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMicroTeachCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.IsVisible) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetUpdDate(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroTeachCaseRelaInfo.UpdDate);
}
objvMicroTeachCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.UpdDate) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetUpdUser(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroTeachCaseRelaInfo.UpdUser);
}
objvMicroTeachCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.UpdUser) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetMemo(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroTeachCaseRelaInfo.Memo);
}
objvMicroTeachCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.Memo) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvMicroTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoENS, clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoENT)
{
try
{
objvMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvMicroTeachCaseRelaInfoENT.FuncModuleId = objvMicroTeachCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvMicroTeachCaseRelaInfoENT.FuncModuleName = objvMicroTeachCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvMicroTeachCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoENT.BrowseCount = objvMicroTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvMicroTeachCaseRelaInfoENT.ResourceOwner = objvMicroTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvMicroTeachCaseRelaInfoENT.ftpFileType = objvMicroTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvMicroTeachCaseRelaInfoENT.ftpFileSize = objvMicroTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvMicroTeachCaseRelaInfoENT.ftpResourceOwner = objvMicroTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroTeachCaseRelaInfoENT.FileOriginName = objvMicroTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvMicroTeachCaseRelaInfoENT.IdFile = objvMicroTeachCaseRelaInfoENS.IdFile; //文件流水号
objvMicroTeachCaseRelaInfoENT.FileName = objvMicroTeachCaseRelaInfoENS.FileName; //文件名称
objvMicroTeachCaseRelaInfoENT.FileType = objvMicroTeachCaseRelaInfoENS.FileType; //文件类型
objvMicroTeachCaseRelaInfoENT.SaveDate = objvMicroTeachCaseRelaInfoENS.SaveDate; //创建日期
objvMicroTeachCaseRelaInfoENT.FileSize = objvMicroTeachCaseRelaInfoENS.FileSize; //文件大小
objvMicroTeachCaseRelaInfoENT.SaveTime = objvMicroTeachCaseRelaInfoENS.SaveTime; //创建时间
objvMicroTeachCaseRelaInfoENT.IdMicroteachCase = objvMicroTeachCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvMicroTeachCaseRelaInfoENT.MicroteachCaseName = objvMicroTeachCaseRelaInfoENS.MicroteachCaseName; //微格教学案例名称
objvMicroTeachCaseRelaInfoENT.IdFtpResource = objvMicroTeachCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvMicroTeachCaseRelaInfoENT.FtpResourceID = objvMicroTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvMicroTeachCaseRelaInfoENT.FileOriginalName = objvMicroTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvMicroTeachCaseRelaInfoENT.FileDirName = objvMicroTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvMicroTeachCaseRelaInfoENT.FileRename = objvMicroTeachCaseRelaInfoENS.FileRename; //文件新名
objvMicroTeachCaseRelaInfoENT.FileUpDate = objvMicroTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvMicroTeachCaseRelaInfoENT.FileUpTime = objvMicroTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvMicroTeachCaseRelaInfoENT.IdResource = objvMicroTeachCaseRelaInfoENS.IdResource; //资源流水号
objvMicroTeachCaseRelaInfoENT.ResourceID = objvMicroTeachCaseRelaInfoENS.ResourceID; //资源ID
objvMicroTeachCaseRelaInfoENT.SaveMode = objvMicroTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvMicroTeachCaseRelaInfoENT.IdResourceType = objvMicroTeachCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvMicroTeachCaseRelaInfoENT.ResourceTypeID = objvMicroTeachCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvMicroTeachCaseRelaInfoENT.ResourceTypeName = objvMicroTeachCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvMicroTeachCaseRelaInfoENT.Flag = objvMicroTeachCaseRelaInfoENS.Flag; //标志
objvMicroTeachCaseRelaInfoENT.FileNewName = objvMicroTeachCaseRelaInfoENS.FileNewName; //新文件名
objvMicroTeachCaseRelaInfoENT.FileOldName = objvMicroTeachCaseRelaInfoENS.FileOldName; //旧文件名
objvMicroTeachCaseRelaInfoENT.IsExistFile = objvMicroTeachCaseRelaInfoENS.IsExistFile; //是否存在文件
objvMicroTeachCaseRelaInfoENT.ResourceName = objvMicroTeachCaseRelaInfoENS.ResourceName; //资源名称
objvMicroTeachCaseRelaInfoENT.IsVisible = objvMicroTeachCaseRelaInfoENS.IsVisible; //是否显示
objvMicroTeachCaseRelaInfoENT.UpdDate = objvMicroTeachCaseRelaInfoENS.UpdDate; //修改日期
objvMicroTeachCaseRelaInfoENT.UpdUser = objvMicroTeachCaseRelaInfoENS.UpdUser; //修改人
objvMicroTeachCaseRelaInfoENT.Memo = objvMicroTeachCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objvMicroTeachCaseRelaInfoENS">源对象</param>
 /// <returns>目标对象=>clsvMicroTeachCaseRelaInfoEN:objvMicroTeachCaseRelaInfoENT</returns>
 public static clsvMicroTeachCaseRelaInfoEN CopyTo(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoENS)
{
try
{
 clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoENT = new clsvMicroTeachCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = objvMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfo, //案例相关信息流水号
FuncModuleId = objvMicroTeachCaseRelaInfoENS.FuncModuleId, //功能模块Id
FuncModuleName = objvMicroTeachCaseRelaInfoENS.FuncModuleName, //功能模块名称
IdMicroTeachCaseRelaInfoType = objvMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType, //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeName = objvMicroTeachCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName, //微格案例相关信息类型名称
BrowseCount = objvMicroTeachCaseRelaInfoENS.BrowseCount, //浏览次数
ResourceOwner = objvMicroTeachCaseRelaInfoENS.ResourceOwner, //上传者
ftpFileType = objvMicroTeachCaseRelaInfoENS.ftpFileType, //ftp文件类型
ftpFileSize = objvMicroTeachCaseRelaInfoENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvMicroTeachCaseRelaInfoENS.ftpResourceOwner, //Ftp资源拥有者
FileOriginName = objvMicroTeachCaseRelaInfoENS.FileOriginName, //原文件名
IdFile = objvMicroTeachCaseRelaInfoENS.IdFile, //文件流水号
FileName = objvMicroTeachCaseRelaInfoENS.FileName, //文件名称
FileType = objvMicroTeachCaseRelaInfoENS.FileType, //文件类型
SaveDate = objvMicroTeachCaseRelaInfoENS.SaveDate, //创建日期
FileSize = objvMicroTeachCaseRelaInfoENS.FileSize, //文件大小
SaveTime = objvMicroTeachCaseRelaInfoENS.SaveTime, //创建时间
IdMicroteachCase = objvMicroTeachCaseRelaInfoENS.IdMicroteachCase, //微格教学案例流水号
MicroteachCaseName = objvMicroTeachCaseRelaInfoENS.MicroteachCaseName, //微格教学案例名称
IdFtpResource = objvMicroTeachCaseRelaInfoENS.IdFtpResource, //FTP资源流水号
FtpResourceID = objvMicroTeachCaseRelaInfoENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvMicroTeachCaseRelaInfoENS.FileOriginalName, //文件原名
FileDirName = objvMicroTeachCaseRelaInfoENS.FileDirName, //文件目录名
FileRename = objvMicroTeachCaseRelaInfoENS.FileRename, //文件新名
FileUpDate = objvMicroTeachCaseRelaInfoENS.FileUpDate, //创建日期
FileUpTime = objvMicroTeachCaseRelaInfoENS.FileUpTime, //创建时间
IdResource = objvMicroTeachCaseRelaInfoENS.IdResource, //资源流水号
ResourceID = objvMicroTeachCaseRelaInfoENS.ResourceID, //资源ID
SaveMode = objvMicroTeachCaseRelaInfoENS.SaveMode, //文件存放方式
IdResourceType = objvMicroTeachCaseRelaInfoENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvMicroTeachCaseRelaInfoENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvMicroTeachCaseRelaInfoENS.ResourceTypeName, //资源类型名称
Flag = objvMicroTeachCaseRelaInfoENS.Flag, //标志
FileNewName = objvMicroTeachCaseRelaInfoENS.FileNewName, //新文件名
FileOldName = objvMicroTeachCaseRelaInfoENS.FileOldName, //旧文件名
IsExistFile = objvMicroTeachCaseRelaInfoENS.IsExistFile, //是否存在文件
ResourceName = objvMicroTeachCaseRelaInfoENS.ResourceName, //资源名称
IsVisible = objvMicroTeachCaseRelaInfoENS.IsVisible, //是否显示
UpdDate = objvMicroTeachCaseRelaInfoENS.UpdDate, //修改日期
UpdUser = objvMicroTeachCaseRelaInfoENS.UpdUser, //修改人
Memo = objvMicroTeachCaseRelaInfoENS.Memo, //备注
};
 return objvMicroTeachCaseRelaInfoENT;
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
public static void CheckProperty4Condition(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN)
{
 clsvMicroTeachCaseRelaInfoBL.vMicroTeachCaseRelaInfoDA.CheckProperty4Condition(objvMicroTeachCaseRelaInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo) == true)
{
string strComparisonOpIdMicroTeachCaseRelaInfo = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo, objvMicroTeachCaseRelaInfoCond.IdMicroTeachCaseRelaInfo, strComparisonOpIdMicroTeachCaseRelaInfo);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FuncModuleId, objvMicroTeachCaseRelaInfoCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FuncModuleName, objvMicroTeachCaseRelaInfoCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType) == true)
{
string strComparisonOpIdMicroTeachCaseRelaInfoType = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType, objvMicroTeachCaseRelaInfoCond.IdMicroTeachCaseRelaInfoType, strComparisonOpIdMicroTeachCaseRelaInfoType);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOpMicroTeachCaseRelaInfoTypeName = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvMicroTeachCaseRelaInfoCond.MicroTeachCaseRelaInfoTypeName, strComparisonOpMicroTeachCaseRelaInfoTypeName);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroTeachCaseRelaInfo.BrowseCount, objvMicroTeachCaseRelaInfoCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ResourceOwner, objvMicroTeachCaseRelaInfoCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ftpFileType, objvMicroTeachCaseRelaInfoCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ftpFileSize, objvMicroTeachCaseRelaInfoCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ftpResourceOwner, objvMicroTeachCaseRelaInfoCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileOriginName, objvMicroTeachCaseRelaInfoCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.IdFile) == true)
{
string strComparisonOpIdFile = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.IdFile, objvMicroTeachCaseRelaInfoCond.IdFile, strComparisonOpIdFile);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FileName) == true)
{
string strComparisonOpFileName = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileName, objvMicroTeachCaseRelaInfoCond.FileName, strComparisonOpFileName);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FileType) == true)
{
string strComparisonOpFileType = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileType, objvMicroTeachCaseRelaInfoCond.FileType, strComparisonOpFileType);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.SaveDate) == true)
{
string strComparisonOpSaveDate = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.SaveDate, objvMicroTeachCaseRelaInfoCond.SaveDate, strComparisonOpSaveDate);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FileSize) == true)
{
string strComparisonOpFileSize = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileSize, objvMicroTeachCaseRelaInfoCond.FileSize, strComparisonOpFileSize);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.SaveTime) == true)
{
string strComparisonOpSaveTime = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.SaveTime, objvMicroTeachCaseRelaInfoCond.SaveTime, strComparisonOpSaveTime);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.IdMicroteachCase, objvMicroTeachCaseRelaInfoCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.MicroteachCaseName, objvMicroTeachCaseRelaInfoCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.IdFtpResource, objvMicroTeachCaseRelaInfoCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FtpResourceID, objvMicroTeachCaseRelaInfoCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileOriginalName, objvMicroTeachCaseRelaInfoCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FileDirName) == true)
{
string strComparisonOpFileDirName = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileDirName, objvMicroTeachCaseRelaInfoCond.FileDirName, strComparisonOpFileDirName);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FileRename) == true)
{
string strComparisonOpFileRename = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileRename, objvMicroTeachCaseRelaInfoCond.FileRename, strComparisonOpFileRename);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileUpDate, objvMicroTeachCaseRelaInfoCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileUpTime, objvMicroTeachCaseRelaInfoCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.IdResource) == true)
{
string strComparisonOpIdResource = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.IdResource, objvMicroTeachCaseRelaInfoCond.IdResource, strComparisonOpIdResource);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.ResourceID) == true)
{
string strComparisonOpResourceID = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ResourceID, objvMicroTeachCaseRelaInfoCond.ResourceID, strComparisonOpResourceID);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.SaveMode) == true)
{
if (objvMicroTeachCaseRelaInfoCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCaseRelaInfo.SaveMode);
}
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.IdResourceType, objvMicroTeachCaseRelaInfoCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ResourceTypeID, objvMicroTeachCaseRelaInfoCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ResourceTypeName, objvMicroTeachCaseRelaInfoCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.Flag) == true)
{
string strComparisonOpFlag = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.Flag, objvMicroTeachCaseRelaInfoCond.Flag, strComparisonOpFlag);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FileNewName) == true)
{
string strComparisonOpFileNewName = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileNewName, objvMicroTeachCaseRelaInfoCond.FileNewName, strComparisonOpFileNewName);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.FileOldName) == true)
{
string strComparisonOpFileOldName = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileOldName, objvMicroTeachCaseRelaInfoCond.FileOldName, strComparisonOpFileOldName);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.IsExistFile) == true)
{
if (objvMicroTeachCaseRelaInfoCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCaseRelaInfo.IsExistFile);
}
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.ResourceName) == true)
{
string strComparisonOpResourceName = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ResourceName, objvMicroTeachCaseRelaInfoCond.ResourceName, strComparisonOpResourceName);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.IsVisible) == true)
{
if (objvMicroTeachCaseRelaInfoCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCaseRelaInfo.IsVisible);
}
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.UpdDate, objvMicroTeachCaseRelaInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.UpdUser) == true)
{
string strComparisonOpUpdUser = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.UpdUser, objvMicroTeachCaseRelaInfoCond.UpdUser, strComparisonOpUpdUser);
}
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(convMicroTeachCaseRelaInfo.Memo) == true)
{
string strComparisonOpMemo = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.Memo, objvMicroTeachCaseRelaInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroTeachCaseRelaInfo
{
public virtual bool UpdRelaTabDate(long lngIdMicroTeachCaseRelaInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 微格案例相关信息视图(vMicroTeachCaseRelaInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroTeachCaseRelaInfoBL
{
public static RelatedActions_vMicroTeachCaseRelaInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroTeachCaseRelaInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroTeachCaseRelaInfoDA vMicroTeachCaseRelaInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroTeachCaseRelaInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroTeachCaseRelaInfoBL()
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
if (string.IsNullOrEmpty(clsvMicroTeachCaseRelaInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroTeachCaseRelaInfoEN._ConnectString);
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
public static DataTable GetDataTable_vMicroTeachCaseRelaInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroTeachCaseRelaInfoDA.GetDataTable_vMicroTeachCaseRelaInfo(strWhereCond);
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
objDT = vMicroTeachCaseRelaInfoDA.GetDataTable(strWhereCond);
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
objDT = vMicroTeachCaseRelaInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroTeachCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroTeachCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroTeachCaseRelaInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroTeachCaseRelaInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroTeachCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroTeachCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstByIdMicroTeachCaseRelaInfoLst(List<long> arrIdMicroTeachCaseRelaInfoLst)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
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
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroTeachCaseRelaInfoEN> GetObjLstByIdMicroTeachCaseRelaInfoLstCache(List<long> arrIdMicroTeachCaseRelaInfoLst)
{
string strKey = string.Format("{0}", clsvMicroTeachCaseRelaInfoEN._CurrTabName);
List<clsvMicroTeachCaseRelaInfoEN> arrvMicroTeachCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroTeachCaseRelaInfoEN> arrvMicroTeachCaseRelaInfoObjLst_Sel =
arrvMicroTeachCaseRelaInfoObjLstCache
.Where(x => arrIdMicroTeachCaseRelaInfoLst.Contains(x.IdMicroTeachCaseRelaInfo));
return arrvMicroTeachCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroTeachCaseRelaInfoEN> GetSubObjLstCache(clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoCond)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroTeachCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroTeachCaseRelaInfo.AttributeName)
{
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroTeachCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroTeachCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroTeachCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroTeachCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroTeachCaseRelaInfoCond[strFldName]));
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
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
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroTeachCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
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
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroTeachCaseRelaInfo(ref clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN)
{
bool bolResult = vMicroTeachCaseRelaInfoDA.GetvMicroTeachCaseRelaInfo(ref objvMicroTeachCaseRelaInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroTeachCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = vMicroTeachCaseRelaInfoDA.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);
return objvMicroTeachCaseRelaInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroTeachCaseRelaInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = vMicroTeachCaseRelaInfoDA.GetFirstObj(strWhereCond);
 return objvMicroTeachCaseRelaInfoEN;
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
public static clsvMicroTeachCaseRelaInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = vMicroTeachCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvMicroTeachCaseRelaInfoEN;
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
public static clsvMicroTeachCaseRelaInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = vMicroTeachCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvMicroTeachCaseRelaInfoEN;
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
 /// <param name = "lstvMicroTeachCaseRelaInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroTeachCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfoFromList(long lngIdMicroTeachCaseRelaInfo, List<clsvMicroTeachCaseRelaInfoEN> lstvMicroTeachCaseRelaInfoObjLst)
{
foreach (clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN in lstvMicroTeachCaseRelaInfoObjLst)
{
if (objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo == lngIdMicroTeachCaseRelaInfo)
{
return objvMicroTeachCaseRelaInfoEN;
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
 lngIdMicroTeachCaseRelaInfo = new clsvMicroTeachCaseRelaInfoDA().GetFirstID(strWhereCond);
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
 arrList = vMicroTeachCaseRelaInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroTeachCaseRelaInfoDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vMicroTeachCaseRelaInfoDA.IsExist(lngIdMicroTeachCaseRelaInfo);
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
 bolIsExist = clsvMicroTeachCaseRelaInfoDA.IsExistTable();
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
 bolIsExist = vMicroTeachCaseRelaInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvMicroTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoENS, clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoENT)
{
try
{
objvMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvMicroTeachCaseRelaInfoENT.FuncModuleId = objvMicroTeachCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvMicroTeachCaseRelaInfoENT.FuncModuleName = objvMicroTeachCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvMicroTeachCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoENT.BrowseCount = objvMicroTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvMicroTeachCaseRelaInfoENT.ResourceOwner = objvMicroTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvMicroTeachCaseRelaInfoENT.ftpFileType = objvMicroTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvMicroTeachCaseRelaInfoENT.ftpFileSize = objvMicroTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvMicroTeachCaseRelaInfoENT.ftpResourceOwner = objvMicroTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroTeachCaseRelaInfoENT.FileOriginName = objvMicroTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvMicroTeachCaseRelaInfoENT.IdFile = objvMicroTeachCaseRelaInfoENS.IdFile; //文件流水号
objvMicroTeachCaseRelaInfoENT.FileName = objvMicroTeachCaseRelaInfoENS.FileName; //文件名称
objvMicroTeachCaseRelaInfoENT.FileType = objvMicroTeachCaseRelaInfoENS.FileType; //文件类型
objvMicroTeachCaseRelaInfoENT.SaveDate = objvMicroTeachCaseRelaInfoENS.SaveDate; //创建日期
objvMicroTeachCaseRelaInfoENT.FileSize = objvMicroTeachCaseRelaInfoENS.FileSize; //文件大小
objvMicroTeachCaseRelaInfoENT.SaveTime = objvMicroTeachCaseRelaInfoENS.SaveTime; //创建时间
objvMicroTeachCaseRelaInfoENT.IdMicroteachCase = objvMicroTeachCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvMicroTeachCaseRelaInfoENT.MicroteachCaseName = objvMicroTeachCaseRelaInfoENS.MicroteachCaseName; //微格教学案例名称
objvMicroTeachCaseRelaInfoENT.IdFtpResource = objvMicroTeachCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvMicroTeachCaseRelaInfoENT.FtpResourceID = objvMicroTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvMicroTeachCaseRelaInfoENT.FileOriginalName = objvMicroTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvMicroTeachCaseRelaInfoENT.FileDirName = objvMicroTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvMicroTeachCaseRelaInfoENT.FileRename = objvMicroTeachCaseRelaInfoENS.FileRename; //文件新名
objvMicroTeachCaseRelaInfoENT.FileUpDate = objvMicroTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvMicroTeachCaseRelaInfoENT.FileUpTime = objvMicroTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvMicroTeachCaseRelaInfoENT.IdResource = objvMicroTeachCaseRelaInfoENS.IdResource; //资源流水号
objvMicroTeachCaseRelaInfoENT.ResourceID = objvMicroTeachCaseRelaInfoENS.ResourceID; //资源ID
objvMicroTeachCaseRelaInfoENT.SaveMode = objvMicroTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvMicroTeachCaseRelaInfoENT.IdResourceType = objvMicroTeachCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvMicroTeachCaseRelaInfoENT.ResourceTypeID = objvMicroTeachCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvMicroTeachCaseRelaInfoENT.ResourceTypeName = objvMicroTeachCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvMicroTeachCaseRelaInfoENT.Flag = objvMicroTeachCaseRelaInfoENS.Flag; //标志
objvMicroTeachCaseRelaInfoENT.FileNewName = objvMicroTeachCaseRelaInfoENS.FileNewName; //新文件名
objvMicroTeachCaseRelaInfoENT.FileOldName = objvMicroTeachCaseRelaInfoENS.FileOldName; //旧文件名
objvMicroTeachCaseRelaInfoENT.IsExistFile = objvMicroTeachCaseRelaInfoENS.IsExistFile; //是否存在文件
objvMicroTeachCaseRelaInfoENT.ResourceName = objvMicroTeachCaseRelaInfoENS.ResourceName; //资源名称
objvMicroTeachCaseRelaInfoENT.IsVisible = objvMicroTeachCaseRelaInfoENS.IsVisible; //是否显示
objvMicroTeachCaseRelaInfoENT.UpdDate = objvMicroTeachCaseRelaInfoENS.UpdDate; //修改日期
objvMicroTeachCaseRelaInfoENT.UpdUser = objvMicroTeachCaseRelaInfoENS.UpdUser; //修改人
objvMicroTeachCaseRelaInfoENT.Memo = objvMicroTeachCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objvMicroTeachCaseRelaInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN)
{
try
{
objvMicroTeachCaseRelaInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroTeachCaseRelaInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objvMicroTeachCaseRelaInfoEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objvMicroTeachCaseRelaInfoEN.FuncModuleName == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.BrowseCount = objvMicroTeachCaseRelaInfoEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objvMicroTeachCaseRelaInfoEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.ftpFileType = objvMicroTeachCaseRelaInfoEN.ftpFileType == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objvMicroTeachCaseRelaInfoEN.ftpFileSize == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objvMicroTeachCaseRelaInfoEN.ftpResourceOwner == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FileOriginName = objvMicroTeachCaseRelaInfoEN.FileOriginName == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.IdFile = objvMicroTeachCaseRelaInfoEN.IdFile == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FileName = objvMicroTeachCaseRelaInfoEN.FileName == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FileName; //文件名称
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FileType = objvMicroTeachCaseRelaInfoEN.FileType == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FileType; //文件类型
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.SaveDate = objvMicroTeachCaseRelaInfoEN.SaveDate == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FileSize = objvMicroTeachCaseRelaInfoEN.FileSize == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.SaveTime = objvMicroTeachCaseRelaInfoEN.SaveTime == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objvMicroTeachCaseRelaInfoEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objvMicroTeachCaseRelaInfoEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objvMicroTeachCaseRelaInfoEN.IdFtpResource == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objvMicroTeachCaseRelaInfoEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objvMicroTeachCaseRelaInfoEN.FileOriginalName == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FileDirName = objvMicroTeachCaseRelaInfoEN.FileDirName == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FileRename = objvMicroTeachCaseRelaInfoEN.FileRename == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FileUpDate = objvMicroTeachCaseRelaInfoEN.FileUpDate == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FileUpTime = objvMicroTeachCaseRelaInfoEN.FileUpTime == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.IdResource = objvMicroTeachCaseRelaInfoEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.ResourceID = objvMicroTeachCaseRelaInfoEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.SaveMode = objvMicroTeachCaseRelaInfoEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.IdResourceType = objvMicroTeachCaseRelaInfoEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objvMicroTeachCaseRelaInfoEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objvMicroTeachCaseRelaInfoEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.Flag, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.Flag = objvMicroTeachCaseRelaInfoEN.Flag == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.Flag; //标志
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FileNewName = objvMicroTeachCaseRelaInfoEN.FileNewName == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.FileOldName = objvMicroTeachCaseRelaInfoEN.FileOldName == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.IsExistFile = objvMicroTeachCaseRelaInfoEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.ResourceName = objvMicroTeachCaseRelaInfoEN.ResourceName == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.IsVisible = objvMicroTeachCaseRelaInfoEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.UpdDate = objvMicroTeachCaseRelaInfoEN.UpdDate == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.UpdUser = objvMicroTeachCaseRelaInfoEN.UpdUser == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convMicroTeachCaseRelaInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroTeachCaseRelaInfoEN.Memo = objvMicroTeachCaseRelaInfoEN.Memo == "[null]" ? null :  objvMicroTeachCaseRelaInfoEN.Memo; //备注
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
 /// <param name = "objvMicroTeachCaseRelaInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN)
{
try
{
if (objvMicroTeachCaseRelaInfoEN.FuncModuleName == "[null]") objvMicroTeachCaseRelaInfoEN.FuncModuleName = null; //功能模块名称
if (objvMicroTeachCaseRelaInfoEN.ftpFileType == "[null]") objvMicroTeachCaseRelaInfoEN.ftpFileType = null; //ftp文件类型
if (objvMicroTeachCaseRelaInfoEN.ftpFileSize == "[null]") objvMicroTeachCaseRelaInfoEN.ftpFileSize = null; //ftp文件大小
if (objvMicroTeachCaseRelaInfoEN.ftpResourceOwner == "[null]") objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvMicroTeachCaseRelaInfoEN.FileOriginName == "[null]") objvMicroTeachCaseRelaInfoEN.FileOriginName = null; //原文件名
if (objvMicroTeachCaseRelaInfoEN.IdFile == "[null]") objvMicroTeachCaseRelaInfoEN.IdFile = null; //文件流水号
if (objvMicroTeachCaseRelaInfoEN.FileName == "[null]") objvMicroTeachCaseRelaInfoEN.FileName = null; //文件名称
if (objvMicroTeachCaseRelaInfoEN.FileType == "[null]") objvMicroTeachCaseRelaInfoEN.FileType = null; //文件类型
if (objvMicroTeachCaseRelaInfoEN.SaveDate == "[null]") objvMicroTeachCaseRelaInfoEN.SaveDate = null; //创建日期
if (objvMicroTeachCaseRelaInfoEN.FileSize == "[null]") objvMicroTeachCaseRelaInfoEN.FileSize = null; //文件大小
if (objvMicroTeachCaseRelaInfoEN.SaveTime == "[null]") objvMicroTeachCaseRelaInfoEN.SaveTime = null; //创建时间
if (objvMicroTeachCaseRelaInfoEN.IdFtpResource == "[null]") objvMicroTeachCaseRelaInfoEN.IdFtpResource = null; //FTP资源流水号
if (objvMicroTeachCaseRelaInfoEN.FileOriginalName == "[null]") objvMicroTeachCaseRelaInfoEN.FileOriginalName = null; //文件原名
if (objvMicroTeachCaseRelaInfoEN.FileDirName == "[null]") objvMicroTeachCaseRelaInfoEN.FileDirName = null; //文件目录名
if (objvMicroTeachCaseRelaInfoEN.FileRename == "[null]") objvMicroTeachCaseRelaInfoEN.FileRename = null; //文件新名
if (objvMicroTeachCaseRelaInfoEN.FileUpDate == "[null]") objvMicroTeachCaseRelaInfoEN.FileUpDate = null; //创建日期
if (objvMicroTeachCaseRelaInfoEN.FileUpTime == "[null]") objvMicroTeachCaseRelaInfoEN.FileUpTime = null; //创建时间
if (objvMicroTeachCaseRelaInfoEN.Flag == "[null]") objvMicroTeachCaseRelaInfoEN.Flag = null; //标志
if (objvMicroTeachCaseRelaInfoEN.FileNewName == "[null]") objvMicroTeachCaseRelaInfoEN.FileNewName = null; //新文件名
if (objvMicroTeachCaseRelaInfoEN.FileOldName == "[null]") objvMicroTeachCaseRelaInfoEN.FileOldName = null; //旧文件名
if (objvMicroTeachCaseRelaInfoEN.ResourceName == "[null]") objvMicroTeachCaseRelaInfoEN.ResourceName = null; //资源名称
if (objvMicroTeachCaseRelaInfoEN.UpdDate == "[null]") objvMicroTeachCaseRelaInfoEN.UpdDate = null; //修改日期
if (objvMicroTeachCaseRelaInfoEN.UpdUser == "[null]") objvMicroTeachCaseRelaInfoEN.UpdUser = null; //修改人
if (objvMicroTeachCaseRelaInfoEN.Memo == "[null]") objvMicroTeachCaseRelaInfoEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN)
{
 vMicroTeachCaseRelaInfoDA.CheckProperty4Condition(objvMicroTeachCaseRelaInfoEN);
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
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseBL没有刷新缓存机制(clsMicroteachCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseTypeBL没有刷新缓存机制(clsMicroteachCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindBL没有刷新缓存机制(clsUserKindBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroTeachCaseRelaInfo");
//if (arrvMicroTeachCaseRelaInfoObjLstCache == null)
//{
//arrvMicroTeachCaseRelaInfoObjLstCache = vMicroTeachCaseRelaInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroTeachCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfoCache(long lngIdMicroTeachCaseRelaInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroTeachCaseRelaInfoEN._CurrTabName);
List<clsvMicroTeachCaseRelaInfoEN> arrvMicroTeachCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroTeachCaseRelaInfoEN> arrvMicroTeachCaseRelaInfoObjLst_Sel =
arrvMicroTeachCaseRelaInfoObjLstCache
.Where(x=> x.IdMicroTeachCaseRelaInfo == lngIdMicroTeachCaseRelaInfo 
);
if (arrvMicroTeachCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvMicroTeachCaseRelaInfoEN obj = clsvMicroTeachCaseRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroTeachCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroTeachCaseRelaInfoEN> GetAllvMicroTeachCaseRelaInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroTeachCaseRelaInfoEN> arrvMicroTeachCaseRelaInfoObjLstCache = GetObjLstCache(); 
return arrvMicroTeachCaseRelaInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroTeachCaseRelaInfoEN._CurrTabName);
List<clsvMicroTeachCaseRelaInfoEN> arrvMicroTeachCaseRelaInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroTeachCaseRelaInfoObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroTeachCaseRelaInfoEN._CurrTabName);
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
if (strInFldName != convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroTeachCaseRelaInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroTeachCaseRelaInfo.AttributeName));
throw new Exception(strMsg);
}
var objvMicroTeachCaseRelaInfo = clsvMicroTeachCaseRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfoCache(lngIdMicroTeachCaseRelaInfo);
if (objvMicroTeachCaseRelaInfo == null) return "";
return objvMicroTeachCaseRelaInfo[strOutFldName].ToString();
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
int intRecCount = clsvMicroTeachCaseRelaInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroTeachCaseRelaInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroTeachCaseRelaInfoDA.GetRecCount();
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
int intRecCount = clsvMicroTeachCaseRelaInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoCond)
{
List<clsvMicroTeachCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroTeachCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroTeachCaseRelaInfo.AttributeName)
{
if (objvMicroTeachCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroTeachCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroTeachCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroTeachCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroTeachCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroTeachCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroTeachCaseRelaInfoCond[strFldName]));
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
 List<string> arrList = clsvMicroTeachCaseRelaInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroTeachCaseRelaInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroTeachCaseRelaInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}