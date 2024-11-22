
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWritingOnBBCaseRelaInfoWApi
 表名:vWritingOnBBCaseRelaInfo(01120397)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:13
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播
 模块英文名:WritingOnBlackboard
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
public static class clsvWritingOnBBCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvWritingOnBBCaseRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFuncModuleId(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convWritingOnBBCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convWritingOnBBCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convWritingOnBBCaseRelaInfo.FuncModuleId);
objvWritingOnBBCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FuncModuleId) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFuncModuleName(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convWritingOnBBCaseRelaInfo.FuncModuleName);
objvWritingOnBBCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FuncModuleName) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN Setid_MicroteachCase(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convWritingOnBBCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convWritingOnBBCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convWritingOnBBCaseRelaInfo.id_MicroteachCase);
objvWritingOnBBCaseRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.id_MicroteachCase) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetMemo(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convWritingOnBBCaseRelaInfo.Memo);
objvWritingOnBBCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.Memo) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetIsVisible(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvWritingOnBBCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.IsVisible) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN Setid_File(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convWritingOnBBCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convWritingOnBBCaseRelaInfo.id_File);
objvWritingOnBBCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.id_File) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFileName(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convWritingOnBBCaseRelaInfo.FileName);
objvWritingOnBBCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FileName) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFileType(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convWritingOnBBCaseRelaInfo.FileType);
objvWritingOnBBCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FileType) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetSaveDate(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convWritingOnBBCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convWritingOnBBCaseRelaInfo.SaveDate);
objvWritingOnBBCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.SaveDate) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFileSize(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convWritingOnBBCaseRelaInfo.FileSize);
objvWritingOnBBCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FileSize) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetSaveTime(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convWritingOnBBCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convWritingOnBBCaseRelaInfo.SaveTime);
objvWritingOnBBCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.SaveTime) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN Setid_FtpResource(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convWritingOnBBCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convWritingOnBBCaseRelaInfo.id_FtpResource);
objvWritingOnBBCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.id_FtpResource) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFtpResourceID(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convWritingOnBBCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convWritingOnBBCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convWritingOnBBCaseRelaInfo.FtpResourceID);
objvWritingOnBBCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FtpResourceID) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFileOriginalName(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convWritingOnBBCaseRelaInfo.FileOriginalName);
objvWritingOnBBCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FileOriginalName) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFileDirName(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convWritingOnBBCaseRelaInfo.FileDirName);
objvWritingOnBBCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FileDirName) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFileRename(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convWritingOnBBCaseRelaInfo.FileRename);
objvWritingOnBBCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FileRename) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFileUpDate(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convWritingOnBBCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convWritingOnBBCaseRelaInfo.FileUpDate);
objvWritingOnBBCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FileUpDate) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFileUpTime(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convWritingOnBBCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convWritingOnBBCaseRelaInfo.FileUpTime);
objvWritingOnBBCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FileUpTime) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN Setid_Resource(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convWritingOnBBCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convWritingOnBBCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convWritingOnBBCaseRelaInfo.id_Resource);
objvWritingOnBBCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.id_Resource) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetResourceID(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convWritingOnBBCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convWritingOnBBCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convWritingOnBBCaseRelaInfo.ResourceID);
objvWritingOnBBCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.ResourceID) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetSaveMode(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvWritingOnBBCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.SaveMode) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN Setid_ResourceType(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convWritingOnBBCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convWritingOnBBCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convWritingOnBBCaseRelaInfo.id_ResourceType);
objvWritingOnBBCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.id_ResourceType) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetResourceTypeID(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convWritingOnBBCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convWritingOnBBCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convWritingOnBBCaseRelaInfo.ResourceTypeID);
objvWritingOnBBCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.ResourceTypeID) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetResourceTypeName(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convWritingOnBBCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convWritingOnBBCaseRelaInfo.ResourceTypeName);
objvWritingOnBBCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.ResourceTypeName) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroTeachCaseRelaInfoType, convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
objvWritingOnBBCaseRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroTeachCaseRelaInfoTypeID, convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroTeachCaseRelaInfoTypeName, convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetBrowseCount(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvWritingOnBBCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.BrowseCount) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetResourceOwner(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convWritingOnBBCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convWritingOnBBCaseRelaInfo.ResourceOwner);
objvWritingOnBBCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.ResourceOwner) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetftpFileType(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convWritingOnBBCaseRelaInfo.ftpFileType);
objvWritingOnBBCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.ftpFileType) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetftpFileSize(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convWritingOnBBCaseRelaInfo.ftpFileSize);
objvWritingOnBBCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.ftpFileSize) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetftpResourceOwner(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convWritingOnBBCaseRelaInfo.ftpResourceOwner);
objvWritingOnBBCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.ftpResourceOwner) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFileOriginName(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convWritingOnBBCaseRelaInfo.FileOriginName);
objvWritingOnBBCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FileOriginName) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN Setid_WritingOnBBCase(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strid_WritingOnBBCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_WritingOnBBCase, convWritingOnBBCaseRelaInfo.id_WritingOnBBCase);
clsCheckSql.CheckFieldLen(strid_WritingOnBBCase, 8, convWritingOnBBCaseRelaInfo.id_WritingOnBBCase);
clsCheckSql.CheckFieldForeignKey(strid_WritingOnBBCase, 8, convWritingOnBBCaseRelaInfo.id_WritingOnBBCase);
objvWritingOnBBCaseRelaInfoEN.id_WritingOnBBCase = strid_WritingOnBBCase; //板书案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.id_WritingOnBBCase) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.id_WritingOnBBCase, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_WritingOnBBCase] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetWritingOnBBCaseName(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strWritingOnBBCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWritingOnBBCaseName, convWritingOnBBCaseRelaInfo.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(strWritingOnBBCaseName, 100, convWritingOnBBCaseRelaInfo.WritingOnBBCaseName);
objvWritingOnBBCaseRelaInfoEN.WritingOnBBCaseName = strWritingOnBBCaseName; //板书教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.WritingOnBBCaseName) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.WritingOnBBCaseName, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.WritingOnBBCaseName] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFlag(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convWritingOnBBCaseRelaInfo.Flag);
objvWritingOnBBCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.Flag) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFileNewName(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convWritingOnBBCaseRelaInfo.FileNewName);
objvWritingOnBBCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FileNewName) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetFileOldName(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convWritingOnBBCaseRelaInfo.FileOldName);
objvWritingOnBBCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.FileOldName) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetIsExistFile(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvWritingOnBBCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.IsExistFile) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetUpdDate(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convWritingOnBBCaseRelaInfo.UpdDate);
objvWritingOnBBCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.UpdDate) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvWritingOnBBCaseRelaInfoEN SetUpdUser(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convWritingOnBBCaseRelaInfo.UpdUser);
objvWritingOnBBCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convWritingOnBBCaseRelaInfo.UpdUser) == false)
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp.Add(convWritingOnBBCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvWritingOnBBCaseRelaInfoEN.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvWritingOnBBCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfo, objvWritingOnBBCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FuncModuleId, objvWritingOnBBCaseRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FuncModuleName, objvWritingOnBBCaseRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.id_MicroteachCase, objvWritingOnBBCaseRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.Memo, objvWritingOnBBCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.IsVisible) == true)
{
if (objvWritingOnBBCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCaseRelaInfo.IsVisible);
}
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.id_File, objvWritingOnBBCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FileName, objvWritingOnBBCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FileType, objvWritingOnBBCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.SaveDate, objvWritingOnBBCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FileSize, objvWritingOnBBCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.SaveTime, objvWritingOnBBCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.id_FtpResource, objvWritingOnBBCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FtpResourceID, objvWritingOnBBCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FileOriginalName, objvWritingOnBBCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FileDirName, objvWritingOnBBCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FileRename, objvWritingOnBBCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FileUpDate, objvWritingOnBBCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FileUpTime, objvWritingOnBBCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.id_Resource, objvWritingOnBBCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.ResourceID, objvWritingOnBBCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.SaveMode) == true)
{
if (objvWritingOnBBCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCaseRelaInfo.SaveMode);
}
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.id_ResourceType, objvWritingOnBBCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.ResourceTypeID, objvWritingOnBBCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.ResourceTypeName, objvWritingOnBBCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType, objvWritingOnBBCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeID = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, objvWritingOnBBCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeID, strComparisonOp_MicroTeachCaseRelaInfoTypeID);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvWritingOnBBCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convWritingOnBBCaseRelaInfo.BrowseCount, objvWritingOnBBCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.ResourceOwner, objvWritingOnBBCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.ftpFileType, objvWritingOnBBCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.ftpFileSize, objvWritingOnBBCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.ftpResourceOwner, objvWritingOnBBCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FileOriginName, objvWritingOnBBCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.id_WritingOnBBCase) == true)
{
string strComparisonOp_id_WritingOnBBCase = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.id_WritingOnBBCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.id_WritingOnBBCase, objvWritingOnBBCaseRelaInfo_Cond.id_WritingOnBBCase, strComparisonOp_id_WritingOnBBCase);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.WritingOnBBCaseName) == true)
{
string strComparisonOp_WritingOnBBCaseName = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.WritingOnBBCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.WritingOnBBCaseName, objvWritingOnBBCaseRelaInfo_Cond.WritingOnBBCaseName, strComparisonOp_WritingOnBBCaseName);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.Flag, objvWritingOnBBCaseRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FileNewName, objvWritingOnBBCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.FileOldName, objvWritingOnBBCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.IsExistFile) == true)
{
if (objvWritingOnBBCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWritingOnBBCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWritingOnBBCaseRelaInfo.IsExistFile);
}
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.UpdDate, objvWritingOnBBCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvWritingOnBBCaseRelaInfo_Cond.IsUpdated(convWritingOnBBCaseRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvWritingOnBBCaseRelaInfo_Cond.dicFldComparisonOp[convWritingOnBBCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWritingOnBBCaseRelaInfo.UpdUser, objvWritingOnBBCaseRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vWritingOnBBCaseRelaInfo(vWritingOnBBCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvWritingOnBBCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vWritingOnBBCaseRelaInfoApi";

 public clsvWritingOnBBCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWritingOnBBCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN = null;
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
objvWritingOnBBCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvWritingOnBBCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCaseRelaInfoEN;
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
public static clsvWritingOnBBCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN = null;
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
objvWritingOnBBCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvWritingOnBBCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCaseRelaInfoEN;
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
public static clsvWritingOnBBCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN = null;
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
objvWritingOnBBCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvWritingOnBBCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvWritingOnBBCaseRelaInfoEN;
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
public static clsvWritingOnBBCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvWritingOnBBCaseRelaInfoEN._CurrTabName_S);
List<clsvWritingOnBBCaseRelaInfoEN> arrvWritingOnBBCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvWritingOnBBCaseRelaInfoEN> arrvWritingOnBBCaseRelaInfoObjLst_Sel =
from objvWritingOnBBCaseRelaInfoEN in arrvWritingOnBBCaseRelaInfoObjLst_Cache
where objvWritingOnBBCaseRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvWritingOnBBCaseRelaInfoEN;
if (arrvWritingOnBBCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvWritingOnBBCaseRelaInfoEN obj = clsvWritingOnBBCaseRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvWritingOnBBCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWritingOnBBCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvWritingOnBBCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvWritingOnBBCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvWritingOnBBCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvWritingOnBBCaseRelaInfoEN._CurrTabName_S);
List<clsvWritingOnBBCaseRelaInfoEN> arrvWritingOnBBCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvWritingOnBBCaseRelaInfoEN> arrvWritingOnBBCaseRelaInfoObjLst_Sel =
from objvWritingOnBBCaseRelaInfoEN in arrvWritingOnBBCaseRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvWritingOnBBCaseRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvWritingOnBBCaseRelaInfoEN;
return arrvWritingOnBBCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWritingOnBBCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvWritingOnBBCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvWritingOnBBCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvWritingOnBBCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvWritingOnBBCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvWritingOnBBCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvWritingOnBBCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWritingOnBBCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvWritingOnBBCaseRelaInfoENS">源对象</param>
 /// <param name = "objvWritingOnBBCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoENS, clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoENT)
{
try
{
objvWritingOnBBCaseRelaInfoENT.id_MicroTeachCaseRelaInfo = objvWritingOnBBCaseRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvWritingOnBBCaseRelaInfoENT.FuncModuleId = objvWritingOnBBCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvWritingOnBBCaseRelaInfoENT.FuncModuleName = objvWritingOnBBCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvWritingOnBBCaseRelaInfoENT.id_MicroteachCase = objvWritingOnBBCaseRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvWritingOnBBCaseRelaInfoENT.Memo = objvWritingOnBBCaseRelaInfoENS.Memo; //备注
objvWritingOnBBCaseRelaInfoENT.IsVisible = objvWritingOnBBCaseRelaInfoENS.IsVisible; //是否显示
objvWritingOnBBCaseRelaInfoENT.id_File = objvWritingOnBBCaseRelaInfoENS.id_File; //文件流水号
objvWritingOnBBCaseRelaInfoENT.FileName = objvWritingOnBBCaseRelaInfoENS.FileName; //文件名称
objvWritingOnBBCaseRelaInfoENT.FileType = objvWritingOnBBCaseRelaInfoENS.FileType; //文件类型
objvWritingOnBBCaseRelaInfoENT.SaveDate = objvWritingOnBBCaseRelaInfoENS.SaveDate; //创建日期
objvWritingOnBBCaseRelaInfoENT.FileSize = objvWritingOnBBCaseRelaInfoENS.FileSize; //文件大小
objvWritingOnBBCaseRelaInfoENT.SaveTime = objvWritingOnBBCaseRelaInfoENS.SaveTime; //创建时间
objvWritingOnBBCaseRelaInfoENT.id_FtpResource = objvWritingOnBBCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvWritingOnBBCaseRelaInfoENT.FtpResourceID = objvWritingOnBBCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvWritingOnBBCaseRelaInfoENT.FileOriginalName = objvWritingOnBBCaseRelaInfoENS.FileOriginalName; //文件原名
objvWritingOnBBCaseRelaInfoENT.FileDirName = objvWritingOnBBCaseRelaInfoENS.FileDirName; //文件目录名
objvWritingOnBBCaseRelaInfoENT.FileRename = objvWritingOnBBCaseRelaInfoENS.FileRename; //文件新名
objvWritingOnBBCaseRelaInfoENT.FileUpDate = objvWritingOnBBCaseRelaInfoENS.FileUpDate; //创建日期
objvWritingOnBBCaseRelaInfoENT.FileUpTime = objvWritingOnBBCaseRelaInfoENS.FileUpTime; //创建时间
objvWritingOnBBCaseRelaInfoENT.id_Resource = objvWritingOnBBCaseRelaInfoENS.id_Resource; //资源流水号
objvWritingOnBBCaseRelaInfoENT.ResourceID = objvWritingOnBBCaseRelaInfoENS.ResourceID; //资源ID
objvWritingOnBBCaseRelaInfoENT.SaveMode = objvWritingOnBBCaseRelaInfoENS.SaveMode; //文件存放方式
objvWritingOnBBCaseRelaInfoENT.id_ResourceType = objvWritingOnBBCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvWritingOnBBCaseRelaInfoENT.ResourceTypeID = objvWritingOnBBCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvWritingOnBBCaseRelaInfoENT.ResourceTypeName = objvWritingOnBBCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvWritingOnBBCaseRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvWritingOnBBCaseRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvWritingOnBBCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvWritingOnBBCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvWritingOnBBCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvWritingOnBBCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvWritingOnBBCaseRelaInfoENT.BrowseCount = objvWritingOnBBCaseRelaInfoENS.BrowseCount; //浏览次数
objvWritingOnBBCaseRelaInfoENT.ResourceOwner = objvWritingOnBBCaseRelaInfoENS.ResourceOwner; //上传者
objvWritingOnBBCaseRelaInfoENT.ftpFileType = objvWritingOnBBCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvWritingOnBBCaseRelaInfoENT.ftpFileSize = objvWritingOnBBCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvWritingOnBBCaseRelaInfoENT.ftpResourceOwner = objvWritingOnBBCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvWritingOnBBCaseRelaInfoENT.FileOriginName = objvWritingOnBBCaseRelaInfoENS.FileOriginName; //原文件名
objvWritingOnBBCaseRelaInfoENT.id_WritingOnBBCase = objvWritingOnBBCaseRelaInfoENS.id_WritingOnBBCase; //板书案例流水号
objvWritingOnBBCaseRelaInfoENT.WritingOnBBCaseName = objvWritingOnBBCaseRelaInfoENS.WritingOnBBCaseName; //板书教学案例名称
objvWritingOnBBCaseRelaInfoENT.Flag = objvWritingOnBBCaseRelaInfoENS.Flag; //标志
objvWritingOnBBCaseRelaInfoENT.FileNewName = objvWritingOnBBCaseRelaInfoENS.FileNewName; //新文件名
objvWritingOnBBCaseRelaInfoENT.FileOldName = objvWritingOnBBCaseRelaInfoENS.FileOldName; //旧文件名
objvWritingOnBBCaseRelaInfoENT.IsExistFile = objvWritingOnBBCaseRelaInfoENS.IsExistFile; //是否存在文件
objvWritingOnBBCaseRelaInfoENT.UpdDate = objvWritingOnBBCaseRelaInfoENS.UpdDate; //修改日期
objvWritingOnBBCaseRelaInfoENT.UpdUser = objvWritingOnBBCaseRelaInfoENS.UpdUser; //修改人
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
public static DataTable ToDataTable(List<clsvWritingOnBBCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvWritingOnBBCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvWritingOnBBCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvWritingOnBBCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvWritingOnBBCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvWritingOnBBCaseRelaInfoEN.AttributeName)
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
if (clsWritingOnBBCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWritingOnBBCaseWApi没有刷新缓存机制(clsWritingOnBBCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWritingOnBBCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWritingOnBBCaseTypeWApi没有刷新缓存机制(clsWritingOnBBCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvWritingOnBBCaseRelaInfoObjLst_Cache == null)
//{
//arrvWritingOnBBCaseRelaInfoObjLst_Cache = await clsvWritingOnBBCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvWritingOnBBCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvWritingOnBBCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvWritingOnBBCaseRelaInfoEN._CurrTabName_S);
List<clsvWritingOnBBCaseRelaInfoEN> arrvWritingOnBBCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvWritingOnBBCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvWritingOnBBCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.id_WritingOnBBCase, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.WritingOnBBCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convWritingOnBBCaseRelaInfo.UpdUser, Type.GetType("System.String"));
foreach (clsvWritingOnBBCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convWritingOnBBCaseRelaInfo.FuncModuleId] = objInFor[convWritingOnBBCaseRelaInfo.FuncModuleId];
objDR[convWritingOnBBCaseRelaInfo.FuncModuleName] = objInFor[convWritingOnBBCaseRelaInfo.FuncModuleName];
objDR[convWritingOnBBCaseRelaInfo.id_MicroteachCase] = objInFor[convWritingOnBBCaseRelaInfo.id_MicroteachCase];
objDR[convWritingOnBBCaseRelaInfo.Memo] = objInFor[convWritingOnBBCaseRelaInfo.Memo];
objDR[convWritingOnBBCaseRelaInfo.IsVisible] = objInFor[convWritingOnBBCaseRelaInfo.IsVisible];
objDR[convWritingOnBBCaseRelaInfo.id_File] = objInFor[convWritingOnBBCaseRelaInfo.id_File];
objDR[convWritingOnBBCaseRelaInfo.FileName] = objInFor[convWritingOnBBCaseRelaInfo.FileName];
objDR[convWritingOnBBCaseRelaInfo.FileType] = objInFor[convWritingOnBBCaseRelaInfo.FileType];
objDR[convWritingOnBBCaseRelaInfo.SaveDate] = objInFor[convWritingOnBBCaseRelaInfo.SaveDate];
objDR[convWritingOnBBCaseRelaInfo.FileSize] = objInFor[convWritingOnBBCaseRelaInfo.FileSize];
objDR[convWritingOnBBCaseRelaInfo.SaveTime] = objInFor[convWritingOnBBCaseRelaInfo.SaveTime];
objDR[convWritingOnBBCaseRelaInfo.id_FtpResource] = objInFor[convWritingOnBBCaseRelaInfo.id_FtpResource];
objDR[convWritingOnBBCaseRelaInfo.FtpResourceID] = objInFor[convWritingOnBBCaseRelaInfo.FtpResourceID];
objDR[convWritingOnBBCaseRelaInfo.FileOriginalName] = objInFor[convWritingOnBBCaseRelaInfo.FileOriginalName];
objDR[convWritingOnBBCaseRelaInfo.FileDirName] = objInFor[convWritingOnBBCaseRelaInfo.FileDirName];
objDR[convWritingOnBBCaseRelaInfo.FileRename] = objInFor[convWritingOnBBCaseRelaInfo.FileRename];
objDR[convWritingOnBBCaseRelaInfo.FileUpDate] = objInFor[convWritingOnBBCaseRelaInfo.FileUpDate];
objDR[convWritingOnBBCaseRelaInfo.FileUpTime] = objInFor[convWritingOnBBCaseRelaInfo.FileUpTime];
objDR[convWritingOnBBCaseRelaInfo.id_Resource] = objInFor[convWritingOnBBCaseRelaInfo.id_Resource];
objDR[convWritingOnBBCaseRelaInfo.ResourceID] = objInFor[convWritingOnBBCaseRelaInfo.ResourceID];
objDR[convWritingOnBBCaseRelaInfo.SaveMode] = objInFor[convWritingOnBBCaseRelaInfo.SaveMode];
objDR[convWritingOnBBCaseRelaInfo.id_ResourceType] = objInFor[convWritingOnBBCaseRelaInfo.id_ResourceType];
objDR[convWritingOnBBCaseRelaInfo.ResourceTypeID] = objInFor[convWritingOnBBCaseRelaInfo.ResourceTypeID];
objDR[convWritingOnBBCaseRelaInfo.ResourceTypeName] = objInFor[convWritingOnBBCaseRelaInfo.ResourceTypeName];
objDR[convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convWritingOnBBCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = objInFor[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
objDR[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convWritingOnBBCaseRelaInfo.BrowseCount] = objInFor[convWritingOnBBCaseRelaInfo.BrowseCount];
objDR[convWritingOnBBCaseRelaInfo.ResourceOwner] = objInFor[convWritingOnBBCaseRelaInfo.ResourceOwner];
objDR[convWritingOnBBCaseRelaInfo.ftpFileType] = objInFor[convWritingOnBBCaseRelaInfo.ftpFileType];
objDR[convWritingOnBBCaseRelaInfo.ftpFileSize] = objInFor[convWritingOnBBCaseRelaInfo.ftpFileSize];
objDR[convWritingOnBBCaseRelaInfo.ftpResourceOwner] = objInFor[convWritingOnBBCaseRelaInfo.ftpResourceOwner];
objDR[convWritingOnBBCaseRelaInfo.FileOriginName] = objInFor[convWritingOnBBCaseRelaInfo.FileOriginName];
objDR[convWritingOnBBCaseRelaInfo.id_WritingOnBBCase] = objInFor[convWritingOnBBCaseRelaInfo.id_WritingOnBBCase];
objDR[convWritingOnBBCaseRelaInfo.WritingOnBBCaseName] = objInFor[convWritingOnBBCaseRelaInfo.WritingOnBBCaseName];
objDR[convWritingOnBBCaseRelaInfo.Flag] = objInFor[convWritingOnBBCaseRelaInfo.Flag];
objDR[convWritingOnBBCaseRelaInfo.FileNewName] = objInFor[convWritingOnBBCaseRelaInfo.FileNewName];
objDR[convWritingOnBBCaseRelaInfo.FileOldName] = objInFor[convWritingOnBBCaseRelaInfo.FileOldName];
objDR[convWritingOnBBCaseRelaInfo.IsExistFile] = objInFor[convWritingOnBBCaseRelaInfo.IsExistFile];
objDR[convWritingOnBBCaseRelaInfo.UpdDate] = objInFor[convWritingOnBBCaseRelaInfo.UpdDate];
objDR[convWritingOnBBCaseRelaInfo.UpdUser] = objInFor[convWritingOnBBCaseRelaInfo.UpdUser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}