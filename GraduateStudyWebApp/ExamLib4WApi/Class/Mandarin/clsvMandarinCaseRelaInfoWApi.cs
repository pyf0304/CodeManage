
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMandarinCaseRelaInfoWApi
 表名:vMandarinCaseRelaInfo(01120401)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:04
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播
 模块英文名:Mandarin
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
public static class clsvMandarinCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvMandarinCaseRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFuncModuleId(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMandarinCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMandarinCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMandarinCaseRelaInfo.FuncModuleId);
objvMandarinCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FuncModuleId) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFuncModuleName(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMandarinCaseRelaInfo.FuncModuleName);
objvMandarinCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FuncModuleName) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN Setid_MicroteachCase(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convMandarinCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMandarinCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMandarinCaseRelaInfo.id_MicroteachCase);
objvMandarinCaseRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.id_MicroteachCase) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetIsVisible(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMandarinCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.IsVisible) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN Setid_File(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convMandarinCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convMandarinCaseRelaInfo.id_File);
objvMandarinCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.id_File) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFileName(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convMandarinCaseRelaInfo.FileName);
objvMandarinCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FileName) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFileType(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convMandarinCaseRelaInfo.FileType);
objvMandarinCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FileType) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetSaveDate(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMandarinCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMandarinCaseRelaInfo.SaveDate);
objvMandarinCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.SaveDate) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFileSize(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMandarinCaseRelaInfo.FileSize);
objvMandarinCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FileSize) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetSaveTime(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMandarinCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMandarinCaseRelaInfo.SaveTime);
objvMandarinCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.SaveTime) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN Setid_FtpResource(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convMandarinCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convMandarinCaseRelaInfo.id_FtpResource);
objvMandarinCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.id_FtpResource) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFtpResourceID(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convMandarinCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMandarinCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMandarinCaseRelaInfo.FtpResourceID);
objvMandarinCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FtpResourceID) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFileOriginalName(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMandarinCaseRelaInfo.FileOriginalName);
objvMandarinCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FileOriginalName) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFileDirName(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMandarinCaseRelaInfo.FileDirName);
objvMandarinCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FileDirName) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFileRename(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMandarinCaseRelaInfo.FileRename);
objvMandarinCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FileRename) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFileUpDate(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMandarinCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMandarinCaseRelaInfo.FileUpDate);
objvMandarinCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FileUpDate) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFileUpTime(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMandarinCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMandarinCaseRelaInfo.FileUpTime);
objvMandarinCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FileUpTime) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN Setid_Resource(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convMandarinCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convMandarinCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convMandarinCaseRelaInfo.id_Resource);
objvMandarinCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.id_Resource) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetResourceID(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convMandarinCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convMandarinCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMandarinCaseRelaInfo.ResourceID);
objvMandarinCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.ResourceID) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetSaveMode(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvMandarinCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.SaveMode) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN Setid_ResourceType(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convMandarinCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convMandarinCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convMandarinCaseRelaInfo.id_ResourceType);
objvMandarinCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.id_ResourceType) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetResourceTypeID(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convMandarinCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMandarinCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMandarinCaseRelaInfo.ResourceTypeID);
objvMandarinCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.ResourceTypeID) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetResourceTypeName(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convMandarinCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMandarinCaseRelaInfo.ResourceTypeName);
objvMandarinCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.ResourceTypeName) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroTeachCaseRelaInfoType, convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
objvMandarinCaseRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroTeachCaseRelaInfoTypeID, convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroTeachCaseRelaInfoTypeName, convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetBrowseCount(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvMandarinCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.BrowseCount) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetResourceOwner(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convMandarinCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMandarinCaseRelaInfo.ResourceOwner);
objvMandarinCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.ResourceOwner) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetftpFileType(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMandarinCaseRelaInfo.ftpFileType);
objvMandarinCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.ftpFileType) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetftpFileSize(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMandarinCaseRelaInfo.ftpFileSize);
objvMandarinCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.ftpFileSize) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetftpResourceOwner(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMandarinCaseRelaInfo.ftpResourceOwner);
objvMandarinCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.ftpResourceOwner) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFileOriginName(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMandarinCaseRelaInfo.FileOriginName);
objvMandarinCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FileOriginName) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetMandarinCaseName(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strMandarinCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseName, 100, convMandarinCaseRelaInfo.MandarinCaseName);
objvMandarinCaseRelaInfoEN.MandarinCaseName = strMandarinCaseName; //普通话教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.MandarinCaseName) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.MandarinCaseName, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.MandarinCaseName] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFileNewName(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMandarinCaseRelaInfo.FileNewName);
objvMandarinCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FileNewName) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFileOldName(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMandarinCaseRelaInfo.FileOldName);
objvMandarinCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.FileOldName) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetIsExistFile(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvMandarinCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.IsExistFile) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetFlag(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convMandarinCaseRelaInfo.Flag);
objvMandarinCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.Flag) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetUpdDate(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMandarinCaseRelaInfo.UpdDate);
objvMandarinCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.UpdDate) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetUpdUser(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMandarinCaseRelaInfo.UpdUser);
objvMandarinCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.UpdUser) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN SetMemo(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMandarinCaseRelaInfo.Memo);
objvMandarinCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.Memo) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCaseRelaInfoEN Setid_MandarinCase(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN, string strid_MandarinCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MandarinCase, 8, convMandarinCaseRelaInfo.id_MandarinCase);
clsCheckSql.CheckFieldForeignKey(strid_MandarinCase, 8, convMandarinCaseRelaInfo.id_MandarinCase);
objvMandarinCaseRelaInfoEN.id_MandarinCase = strid_MandarinCase; //普通话案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convMandarinCaseRelaInfo.id_MandarinCase) == false)
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp.Add(convMandarinCaseRelaInfo.id_MandarinCase, strComparisonOp);
}
else
{
objvMandarinCaseRelaInfoEN.dicFldComparisonOp[convMandarinCaseRelaInfo.id_MandarinCase] = strComparisonOp;
}
}
return objvMandarinCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfo, objvMandarinCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FuncModuleId, objvMandarinCaseRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FuncModuleName, objvMandarinCaseRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.id_MicroteachCase, objvMandarinCaseRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.IsVisible) == true)
{
if (objvMandarinCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCaseRelaInfo.IsVisible);
}
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.id_File, objvMandarinCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FileName, objvMandarinCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FileType, objvMandarinCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.SaveDate, objvMandarinCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FileSize, objvMandarinCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.SaveTime, objvMandarinCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.id_FtpResource, objvMandarinCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FtpResourceID, objvMandarinCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FileOriginalName, objvMandarinCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FileDirName, objvMandarinCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FileRename, objvMandarinCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FileUpDate, objvMandarinCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FileUpTime, objvMandarinCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.id_Resource, objvMandarinCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.ResourceID, objvMandarinCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.SaveMode) == true)
{
if (objvMandarinCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCaseRelaInfo.SaveMode);
}
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.id_ResourceType, objvMandarinCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.ResourceTypeID, objvMandarinCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.ResourceTypeName, objvMandarinCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType, objvMandarinCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeID = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, objvMandarinCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeID, strComparisonOp_MicroTeachCaseRelaInfoTypeID);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvMandarinCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCaseRelaInfo.BrowseCount, objvMandarinCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.ResourceOwner, objvMandarinCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.ftpFileType, objvMandarinCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.ftpFileSize, objvMandarinCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.ftpResourceOwner, objvMandarinCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FileOriginName, objvMandarinCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.MandarinCaseName) == true)
{
string strComparisonOp_MandarinCaseName = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.MandarinCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.MandarinCaseName, objvMandarinCaseRelaInfo_Cond.MandarinCaseName, strComparisonOp_MandarinCaseName);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FileNewName, objvMandarinCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.FileOldName, objvMandarinCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.IsExistFile) == true)
{
if (objvMandarinCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCaseRelaInfo.IsExistFile);
}
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.Flag, objvMandarinCaseRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.UpdDate, objvMandarinCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.UpdUser, objvMandarinCaseRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.Memo, objvMandarinCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
if (objvMandarinCaseRelaInfo_Cond.IsUpdated(convMandarinCaseRelaInfo.id_MandarinCase) == true)
{
string strComparisonOp_id_MandarinCase = objvMandarinCaseRelaInfo_Cond.dicFldComparisonOp[convMandarinCaseRelaInfo.id_MandarinCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCaseRelaInfo.id_MandarinCase, objvMandarinCaseRelaInfo_Cond.id_MandarinCase, strComparisonOp_id_MandarinCase);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vMandarinCaseRelaInfo(vMandarinCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMandarinCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vMandarinCaseRelaInfoApi";

 public clsvMandarinCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMandarinCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN = null;
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
objvMandarinCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvMandarinCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCaseRelaInfoEN;
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
public static clsvMandarinCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN = null;
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
objvMandarinCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvMandarinCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCaseRelaInfoEN;
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
public static clsvMandarinCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN = null;
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
objvMandarinCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvMandarinCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCaseRelaInfoEN;
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
public static clsvMandarinCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMandarinCaseRelaInfoEN._CurrTabName_S);
List<clsvMandarinCaseRelaInfoEN> arrvMandarinCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMandarinCaseRelaInfoEN> arrvMandarinCaseRelaInfoObjLst_Sel =
from objvMandarinCaseRelaInfoEN in arrvMandarinCaseRelaInfoObjLst_Cache
where objvMandarinCaseRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvMandarinCaseRelaInfoEN;
if (arrvMandarinCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvMandarinCaseRelaInfoEN obj = clsvMandarinCaseRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMandarinCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMandarinCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvMandarinCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvMandarinCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvMandarinCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMandarinCaseRelaInfoEN._CurrTabName_S);
List<clsvMandarinCaseRelaInfoEN> arrvMandarinCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMandarinCaseRelaInfoEN> arrvMandarinCaseRelaInfoObjLst_Sel =
from objvMandarinCaseRelaInfoEN in arrvMandarinCaseRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvMandarinCaseRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvMandarinCaseRelaInfoEN;
return arrvMandarinCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMandarinCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvMandarinCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMandarinCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMandarinCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMandarinCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMandarinCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvMandarinCaseRelaInfoENS">源对象</param>
 /// <param name = "objvMandarinCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoENS, clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoENT)
{
try
{
objvMandarinCaseRelaInfoENT.id_MicroTeachCaseRelaInfo = objvMandarinCaseRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvMandarinCaseRelaInfoENT.FuncModuleId = objvMandarinCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvMandarinCaseRelaInfoENT.FuncModuleName = objvMandarinCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvMandarinCaseRelaInfoENT.id_MicroteachCase = objvMandarinCaseRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvMandarinCaseRelaInfoENT.IsVisible = objvMandarinCaseRelaInfoENS.IsVisible; //是否显示
objvMandarinCaseRelaInfoENT.id_File = objvMandarinCaseRelaInfoENS.id_File; //文件流水号
objvMandarinCaseRelaInfoENT.FileName = objvMandarinCaseRelaInfoENS.FileName; //文件名称
objvMandarinCaseRelaInfoENT.FileType = objvMandarinCaseRelaInfoENS.FileType; //文件类型
objvMandarinCaseRelaInfoENT.SaveDate = objvMandarinCaseRelaInfoENS.SaveDate; //创建日期
objvMandarinCaseRelaInfoENT.FileSize = objvMandarinCaseRelaInfoENS.FileSize; //文件大小
objvMandarinCaseRelaInfoENT.SaveTime = objvMandarinCaseRelaInfoENS.SaveTime; //创建时间
objvMandarinCaseRelaInfoENT.id_FtpResource = objvMandarinCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvMandarinCaseRelaInfoENT.FtpResourceID = objvMandarinCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvMandarinCaseRelaInfoENT.FileOriginalName = objvMandarinCaseRelaInfoENS.FileOriginalName; //文件原名
objvMandarinCaseRelaInfoENT.FileDirName = objvMandarinCaseRelaInfoENS.FileDirName; //文件目录名
objvMandarinCaseRelaInfoENT.FileRename = objvMandarinCaseRelaInfoENS.FileRename; //文件新名
objvMandarinCaseRelaInfoENT.FileUpDate = objvMandarinCaseRelaInfoENS.FileUpDate; //创建日期
objvMandarinCaseRelaInfoENT.FileUpTime = objvMandarinCaseRelaInfoENS.FileUpTime; //创建时间
objvMandarinCaseRelaInfoENT.id_Resource = objvMandarinCaseRelaInfoENS.id_Resource; //资源流水号
objvMandarinCaseRelaInfoENT.ResourceID = objvMandarinCaseRelaInfoENS.ResourceID; //资源ID
objvMandarinCaseRelaInfoENT.SaveMode = objvMandarinCaseRelaInfoENS.SaveMode; //文件存放方式
objvMandarinCaseRelaInfoENT.id_ResourceType = objvMandarinCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvMandarinCaseRelaInfoENT.ResourceTypeID = objvMandarinCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvMandarinCaseRelaInfoENT.ResourceTypeName = objvMandarinCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvMandarinCaseRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvMandarinCaseRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvMandarinCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvMandarinCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvMandarinCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvMandarinCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvMandarinCaseRelaInfoENT.BrowseCount = objvMandarinCaseRelaInfoENS.BrowseCount; //浏览次数
objvMandarinCaseRelaInfoENT.ResourceOwner = objvMandarinCaseRelaInfoENS.ResourceOwner; //上传者
objvMandarinCaseRelaInfoENT.ftpFileType = objvMandarinCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvMandarinCaseRelaInfoENT.ftpFileSize = objvMandarinCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvMandarinCaseRelaInfoENT.ftpResourceOwner = objvMandarinCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvMandarinCaseRelaInfoENT.FileOriginName = objvMandarinCaseRelaInfoENS.FileOriginName; //原文件名
objvMandarinCaseRelaInfoENT.MandarinCaseName = objvMandarinCaseRelaInfoENS.MandarinCaseName; //普通话教学案例名称
objvMandarinCaseRelaInfoENT.FileNewName = objvMandarinCaseRelaInfoENS.FileNewName; //新文件名
objvMandarinCaseRelaInfoENT.FileOldName = objvMandarinCaseRelaInfoENS.FileOldName; //旧文件名
objvMandarinCaseRelaInfoENT.IsExistFile = objvMandarinCaseRelaInfoENS.IsExistFile; //是否存在文件
objvMandarinCaseRelaInfoENT.Flag = objvMandarinCaseRelaInfoENS.Flag; //标志
objvMandarinCaseRelaInfoENT.UpdDate = objvMandarinCaseRelaInfoENS.UpdDate; //修改日期
objvMandarinCaseRelaInfoENT.UpdUser = objvMandarinCaseRelaInfoENS.UpdUser; //修改人
objvMandarinCaseRelaInfoENT.Memo = objvMandarinCaseRelaInfoENS.Memo; //备注
objvMandarinCaseRelaInfoENT.id_MandarinCase = objvMandarinCaseRelaInfoENS.id_MandarinCase; //普通话案例流水号
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
public static DataTable ToDataTable(List<clsvMandarinCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMandarinCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMandarinCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMandarinCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMandarinCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMandarinCaseRelaInfoEN.AttributeName)
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
if (clsMandarinCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMandarinCaseWApi没有刷新缓存机制(clsMandarinCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMandarinCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMandarinCaseTypeWApi没有刷新缓存机制(clsMandarinCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvMandarinCaseRelaInfoObjLst_Cache == null)
//{
//arrvMandarinCaseRelaInfoObjLst_Cache = await clsvMandarinCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMandarinCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvMandarinCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMandarinCaseRelaInfoEN._CurrTabName_S);
List<clsvMandarinCaseRelaInfoEN> arrvMandarinCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMandarinCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMandarinCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convMandarinCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.MandarinCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCaseRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCaseRelaInfo.id_MandarinCase, Type.GetType("System.String"));
foreach (clsvMandarinCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convMandarinCaseRelaInfo.FuncModuleId] = objInFor[convMandarinCaseRelaInfo.FuncModuleId];
objDR[convMandarinCaseRelaInfo.FuncModuleName] = objInFor[convMandarinCaseRelaInfo.FuncModuleName];
objDR[convMandarinCaseRelaInfo.id_MicroteachCase] = objInFor[convMandarinCaseRelaInfo.id_MicroteachCase];
objDR[convMandarinCaseRelaInfo.IsVisible] = objInFor[convMandarinCaseRelaInfo.IsVisible];
objDR[convMandarinCaseRelaInfo.id_File] = objInFor[convMandarinCaseRelaInfo.id_File];
objDR[convMandarinCaseRelaInfo.FileName] = objInFor[convMandarinCaseRelaInfo.FileName];
objDR[convMandarinCaseRelaInfo.FileType] = objInFor[convMandarinCaseRelaInfo.FileType];
objDR[convMandarinCaseRelaInfo.SaveDate] = objInFor[convMandarinCaseRelaInfo.SaveDate];
objDR[convMandarinCaseRelaInfo.FileSize] = objInFor[convMandarinCaseRelaInfo.FileSize];
objDR[convMandarinCaseRelaInfo.SaveTime] = objInFor[convMandarinCaseRelaInfo.SaveTime];
objDR[convMandarinCaseRelaInfo.id_FtpResource] = objInFor[convMandarinCaseRelaInfo.id_FtpResource];
objDR[convMandarinCaseRelaInfo.FtpResourceID] = objInFor[convMandarinCaseRelaInfo.FtpResourceID];
objDR[convMandarinCaseRelaInfo.FileOriginalName] = objInFor[convMandarinCaseRelaInfo.FileOriginalName];
objDR[convMandarinCaseRelaInfo.FileDirName] = objInFor[convMandarinCaseRelaInfo.FileDirName];
objDR[convMandarinCaseRelaInfo.FileRename] = objInFor[convMandarinCaseRelaInfo.FileRename];
objDR[convMandarinCaseRelaInfo.FileUpDate] = objInFor[convMandarinCaseRelaInfo.FileUpDate];
objDR[convMandarinCaseRelaInfo.FileUpTime] = objInFor[convMandarinCaseRelaInfo.FileUpTime];
objDR[convMandarinCaseRelaInfo.id_Resource] = objInFor[convMandarinCaseRelaInfo.id_Resource];
objDR[convMandarinCaseRelaInfo.ResourceID] = objInFor[convMandarinCaseRelaInfo.ResourceID];
objDR[convMandarinCaseRelaInfo.SaveMode] = objInFor[convMandarinCaseRelaInfo.SaveMode];
objDR[convMandarinCaseRelaInfo.id_ResourceType] = objInFor[convMandarinCaseRelaInfo.id_ResourceType];
objDR[convMandarinCaseRelaInfo.ResourceTypeID] = objInFor[convMandarinCaseRelaInfo.ResourceTypeID];
objDR[convMandarinCaseRelaInfo.ResourceTypeName] = objInFor[convMandarinCaseRelaInfo.ResourceTypeName];
objDR[convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convMandarinCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = objInFor[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
objDR[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convMandarinCaseRelaInfo.BrowseCount] = objInFor[convMandarinCaseRelaInfo.BrowseCount];
objDR[convMandarinCaseRelaInfo.ResourceOwner] = objInFor[convMandarinCaseRelaInfo.ResourceOwner];
objDR[convMandarinCaseRelaInfo.ftpFileType] = objInFor[convMandarinCaseRelaInfo.ftpFileType];
objDR[convMandarinCaseRelaInfo.ftpFileSize] = objInFor[convMandarinCaseRelaInfo.ftpFileSize];
objDR[convMandarinCaseRelaInfo.ftpResourceOwner] = objInFor[convMandarinCaseRelaInfo.ftpResourceOwner];
objDR[convMandarinCaseRelaInfo.FileOriginName] = objInFor[convMandarinCaseRelaInfo.FileOriginName];
objDR[convMandarinCaseRelaInfo.MandarinCaseName] = objInFor[convMandarinCaseRelaInfo.MandarinCaseName];
objDR[convMandarinCaseRelaInfo.FileNewName] = objInFor[convMandarinCaseRelaInfo.FileNewName];
objDR[convMandarinCaseRelaInfo.FileOldName] = objInFor[convMandarinCaseRelaInfo.FileOldName];
objDR[convMandarinCaseRelaInfo.IsExistFile] = objInFor[convMandarinCaseRelaInfo.IsExistFile];
objDR[convMandarinCaseRelaInfo.Flag] = objInFor[convMandarinCaseRelaInfo.Flag];
objDR[convMandarinCaseRelaInfo.UpdDate] = objInFor[convMandarinCaseRelaInfo.UpdDate];
objDR[convMandarinCaseRelaInfo.UpdUser] = objInFor[convMandarinCaseRelaInfo.UpdUser];
objDR[convMandarinCaseRelaInfo.Memo] = objInFor[convMandarinCaseRelaInfo.Memo];
objDR[convMandarinCaseRelaInfo.id_MandarinCase] = objInFor[convMandarinCaseRelaInfo.id_MandarinCase];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}