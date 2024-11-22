
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvResourceBL
 表名:vResource(01120321)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
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
public static class  clsvResourceBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsvResourceEN GetObj(this K_IdResource_vResource myKey)
{
clsvResourceEN objvResourceEN = clsvResourceBL.vResourceDA.GetObjByIdResource(myKey.Value);
return objvResourceEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetIdResource(this clsvResourceEN objvResourceEN, string strIdResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convResource.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convResource.IdResource);
}
objvResourceEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.IdResource) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.IdResource, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.IdResource] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetResourceID(this clsvResourceEN objvResourceEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convResource.ResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convResource.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convResource.ResourceID);
}
objvResourceEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.ResourceID) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.ResourceID, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.ResourceID] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetResourceName(this clsvResourceEN objvResourceEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceName, convResource.ResourceName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convResource.ResourceName);
}
objvResourceEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.ResourceName) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.ResourceName, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.ResourceName] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetSaveMode(this clsvResourceEN objvResourceEN, bool bolSaveMode, string strComparisonOp="")
	{
objvResourceEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.SaveMode) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.SaveMode, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.SaveMode] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetIdFtpResource(this clsvResourceEN objvResourceEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convResource.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convResource.IdFtpResource);
}
objvResourceEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.IdFtpResource) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.IdFtpResource, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.IdFtpResource] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFtpResourceID(this clsvResourceEN objvResourceEN, string strFtpResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convResource.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convResource.FtpResourceID);
}
objvResourceEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FtpResourceID) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FtpResourceID, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FtpResourceID] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFileOriginalName(this clsvResourceEN objvResourceEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convResource.FileOriginalName);
}
objvResourceEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FileOriginalName) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FileOriginalName, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FileOriginalName] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFileDirName(this clsvResourceEN objvResourceEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convResource.FileDirName);
}
objvResourceEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FileDirName) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FileDirName, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FileDirName] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFileRename(this clsvResourceEN objvResourceEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convResource.FileRename);
}
objvResourceEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FileRename) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FileRename, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FileRename] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFileUpDate(this clsvResourceEN objvResourceEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convResource.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convResource.FileUpDate);
}
objvResourceEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FileUpDate) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FileUpDate, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FileUpDate] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFileUpTime(this clsvResourceEN objvResourceEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convResource.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convResource.FileUpTime);
}
objvResourceEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FileUpTime) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FileUpTime, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FileUpTime] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFileSize(this clsvResourceEN objvResourceEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convResource.FileSize);
}
objvResourceEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FileSize) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FileSize, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FileSize] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFileType(this clsvResourceEN objvResourceEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convResource.FileType);
}
objvResourceEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FileType) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FileType, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FileType] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetResourceOwner(this clsvResourceEN objvResourceEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convResource.ResourceOwner);
}
objvResourceEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.ResourceOwner) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.ResourceOwner, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.ResourceOwner] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetIsExistFile(this clsvResourceEN objvResourceEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvResourceEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.IsExistFile) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.IsExistFile, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.IsExistFile] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetIdFile(this clsvResourceEN objvResourceEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convResource.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convResource.IdFile);
}
objvResourceEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.IdFile) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.IdFile, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.IdFile] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFileName(this clsvResourceEN objvResourceEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convResource.FileName);
}
objvResourceEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FileName) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FileName, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FileName] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetSaveDate(this clsvResourceEN objvResourceEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convResource.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convResource.SaveDate);
}
objvResourceEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.SaveDate) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.SaveDate, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.SaveDate] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetSaveTime(this clsvResourceEN objvResourceEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convResource.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convResource.SaveTime);
}
objvResourceEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.SaveTime) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.SaveTime, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.SaveTime] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFileOriginName(this clsvResourceEN objvResourceEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convResource.FileOriginName);
}
objvResourceEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FileOriginName) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FileOriginName, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FileOriginName] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetIdResourceType(this clsvResourceEN objvResourceEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, convResource.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convResource.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convResource.IdResourceType);
}
objvResourceEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.IdResourceType) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.IdResourceType, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.IdResourceType] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetResourceTypeID(this clsvResourceEN objvResourceEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convResource.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convResource.ResourceTypeID);
}
objvResourceEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.ResourceTypeID) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.ResourceTypeID, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.ResourceTypeID] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetResourceTypeName(this clsvResourceEN objvResourceEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convResource.ResourceTypeName);
}
objvResourceEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.ResourceTypeName) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.ResourceTypeName, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.ResourceTypeName] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetMemo(this clsvResourceEN objvResourceEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convResource.Memo);
}
objvResourceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.Memo) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.Memo, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.Memo] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFuncModuleId(this clsvResourceEN objvResourceEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convResource.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convResource.FuncModuleId);
}
objvResourceEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FuncModuleId) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FuncModuleId, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FuncModuleId] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFuncModuleNameSim(this clsvResourceEN objvResourceEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convResource.FuncModuleNameSim);
}
objvResourceEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FuncModuleNameSim) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FuncModuleNameSim, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FuncModuleNameSim] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetOrderNum(this clsvResourceEN objvResourceEN, int? intOrderNum, string strComparisonOp="")
	{
objvResourceEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.OrderNum) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.OrderNum, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.OrderNum] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetCheckDate(this clsvResourceEN objvResourceEN, string strCheckDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDate, 20, convResource.CheckDate);
}
objvResourceEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.CheckDate) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.CheckDate, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.CheckDate] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetCheckUser(this clsvResourceEN objvResourceEN, string strCheckUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckUser, 18, convResource.CheckUser);
}
objvResourceEN.CheckUser = strCheckUser; //检查用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.CheckUser) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.CheckUser, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.CheckUser] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetCheckResult(this clsvResourceEN objvResourceEN, string strCheckResult, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckResult, 1000, convResource.CheckResult);
}
objvResourceEN.CheckResult = strCheckResult; //检查结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.CheckResult) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.CheckResult, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.CheckResult] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFileNewName(this clsvResourceEN objvResourceEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convResource.FileNewName);
}
objvResourceEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FileNewName) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FileNewName, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FileNewName] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetFileOldName(this clsvResourceEN objvResourceEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convResource.FileOldName);
}
objvResourceEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FileOldName) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FileOldName, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FileOldName] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetftpFileType(this clsvResourceEN objvResourceEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convResource.ftpFileType);
}
objvResourceEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.ftpFileType) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.ftpFileType, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.ftpFileType] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetftpFileSize(this clsvResourceEN objvResourceEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convResource.ftpFileSize);
}
objvResourceEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.ftpFileSize) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.ftpFileSize, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.ftpFileSize] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResourceEN SetftpResourceOwner(this clsvResourceEN objvResourceEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convResource.ftpResourceOwner);
}
objvResourceEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.ftpResourceOwner) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.ftpResourceOwner, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.ftpResourceOwner] = strComparisonOp;
}
}
return objvResourceEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvResourceENS">源对象</param>
 /// <param name = "objvResourceENT">目标对象</param>
 public static void CopyTo(this clsvResourceEN objvResourceENS, clsvResourceEN objvResourceENT)
{
try
{
objvResourceENT.IdResource = objvResourceENS.IdResource; //资源流水号
objvResourceENT.ResourceID = objvResourceENS.ResourceID; //资源ID
objvResourceENT.ResourceName = objvResourceENS.ResourceName; //资源名称
objvResourceENT.SaveMode = objvResourceENS.SaveMode; //文件存放方式
objvResourceENT.IdFtpResource = objvResourceENS.IdFtpResource; //FTP资源流水号
objvResourceENT.FtpResourceID = objvResourceENS.FtpResourceID; //FTP资源ID
objvResourceENT.FileOriginalName = objvResourceENS.FileOriginalName; //文件原名
objvResourceENT.FileDirName = objvResourceENS.FileDirName; //文件目录名
objvResourceENT.FileRename = objvResourceENS.FileRename; //文件新名
objvResourceENT.FileUpDate = objvResourceENS.FileUpDate; //创建日期
objvResourceENT.FileUpTime = objvResourceENS.FileUpTime; //创建时间
objvResourceENT.FileSize = objvResourceENS.FileSize; //文件大小
objvResourceENT.FileType = objvResourceENS.FileType; //文件类型
objvResourceENT.ResourceOwner = objvResourceENS.ResourceOwner; //上传者
objvResourceENT.IsExistFile = objvResourceENS.IsExistFile; //是否存在文件
objvResourceENT.IdFile = objvResourceENS.IdFile; //文件流水号
objvResourceENT.FileName = objvResourceENS.FileName; //文件名称
objvResourceENT.SaveDate = objvResourceENS.SaveDate; //创建日期
objvResourceENT.SaveTime = objvResourceENS.SaveTime; //创建时间
objvResourceENT.FileOriginName = objvResourceENS.FileOriginName; //原文件名
objvResourceENT.IdResourceType = objvResourceENS.IdResourceType; //资源类型流水号
objvResourceENT.ResourceTypeID = objvResourceENS.ResourceTypeID; //资源类型ID
objvResourceENT.ResourceTypeName = objvResourceENS.ResourceTypeName; //资源类型名称
objvResourceENT.Memo = objvResourceENS.Memo; //备注
objvResourceENT.FuncModuleId = objvResourceENS.FuncModuleId; //功能模块Id
objvResourceENT.FuncModuleNameSim = objvResourceENS.FuncModuleNameSim; //功能模块简称
objvResourceENT.OrderNum = objvResourceENS.OrderNum; //序号
objvResourceENT.CheckDate = objvResourceENS.CheckDate; //检查日期
objvResourceENT.CheckUser = objvResourceENS.CheckUser; //检查用户Id
objvResourceENT.CheckResult = objvResourceENS.CheckResult; //检查结果
objvResourceENT.FileNewName = objvResourceENS.FileNewName; //新文件名
objvResourceENT.FileOldName = objvResourceENS.FileOldName; //旧文件名
objvResourceENT.ftpFileType = objvResourceENS.ftpFileType; //ftp文件类型
objvResourceENT.ftpFileSize = objvResourceENS.ftpFileSize; //ftp文件大小
objvResourceENT.ftpResourceOwner = objvResourceENS.ftpResourceOwner; //Ftp资源拥有者
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
 /// <param name = "objvResourceENS">源对象</param>
 /// <returns>目标对象=>clsvResourceEN:objvResourceENT</returns>
 public static clsvResourceEN CopyTo(this clsvResourceEN objvResourceENS)
{
try
{
 clsvResourceEN objvResourceENT = new clsvResourceEN()
{
IdResource = objvResourceENS.IdResource, //资源流水号
ResourceID = objvResourceENS.ResourceID, //资源ID
ResourceName = objvResourceENS.ResourceName, //资源名称
SaveMode = objvResourceENS.SaveMode, //文件存放方式
IdFtpResource = objvResourceENS.IdFtpResource, //FTP资源流水号
FtpResourceID = objvResourceENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvResourceENS.FileOriginalName, //文件原名
FileDirName = objvResourceENS.FileDirName, //文件目录名
FileRename = objvResourceENS.FileRename, //文件新名
FileUpDate = objvResourceENS.FileUpDate, //创建日期
FileUpTime = objvResourceENS.FileUpTime, //创建时间
FileSize = objvResourceENS.FileSize, //文件大小
FileType = objvResourceENS.FileType, //文件类型
ResourceOwner = objvResourceENS.ResourceOwner, //上传者
IsExistFile = objvResourceENS.IsExistFile, //是否存在文件
IdFile = objvResourceENS.IdFile, //文件流水号
FileName = objvResourceENS.FileName, //文件名称
SaveDate = objvResourceENS.SaveDate, //创建日期
SaveTime = objvResourceENS.SaveTime, //创建时间
FileOriginName = objvResourceENS.FileOriginName, //原文件名
IdResourceType = objvResourceENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvResourceENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvResourceENS.ResourceTypeName, //资源类型名称
Memo = objvResourceENS.Memo, //备注
FuncModuleId = objvResourceENS.FuncModuleId, //功能模块Id
FuncModuleNameSim = objvResourceENS.FuncModuleNameSim, //功能模块简称
OrderNum = objvResourceENS.OrderNum, //序号
CheckDate = objvResourceENS.CheckDate, //检查日期
CheckUser = objvResourceENS.CheckUser, //检查用户Id
CheckResult = objvResourceENS.CheckResult, //检查结果
FileNewName = objvResourceENS.FileNewName, //新文件名
FileOldName = objvResourceENS.FileOldName, //旧文件名
ftpFileType = objvResourceENS.ftpFileType, //ftp文件类型
ftpFileSize = objvResourceENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvResourceENS.ftpResourceOwner, //Ftp资源拥有者
};
 return objvResourceENT;
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
public static void CheckProperty4Condition(this clsvResourceEN objvResourceEN)
{
 clsvResourceBL.vResourceDA.CheckProperty4Condition(objvResourceEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvResourceEN objvResourceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvResourceCond.IsUpdated(convResource.IdResource) == true)
{
string strComparisonOpIdResource = objvResourceCond.dicFldComparisonOp[convResource.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.IdResource, objvResourceCond.IdResource, strComparisonOpIdResource);
}
if (objvResourceCond.IsUpdated(convResource.ResourceID) == true)
{
string strComparisonOpResourceID = objvResourceCond.dicFldComparisonOp[convResource.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ResourceID, objvResourceCond.ResourceID, strComparisonOpResourceID);
}
if (objvResourceCond.IsUpdated(convResource.ResourceName) == true)
{
string strComparisonOpResourceName = objvResourceCond.dicFldComparisonOp[convResource.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ResourceName, objvResourceCond.ResourceName, strComparisonOpResourceName);
}
if (objvResourceCond.IsUpdated(convResource.SaveMode) == true)
{
if (objvResourceCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convResource.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convResource.SaveMode);
}
}
if (objvResourceCond.IsUpdated(convResource.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvResourceCond.dicFldComparisonOp[convResource.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.IdFtpResource, objvResourceCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvResourceCond.IsUpdated(convResource.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvResourceCond.dicFldComparisonOp[convResource.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FtpResourceID, objvResourceCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvResourceCond.IsUpdated(convResource.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvResourceCond.dicFldComparisonOp[convResource.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileOriginalName, objvResourceCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvResourceCond.IsUpdated(convResource.FileDirName) == true)
{
string strComparisonOpFileDirName = objvResourceCond.dicFldComparisonOp[convResource.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileDirName, objvResourceCond.FileDirName, strComparisonOpFileDirName);
}
if (objvResourceCond.IsUpdated(convResource.FileRename) == true)
{
string strComparisonOpFileRename = objvResourceCond.dicFldComparisonOp[convResource.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileRename, objvResourceCond.FileRename, strComparisonOpFileRename);
}
if (objvResourceCond.IsUpdated(convResource.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvResourceCond.dicFldComparisonOp[convResource.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileUpDate, objvResourceCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvResourceCond.IsUpdated(convResource.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvResourceCond.dicFldComparisonOp[convResource.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileUpTime, objvResourceCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvResourceCond.IsUpdated(convResource.FileSize) == true)
{
string strComparisonOpFileSize = objvResourceCond.dicFldComparisonOp[convResource.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileSize, objvResourceCond.FileSize, strComparisonOpFileSize);
}
if (objvResourceCond.IsUpdated(convResource.FileType) == true)
{
string strComparisonOpFileType = objvResourceCond.dicFldComparisonOp[convResource.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileType, objvResourceCond.FileType, strComparisonOpFileType);
}
if (objvResourceCond.IsUpdated(convResource.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvResourceCond.dicFldComparisonOp[convResource.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ResourceOwner, objvResourceCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvResourceCond.IsUpdated(convResource.IsExistFile) == true)
{
if (objvResourceCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convResource.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convResource.IsExistFile);
}
}
if (objvResourceCond.IsUpdated(convResource.IdFile) == true)
{
string strComparisonOpIdFile = objvResourceCond.dicFldComparisonOp[convResource.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.IdFile, objvResourceCond.IdFile, strComparisonOpIdFile);
}
if (objvResourceCond.IsUpdated(convResource.FileName) == true)
{
string strComparisonOpFileName = objvResourceCond.dicFldComparisonOp[convResource.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileName, objvResourceCond.FileName, strComparisonOpFileName);
}
if (objvResourceCond.IsUpdated(convResource.SaveDate) == true)
{
string strComparisonOpSaveDate = objvResourceCond.dicFldComparisonOp[convResource.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.SaveDate, objvResourceCond.SaveDate, strComparisonOpSaveDate);
}
if (objvResourceCond.IsUpdated(convResource.SaveTime) == true)
{
string strComparisonOpSaveTime = objvResourceCond.dicFldComparisonOp[convResource.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.SaveTime, objvResourceCond.SaveTime, strComparisonOpSaveTime);
}
if (objvResourceCond.IsUpdated(convResource.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvResourceCond.dicFldComparisonOp[convResource.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileOriginName, objvResourceCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvResourceCond.IsUpdated(convResource.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvResourceCond.dicFldComparisonOp[convResource.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.IdResourceType, objvResourceCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvResourceCond.IsUpdated(convResource.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvResourceCond.dicFldComparisonOp[convResource.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ResourceTypeID, objvResourceCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvResourceCond.IsUpdated(convResource.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvResourceCond.dicFldComparisonOp[convResource.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ResourceTypeName, objvResourceCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvResourceCond.IsUpdated(convResource.Memo) == true)
{
string strComparisonOpMemo = objvResourceCond.dicFldComparisonOp[convResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.Memo, objvResourceCond.Memo, strComparisonOpMemo);
}
if (objvResourceCond.IsUpdated(convResource.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvResourceCond.dicFldComparisonOp[convResource.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FuncModuleId, objvResourceCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvResourceCond.IsUpdated(convResource.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvResourceCond.dicFldComparisonOp[convResource.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FuncModuleNameSim, objvResourceCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvResourceCond.IsUpdated(convResource.OrderNum) == true)
{
string strComparisonOpOrderNum = objvResourceCond.dicFldComparisonOp[convResource.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convResource.OrderNum, objvResourceCond.OrderNum, strComparisonOpOrderNum);
}
if (objvResourceCond.IsUpdated(convResource.CheckDate) == true)
{
string strComparisonOpCheckDate = objvResourceCond.dicFldComparisonOp[convResource.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.CheckDate, objvResourceCond.CheckDate, strComparisonOpCheckDate);
}
if (objvResourceCond.IsUpdated(convResource.CheckUser) == true)
{
string strComparisonOpCheckUser = objvResourceCond.dicFldComparisonOp[convResource.CheckUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.CheckUser, objvResourceCond.CheckUser, strComparisonOpCheckUser);
}
if (objvResourceCond.IsUpdated(convResource.CheckResult) == true)
{
string strComparisonOpCheckResult = objvResourceCond.dicFldComparisonOp[convResource.CheckResult];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.CheckResult, objvResourceCond.CheckResult, strComparisonOpCheckResult);
}
if (objvResourceCond.IsUpdated(convResource.FileNewName) == true)
{
string strComparisonOpFileNewName = objvResourceCond.dicFldComparisonOp[convResource.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileNewName, objvResourceCond.FileNewName, strComparisonOpFileNewName);
}
if (objvResourceCond.IsUpdated(convResource.FileOldName) == true)
{
string strComparisonOpFileOldName = objvResourceCond.dicFldComparisonOp[convResource.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileOldName, objvResourceCond.FileOldName, strComparisonOpFileOldName);
}
if (objvResourceCond.IsUpdated(convResource.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvResourceCond.dicFldComparisonOp[convResource.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ftpFileType, objvResourceCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvResourceCond.IsUpdated(convResource.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvResourceCond.dicFldComparisonOp[convResource.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ftpFileSize, objvResourceCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvResourceCond.IsUpdated(convResource.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvResourceCond.dicFldComparisonOp[convResource.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ftpResourceOwner, objvResourceCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vResource
{
public virtual bool UpdRelaTabDate(string strIdResource, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v资源(vResource)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvResourceBL
{
public static RelatedActions_vResource relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvResourceDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvResourceDA vResourceDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvResourceDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvResourceBL()
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
if (string.IsNullOrEmpty(clsvResourceEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvResourceEN._ConnectString);
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
public static DataTable GetDataTable_vResource(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vResourceDA.GetDataTable_vResource(strWhereCond);
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
objDT = vResourceDA.GetDataTable(strWhereCond);
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
objDT = vResourceDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vResourceDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vResourceDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vResourceDA.GetDataTable_Top(objTopPara);
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
objDT = vResourceDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdResourceLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvResourceEN> GetObjLstByIdResourceLst(List<string> arrIdResourceLst)
{
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdResourceLst, true);
 string strWhereCond = string.Format("IdResource in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdResourceLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvResourceEN> GetObjLstByIdResourceLstCache(List<string> arrIdResourceLst)
{
string strKey = string.Format("{0}", clsvResourceEN._CurrTabName);
List<clsvResourceEN> arrvResourceObjLstCache = GetObjLstCache();
IEnumerable <clsvResourceEN> arrvResourceObjLst_Sel =
arrvResourceObjLstCache
.Where(x => arrIdResourceLst.Contains(x.IdResource));
return arrvResourceObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvResourceEN> GetObjLst(string strWhereCond)
{
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResourceEN);
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
public static List<clsvResourceEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvResourceEN> GetSubObjLstCache(clsvResourceEN objvResourceCond)
{
List<clsvResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convResource.AttributeName)
{
if (objvResourceCond.IsUpdated(strFldName) == false) continue;
if (objvResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvResourceCond[strFldName].ToString());
}
else
{
if (objvResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvResourceCond[strFldName]));
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
public static List<clsvResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResourceEN);
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
public static List<clsvResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResourceEN);
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
List<clsvResourceEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvResourceEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvResourceEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
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
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResourceEN);
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
public static List<clsvResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResourceEN);
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
public static List<clsvResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvResourceEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvResourceEN> arrObjLst = new List<clsvResourceEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResourceEN objvResourceEN = new clsvResourceEN();
try
{
objvResourceEN.IdResource = objRow[convResource.IdResource].ToString().Trim(); //资源流水号
objvResourceEN.ResourceID = objRow[convResource.ResourceID].ToString().Trim(); //资源ID
objvResourceEN.ResourceName = objRow[convResource.ResourceName].ToString().Trim(); //资源名称
objvResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convResource.SaveMode].ToString().Trim()); //文件存放方式
objvResourceEN.IdFtpResource = objRow[convResource.IdFtpResource] == DBNull.Value ? null : objRow[convResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvResourceEN.FtpResourceID = objRow[convResource.FtpResourceID] == DBNull.Value ? null : objRow[convResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvResourceEN.FileOriginalName = objRow[convResource.FileOriginalName] == DBNull.Value ? null : objRow[convResource.FileOriginalName].ToString().Trim(); //文件原名
objvResourceEN.FileDirName = objRow[convResource.FileDirName] == DBNull.Value ? null : objRow[convResource.FileDirName].ToString().Trim(); //文件目录名
objvResourceEN.FileRename = objRow[convResource.FileRename] == DBNull.Value ? null : objRow[convResource.FileRename].ToString().Trim(); //文件新名
objvResourceEN.FileUpDate = objRow[convResource.FileUpDate] == DBNull.Value ? null : objRow[convResource.FileUpDate].ToString().Trim(); //创建日期
objvResourceEN.FileUpTime = objRow[convResource.FileUpTime] == DBNull.Value ? null : objRow[convResource.FileUpTime].ToString().Trim(); //创建时间
objvResourceEN.FileSize = objRow[convResource.FileSize] == DBNull.Value ? null : objRow[convResource.FileSize].ToString().Trim(); //文件大小
objvResourceEN.FileType = objRow[convResource.FileType] == DBNull.Value ? null : objRow[convResource.FileType].ToString().Trim(); //文件类型
objvResourceEN.ResourceOwner = objRow[convResource.ResourceOwner] == DBNull.Value ? null : objRow[convResource.ResourceOwner].ToString().Trim(); //上传者
objvResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convResource.IsExistFile].ToString().Trim()); //是否存在文件
objvResourceEN.IdFile = objRow[convResource.IdFile] == DBNull.Value ? null : objRow[convResource.IdFile].ToString().Trim(); //文件流水号
objvResourceEN.FileName = objRow[convResource.FileName] == DBNull.Value ? null : objRow[convResource.FileName].ToString().Trim(); //文件名称
objvResourceEN.SaveDate = objRow[convResource.SaveDate] == DBNull.Value ? null : objRow[convResource.SaveDate].ToString().Trim(); //创建日期
objvResourceEN.SaveTime = objRow[convResource.SaveTime] == DBNull.Value ? null : objRow[convResource.SaveTime].ToString().Trim(); //创建时间
objvResourceEN.FileOriginName = objRow[convResource.FileOriginName] == DBNull.Value ? null : objRow[convResource.FileOriginName].ToString().Trim(); //原文件名
objvResourceEN.IdResourceType = objRow[convResource.IdResourceType].ToString().Trim(); //资源类型流水号
objvResourceEN.ResourceTypeID = objRow[convResource.ResourceTypeID] == DBNull.Value ? null : objRow[convResource.ResourceTypeID].ToString().Trim(); //资源类型ID
objvResourceEN.ResourceTypeName = objRow[convResource.ResourceTypeName] == DBNull.Value ? null : objRow[convResource.ResourceTypeName].ToString().Trim(); //资源类型名称
objvResourceEN.Memo = objRow[convResource.Memo] == DBNull.Value ? null : objRow[convResource.Memo].ToString().Trim(); //备注
objvResourceEN.FuncModuleId = objRow[convResource.FuncModuleId] == DBNull.Value ? null : objRow[convResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvResourceEN.FuncModuleNameSim = objRow[convResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvResourceEN.OrderNum = objRow[convResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResource.OrderNum].ToString().Trim()); //序号
objvResourceEN.CheckDate = objRow[convResource.CheckDate] == DBNull.Value ? null : objRow[convResource.CheckDate].ToString().Trim(); //检查日期
objvResourceEN.CheckUser = objRow[convResource.CheckUser] == DBNull.Value ? null : objRow[convResource.CheckUser].ToString().Trim(); //检查用户Id
objvResourceEN.CheckResult = objRow[convResource.CheckResult] == DBNull.Value ? null : objRow[convResource.CheckResult].ToString().Trim(); //检查结果
objvResourceEN.FileNewName = objRow[convResource.FileNewName] == DBNull.Value ? null : objRow[convResource.FileNewName].ToString().Trim(); //新文件名
objvResourceEN.FileOldName = objRow[convResource.FileOldName] == DBNull.Value ? null : objRow[convResource.FileOldName].ToString().Trim(); //旧文件名
objvResourceEN.ftpFileType = objRow[convResource.ftpFileType] == DBNull.Value ? null : objRow[convResource.ftpFileType].ToString().Trim(); //ftp文件类型
objvResourceEN.ftpFileSize = objRow[convResource.ftpFileSize] == DBNull.Value ? null : objRow[convResource.ftpFileSize].ToString().Trim(); //ftp文件大小
objvResourceEN.ftpResourceOwner = objRow[convResource.ftpResourceOwner] == DBNull.Value ? null : objRow[convResource.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResourceEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvResourceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvResource(ref clsvResourceEN objvResourceEN)
{
bool bolResult = vResourceDA.GetvResource(ref objvResourceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsvResourceEN GetObjByIdResource(string strIdResource)
{
if (strIdResource.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdResource]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdResource) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdResource]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvResourceEN objvResourceEN = vResourceDA.GetObjByIdResource(strIdResource);
return objvResourceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvResourceEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvResourceEN objvResourceEN = vResourceDA.GetFirstObj(strWhereCond);
 return objvResourceEN;
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
public static clsvResourceEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvResourceEN objvResourceEN = vResourceDA.GetObjByDataRow(objRow);
 return objvResourceEN;
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
public static clsvResourceEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvResourceEN objvResourceEN = vResourceDA.GetObjByDataRow(objRow);
 return objvResourceEN;
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
 /// <param name = "strIdResource">所给的关键字</param>
 /// <param name = "lstvResourceObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvResourceEN GetObjByIdResourceFromList(string strIdResource, List<clsvResourceEN> lstvResourceObjLst)
{
foreach (clsvResourceEN objvResourceEN in lstvResourceObjLst)
{
if (objvResourceEN.IdResource == strIdResource)
{
return objvResourceEN;
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
 string strIdResource;
 try
 {
 strIdResource = new clsvResourceDA().GetFirstID(strWhereCond);
 return strIdResource;
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
 arrList = vResourceDA.GetID(strWhereCond);
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
bool bolIsExist = vResourceDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdResource">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdResource)
{
if (string.IsNullOrEmpty(strIdResource) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdResource]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vResourceDA.IsExist(strIdResource);
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
 bolIsExist = clsvResourceDA.IsExistTable();
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
 bolIsExist = vResourceDA.IsExistTable(strTabName);
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
 /// <param name = "objvResourceENS">源对象</param>
 /// <param name = "objvResourceENT">目标对象</param>
 public static void CopyTo(clsvResourceEN objvResourceENS, clsvResourceEN objvResourceENT)
{
try
{
objvResourceENT.IdResource = objvResourceENS.IdResource; //资源流水号
objvResourceENT.ResourceID = objvResourceENS.ResourceID; //资源ID
objvResourceENT.ResourceName = objvResourceENS.ResourceName; //资源名称
objvResourceENT.SaveMode = objvResourceENS.SaveMode; //文件存放方式
objvResourceENT.IdFtpResource = objvResourceENS.IdFtpResource; //FTP资源流水号
objvResourceENT.FtpResourceID = objvResourceENS.FtpResourceID; //FTP资源ID
objvResourceENT.FileOriginalName = objvResourceENS.FileOriginalName; //文件原名
objvResourceENT.FileDirName = objvResourceENS.FileDirName; //文件目录名
objvResourceENT.FileRename = objvResourceENS.FileRename; //文件新名
objvResourceENT.FileUpDate = objvResourceENS.FileUpDate; //创建日期
objvResourceENT.FileUpTime = objvResourceENS.FileUpTime; //创建时间
objvResourceENT.FileSize = objvResourceENS.FileSize; //文件大小
objvResourceENT.FileType = objvResourceENS.FileType; //文件类型
objvResourceENT.ResourceOwner = objvResourceENS.ResourceOwner; //上传者
objvResourceENT.IsExistFile = objvResourceENS.IsExistFile; //是否存在文件
objvResourceENT.IdFile = objvResourceENS.IdFile; //文件流水号
objvResourceENT.FileName = objvResourceENS.FileName; //文件名称
objvResourceENT.SaveDate = objvResourceENS.SaveDate; //创建日期
objvResourceENT.SaveTime = objvResourceENS.SaveTime; //创建时间
objvResourceENT.FileOriginName = objvResourceENS.FileOriginName; //原文件名
objvResourceENT.IdResourceType = objvResourceENS.IdResourceType; //资源类型流水号
objvResourceENT.ResourceTypeID = objvResourceENS.ResourceTypeID; //资源类型ID
objvResourceENT.ResourceTypeName = objvResourceENS.ResourceTypeName; //资源类型名称
objvResourceENT.Memo = objvResourceENS.Memo; //备注
objvResourceENT.FuncModuleId = objvResourceENS.FuncModuleId; //功能模块Id
objvResourceENT.FuncModuleNameSim = objvResourceENS.FuncModuleNameSim; //功能模块简称
objvResourceENT.OrderNum = objvResourceENS.OrderNum; //序号
objvResourceENT.CheckDate = objvResourceENS.CheckDate; //检查日期
objvResourceENT.CheckUser = objvResourceENS.CheckUser; //检查用户Id
objvResourceENT.CheckResult = objvResourceENS.CheckResult; //检查结果
objvResourceENT.FileNewName = objvResourceENS.FileNewName; //新文件名
objvResourceENT.FileOldName = objvResourceENS.FileOldName; //旧文件名
objvResourceENT.ftpFileType = objvResourceENS.ftpFileType; //ftp文件类型
objvResourceENT.ftpFileSize = objvResourceENS.ftpFileSize; //ftp文件大小
objvResourceENT.ftpResourceOwner = objvResourceENS.ftpResourceOwner; //Ftp资源拥有者
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
 /// <param name = "objvResourceEN">源简化对象</param>
 public static void SetUpdFlag(clsvResourceEN objvResourceEN)
{
try
{
objvResourceEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvResourceEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convResource.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.IdResource = objvResourceEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convResource.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.ResourceID = objvResourceEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convResource.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.ResourceName = objvResourceEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convResource.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.SaveMode = objvResourceEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convResource.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.IdFtpResource = objvResourceEN.IdFtpResource == "[null]" ? null :  objvResourceEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convResource.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FtpResourceID = objvResourceEN.FtpResourceID == "[null]" ? null :  objvResourceEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convResource.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FileOriginalName = objvResourceEN.FileOriginalName == "[null]" ? null :  objvResourceEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convResource.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FileDirName = objvResourceEN.FileDirName == "[null]" ? null :  objvResourceEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convResource.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FileRename = objvResourceEN.FileRename == "[null]" ? null :  objvResourceEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convResource.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FileUpDate = objvResourceEN.FileUpDate == "[null]" ? null :  objvResourceEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convResource.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FileUpTime = objvResourceEN.FileUpTime == "[null]" ? null :  objvResourceEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convResource.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FileSize = objvResourceEN.FileSize == "[null]" ? null :  objvResourceEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convResource.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FileType = objvResourceEN.FileType == "[null]" ? null :  objvResourceEN.FileType; //文件类型
}
if (arrFldSet.Contains(convResource.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.ResourceOwner = objvResourceEN.ResourceOwner == "[null]" ? null :  objvResourceEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convResource.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.IsExistFile = objvResourceEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convResource.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.IdFile = objvResourceEN.IdFile == "[null]" ? null :  objvResourceEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convResource.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FileName = objvResourceEN.FileName == "[null]" ? null :  objvResourceEN.FileName; //文件名称
}
if (arrFldSet.Contains(convResource.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.SaveDate = objvResourceEN.SaveDate == "[null]" ? null :  objvResourceEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convResource.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.SaveTime = objvResourceEN.SaveTime == "[null]" ? null :  objvResourceEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convResource.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FileOriginName = objvResourceEN.FileOriginName == "[null]" ? null :  objvResourceEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convResource.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.IdResourceType = objvResourceEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convResource.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.ResourceTypeID = objvResourceEN.ResourceTypeID == "[null]" ? null :  objvResourceEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convResource.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.ResourceTypeName = objvResourceEN.ResourceTypeName == "[null]" ? null :  objvResourceEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convResource.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.Memo = objvResourceEN.Memo == "[null]" ? null :  objvResourceEN.Memo; //备注
}
if (arrFldSet.Contains(convResource.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FuncModuleId = objvResourceEN.FuncModuleId == "[null]" ? null :  objvResourceEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convResource.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FuncModuleNameSim = objvResourceEN.FuncModuleNameSim == "[null]" ? null :  objvResourceEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convResource.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.OrderNum = objvResourceEN.OrderNum; //序号
}
if (arrFldSet.Contains(convResource.CheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.CheckDate = objvResourceEN.CheckDate == "[null]" ? null :  objvResourceEN.CheckDate; //检查日期
}
if (arrFldSet.Contains(convResource.CheckUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.CheckUser = objvResourceEN.CheckUser == "[null]" ? null :  objvResourceEN.CheckUser; //检查用户Id
}
if (arrFldSet.Contains(convResource.CheckResult, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.CheckResult = objvResourceEN.CheckResult == "[null]" ? null :  objvResourceEN.CheckResult; //检查结果
}
if (arrFldSet.Contains(convResource.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FileNewName = objvResourceEN.FileNewName == "[null]" ? null :  objvResourceEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convResource.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.FileOldName = objvResourceEN.FileOldName == "[null]" ? null :  objvResourceEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convResource.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.ftpFileType = objvResourceEN.ftpFileType == "[null]" ? null :  objvResourceEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convResource.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.ftpFileSize = objvResourceEN.ftpFileSize == "[null]" ? null :  objvResourceEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convResource.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvResourceEN.ftpResourceOwner = objvResourceEN.ftpResourceOwner == "[null]" ? null :  objvResourceEN.ftpResourceOwner; //Ftp资源拥有者
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
 /// <param name = "objvResourceEN">源简化对象</param>
 public static void AccessFldValueNull(clsvResourceEN objvResourceEN)
{
try
{
if (objvResourceEN.IdFtpResource == "[null]") objvResourceEN.IdFtpResource = null; //FTP资源流水号
if (objvResourceEN.FtpResourceID == "[null]") objvResourceEN.FtpResourceID = null; //FTP资源ID
if (objvResourceEN.FileOriginalName == "[null]") objvResourceEN.FileOriginalName = null; //文件原名
if (objvResourceEN.FileDirName == "[null]") objvResourceEN.FileDirName = null; //文件目录名
if (objvResourceEN.FileRename == "[null]") objvResourceEN.FileRename = null; //文件新名
if (objvResourceEN.FileUpDate == "[null]") objvResourceEN.FileUpDate = null; //创建日期
if (objvResourceEN.FileUpTime == "[null]") objvResourceEN.FileUpTime = null; //创建时间
if (objvResourceEN.FileSize == "[null]") objvResourceEN.FileSize = null; //文件大小
if (objvResourceEN.FileType == "[null]") objvResourceEN.FileType = null; //文件类型
if (objvResourceEN.ResourceOwner == "[null]") objvResourceEN.ResourceOwner = null; //上传者
if (objvResourceEN.IdFile == "[null]") objvResourceEN.IdFile = null; //文件流水号
if (objvResourceEN.FileName == "[null]") objvResourceEN.FileName = null; //文件名称
if (objvResourceEN.SaveDate == "[null]") objvResourceEN.SaveDate = null; //创建日期
if (objvResourceEN.SaveTime == "[null]") objvResourceEN.SaveTime = null; //创建时间
if (objvResourceEN.FileOriginName == "[null]") objvResourceEN.FileOriginName = null; //原文件名
if (objvResourceEN.ResourceTypeID == "[null]") objvResourceEN.ResourceTypeID = null; //资源类型ID
if (objvResourceEN.ResourceTypeName == "[null]") objvResourceEN.ResourceTypeName = null; //资源类型名称
if (objvResourceEN.Memo == "[null]") objvResourceEN.Memo = null; //备注
if (objvResourceEN.FuncModuleId == "[null]") objvResourceEN.FuncModuleId = null; //功能模块Id
if (objvResourceEN.FuncModuleNameSim == "[null]") objvResourceEN.FuncModuleNameSim = null; //功能模块简称
if (objvResourceEN.CheckDate == "[null]") objvResourceEN.CheckDate = null; //检查日期
if (objvResourceEN.CheckUser == "[null]") objvResourceEN.CheckUser = null; //检查用户Id
if (objvResourceEN.CheckResult == "[null]") objvResourceEN.CheckResult = null; //检查结果
if (objvResourceEN.FileNewName == "[null]") objvResourceEN.FileNewName = null; //新文件名
if (objvResourceEN.FileOldName == "[null]") objvResourceEN.FileOldName = null; //旧文件名
if (objvResourceEN.ftpFileType == "[null]") objvResourceEN.ftpFileType = null; //ftp文件类型
if (objvResourceEN.ftpFileSize == "[null]") objvResourceEN.ftpFileSize = null; //ftp文件大小
if (objvResourceEN.ftpResourceOwner == "[null]") objvResourceEN.ftpResourceOwner = null; //Ftp资源拥有者
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
public static void CheckProperty4Condition(clsvResourceEN objvResourceEN)
{
 vResourceDA.CheckProperty4Condition(objvResourceEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdResource(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convResource.IdResource); 
List<clsvResourceEN> arrObjLst = clsvResourceBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvResourceEN objvResourceEN = new clsvResourceEN()
{
IdResource = "0",
ResourceName = "选[v资源]..."
};
arrObjLst.Insert(0, objvResourceEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convResource.IdResource;
objComboBox.DisplayMember = convResource.ResourceName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdResource(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v资源]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convResource.IdResource); 
IEnumerable<clsvResourceEN> arrObjLst = clsvResourceBL.GetObjLst(strCondition);
objDDL.DataValueField = convResource.IdResource;
objDDL.DataTextField = convResource.ResourceName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdResourceCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v资源]...","0");
List<clsvResourceEN> arrvResourceObjLst = GetAllvResourceObjLstCache(); 
objDDL.DataValueField = convResource.IdResource;
objDDL.DataTextField = convResource.ResourceName;
objDDL.DataSource = arrvResourceObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdResource");
//if (arrvResourceObjLstCache == null)
//{
//arrvResourceObjLstCache = vResourceDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdResource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvResourceEN GetObjByIdResourceCache(string strIdResource)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvResourceEN._CurrTabName);
List<clsvResourceEN> arrvResourceObjLstCache = GetObjLstCache();
IEnumerable <clsvResourceEN> arrvResourceObjLst_Sel =
arrvResourceObjLstCache
.Where(x=> x.IdResource == strIdResource 
);
if (arrvResourceObjLst_Sel.Count() == 0)
{
   clsvResourceEN obj = clsvResourceBL.GetObjByIdResource(strIdResource);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvResourceObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdResource">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetResourceNameByIdResourceCache(string strIdResource)
{
if (string.IsNullOrEmpty(strIdResource) == true) return "";
//获取缓存中的对象列表
clsvResourceEN objvResource = GetObjByIdResourceCache(strIdResource);
if (objvResource == null) return "";
return objvResource.ResourceName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdResource">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdResourceCache(string strIdResource)
{
if (string.IsNullOrEmpty(strIdResource) == true) return "";
//获取缓存中的对象列表
clsvResourceEN objvResource = GetObjByIdResourceCache(strIdResource);
if (objvResource == null) return "";
return objvResource.ResourceName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvResourceEN> GetAllvResourceObjLstCache()
{
//获取缓存中的对象列表
List<clsvResourceEN> arrvResourceObjLstCache = GetObjLstCache(); 
return arrvResourceObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvResourceEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvResourceEN._CurrTabName);
List<clsvResourceEN> arrvResourceObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvResourceObjLstCache;
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
string strKey = string.Format("{0}", clsvResourceEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdResource)
{
if (strInFldName != convResource.IdResource)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convResource.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convResource.AttributeName));
throw new Exception(strMsg);
}
var objvResource = clsvResourceBL.GetObjByIdResourceCache(strIdResource);
if (objvResource == null) return "";
return objvResource[strOutFldName].ToString();
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
int intRecCount = clsvResourceDA.GetRecCount(strTabName);
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
int intRecCount = clsvResourceDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvResourceDA.GetRecCount();
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
int intRecCount = clsvResourceDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvResourceEN objvResourceCond)
{
List<clsvResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convResource.AttributeName)
{
if (objvResourceCond.IsUpdated(strFldName) == false) continue;
if (objvResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvResourceCond[strFldName].ToString());
}
else
{
if (objvResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvResourceCond[strFldName]));
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
 List<string> arrList = clsvResourceDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vResourceDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vResourceDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}