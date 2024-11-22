
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFtpResourceFileResRelaWApi
 表名:vFtpResourceFileResRela(01120376)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:46
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
public static class clsvFtpResourceFileResRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetmId(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, long lngmId, string strComparisonOp="")
	{
objvFtpResourceFileResRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.mId) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.mId, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.mId] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileResourceID(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, long lngFileResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngFileResourceID, convFtpResourceFileResRela.FileResourceID);
objvFtpResourceFileResRelaEN.FileResourceID = lngFileResourceID; //FileResourceID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileResourceID) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileResourceID, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileResourceID] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetIpAddress(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 50, convFtpResourceFileResRela.IpAddress);
objvFtpResourceFileResRelaEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.IpAddress) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.IpAddress, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.IpAddress] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileDirName(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convFtpResourceFileResRela.FileDirName);
objvFtpResourceFileResRelaEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileDirName) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileDirName, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileDirName] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileName(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convFtpResourceFileResRela.FileName);
objvFtpResourceFileResRelaEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileName) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileName, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileName] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileName_Bak(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFileName_Bak, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName_Bak, 500, convFtpResourceFileResRela.FileName_Bak);
objvFtpResourceFileResRelaEN.FileName_Bak = strFileName_Bak; //FileName_Bak
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileName_Bak) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileName_Bak, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileName_Bak] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetExtension(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strExtension, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExtension, 10, convFtpResourceFileResRela.Extension);
objvFtpResourceFileResRelaEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.Extension) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.Extension, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.Extension] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileLength(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, long lngFileLength, string strComparisonOp="")
	{
objvFtpResourceFileResRelaEN.FileLength = lngFileLength; //文件长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileLength) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileLength, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileLength] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileType(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convFtpResourceFileResRela.FileType);
objvFtpResourceFileResRelaEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileType) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileType, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileType] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetCreationTime(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strCreationTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreationTime, 20, convFtpResourceFileResRela.CreationTime);
objvFtpResourceFileResRelaEN.CreationTime = strCreationTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.CreationTime) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.CreationTime, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.CreationTime] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetLastWriteTime(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strLastWriteTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastWriteTime, 20, convFtpResourceFileResRela.LastWriteTime);
objvFtpResourceFileResRelaEN.LastWriteTime = strLastWriteTime; //最后修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.LastWriteTime) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.LastWriteTime, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.LastWriteTime] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetCheckDateTime(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strCheckDateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckDateTime, 30, convFtpResourceFileResRela.CheckDateTime);
objvFtpResourceFileResRelaEN.CheckDateTime = strCheckDateTime; //CheckDateTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.CheckDateTime) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.CheckDateTime, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.CheckDateTime] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetInUse(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, bool bolInUse, string strComparisonOp="")
	{
objvFtpResourceFileResRelaEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.InUse) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.InUse, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.InUse] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetIsExistFile(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvFtpResourceFileResRelaEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.IsExistFile) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.IsExistFile, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.IsExistFile] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN Setid_FtpResource(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convFtpResourceFileResRela.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convFtpResourceFileResRela.id_FtpResource);
objvFtpResourceFileResRelaEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.id_FtpResource) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.id_FtpResource, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.id_FtpResource] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFuncModuleId(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convFtpResourceFileResRela.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convFtpResourceFileResRela.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convFtpResourceFileResRela.FuncModuleId);
objvFtpResourceFileResRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FuncModuleId) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FuncModuleId, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleId] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFuncModuleName(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convFtpResourceFileResRela.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convFtpResourceFileResRela.FuncModuleName);
objvFtpResourceFileResRelaEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FuncModuleName) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FuncModuleName, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleName] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFuncModuleName_Sim(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convFtpResourceFileResRela.FuncModuleName_Sim);
objvFtpResourceFileResRelaEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FuncModuleName_Sim) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetOrderNum(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, int intOrderNum, string strComparisonOp="")
	{
objvFtpResourceFileResRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.OrderNum) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.OrderNum, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.OrderNum] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetUpdDate(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFtpResourceFileResRela.UpdDate);
objvFtpResourceFileResRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.UpdDate) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.UpdDate, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.UpdDate] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetUpdUser(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFtpResourceFileResRela.UpdUser);
objvFtpResourceFileResRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.UpdUser) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.UpdUser, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.UpdUser] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetMemo(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFtpResourceFileResRela.Memo);
objvFtpResourceFileResRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.Memo) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.Memo, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.Memo] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.mId) == true)
{
string strComparisonOp_mId = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResourceFileResRela.mId, objvFtpResourceFileResRela_Cond.mId, strComparisonOp_mId);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.FileResourceID) == true)
{
string strComparisonOp_FileResourceID = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.FileResourceID];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResourceFileResRela.FileResourceID, objvFtpResourceFileResRela_Cond.FileResourceID, strComparisonOp_FileResourceID);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.IpAddress) == true)
{
string strComparisonOp_IpAddress = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.IpAddress, objvFtpResourceFileResRela_Cond.IpAddress, strComparisonOp_IpAddress);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FileDirName, objvFtpResourceFileResRela_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.FileName) == true)
{
string strComparisonOp_FileName = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FileName, objvFtpResourceFileResRela_Cond.FileName, strComparisonOp_FileName);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.FileName_Bak) == true)
{
string strComparisonOp_FileName_Bak = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.FileName_Bak];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FileName_Bak, objvFtpResourceFileResRela_Cond.FileName_Bak, strComparisonOp_FileName_Bak);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.Extension) == true)
{
string strComparisonOp_Extension = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.Extension, objvFtpResourceFileResRela_Cond.Extension, strComparisonOp_Extension);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.FileLength) == true)
{
string strComparisonOp_FileLength = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.FileLength];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResourceFileResRela.FileLength, objvFtpResourceFileResRela_Cond.FileLength, strComparisonOp_FileLength);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.FileType) == true)
{
string strComparisonOp_FileType = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FileType, objvFtpResourceFileResRela_Cond.FileType, strComparisonOp_FileType);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.CreationTime) == true)
{
string strComparisonOp_CreationTime = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.CreationTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.CreationTime, objvFtpResourceFileResRela_Cond.CreationTime, strComparisonOp_CreationTime);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.LastWriteTime) == true)
{
string strComparisonOp_LastWriteTime = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.LastWriteTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.LastWriteTime, objvFtpResourceFileResRela_Cond.LastWriteTime, strComparisonOp_LastWriteTime);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.CheckDateTime) == true)
{
string strComparisonOp_CheckDateTime = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.CheckDateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.CheckDateTime, objvFtpResourceFileResRela_Cond.CheckDateTime, strComparisonOp_CheckDateTime);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.InUse) == true)
{
if (objvFtpResourceFileResRela_Cond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFtpResourceFileResRela.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFtpResourceFileResRela.InUse);
}
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.IsExistFile) == true)
{
if (objvFtpResourceFileResRela_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFtpResourceFileResRela.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFtpResourceFileResRela.IsExistFile);
}
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.id_FtpResource, objvFtpResourceFileResRela_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FuncModuleId, objvFtpResourceFileResRela_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FuncModuleName, objvFtpResourceFileResRela_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FuncModuleName_Sim, objvFtpResourceFileResRela_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResourceFileResRela.OrderNum, objvFtpResourceFileResRela_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.UpdDate, objvFtpResourceFileResRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.UpdUser, objvFtpResourceFileResRela_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvFtpResourceFileResRela_Cond.IsUpdated(convFtpResourceFileResRela.Memo) == true)
{
string strComparisonOp_Memo = objvFtpResourceFileResRela_Cond.dicFldComparisonOp[convFtpResourceFileResRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.Memo, objvFtpResourceFileResRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vFtp资源文件资源关系(vFtpResourceFileResRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFtpResourceFileResRelaWApi
{
private static readonly string mstrApiControllerName = "vFtpResourceFileResRelaApi";

 public clsvFtpResourceFileResRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFtpResourceFileResRelaEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvFtpResourceFileResRelaEN = JsonConvert.DeserializeObject<clsvFtpResourceFileResRelaEN>((string)jobjReturn["ReturnObj"]);
return objvFtpResourceFileResRelaEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFtpResourceFileResRelaEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvFtpResourceFileResRelaEN = JsonConvert.DeserializeObject<clsvFtpResourceFileResRelaEN>((string)jobjReturn["ReturnObj"]);
return objvFtpResourceFileResRelaEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
public static clsvFtpResourceFileResRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = null;
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
objvFtpResourceFileResRelaEN = JsonConvert.DeserializeObject<clsvFtpResourceFileResRelaEN>((string)jobjReturn["ReturnObj"]);
return objvFtpResourceFileResRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFtpResourceFileResRelaEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFtpResourceFileResRelaEN._CurrTabName_S);
List<clsvFtpResourceFileResRelaEN> arrvFtpResourceFileResRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvFtpResourceFileResRelaEN> arrvFtpResourceFileResRelaObjLst_Sel =
from objvFtpResourceFileResRelaEN in arrvFtpResourceFileResRelaObjLst_Cache
where objvFtpResourceFileResRelaEN.mId == lngmId
select objvFtpResourceFileResRelaEN;
if (arrvFtpResourceFileResRelaObjLst_Sel.Count() == 0)
{
   clsvFtpResourceFileResRelaEN obj = clsvFtpResourceFileResRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFtpResourceFileResRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceFileResRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvFtpResourceFileResRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceFileResRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFtpResourceFileResRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFtpResourceFileResRelaEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceFileResRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvFtpResourceFileResRelaEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFtpResourceFileResRelaEN._CurrTabName_S);
List<clsvFtpResourceFileResRelaEN> arrvFtpResourceFileResRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvFtpResourceFileResRelaEN> arrvFtpResourceFileResRelaObjLst_Sel =
from objvFtpResourceFileResRelaEN in arrvFtpResourceFileResRelaObjLst_Cache
where arrMId.Contains(objvFtpResourceFileResRelaEN.mId)
select objvFtpResourceFileResRelaEN;
return arrvFtpResourceFileResRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceFileResRelaEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvFtpResourceFileResRelaEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceFileResRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFtpResourceFileResRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFtpResourceFileResRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceFileResRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFtpResourceFileResRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFtpResourceFileResRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceFileResRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFtpResourceFileResRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFtpResourceFileResRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceFileResRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFtpResourceFileResRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvFtpResourceFileResRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceFileResRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objvFtpResourceFileResRelaENS">源对象</param>
 /// <param name = "objvFtpResourceFileResRelaENT">目标对象</param>
 public static void CopyTo(clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaENS, clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaENT)
{
try
{
objvFtpResourceFileResRelaENT.mId = objvFtpResourceFileResRelaENS.mId; //mId
objvFtpResourceFileResRelaENT.FileResourceID = objvFtpResourceFileResRelaENS.FileResourceID; //FileResourceID
objvFtpResourceFileResRelaENT.IpAddress = objvFtpResourceFileResRelaENS.IpAddress; //Ip地址
objvFtpResourceFileResRelaENT.FileDirName = objvFtpResourceFileResRelaENS.FileDirName; //文件目录名
objvFtpResourceFileResRelaENT.FileName = objvFtpResourceFileResRelaENS.FileName; //文件名称
objvFtpResourceFileResRelaENT.FileName_Bak = objvFtpResourceFileResRelaENS.FileName_Bak; //FileName_Bak
objvFtpResourceFileResRelaENT.Extension = objvFtpResourceFileResRelaENS.Extension; //扩展名
objvFtpResourceFileResRelaENT.FileLength = objvFtpResourceFileResRelaENS.FileLength; //文件长度
objvFtpResourceFileResRelaENT.FileType = objvFtpResourceFileResRelaENS.FileType; //文件类型
objvFtpResourceFileResRelaENT.CreationTime = objvFtpResourceFileResRelaENS.CreationTime; //建立时间
objvFtpResourceFileResRelaENT.LastWriteTime = objvFtpResourceFileResRelaENS.LastWriteTime; //最后修改时间
objvFtpResourceFileResRelaENT.CheckDateTime = objvFtpResourceFileResRelaENS.CheckDateTime; //CheckDateTime
objvFtpResourceFileResRelaENT.InUse = objvFtpResourceFileResRelaENS.InUse; //是否在用
objvFtpResourceFileResRelaENT.IsExistFile = objvFtpResourceFileResRelaENS.IsExistFile; //是否存在文件
objvFtpResourceFileResRelaENT.id_FtpResource = objvFtpResourceFileResRelaENS.id_FtpResource; //FTP资源流水号
objvFtpResourceFileResRelaENT.FuncModuleId = objvFtpResourceFileResRelaENS.FuncModuleId; //功能模块Id
objvFtpResourceFileResRelaENT.FuncModuleName = objvFtpResourceFileResRelaENS.FuncModuleName; //功能模块名称
objvFtpResourceFileResRelaENT.FuncModuleName_Sim = objvFtpResourceFileResRelaENS.FuncModuleName_Sim; //功能模块简称
objvFtpResourceFileResRelaENT.OrderNum = objvFtpResourceFileResRelaENS.OrderNum; //序号
objvFtpResourceFileResRelaENT.UpdDate = objvFtpResourceFileResRelaENS.UpdDate; //修改日期
objvFtpResourceFileResRelaENT.UpdUser = objvFtpResourceFileResRelaENS.UpdUser; //修改人
objvFtpResourceFileResRelaENT.Memo = objvFtpResourceFileResRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvFtpResourceFileResRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFtpResourceFileResRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFtpResourceFileResRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFtpResourceFileResRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFtpResourceFileResRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFtpResourceFileResRelaEN.AttributeName)
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
if (clsFileResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileResourceWApi没有刷新缓存机制(clsFileResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceFileResRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceFileResRelaWApi没有刷新缓存机制(clsFtpResourceFileResRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceWApi没有刷新缓存机制(clsFtpResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvFtpResourceFileResRelaObjLst_Cache == null)
//{
//arrvFtpResourceFileResRelaObjLst_Cache = await clsvFtpResourceFileResRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvFtpResourceFileResRelaEN._CurrTabName_S);
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
public static List<clsvFtpResourceFileResRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvFtpResourceFileResRelaEN._CurrTabName_S);
List<clsvFtpResourceFileResRelaEN> arrvFtpResourceFileResRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFtpResourceFileResRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFtpResourceFileResRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFtpResourceFileResRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFtpResourceFileResRela.FileResourceID, Type.GetType("System.Int64"));
objDT.Columns.Add(convFtpResourceFileResRela.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.FileName_Bak, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.Extension, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.FileLength, Type.GetType("System.Int64"));
objDT.Columns.Add(convFtpResourceFileResRela.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.CreationTime, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.LastWriteTime, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.CheckDateTime, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFtpResourceFileResRela.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFtpResourceFileResRela.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFtpResourceFileResRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResourceFileResRela.Memo, Type.GetType("System.String"));
foreach (clsvFtpResourceFileResRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFtpResourceFileResRela.mId] = objInFor[convFtpResourceFileResRela.mId];
objDR[convFtpResourceFileResRela.FileResourceID] = objInFor[convFtpResourceFileResRela.FileResourceID];
objDR[convFtpResourceFileResRela.IpAddress] = objInFor[convFtpResourceFileResRela.IpAddress];
objDR[convFtpResourceFileResRela.FileDirName] = objInFor[convFtpResourceFileResRela.FileDirName];
objDR[convFtpResourceFileResRela.FileName] = objInFor[convFtpResourceFileResRela.FileName];
objDR[convFtpResourceFileResRela.FileName_Bak] = objInFor[convFtpResourceFileResRela.FileName_Bak];
objDR[convFtpResourceFileResRela.Extension] = objInFor[convFtpResourceFileResRela.Extension];
objDR[convFtpResourceFileResRela.FileLength] = objInFor[convFtpResourceFileResRela.FileLength];
objDR[convFtpResourceFileResRela.FileType] = objInFor[convFtpResourceFileResRela.FileType];
objDR[convFtpResourceFileResRela.CreationTime] = objInFor[convFtpResourceFileResRela.CreationTime];
objDR[convFtpResourceFileResRela.LastWriteTime] = objInFor[convFtpResourceFileResRela.LastWriteTime];
objDR[convFtpResourceFileResRela.CheckDateTime] = objInFor[convFtpResourceFileResRela.CheckDateTime];
objDR[convFtpResourceFileResRela.InUse] = objInFor[convFtpResourceFileResRela.InUse];
objDR[convFtpResourceFileResRela.IsExistFile] = objInFor[convFtpResourceFileResRela.IsExistFile];
objDR[convFtpResourceFileResRela.id_FtpResource] = objInFor[convFtpResourceFileResRela.id_FtpResource];
objDR[convFtpResourceFileResRela.FuncModuleId] = objInFor[convFtpResourceFileResRela.FuncModuleId];
objDR[convFtpResourceFileResRela.FuncModuleName] = objInFor[convFtpResourceFileResRela.FuncModuleName];
objDR[convFtpResourceFileResRela.FuncModuleName_Sim] = objInFor[convFtpResourceFileResRela.FuncModuleName_Sim];
objDR[convFtpResourceFileResRela.OrderNum] = objInFor[convFtpResourceFileResRela.OrderNum];
objDR[convFtpResourceFileResRela.UpdDate] = objInFor[convFtpResourceFileResRela.UpdDate];
objDR[convFtpResourceFileResRela.UpdUser] = objInFor[convFtpResourceFileResRela.UpdUser];
objDR[convFtpResourceFileResRela.Memo] = objInFor[convFtpResourceFileResRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}