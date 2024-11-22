
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCaseRelaInfoWApi
 表名:vCoursewareCaseRelaInfo(01120403)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:01
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件
 模块英文名:Courseware
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
public static class clsvCoursewareCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvCoursewareCaseRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN Setid_File(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convCoursewareCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convCoursewareCaseRelaInfo.id_File);
objvCoursewareCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.id_File) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFileName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convCoursewareCaseRelaInfo.FileName);
objvCoursewareCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FileName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFileType(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convCoursewareCaseRelaInfo.FileType);
objvCoursewareCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FileType) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetSaveDate(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convCoursewareCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convCoursewareCaseRelaInfo.SaveDate);
objvCoursewareCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.SaveDate) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFileSize(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convCoursewareCaseRelaInfo.FileSize);
objvCoursewareCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FileSize) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetSaveTime(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convCoursewareCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convCoursewareCaseRelaInfo.SaveTime);
objvCoursewareCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.SaveTime) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN Setid_MicroteachCase(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convCoursewareCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCoursewareCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCoursewareCaseRelaInfo.id_MicroteachCase);
objvCoursewareCaseRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.id_MicroteachCase) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN Setid_FtpResource(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convCoursewareCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convCoursewareCaseRelaInfo.id_FtpResource);
objvCoursewareCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.id_FtpResource) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFtpResourceID(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convCoursewareCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convCoursewareCaseRelaInfo.FtpResourceID);
objvCoursewareCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FtpResourceID) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFileOriginalName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convCoursewareCaseRelaInfo.FileOriginalName);
objvCoursewareCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FileOriginalName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFileDirName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convCoursewareCaseRelaInfo.FileDirName);
objvCoursewareCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FileDirName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFileRename(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convCoursewareCaseRelaInfo.FileRename);
objvCoursewareCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FileRename) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFileUpDate(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convCoursewareCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convCoursewareCaseRelaInfo.FileUpDate);
objvCoursewareCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FileUpDate) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFileUpTime(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convCoursewareCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convCoursewareCaseRelaInfo.FileUpTime);
objvCoursewareCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FileUpTime) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN Setid_Resource(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convCoursewareCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convCoursewareCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convCoursewareCaseRelaInfo.id_Resource);
objvCoursewareCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.id_Resource) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetResourceID(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convCoursewareCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convCoursewareCaseRelaInfo.ResourceID);
objvCoursewareCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.ResourceID) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetSaveMode(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvCoursewareCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.SaveMode) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN Setid_ResourceType(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convCoursewareCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convCoursewareCaseRelaInfo.id_ResourceType);
objvCoursewareCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.id_ResourceType) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetResourceTypeID(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convCoursewareCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convCoursewareCaseRelaInfo.ResourceTypeID);
objvCoursewareCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.ResourceTypeID) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetResourceTypeName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convCoursewareCaseRelaInfo.ResourceTypeName);
objvCoursewareCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.ResourceTypeName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetMajorName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCoursewareCaseRelaInfo.MajorName);
objvCoursewareCaseRelaInfoEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.MajorName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.MajorName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.MajorName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetCollegeID(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCoursewareCaseRelaInfo.CollegeID);
objvCoursewareCaseRelaInfoEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.CollegeID) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.CollegeID, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.CollegeID] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetCollegeName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCoursewareCaseRelaInfo.CollegeName);
objvCoursewareCaseRelaInfoEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.CollegeName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.CollegeName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.CollegeName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
objvCoursewareCaseRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
objvCoursewareCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetBrowseCount(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvCoursewareCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.BrowseCount) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetResourceOwner(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convCoursewareCaseRelaInfo.ResourceOwner);
objvCoursewareCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.ResourceOwner) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetftpFileType(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCoursewareCaseRelaInfo.ftpFileType);
objvCoursewareCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.ftpFileType) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetftpFileSize(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convCoursewareCaseRelaInfo.ftpFileSize);
objvCoursewareCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.ftpFileSize) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetftpResourceOwner(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convCoursewareCaseRelaInfo.ftpResourceOwner);
objvCoursewareCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.ftpResourceOwner) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFileOriginName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convCoursewareCaseRelaInfo.FileOriginName);
objvCoursewareCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FileOriginName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetUpdDate(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCoursewareCaseRelaInfo.UpdDate);
objvCoursewareCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.UpdDate) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetUpdUser(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCoursewareCaseRelaInfo.UpdUser);
objvCoursewareCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.UpdUser) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetIsExistFile(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvCoursewareCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.IsExistFile) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFlag(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convCoursewareCaseRelaInfo.Flag);
objvCoursewareCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.Flag) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFuncModuleName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCoursewareCaseRelaInfo.FuncModuleName);
objvCoursewareCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FuncModuleName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFuncModuleId(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCoursewareCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCoursewareCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCoursewareCaseRelaInfo.FuncModuleId);
objvCoursewareCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FuncModuleId) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFileNewName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convCoursewareCaseRelaInfo.FileNewName);
objvCoursewareCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FileNewName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetFileOldName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convCoursewareCaseRelaInfo.FileOldName);
objvCoursewareCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.FileOldName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetCoursewareCaseName(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strCoursewareCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareCaseName, 100, convCoursewareCaseRelaInfo.CoursewareCaseName);
objvCoursewareCaseRelaInfoEN.CoursewareCaseName = strCoursewareCaseName; //课件教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.CoursewareCaseName) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.CoursewareCaseName, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.CoursewareCaseName] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetId_CoursewareCase(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strId_CoursewareCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CoursewareCase, 8, convCoursewareCaseRelaInfo.Id_CoursewareCase);
clsCheckSql.CheckFieldForeignKey(strId_CoursewareCase, 8, convCoursewareCaseRelaInfo.Id_CoursewareCase);
objvCoursewareCaseRelaInfoEN.Id_CoursewareCase = strId_CoursewareCase; //课件教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.Id_CoursewareCase) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.Id_CoursewareCase, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.Id_CoursewareCase] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetIsVisible(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCoursewareCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.IsVisible) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN SetMemo(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCoursewareCaseRelaInfo.Memo);
objvCoursewareCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.Memo) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareCaseRelaInfoEN Setid_XzCollege(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCoursewareCaseRelaInfo.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCoursewareCaseRelaInfo.id_XzCollege);
objvCoursewareCaseRelaInfoEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareCaseRelaInfo.id_XzCollege) == false)
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareCaseRelaInfo.id_XzCollege, strComparisonOp);
}
else
{
objvCoursewareCaseRelaInfoEN.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_XzCollege] = strComparisonOp;
}
}
return objvCoursewareCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfo, objvCoursewareCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.id_File, objvCoursewareCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FileName, objvCoursewareCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FileType, objvCoursewareCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.SaveDate, objvCoursewareCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FileSize, objvCoursewareCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.SaveTime, objvCoursewareCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.id_MicroteachCase, objvCoursewareCaseRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.id_FtpResource, objvCoursewareCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FtpResourceID, objvCoursewareCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FileOriginalName, objvCoursewareCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FileDirName, objvCoursewareCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FileRename, objvCoursewareCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FileUpDate, objvCoursewareCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FileUpTime, objvCoursewareCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.id_Resource, objvCoursewareCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.ResourceID, objvCoursewareCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.SaveMode) == true)
{
if (objvCoursewareCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCaseRelaInfo.SaveMode);
}
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.id_ResourceType, objvCoursewareCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.ResourceTypeID, objvCoursewareCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.ResourceTypeName, objvCoursewareCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.MajorName) == true)
{
string strComparisonOp_MajorName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.MajorName, objvCoursewareCaseRelaInfo_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.CollegeID, objvCoursewareCaseRelaInfo_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.CollegeName, objvCoursewareCaseRelaInfo_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfoType, objvCoursewareCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeID = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, objvCoursewareCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeID, strComparisonOp_MicroTeachCaseRelaInfoTypeID);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvCoursewareCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareCaseRelaInfo.BrowseCount, objvCoursewareCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.ResourceOwner, objvCoursewareCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.ftpFileType, objvCoursewareCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.ftpFileSize, objvCoursewareCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.ftpResourceOwner, objvCoursewareCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FileOriginName, objvCoursewareCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.UpdDate, objvCoursewareCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.UpdUser, objvCoursewareCaseRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.IsExistFile) == true)
{
if (objvCoursewareCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCaseRelaInfo.IsExistFile);
}
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.Flag, objvCoursewareCaseRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FuncModuleName, objvCoursewareCaseRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FuncModuleId, objvCoursewareCaseRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FileNewName, objvCoursewareCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.FileOldName, objvCoursewareCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.CoursewareCaseName) == true)
{
string strComparisonOp_CoursewareCaseName = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.CoursewareCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.CoursewareCaseName, objvCoursewareCaseRelaInfo_Cond.CoursewareCaseName, strComparisonOp_CoursewareCaseName);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.Id_CoursewareCase) == true)
{
string strComparisonOp_Id_CoursewareCase = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.Id_CoursewareCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.Id_CoursewareCase, objvCoursewareCaseRelaInfo_Cond.Id_CoursewareCase, strComparisonOp_Id_CoursewareCase);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.IsVisible) == true)
{
if (objvCoursewareCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareCaseRelaInfo.IsVisible);
}
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.Memo, objvCoursewareCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
if (objvCoursewareCaseRelaInfo_Cond.IsUpdated(convCoursewareCaseRelaInfo.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCoursewareCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareCaseRelaInfo.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareCaseRelaInfo.id_XzCollege, objvCoursewareCaseRelaInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCoursewareCaseRelaInfo(vCoursewareCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCoursewareCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vCoursewareCaseRelaInfoApi";

 public clsvCoursewareCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN = null;
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
objvCoursewareCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCoursewareCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCaseRelaInfoEN;
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
public static clsvCoursewareCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN = null;
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
objvCoursewareCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCoursewareCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCaseRelaInfoEN;
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
public static clsvCoursewareCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoEN = null;
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
objvCoursewareCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCoursewareCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareCaseRelaInfoEN;
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
public static clsvCoursewareCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareCaseRelaInfoEN._CurrTabName_S);
List<clsvCoursewareCaseRelaInfoEN> arrvCoursewareCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareCaseRelaInfoEN> arrvCoursewareCaseRelaInfoObjLst_Sel =
from objvCoursewareCaseRelaInfoEN in arrvCoursewareCaseRelaInfoObjLst_Cache
where objvCoursewareCaseRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvCoursewareCaseRelaInfoEN;
if (arrvCoursewareCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvCoursewareCaseRelaInfoEN obj = clsvCoursewareCaseRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCoursewareCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvCoursewareCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvCoursewareCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCoursewareCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareCaseRelaInfoEN._CurrTabName_S);
List<clsvCoursewareCaseRelaInfoEN> arrvCoursewareCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareCaseRelaInfoEN> arrvCoursewareCaseRelaInfoObjLst_Sel =
from objvCoursewareCaseRelaInfoEN in arrvCoursewareCaseRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvCoursewareCaseRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvCoursewareCaseRelaInfoEN;
return arrvCoursewareCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvCoursewareCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCoursewareCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCoursewareCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCoursewareCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCoursewareCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCoursewareCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCoursewareCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoENS, clsvCoursewareCaseRelaInfoEN objvCoursewareCaseRelaInfoENT)
{
try
{
objvCoursewareCaseRelaInfoENT.id_MicroTeachCaseRelaInfo = objvCoursewareCaseRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvCoursewareCaseRelaInfoENT.id_File = objvCoursewareCaseRelaInfoENS.id_File; //文件流水号
objvCoursewareCaseRelaInfoENT.FileName = objvCoursewareCaseRelaInfoENS.FileName; //文件名称
objvCoursewareCaseRelaInfoENT.FileType = objvCoursewareCaseRelaInfoENS.FileType; //文件类型
objvCoursewareCaseRelaInfoENT.SaveDate = objvCoursewareCaseRelaInfoENS.SaveDate; //创建日期
objvCoursewareCaseRelaInfoENT.FileSize = objvCoursewareCaseRelaInfoENS.FileSize; //文件大小
objvCoursewareCaseRelaInfoENT.SaveTime = objvCoursewareCaseRelaInfoENS.SaveTime; //创建时间
objvCoursewareCaseRelaInfoENT.id_MicroteachCase = objvCoursewareCaseRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvCoursewareCaseRelaInfoENT.id_FtpResource = objvCoursewareCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvCoursewareCaseRelaInfoENT.FtpResourceID = objvCoursewareCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvCoursewareCaseRelaInfoENT.FileOriginalName = objvCoursewareCaseRelaInfoENS.FileOriginalName; //文件原名
objvCoursewareCaseRelaInfoENT.FileDirName = objvCoursewareCaseRelaInfoENS.FileDirName; //文件目录名
objvCoursewareCaseRelaInfoENT.FileRename = objvCoursewareCaseRelaInfoENS.FileRename; //文件新名
objvCoursewareCaseRelaInfoENT.FileUpDate = objvCoursewareCaseRelaInfoENS.FileUpDate; //创建日期
objvCoursewareCaseRelaInfoENT.FileUpTime = objvCoursewareCaseRelaInfoENS.FileUpTime; //创建时间
objvCoursewareCaseRelaInfoENT.id_Resource = objvCoursewareCaseRelaInfoENS.id_Resource; //资源流水号
objvCoursewareCaseRelaInfoENT.ResourceID = objvCoursewareCaseRelaInfoENS.ResourceID; //资源ID
objvCoursewareCaseRelaInfoENT.SaveMode = objvCoursewareCaseRelaInfoENS.SaveMode; //文件存放方式
objvCoursewareCaseRelaInfoENT.id_ResourceType = objvCoursewareCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvCoursewareCaseRelaInfoENT.ResourceTypeID = objvCoursewareCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvCoursewareCaseRelaInfoENT.ResourceTypeName = objvCoursewareCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvCoursewareCaseRelaInfoENT.MajorName = objvCoursewareCaseRelaInfoENS.MajorName; //专业名称
objvCoursewareCaseRelaInfoENT.CollegeID = objvCoursewareCaseRelaInfoENS.CollegeID; //学院ID
objvCoursewareCaseRelaInfoENT.CollegeName = objvCoursewareCaseRelaInfoENS.CollegeName; //学院名称
objvCoursewareCaseRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvCoursewareCaseRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvCoursewareCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvCoursewareCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvCoursewareCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvCoursewareCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvCoursewareCaseRelaInfoENT.BrowseCount = objvCoursewareCaseRelaInfoENS.BrowseCount; //浏览次数
objvCoursewareCaseRelaInfoENT.ResourceOwner = objvCoursewareCaseRelaInfoENS.ResourceOwner; //上传者
objvCoursewareCaseRelaInfoENT.ftpFileType = objvCoursewareCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvCoursewareCaseRelaInfoENT.ftpFileSize = objvCoursewareCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvCoursewareCaseRelaInfoENT.ftpResourceOwner = objvCoursewareCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvCoursewareCaseRelaInfoENT.FileOriginName = objvCoursewareCaseRelaInfoENS.FileOriginName; //原文件名
objvCoursewareCaseRelaInfoENT.UpdDate = objvCoursewareCaseRelaInfoENS.UpdDate; //修改日期
objvCoursewareCaseRelaInfoENT.UpdUser = objvCoursewareCaseRelaInfoENS.UpdUser; //修改人
objvCoursewareCaseRelaInfoENT.IsExistFile = objvCoursewareCaseRelaInfoENS.IsExistFile; //是否存在文件
objvCoursewareCaseRelaInfoENT.Flag = objvCoursewareCaseRelaInfoENS.Flag; //标志
objvCoursewareCaseRelaInfoENT.FuncModuleName = objvCoursewareCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvCoursewareCaseRelaInfoENT.FuncModuleId = objvCoursewareCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvCoursewareCaseRelaInfoENT.FileNewName = objvCoursewareCaseRelaInfoENS.FileNewName; //新文件名
objvCoursewareCaseRelaInfoENT.FileOldName = objvCoursewareCaseRelaInfoENS.FileOldName; //旧文件名
objvCoursewareCaseRelaInfoENT.CoursewareCaseName = objvCoursewareCaseRelaInfoENS.CoursewareCaseName; //课件教学案例名称
objvCoursewareCaseRelaInfoENT.Id_CoursewareCase = objvCoursewareCaseRelaInfoENS.Id_CoursewareCase; //课件教学案例流水号
objvCoursewareCaseRelaInfoENT.IsVisible = objvCoursewareCaseRelaInfoENS.IsVisible; //是否显示
objvCoursewareCaseRelaInfoENT.Memo = objvCoursewareCaseRelaInfoENS.Memo; //备注
objvCoursewareCaseRelaInfoENT.id_XzCollege = objvCoursewareCaseRelaInfoENS.id_XzCollege; //学院流水号
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
public static DataTable ToDataTable(List<clsvCoursewareCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCoursewareCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCoursewareCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCoursewareCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCoursewareCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCoursewareCaseRelaInfoEN.AttributeName)
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
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCoursewareCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareCaseWApi没有刷新缓存机制(clsCoursewareCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCoursewareCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareCaseTypeWApi没有刷新缓存机制(clsCoursewareCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvCoursewareCaseRelaInfoObjLst_Cache == null)
//{
//arrvCoursewareCaseRelaInfoObjLst_Cache = await clsvCoursewareCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCoursewareCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvCoursewareCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCoursewareCaseRelaInfoEN._CurrTabName_S);
List<clsvCoursewareCaseRelaInfoEN> arrvCoursewareCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCoursewareCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCoursewareCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.CoursewareCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.Id_CoursewareCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareCaseRelaInfo.id_XzCollege, Type.GetType("System.String"));
foreach (clsvCoursewareCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convCoursewareCaseRelaInfo.id_File] = objInFor[convCoursewareCaseRelaInfo.id_File];
objDR[convCoursewareCaseRelaInfo.FileName] = objInFor[convCoursewareCaseRelaInfo.FileName];
objDR[convCoursewareCaseRelaInfo.FileType] = objInFor[convCoursewareCaseRelaInfo.FileType];
objDR[convCoursewareCaseRelaInfo.SaveDate] = objInFor[convCoursewareCaseRelaInfo.SaveDate];
objDR[convCoursewareCaseRelaInfo.FileSize] = objInFor[convCoursewareCaseRelaInfo.FileSize];
objDR[convCoursewareCaseRelaInfo.SaveTime] = objInFor[convCoursewareCaseRelaInfo.SaveTime];
objDR[convCoursewareCaseRelaInfo.id_MicroteachCase] = objInFor[convCoursewareCaseRelaInfo.id_MicroteachCase];
objDR[convCoursewareCaseRelaInfo.id_FtpResource] = objInFor[convCoursewareCaseRelaInfo.id_FtpResource];
objDR[convCoursewareCaseRelaInfo.FtpResourceID] = objInFor[convCoursewareCaseRelaInfo.FtpResourceID];
objDR[convCoursewareCaseRelaInfo.FileOriginalName] = objInFor[convCoursewareCaseRelaInfo.FileOriginalName];
objDR[convCoursewareCaseRelaInfo.FileDirName] = objInFor[convCoursewareCaseRelaInfo.FileDirName];
objDR[convCoursewareCaseRelaInfo.FileRename] = objInFor[convCoursewareCaseRelaInfo.FileRename];
objDR[convCoursewareCaseRelaInfo.FileUpDate] = objInFor[convCoursewareCaseRelaInfo.FileUpDate];
objDR[convCoursewareCaseRelaInfo.FileUpTime] = objInFor[convCoursewareCaseRelaInfo.FileUpTime];
objDR[convCoursewareCaseRelaInfo.id_Resource] = objInFor[convCoursewareCaseRelaInfo.id_Resource];
objDR[convCoursewareCaseRelaInfo.ResourceID] = objInFor[convCoursewareCaseRelaInfo.ResourceID];
objDR[convCoursewareCaseRelaInfo.SaveMode] = objInFor[convCoursewareCaseRelaInfo.SaveMode];
objDR[convCoursewareCaseRelaInfo.id_ResourceType] = objInFor[convCoursewareCaseRelaInfo.id_ResourceType];
objDR[convCoursewareCaseRelaInfo.ResourceTypeID] = objInFor[convCoursewareCaseRelaInfo.ResourceTypeID];
objDR[convCoursewareCaseRelaInfo.ResourceTypeName] = objInFor[convCoursewareCaseRelaInfo.ResourceTypeName];
objDR[convCoursewareCaseRelaInfo.MajorName] = objInFor[convCoursewareCaseRelaInfo.MajorName];
objDR[convCoursewareCaseRelaInfo.CollegeID] = objInFor[convCoursewareCaseRelaInfo.CollegeID];
objDR[convCoursewareCaseRelaInfo.CollegeName] = objInFor[convCoursewareCaseRelaInfo.CollegeName];
objDR[convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convCoursewareCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = objInFor[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
objDR[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convCoursewareCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convCoursewareCaseRelaInfo.BrowseCount] = objInFor[convCoursewareCaseRelaInfo.BrowseCount];
objDR[convCoursewareCaseRelaInfo.ResourceOwner] = objInFor[convCoursewareCaseRelaInfo.ResourceOwner];
objDR[convCoursewareCaseRelaInfo.ftpFileType] = objInFor[convCoursewareCaseRelaInfo.ftpFileType];
objDR[convCoursewareCaseRelaInfo.ftpFileSize] = objInFor[convCoursewareCaseRelaInfo.ftpFileSize];
objDR[convCoursewareCaseRelaInfo.ftpResourceOwner] = objInFor[convCoursewareCaseRelaInfo.ftpResourceOwner];
objDR[convCoursewareCaseRelaInfo.FileOriginName] = objInFor[convCoursewareCaseRelaInfo.FileOriginName];
objDR[convCoursewareCaseRelaInfo.UpdDate] = objInFor[convCoursewareCaseRelaInfo.UpdDate];
objDR[convCoursewareCaseRelaInfo.UpdUser] = objInFor[convCoursewareCaseRelaInfo.UpdUser];
objDR[convCoursewareCaseRelaInfo.IsExistFile] = objInFor[convCoursewareCaseRelaInfo.IsExistFile];
objDR[convCoursewareCaseRelaInfo.Flag] = objInFor[convCoursewareCaseRelaInfo.Flag];
objDR[convCoursewareCaseRelaInfo.FuncModuleName] = objInFor[convCoursewareCaseRelaInfo.FuncModuleName];
objDR[convCoursewareCaseRelaInfo.FuncModuleId] = objInFor[convCoursewareCaseRelaInfo.FuncModuleId];
objDR[convCoursewareCaseRelaInfo.FileNewName] = objInFor[convCoursewareCaseRelaInfo.FileNewName];
objDR[convCoursewareCaseRelaInfo.FileOldName] = objInFor[convCoursewareCaseRelaInfo.FileOldName];
objDR[convCoursewareCaseRelaInfo.CoursewareCaseName] = objInFor[convCoursewareCaseRelaInfo.CoursewareCaseName];
objDR[convCoursewareCaseRelaInfo.Id_CoursewareCase] = objInFor[convCoursewareCaseRelaInfo.Id_CoursewareCase];
objDR[convCoursewareCaseRelaInfo.IsVisible] = objInFor[convCoursewareCaseRelaInfo.IsVisible];
objDR[convCoursewareCaseRelaInfo.Memo] = objInFor[convCoursewareCaseRelaInfo.Memo];
objDR[convCoursewareCaseRelaInfo.id_XzCollege] = objInFor[convCoursewareCaseRelaInfo.id_XzCollege];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}