
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachCaseRelaInfoWApi
 表名:vTeachCaseRelaInfo(01120399)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:06
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范
 模块英文名:SkillDemo
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
public static class clsvTeachCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN Setid_TeachCaseRelaInfo(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, long lngid_TeachCaseRelaInfo, string strComparisonOp="")
	{
objvTeachCaseRelaInfoEN.id_TeachCaseRelaInfo = lngid_TeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.id_TeachCaseRelaInfo) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.id_TeachCaseRelaInfo, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.id_TeachCaseRelaInfo] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN Setid_TeachCase(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strid_TeachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachCase, convTeachCaseRelaInfo.id_TeachCase);
clsCheckSql.CheckFieldLen(strid_TeachCase, 8, convTeachCaseRelaInfo.id_TeachCase);
clsCheckSql.CheckFieldForeignKey(strid_TeachCase, 8, convTeachCaseRelaInfo.id_TeachCase);
objvTeachCaseRelaInfoEN.id_TeachCase = strid_TeachCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.id_TeachCase) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.id_TeachCase, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.id_TeachCase] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetTeachCaseName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strTeachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseName, convTeachCaseRelaInfo.TeachCaseName);
clsCheckSql.CheckFieldLen(strTeachCaseName, 200, convTeachCaseRelaInfo.TeachCaseName);
objvTeachCaseRelaInfoEN.TeachCaseName = strTeachCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.TeachCaseName) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.TeachCaseName, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.TeachCaseName] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN Setid_Resource(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convTeachCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convTeachCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convTeachCaseRelaInfo.id_Resource);
objvTeachCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.id_Resource) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetResourceID(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convTeachCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convTeachCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convTeachCaseRelaInfo.ResourceID);
objvTeachCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.ResourceID) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetSaveMode(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvTeachCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.SaveMode) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN Setid_FtpResource(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convTeachCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convTeachCaseRelaInfo.id_FtpResource);
objvTeachCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.id_FtpResource) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFtpResourceID(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convTeachCaseRelaInfo.FtpResourceID);
objvTeachCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FtpResourceID) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileOriginalName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convTeachCaseRelaInfo.FileOriginalName);
objvTeachCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FileOriginalName) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileDirName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convTeachCaseRelaInfo.FileDirName);
objvTeachCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FileDirName) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileRename(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convTeachCaseRelaInfo.FileRename);
objvTeachCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FileRename) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileUpDate(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convTeachCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convTeachCaseRelaInfo.FileUpDate);
objvTeachCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FileUpDate) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileUpTime(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convTeachCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convTeachCaseRelaInfo.FileUpTime);
objvTeachCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FileUpTime) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileSize(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convTeachCaseRelaInfo.FileSize);
objvTeachCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FileSize) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileType(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convTeachCaseRelaInfo.FileType);
objvTeachCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FileType) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetResourceOwner(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convTeachCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convTeachCaseRelaInfo.ResourceOwner);
objvTeachCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.ResourceOwner) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN Setid_File(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convTeachCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convTeachCaseRelaInfo.id_File);
objvTeachCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.id_File) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convTeachCaseRelaInfo.FileName);
objvTeachCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FileName) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetSaveDate(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convTeachCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convTeachCaseRelaInfo.SaveDate);
objvTeachCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.SaveDate) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetSaveTime(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convTeachCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convTeachCaseRelaInfo.SaveTime);
objvTeachCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.SaveTime) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileOriginName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convTeachCaseRelaInfo.FileOriginName);
objvTeachCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FileOriginName) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN Setid_ResourceType(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convTeachCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convTeachCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convTeachCaseRelaInfo.id_ResourceType);
objvTeachCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.id_ResourceType) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetResourceTypeID(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convTeachCaseRelaInfo.ResourceTypeID);
objvTeachCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.ResourceTypeID) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetResourceTypeName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convTeachCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convTeachCaseRelaInfo.ResourceTypeName);
objvTeachCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.ResourceTypeName) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileNewName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convTeachCaseRelaInfo.FileNewName);
objvTeachCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FileNewName) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileOldName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convTeachCaseRelaInfo.FileOldName);
objvTeachCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.FileOldName) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetftpFileType(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachCaseRelaInfo.ftpFileType);
objvTeachCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.ftpFileType) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetftpFileSize(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convTeachCaseRelaInfo.ftpFileSize);
objvTeachCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.ftpFileSize) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetftpResourceOwner(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convTeachCaseRelaInfo.ftpResourceOwner);
objvTeachCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.ftpResourceOwner) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN Setid_TeachCaseRelaInfoType(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strid_TeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachCaseRelaInfoType, convTeachCaseRelaInfo.id_TeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(strid_TeachCaseRelaInfoType, 4, convTeachCaseRelaInfo.id_TeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_TeachCaseRelaInfoType, 4, convTeachCaseRelaInfo.id_TeachCaseRelaInfoType);
objvTeachCaseRelaInfoEN.id_TeachCaseRelaInfoType = strid_TeachCaseRelaInfoType; //案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.id_TeachCaseRelaInfoType) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.id_TeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.id_TeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetTeachCaseRelaInfoTypeID(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseRelaInfoTypeID, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(strTeachCaseRelaInfoTypeID, 4, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strTeachCaseRelaInfoTypeID, 4, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID);
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = strTeachCaseRelaInfoTypeID; //案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetTeachCaseRelaInfoTypeName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseRelaInfoTypeName, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(strTeachCaseRelaInfoTypeName, 50, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName);
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = strTeachCaseRelaInfoTypeName; //案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetIsVisible(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvTeachCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.IsVisible) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetBrowseCount(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvTeachCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.BrowseCount) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetMemo(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachCaseRelaInfo.Memo);
objvTeachCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.Memo) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.id_TeachCaseRelaInfo) == true)
{
string strComparisonOp_id_TeachCaseRelaInfo = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.id_TeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCaseRelaInfo.id_TeachCaseRelaInfo, objvTeachCaseRelaInfo_Cond.id_TeachCaseRelaInfo, strComparisonOp_id_TeachCaseRelaInfo);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.id_TeachCase) == true)
{
string strComparisonOp_id_TeachCase = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.id_TeachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.id_TeachCase, objvTeachCaseRelaInfo_Cond.id_TeachCase, strComparisonOp_id_TeachCase);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.TeachCaseName) == true)
{
string strComparisonOp_TeachCaseName = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.TeachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.TeachCaseName, objvTeachCaseRelaInfo_Cond.TeachCaseName, strComparisonOp_TeachCaseName);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.id_Resource, objvTeachCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ResourceID, objvTeachCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.SaveMode) == true)
{
if (objvTeachCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCaseRelaInfo.SaveMode);
}
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.id_FtpResource, objvTeachCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FtpResourceID, objvTeachCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileOriginalName, objvTeachCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileDirName, objvTeachCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileRename, objvTeachCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileUpDate, objvTeachCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileUpTime, objvTeachCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileSize, objvTeachCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileType, objvTeachCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ResourceOwner, objvTeachCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.id_File, objvTeachCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileName, objvTeachCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.SaveDate, objvTeachCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.SaveTime, objvTeachCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileOriginName, objvTeachCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.id_ResourceType, objvTeachCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ResourceTypeID, objvTeachCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ResourceTypeName, objvTeachCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileNewName, objvTeachCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileOldName, objvTeachCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ftpFileType, objvTeachCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ftpFileSize, objvTeachCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ftpResourceOwner, objvTeachCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.id_TeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_TeachCaseRelaInfoType = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.id_TeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.id_TeachCaseRelaInfoType, objvTeachCaseRelaInfo_Cond.id_TeachCaseRelaInfoType, strComparisonOp_id_TeachCaseRelaInfoType);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_TeachCaseRelaInfoTypeID = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID, objvTeachCaseRelaInfo_Cond.TeachCaseRelaInfoTypeID, strComparisonOp_TeachCaseRelaInfoTypeID);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_TeachCaseRelaInfoTypeName = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName, objvTeachCaseRelaInfo_Cond.TeachCaseRelaInfoTypeName, strComparisonOp_TeachCaseRelaInfoTypeName);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.IsVisible) == true)
{
if (objvTeachCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCaseRelaInfo.IsVisible);
}
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCaseRelaInfo.BrowseCount, objvTeachCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvTeachCaseRelaInfo_Cond.IsUpdated(convTeachCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvTeachCaseRelaInfo_Cond.dicFldComparisonOp[convTeachCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.Memo, objvTeachCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 案例相关信息表视图(vTeachCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vTeachCaseRelaInfoApi";

 public clsvTeachCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_TeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCaseRelaInfoEN GetObjByid_TeachCaseRelaInfo(long lngid_TeachCaseRelaInfo)
{
string strAction = "GetObjByid_TeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCaseRelaInfo"] = lngid_TeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvTeachCaseRelaInfoEN;
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
 /// <param name = "lngid_TeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCaseRelaInfoEN GetObjByid_TeachCaseRelaInfo_WA_Cache(long lngid_TeachCaseRelaInfo)
{
string strAction = "GetObjByid_TeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCaseRelaInfo"] = lngid_TeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvTeachCaseRelaInfoEN;
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
public static clsvTeachCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = null;
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
objvTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvTeachCaseRelaInfoEN;
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
 /// <param name = "lngid_TeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachCaseRelaInfoEN GetObjByid_TeachCaseRelaInfo_Cache(long lngid_TeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachCaseRelaInfoEN._CurrTabName_S);
List<clsvTeachCaseRelaInfoEN> arrvTeachCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachCaseRelaInfoEN> arrvTeachCaseRelaInfoObjLst_Sel =
from objvTeachCaseRelaInfoEN in arrvTeachCaseRelaInfoObjLst_Cache
where objvTeachCaseRelaInfoEN.id_TeachCaseRelaInfo == lngid_TeachCaseRelaInfo
select objvTeachCaseRelaInfoEN;
if (arrvTeachCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvTeachCaseRelaInfoEN obj = clsvTeachCaseRelaInfoWApi.GetObjByid_TeachCaseRelaInfo(lngid_TeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCaseRelaInfoEN> GetObjLstById_TeachCaseRelaInfoLst(List<long> arrId_TeachCaseRelaInfo)
{
 List<clsvTeachCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachCaseRelaInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_TeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeachCaseRelaInfoEN> GetObjLstById_TeachCaseRelaInfoLst_Cache(List<long> arrId_TeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachCaseRelaInfoEN._CurrTabName_S);
List<clsvTeachCaseRelaInfoEN> arrvTeachCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachCaseRelaInfoEN> arrvTeachCaseRelaInfoObjLst_Sel =
from objvTeachCaseRelaInfoEN in arrvTeachCaseRelaInfoObjLst_Cache
where arrId_TeachCaseRelaInfo.Contains(objvTeachCaseRelaInfoEN.id_TeachCaseRelaInfo)
select objvTeachCaseRelaInfoEN;
return arrvTeachCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCaseRelaInfoEN> GetObjLstById_TeachCaseRelaInfoLst_WA_Cache(List<long> arrId_TeachCaseRelaInfo)
{
 List<clsvTeachCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachCaseRelaInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_TeachCaseRelaInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCaseRelaInfo"] = lngid_TeachCaseRelaInfo.ToString()
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
 /// <param name = "objvTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoENS, clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoENT)
{
try
{
objvTeachCaseRelaInfoENT.id_TeachCaseRelaInfo = objvTeachCaseRelaInfoENS.id_TeachCaseRelaInfo; //案例相关信息流水号
objvTeachCaseRelaInfoENT.id_TeachCase = objvTeachCaseRelaInfoENS.id_TeachCase; //案例流水号
objvTeachCaseRelaInfoENT.TeachCaseName = objvTeachCaseRelaInfoENS.TeachCaseName; //案例名称
objvTeachCaseRelaInfoENT.id_Resource = objvTeachCaseRelaInfoENS.id_Resource; //资源流水号
objvTeachCaseRelaInfoENT.ResourceID = objvTeachCaseRelaInfoENS.ResourceID; //资源ID
objvTeachCaseRelaInfoENT.SaveMode = objvTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvTeachCaseRelaInfoENT.id_FtpResource = objvTeachCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvTeachCaseRelaInfoENT.FtpResourceID = objvTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvTeachCaseRelaInfoENT.FileOriginalName = objvTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvTeachCaseRelaInfoENT.FileDirName = objvTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvTeachCaseRelaInfoENT.FileRename = objvTeachCaseRelaInfoENS.FileRename; //文件新名
objvTeachCaseRelaInfoENT.FileUpDate = objvTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvTeachCaseRelaInfoENT.FileUpTime = objvTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvTeachCaseRelaInfoENT.FileSize = objvTeachCaseRelaInfoENS.FileSize; //文件大小
objvTeachCaseRelaInfoENT.FileType = objvTeachCaseRelaInfoENS.FileType; //文件类型
objvTeachCaseRelaInfoENT.ResourceOwner = objvTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvTeachCaseRelaInfoENT.id_File = objvTeachCaseRelaInfoENS.id_File; //文件流水号
objvTeachCaseRelaInfoENT.FileName = objvTeachCaseRelaInfoENS.FileName; //文件名称
objvTeachCaseRelaInfoENT.SaveDate = objvTeachCaseRelaInfoENS.SaveDate; //创建日期
objvTeachCaseRelaInfoENT.SaveTime = objvTeachCaseRelaInfoENS.SaveTime; //创建时间
objvTeachCaseRelaInfoENT.FileOriginName = objvTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvTeachCaseRelaInfoENT.id_ResourceType = objvTeachCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvTeachCaseRelaInfoENT.ResourceTypeID = objvTeachCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvTeachCaseRelaInfoENT.ResourceTypeName = objvTeachCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvTeachCaseRelaInfoENT.FileNewName = objvTeachCaseRelaInfoENS.FileNewName; //新文件名
objvTeachCaseRelaInfoENT.FileOldName = objvTeachCaseRelaInfoENS.FileOldName; //旧文件名
objvTeachCaseRelaInfoENT.ftpFileType = objvTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvTeachCaseRelaInfoENT.ftpFileSize = objvTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvTeachCaseRelaInfoENT.ftpResourceOwner = objvTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvTeachCaseRelaInfoENT.id_TeachCaseRelaInfoType = objvTeachCaseRelaInfoENS.id_TeachCaseRelaInfoType; //案例相关信息类型流水号
objvTeachCaseRelaInfoENT.TeachCaseRelaInfoTypeID = objvTeachCaseRelaInfoENS.TeachCaseRelaInfoTypeID; //案例相关信息类型ID
objvTeachCaseRelaInfoENT.TeachCaseRelaInfoTypeName = objvTeachCaseRelaInfoENS.TeachCaseRelaInfoTypeName; //案例相关信息类型名称
objvTeachCaseRelaInfoENT.IsVisible = objvTeachCaseRelaInfoENS.IsVisible; //是否显示
objvTeachCaseRelaInfoENT.BrowseCount = objvTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvTeachCaseRelaInfoENT.Memo = objvTeachCaseRelaInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvTeachCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachCaseRelaInfoEN.AttributeName)
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
if (clsTeachCaseRelaInfoTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCaseRelaInfoTypeWApi没有刷新缓存机制(clsTeachCaseRelaInfoTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachCaseRelaInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCaseRelaInfoWApi没有刷新缓存机制(clsTeachCaseRelaInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCaseWApi没有刷新缓存机制(clsTeachCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_TeachCaseRelaInfo");
//if (arrvTeachCaseRelaInfoObjLst_Cache == null)
//{
//arrvTeachCaseRelaInfoObjLst_Cache = await clsvTeachCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeachCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvTeachCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachCaseRelaInfoEN._CurrTabName_S);
List<clsvTeachCaseRelaInfoEN> arrvTeachCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachCaseRelaInfo.id_TeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachCaseRelaInfo.id_TeachCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.TeachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.id_TeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachCaseRelaInfo.Memo, Type.GetType("System.String"));
foreach (clsvTeachCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachCaseRelaInfo.id_TeachCaseRelaInfo] = objInFor[convTeachCaseRelaInfo.id_TeachCaseRelaInfo];
objDR[convTeachCaseRelaInfo.id_TeachCase] = objInFor[convTeachCaseRelaInfo.id_TeachCase];
objDR[convTeachCaseRelaInfo.TeachCaseName] = objInFor[convTeachCaseRelaInfo.TeachCaseName];
objDR[convTeachCaseRelaInfo.id_Resource] = objInFor[convTeachCaseRelaInfo.id_Resource];
objDR[convTeachCaseRelaInfo.ResourceID] = objInFor[convTeachCaseRelaInfo.ResourceID];
objDR[convTeachCaseRelaInfo.SaveMode] = objInFor[convTeachCaseRelaInfo.SaveMode];
objDR[convTeachCaseRelaInfo.id_FtpResource] = objInFor[convTeachCaseRelaInfo.id_FtpResource];
objDR[convTeachCaseRelaInfo.FtpResourceID] = objInFor[convTeachCaseRelaInfo.FtpResourceID];
objDR[convTeachCaseRelaInfo.FileOriginalName] = objInFor[convTeachCaseRelaInfo.FileOriginalName];
objDR[convTeachCaseRelaInfo.FileDirName] = objInFor[convTeachCaseRelaInfo.FileDirName];
objDR[convTeachCaseRelaInfo.FileRename] = objInFor[convTeachCaseRelaInfo.FileRename];
objDR[convTeachCaseRelaInfo.FileUpDate] = objInFor[convTeachCaseRelaInfo.FileUpDate];
objDR[convTeachCaseRelaInfo.FileUpTime] = objInFor[convTeachCaseRelaInfo.FileUpTime];
objDR[convTeachCaseRelaInfo.FileSize] = objInFor[convTeachCaseRelaInfo.FileSize];
objDR[convTeachCaseRelaInfo.FileType] = objInFor[convTeachCaseRelaInfo.FileType];
objDR[convTeachCaseRelaInfo.ResourceOwner] = objInFor[convTeachCaseRelaInfo.ResourceOwner];
objDR[convTeachCaseRelaInfo.id_File] = objInFor[convTeachCaseRelaInfo.id_File];
objDR[convTeachCaseRelaInfo.FileName] = objInFor[convTeachCaseRelaInfo.FileName];
objDR[convTeachCaseRelaInfo.SaveDate] = objInFor[convTeachCaseRelaInfo.SaveDate];
objDR[convTeachCaseRelaInfo.SaveTime] = objInFor[convTeachCaseRelaInfo.SaveTime];
objDR[convTeachCaseRelaInfo.FileOriginName] = objInFor[convTeachCaseRelaInfo.FileOriginName];
objDR[convTeachCaseRelaInfo.id_ResourceType] = objInFor[convTeachCaseRelaInfo.id_ResourceType];
objDR[convTeachCaseRelaInfo.ResourceTypeID] = objInFor[convTeachCaseRelaInfo.ResourceTypeID];
objDR[convTeachCaseRelaInfo.ResourceTypeName] = objInFor[convTeachCaseRelaInfo.ResourceTypeName];
objDR[convTeachCaseRelaInfo.FileNewName] = objInFor[convTeachCaseRelaInfo.FileNewName];
objDR[convTeachCaseRelaInfo.FileOldName] = objInFor[convTeachCaseRelaInfo.FileOldName];
objDR[convTeachCaseRelaInfo.ftpFileType] = objInFor[convTeachCaseRelaInfo.ftpFileType];
objDR[convTeachCaseRelaInfo.ftpFileSize] = objInFor[convTeachCaseRelaInfo.ftpFileSize];
objDR[convTeachCaseRelaInfo.ftpResourceOwner] = objInFor[convTeachCaseRelaInfo.ftpResourceOwner];
objDR[convTeachCaseRelaInfo.id_TeachCaseRelaInfoType] = objInFor[convTeachCaseRelaInfo.id_TeachCaseRelaInfoType];
objDR[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID] = objInFor[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID];
objDR[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName] = objInFor[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName];
objDR[convTeachCaseRelaInfo.IsVisible] = objInFor[convTeachCaseRelaInfo.IsVisible];
objDR[convTeachCaseRelaInfo.BrowseCount] = objInFor[convTeachCaseRelaInfo.BrowseCount];
objDR[convTeachCaseRelaInfo.Memo] = objInFor[convTeachCaseRelaInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}