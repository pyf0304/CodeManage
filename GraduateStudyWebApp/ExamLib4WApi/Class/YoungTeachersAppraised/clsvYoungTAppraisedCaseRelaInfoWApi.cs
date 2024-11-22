
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCaseRelaInfoWApi
 表名:vYoungTAppraisedCaseRelaInfo(01120396)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:47
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优
 模块英文名:YoungTeachersAppraised
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
public static class clsvYoungTAppraisedCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvYoungTAppraisedCaseRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetIsVisible(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvYoungTAppraisedCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.IsVisible) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN Setid_File(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convYoungTAppraisedCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convYoungTAppraisedCaseRelaInfo.id_File);
objvYoungTAppraisedCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.id_File) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFileName(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convYoungTAppraisedCaseRelaInfo.FileName);
objvYoungTAppraisedCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FileName) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFileType(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convYoungTAppraisedCaseRelaInfo.FileType);
objvYoungTAppraisedCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FileType) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetSaveDate(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convYoungTAppraisedCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convYoungTAppraisedCaseRelaInfo.SaveDate);
objvYoungTAppraisedCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.SaveDate) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFileSize(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convYoungTAppraisedCaseRelaInfo.FileSize);
objvYoungTAppraisedCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FileSize) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetSaveTime(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convYoungTAppraisedCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convYoungTAppraisedCaseRelaInfo.SaveTime);
objvYoungTAppraisedCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.SaveTime) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN Setid_FtpResource(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convYoungTAppraisedCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convYoungTAppraisedCaseRelaInfo.id_FtpResource);
objvYoungTAppraisedCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.id_FtpResource) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFtpResourceID(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convYoungTAppraisedCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convYoungTAppraisedCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convYoungTAppraisedCaseRelaInfo.FtpResourceID);
objvYoungTAppraisedCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FtpResourceID) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFileOriginalName(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convYoungTAppraisedCaseRelaInfo.FileOriginalName);
objvYoungTAppraisedCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FileOriginalName) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFileDirName(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convYoungTAppraisedCaseRelaInfo.FileDirName);
objvYoungTAppraisedCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FileDirName) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFileRename(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convYoungTAppraisedCaseRelaInfo.FileRename);
objvYoungTAppraisedCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FileRename) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFileUpDate(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convYoungTAppraisedCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convYoungTAppraisedCaseRelaInfo.FileUpDate);
objvYoungTAppraisedCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FileUpDate) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFileUpTime(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convYoungTAppraisedCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convYoungTAppraisedCaseRelaInfo.FileUpTime);
objvYoungTAppraisedCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FileUpTime) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN Setid_Resource(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convYoungTAppraisedCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convYoungTAppraisedCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convYoungTAppraisedCaseRelaInfo.id_Resource);
objvYoungTAppraisedCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.id_Resource) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetResourceID(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convYoungTAppraisedCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convYoungTAppraisedCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convYoungTAppraisedCaseRelaInfo.ResourceID);
objvYoungTAppraisedCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.ResourceID) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetSaveMode(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvYoungTAppraisedCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.SaveMode) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN Setid_ResourceType(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convYoungTAppraisedCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convYoungTAppraisedCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convYoungTAppraisedCaseRelaInfo.id_ResourceType);
objvYoungTAppraisedCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.id_ResourceType) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetResourceTypeID(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convYoungTAppraisedCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convYoungTAppraisedCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convYoungTAppraisedCaseRelaInfo.ResourceTypeID);
objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.ResourceTypeID) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetResourceTypeName(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convYoungTAppraisedCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convYoungTAppraisedCaseRelaInfo.ResourceTypeName);
objvYoungTAppraisedCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.ResourceTypeName) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroTeachCaseRelaInfoType, convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
objvYoungTAppraisedCaseRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroTeachCaseRelaInfoTypeName, convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetBrowseCount(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvYoungTAppraisedCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.BrowseCount) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetResourceOwner(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convYoungTAppraisedCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convYoungTAppraisedCaseRelaInfo.ResourceOwner);
objvYoungTAppraisedCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.ResourceOwner) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetftpFileType(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convYoungTAppraisedCaseRelaInfo.ftpFileType);
objvYoungTAppraisedCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.ftpFileType) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetftpFileSize(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convYoungTAppraisedCaseRelaInfo.ftpFileSize);
objvYoungTAppraisedCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.ftpFileSize) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetftpResourceOwner(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convYoungTAppraisedCaseRelaInfo.ftpResourceOwner);
objvYoungTAppraisedCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.ftpResourceOwner) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFileOriginName(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convYoungTAppraisedCaseRelaInfo.FileOriginName);
objvYoungTAppraisedCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FileOriginName) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN Setid_YoungTAppraisedCase(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strid_YoungTAppraisedCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_YoungTAppraisedCase, convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase);
clsCheckSql.CheckFieldLen(strid_YoungTAppraisedCase, 8, convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase);
clsCheckSql.CheckFieldForeignKey(strid_YoungTAppraisedCase, 8, convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase);
objvYoungTAppraisedCaseRelaInfoEN.id_YoungTAppraisedCase = strid_YoungTAppraisedCase; //青教评优案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetYoungTAppraisedCaseName(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strYoungTAppraisedCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strYoungTAppraisedCaseName, convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(strYoungTAppraisedCaseName, 100, convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName);
objvYoungTAppraisedCaseRelaInfoEN.YoungTAppraisedCaseName = strYoungTAppraisedCaseName; //青教评优案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFlag(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convYoungTAppraisedCaseRelaInfo.Flag);
objvYoungTAppraisedCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.Flag) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFileNewName(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convYoungTAppraisedCaseRelaInfo.FileNewName);
objvYoungTAppraisedCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FileNewName) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFileOldName(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convYoungTAppraisedCaseRelaInfo.FileOldName);
objvYoungTAppraisedCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FileOldName) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetIsExistFile(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvYoungTAppraisedCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.IsExistFile) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFuncModuleId(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convYoungTAppraisedCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convYoungTAppraisedCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convYoungTAppraisedCaseRelaInfo.FuncModuleId);
objvYoungTAppraisedCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FuncModuleId) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetFuncModuleName(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convYoungTAppraisedCaseRelaInfo.FuncModuleName);
objvYoungTAppraisedCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.FuncModuleName) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN Setid_MicroteachCase(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convYoungTAppraisedCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convYoungTAppraisedCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convYoungTAppraisedCaseRelaInfo.id_MicroteachCase);
objvYoungTAppraisedCaseRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.id_MicroteachCase) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
objvYoungTAppraisedCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetUpdDate(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convYoungTAppraisedCaseRelaInfo.UpdDate);
objvYoungTAppraisedCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.UpdDate) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetUpdUser(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convYoungTAppraisedCaseRelaInfo.UpdUser);
objvYoungTAppraisedCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.UpdUser) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN SetMemo(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convYoungTAppraisedCaseRelaInfo.Memo);
objvYoungTAppraisedCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convYoungTAppraisedCaseRelaInfo.Memo) == false)
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp.Add(convYoungTAppraisedCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvYoungTAppraisedCaseRelaInfoEN.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvYoungTAppraisedCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfo, objvYoungTAppraisedCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.IsVisible) == true)
{
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCaseRelaInfo.IsVisible);
}
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.id_File, objvYoungTAppraisedCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FileName, objvYoungTAppraisedCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FileType, objvYoungTAppraisedCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.SaveDate, objvYoungTAppraisedCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FileSize, objvYoungTAppraisedCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.SaveTime, objvYoungTAppraisedCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.id_FtpResource, objvYoungTAppraisedCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FtpResourceID, objvYoungTAppraisedCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FileOriginalName, objvYoungTAppraisedCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FileDirName, objvYoungTAppraisedCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FileRename, objvYoungTAppraisedCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FileUpDate, objvYoungTAppraisedCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FileUpTime, objvYoungTAppraisedCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.id_Resource, objvYoungTAppraisedCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.ResourceID, objvYoungTAppraisedCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.SaveMode) == true)
{
if (objvYoungTAppraisedCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCaseRelaInfo.SaveMode);
}
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.id_ResourceType, objvYoungTAppraisedCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.ResourceTypeID, objvYoungTAppraisedCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.ResourceTypeName, objvYoungTAppraisedCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType, objvYoungTAppraisedCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvYoungTAppraisedCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convYoungTAppraisedCaseRelaInfo.BrowseCount, objvYoungTAppraisedCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.ResourceOwner, objvYoungTAppraisedCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.ftpFileType, objvYoungTAppraisedCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.ftpFileSize, objvYoungTAppraisedCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.ftpResourceOwner, objvYoungTAppraisedCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FileOriginName, objvYoungTAppraisedCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase) == true)
{
string strComparisonOp_id_YoungTAppraisedCase = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase, objvYoungTAppraisedCaseRelaInfo_Cond.id_YoungTAppraisedCase, strComparisonOp_id_YoungTAppraisedCase);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName) == true)
{
string strComparisonOp_YoungTAppraisedCaseName = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName, objvYoungTAppraisedCaseRelaInfo_Cond.YoungTAppraisedCaseName, strComparisonOp_YoungTAppraisedCaseName);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.Flag, objvYoungTAppraisedCaseRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FileNewName, objvYoungTAppraisedCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FileOldName, objvYoungTAppraisedCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.IsExistFile) == true)
{
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convYoungTAppraisedCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convYoungTAppraisedCaseRelaInfo.IsExistFile);
}
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FuncModuleId, objvYoungTAppraisedCaseRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.FuncModuleName, objvYoungTAppraisedCaseRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.id_MicroteachCase, objvYoungTAppraisedCaseRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeID = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, objvYoungTAppraisedCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeID, strComparisonOp_MicroTeachCaseRelaInfoTypeID);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.UpdDate, objvYoungTAppraisedCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.UpdUser, objvYoungTAppraisedCaseRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvYoungTAppraisedCaseRelaInfo_Cond.IsUpdated(convYoungTAppraisedCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvYoungTAppraisedCaseRelaInfo_Cond.dicFldComparisonOp[convYoungTAppraisedCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convYoungTAppraisedCaseRelaInfo.Memo, objvYoungTAppraisedCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vYoungTAppraisedCaseRelaInfo(vYoungTAppraisedCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvYoungTAppraisedCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vYoungTAppraisedCaseRelaInfoApi";

 public clsvYoungTAppraisedCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvYoungTAppraisedCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN = null;
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
objvYoungTAppraisedCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCaseRelaInfoEN;
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
public static clsvYoungTAppraisedCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN = null;
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
objvYoungTAppraisedCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCaseRelaInfoEN;
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
public static clsvYoungTAppraisedCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoEN = null;
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
objvYoungTAppraisedCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvYoungTAppraisedCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvYoungTAppraisedCaseRelaInfoEN;
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
public static clsvYoungTAppraisedCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseRelaInfoEN._CurrTabName_S);
List<clsvYoungTAppraisedCaseRelaInfoEN> arrvYoungTAppraisedCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvYoungTAppraisedCaseRelaInfoEN> arrvYoungTAppraisedCaseRelaInfoObjLst_Sel =
from objvYoungTAppraisedCaseRelaInfoEN in arrvYoungTAppraisedCaseRelaInfoObjLst_Cache
where objvYoungTAppraisedCaseRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvYoungTAppraisedCaseRelaInfoEN;
if (arrvYoungTAppraisedCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvYoungTAppraisedCaseRelaInfoEN obj = clsvYoungTAppraisedCaseRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvYoungTAppraisedCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvYoungTAppraisedCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvYoungTAppraisedCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvYoungTAppraisedCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvYoungTAppraisedCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseRelaInfoEN._CurrTabName_S);
List<clsvYoungTAppraisedCaseRelaInfoEN> arrvYoungTAppraisedCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvYoungTAppraisedCaseRelaInfoEN> arrvYoungTAppraisedCaseRelaInfoObjLst_Sel =
from objvYoungTAppraisedCaseRelaInfoEN in arrvYoungTAppraisedCaseRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvYoungTAppraisedCaseRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvYoungTAppraisedCaseRelaInfoEN;
return arrvYoungTAppraisedCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvYoungTAppraisedCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvYoungTAppraisedCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvYoungTAppraisedCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvYoungTAppraisedCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvYoungTAppraisedCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvYoungTAppraisedCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvYoungTAppraisedCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvYoungTAppraisedCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvYoungTAppraisedCaseRelaInfoENS">源对象</param>
 /// <param name = "objvYoungTAppraisedCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoENS, clsvYoungTAppraisedCaseRelaInfoEN objvYoungTAppraisedCaseRelaInfoENT)
{
try
{
objvYoungTAppraisedCaseRelaInfoENT.id_MicroTeachCaseRelaInfo = objvYoungTAppraisedCaseRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvYoungTAppraisedCaseRelaInfoENT.IsVisible = objvYoungTAppraisedCaseRelaInfoENS.IsVisible; //是否显示
objvYoungTAppraisedCaseRelaInfoENT.id_File = objvYoungTAppraisedCaseRelaInfoENS.id_File; //文件流水号
objvYoungTAppraisedCaseRelaInfoENT.FileName = objvYoungTAppraisedCaseRelaInfoENS.FileName; //文件名称
objvYoungTAppraisedCaseRelaInfoENT.FileType = objvYoungTAppraisedCaseRelaInfoENS.FileType; //文件类型
objvYoungTAppraisedCaseRelaInfoENT.SaveDate = objvYoungTAppraisedCaseRelaInfoENS.SaveDate; //创建日期
objvYoungTAppraisedCaseRelaInfoENT.FileSize = objvYoungTAppraisedCaseRelaInfoENS.FileSize; //文件大小
objvYoungTAppraisedCaseRelaInfoENT.SaveTime = objvYoungTAppraisedCaseRelaInfoENS.SaveTime; //创建时间
objvYoungTAppraisedCaseRelaInfoENT.id_FtpResource = objvYoungTAppraisedCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvYoungTAppraisedCaseRelaInfoENT.FtpResourceID = objvYoungTAppraisedCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvYoungTAppraisedCaseRelaInfoENT.FileOriginalName = objvYoungTAppraisedCaseRelaInfoENS.FileOriginalName; //文件原名
objvYoungTAppraisedCaseRelaInfoENT.FileDirName = objvYoungTAppraisedCaseRelaInfoENS.FileDirName; //文件目录名
objvYoungTAppraisedCaseRelaInfoENT.FileRename = objvYoungTAppraisedCaseRelaInfoENS.FileRename; //文件新名
objvYoungTAppraisedCaseRelaInfoENT.FileUpDate = objvYoungTAppraisedCaseRelaInfoENS.FileUpDate; //创建日期
objvYoungTAppraisedCaseRelaInfoENT.FileUpTime = objvYoungTAppraisedCaseRelaInfoENS.FileUpTime; //创建时间
objvYoungTAppraisedCaseRelaInfoENT.id_Resource = objvYoungTAppraisedCaseRelaInfoENS.id_Resource; //资源流水号
objvYoungTAppraisedCaseRelaInfoENT.ResourceID = objvYoungTAppraisedCaseRelaInfoENS.ResourceID; //资源ID
objvYoungTAppraisedCaseRelaInfoENT.SaveMode = objvYoungTAppraisedCaseRelaInfoENS.SaveMode; //文件存放方式
objvYoungTAppraisedCaseRelaInfoENT.id_ResourceType = objvYoungTAppraisedCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvYoungTAppraisedCaseRelaInfoENT.ResourceTypeID = objvYoungTAppraisedCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvYoungTAppraisedCaseRelaInfoENT.ResourceTypeName = objvYoungTAppraisedCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvYoungTAppraisedCaseRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvYoungTAppraisedCaseRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvYoungTAppraisedCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvYoungTAppraisedCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvYoungTAppraisedCaseRelaInfoENT.BrowseCount = objvYoungTAppraisedCaseRelaInfoENS.BrowseCount; //浏览次数
objvYoungTAppraisedCaseRelaInfoENT.ResourceOwner = objvYoungTAppraisedCaseRelaInfoENS.ResourceOwner; //上传者
objvYoungTAppraisedCaseRelaInfoENT.ftpFileType = objvYoungTAppraisedCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvYoungTAppraisedCaseRelaInfoENT.ftpFileSize = objvYoungTAppraisedCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvYoungTAppraisedCaseRelaInfoENT.ftpResourceOwner = objvYoungTAppraisedCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvYoungTAppraisedCaseRelaInfoENT.FileOriginName = objvYoungTAppraisedCaseRelaInfoENS.FileOriginName; //原文件名
objvYoungTAppraisedCaseRelaInfoENT.id_YoungTAppraisedCase = objvYoungTAppraisedCaseRelaInfoENS.id_YoungTAppraisedCase; //青教评优案例流水号
objvYoungTAppraisedCaseRelaInfoENT.YoungTAppraisedCaseName = objvYoungTAppraisedCaseRelaInfoENS.YoungTAppraisedCaseName; //青教评优案例名称
objvYoungTAppraisedCaseRelaInfoENT.Flag = objvYoungTAppraisedCaseRelaInfoENS.Flag; //标志
objvYoungTAppraisedCaseRelaInfoENT.FileNewName = objvYoungTAppraisedCaseRelaInfoENS.FileNewName; //新文件名
objvYoungTAppraisedCaseRelaInfoENT.FileOldName = objvYoungTAppraisedCaseRelaInfoENS.FileOldName; //旧文件名
objvYoungTAppraisedCaseRelaInfoENT.IsExistFile = objvYoungTAppraisedCaseRelaInfoENS.IsExistFile; //是否存在文件
objvYoungTAppraisedCaseRelaInfoENT.FuncModuleId = objvYoungTAppraisedCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvYoungTAppraisedCaseRelaInfoENT.FuncModuleName = objvYoungTAppraisedCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvYoungTAppraisedCaseRelaInfoENT.id_MicroteachCase = objvYoungTAppraisedCaseRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvYoungTAppraisedCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvYoungTAppraisedCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvYoungTAppraisedCaseRelaInfoENT.UpdDate = objvYoungTAppraisedCaseRelaInfoENS.UpdDate; //修改日期
objvYoungTAppraisedCaseRelaInfoENT.UpdUser = objvYoungTAppraisedCaseRelaInfoENS.UpdUser; //修改人
objvYoungTAppraisedCaseRelaInfoENT.Memo = objvYoungTAppraisedCaseRelaInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvYoungTAppraisedCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvYoungTAppraisedCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvYoungTAppraisedCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvYoungTAppraisedCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvYoungTAppraisedCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvYoungTAppraisedCaseRelaInfoEN.AttributeName)
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
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsYoungTAppraisedCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsYoungTAppraisedCaseWApi没有刷新缓存机制(clsYoungTAppraisedCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsYoungTAppraisedCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsYoungTAppraisedCaseTypeWApi没有刷新缓存机制(clsYoungTAppraisedCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscipline4TeaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline4TeaWApi没有刷新缓存机制(clsDiscipline4TeaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCaseAddiSiteRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseAddiSiteRelaWApi没有刷新缓存机制(clsCaseAddiSiteRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDecompressionFileWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDecompressionFileWApi没有刷新缓存机制(clsDecompressionFileWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeWApi没有刷新缓存机制(clsRsStaffTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeWApi没有刷新缓存机制(clsRsProfGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeWApi没有刷新缓存机制(clsRsDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceWApi没有刷新缓存机制(clsRsProvinceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionWApi没有刷新缓存机制(clsRsReligionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifWApi没有刷新缓存机制(clsRsQualifWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeWApi没有刷新缓存机制(clsRsAdminGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroTeachCaseRelaInfo");
//if (arrvYoungTAppraisedCaseRelaInfoObjLst_Cache == null)
//{
//arrvYoungTAppraisedCaseRelaInfoObjLst_Cache = await clsvYoungTAppraisedCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvYoungTAppraisedCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvYoungTAppraisedCaseRelaInfoEN._CurrTabName_S);
List<clsvYoungTAppraisedCaseRelaInfoEN> arrvYoungTAppraisedCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvYoungTAppraisedCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvYoungTAppraisedCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convYoungTAppraisedCaseRelaInfo.Memo, Type.GetType("System.String"));
foreach (clsvYoungTAppraisedCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convYoungTAppraisedCaseRelaInfo.IsVisible] = objInFor[convYoungTAppraisedCaseRelaInfo.IsVisible];
objDR[convYoungTAppraisedCaseRelaInfo.id_File] = objInFor[convYoungTAppraisedCaseRelaInfo.id_File];
objDR[convYoungTAppraisedCaseRelaInfo.FileName] = objInFor[convYoungTAppraisedCaseRelaInfo.FileName];
objDR[convYoungTAppraisedCaseRelaInfo.FileType] = objInFor[convYoungTAppraisedCaseRelaInfo.FileType];
objDR[convYoungTAppraisedCaseRelaInfo.SaveDate] = objInFor[convYoungTAppraisedCaseRelaInfo.SaveDate];
objDR[convYoungTAppraisedCaseRelaInfo.FileSize] = objInFor[convYoungTAppraisedCaseRelaInfo.FileSize];
objDR[convYoungTAppraisedCaseRelaInfo.SaveTime] = objInFor[convYoungTAppraisedCaseRelaInfo.SaveTime];
objDR[convYoungTAppraisedCaseRelaInfo.id_FtpResource] = objInFor[convYoungTAppraisedCaseRelaInfo.id_FtpResource];
objDR[convYoungTAppraisedCaseRelaInfo.FtpResourceID] = objInFor[convYoungTAppraisedCaseRelaInfo.FtpResourceID];
objDR[convYoungTAppraisedCaseRelaInfo.FileOriginalName] = objInFor[convYoungTAppraisedCaseRelaInfo.FileOriginalName];
objDR[convYoungTAppraisedCaseRelaInfo.FileDirName] = objInFor[convYoungTAppraisedCaseRelaInfo.FileDirName];
objDR[convYoungTAppraisedCaseRelaInfo.FileRename] = objInFor[convYoungTAppraisedCaseRelaInfo.FileRename];
objDR[convYoungTAppraisedCaseRelaInfo.FileUpDate] = objInFor[convYoungTAppraisedCaseRelaInfo.FileUpDate];
objDR[convYoungTAppraisedCaseRelaInfo.FileUpTime] = objInFor[convYoungTAppraisedCaseRelaInfo.FileUpTime];
objDR[convYoungTAppraisedCaseRelaInfo.id_Resource] = objInFor[convYoungTAppraisedCaseRelaInfo.id_Resource];
objDR[convYoungTAppraisedCaseRelaInfo.ResourceID] = objInFor[convYoungTAppraisedCaseRelaInfo.ResourceID];
objDR[convYoungTAppraisedCaseRelaInfo.SaveMode] = objInFor[convYoungTAppraisedCaseRelaInfo.SaveMode];
objDR[convYoungTAppraisedCaseRelaInfo.id_ResourceType] = objInFor[convYoungTAppraisedCaseRelaInfo.id_ResourceType];
objDR[convYoungTAppraisedCaseRelaInfo.ResourceTypeID] = objInFor[convYoungTAppraisedCaseRelaInfo.ResourceTypeID];
objDR[convYoungTAppraisedCaseRelaInfo.ResourceTypeName] = objInFor[convYoungTAppraisedCaseRelaInfo.ResourceTypeName];
objDR[convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convYoungTAppraisedCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convYoungTAppraisedCaseRelaInfo.BrowseCount] = objInFor[convYoungTAppraisedCaseRelaInfo.BrowseCount];
objDR[convYoungTAppraisedCaseRelaInfo.ResourceOwner] = objInFor[convYoungTAppraisedCaseRelaInfo.ResourceOwner];
objDR[convYoungTAppraisedCaseRelaInfo.ftpFileType] = objInFor[convYoungTAppraisedCaseRelaInfo.ftpFileType];
objDR[convYoungTAppraisedCaseRelaInfo.ftpFileSize] = objInFor[convYoungTAppraisedCaseRelaInfo.ftpFileSize];
objDR[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner] = objInFor[convYoungTAppraisedCaseRelaInfo.ftpResourceOwner];
objDR[convYoungTAppraisedCaseRelaInfo.FileOriginName] = objInFor[convYoungTAppraisedCaseRelaInfo.FileOriginName];
objDR[convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase] = objInFor[convYoungTAppraisedCaseRelaInfo.id_YoungTAppraisedCase];
objDR[convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName] = objInFor[convYoungTAppraisedCaseRelaInfo.YoungTAppraisedCaseName];
objDR[convYoungTAppraisedCaseRelaInfo.Flag] = objInFor[convYoungTAppraisedCaseRelaInfo.Flag];
objDR[convYoungTAppraisedCaseRelaInfo.FileNewName] = objInFor[convYoungTAppraisedCaseRelaInfo.FileNewName];
objDR[convYoungTAppraisedCaseRelaInfo.FileOldName] = objInFor[convYoungTAppraisedCaseRelaInfo.FileOldName];
objDR[convYoungTAppraisedCaseRelaInfo.IsExistFile] = objInFor[convYoungTAppraisedCaseRelaInfo.IsExistFile];
objDR[convYoungTAppraisedCaseRelaInfo.FuncModuleId] = objInFor[convYoungTAppraisedCaseRelaInfo.FuncModuleId];
objDR[convYoungTAppraisedCaseRelaInfo.FuncModuleName] = objInFor[convYoungTAppraisedCaseRelaInfo.FuncModuleName];
objDR[convYoungTAppraisedCaseRelaInfo.id_MicroteachCase] = objInFor[convYoungTAppraisedCaseRelaInfo.id_MicroteachCase];
objDR[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = objInFor[convYoungTAppraisedCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
objDR[convYoungTAppraisedCaseRelaInfo.UpdDate] = objInFor[convYoungTAppraisedCaseRelaInfo.UpdDate];
objDR[convYoungTAppraisedCaseRelaInfo.UpdUser] = objInFor[convYoungTAppraisedCaseRelaInfo.UpdUser];
objDR[convYoungTAppraisedCaseRelaInfo.Memo] = objInFor[convYoungTAppraisedCaseRelaInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}