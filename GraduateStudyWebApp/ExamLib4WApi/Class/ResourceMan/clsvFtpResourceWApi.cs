
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFtpResourceWApi
 表名:vFtpResource(01120500)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:56
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
public static class clsvFtpResourceWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN Setid_FtpResource(this clsvFtpResourceEN objvFtpResourceEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convFtpResource.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convFtpResource.id_FtpResource);
objvFtpResourceEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.id_FtpResource) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.id_FtpResource, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.id_FtpResource] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFtpResourceID(this clsvFtpResourceEN objvFtpResourceEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convFtpResource.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convFtpResource.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convFtpResource.FtpResourceID);
objvFtpResourceEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FtpResourceID) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FtpResourceID, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FtpResourceID] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFileOriginalName(this clsvFtpResourceEN objvFtpResourceEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convFtpResource.FileOriginalName);
objvFtpResourceEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileOriginalName) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileOriginalName, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileOriginalName] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFileDirName(this clsvFtpResourceEN objvFtpResourceEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convFtpResource.FileDirName);
objvFtpResourceEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileDirName) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileDirName, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileDirName] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFileRename(this clsvFtpResourceEN objvFtpResourceEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convFtpResource.FileRename);
objvFtpResourceEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileRename) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileRename, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileRename] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFileName_Bak(this clsvFtpResourceEN objvFtpResourceEN, string strFileName_Bak, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName_Bak, 500, convFtpResource.FileName_Bak);
objvFtpResourceEN.FileName_Bak = strFileName_Bak; //FileName_Bak
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileName_Bak) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileName_Bak, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileName_Bak] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFileUpDate(this clsvFtpResourceEN objvFtpResourceEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convFtpResource.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convFtpResource.FileUpDate);
objvFtpResourceEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileUpDate) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileUpDate, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileUpDate] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFileUpTime(this clsvFtpResourceEN objvFtpResourceEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convFtpResource.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convFtpResource.FileUpTime);
objvFtpResourceEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileUpTime) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileUpTime, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileUpTime] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFileSize(this clsvFtpResourceEN objvFtpResourceEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convFtpResource.FileSize);
objvFtpResourceEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileSize) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileSize, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileSize] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFileType(this clsvFtpResourceEN objvFtpResourceEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convFtpResource.FileType);
objvFtpResourceEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileType) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileType, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileType] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFuncModuleId(this clsvFtpResourceEN objvFtpResourceEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convFtpResource.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convFtpResource.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convFtpResource.FuncModuleId);
objvFtpResourceEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FuncModuleId) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FuncModuleId, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FuncModuleId] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFuncModuleName(this clsvFtpResourceEN objvFtpResourceEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convFtpResource.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convFtpResource.FuncModuleName);
objvFtpResourceEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FuncModuleName) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FuncModuleName, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FuncModuleName] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFuncModuleName_Sim(this clsvFtpResourceEN objvFtpResourceEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convFtpResource.FuncModuleName_Sim);
objvFtpResourceEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FuncModuleName_Sim) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetOrderNum(this clsvFtpResourceEN objvFtpResourceEN, int intOrderNum, string strComparisonOp="")
	{
objvFtpResourceEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.OrderNum) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.OrderNum, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.OrderNum] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetCheckDateTime(this clsvFtpResourceEN objvFtpResourceEN, string strCheckDateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckDateTime, 30, convFtpResource.CheckDateTime);
objvFtpResourceEN.CheckDateTime = strCheckDateTime; //CheckDateTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.CheckDateTime) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.CheckDateTime, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.CheckDateTime] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetResourceOwner(this clsvFtpResourceEN objvFtpResourceEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convFtpResource.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convFtpResource.ResourceOwner);
objvFtpResourceEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.ResourceOwner) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.ResourceOwner, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.ResourceOwner] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetIsExistFile(this clsvFtpResourceEN objvFtpResourceEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvFtpResourceEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.IsExistFile) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.IsExistFile, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.IsExistFile] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetFileResourceID(this clsvFtpResourceEN objvFtpResourceEN, long lngFileResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngFileResourceID, convFtpResource.FileResourceID);
objvFtpResourceEN.FileResourceID = lngFileResourceID; //FileResourceID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileResourceID) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileResourceID, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileResourceID] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetUpdDate(this clsvFtpResourceEN objvFtpResourceEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFtpResource.UpdDate);
objvFtpResourceEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.UpdDate) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.UpdDate, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.UpdDate] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetUpdUser(this clsvFtpResourceEN objvFtpResourceEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFtpResource.UpdUser);
objvFtpResourceEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.UpdUser) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.UpdUser, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.UpdUser] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFtpResourceEN SetMemo(this clsvFtpResourceEN objvFtpResourceEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFtpResource.Memo);
objvFtpResourceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.Memo) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.Memo, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.Memo] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFtpResourceEN objvFtpResource_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFtpResource_Cond.IsUpdated(convFtpResource.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.id_FtpResource, objvFtpResource_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FtpResourceID, objvFtpResource_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileOriginalName, objvFtpResource_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileDirName, objvFtpResource_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FileRename) == true)
{
string strComparisonOp_FileRename = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileRename, objvFtpResource_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FileName_Bak) == true)
{
string strComparisonOp_FileName_Bak = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FileName_Bak];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileName_Bak, objvFtpResource_Cond.FileName_Bak, strComparisonOp_FileName_Bak);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileUpDate, objvFtpResource_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileUpTime, objvFtpResource_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FileSize) == true)
{
string strComparisonOp_FileSize = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileSize, objvFtpResource_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FileType) == true)
{
string strComparisonOp_FileType = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileType, objvFtpResource_Cond.FileType, strComparisonOp_FileType);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FuncModuleId, objvFtpResource_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FuncModuleName, objvFtpResource_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FuncModuleName_Sim, objvFtpResource_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResource.OrderNum, objvFtpResource_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.CheckDateTime) == true)
{
string strComparisonOp_CheckDateTime = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.CheckDateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.CheckDateTime, objvFtpResource_Cond.CheckDateTime, strComparisonOp_CheckDateTime);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.ResourceOwner, objvFtpResource_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.IsExistFile) == true)
{
if (objvFtpResource_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFtpResource.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFtpResource.IsExistFile);
}
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.FileResourceID) == true)
{
string strComparisonOp_FileResourceID = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.FileResourceID];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResource.FileResourceID, objvFtpResource_Cond.FileResourceID, strComparisonOp_FileResourceID);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.UpdDate, objvFtpResource_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.UpdUser, objvFtpResource_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvFtpResource_Cond.IsUpdated(convFtpResource.Memo) == true)
{
string strComparisonOp_Memo = objvFtpResource_Cond.dicFldComparisonOp[convFtpResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.Memo, objvFtpResource_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vFTP资源(vFtpResource)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFtpResourceWApi
{
private static readonly string mstrApiControllerName = "vFtpResourceApi";

 public clsvFtpResourceWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_FtpResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFtpResourceEN GetObjByid_FtpResource(string strid_FtpResource)
{
string strAction = "GetObjByid_FtpResource";
string strErrMsg = string.Empty;
string strResult = "";
clsvFtpResourceEN objvFtpResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_FtpResource"] = strid_FtpResource
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvFtpResourceEN = JsonConvert.DeserializeObject<clsvFtpResourceEN>((string)jobjReturn["ReturnObj"]);
return objvFtpResourceEN;
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
 /// <param name = "strid_FtpResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFtpResourceEN GetObjByid_FtpResource_WA_Cache(string strid_FtpResource)
{
string strAction = "GetObjByid_FtpResource_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvFtpResourceEN objvFtpResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_FtpResource"] = strid_FtpResource
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvFtpResourceEN = JsonConvert.DeserializeObject<clsvFtpResourceEN>((string)jobjReturn["ReturnObj"]);
return objvFtpResourceEN;
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
public static clsvFtpResourceEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvFtpResourceEN objvFtpResourceEN = null;
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
objvFtpResourceEN = JsonConvert.DeserializeObject<clsvFtpResourceEN>((string)jobjReturn["ReturnObj"]);
return objvFtpResourceEN;
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
 /// <param name = "strid_FtpResource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFtpResourceEN GetObjByid_FtpResource_Cache(string strid_FtpResource)
{
if (string.IsNullOrEmpty(strid_FtpResource) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvFtpResourceEN._CurrTabName_S);
List<clsvFtpResourceEN> arrvFtpResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvFtpResourceEN> arrvFtpResourceObjLst_Sel =
from objvFtpResourceEN in arrvFtpResourceObjLst_Cache
where objvFtpResourceEN.id_FtpResource == strid_FtpResource
select objvFtpResourceEN;
if (arrvFtpResourceObjLst_Sel.Count() == 0)
{
   clsvFtpResourceEN obj = clsvFtpResourceWApi.GetObjByid_FtpResource(strid_FtpResource);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFtpResourceObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLst(string strWhereCond)
{
 List<clsvFtpResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFtpResourceEN> GetObjLstById_FtpResourceLst(List<string> arrId_FtpResource)
{
 List<clsvFtpResourceEN> arrObjLst = null; 
string strAction = "GetObjLstById_FtpResourceLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_FtpResource);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_FtpResource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvFtpResourceEN> GetObjLstById_FtpResourceLst_Cache(List<string> arrId_FtpResource)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFtpResourceEN._CurrTabName_S);
List<clsvFtpResourceEN> arrvFtpResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvFtpResourceEN> arrvFtpResourceObjLst_Sel =
from objvFtpResourceEN in arrvFtpResourceObjLst_Cache
where arrId_FtpResource.Contains(objvFtpResourceEN.id_FtpResource)
select objvFtpResourceEN;
return arrvFtpResourceObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLstById_FtpResourceLst_WA_Cache(List<string> arrId_FtpResource)
{
 List<clsvFtpResourceEN> arrObjLst = null; 
string strAction = "GetObjLstById_FtpResourceLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_FtpResource);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFtpResourceEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFtpResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFtpResourceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFtpResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFtpResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFtpResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFtpResourceEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvFtpResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFtpResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_FtpResource)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_FtpResource"] = strid_FtpResource
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
 /// <param name = "objvFtpResourceENS">源对象</param>
 /// <param name = "objvFtpResourceENT">目标对象</param>
 public static void CopyTo(clsvFtpResourceEN objvFtpResourceENS, clsvFtpResourceEN objvFtpResourceENT)
{
try
{
objvFtpResourceENT.id_FtpResource = objvFtpResourceENS.id_FtpResource; //FTP资源流水号
objvFtpResourceENT.FtpResourceID = objvFtpResourceENS.FtpResourceID; //FTP资源ID
objvFtpResourceENT.FileOriginalName = objvFtpResourceENS.FileOriginalName; //文件原名
objvFtpResourceENT.FileDirName = objvFtpResourceENS.FileDirName; //文件目录名
objvFtpResourceENT.FileRename = objvFtpResourceENS.FileRename; //文件新名
objvFtpResourceENT.FileName_Bak = objvFtpResourceENS.FileName_Bak; //FileName_Bak
objvFtpResourceENT.FileUpDate = objvFtpResourceENS.FileUpDate; //创建日期
objvFtpResourceENT.FileUpTime = objvFtpResourceENS.FileUpTime; //创建时间
objvFtpResourceENT.FileSize = objvFtpResourceENS.FileSize; //文件大小
objvFtpResourceENT.FileType = objvFtpResourceENS.FileType; //文件类型
objvFtpResourceENT.FuncModuleId = objvFtpResourceENS.FuncModuleId; //功能模块Id
objvFtpResourceENT.FuncModuleName = objvFtpResourceENS.FuncModuleName; //功能模块名称
objvFtpResourceENT.FuncModuleName_Sim = objvFtpResourceENS.FuncModuleName_Sim; //功能模块简称
objvFtpResourceENT.OrderNum = objvFtpResourceENS.OrderNum; //序号
objvFtpResourceENT.CheckDateTime = objvFtpResourceENS.CheckDateTime; //CheckDateTime
objvFtpResourceENT.ResourceOwner = objvFtpResourceENS.ResourceOwner; //上传者
objvFtpResourceENT.IsExistFile = objvFtpResourceENS.IsExistFile; //是否存在文件
objvFtpResourceENT.FileResourceID = objvFtpResourceENS.FileResourceID; //FileResourceID
objvFtpResourceENT.UpdDate = objvFtpResourceENS.UpdDate; //修改日期
objvFtpResourceENT.UpdUser = objvFtpResourceENS.UpdUser; //修改人
objvFtpResourceENT.Memo = objvFtpResourceENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvFtpResourceEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFtpResourceEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFtpResourceEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFtpResourceEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFtpResourceEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFtpResourceEN.AttributeName)
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
if (clsFtpResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceWApi没有刷新缓存机制(clsFtpResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_FtpResource");
//if (arrvFtpResourceObjLst_Cache == null)
//{
//arrvFtpResourceObjLst_Cache = await clsvFtpResourceWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvFtpResourceEN._CurrTabName_S);
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
public static List<clsvFtpResourceEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvFtpResourceEN._CurrTabName_S);
List<clsvFtpResourceEN> arrvFtpResourceObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFtpResourceObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFtpResourceEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFtpResource.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FileName_Bak, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFtpResource.CheckDateTime, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFtpResource.FileResourceID, Type.GetType("System.Int64"));
objDT.Columns.Add(convFtpResource.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFtpResource.Memo, Type.GetType("System.String"));
foreach (clsvFtpResourceEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFtpResource.id_FtpResource] = objInFor[convFtpResource.id_FtpResource];
objDR[convFtpResource.FtpResourceID] = objInFor[convFtpResource.FtpResourceID];
objDR[convFtpResource.FileOriginalName] = objInFor[convFtpResource.FileOriginalName];
objDR[convFtpResource.FileDirName] = objInFor[convFtpResource.FileDirName];
objDR[convFtpResource.FileRename] = objInFor[convFtpResource.FileRename];
objDR[convFtpResource.FileName_Bak] = objInFor[convFtpResource.FileName_Bak];
objDR[convFtpResource.FileUpDate] = objInFor[convFtpResource.FileUpDate];
objDR[convFtpResource.FileUpTime] = objInFor[convFtpResource.FileUpTime];
objDR[convFtpResource.FileSize] = objInFor[convFtpResource.FileSize];
objDR[convFtpResource.FileType] = objInFor[convFtpResource.FileType];
objDR[convFtpResource.FuncModuleId] = objInFor[convFtpResource.FuncModuleId];
objDR[convFtpResource.FuncModuleName] = objInFor[convFtpResource.FuncModuleName];
objDR[convFtpResource.FuncModuleName_Sim] = objInFor[convFtpResource.FuncModuleName_Sim];
objDR[convFtpResource.OrderNum] = objInFor[convFtpResource.OrderNum];
objDR[convFtpResource.CheckDateTime] = objInFor[convFtpResource.CheckDateTime];
objDR[convFtpResource.ResourceOwner] = objInFor[convFtpResource.ResourceOwner];
objDR[convFtpResource.IsExistFile] = objInFor[convFtpResource.IsExistFile];
objDR[convFtpResource.FileResourceID] = objInFor[convFtpResource.FileResourceID];
objDR[convFtpResource.UpdDate] = objInFor[convFtpResource.UpdDate];
objDR[convFtpResource.UpdUser] = objInFor[convFtpResource.UpdUser];
objDR[convFtpResource.Memo] = objInFor[convFtpResource.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}