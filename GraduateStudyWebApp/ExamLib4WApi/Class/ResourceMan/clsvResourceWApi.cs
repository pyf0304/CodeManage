
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvResourceWApi
 表名:vResource(01120321)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:52
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理
 模块英文名:ResourceMan
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsvResourceWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN Setid_Resource(this clsvResourceEN objvResourceEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Resource, 8, convResource.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convResource.id_Resource);
objvResourceEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.id_Resource) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.id_Resource, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.id_Resource] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetResourceID(this clsvResourceEN objvResourceEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convResource.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convResource.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convResource.ResourceID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetResourceName(this clsvResourceEN objvResourceEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceName, convResource.ResourceName);
clsCheckSql.CheckFieldLen(strResourceName, 100, convResource.ResourceName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN Setid_FtpResource(this clsvResourceEN objvResourceEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convResource.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convResource.id_FtpResource);
objvResourceEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.id_FtpResource) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.id_FtpResource, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.id_FtpResource] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFtpResourceID(this clsvResourceEN objvResourceEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convResource.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convResource.FtpResourceID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFileOriginalName(this clsvResourceEN objvResourceEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convResource.FileOriginalName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFileDirName(this clsvResourceEN objvResourceEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convResource.FileDirName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFileRename(this clsvResourceEN objvResourceEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convResource.FileRename);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFileUpDate(this clsvResourceEN objvResourceEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convResource.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convResource.FileUpDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFileUpTime(this clsvResourceEN objvResourceEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convResource.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convResource.FileUpTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFileSize(this clsvResourceEN objvResourceEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convResource.FileSize);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFileType(this clsvResourceEN objvResourceEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convResource.FileType);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetResourceOwner(this clsvResourceEN objvResourceEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convResource.ResourceOwner);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN Setid_File(this clsvResourceEN objvResourceEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convResource.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convResource.id_File);
objvResourceEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.id_File) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.id_File, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.id_File] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFileName(this clsvResourceEN objvResourceEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convResource.FileName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetSaveDate(this clsvResourceEN objvResourceEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convResource.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convResource.SaveDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetSaveTime(this clsvResourceEN objvResourceEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convResource.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convResource.SaveTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFileOriginName(this clsvResourceEN objvResourceEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convResource.FileOriginName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN Setid_ResourceType(this clsvResourceEN objvResourceEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convResource.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convResource.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convResource.id_ResourceType);
objvResourceEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.id_ResourceType) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.id_ResourceType, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.id_ResourceType] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetResourceTypeID(this clsvResourceEN objvResourceEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convResource.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convResource.ResourceTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetResourceTypeName(this clsvResourceEN objvResourceEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convResource.ResourceTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetMemo(this clsvResourceEN objvResourceEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convResource.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFuncModuleId(this clsvResourceEN objvResourceEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convResource.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convResource.FuncModuleId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFuncModuleName_Sim(this clsvResourceEN objvResourceEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convResource.FuncModuleName_Sim);
objvResourceEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResourceEN.dicFldComparisonOp.ContainsKey(convResource.FuncModuleName_Sim) == false)
{
objvResourceEN.dicFldComparisonOp.Add(convResource.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvResourceEN.dicFldComparisonOp[convResource.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetOrderNum(this clsvResourceEN objvResourceEN, int intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetCheckDate(this clsvResourceEN objvResourceEN, string strCheckDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckDate, 20, convResource.CheckDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetCheckUser(this clsvResourceEN objvResourceEN, string strCheckUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckUser, 18, convResource.CheckUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetCheckResult(this clsvResourceEN objvResourceEN, string strCheckResult, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckResult, 1000, convResource.CheckResult);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFileNewName(this clsvResourceEN objvResourceEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convResource.FileNewName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetFileOldName(this clsvResourceEN objvResourceEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convResource.FileOldName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetftpFileType(this clsvResourceEN objvResourceEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convResource.ftpFileType);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetftpFileSize(this clsvResourceEN objvResourceEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convResource.ftpFileSize);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvResourceEN SetftpResourceOwner(this clsvResourceEN objvResourceEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convResource.ftpResourceOwner);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvResourceEN objvResource_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvResource_Cond.IsUpdated(convResource.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvResource_Cond.dicFldComparisonOp[convResource.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.id_Resource, objvResource_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvResource_Cond.IsUpdated(convResource.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvResource_Cond.dicFldComparisonOp[convResource.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ResourceID, objvResource_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvResource_Cond.IsUpdated(convResource.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvResource_Cond.dicFldComparisonOp[convResource.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ResourceName, objvResource_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvResource_Cond.IsUpdated(convResource.SaveMode) == true)
{
if (objvResource_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convResource.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convResource.SaveMode);
}
}
if (objvResource_Cond.IsUpdated(convResource.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvResource_Cond.dicFldComparisonOp[convResource.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.id_FtpResource, objvResource_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvResource_Cond.IsUpdated(convResource.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvResource_Cond.dicFldComparisonOp[convResource.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FtpResourceID, objvResource_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvResource_Cond.IsUpdated(convResource.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvResource_Cond.dicFldComparisonOp[convResource.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileOriginalName, objvResource_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvResource_Cond.IsUpdated(convResource.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvResource_Cond.dicFldComparisonOp[convResource.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileDirName, objvResource_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvResource_Cond.IsUpdated(convResource.FileRename) == true)
{
string strComparisonOp_FileRename = objvResource_Cond.dicFldComparisonOp[convResource.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileRename, objvResource_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvResource_Cond.IsUpdated(convResource.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvResource_Cond.dicFldComparisonOp[convResource.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileUpDate, objvResource_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvResource_Cond.IsUpdated(convResource.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvResource_Cond.dicFldComparisonOp[convResource.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileUpTime, objvResource_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvResource_Cond.IsUpdated(convResource.FileSize) == true)
{
string strComparisonOp_FileSize = objvResource_Cond.dicFldComparisonOp[convResource.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileSize, objvResource_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvResource_Cond.IsUpdated(convResource.FileType) == true)
{
string strComparisonOp_FileType = objvResource_Cond.dicFldComparisonOp[convResource.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileType, objvResource_Cond.FileType, strComparisonOp_FileType);
}
if (objvResource_Cond.IsUpdated(convResource.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvResource_Cond.dicFldComparisonOp[convResource.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ResourceOwner, objvResource_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvResource_Cond.IsUpdated(convResource.IsExistFile) == true)
{
if (objvResource_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convResource.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convResource.IsExistFile);
}
}
if (objvResource_Cond.IsUpdated(convResource.id_File) == true)
{
string strComparisonOp_id_File = objvResource_Cond.dicFldComparisonOp[convResource.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.id_File, objvResource_Cond.id_File, strComparisonOp_id_File);
}
if (objvResource_Cond.IsUpdated(convResource.FileName) == true)
{
string strComparisonOp_FileName = objvResource_Cond.dicFldComparisonOp[convResource.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileName, objvResource_Cond.FileName, strComparisonOp_FileName);
}
if (objvResource_Cond.IsUpdated(convResource.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvResource_Cond.dicFldComparisonOp[convResource.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.SaveDate, objvResource_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvResource_Cond.IsUpdated(convResource.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvResource_Cond.dicFldComparisonOp[convResource.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.SaveTime, objvResource_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvResource_Cond.IsUpdated(convResource.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvResource_Cond.dicFldComparisonOp[convResource.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileOriginName, objvResource_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvResource_Cond.IsUpdated(convResource.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvResource_Cond.dicFldComparisonOp[convResource.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.id_ResourceType, objvResource_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvResource_Cond.IsUpdated(convResource.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvResource_Cond.dicFldComparisonOp[convResource.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ResourceTypeID, objvResource_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvResource_Cond.IsUpdated(convResource.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvResource_Cond.dicFldComparisonOp[convResource.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ResourceTypeName, objvResource_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvResource_Cond.IsUpdated(convResource.Memo) == true)
{
string strComparisonOp_Memo = objvResource_Cond.dicFldComparisonOp[convResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.Memo, objvResource_Cond.Memo, strComparisonOp_Memo);
}
if (objvResource_Cond.IsUpdated(convResource.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvResource_Cond.dicFldComparisonOp[convResource.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FuncModuleId, objvResource_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvResource_Cond.IsUpdated(convResource.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvResource_Cond.dicFldComparisonOp[convResource.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FuncModuleName_Sim, objvResource_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvResource_Cond.IsUpdated(convResource.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvResource_Cond.dicFldComparisonOp[convResource.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convResource.OrderNum, objvResource_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvResource_Cond.IsUpdated(convResource.CheckDate) == true)
{
string strComparisonOp_CheckDate = objvResource_Cond.dicFldComparisonOp[convResource.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.CheckDate, objvResource_Cond.CheckDate, strComparisonOp_CheckDate);
}
if (objvResource_Cond.IsUpdated(convResource.CheckUser) == true)
{
string strComparisonOp_CheckUser = objvResource_Cond.dicFldComparisonOp[convResource.CheckUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.CheckUser, objvResource_Cond.CheckUser, strComparisonOp_CheckUser);
}
if (objvResource_Cond.IsUpdated(convResource.CheckResult) == true)
{
string strComparisonOp_CheckResult = objvResource_Cond.dicFldComparisonOp[convResource.CheckResult];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.CheckResult, objvResource_Cond.CheckResult, strComparisonOp_CheckResult);
}
if (objvResource_Cond.IsUpdated(convResource.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvResource_Cond.dicFldComparisonOp[convResource.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileNewName, objvResource_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvResource_Cond.IsUpdated(convResource.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvResource_Cond.dicFldComparisonOp[convResource.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.FileOldName, objvResource_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvResource_Cond.IsUpdated(convResource.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvResource_Cond.dicFldComparisonOp[convResource.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ftpFileType, objvResource_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvResource_Cond.IsUpdated(convResource.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvResource_Cond.dicFldComparisonOp[convResource.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ftpFileSize, objvResource_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvResource_Cond.IsUpdated(convResource.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvResource_Cond.dicFldComparisonOp[convResource.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResource.ftpResourceOwner, objvResource_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v资源(vResource)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvResourceWApi
{
private static readonly string mstrApiControllerName = "vResourceApi";

 public clsvResourceWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_Resource(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v资源]...","0");
List<clsvResourceEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_Resource";
objDDL.DataTextField="ResourceName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_Resource(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convResource.id_Resource); 
List<clsvResourceEN> arrObjLst = clsvResourceWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvResourceEN objvResourceEN = new clsvResourceEN()
{
id_Resource = "0",
ResourceName = "选[v资源]..."
};
arrObjLst.Insert(0, objvResourceEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convResource.id_Resource;
objComboBox.DisplayMember = convResource.ResourceName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_Resource">表关键字</param>
 /// <returns>表对象</returns>
public static clsvResourceEN GetObjByid_Resource(string strid_Resource)
{
string strAction = "GetObjByid_Resource";
string strErrMsg = string.Empty;
string strResult = "";
clsvResourceEN objvResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Resource"] = strid_Resource
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvResourceEN = JsonConvert.DeserializeObject<clsvResourceEN>((string)jobjReturn["ReturnObj"]);
return objvResourceEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strid_Resource">表关键字</param>
 /// <returns>表对象</returns>
public static clsvResourceEN GetObjByid_Resource_WA_Cache(string strid_Resource)
{
string strAction = "GetObjByid_Resource_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvResourceEN objvResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Resource"] = strid_Resource
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvResourceEN = JsonConvert.DeserializeObject<clsvResourceEN>((string)jobjReturn["ReturnObj"]);
return objvResourceEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvResourceEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvResourceEN objvResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvResourceEN = JsonConvert.DeserializeObject<clsvResourceEN>((string)jobjReturn["ReturnObj"]);
return objvResourceEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_Resource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvResourceEN GetObjByid_Resource_Cache(string strid_Resource)
{
if (string.IsNullOrEmpty(strid_Resource) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvResourceEN._CurrTabName_S);
List<clsvResourceEN> arrvResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvResourceEN> arrvResourceObjLst_Sel =
from objvResourceEN in arrvResourceObjLst_Cache
where objvResourceEN.id_Resource == strid_Resource
select objvResourceEN;
if (arrvResourceObjLst_Sel.Count() == 0)
{
   clsvResourceEN obj = clsvResourceWApi.GetObjByid_Resource(strid_Resource);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvResourceObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_Resource">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetResourceNameByid_Resource_Cache(string strid_Resource)
{
if (string.IsNullOrEmpty(strid_Resource) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvResourceEN._CurrTabName_S);
List<clsvResourceEN> arrvResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvResourceEN> arrvResourceObjLst_Sel1 =
from objvResourceEN in arrvResourceObjLst_Cache
where objvResourceEN.id_Resource == strid_Resource
select objvResourceEN;
List <clsvResourceEN> arrvResourceObjLst_Sel = new List<clsvResourceEN>();
foreach (clsvResourceEN obj in arrvResourceObjLst_Sel1)
{
arrvResourceObjLst_Sel.Add(obj);
}
if (arrvResourceObjLst_Sel.Count > 0)
{
return arrvResourceObjLst_Sel[0].ResourceName;
}
string strErrMsgForGetObjById = string.Format("在vResource对象缓存列表中,找不到记录[id_Resource = {0}](函数:{1})", strid_Resource, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvResourceBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_Resource">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_Resource_Cache(string strid_Resource)
{
if (string.IsNullOrEmpty(strid_Resource) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvResourceEN._CurrTabName_S);
List<clsvResourceEN> arrvResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvResourceEN> arrvResourceObjLst_Sel1 =
from objvResourceEN in arrvResourceObjLst_Cache
where objvResourceEN.id_Resource == strid_Resource
select objvResourceEN;
List <clsvResourceEN> arrvResourceObjLst_Sel = new List<clsvResourceEN>();
foreach (clsvResourceEN obj in arrvResourceObjLst_Sel1)
{
arrvResourceObjLst_Sel.Add(obj);
}
if (arrvResourceObjLst_Sel.Count > 0)
{
return arrvResourceObjLst_Sel[0].ResourceName;
}
string strErrMsgForGetObjById = string.Format("在vResource对象缓存列表中,找不到记录的相关名称[id_Resource = {0}](函数:{1})", strid_Resource, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvResourceBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvResourceEN> GetObjLst(string strWhereCond)
{
 List<clsvResourceEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvResourceEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvResourceEN> GetObjLstById_ResourceLst(List<string> arrId_Resource)
{
 List<clsvResourceEN> arrObjLst = null; 
string strAction = "GetObjLstById_ResourceLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Resource);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvResourceEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strid_Resource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvResourceEN> GetObjLstById_ResourceLst_Cache(List<string> arrId_Resource)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvResourceEN._CurrTabName_S);
List<clsvResourceEN> arrvResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvResourceEN> arrvResourceObjLst_Sel =
from objvResourceEN in arrvResourceObjLst_Cache
where arrId_Resource.Contains(objvResourceEN.id_Resource)
select objvResourceEN;
return arrvResourceObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvResourceEN> GetObjLstById_ResourceLst_WA_Cache(List<string> arrId_Resource)
{
 List<clsvResourceEN> arrObjLst = null; 
string strAction = "GetObjLstById_ResourceLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Resource);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvResourceEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvResourceEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvResourceEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvResourceEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvResourceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvResourceEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvResourceEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvResourceEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvResourceEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvResourceEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvResourceEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvResourceEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strid_Resource)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Resource"] = strid_Resource
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvResourceENS">源对象</param>
 /// <param name = "objvResourceENT">目标对象</param>
 public static void CopyTo(clsvResourceEN objvResourceENS, clsvResourceEN objvResourceENT)
{
try
{
objvResourceENT.id_Resource = objvResourceENS.id_Resource; //资源流水号
objvResourceENT.ResourceID = objvResourceENS.ResourceID; //资源ID
objvResourceENT.ResourceName = objvResourceENS.ResourceName; //资源名称
objvResourceENT.SaveMode = objvResourceENS.SaveMode; //文件存放方式
objvResourceENT.id_FtpResource = objvResourceENS.id_FtpResource; //FTP资源流水号
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
objvResourceENT.id_File = objvResourceENS.id_File; //文件流水号
objvResourceENT.FileName = objvResourceENS.FileName; //文件名称
objvResourceENT.SaveDate = objvResourceENS.SaveDate; //创建日期
objvResourceENT.SaveTime = objvResourceENS.SaveTime; //创建时间
objvResourceENT.FileOriginName = objvResourceENS.FileOriginName; //原文件名
objvResourceENT.id_ResourceType = objvResourceENS.id_ResourceType; //资源类型流水号
objvResourceENT.ResourceTypeID = objvResourceENS.ResourceTypeID; //资源类型ID
objvResourceENT.ResourceTypeName = objvResourceENS.ResourceTypeName; //资源类型名称
objvResourceENT.Memo = objvResourceENS.Memo; //备注
objvResourceENT.FuncModuleId = objvResourceENS.FuncModuleId; //功能模块Id
objvResourceENT.FuncModuleName_Sim = objvResourceENS.FuncModuleName_Sim; //功能模块简称
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
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvResourceEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvResourceEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvResourceEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvResourceEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvResourceEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvResourceEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceWApi没有刷新缓存机制(clsResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerWApi没有刷新缓存机制(clsFileServerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceWApi没有刷新缓存机制(clsFtpResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_Resource");
//if (arrvResourceObjLst_Cache == null)
//{
//arrvResourceObjLst_Cache = await clsvResourceWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvResourceEN._CurrTabName_S);
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

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvResourceEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvResourceEN._CurrTabName_S);
List<clsvResourceEN> arrvResourceObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvResourceObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvResourceEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convResource.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convResource.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convResource.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convResource.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convResource.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convResource.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convResource.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convResource.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convResource.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convResource.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convResource.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convResource.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convResource.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convResource.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convResource.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convResource.CheckDate, Type.GetType("System.String"));
objDT.Columns.Add(convResource.CheckUser, Type.GetType("System.String"));
objDT.Columns.Add(convResource.CheckResult, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convResource.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convResource.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convResource.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convResource.ftpResourceOwner, Type.GetType("System.String"));
foreach (clsvResourceEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convResource.id_Resource] = objInFor[convResource.id_Resource];
objDR[convResource.ResourceID] = objInFor[convResource.ResourceID];
objDR[convResource.ResourceName] = objInFor[convResource.ResourceName];
objDR[convResource.SaveMode] = objInFor[convResource.SaveMode];
objDR[convResource.id_FtpResource] = objInFor[convResource.id_FtpResource];
objDR[convResource.FtpResourceID] = objInFor[convResource.FtpResourceID];
objDR[convResource.FileOriginalName] = objInFor[convResource.FileOriginalName];
objDR[convResource.FileDirName] = objInFor[convResource.FileDirName];
objDR[convResource.FileRename] = objInFor[convResource.FileRename];
objDR[convResource.FileUpDate] = objInFor[convResource.FileUpDate];
objDR[convResource.FileUpTime] = objInFor[convResource.FileUpTime];
objDR[convResource.FileSize] = objInFor[convResource.FileSize];
objDR[convResource.FileType] = objInFor[convResource.FileType];
objDR[convResource.ResourceOwner] = objInFor[convResource.ResourceOwner];
objDR[convResource.IsExistFile] = objInFor[convResource.IsExistFile];
objDR[convResource.id_File] = objInFor[convResource.id_File];
objDR[convResource.FileName] = objInFor[convResource.FileName];
objDR[convResource.SaveDate] = objInFor[convResource.SaveDate];
objDR[convResource.SaveTime] = objInFor[convResource.SaveTime];
objDR[convResource.FileOriginName] = objInFor[convResource.FileOriginName];
objDR[convResource.id_ResourceType] = objInFor[convResource.id_ResourceType];
objDR[convResource.ResourceTypeID] = objInFor[convResource.ResourceTypeID];
objDR[convResource.ResourceTypeName] = objInFor[convResource.ResourceTypeName];
objDR[convResource.Memo] = objInFor[convResource.Memo];
objDR[convResource.FuncModuleId] = objInFor[convResource.FuncModuleId];
objDR[convResource.FuncModuleName_Sim] = objInFor[convResource.FuncModuleName_Sim];
objDR[convResource.OrderNum] = objInFor[convResource.OrderNum];
objDR[convResource.CheckDate] = objInFor[convResource.CheckDate];
objDR[convResource.CheckUser] = objInFor[convResource.CheckUser];
objDR[convResource.CheckResult] = objInFor[convResource.CheckResult];
objDR[convResource.FileNewName] = objInFor[convResource.FileNewName];
objDR[convResource.FileOldName] = objInFor[convResource.FileOldName];
objDR[convResource.ftpFileType] = objInFor[convResource.ftpFileType];
objDR[convResource.ftpFileSize] = objInFor[convResource.ftpFileSize];
objDR[convResource.ftpResourceOwner] = objInFor[convResource.ftpResourceOwner];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}