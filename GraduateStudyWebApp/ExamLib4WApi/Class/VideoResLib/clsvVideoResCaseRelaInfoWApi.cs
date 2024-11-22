
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCaseRelaInfoWApi
 表名:vVideoResCaseRelaInfo(01120398)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:42
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频资源库
 模块英文名:VideoResLib
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
public static class clsvVideoResCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvVideoResCaseRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
objvVideoResCaseRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
objvVideoResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN Setid_MicroteachCase(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convVideoResCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convVideoResCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convVideoResCaseRelaInfo.id_MicroteachCase);
objvVideoResCaseRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.id_MicroteachCase) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetId_VideoResCase(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strId_VideoResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_VideoResCase, 8, convVideoResCaseRelaInfo.Id_VideoResCase);
clsCheckSql.CheckFieldForeignKey(strId_VideoResCase, 8, convVideoResCaseRelaInfo.Id_VideoResCase);
objvVideoResCaseRelaInfoEN.Id_VideoResCase = strId_VideoResCase; //视频资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.Id_VideoResCase) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.Id_VideoResCase, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.Id_VideoResCase] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetVideoResCaseName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strVideoResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseName, 100, convVideoResCaseRelaInfo.VideoResCaseName);
objvVideoResCaseRelaInfoEN.VideoResCaseName = strVideoResCaseName; //视频资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.VideoResCaseName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.VideoResCaseName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.VideoResCaseName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFileName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convVideoResCaseRelaInfo.FileName);
objvVideoResCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FileName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFileType(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convVideoResCaseRelaInfo.FileType);
objvVideoResCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FileType) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetSaveDate(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convVideoResCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convVideoResCaseRelaInfo.SaveDate);
objvVideoResCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.SaveDate) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFileSize(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convVideoResCaseRelaInfo.FileSize);
objvVideoResCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FileSize) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetSaveTime(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convVideoResCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convVideoResCaseRelaInfo.SaveTime);
objvVideoResCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.SaveTime) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN Setid_FtpResource(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convVideoResCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convVideoResCaseRelaInfo.id_FtpResource);
objvVideoResCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.id_FtpResource) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFtpResourceID(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convVideoResCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convVideoResCaseRelaInfo.FtpResourceID);
objvVideoResCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FtpResourceID) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFileOriginalName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convVideoResCaseRelaInfo.FileOriginalName);
objvVideoResCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FileOriginalName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFileDirName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convVideoResCaseRelaInfo.FileDirName);
objvVideoResCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FileDirName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFileRename(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convVideoResCaseRelaInfo.FileRename);
objvVideoResCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FileRename) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFileUpDate(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convVideoResCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convVideoResCaseRelaInfo.FileUpDate);
objvVideoResCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FileUpDate) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFileUpTime(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convVideoResCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convVideoResCaseRelaInfo.FileUpTime);
objvVideoResCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FileUpTime) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN Setid_Resource(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convVideoResCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convVideoResCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convVideoResCaseRelaInfo.id_Resource);
objvVideoResCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.id_Resource) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetResourceID(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convVideoResCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convVideoResCaseRelaInfo.ResourceID);
objvVideoResCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.ResourceID) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetSaveMode(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvVideoResCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.SaveMode) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN Setid_ResourceType(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convVideoResCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convVideoResCaseRelaInfo.id_ResourceType);
objvVideoResCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.id_ResourceType) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetResourceTypeID(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convVideoResCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convVideoResCaseRelaInfo.ResourceTypeID);
objvVideoResCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.ResourceTypeID) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetResourceTypeName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convVideoResCaseRelaInfo.ResourceTypeName);
objvVideoResCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.ResourceTypeName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetMajorID(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convVideoResCaseRelaInfo.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convVideoResCaseRelaInfo.MajorID);
objvVideoResCaseRelaInfoEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.MajorID) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.MajorID, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.MajorID] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetMajorName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convVideoResCaseRelaInfo.MajorName);
objvVideoResCaseRelaInfoEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.MajorName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.MajorName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.MajorName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetCourseCode(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoResCaseRelaInfo.CourseCode);
objvVideoResCaseRelaInfoEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.CourseCode) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.CourseCode, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.CourseCode] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetCollegeID(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoResCaseRelaInfo.CollegeID);
objvVideoResCaseRelaInfoEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.CollegeID) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.CollegeID, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.CollegeID] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetCollegeName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoResCaseRelaInfo.CollegeName);
objvVideoResCaseRelaInfoEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.CollegeName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.CollegeName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.CollegeName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetCourseName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoResCaseRelaInfo.CourseName);
objvVideoResCaseRelaInfoEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.CourseName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.CourseName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.CourseName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetBrowseCount(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvVideoResCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.BrowseCount) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetResourceOwner(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convVideoResCaseRelaInfo.ResourceOwner);
objvVideoResCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.ResourceOwner) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetftpFileType(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convVideoResCaseRelaInfo.ftpFileType);
objvVideoResCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.ftpFileType) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetftpFileSize(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convVideoResCaseRelaInfo.ftpFileSize);
objvVideoResCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.ftpFileSize) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetftpResourceOwner(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convVideoResCaseRelaInfo.ftpResourceOwner);
objvVideoResCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.ftpResourceOwner) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFileOriginName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convVideoResCaseRelaInfo.FileOriginName);
objvVideoResCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FileOriginName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetIsExistFile(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvVideoResCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.IsExistFile) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFlag(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convVideoResCaseRelaInfo.Flag);
objvVideoResCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.Flag) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFuncModuleName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoResCaseRelaInfo.FuncModuleName);
objvVideoResCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FuncModuleName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFuncModuleId(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoResCaseRelaInfo.FuncModuleId);
objvVideoResCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FuncModuleId) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFileNewName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convVideoResCaseRelaInfo.FileNewName);
objvVideoResCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FileNewName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetFileOldName(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convVideoResCaseRelaInfo.FileOldName);
objvVideoResCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.FileOldName) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetIsVisible(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvVideoResCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.IsVisible) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN Setid_File(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convVideoResCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convVideoResCaseRelaInfo.id_File);
objvVideoResCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.id_File) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetUpdDate(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convVideoResCaseRelaInfo.UpdDate);
objvVideoResCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.UpdDate) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetUpdUser(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convVideoResCaseRelaInfo.UpdUser);
objvVideoResCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.UpdUser) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetMemo(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoResCaseRelaInfo.Memo);
objvVideoResCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.Memo) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetCourseId(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoResCaseRelaInfo.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoResCaseRelaInfo.CourseId);
objvVideoResCaseRelaInfoEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.CourseId) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.CourseId, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.CourseId] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN Setid_XzCollege(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoResCaseRelaInfo.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoResCaseRelaInfo.id_XzCollege);
objvVideoResCaseRelaInfoEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.id_XzCollege) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.id_XzCollege, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.id_XzCollege] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseRelaInfoEN SetCollegeNameA(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoResCaseRelaInfo.CollegeNameA);
objvVideoResCaseRelaInfoEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoResCaseRelaInfo.CollegeNameA) == false)
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp.Add(convVideoResCaseRelaInfo.CollegeNameA, strComparisonOp);
}
else
{
objvVideoResCaseRelaInfoEN.dicFldComparisonOp[convVideoResCaseRelaInfo.CollegeNameA] = strComparisonOp;
}
}
return objvVideoResCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfo, objvVideoResCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfoType, objvVideoResCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeID = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, objvVideoResCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeID, strComparisonOp_MicroTeachCaseRelaInfoTypeID);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvVideoResCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.id_MicroteachCase, objvVideoResCaseRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.Id_VideoResCase) == true)
{
string strComparisonOp_Id_VideoResCase = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.Id_VideoResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.Id_VideoResCase, objvVideoResCaseRelaInfo_Cond.Id_VideoResCase, strComparisonOp_Id_VideoResCase);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.VideoResCaseName) == true)
{
string strComparisonOp_VideoResCaseName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.VideoResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.VideoResCaseName, objvVideoResCaseRelaInfo_Cond.VideoResCaseName, strComparisonOp_VideoResCaseName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FileName, objvVideoResCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FileType, objvVideoResCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.SaveDate, objvVideoResCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FileSize, objvVideoResCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.SaveTime, objvVideoResCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.id_FtpResource, objvVideoResCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FtpResourceID, objvVideoResCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FileOriginalName, objvVideoResCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FileDirName, objvVideoResCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FileRename, objvVideoResCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FileUpDate, objvVideoResCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FileUpTime, objvVideoResCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.id_Resource, objvVideoResCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.ResourceID, objvVideoResCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.SaveMode) == true)
{
if (objvVideoResCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCaseRelaInfo.SaveMode);
}
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.id_ResourceType, objvVideoResCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.ResourceTypeID, objvVideoResCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.ResourceTypeName, objvVideoResCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.MajorID) == true)
{
string strComparisonOp_MajorID = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.MajorID, objvVideoResCaseRelaInfo_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.MajorName) == true)
{
string strComparisonOp_MajorName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.MajorName, objvVideoResCaseRelaInfo_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.CourseCode, objvVideoResCaseRelaInfo_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.CollegeID, objvVideoResCaseRelaInfo_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.CollegeName, objvVideoResCaseRelaInfo_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.CourseName) == true)
{
string strComparisonOp_CourseName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.CourseName, objvVideoResCaseRelaInfo_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseRelaInfo.BrowseCount, objvVideoResCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.ResourceOwner, objvVideoResCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.ftpFileType, objvVideoResCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.ftpFileSize, objvVideoResCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.ftpResourceOwner, objvVideoResCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FileOriginName, objvVideoResCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.IsExistFile) == true)
{
if (objvVideoResCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCaseRelaInfo.IsExistFile);
}
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.Flag, objvVideoResCaseRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FuncModuleName, objvVideoResCaseRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FuncModuleId, objvVideoResCaseRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FileNewName, objvVideoResCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.FileOldName, objvVideoResCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.IsVisible) == true)
{
if (objvVideoResCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCaseRelaInfo.IsVisible);
}
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.id_File, objvVideoResCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.UpdDate, objvVideoResCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.UpdUser, objvVideoResCaseRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.Memo, objvVideoResCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.CourseId, objvVideoResCaseRelaInfo_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.id_XzCollege, objvVideoResCaseRelaInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoResCaseRelaInfo_Cond.IsUpdated(convVideoResCaseRelaInfo.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvVideoResCaseRelaInfo_Cond.dicFldComparisonOp[convVideoResCaseRelaInfo.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseRelaInfo.CollegeNameA, objvVideoResCaseRelaInfo_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频资源案例相关信息(vVideoResCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoResCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vVideoResCaseRelaInfoApi";

 public clsvVideoResCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoResCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN = null;
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
objvVideoResCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvVideoResCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseRelaInfoEN;
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
public static clsvVideoResCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN = null;
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
objvVideoResCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvVideoResCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseRelaInfoEN;
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
public static clsvVideoResCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoEN = null;
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
objvVideoResCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvVideoResCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseRelaInfoEN;
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
public static clsvVideoResCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCaseRelaInfoEN._CurrTabName_S);
List<clsvVideoResCaseRelaInfoEN> arrvVideoResCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCaseRelaInfoEN> arrvVideoResCaseRelaInfoObjLst_Sel =
from objvVideoResCaseRelaInfoEN in arrvVideoResCaseRelaInfoObjLst_Cache
where objvVideoResCaseRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvVideoResCaseRelaInfoEN;
if (arrvVideoResCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvVideoResCaseRelaInfoEN obj = clsvVideoResCaseRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoResCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvVideoResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvVideoResCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCaseRelaInfoEN._CurrTabName_S);
List<clsvVideoResCaseRelaInfoEN> arrvVideoResCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCaseRelaInfoEN> arrvVideoResCaseRelaInfoObjLst_Sel =
from objvVideoResCaseRelaInfoEN in arrvVideoResCaseRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvVideoResCaseRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvVideoResCaseRelaInfoEN;
return arrvVideoResCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvVideoResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvVideoResCaseRelaInfoENS">源对象</param>
 /// <param name = "objvVideoResCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoENS, clsvVideoResCaseRelaInfoEN objvVideoResCaseRelaInfoENT)
{
try
{
objvVideoResCaseRelaInfoENT.id_MicroTeachCaseRelaInfo = objvVideoResCaseRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvVideoResCaseRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvVideoResCaseRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvVideoResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvVideoResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvVideoResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvVideoResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvVideoResCaseRelaInfoENT.id_MicroteachCase = objvVideoResCaseRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvVideoResCaseRelaInfoENT.Id_VideoResCase = objvVideoResCaseRelaInfoENS.Id_VideoResCase; //视频资源案例流水号
objvVideoResCaseRelaInfoENT.VideoResCaseName = objvVideoResCaseRelaInfoENS.VideoResCaseName; //视频资源案例名称
objvVideoResCaseRelaInfoENT.FileName = objvVideoResCaseRelaInfoENS.FileName; //文件名称
objvVideoResCaseRelaInfoENT.FileType = objvVideoResCaseRelaInfoENS.FileType; //文件类型
objvVideoResCaseRelaInfoENT.SaveDate = objvVideoResCaseRelaInfoENS.SaveDate; //创建日期
objvVideoResCaseRelaInfoENT.FileSize = objvVideoResCaseRelaInfoENS.FileSize; //文件大小
objvVideoResCaseRelaInfoENT.SaveTime = objvVideoResCaseRelaInfoENS.SaveTime; //创建时间
objvVideoResCaseRelaInfoENT.id_FtpResource = objvVideoResCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvVideoResCaseRelaInfoENT.FtpResourceID = objvVideoResCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvVideoResCaseRelaInfoENT.FileOriginalName = objvVideoResCaseRelaInfoENS.FileOriginalName; //文件原名
objvVideoResCaseRelaInfoENT.FileDirName = objvVideoResCaseRelaInfoENS.FileDirName; //文件目录名
objvVideoResCaseRelaInfoENT.FileRename = objvVideoResCaseRelaInfoENS.FileRename; //文件新名
objvVideoResCaseRelaInfoENT.FileUpDate = objvVideoResCaseRelaInfoENS.FileUpDate; //创建日期
objvVideoResCaseRelaInfoENT.FileUpTime = objvVideoResCaseRelaInfoENS.FileUpTime; //创建时间
objvVideoResCaseRelaInfoENT.id_Resource = objvVideoResCaseRelaInfoENS.id_Resource; //资源流水号
objvVideoResCaseRelaInfoENT.ResourceID = objvVideoResCaseRelaInfoENS.ResourceID; //资源ID
objvVideoResCaseRelaInfoENT.SaveMode = objvVideoResCaseRelaInfoENS.SaveMode; //文件存放方式
objvVideoResCaseRelaInfoENT.id_ResourceType = objvVideoResCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvVideoResCaseRelaInfoENT.ResourceTypeID = objvVideoResCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvVideoResCaseRelaInfoENT.ResourceTypeName = objvVideoResCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvVideoResCaseRelaInfoENT.MajorID = objvVideoResCaseRelaInfoENS.MajorID; //专业ID
objvVideoResCaseRelaInfoENT.MajorName = objvVideoResCaseRelaInfoENS.MajorName; //专业名称
objvVideoResCaseRelaInfoENT.CourseCode = objvVideoResCaseRelaInfoENS.CourseCode; //课程代码
objvVideoResCaseRelaInfoENT.CollegeID = objvVideoResCaseRelaInfoENS.CollegeID; //学院ID
objvVideoResCaseRelaInfoENT.CollegeName = objvVideoResCaseRelaInfoENS.CollegeName; //学院名称
objvVideoResCaseRelaInfoENT.CourseName = objvVideoResCaseRelaInfoENS.CourseName; //课程名称
objvVideoResCaseRelaInfoENT.BrowseCount = objvVideoResCaseRelaInfoENS.BrowseCount; //浏览次数
objvVideoResCaseRelaInfoENT.ResourceOwner = objvVideoResCaseRelaInfoENS.ResourceOwner; //上传者
objvVideoResCaseRelaInfoENT.ftpFileType = objvVideoResCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvVideoResCaseRelaInfoENT.ftpFileSize = objvVideoResCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvVideoResCaseRelaInfoENT.ftpResourceOwner = objvVideoResCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoResCaseRelaInfoENT.FileOriginName = objvVideoResCaseRelaInfoENS.FileOriginName; //原文件名
objvVideoResCaseRelaInfoENT.IsExistFile = objvVideoResCaseRelaInfoENS.IsExistFile; //是否存在文件
objvVideoResCaseRelaInfoENT.Flag = objvVideoResCaseRelaInfoENS.Flag; //标志
objvVideoResCaseRelaInfoENT.FuncModuleName = objvVideoResCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvVideoResCaseRelaInfoENT.FuncModuleId = objvVideoResCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvVideoResCaseRelaInfoENT.FileNewName = objvVideoResCaseRelaInfoENS.FileNewName; //新文件名
objvVideoResCaseRelaInfoENT.FileOldName = objvVideoResCaseRelaInfoENS.FileOldName; //旧文件名
objvVideoResCaseRelaInfoENT.IsVisible = objvVideoResCaseRelaInfoENS.IsVisible; //是否显示
objvVideoResCaseRelaInfoENT.id_File = objvVideoResCaseRelaInfoENS.id_File; //文件流水号
objvVideoResCaseRelaInfoENT.UpdDate = objvVideoResCaseRelaInfoENS.UpdDate; //修改日期
objvVideoResCaseRelaInfoENT.UpdUser = objvVideoResCaseRelaInfoENS.UpdUser; //修改人
objvVideoResCaseRelaInfoENT.Memo = objvVideoResCaseRelaInfoENS.Memo; //备注
objvVideoResCaseRelaInfoENT.CourseId = objvVideoResCaseRelaInfoENS.CourseId; //课程Id
objvVideoResCaseRelaInfoENT.id_XzCollege = objvVideoResCaseRelaInfoENS.id_XzCollege; //学院流水号
objvVideoResCaseRelaInfoENT.CollegeNameA = objvVideoResCaseRelaInfoENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvVideoResCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoResCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoResCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoResCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoResCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoResCaseRelaInfoEN.AttributeName)
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
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoResCaseWApi没有刷新缓存机制(clsVideoResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoResCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoResCaseTypeWApi没有刷新缓存机制(clsVideoResCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeWApi没有刷新缓存机制(clsXzDegreeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeWApi没有刷新缓存机制(clsXzMajorTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeWApi没有刷新缓存机制(clsXzMajorShoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroTeachCaseRelaInfo");
//if (arrvVideoResCaseRelaInfoObjLst_Cache == null)
//{
//arrvVideoResCaseRelaInfoObjLst_Cache = await clsvVideoResCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoResCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvVideoResCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoResCaseRelaInfoEN._CurrTabName_S);
List<clsvVideoResCaseRelaInfoEN> arrvVideoResCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoResCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoResCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.Id_VideoResCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.VideoResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCaseRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseRelaInfo.CollegeNameA, Type.GetType("System.String"));
foreach (clsvVideoResCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convVideoResCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = objInFor[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
objDR[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convVideoResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convVideoResCaseRelaInfo.id_MicroteachCase] = objInFor[convVideoResCaseRelaInfo.id_MicroteachCase];
objDR[convVideoResCaseRelaInfo.Id_VideoResCase] = objInFor[convVideoResCaseRelaInfo.Id_VideoResCase];
objDR[convVideoResCaseRelaInfo.VideoResCaseName] = objInFor[convVideoResCaseRelaInfo.VideoResCaseName];
objDR[convVideoResCaseRelaInfo.FileName] = objInFor[convVideoResCaseRelaInfo.FileName];
objDR[convVideoResCaseRelaInfo.FileType] = objInFor[convVideoResCaseRelaInfo.FileType];
objDR[convVideoResCaseRelaInfo.SaveDate] = objInFor[convVideoResCaseRelaInfo.SaveDate];
objDR[convVideoResCaseRelaInfo.FileSize] = objInFor[convVideoResCaseRelaInfo.FileSize];
objDR[convVideoResCaseRelaInfo.SaveTime] = objInFor[convVideoResCaseRelaInfo.SaveTime];
objDR[convVideoResCaseRelaInfo.id_FtpResource] = objInFor[convVideoResCaseRelaInfo.id_FtpResource];
objDR[convVideoResCaseRelaInfo.FtpResourceID] = objInFor[convVideoResCaseRelaInfo.FtpResourceID];
objDR[convVideoResCaseRelaInfo.FileOriginalName] = objInFor[convVideoResCaseRelaInfo.FileOriginalName];
objDR[convVideoResCaseRelaInfo.FileDirName] = objInFor[convVideoResCaseRelaInfo.FileDirName];
objDR[convVideoResCaseRelaInfo.FileRename] = objInFor[convVideoResCaseRelaInfo.FileRename];
objDR[convVideoResCaseRelaInfo.FileUpDate] = objInFor[convVideoResCaseRelaInfo.FileUpDate];
objDR[convVideoResCaseRelaInfo.FileUpTime] = objInFor[convVideoResCaseRelaInfo.FileUpTime];
objDR[convVideoResCaseRelaInfo.id_Resource] = objInFor[convVideoResCaseRelaInfo.id_Resource];
objDR[convVideoResCaseRelaInfo.ResourceID] = objInFor[convVideoResCaseRelaInfo.ResourceID];
objDR[convVideoResCaseRelaInfo.SaveMode] = objInFor[convVideoResCaseRelaInfo.SaveMode];
objDR[convVideoResCaseRelaInfo.id_ResourceType] = objInFor[convVideoResCaseRelaInfo.id_ResourceType];
objDR[convVideoResCaseRelaInfo.ResourceTypeID] = objInFor[convVideoResCaseRelaInfo.ResourceTypeID];
objDR[convVideoResCaseRelaInfo.ResourceTypeName] = objInFor[convVideoResCaseRelaInfo.ResourceTypeName];
objDR[convVideoResCaseRelaInfo.MajorID] = objInFor[convVideoResCaseRelaInfo.MajorID];
objDR[convVideoResCaseRelaInfo.MajorName] = objInFor[convVideoResCaseRelaInfo.MajorName];
objDR[convVideoResCaseRelaInfo.CourseCode] = objInFor[convVideoResCaseRelaInfo.CourseCode];
objDR[convVideoResCaseRelaInfo.CollegeID] = objInFor[convVideoResCaseRelaInfo.CollegeID];
objDR[convVideoResCaseRelaInfo.CollegeName] = objInFor[convVideoResCaseRelaInfo.CollegeName];
objDR[convVideoResCaseRelaInfo.CourseName] = objInFor[convVideoResCaseRelaInfo.CourseName];
objDR[convVideoResCaseRelaInfo.BrowseCount] = objInFor[convVideoResCaseRelaInfo.BrowseCount];
objDR[convVideoResCaseRelaInfo.ResourceOwner] = objInFor[convVideoResCaseRelaInfo.ResourceOwner];
objDR[convVideoResCaseRelaInfo.ftpFileType] = objInFor[convVideoResCaseRelaInfo.ftpFileType];
objDR[convVideoResCaseRelaInfo.ftpFileSize] = objInFor[convVideoResCaseRelaInfo.ftpFileSize];
objDR[convVideoResCaseRelaInfo.ftpResourceOwner] = objInFor[convVideoResCaseRelaInfo.ftpResourceOwner];
objDR[convVideoResCaseRelaInfo.FileOriginName] = objInFor[convVideoResCaseRelaInfo.FileOriginName];
objDR[convVideoResCaseRelaInfo.IsExistFile] = objInFor[convVideoResCaseRelaInfo.IsExistFile];
objDR[convVideoResCaseRelaInfo.Flag] = objInFor[convVideoResCaseRelaInfo.Flag];
objDR[convVideoResCaseRelaInfo.FuncModuleName] = objInFor[convVideoResCaseRelaInfo.FuncModuleName];
objDR[convVideoResCaseRelaInfo.FuncModuleId] = objInFor[convVideoResCaseRelaInfo.FuncModuleId];
objDR[convVideoResCaseRelaInfo.FileNewName] = objInFor[convVideoResCaseRelaInfo.FileNewName];
objDR[convVideoResCaseRelaInfo.FileOldName] = objInFor[convVideoResCaseRelaInfo.FileOldName];
objDR[convVideoResCaseRelaInfo.IsVisible] = objInFor[convVideoResCaseRelaInfo.IsVisible];
objDR[convVideoResCaseRelaInfo.id_File] = objInFor[convVideoResCaseRelaInfo.id_File];
objDR[convVideoResCaseRelaInfo.UpdDate] = objInFor[convVideoResCaseRelaInfo.UpdDate];
objDR[convVideoResCaseRelaInfo.UpdUser] = objInFor[convVideoResCaseRelaInfo.UpdUser];
objDR[convVideoResCaseRelaInfo.Memo] = objInFor[convVideoResCaseRelaInfo.Memo];
objDR[convVideoResCaseRelaInfo.CourseId] = objInFor[convVideoResCaseRelaInfo.CourseId];
objDR[convVideoResCaseRelaInfo.id_XzCollege] = objInFor[convVideoResCaseRelaInfo.id_XzCollege];
objDR[convVideoResCaseRelaInfo.CollegeNameA] = objInFor[convVideoResCaseRelaInfo.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}