
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroTeachCaseRelaInfoWApi
 表名:vMicroTeachCaseRelaInfo(01120319)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:16
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
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
public static class clsvMicroTeachCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvMicroTeachCaseRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFuncModuleId(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroTeachCaseRelaInfo.FuncModuleId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFuncModuleName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroTeachCaseRelaInfo.FuncModuleName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroTeachCaseRelaInfoType, convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
objvMicroTeachCaseRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroTeachCaseRelaInfoTypeName, convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetBrowseCount(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetResourceOwner(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convMicroTeachCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroTeachCaseRelaInfo.ResourceOwner);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetftpFileType(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroTeachCaseRelaInfo.ftpFileType);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetftpFileSize(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroTeachCaseRelaInfo.ftpFileSize);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetftpResourceOwner(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroTeachCaseRelaInfo.ftpResourceOwner);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileOriginName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroTeachCaseRelaInfo.FileOriginName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN Setid_File(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convMicroTeachCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convMicroTeachCaseRelaInfo.id_File);
objvMicroTeachCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.id_File) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroTeachCaseRelaInfo.FileName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileType(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroTeachCaseRelaInfo.FileType);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetSaveDate(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroTeachCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroTeachCaseRelaInfo.SaveDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileSize(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroTeachCaseRelaInfo.FileSize);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetSaveTime(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroTeachCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroTeachCaseRelaInfo.SaveTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN Setid_MicroteachCase(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convMicroTeachCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroTeachCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroTeachCaseRelaInfo.id_MicroteachCase);
objvMicroTeachCaseRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.id_MicroteachCase) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetMicroteachCaseName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, convMicroTeachCaseRelaInfo.MicroteachCaseName);
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroTeachCaseRelaInfo.MicroteachCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN Setid_FtpResource(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convMicroTeachCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convMicroTeachCaseRelaInfo.id_FtpResource);
objvMicroTeachCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.id_FtpResource) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFtpResourceID(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convMicroTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroTeachCaseRelaInfo.FtpResourceID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileOriginalName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroTeachCaseRelaInfo.FileOriginalName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileDirName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroTeachCaseRelaInfo.FileDirName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileRename(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroTeachCaseRelaInfo.FileRename);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileUpDate(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroTeachCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroTeachCaseRelaInfo.FileUpDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileUpTime(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroTeachCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroTeachCaseRelaInfo.FileUpTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN Setid_Resource(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convMicroTeachCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convMicroTeachCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convMicroTeachCaseRelaInfo.id_Resource);
objvMicroTeachCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.id_Resource) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetResourceID(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convMicroTeachCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroTeachCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroTeachCaseRelaInfo.ResourceID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN Setid_ResourceType(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convMicroTeachCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convMicroTeachCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convMicroTeachCaseRelaInfo.id_ResourceType);
objvMicroTeachCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMicroTeachCaseRelaInfo.id_ResourceType) == false)
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convMicroTeachCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvMicroTeachCaseRelaInfoEN.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetResourceTypeID(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convMicroTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroTeachCaseRelaInfo.ResourceTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetResourceTypeName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convMicroTeachCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroTeachCaseRelaInfo.ResourceTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFlag(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convMicroTeachCaseRelaInfo.Flag);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileNewName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroTeachCaseRelaInfo.FileNewName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetFileOldName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroTeachCaseRelaInfo.FileOldName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetResourceName(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroTeachCaseRelaInfo.ResourceName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetUpdDate(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroTeachCaseRelaInfo.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetUpdUser(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroTeachCaseRelaInfo.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroTeachCaseRelaInfoEN SetMemo(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroTeachCaseRelaInfo.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfo, objvMicroTeachCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FuncModuleId, objvMicroTeachCaseRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FuncModuleName, objvMicroTeachCaseRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType, objvMicroTeachCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvMicroTeachCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroTeachCaseRelaInfo.BrowseCount, objvMicroTeachCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ResourceOwner, objvMicroTeachCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ftpFileType, objvMicroTeachCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ftpFileSize, objvMicroTeachCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ftpResourceOwner, objvMicroTeachCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileOriginName, objvMicroTeachCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.id_File, objvMicroTeachCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileName, objvMicroTeachCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileType, objvMicroTeachCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.SaveDate, objvMicroTeachCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileSize, objvMicroTeachCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.SaveTime, objvMicroTeachCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.id_MicroteachCase, objvMicroTeachCaseRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.MicroteachCaseName, objvMicroTeachCaseRelaInfo_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.id_FtpResource, objvMicroTeachCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FtpResourceID, objvMicroTeachCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileOriginalName, objvMicroTeachCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileDirName, objvMicroTeachCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileRename, objvMicroTeachCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileUpDate, objvMicroTeachCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileUpTime, objvMicroTeachCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.id_Resource, objvMicroTeachCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ResourceID, objvMicroTeachCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.SaveMode) == true)
{
if (objvMicroTeachCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCaseRelaInfo.SaveMode);
}
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.id_ResourceType, objvMicroTeachCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ResourceTypeID, objvMicroTeachCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ResourceTypeName, objvMicroTeachCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.Flag, objvMicroTeachCaseRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileNewName, objvMicroTeachCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.FileOldName, objvMicroTeachCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.IsExistFile) == true)
{
if (objvMicroTeachCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCaseRelaInfo.IsExistFile);
}
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.ResourceName, objvMicroTeachCaseRelaInfo_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.IsVisible) == true)
{
if (objvMicroTeachCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroTeachCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroTeachCaseRelaInfo.IsVisible);
}
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.UpdDate, objvMicroTeachCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.UpdUser, objvMicroTeachCaseRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvMicroTeachCaseRelaInfo_Cond.IsUpdated(convMicroTeachCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvMicroTeachCaseRelaInfo_Cond.dicFldComparisonOp[convMicroTeachCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroTeachCaseRelaInfo.Memo, objvMicroTeachCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 微格案例相关信息视图(vMicroTeachCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroTeachCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vMicroTeachCaseRelaInfoApi";

 public clsvMicroTeachCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroTeachCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroTeachCaseRelaInfo"] = lngid_MicroTeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvMicroTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvMicroTeachCaseRelaInfoEN;
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
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroTeachCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroTeachCaseRelaInfo"] = lngid_MicroTeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvMicroTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvMicroTeachCaseRelaInfoEN;
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
public static clsvMicroTeachCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = null;
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
objvMicroTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvMicroTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvMicroTeachCaseRelaInfoEN;
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
 /// <param name = "lngid_MicroTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroTeachCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroTeachCaseRelaInfoEN._CurrTabName_S);
List<clsvMicroTeachCaseRelaInfoEN> arrvMicroTeachCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroTeachCaseRelaInfoEN> arrvMicroTeachCaseRelaInfoObjLst_Sel =
from objvMicroTeachCaseRelaInfoEN in arrvMicroTeachCaseRelaInfoObjLst_Cache
where objvMicroTeachCaseRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvMicroTeachCaseRelaInfoEN;
if (arrvMicroTeachCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvMicroTeachCaseRelaInfoEN obj = clsvMicroTeachCaseRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroTeachCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroTeachCaseRelaInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroTeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMicroTeachCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroTeachCaseRelaInfoEN._CurrTabName_S);
List<clsvMicroTeachCaseRelaInfoEN> arrvMicroTeachCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroTeachCaseRelaInfoEN> arrvMicroTeachCaseRelaInfoObjLst_Sel =
from objvMicroTeachCaseRelaInfoEN in arrvMicroTeachCaseRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvMicroTeachCaseRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvMicroTeachCaseRelaInfoEN;
return arrvMicroTeachCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroTeachCaseRelaInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroTeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_MicroTeachCaseRelaInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroTeachCaseRelaInfo"] = lngid_MicroTeachCaseRelaInfo.ToString()
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
 /// <param name = "objvMicroTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvMicroTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoENS, clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoENT)
{
try
{
objvMicroTeachCaseRelaInfoENT.id_MicroTeachCaseRelaInfo = objvMicroTeachCaseRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvMicroTeachCaseRelaInfoENT.FuncModuleId = objvMicroTeachCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvMicroTeachCaseRelaInfoENT.FuncModuleName = objvMicroTeachCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvMicroTeachCaseRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvMicroTeachCaseRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvMicroTeachCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoENT.BrowseCount = objvMicroTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvMicroTeachCaseRelaInfoENT.ResourceOwner = objvMicroTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvMicroTeachCaseRelaInfoENT.ftpFileType = objvMicroTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvMicroTeachCaseRelaInfoENT.ftpFileSize = objvMicroTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvMicroTeachCaseRelaInfoENT.ftpResourceOwner = objvMicroTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroTeachCaseRelaInfoENT.FileOriginName = objvMicroTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvMicroTeachCaseRelaInfoENT.id_File = objvMicroTeachCaseRelaInfoENS.id_File; //文件流水号
objvMicroTeachCaseRelaInfoENT.FileName = objvMicroTeachCaseRelaInfoENS.FileName; //文件名称
objvMicroTeachCaseRelaInfoENT.FileType = objvMicroTeachCaseRelaInfoENS.FileType; //文件类型
objvMicroTeachCaseRelaInfoENT.SaveDate = objvMicroTeachCaseRelaInfoENS.SaveDate; //创建日期
objvMicroTeachCaseRelaInfoENT.FileSize = objvMicroTeachCaseRelaInfoENS.FileSize; //文件大小
objvMicroTeachCaseRelaInfoENT.SaveTime = objvMicroTeachCaseRelaInfoENS.SaveTime; //创建时间
objvMicroTeachCaseRelaInfoENT.id_MicroteachCase = objvMicroTeachCaseRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvMicroTeachCaseRelaInfoENT.MicroteachCaseName = objvMicroTeachCaseRelaInfoENS.MicroteachCaseName; //微格教学案例名称
objvMicroTeachCaseRelaInfoENT.id_FtpResource = objvMicroTeachCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvMicroTeachCaseRelaInfoENT.FtpResourceID = objvMicroTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvMicroTeachCaseRelaInfoENT.FileOriginalName = objvMicroTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvMicroTeachCaseRelaInfoENT.FileDirName = objvMicroTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvMicroTeachCaseRelaInfoENT.FileRename = objvMicroTeachCaseRelaInfoENS.FileRename; //文件新名
objvMicroTeachCaseRelaInfoENT.FileUpDate = objvMicroTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvMicroTeachCaseRelaInfoENT.FileUpTime = objvMicroTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvMicroTeachCaseRelaInfoENT.id_Resource = objvMicroTeachCaseRelaInfoENS.id_Resource; //资源流水号
objvMicroTeachCaseRelaInfoENT.ResourceID = objvMicroTeachCaseRelaInfoENS.ResourceID; //资源ID
objvMicroTeachCaseRelaInfoENT.SaveMode = objvMicroTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvMicroTeachCaseRelaInfoENT.id_ResourceType = objvMicroTeachCaseRelaInfoENS.id_ResourceType; //资源类型流水号
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
public static DataTable ToDataTable(List<clsvMicroTeachCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroTeachCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroTeachCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroTeachCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroTeachCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroTeachCaseRelaInfoEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroTeachCaseRelaInfoTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoTypeWApi没有刷新缓存机制(clsMicroTeachCaseRelaInfoTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroTeachCaseRelaInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoWApi没有刷新缓存机制(clsMicroTeachCaseRelaInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseWApi没有刷新缓存机制(clsMicroteachCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseTypeWApi没有刷新缓存机制(clsMicroteachCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeWApi没有刷新缓存机制(clsRsStuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillWApi没有刷新缓存机制(clsTeachSkillWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroTeachCaseRelaInfo");
//if (arrvMicroTeachCaseRelaInfoObjLst_Cache == null)
//{
//arrvMicroTeachCaseRelaInfoObjLst_Cache = await clsvMicroTeachCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroTeachCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvMicroTeachCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroTeachCaseRelaInfoEN._CurrTabName_S);
List<clsvMicroTeachCaseRelaInfoEN> arrvMicroTeachCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroTeachCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroTeachCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convMicroTeachCaseRelaInfo.Memo, Type.GetType("System.String"));
foreach (clsvMicroTeachCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convMicroTeachCaseRelaInfo.FuncModuleId] = objInFor[convMicroTeachCaseRelaInfo.FuncModuleId];
objDR[convMicroTeachCaseRelaInfo.FuncModuleName] = objInFor[convMicroTeachCaseRelaInfo.FuncModuleName];
objDR[convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convMicroTeachCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convMicroTeachCaseRelaInfo.BrowseCount] = objInFor[convMicroTeachCaseRelaInfo.BrowseCount];
objDR[convMicroTeachCaseRelaInfo.ResourceOwner] = objInFor[convMicroTeachCaseRelaInfo.ResourceOwner];
objDR[convMicroTeachCaseRelaInfo.ftpFileType] = objInFor[convMicroTeachCaseRelaInfo.ftpFileType];
objDR[convMicroTeachCaseRelaInfo.ftpFileSize] = objInFor[convMicroTeachCaseRelaInfo.ftpFileSize];
objDR[convMicroTeachCaseRelaInfo.ftpResourceOwner] = objInFor[convMicroTeachCaseRelaInfo.ftpResourceOwner];
objDR[convMicroTeachCaseRelaInfo.FileOriginName] = objInFor[convMicroTeachCaseRelaInfo.FileOriginName];
objDR[convMicroTeachCaseRelaInfo.id_File] = objInFor[convMicroTeachCaseRelaInfo.id_File];
objDR[convMicroTeachCaseRelaInfo.FileName] = objInFor[convMicroTeachCaseRelaInfo.FileName];
objDR[convMicroTeachCaseRelaInfo.FileType] = objInFor[convMicroTeachCaseRelaInfo.FileType];
objDR[convMicroTeachCaseRelaInfo.SaveDate] = objInFor[convMicroTeachCaseRelaInfo.SaveDate];
objDR[convMicroTeachCaseRelaInfo.FileSize] = objInFor[convMicroTeachCaseRelaInfo.FileSize];
objDR[convMicroTeachCaseRelaInfo.SaveTime] = objInFor[convMicroTeachCaseRelaInfo.SaveTime];
objDR[convMicroTeachCaseRelaInfo.id_MicroteachCase] = objInFor[convMicroTeachCaseRelaInfo.id_MicroteachCase];
objDR[convMicroTeachCaseRelaInfo.MicroteachCaseName] = objInFor[convMicroTeachCaseRelaInfo.MicroteachCaseName];
objDR[convMicroTeachCaseRelaInfo.id_FtpResource] = objInFor[convMicroTeachCaseRelaInfo.id_FtpResource];
objDR[convMicroTeachCaseRelaInfo.FtpResourceID] = objInFor[convMicroTeachCaseRelaInfo.FtpResourceID];
objDR[convMicroTeachCaseRelaInfo.FileOriginalName] = objInFor[convMicroTeachCaseRelaInfo.FileOriginalName];
objDR[convMicroTeachCaseRelaInfo.FileDirName] = objInFor[convMicroTeachCaseRelaInfo.FileDirName];
objDR[convMicroTeachCaseRelaInfo.FileRename] = objInFor[convMicroTeachCaseRelaInfo.FileRename];
objDR[convMicroTeachCaseRelaInfo.FileUpDate] = objInFor[convMicroTeachCaseRelaInfo.FileUpDate];
objDR[convMicroTeachCaseRelaInfo.FileUpTime] = objInFor[convMicroTeachCaseRelaInfo.FileUpTime];
objDR[convMicroTeachCaseRelaInfo.id_Resource] = objInFor[convMicroTeachCaseRelaInfo.id_Resource];
objDR[convMicroTeachCaseRelaInfo.ResourceID] = objInFor[convMicroTeachCaseRelaInfo.ResourceID];
objDR[convMicroTeachCaseRelaInfo.SaveMode] = objInFor[convMicroTeachCaseRelaInfo.SaveMode];
objDR[convMicroTeachCaseRelaInfo.id_ResourceType] = objInFor[convMicroTeachCaseRelaInfo.id_ResourceType];
objDR[convMicroTeachCaseRelaInfo.ResourceTypeID] = objInFor[convMicroTeachCaseRelaInfo.ResourceTypeID];
objDR[convMicroTeachCaseRelaInfo.ResourceTypeName] = objInFor[convMicroTeachCaseRelaInfo.ResourceTypeName];
objDR[convMicroTeachCaseRelaInfo.Flag] = objInFor[convMicroTeachCaseRelaInfo.Flag];
objDR[convMicroTeachCaseRelaInfo.FileNewName] = objInFor[convMicroTeachCaseRelaInfo.FileNewName];
objDR[convMicroTeachCaseRelaInfo.FileOldName] = objInFor[convMicroTeachCaseRelaInfo.FileOldName];
objDR[convMicroTeachCaseRelaInfo.IsExistFile] = objInFor[convMicroTeachCaseRelaInfo.IsExistFile];
objDR[convMicroTeachCaseRelaInfo.ResourceName] = objInFor[convMicroTeachCaseRelaInfo.ResourceName];
objDR[convMicroTeachCaseRelaInfo.IsVisible] = objInFor[convMicroTeachCaseRelaInfo.IsVisible];
objDR[convMicroTeachCaseRelaInfo.UpdDate] = objInFor[convMicroTeachCaseRelaInfo.UpdDate];
objDR[convMicroTeachCaseRelaInfo.UpdUser] = objInFor[convMicroTeachCaseRelaInfo.UpdUser];
objDR[convMicroTeachCaseRelaInfo.Memo] = objInFor[convMicroTeachCaseRelaInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}