
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMandarinCase_Resource_RelWApi
 表名:vMandarinCase_Resource_Rel(01120430)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:54
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
public static class clsvMandarinCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_MicroteachCase_Resource_Rel(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvMandarinCase_Resource_RelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFuncModuleName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMandarinCase_Resource_Rel.FuncModuleName);
objvMandarinCase_Resource_RelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FuncModuleName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FuncModuleName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FuncModuleName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFuncModuleId(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMandarinCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMandarinCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMandarinCase_Resource_Rel.FuncModuleId);
objvMandarinCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FuncModuleId) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_MicroteachCase(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convMandarinCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMandarinCase_Resource_Rel.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMandarinCase_Resource_Rel.id_MicroteachCase);
objvMandarinCase_Resource_RelEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_MicroteachCase) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_MicroteachCase, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_MicroteachCase] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetUpdDate(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMandarinCase_Resource_Rel.UpdDate);
objvMandarinCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.UpdDate) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetUpdUser(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMandarinCase_Resource_Rel.UpdUser);
objvMandarinCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.UpdUser) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_Resource(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convMandarinCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convMandarinCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convMandarinCase_Resource_Rel.id_Resource);
objvMandarinCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_Resource) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetResourceID(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convMandarinCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convMandarinCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMandarinCase_Resource_Rel.ResourceID);
objvMandarinCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.ResourceID) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_FtpResource(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convMandarinCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convMandarinCase_Resource_Rel.id_FtpResource);
objvMandarinCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_FtpResource) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_File(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convMandarinCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convMandarinCase_Resource_Rel.id_File);
objvMandarinCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_File) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFileName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convMandarinCase_Resource_Rel.FileName);
objvMandarinCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FileName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFileType(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convMandarinCase_Resource_Rel.FileType);
objvMandarinCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FileType) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetSaveDate(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMandarinCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMandarinCase_Resource_Rel.SaveDate);
objvMandarinCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.SaveDate) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFileSize(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMandarinCase_Resource_Rel.FileSize);
objvMandarinCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FileSize) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetSaveTime(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMandarinCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMandarinCase_Resource_Rel.SaveTime);
objvMandarinCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.SaveTime) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFtpResourceID(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convMandarinCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMandarinCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMandarinCase_Resource_Rel.FtpResourceID);
objvMandarinCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FtpResourceID) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFileOriginalName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMandarinCase_Resource_Rel.FileOriginalName);
objvMandarinCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FileOriginalName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFileDirName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMandarinCase_Resource_Rel.FileDirName);
objvMandarinCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FileDirName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFileRename(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMandarinCase_Resource_Rel.FileRename);
objvMandarinCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FileRename) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFileUpDate(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMandarinCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMandarinCase_Resource_Rel.FileUpDate);
objvMandarinCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FileUpDate) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFileUpTime(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMandarinCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMandarinCase_Resource_Rel.FileUpTime);
objvMandarinCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FileUpTime) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetSaveMode(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvMandarinCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.SaveMode) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_ResourceType(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convMandarinCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convMandarinCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convMandarinCase_Resource_Rel.id_ResourceType);
objvMandarinCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_ResourceType) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetResourceTypeID(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convMandarinCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMandarinCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMandarinCase_Resource_Rel.ResourceTypeID);
objvMandarinCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.ResourceTypeID) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetResourceTypeName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convMandarinCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMandarinCase_Resource_Rel.ResourceTypeName);
objvMandarinCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.ResourceTypeName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetResourceOwner(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convMandarinCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMandarinCase_Resource_Rel.ResourceOwner);
objvMandarinCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.ResourceOwner) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetftpFileType(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMandarinCase_Resource_Rel.ftpFileType);
objvMandarinCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.ftpFileType) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetftpFileSize(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMandarinCase_Resource_Rel.ftpFileSize);
objvMandarinCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.ftpFileSize) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetftpResourceOwner(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMandarinCase_Resource_Rel.ftpResourceOwner);
objvMandarinCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.ftpResourceOwner) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFileOriginName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMandarinCase_Resource_Rel.FileOriginName);
objvMandarinCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FileOriginName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetIsExistFile(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvMandarinCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.IsExistFile) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFileNewName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMandarinCase_Resource_Rel.FileNewName);
objvMandarinCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FileNewName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetFileOldName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMandarinCase_Resource_Rel.FileOldName);
objvMandarinCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.FileOldName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_UsingMode(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_UsingMode, convMandarinCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convMandarinCase_Resource_Rel.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convMandarinCase_Resource_Rel.id_UsingMode);
objvMandarinCase_Resource_RelEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_UsingMode) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_UsingMode, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_UsingMode] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetIsVisible(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMandarinCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.IsVisible) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetIndexNO(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvMandarinCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.IndexNO) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetIsMain(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvMandarinCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.IsMain) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetBrowseCount(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvMandarinCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.BrowseCount) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetMemo(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMandarinCase_Resource_Rel.Memo);
objvMandarinCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.Memo) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_MandarinCase(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_MandarinCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MandarinCase, 8, convMandarinCase_Resource_Rel.id_MandarinCase);
clsCheckSql.CheckFieldForeignKey(strid_MandarinCase, 8, convMandarinCase_Resource_Rel.id_MandarinCase);
objvMandarinCase_Resource_RelEN.id_MandarinCase = strid_MandarinCase; //普通话案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_MandarinCase) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_MandarinCase, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_MandarinCase] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetMandarinCaseID(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strMandarinCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseID, 8, convMandarinCase_Resource_Rel.MandarinCaseID);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseID, 8, convMandarinCase_Resource_Rel.MandarinCaseID);
objvMandarinCase_Resource_RelEN.MandarinCaseID = strMandarinCaseID; //普通话教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.MandarinCaseID) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.MandarinCaseID, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseID] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetMandarinCaseName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strMandarinCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseName, 100, convMandarinCase_Resource_Rel.MandarinCaseName);
objvMandarinCase_Resource_RelEN.MandarinCaseName = strMandarinCaseName; //普通话教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.MandarinCaseName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.MandarinCaseName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_Discipline(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convMandarinCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convMandarinCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convMandarinCase_Resource_Rel.id_Discipline);
objvMandarinCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_Discipline) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetDisciplineID(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convMandarinCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convMandarinCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convMandarinCase_Resource_Rel.DisciplineID);
objvMandarinCase_Resource_RelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.DisciplineID) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.DisciplineID, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.DisciplineID] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetDisciplineName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convMandarinCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convMandarinCase_Resource_Rel.DisciplineName);
objvMandarinCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.DisciplineName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_StudyLevel(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convMandarinCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convMandarinCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convMandarinCase_Resource_Rel.id_StudyLevel);
objvMandarinCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_StudyLevel) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetStudyLevelName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convMandarinCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convMandarinCase_Resource_Rel.StudyLevelName);
objvMandarinCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.StudyLevelName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetMandarinCaseTheme(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strMandarinCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseTheme, 200, convMandarinCase_Resource_Rel.MandarinCaseTheme);
objvMandarinCase_Resource_RelEN.MandarinCaseTheme = strMandarinCaseTheme; //普通话教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.MandarinCaseTheme) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.MandarinCaseTheme, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseTheme] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetMandarinCaseDate(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strMandarinCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseDate, 8, convMandarinCase_Resource_Rel.MandarinCaseDate);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseDate, 8, convMandarinCase_Resource_Rel.MandarinCaseDate);
objvMandarinCase_Resource_RelEN.MandarinCaseDate = strMandarinCaseDate; //普通话教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.MandarinCaseDate) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.MandarinCaseDate, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseDate] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetMandarinCaseTime(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strMandarinCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseTime, 6, convMandarinCase_Resource_Rel.MandarinCaseTime);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseTime, 6, convMandarinCase_Resource_Rel.MandarinCaseTime);
objvMandarinCase_Resource_RelEN.MandarinCaseTime = strMandarinCaseTime; //普通话教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.MandarinCaseTime) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.MandarinCaseTime, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseTime] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetMandarinCaseDateIn(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strMandarinCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseDateIn, 8, convMandarinCase_Resource_Rel.MandarinCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseDateIn, 8, convMandarinCase_Resource_Rel.MandarinCaseDateIn);
objvMandarinCase_Resource_RelEN.MandarinCaseDateIn = strMandarinCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.MandarinCaseDateIn) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.MandarinCaseDateIn, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseDateIn] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetMandarinCaseTimeIn(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strMandarinCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMandarinCaseTimeIn, 6, convMandarinCase_Resource_Rel.MandarinCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strMandarinCaseTimeIn, 6, convMandarinCase_Resource_Rel.MandarinCaseTimeIn);
objvMandarinCase_Resource_RelEN.MandarinCaseTimeIn = strMandarinCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.MandarinCaseTimeIn) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.MandarinCaseTimeIn, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseTimeIn] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_TeachingPlan(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convMandarinCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convMandarinCase_Resource_Rel.id_TeachingPlan);
objvMandarinCase_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_TeachingPlan) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetsenateGaugeVersionID(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convMandarinCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMandarinCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMandarinCase_Resource_Rel.senateGaugeVersionID);
objvMandarinCase_Resource_RelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.senateGaugeVersionID) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetsenateGaugeVersionName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMandarinCase_Resource_Rel.senateGaugeVersionName);
objvMandarinCase_Resource_RelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.senateGaugeVersionName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetsenateGaugeVersionTtlScore(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore);
objvMandarinCase_Resource_RelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetVersionNo(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, int intVersionNo, string strComparisonOp="")
	{
objvMandarinCase_Resource_RelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.VersionNo) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.VersionNo, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.VersionNo] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetCaseLevelId(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convMandarinCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convMandarinCase_Resource_Rel.CaseLevelId);
objvMandarinCase_Resource_RelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.CaseLevelId) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.CaseLevelId, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.CaseLevelId] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetOwnerId(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMandarinCase_Resource_Rel.OwnerId);
objvMandarinCase_Resource_RelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.OwnerId) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.OwnerId, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.OwnerId] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetStuName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, convMandarinCase_Resource_Rel.StuName);
clsCheckSql.CheckFieldLen(strStuName, 50, convMandarinCase_Resource_Rel.StuName);
objvMandarinCase_Resource_RelEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.StuName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.StuName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.StuName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetStuID(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuID, convMandarinCase_Resource_Rel.StuID);
clsCheckSql.CheckFieldLen(strStuID, 20, convMandarinCase_Resource_Rel.StuID);
objvMandarinCase_Resource_RelEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.StuID) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.StuID, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.StuID] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetCollegeName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convMandarinCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMandarinCase_Resource_Rel.CollegeName);
objvMandarinCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.CollegeName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_XzCollege(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMandarinCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMandarinCase_Resource_Rel.id_XzCollege);
objvMandarinCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_XzCollege) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetCollegeNameA(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMandarinCase_Resource_Rel.CollegeNameA);
objvMandarinCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.CollegeNameA) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_XzMajor(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convMandarinCase_Resource_Rel.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convMandarinCase_Resource_Rel.id_XzMajor);
objvMandarinCase_Resource_RelEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_XzMajor) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_XzMajor, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_XzMajor] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_GradeBase(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convMandarinCase_Resource_Rel.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convMandarinCase_Resource_Rel.id_GradeBase);
objvMandarinCase_Resource_RelEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_GradeBase) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_GradeBase, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_GradeBase] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN Setid_AdminCls(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convMandarinCase_Resource_Rel.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convMandarinCase_Resource_Rel.id_AdminCls);
objvMandarinCase_Resource_RelEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.id_AdminCls) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.id_AdminCls, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_AdminCls] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetIsDualVideo(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvMandarinCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.IsDualVideo) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetRecommendedDegreeId(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convMandarinCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convMandarinCase_Resource_Rel.RecommendedDegreeId);
objvMandarinCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetRecommendedDegreeName(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convMandarinCase_Resource_Rel.RecommendedDegreeName);
objvMandarinCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMandarinCase_Resource_RelEN SetBrowseCount4Case(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvMandarinCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMandarinCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convMandarinCase_Resource_Rel.BrowseCount4Case) == false)
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp.Add(convMandarinCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvMandarinCase_Resource_RelEN.dicFldComparisonOp[convMandarinCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvMandarinCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCase_Resource_Rel.id_MicroteachCase_Resource_Rel, objvMandarinCase_Resource_Rel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FuncModuleName, objvMandarinCase_Resource_Rel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FuncModuleId, objvMandarinCase_Resource_Rel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_MicroteachCase, objvMandarinCase_Resource_Rel_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.UpdDate, objvMandarinCase_Resource_Rel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.UpdUser, objvMandarinCase_Resource_Rel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_Resource, objvMandarinCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.ResourceID, objvMandarinCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_FtpResource, objvMandarinCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_File, objvMandarinCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FileName, objvMandarinCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FileType, objvMandarinCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.SaveDate, objvMandarinCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FileSize, objvMandarinCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.SaveTime, objvMandarinCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FtpResourceID, objvMandarinCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FileOriginalName, objvMandarinCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FileDirName, objvMandarinCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FileRename, objvMandarinCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FileUpDate, objvMandarinCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FileUpTime, objvMandarinCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.SaveMode) == true)
{
if (objvMandarinCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCase_Resource_Rel.SaveMode);
}
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_ResourceType, objvMandarinCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.ResourceTypeID, objvMandarinCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.ResourceTypeName, objvMandarinCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.ResourceOwner, objvMandarinCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.ftpFileType, objvMandarinCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.ftpFileSize, objvMandarinCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.ftpResourceOwner, objvMandarinCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FileOriginName, objvMandarinCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.IsExistFile) == true)
{
if (objvMandarinCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCase_Resource_Rel.IsExistFile);
}
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FileNewName, objvMandarinCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.FileOldName, objvMandarinCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_UsingMode, objvMandarinCase_Resource_Rel_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.IsVisible) == true)
{
if (objvMandarinCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCase_Resource_Rel.IsVisible);
}
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCase_Resource_Rel.IndexNO, objvMandarinCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.IsMain) == true)
{
if (objvMandarinCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCase_Resource_Rel.IsMain);
}
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCase_Resource_Rel.BrowseCount, objvMandarinCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.Memo, objvMandarinCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_MandarinCase) == true)
{
string strComparisonOp_id_MandarinCase = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_MandarinCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_MandarinCase, objvMandarinCase_Resource_Rel_Cond.id_MandarinCase, strComparisonOp_id_MandarinCase);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.MandarinCaseID) == true)
{
string strComparisonOp_MandarinCaseID = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.MandarinCaseID, objvMandarinCase_Resource_Rel_Cond.MandarinCaseID, strComparisonOp_MandarinCaseID);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.MandarinCaseName) == true)
{
string strComparisonOp_MandarinCaseName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.MandarinCaseName, objvMandarinCase_Resource_Rel_Cond.MandarinCaseName, strComparisonOp_MandarinCaseName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_Discipline, objvMandarinCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.DisciplineID, objvMandarinCase_Resource_Rel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.DisciplineName, objvMandarinCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_StudyLevel, objvMandarinCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.StudyLevelName, objvMandarinCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.MandarinCaseTheme) == true)
{
string strComparisonOp_MandarinCaseTheme = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.MandarinCaseTheme, objvMandarinCase_Resource_Rel_Cond.MandarinCaseTheme, strComparisonOp_MandarinCaseTheme);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.MandarinCaseDate) == true)
{
string strComparisonOp_MandarinCaseDate = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.MandarinCaseDate, objvMandarinCase_Resource_Rel_Cond.MandarinCaseDate, strComparisonOp_MandarinCaseDate);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.MandarinCaseTime) == true)
{
string strComparisonOp_MandarinCaseTime = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.MandarinCaseTime, objvMandarinCase_Resource_Rel_Cond.MandarinCaseTime, strComparisonOp_MandarinCaseTime);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.MandarinCaseDateIn) == true)
{
string strComparisonOp_MandarinCaseDateIn = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.MandarinCaseDateIn, objvMandarinCase_Resource_Rel_Cond.MandarinCaseDateIn, strComparisonOp_MandarinCaseDateIn);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.MandarinCaseTimeIn) == true)
{
string strComparisonOp_MandarinCaseTimeIn = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.MandarinCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.MandarinCaseTimeIn, objvMandarinCase_Resource_Rel_Cond.MandarinCaseTimeIn, strComparisonOp_MandarinCaseTimeIn);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_TeachingPlan, objvMandarinCase_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.senateGaugeVersionID, objvMandarinCase_Resource_Rel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.senateGaugeVersionName, objvMandarinCase_Resource_Rel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore, objvMandarinCase_Resource_Rel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCase_Resource_Rel.VersionNo, objvMandarinCase_Resource_Rel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.CaseLevelId, objvMandarinCase_Resource_Rel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.OwnerId, objvMandarinCase_Resource_Rel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.StuName) == true)
{
string strComparisonOp_StuName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.StuName, objvMandarinCase_Resource_Rel_Cond.StuName, strComparisonOp_StuName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.StuID) == true)
{
string strComparisonOp_StuID = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.StuID, objvMandarinCase_Resource_Rel_Cond.StuID, strComparisonOp_StuID);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.CollegeName, objvMandarinCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_XzCollege, objvMandarinCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.CollegeNameA, objvMandarinCase_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_XzMajor, objvMandarinCase_Resource_Rel_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_GradeBase, objvMandarinCase_Resource_Rel_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.id_AdminCls, objvMandarinCase_Resource_Rel_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.IsDualVideo) == true)
{
if (objvMandarinCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMandarinCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMandarinCase_Resource_Rel.IsDualVideo);
}
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.RecommendedDegreeId, objvMandarinCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMandarinCase_Resource_Rel.RecommendedDegreeName, objvMandarinCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvMandarinCase_Resource_Rel_Cond.IsUpdated(convMandarinCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvMandarinCase_Resource_Rel_Cond.dicFldComparisonOp[convMandarinCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convMandarinCase_Resource_Rel.BrowseCount4Case, objvMandarinCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vMandarinCase_Resource_Rel(vMandarinCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMandarinCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vMandarinCase_Resource_RelApi";

 public clsvMandarinCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMandarinCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMandarinCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvMandarinCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCase_Resource_RelEN;
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMandarinCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMandarinCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvMandarinCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCase_Resource_RelEN;
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
public static clsvMandarinCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN = null;
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
objvMandarinCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvMandarinCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvMandarinCase_Resource_RelEN;
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMandarinCase_Resource_RelEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMandarinCase_Resource_RelEN._CurrTabName_S);
List<clsvMandarinCase_Resource_RelEN> arrvMandarinCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMandarinCase_Resource_RelEN> arrvMandarinCase_Resource_RelObjLst_Sel =
from objvMandarinCase_Resource_RelEN in arrvMandarinCase_Resource_RelObjLst_Cache
where objvMandarinCase_Resource_RelEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvMandarinCase_Resource_RelEN;
if (arrvMandarinCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvMandarinCase_Resource_RelEN obj = clsvMandarinCase_Resource_RelWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMandarinCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMandarinCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvMandarinCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvMandarinCase_Resource_RelEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCase_Resource_RelLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroteachCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMandarinCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMandarinCase_Resource_RelEN._CurrTabName_S);
List<clsvMandarinCase_Resource_RelEN> arrvMandarinCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMandarinCase_Resource_RelEN> arrvMandarinCase_Resource_RelObjLst_Sel =
from objvMandarinCase_Resource_RelEN in arrvMandarinCase_Resource_RelObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvMandarinCase_Resource_RelEN.id_MicroteachCase_Resource_Rel)
select objvMandarinCase_Resource_RelEN;
return arrvMandarinCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMandarinCase_Resource_RelEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvMandarinCase_Resource_RelEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachCase_Resource_RelLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMandarinCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMandarinCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMandarinCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMandarinCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMandarinCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMandarinCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_MicroteachCase_Resource_Rel)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachCase_Resource_Rel"] = lngid_MicroteachCase_Resource_Rel.ToString()
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
 /// <param name = "objvMandarinCase_Resource_RelENS">源对象</param>
 /// <param name = "objvMandarinCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelENS, clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelENT)
{
try
{
objvMandarinCase_Resource_RelENT.id_MicroteachCase_Resource_Rel = objvMandarinCase_Resource_RelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvMandarinCase_Resource_RelENT.FuncModuleName = objvMandarinCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvMandarinCase_Resource_RelENT.FuncModuleId = objvMandarinCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvMandarinCase_Resource_RelENT.id_MicroteachCase = objvMandarinCase_Resource_RelENS.id_MicroteachCase; //微格教学案例流水号
objvMandarinCase_Resource_RelENT.UpdDate = objvMandarinCase_Resource_RelENS.UpdDate; //修改日期
objvMandarinCase_Resource_RelENT.UpdUser = objvMandarinCase_Resource_RelENS.UpdUser; //修改人
objvMandarinCase_Resource_RelENT.id_Resource = objvMandarinCase_Resource_RelENS.id_Resource; //资源流水号
objvMandarinCase_Resource_RelENT.ResourceID = objvMandarinCase_Resource_RelENS.ResourceID; //资源ID
objvMandarinCase_Resource_RelENT.id_FtpResource = objvMandarinCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvMandarinCase_Resource_RelENT.id_File = objvMandarinCase_Resource_RelENS.id_File; //文件流水号
objvMandarinCase_Resource_RelENT.FileName = objvMandarinCase_Resource_RelENS.FileName; //文件名称
objvMandarinCase_Resource_RelENT.FileType = objvMandarinCase_Resource_RelENS.FileType; //文件类型
objvMandarinCase_Resource_RelENT.SaveDate = objvMandarinCase_Resource_RelENS.SaveDate; //创建日期
objvMandarinCase_Resource_RelENT.FileSize = objvMandarinCase_Resource_RelENS.FileSize; //文件大小
objvMandarinCase_Resource_RelENT.SaveTime = objvMandarinCase_Resource_RelENS.SaveTime; //创建时间
objvMandarinCase_Resource_RelENT.FtpResourceID = objvMandarinCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvMandarinCase_Resource_RelENT.FileOriginalName = objvMandarinCase_Resource_RelENS.FileOriginalName; //文件原名
objvMandarinCase_Resource_RelENT.FileDirName = objvMandarinCase_Resource_RelENS.FileDirName; //文件目录名
objvMandarinCase_Resource_RelENT.FileRename = objvMandarinCase_Resource_RelENS.FileRename; //文件新名
objvMandarinCase_Resource_RelENT.FileUpDate = objvMandarinCase_Resource_RelENS.FileUpDate; //创建日期
objvMandarinCase_Resource_RelENT.FileUpTime = objvMandarinCase_Resource_RelENS.FileUpTime; //创建时间
objvMandarinCase_Resource_RelENT.SaveMode = objvMandarinCase_Resource_RelENS.SaveMode; //文件存放方式
objvMandarinCase_Resource_RelENT.id_ResourceType = objvMandarinCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvMandarinCase_Resource_RelENT.ResourceTypeID = objvMandarinCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvMandarinCase_Resource_RelENT.ResourceTypeName = objvMandarinCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvMandarinCase_Resource_RelENT.ResourceOwner = objvMandarinCase_Resource_RelENS.ResourceOwner; //上传者
objvMandarinCase_Resource_RelENT.ftpFileType = objvMandarinCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvMandarinCase_Resource_RelENT.ftpFileSize = objvMandarinCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvMandarinCase_Resource_RelENT.ftpResourceOwner = objvMandarinCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvMandarinCase_Resource_RelENT.FileOriginName = objvMandarinCase_Resource_RelENS.FileOriginName; //原文件名
objvMandarinCase_Resource_RelENT.IsExistFile = objvMandarinCase_Resource_RelENS.IsExistFile; //是否存在文件
objvMandarinCase_Resource_RelENT.FileNewName = objvMandarinCase_Resource_RelENS.FileNewName; //新文件名
objvMandarinCase_Resource_RelENT.FileOldName = objvMandarinCase_Resource_RelENS.FileOldName; //旧文件名
objvMandarinCase_Resource_RelENT.id_UsingMode = objvMandarinCase_Resource_RelENS.id_UsingMode; //资源使用模式流水号
objvMandarinCase_Resource_RelENT.IsVisible = objvMandarinCase_Resource_RelENS.IsVisible; //是否显示
objvMandarinCase_Resource_RelENT.IndexNO = objvMandarinCase_Resource_RelENS.IndexNO; //序号
objvMandarinCase_Resource_RelENT.IsMain = objvMandarinCase_Resource_RelENS.IsMain; //是否主资源
objvMandarinCase_Resource_RelENT.BrowseCount = objvMandarinCase_Resource_RelENS.BrowseCount; //浏览次数
objvMandarinCase_Resource_RelENT.Memo = objvMandarinCase_Resource_RelENS.Memo; //备注
objvMandarinCase_Resource_RelENT.id_MandarinCase = objvMandarinCase_Resource_RelENS.id_MandarinCase; //普通话案例流水号
objvMandarinCase_Resource_RelENT.MandarinCaseID = objvMandarinCase_Resource_RelENS.MandarinCaseID; //普通话教学案例ID
objvMandarinCase_Resource_RelENT.MandarinCaseName = objvMandarinCase_Resource_RelENS.MandarinCaseName; //普通话教学案例名称
objvMandarinCase_Resource_RelENT.id_Discipline = objvMandarinCase_Resource_RelENS.id_Discipline; //学科流水号
objvMandarinCase_Resource_RelENT.DisciplineID = objvMandarinCase_Resource_RelENS.DisciplineID; //学科ID
objvMandarinCase_Resource_RelENT.DisciplineName = objvMandarinCase_Resource_RelENS.DisciplineName; //学科名称
objvMandarinCase_Resource_RelENT.id_StudyLevel = objvMandarinCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvMandarinCase_Resource_RelENT.StudyLevelName = objvMandarinCase_Resource_RelENS.StudyLevelName; //学段名称
objvMandarinCase_Resource_RelENT.MandarinCaseTheme = objvMandarinCase_Resource_RelENS.MandarinCaseTheme; //普通话教学案例主题词
objvMandarinCase_Resource_RelENT.MandarinCaseDate = objvMandarinCase_Resource_RelENS.MandarinCaseDate; //普通话教学日期
objvMandarinCase_Resource_RelENT.MandarinCaseTime = objvMandarinCase_Resource_RelENS.MandarinCaseTime; //普通话教学时间
objvMandarinCase_Resource_RelENT.MandarinCaseDateIn = objvMandarinCase_Resource_RelENS.MandarinCaseDateIn; //案例入库日期
objvMandarinCase_Resource_RelENT.MandarinCaseTimeIn = objvMandarinCase_Resource_RelENS.MandarinCaseTimeIn; //案例入库时间
objvMandarinCase_Resource_RelENT.id_TeachingPlan = objvMandarinCase_Resource_RelENS.id_TeachingPlan; //教案流水号
objvMandarinCase_Resource_RelENT.senateGaugeVersionID = objvMandarinCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvMandarinCase_Resource_RelENT.senateGaugeVersionName = objvMandarinCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvMandarinCase_Resource_RelENT.senateGaugeVersionTtlScore = objvMandarinCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMandarinCase_Resource_RelENT.VersionNo = objvMandarinCase_Resource_RelENS.VersionNo; //版本号
objvMandarinCase_Resource_RelENT.CaseLevelId = objvMandarinCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvMandarinCase_Resource_RelENT.OwnerId = objvMandarinCase_Resource_RelENS.OwnerId; //拥有者Id
objvMandarinCase_Resource_RelENT.StuName = objvMandarinCase_Resource_RelENS.StuName; //姓名
objvMandarinCase_Resource_RelENT.StuID = objvMandarinCase_Resource_RelENS.StuID; //学号
objvMandarinCase_Resource_RelENT.CollegeName = objvMandarinCase_Resource_RelENS.CollegeName; //学院名称
objvMandarinCase_Resource_RelENT.id_XzCollege = objvMandarinCase_Resource_RelENS.id_XzCollege; //学院流水号
objvMandarinCase_Resource_RelENT.CollegeNameA = objvMandarinCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvMandarinCase_Resource_RelENT.id_XzMajor = objvMandarinCase_Resource_RelENS.id_XzMajor; //专业流水号
objvMandarinCase_Resource_RelENT.id_GradeBase = objvMandarinCase_Resource_RelENS.id_GradeBase; //年级流水号
objvMandarinCase_Resource_RelENT.id_AdminCls = objvMandarinCase_Resource_RelENS.id_AdminCls; //行政班流水号
objvMandarinCase_Resource_RelENT.IsDualVideo = objvMandarinCase_Resource_RelENS.IsDualVideo; //是否双视频
objvMandarinCase_Resource_RelENT.RecommendedDegreeId = objvMandarinCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvMandarinCase_Resource_RelENT.RecommendedDegreeName = objvMandarinCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvMandarinCase_Resource_RelENT.BrowseCount4Case = objvMandarinCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
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
public static DataTable ToDataTable(List<clsvMandarinCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMandarinCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMandarinCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMandarinCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMandarinCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMandarinCase_Resource_RelEN.AttributeName)
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
if (clsMicroteachCase_Resource_RelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCase_Resource_RelWApi没有刷新缓存机制(clsMicroteachCase_Resource_RelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase_Resource_Rel");
//if (arrvMandarinCase_Resource_RelObjLst_Cache == null)
//{
//arrvMandarinCase_Resource_RelObjLst_Cache = await clsvMandarinCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMandarinCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvMandarinCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMandarinCase_Resource_RelEN._CurrTabName_S);
List<clsvMandarinCase_Resource_RelEN> arrvMandarinCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMandarinCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMandarinCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_MandarinCase, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.MandarinCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.MandarinCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.MandarinCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.MandarinCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.MandarinCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.MandarinCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.MandarinCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convMandarinCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
foreach (clsvMandarinCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMandarinCase_Resource_Rel.id_MicroteachCase_Resource_Rel] = objInFor[convMandarinCase_Resource_Rel.id_MicroteachCase_Resource_Rel];
objDR[convMandarinCase_Resource_Rel.FuncModuleName] = objInFor[convMandarinCase_Resource_Rel.FuncModuleName];
objDR[convMandarinCase_Resource_Rel.FuncModuleId] = objInFor[convMandarinCase_Resource_Rel.FuncModuleId];
objDR[convMandarinCase_Resource_Rel.id_MicroteachCase] = objInFor[convMandarinCase_Resource_Rel.id_MicroteachCase];
objDR[convMandarinCase_Resource_Rel.UpdDate] = objInFor[convMandarinCase_Resource_Rel.UpdDate];
objDR[convMandarinCase_Resource_Rel.UpdUser] = objInFor[convMandarinCase_Resource_Rel.UpdUser];
objDR[convMandarinCase_Resource_Rel.id_Resource] = objInFor[convMandarinCase_Resource_Rel.id_Resource];
objDR[convMandarinCase_Resource_Rel.ResourceID] = objInFor[convMandarinCase_Resource_Rel.ResourceID];
objDR[convMandarinCase_Resource_Rel.id_FtpResource] = objInFor[convMandarinCase_Resource_Rel.id_FtpResource];
objDR[convMandarinCase_Resource_Rel.id_File] = objInFor[convMandarinCase_Resource_Rel.id_File];
objDR[convMandarinCase_Resource_Rel.FileName] = objInFor[convMandarinCase_Resource_Rel.FileName];
objDR[convMandarinCase_Resource_Rel.FileType] = objInFor[convMandarinCase_Resource_Rel.FileType];
objDR[convMandarinCase_Resource_Rel.SaveDate] = objInFor[convMandarinCase_Resource_Rel.SaveDate];
objDR[convMandarinCase_Resource_Rel.FileSize] = objInFor[convMandarinCase_Resource_Rel.FileSize];
objDR[convMandarinCase_Resource_Rel.SaveTime] = objInFor[convMandarinCase_Resource_Rel.SaveTime];
objDR[convMandarinCase_Resource_Rel.FtpResourceID] = objInFor[convMandarinCase_Resource_Rel.FtpResourceID];
objDR[convMandarinCase_Resource_Rel.FileOriginalName] = objInFor[convMandarinCase_Resource_Rel.FileOriginalName];
objDR[convMandarinCase_Resource_Rel.FileDirName] = objInFor[convMandarinCase_Resource_Rel.FileDirName];
objDR[convMandarinCase_Resource_Rel.FileRename] = objInFor[convMandarinCase_Resource_Rel.FileRename];
objDR[convMandarinCase_Resource_Rel.FileUpDate] = objInFor[convMandarinCase_Resource_Rel.FileUpDate];
objDR[convMandarinCase_Resource_Rel.FileUpTime] = objInFor[convMandarinCase_Resource_Rel.FileUpTime];
objDR[convMandarinCase_Resource_Rel.SaveMode] = objInFor[convMandarinCase_Resource_Rel.SaveMode];
objDR[convMandarinCase_Resource_Rel.id_ResourceType] = objInFor[convMandarinCase_Resource_Rel.id_ResourceType];
objDR[convMandarinCase_Resource_Rel.ResourceTypeID] = objInFor[convMandarinCase_Resource_Rel.ResourceTypeID];
objDR[convMandarinCase_Resource_Rel.ResourceTypeName] = objInFor[convMandarinCase_Resource_Rel.ResourceTypeName];
objDR[convMandarinCase_Resource_Rel.ResourceOwner] = objInFor[convMandarinCase_Resource_Rel.ResourceOwner];
objDR[convMandarinCase_Resource_Rel.ftpFileType] = objInFor[convMandarinCase_Resource_Rel.ftpFileType];
objDR[convMandarinCase_Resource_Rel.ftpFileSize] = objInFor[convMandarinCase_Resource_Rel.ftpFileSize];
objDR[convMandarinCase_Resource_Rel.ftpResourceOwner] = objInFor[convMandarinCase_Resource_Rel.ftpResourceOwner];
objDR[convMandarinCase_Resource_Rel.FileOriginName] = objInFor[convMandarinCase_Resource_Rel.FileOriginName];
objDR[convMandarinCase_Resource_Rel.IsExistFile] = objInFor[convMandarinCase_Resource_Rel.IsExistFile];
objDR[convMandarinCase_Resource_Rel.FileNewName] = objInFor[convMandarinCase_Resource_Rel.FileNewName];
objDR[convMandarinCase_Resource_Rel.FileOldName] = objInFor[convMandarinCase_Resource_Rel.FileOldName];
objDR[convMandarinCase_Resource_Rel.id_UsingMode] = objInFor[convMandarinCase_Resource_Rel.id_UsingMode];
objDR[convMandarinCase_Resource_Rel.IsVisible] = objInFor[convMandarinCase_Resource_Rel.IsVisible];
objDR[convMandarinCase_Resource_Rel.IndexNO] = objInFor[convMandarinCase_Resource_Rel.IndexNO];
objDR[convMandarinCase_Resource_Rel.IsMain] = objInFor[convMandarinCase_Resource_Rel.IsMain];
objDR[convMandarinCase_Resource_Rel.BrowseCount] = objInFor[convMandarinCase_Resource_Rel.BrowseCount];
objDR[convMandarinCase_Resource_Rel.Memo] = objInFor[convMandarinCase_Resource_Rel.Memo];
objDR[convMandarinCase_Resource_Rel.id_MandarinCase] = objInFor[convMandarinCase_Resource_Rel.id_MandarinCase];
objDR[convMandarinCase_Resource_Rel.MandarinCaseID] = objInFor[convMandarinCase_Resource_Rel.MandarinCaseID];
objDR[convMandarinCase_Resource_Rel.MandarinCaseName] = objInFor[convMandarinCase_Resource_Rel.MandarinCaseName];
objDR[convMandarinCase_Resource_Rel.id_Discipline] = objInFor[convMandarinCase_Resource_Rel.id_Discipline];
objDR[convMandarinCase_Resource_Rel.DisciplineID] = objInFor[convMandarinCase_Resource_Rel.DisciplineID];
objDR[convMandarinCase_Resource_Rel.DisciplineName] = objInFor[convMandarinCase_Resource_Rel.DisciplineName];
objDR[convMandarinCase_Resource_Rel.id_StudyLevel] = objInFor[convMandarinCase_Resource_Rel.id_StudyLevel];
objDR[convMandarinCase_Resource_Rel.StudyLevelName] = objInFor[convMandarinCase_Resource_Rel.StudyLevelName];
objDR[convMandarinCase_Resource_Rel.MandarinCaseTheme] = objInFor[convMandarinCase_Resource_Rel.MandarinCaseTheme];
objDR[convMandarinCase_Resource_Rel.MandarinCaseDate] = objInFor[convMandarinCase_Resource_Rel.MandarinCaseDate];
objDR[convMandarinCase_Resource_Rel.MandarinCaseTime] = objInFor[convMandarinCase_Resource_Rel.MandarinCaseTime];
objDR[convMandarinCase_Resource_Rel.MandarinCaseDateIn] = objInFor[convMandarinCase_Resource_Rel.MandarinCaseDateIn];
objDR[convMandarinCase_Resource_Rel.MandarinCaseTimeIn] = objInFor[convMandarinCase_Resource_Rel.MandarinCaseTimeIn];
objDR[convMandarinCase_Resource_Rel.id_TeachingPlan] = objInFor[convMandarinCase_Resource_Rel.id_TeachingPlan];
objDR[convMandarinCase_Resource_Rel.senateGaugeVersionID] = objInFor[convMandarinCase_Resource_Rel.senateGaugeVersionID];
objDR[convMandarinCase_Resource_Rel.senateGaugeVersionName] = objInFor[convMandarinCase_Resource_Rel.senateGaugeVersionName];
objDR[convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore] = objInFor[convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore];
objDR[convMandarinCase_Resource_Rel.VersionNo] = objInFor[convMandarinCase_Resource_Rel.VersionNo];
objDR[convMandarinCase_Resource_Rel.CaseLevelId] = objInFor[convMandarinCase_Resource_Rel.CaseLevelId];
objDR[convMandarinCase_Resource_Rel.OwnerId] = objInFor[convMandarinCase_Resource_Rel.OwnerId];
objDR[convMandarinCase_Resource_Rel.StuName] = objInFor[convMandarinCase_Resource_Rel.StuName];
objDR[convMandarinCase_Resource_Rel.StuID] = objInFor[convMandarinCase_Resource_Rel.StuID];
objDR[convMandarinCase_Resource_Rel.CollegeName] = objInFor[convMandarinCase_Resource_Rel.CollegeName];
objDR[convMandarinCase_Resource_Rel.id_XzCollege] = objInFor[convMandarinCase_Resource_Rel.id_XzCollege];
objDR[convMandarinCase_Resource_Rel.CollegeNameA] = objInFor[convMandarinCase_Resource_Rel.CollegeNameA];
objDR[convMandarinCase_Resource_Rel.id_XzMajor] = objInFor[convMandarinCase_Resource_Rel.id_XzMajor];
objDR[convMandarinCase_Resource_Rel.id_GradeBase] = objInFor[convMandarinCase_Resource_Rel.id_GradeBase];
objDR[convMandarinCase_Resource_Rel.id_AdminCls] = objInFor[convMandarinCase_Resource_Rel.id_AdminCls];
objDR[convMandarinCase_Resource_Rel.IsDualVideo] = objInFor[convMandarinCase_Resource_Rel.IsDualVideo];
objDR[convMandarinCase_Resource_Rel.RecommendedDegreeId] = objInFor[convMandarinCase_Resource_Rel.RecommendedDegreeId];
objDR[convMandarinCase_Resource_Rel.RecommendedDegreeName] = objInFor[convMandarinCase_Resource_Rel.RecommendedDegreeName];
objDR[convMandarinCase_Resource_Rel.BrowseCount4Case] = objInFor[convMandarinCase_Resource_Rel.BrowseCount4Case];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}