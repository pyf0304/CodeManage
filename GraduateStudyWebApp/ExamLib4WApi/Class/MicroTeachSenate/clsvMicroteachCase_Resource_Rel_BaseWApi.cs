
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel_BaseWApi
 表名:vMicroteachCase_Resource_Rel_Base(01120490)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:45
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
public static class clsvMicroteachCase_Resource_Rel_BaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN Setid_MicroteachCase_Resource_Rel(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.id_MicroteachCase_Resource_Rel) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFuncModuleId(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachCase_Resource_Rel_Base.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCase_Resource_Rel_Base.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCase_Resource_Rel_Base.FuncModuleId);
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FuncModuleId) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FuncModuleId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FuncModuleId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFuncModuleName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachCase_Resource_Rel_Base.FuncModuleName);
objvMicroteachCase_Resource_Rel_BaseEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FuncModuleName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FuncModuleName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FuncModuleName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN Setid_MicroteachCase(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convMicroteachCase_Resource_Rel_Base.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroteachCase_Resource_Rel_Base.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroteachCase_Resource_Rel_Base.id_MicroteachCase);
objvMicroteachCase_Resource_Rel_BaseEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.id_MicroteachCase) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN Setid_Resource(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convMicroteachCase_Resource_Rel_Base.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convMicroteachCase_Resource_Rel_Base.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convMicroteachCase_Resource_Rel_Base.id_Resource);
objvMicroteachCase_Resource_Rel_BaseEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.id_Resource) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.id_Resource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_Resource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetResourceID(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convMicroteachCase_Resource_Rel_Base.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convMicroteachCase_Resource_Rel_Base.ResourceID);
objvMicroteachCase_Resource_Rel_BaseEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ResourceID) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ResourceID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetResourceName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convMicroteachCase_Resource_Rel_Base.ResourceName);
objvMicroteachCase_Resource_Rel_BaseEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ResourceName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ResourceName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN Setid_FtpResource(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convMicroteachCase_Resource_Rel_Base.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convMicroteachCase_Resource_Rel_Base.id_FtpResource);
objvMicroteachCase_Resource_Rel_BaseEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.id_FtpResource) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.id_FtpResource, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_FtpResource] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN Setid_File(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convMicroteachCase_Resource_Rel_Base.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convMicroteachCase_Resource_Rel_Base.id_File);
objvMicroteachCase_Resource_Rel_BaseEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.id_File) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.id_File, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_File] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convMicroteachCase_Resource_Rel_Base.FileName);
objvMicroteachCase_Resource_Rel_BaseEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileType(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convMicroteachCase_Resource_Rel_Base.FileType);
objvMicroteachCase_Resource_Rel_BaseEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileType) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetSaveDate(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convMicroteachCase_Resource_Rel_Base.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convMicroteachCase_Resource_Rel_Base.SaveDate);
objvMicroteachCase_Resource_Rel_BaseEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.SaveDate) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.SaveDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.SaveDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileSize(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convMicroteachCase_Resource_Rel_Base.FileSize);
objvMicroteachCase_Resource_Rel_BaseEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileSize) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileSize, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileSize] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetSaveTime(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convMicroteachCase_Resource_Rel_Base.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convMicroteachCase_Resource_Rel_Base.SaveTime);
objvMicroteachCase_Resource_Rel_BaseEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.SaveTime) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.SaveTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.SaveTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFtpResourceID(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convMicroteachCase_Resource_Rel_Base.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convMicroteachCase_Resource_Rel_Base.FtpResourceID);
objvMicroteachCase_Resource_Rel_BaseEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FtpResourceID) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FtpResourceID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FtpResourceID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileOriginalName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convMicroteachCase_Resource_Rel_Base.FileOriginalName);
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileOriginalName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileOriginalName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOriginalName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileDirName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convMicroteachCase_Resource_Rel_Base.FileDirName);
objvMicroteachCase_Resource_Rel_BaseEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileDirName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileDirName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileDirName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileRename(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convMicroteachCase_Resource_Rel_Base.FileRename);
objvMicroteachCase_Resource_Rel_BaseEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileRename) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileRename, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileRename] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileUpDate(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convMicroteachCase_Resource_Rel_Base.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convMicroteachCase_Resource_Rel_Base.FileUpDate);
objvMicroteachCase_Resource_Rel_BaseEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileUpDate) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileUpDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileUpDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileUpTime(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convMicroteachCase_Resource_Rel_Base.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convMicroteachCase_Resource_Rel_Base.FileUpTime);
objvMicroteachCase_Resource_Rel_BaseEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileUpTime) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileUpTime, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileUpTime] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetSaveMode(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, bool bolSaveMode, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.SaveMode) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.SaveMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.SaveMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN Setid_ResourceType(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convMicroteachCase_Resource_Rel_Base.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convMicroteachCase_Resource_Rel_Base.id_ResourceType);
objvMicroteachCase_Resource_Rel_BaseEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.id_ResourceType) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.id_ResourceType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_ResourceType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetResourceTypeID(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convMicroteachCase_Resource_Rel_Base.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convMicroteachCase_Resource_Rel_Base.ResourceTypeID);
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ResourceTypeID) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ResourceTypeID, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetResourceTypeName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convMicroteachCase_Resource_Rel_Base.ResourceTypeName);
objvMicroteachCase_Resource_Rel_BaseEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ResourceTypeName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ResourceTypeName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetResourceOwner(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convMicroteachCase_Resource_Rel_Base.ResourceOwner);
objvMicroteachCase_Resource_Rel_BaseEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ResourceOwner) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetftpFileType(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convMicroteachCase_Resource_Rel_Base.ftpFileType);
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ftpFileType) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ftpFileType, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpFileType] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetftpFileSize(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convMicroteachCase_Resource_Rel_Base.ftpFileSize);
objvMicroteachCase_Resource_Rel_BaseEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ftpFileSize) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ftpFileSize, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpFileSize] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetftpResourceOwner(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convMicroteachCase_Resource_Rel_Base.ftpResourceOwner);
objvMicroteachCase_Resource_Rel_BaseEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.ftpResourceOwner) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.ftpResourceOwner, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileOriginName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convMicroteachCase_Resource_Rel_Base.FileOriginName);
objvMicroteachCase_Resource_Rel_BaseEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileOriginName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileOriginName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOriginName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIsExistFile(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IsExistFile) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IsExistFile, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IsExistFile] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileNewName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convMicroteachCase_Resource_Rel_Base.FileNewName);
objvMicroteachCase_Resource_Rel_BaseEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileNewName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileNewName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileNewName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetFileOldName(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convMicroteachCase_Resource_Rel_Base.FileOldName);
objvMicroteachCase_Resource_Rel_BaseEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.FileOldName) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.FileOldName, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOldName] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIsMain(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, bool bolIsMain, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IsMain) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IsMain, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IsMain] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN Setid_UsingMode(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strid_UsingMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UsingMode, 4, convMicroteachCase_Resource_Rel_Base.id_UsingMode);
clsCheckSql.CheckFieldForeignKey(strid_UsingMode, 4, convMicroteachCase_Resource_Rel_Base.id_UsingMode);
objvMicroteachCase_Resource_Rel_BaseEN.id_UsingMode = strid_UsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.id_UsingMode) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.id_UsingMode, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_UsingMode] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetIndexNO(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, int intIndexNO, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.IndexNO) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.IndexNO, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IndexNO] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetBrowseCount(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, int intBrowseCount, string strComparisonOp="")
	{
objvMicroteachCase_Resource_Rel_BaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.BrowseCount) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.BrowseCount, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.BrowseCount] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetUpdDate(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroteachCase_Resource_Rel_Base.UpdDate);
objvMicroteachCase_Resource_Rel_BaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.UpdDate) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.UpdDate, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.UpdDate] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetUpdUser(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCase_Resource_Rel_Base.UpdUser);
objvMicroteachCase_Resource_Rel_BaseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.UpdUser) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.UpdUser, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.UpdUser] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN SetMemo(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMicroteachCase_Resource_Rel_Base.Memo);
objvMicroteachCase_Resource_Rel_BaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_Rel_Base.Memo) == false)
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_Rel_Base.Memo, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_Rel_BaseEN.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.Memo] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_Rel_BaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_Base_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel_Base.id_MicroteachCase_Resource_Rel, objvMicroteachCase_Resource_Rel_Base_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FuncModuleId, objvMicroteachCase_Resource_Rel_Base_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FuncModuleName, objvMicroteachCase_Resource_Rel_Base_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.id_MicroteachCase, objvMicroteachCase_Resource_Rel_Base_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.id_Resource, objvMicroteachCase_Resource_Rel_Base_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ResourceID, objvMicroteachCase_Resource_Rel_Base_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ResourceName, objvMicroteachCase_Resource_Rel_Base_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.id_FtpResource, objvMicroteachCase_Resource_Rel_Base_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.id_File) == true)
{
string strComparisonOp_id_File = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.id_File, objvMicroteachCase_Resource_Rel_Base_Cond.id_File, strComparisonOp_id_File);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileName) == true)
{
string strComparisonOp_FileName = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileName, objvMicroteachCase_Resource_Rel_Base_Cond.FileName, strComparisonOp_FileName);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileType) == true)
{
string strComparisonOp_FileType = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileType, objvMicroteachCase_Resource_Rel_Base_Cond.FileType, strComparisonOp_FileType);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.SaveDate, objvMicroteachCase_Resource_Rel_Base_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileSize) == true)
{
string strComparisonOp_FileSize = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileSize, objvMicroteachCase_Resource_Rel_Base_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.SaveTime, objvMicroteachCase_Resource_Rel_Base_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FtpResourceID, objvMicroteachCase_Resource_Rel_Base_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileOriginalName, objvMicroteachCase_Resource_Rel_Base_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileDirName, objvMicroteachCase_Resource_Rel_Base_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileRename) == true)
{
string strComparisonOp_FileRename = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileRename, objvMicroteachCase_Resource_Rel_Base_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileUpDate, objvMicroteachCase_Resource_Rel_Base_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileUpTime, objvMicroteachCase_Resource_Rel_Base_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.SaveMode) == true)
{
if (objvMicroteachCase_Resource_Rel_Base_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel_Base.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel_Base.SaveMode);
}
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.id_ResourceType, objvMicroteachCase_Resource_Rel_Base_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ResourceTypeID, objvMicroteachCase_Resource_Rel_Base_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ResourceTypeName, objvMicroteachCase_Resource_Rel_Base_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ResourceOwner, objvMicroteachCase_Resource_Rel_Base_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ftpFileType, objvMicroteachCase_Resource_Rel_Base_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ftpFileSize, objvMicroteachCase_Resource_Rel_Base_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.ftpResourceOwner, objvMicroteachCase_Resource_Rel_Base_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileOriginName, objvMicroteachCase_Resource_Rel_Base_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IsExistFile) == true)
{
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel_Base.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel_Base.IsExistFile);
}
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileNewName, objvMicroteachCase_Resource_Rel_Base_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.FileOldName, objvMicroteachCase_Resource_Rel_Base_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IsMain) == true)
{
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCase_Resource_Rel_Base.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCase_Resource_Rel_Base.IsMain);
}
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.id_UsingMode) == true)
{
string strComparisonOp_id_UsingMode = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.id_UsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.id_UsingMode, objvMicroteachCase_Resource_Rel_Base_Cond.id_UsingMode, strComparisonOp_id_UsingMode);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel_Base.IndexNO, objvMicroteachCase_Resource_Rel_Base_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_Rel_Base.BrowseCount, objvMicroteachCase_Resource_Rel_Base_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.UpdDate, objvMicroteachCase_Resource_Rel_Base_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.UpdUser, objvMicroteachCase_Resource_Rel_Base_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvMicroteachCase_Resource_Rel_Base_Cond.IsUpdated(convMicroteachCase_Resource_Rel_Base.Memo) == true)
{
string strComparisonOp_Memo = objvMicroteachCase_Resource_Rel_Base_Cond.dicFldComparisonOp[convMicroteachCase_Resource_Rel_Base.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_Rel_Base.Memo, objvMicroteachCase_Resource_Rel_Base_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vMicroteachCase_Resource_Rel_Base(vMicroteachCase_Resource_Rel_Base)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase_Resource_Rel_BaseWApi
{
private static readonly string mstrApiControllerName = "vMicroteachCase_Resource_Rel_BaseApi";

 public clsvMicroteachCase_Resource_Rel_BaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_Rel_BaseEN GetObjByid_MicroteachCase_Resource_Rel(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = null;
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
objvMicroteachCase_Resource_Rel_BaseEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_Rel_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_Rel_BaseEN;
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
public static clsvMicroteachCase_Resource_Rel_BaseEN GetObjByid_MicroteachCase_Resource_Rel_WA_Cache(long lngid_MicroteachCase_Resource_Rel)
{
string strAction = "GetObjByid_MicroteachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = null;
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
objvMicroteachCase_Resource_Rel_BaseEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_Rel_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_Rel_BaseEN;
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
public static clsvMicroteachCase_Resource_Rel_BaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseEN = null;
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
objvMicroteachCase_Resource_Rel_BaseEN = JsonConvert.DeserializeObject<clsvMicroteachCase_Resource_Rel_BaseEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCase_Resource_Rel_BaseEN;
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
public static clsvMicroteachCase_Resource_Rel_BaseEN GetObjByid_MicroteachCase_Resource_Rel_Cache(long lngid_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrvMicroteachCase_Resource_Rel_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase_Resource_Rel_BaseEN> arrvMicroteachCase_Resource_Rel_BaseObjLst_Sel =
from objvMicroteachCase_Resource_Rel_BaseEN in arrvMicroteachCase_Resource_Rel_BaseObjLst_Cache
where objvMicroteachCase_Resource_Rel_BaseEN.id_MicroteachCase_Resource_Rel == lngid_MicroteachCase_Resource_Rel
select objvMicroteachCase_Resource_Rel_BaseEN;
if (arrvMicroteachCase_Resource_Rel_BaseObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase_Resource_Rel_BaseEN obj = clsvMicroteachCase_Resource_Rel_BaseWApi.GetObjByid_MicroteachCase_Resource_Rel(lngid_MicroteachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroteachCase_Resource_Rel_BaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstById_MicroteachCase_Resource_RelLst(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstById_MicroteachCase_Resource_RelLst_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrvMicroteachCase_Resource_Rel_BaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCase_Resource_Rel_BaseEN> arrvMicroteachCase_Resource_Rel_BaseObjLst_Sel =
from objvMicroteachCase_Resource_Rel_BaseEN in arrvMicroteachCase_Resource_Rel_BaseObjLst_Cache
where arrId_MicroteachCase_Resource_Rel.Contains(objvMicroteachCase_Resource_Rel_BaseEN.id_MicroteachCase_Resource_Rel)
select objvMicroteachCase_Resource_Rel_BaseEN;
return arrvMicroteachCase_Resource_Rel_BaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstById_MicroteachCase_Resource_RelLst_WA_Cache(List<long> arrId_MicroteachCase_Resource_Rel)
{
 List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCase_Resource_Rel_BaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel_BaseENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseENS, clsvMicroteachCase_Resource_Rel_BaseEN objvMicroteachCase_Resource_Rel_BaseENT)
{
try
{
objvMicroteachCase_Resource_Rel_BaseENT.id_MicroteachCase_Resource_Rel = objvMicroteachCase_Resource_Rel_BaseENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel_BaseENT.FuncModuleId = objvMicroteachCase_Resource_Rel_BaseENS.FuncModuleId; //功能模块Id
objvMicroteachCase_Resource_Rel_BaseENT.FuncModuleName = objvMicroteachCase_Resource_Rel_BaseENS.FuncModuleName; //功能模块名称
objvMicroteachCase_Resource_Rel_BaseENT.id_MicroteachCase = objvMicroteachCase_Resource_Rel_BaseENS.id_MicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel_BaseENT.id_Resource = objvMicroteachCase_Resource_Rel_BaseENS.id_Resource; //资源流水号
objvMicroteachCase_Resource_Rel_BaseENT.ResourceID = objvMicroteachCase_Resource_Rel_BaseENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel_BaseENT.ResourceName = objvMicroteachCase_Resource_Rel_BaseENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel_BaseENT.id_FtpResource = objvMicroteachCase_Resource_Rel_BaseENS.id_FtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel_BaseENT.id_File = objvMicroteachCase_Resource_Rel_BaseENS.id_File; //文件流水号
objvMicroteachCase_Resource_Rel_BaseENT.FileName = objvMicroteachCase_Resource_Rel_BaseENS.FileName; //文件名称
objvMicroteachCase_Resource_Rel_BaseENT.FileType = objvMicroteachCase_Resource_Rel_BaseENS.FileType; //文件类型
objvMicroteachCase_Resource_Rel_BaseENT.SaveDate = objvMicroteachCase_Resource_Rel_BaseENS.SaveDate; //创建日期
objvMicroteachCase_Resource_Rel_BaseENT.FileSize = objvMicroteachCase_Resource_Rel_BaseENS.FileSize; //文件大小
objvMicroteachCase_Resource_Rel_BaseENT.SaveTime = objvMicroteachCase_Resource_Rel_BaseENS.SaveTime; //创建时间
objvMicroteachCase_Resource_Rel_BaseENT.FtpResourceID = objvMicroteachCase_Resource_Rel_BaseENS.FtpResourceID; //FTP资源ID
objvMicroteachCase_Resource_Rel_BaseENT.FileOriginalName = objvMicroteachCase_Resource_Rel_BaseENS.FileOriginalName; //文件原名
objvMicroteachCase_Resource_Rel_BaseENT.FileDirName = objvMicroteachCase_Resource_Rel_BaseENS.FileDirName; //文件目录名
objvMicroteachCase_Resource_Rel_BaseENT.FileRename = objvMicroteachCase_Resource_Rel_BaseENS.FileRename; //文件新名
objvMicroteachCase_Resource_Rel_BaseENT.FileUpDate = objvMicroteachCase_Resource_Rel_BaseENS.FileUpDate; //创建日期
objvMicroteachCase_Resource_Rel_BaseENT.FileUpTime = objvMicroteachCase_Resource_Rel_BaseENS.FileUpTime; //创建时间
objvMicroteachCase_Resource_Rel_BaseENT.SaveMode = objvMicroteachCase_Resource_Rel_BaseENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_Rel_BaseENT.id_ResourceType = objvMicroteachCase_Resource_Rel_BaseENS.id_ResourceType; //资源类型流水号
objvMicroteachCase_Resource_Rel_BaseENT.ResourceTypeID = objvMicroteachCase_Resource_Rel_BaseENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_Rel_BaseENT.ResourceTypeName = objvMicroteachCase_Resource_Rel_BaseENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_Rel_BaseENT.ResourceOwner = objvMicroteachCase_Resource_Rel_BaseENS.ResourceOwner; //上传者
objvMicroteachCase_Resource_Rel_BaseENT.ftpFileType = objvMicroteachCase_Resource_Rel_BaseENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_Rel_BaseENT.ftpFileSize = objvMicroteachCase_Resource_Rel_BaseENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_Rel_BaseENT.ftpResourceOwner = objvMicroteachCase_Resource_Rel_BaseENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_Rel_BaseENT.FileOriginName = objvMicroteachCase_Resource_Rel_BaseENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_Rel_BaseENT.IsExistFile = objvMicroteachCase_Resource_Rel_BaseENS.IsExistFile; //是否存在文件
objvMicroteachCase_Resource_Rel_BaseENT.FileNewName = objvMicroteachCase_Resource_Rel_BaseENS.FileNewName; //新文件名
objvMicroteachCase_Resource_Rel_BaseENT.FileOldName = objvMicroteachCase_Resource_Rel_BaseENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_Rel_BaseENT.IsMain = objvMicroteachCase_Resource_Rel_BaseENS.IsMain; //是否主资源
objvMicroteachCase_Resource_Rel_BaseENT.id_UsingMode = objvMicroteachCase_Resource_Rel_BaseENS.id_UsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_Rel_BaseENT.IndexNO = objvMicroteachCase_Resource_Rel_BaseENS.IndexNO; //序号
objvMicroteachCase_Resource_Rel_BaseENT.BrowseCount = objvMicroteachCase_Resource_Rel_BaseENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_Rel_BaseENT.UpdDate = objvMicroteachCase_Resource_Rel_BaseENS.UpdDate; //修改日期
objvMicroteachCase_Resource_Rel_BaseENT.UpdUser = objvMicroteachCase_Resource_Rel_BaseENS.UpdUser; //修改人
objvMicroteachCase_Resource_Rel_BaseENT.Memo = objvMicroteachCase_Resource_Rel_BaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroteachCase_Resource_Rel_BaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroteachCase_Resource_Rel_BaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroteachCase_Resource_Rel_BaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroteachCase_Resource_Rel_BaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroteachCase_Resource_Rel_BaseEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachCase_Resource_Rel");
//if (arrvMicroteachCase_Resource_Rel_BaseObjLst_Cache == null)
//{
//arrvMicroteachCase_Resource_Rel_BaseObjLst_Cache = await clsvMicroteachCase_Resource_Rel_BaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName_S);
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
public static List<clsvMicroteachCase_Resource_Rel_BaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_Rel_BaseEN._CurrTabName_S);
List<clsvMicroteachCase_Resource_Rel_BaseEN> arrvMicroteachCase_Resource_Rel_BaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase_Resource_Rel_BaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroteachCase_Resource_Rel_BaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.id_UsingMode, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCase_Resource_Rel_Base.Memo, Type.GetType("System.String"));
foreach (clsvMicroteachCase_Resource_Rel_BaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroteachCase_Resource_Rel_Base.id_MicroteachCase_Resource_Rel] = objInFor[convMicroteachCase_Resource_Rel_Base.id_MicroteachCase_Resource_Rel];
objDR[convMicroteachCase_Resource_Rel_Base.FuncModuleId] = objInFor[convMicroteachCase_Resource_Rel_Base.FuncModuleId];
objDR[convMicroteachCase_Resource_Rel_Base.FuncModuleName] = objInFor[convMicroteachCase_Resource_Rel_Base.FuncModuleName];
objDR[convMicroteachCase_Resource_Rel_Base.id_MicroteachCase] = objInFor[convMicroteachCase_Resource_Rel_Base.id_MicroteachCase];
objDR[convMicroteachCase_Resource_Rel_Base.id_Resource] = objInFor[convMicroteachCase_Resource_Rel_Base.id_Resource];
objDR[convMicroteachCase_Resource_Rel_Base.ResourceID] = objInFor[convMicroteachCase_Resource_Rel_Base.ResourceID];
objDR[convMicroteachCase_Resource_Rel_Base.ResourceName] = objInFor[convMicroteachCase_Resource_Rel_Base.ResourceName];
objDR[convMicroteachCase_Resource_Rel_Base.id_FtpResource] = objInFor[convMicroteachCase_Resource_Rel_Base.id_FtpResource];
objDR[convMicroteachCase_Resource_Rel_Base.id_File] = objInFor[convMicroteachCase_Resource_Rel_Base.id_File];
objDR[convMicroteachCase_Resource_Rel_Base.FileName] = objInFor[convMicroteachCase_Resource_Rel_Base.FileName];
objDR[convMicroteachCase_Resource_Rel_Base.FileType] = objInFor[convMicroteachCase_Resource_Rel_Base.FileType];
objDR[convMicroteachCase_Resource_Rel_Base.SaveDate] = objInFor[convMicroteachCase_Resource_Rel_Base.SaveDate];
objDR[convMicroteachCase_Resource_Rel_Base.FileSize] = objInFor[convMicroteachCase_Resource_Rel_Base.FileSize];
objDR[convMicroteachCase_Resource_Rel_Base.SaveTime] = objInFor[convMicroteachCase_Resource_Rel_Base.SaveTime];
objDR[convMicroteachCase_Resource_Rel_Base.FtpResourceID] = objInFor[convMicroteachCase_Resource_Rel_Base.FtpResourceID];
objDR[convMicroteachCase_Resource_Rel_Base.FileOriginalName] = objInFor[convMicroteachCase_Resource_Rel_Base.FileOriginalName];
objDR[convMicroteachCase_Resource_Rel_Base.FileDirName] = objInFor[convMicroteachCase_Resource_Rel_Base.FileDirName];
objDR[convMicroteachCase_Resource_Rel_Base.FileRename] = objInFor[convMicroteachCase_Resource_Rel_Base.FileRename];
objDR[convMicroteachCase_Resource_Rel_Base.FileUpDate] = objInFor[convMicroteachCase_Resource_Rel_Base.FileUpDate];
objDR[convMicroteachCase_Resource_Rel_Base.FileUpTime] = objInFor[convMicroteachCase_Resource_Rel_Base.FileUpTime];
objDR[convMicroteachCase_Resource_Rel_Base.SaveMode] = objInFor[convMicroteachCase_Resource_Rel_Base.SaveMode];
objDR[convMicroteachCase_Resource_Rel_Base.id_ResourceType] = objInFor[convMicroteachCase_Resource_Rel_Base.id_ResourceType];
objDR[convMicroteachCase_Resource_Rel_Base.ResourceTypeID] = objInFor[convMicroteachCase_Resource_Rel_Base.ResourceTypeID];
objDR[convMicroteachCase_Resource_Rel_Base.ResourceTypeName] = objInFor[convMicroteachCase_Resource_Rel_Base.ResourceTypeName];
objDR[convMicroteachCase_Resource_Rel_Base.ResourceOwner] = objInFor[convMicroteachCase_Resource_Rel_Base.ResourceOwner];
objDR[convMicroteachCase_Resource_Rel_Base.ftpFileType] = objInFor[convMicroteachCase_Resource_Rel_Base.ftpFileType];
objDR[convMicroteachCase_Resource_Rel_Base.ftpFileSize] = objInFor[convMicroteachCase_Resource_Rel_Base.ftpFileSize];
objDR[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner] = objInFor[convMicroteachCase_Resource_Rel_Base.ftpResourceOwner];
objDR[convMicroteachCase_Resource_Rel_Base.FileOriginName] = objInFor[convMicroteachCase_Resource_Rel_Base.FileOriginName];
objDR[convMicroteachCase_Resource_Rel_Base.IsExistFile] = objInFor[convMicroteachCase_Resource_Rel_Base.IsExistFile];
objDR[convMicroteachCase_Resource_Rel_Base.FileNewName] = objInFor[convMicroteachCase_Resource_Rel_Base.FileNewName];
objDR[convMicroteachCase_Resource_Rel_Base.FileOldName] = objInFor[convMicroteachCase_Resource_Rel_Base.FileOldName];
objDR[convMicroteachCase_Resource_Rel_Base.IsMain] = objInFor[convMicroteachCase_Resource_Rel_Base.IsMain];
objDR[convMicroteachCase_Resource_Rel_Base.id_UsingMode] = objInFor[convMicroteachCase_Resource_Rel_Base.id_UsingMode];
objDR[convMicroteachCase_Resource_Rel_Base.IndexNO] = objInFor[convMicroteachCase_Resource_Rel_Base.IndexNO];
objDR[convMicroteachCase_Resource_Rel_Base.BrowseCount] = objInFor[convMicroteachCase_Resource_Rel_Base.BrowseCount];
objDR[convMicroteachCase_Resource_Rel_Base.UpdDate] = objInFor[convMicroteachCase_Resource_Rel_Base.UpdDate];
objDR[convMicroteachCase_Resource_Rel_Base.UpdUser] = objInFor[convMicroteachCase_Resource_Rel_Base.UpdUser];
objDR[convMicroteachCase_Resource_Rel_Base.Memo] = objInFor[convMicroteachCase_Resource_Rel_Base.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}