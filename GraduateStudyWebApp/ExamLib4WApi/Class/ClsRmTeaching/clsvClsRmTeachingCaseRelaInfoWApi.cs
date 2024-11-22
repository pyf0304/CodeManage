
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCaseRelaInfoWApi
 表名:vClsRmTeachingCaseRelaInfo(01120404)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:20
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学
 模块英文名:ClsRmTeaching
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
public static class clsvClsRmTeachingCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvClsRmTeachingCaseRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN Setid_MicroteachCase(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convClsRmTeachingCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convClsRmTeachingCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convClsRmTeachingCaseRelaInfo.id_MicroteachCase);
objvClsRmTeachingCaseRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.id_MicroteachCase) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetId_ClsRmTeachingCase(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strId_ClsRmTeachingCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_ClsRmTeachingCase, 8, convClsRmTeachingCaseRelaInfo.Id_ClsRmTeachingCase);
clsCheckSql.CheckFieldForeignKey(strId_ClsRmTeachingCase, 8, convClsRmTeachingCaseRelaInfo.Id_ClsRmTeachingCase);
objvClsRmTeachingCaseRelaInfoEN.Id_ClsRmTeachingCase = strId_ClsRmTeachingCase; //课堂教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.Id_ClsRmTeachingCase) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.Id_ClsRmTeachingCase, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.Id_ClsRmTeachingCase] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetClsRmTeachingCaseName(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strClsRmTeachingCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsRmTeachingCaseName, 100, convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName);
objvClsRmTeachingCaseRelaInfoEN.ClsRmTeachingCaseName = strClsRmTeachingCaseName; //课堂教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN Setid_Resource(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convClsRmTeachingCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convClsRmTeachingCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convClsRmTeachingCaseRelaInfo.id_Resource);
objvClsRmTeachingCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.id_Resource) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetIsVisible(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvClsRmTeachingCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.IsVisible) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN Setid_File(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convClsRmTeachingCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convClsRmTeachingCaseRelaInfo.id_File);
objvClsRmTeachingCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.id_File) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFileName(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convClsRmTeachingCaseRelaInfo.FileName);
objvClsRmTeachingCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FileName) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFileType(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convClsRmTeachingCaseRelaInfo.FileType);
objvClsRmTeachingCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FileType) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetSaveDate(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convClsRmTeachingCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convClsRmTeachingCaseRelaInfo.SaveDate);
objvClsRmTeachingCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.SaveDate) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFileSize(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convClsRmTeachingCaseRelaInfo.FileSize);
objvClsRmTeachingCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FileSize) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetSaveTime(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convClsRmTeachingCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convClsRmTeachingCaseRelaInfo.SaveTime);
objvClsRmTeachingCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.SaveTime) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN Setid_FtpResource(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convClsRmTeachingCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convClsRmTeachingCaseRelaInfo.id_FtpResource);
objvClsRmTeachingCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.id_FtpResource) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFtpResourceID(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convClsRmTeachingCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convClsRmTeachingCaseRelaInfo.FtpResourceID);
objvClsRmTeachingCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FtpResourceID) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFileOriginalName(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convClsRmTeachingCaseRelaInfo.FileOriginalName);
objvClsRmTeachingCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FileOriginalName) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFileDirName(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convClsRmTeachingCaseRelaInfo.FileDirName);
objvClsRmTeachingCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FileDirName) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFileRename(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convClsRmTeachingCaseRelaInfo.FileRename);
objvClsRmTeachingCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FileRename) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFileUpDate(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convClsRmTeachingCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convClsRmTeachingCaseRelaInfo.FileUpDate);
objvClsRmTeachingCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FileUpDate) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFileUpTime(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convClsRmTeachingCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convClsRmTeachingCaseRelaInfo.FileUpTime);
objvClsRmTeachingCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FileUpTime) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetResourceID(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convClsRmTeachingCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convClsRmTeachingCaseRelaInfo.ResourceID);
objvClsRmTeachingCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.ResourceID) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetSaveMode(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvClsRmTeachingCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.SaveMode) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN Setid_ResourceType(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convClsRmTeachingCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convClsRmTeachingCaseRelaInfo.id_ResourceType);
objvClsRmTeachingCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.id_ResourceType) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetResourceTypeID(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convClsRmTeachingCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convClsRmTeachingCaseRelaInfo.ResourceTypeID);
objvClsRmTeachingCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.ResourceTypeID) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetResourceTypeName(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convClsRmTeachingCaseRelaInfo.ResourceTypeName);
objvClsRmTeachingCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.ResourceTypeName) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
objvClsRmTeachingCaseRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
objvClsRmTeachingCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetBrowseCount(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvClsRmTeachingCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.BrowseCount) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetResourceOwner(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convClsRmTeachingCaseRelaInfo.ResourceOwner);
objvClsRmTeachingCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.ResourceOwner) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetftpFileType(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convClsRmTeachingCaseRelaInfo.ftpFileType);
objvClsRmTeachingCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.ftpFileType) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetftpFileSize(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convClsRmTeachingCaseRelaInfo.ftpFileSize);
objvClsRmTeachingCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.ftpFileSize) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetftpResourceOwner(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convClsRmTeachingCaseRelaInfo.ftpResourceOwner);
objvClsRmTeachingCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.ftpResourceOwner) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFileOriginName(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convClsRmTeachingCaseRelaInfo.FileOriginName);
objvClsRmTeachingCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FileOriginName) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetIsExistFile(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvClsRmTeachingCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.IsExistFile) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFlag(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convClsRmTeachingCaseRelaInfo.Flag);
objvClsRmTeachingCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.Flag) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFuncModuleName(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convClsRmTeachingCaseRelaInfo.FuncModuleName);
objvClsRmTeachingCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FuncModuleName) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFuncModuleId(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convClsRmTeachingCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convClsRmTeachingCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convClsRmTeachingCaseRelaInfo.FuncModuleId);
objvClsRmTeachingCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FuncModuleId) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFileNewName(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convClsRmTeachingCaseRelaInfo.FileNewName);
objvClsRmTeachingCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FileNewName) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetFileOldName(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convClsRmTeachingCaseRelaInfo.FileOldName);
objvClsRmTeachingCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.FileOldName) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetUpdDate(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convClsRmTeachingCaseRelaInfo.UpdDate);
objvClsRmTeachingCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.UpdDate) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetUpdUser(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convClsRmTeachingCaseRelaInfo.UpdUser);
objvClsRmTeachingCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.UpdUser) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClsRmTeachingCaseRelaInfoEN SetMemo(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClsRmTeachingCaseRelaInfo.Memo);
objvClsRmTeachingCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convClsRmTeachingCaseRelaInfo.Memo) == false)
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp.Add(convClsRmTeachingCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvClsRmTeachingCaseRelaInfoEN.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvClsRmTeachingCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfo, objvClsRmTeachingCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.id_MicroteachCase, objvClsRmTeachingCaseRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.Id_ClsRmTeachingCase) == true)
{
string strComparisonOp_Id_ClsRmTeachingCase = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.Id_ClsRmTeachingCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.Id_ClsRmTeachingCase, objvClsRmTeachingCaseRelaInfo_Cond.Id_ClsRmTeachingCase, strComparisonOp_Id_ClsRmTeachingCase);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName) == true)
{
string strComparisonOp_ClsRmTeachingCaseName = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName, objvClsRmTeachingCaseRelaInfo_Cond.ClsRmTeachingCaseName, strComparisonOp_ClsRmTeachingCaseName);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.id_Resource, objvClsRmTeachingCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.IsVisible) == true)
{
if (objvClsRmTeachingCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCaseRelaInfo.IsVisible);
}
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.id_File, objvClsRmTeachingCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FileName, objvClsRmTeachingCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FileType, objvClsRmTeachingCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.SaveDate, objvClsRmTeachingCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FileSize, objvClsRmTeachingCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.SaveTime, objvClsRmTeachingCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.id_FtpResource, objvClsRmTeachingCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FtpResourceID, objvClsRmTeachingCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FileOriginalName, objvClsRmTeachingCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FileDirName, objvClsRmTeachingCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FileRename, objvClsRmTeachingCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FileUpDate, objvClsRmTeachingCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FileUpTime, objvClsRmTeachingCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.ResourceID, objvClsRmTeachingCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.SaveMode) == true)
{
if (objvClsRmTeachingCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCaseRelaInfo.SaveMode);
}
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.id_ResourceType, objvClsRmTeachingCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.ResourceTypeID, objvClsRmTeachingCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.ResourceTypeName, objvClsRmTeachingCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfoType, objvClsRmTeachingCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeID = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, objvClsRmTeachingCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeID, strComparisonOp_MicroTeachCaseRelaInfoTypeID);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvClsRmTeachingCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convClsRmTeachingCaseRelaInfo.BrowseCount, objvClsRmTeachingCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.ResourceOwner, objvClsRmTeachingCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.ftpFileType, objvClsRmTeachingCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.ftpFileSize, objvClsRmTeachingCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.ftpResourceOwner, objvClsRmTeachingCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FileOriginName, objvClsRmTeachingCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.IsExistFile) == true)
{
if (objvClsRmTeachingCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClsRmTeachingCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClsRmTeachingCaseRelaInfo.IsExistFile);
}
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.Flag, objvClsRmTeachingCaseRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FuncModuleName, objvClsRmTeachingCaseRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FuncModuleId, objvClsRmTeachingCaseRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FileNewName, objvClsRmTeachingCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.FileOldName, objvClsRmTeachingCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.UpdDate, objvClsRmTeachingCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.UpdUser, objvClsRmTeachingCaseRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvClsRmTeachingCaseRelaInfo_Cond.IsUpdated(convClsRmTeachingCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvClsRmTeachingCaseRelaInfo_Cond.dicFldComparisonOp[convClsRmTeachingCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClsRmTeachingCaseRelaInfo.Memo, objvClsRmTeachingCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课堂教学案例相关信息(vClsRmTeachingCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvClsRmTeachingCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vClsRmTeachingCaseRelaInfoApi";

 public clsvClsRmTeachingCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClsRmTeachingCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN = null;
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
objvClsRmTeachingCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCaseRelaInfoEN;
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
public static clsvClsRmTeachingCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN = null;
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
objvClsRmTeachingCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCaseRelaInfoEN;
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
public static clsvClsRmTeachingCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoEN = null;
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
objvClsRmTeachingCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvClsRmTeachingCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvClsRmTeachingCaseRelaInfoEN;
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
public static clsvClsRmTeachingCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClsRmTeachingCaseRelaInfoEN._CurrTabName_S);
List<clsvClsRmTeachingCaseRelaInfoEN> arrvClsRmTeachingCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCaseRelaInfoEN> arrvClsRmTeachingCaseRelaInfoObjLst_Sel =
from objvClsRmTeachingCaseRelaInfoEN in arrvClsRmTeachingCaseRelaInfoObjLst_Cache
where objvClsRmTeachingCaseRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvClsRmTeachingCaseRelaInfoEN;
if (arrvClsRmTeachingCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvClsRmTeachingCaseRelaInfoEN obj = clsvClsRmTeachingCaseRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvClsRmTeachingCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvClsRmTeachingCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvClsRmTeachingCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvClsRmTeachingCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClsRmTeachingCaseRelaInfoEN._CurrTabName_S);
List<clsvClsRmTeachingCaseRelaInfoEN> arrvClsRmTeachingCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClsRmTeachingCaseRelaInfoEN> arrvClsRmTeachingCaseRelaInfoObjLst_Sel =
from objvClsRmTeachingCaseRelaInfoEN in arrvClsRmTeachingCaseRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvClsRmTeachingCaseRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvClsRmTeachingCaseRelaInfoEN;
return arrvClsRmTeachingCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClsRmTeachingCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvClsRmTeachingCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvClsRmTeachingCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvClsRmTeachingCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvClsRmTeachingCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClsRmTeachingCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvClsRmTeachingCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClsRmTeachingCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvClsRmTeachingCaseRelaInfoENS">源对象</param>
 /// <param name = "objvClsRmTeachingCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoENS, clsvClsRmTeachingCaseRelaInfoEN objvClsRmTeachingCaseRelaInfoENT)
{
try
{
objvClsRmTeachingCaseRelaInfoENT.id_MicroTeachCaseRelaInfo = objvClsRmTeachingCaseRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvClsRmTeachingCaseRelaInfoENT.id_MicroteachCase = objvClsRmTeachingCaseRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvClsRmTeachingCaseRelaInfoENT.Id_ClsRmTeachingCase = objvClsRmTeachingCaseRelaInfoENS.Id_ClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCaseRelaInfoENT.ClsRmTeachingCaseName = objvClsRmTeachingCaseRelaInfoENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCaseRelaInfoENT.id_Resource = objvClsRmTeachingCaseRelaInfoENS.id_Resource; //资源流水号
objvClsRmTeachingCaseRelaInfoENT.IsVisible = objvClsRmTeachingCaseRelaInfoENS.IsVisible; //是否显示
objvClsRmTeachingCaseRelaInfoENT.id_File = objvClsRmTeachingCaseRelaInfoENS.id_File; //文件流水号
objvClsRmTeachingCaseRelaInfoENT.FileName = objvClsRmTeachingCaseRelaInfoENS.FileName; //文件名称
objvClsRmTeachingCaseRelaInfoENT.FileType = objvClsRmTeachingCaseRelaInfoENS.FileType; //文件类型
objvClsRmTeachingCaseRelaInfoENT.SaveDate = objvClsRmTeachingCaseRelaInfoENS.SaveDate; //创建日期
objvClsRmTeachingCaseRelaInfoENT.FileSize = objvClsRmTeachingCaseRelaInfoENS.FileSize; //文件大小
objvClsRmTeachingCaseRelaInfoENT.SaveTime = objvClsRmTeachingCaseRelaInfoENS.SaveTime; //创建时间
objvClsRmTeachingCaseRelaInfoENT.id_FtpResource = objvClsRmTeachingCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvClsRmTeachingCaseRelaInfoENT.FtpResourceID = objvClsRmTeachingCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvClsRmTeachingCaseRelaInfoENT.FileOriginalName = objvClsRmTeachingCaseRelaInfoENS.FileOriginalName; //文件原名
objvClsRmTeachingCaseRelaInfoENT.FileDirName = objvClsRmTeachingCaseRelaInfoENS.FileDirName; //文件目录名
objvClsRmTeachingCaseRelaInfoENT.FileRename = objvClsRmTeachingCaseRelaInfoENS.FileRename; //文件新名
objvClsRmTeachingCaseRelaInfoENT.FileUpDate = objvClsRmTeachingCaseRelaInfoENS.FileUpDate; //创建日期
objvClsRmTeachingCaseRelaInfoENT.FileUpTime = objvClsRmTeachingCaseRelaInfoENS.FileUpTime; //创建时间
objvClsRmTeachingCaseRelaInfoENT.ResourceID = objvClsRmTeachingCaseRelaInfoENS.ResourceID; //资源ID
objvClsRmTeachingCaseRelaInfoENT.SaveMode = objvClsRmTeachingCaseRelaInfoENS.SaveMode; //文件存放方式
objvClsRmTeachingCaseRelaInfoENT.id_ResourceType = objvClsRmTeachingCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvClsRmTeachingCaseRelaInfoENT.ResourceTypeID = objvClsRmTeachingCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvClsRmTeachingCaseRelaInfoENT.ResourceTypeName = objvClsRmTeachingCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvClsRmTeachingCaseRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvClsRmTeachingCaseRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvClsRmTeachingCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvClsRmTeachingCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvClsRmTeachingCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvClsRmTeachingCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvClsRmTeachingCaseRelaInfoENT.BrowseCount = objvClsRmTeachingCaseRelaInfoENS.BrowseCount; //浏览次数
objvClsRmTeachingCaseRelaInfoENT.ResourceOwner = objvClsRmTeachingCaseRelaInfoENS.ResourceOwner; //上传者
objvClsRmTeachingCaseRelaInfoENT.ftpFileType = objvClsRmTeachingCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvClsRmTeachingCaseRelaInfoENT.ftpFileSize = objvClsRmTeachingCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvClsRmTeachingCaseRelaInfoENT.ftpResourceOwner = objvClsRmTeachingCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvClsRmTeachingCaseRelaInfoENT.FileOriginName = objvClsRmTeachingCaseRelaInfoENS.FileOriginName; //原文件名
objvClsRmTeachingCaseRelaInfoENT.IsExistFile = objvClsRmTeachingCaseRelaInfoENS.IsExistFile; //是否存在文件
objvClsRmTeachingCaseRelaInfoENT.Flag = objvClsRmTeachingCaseRelaInfoENS.Flag; //标志
objvClsRmTeachingCaseRelaInfoENT.FuncModuleName = objvClsRmTeachingCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvClsRmTeachingCaseRelaInfoENT.FuncModuleId = objvClsRmTeachingCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvClsRmTeachingCaseRelaInfoENT.FileNewName = objvClsRmTeachingCaseRelaInfoENS.FileNewName; //新文件名
objvClsRmTeachingCaseRelaInfoENT.FileOldName = objvClsRmTeachingCaseRelaInfoENS.FileOldName; //旧文件名
objvClsRmTeachingCaseRelaInfoENT.UpdDate = objvClsRmTeachingCaseRelaInfoENS.UpdDate; //修改日期
objvClsRmTeachingCaseRelaInfoENT.UpdUser = objvClsRmTeachingCaseRelaInfoENS.UpdUser; //修改人
objvClsRmTeachingCaseRelaInfoENT.Memo = objvClsRmTeachingCaseRelaInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvClsRmTeachingCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvClsRmTeachingCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvClsRmTeachingCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvClsRmTeachingCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvClsRmTeachingCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvClsRmTeachingCaseRelaInfoEN.AttributeName)
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
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzGrade_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGrade_psWApi没有刷新缓存机制(clsXzGrade_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClsRmTeachingCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClsRmTeachingCaseWApi没有刷新缓存机制(clsClsRmTeachingCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClsRmTeachingCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClsRmTeachingCaseTypeWApi没有刷新缓存机制(clsClsRmTeachingCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvClsRmTeachingCaseRelaInfoObjLst_Cache == null)
//{
//arrvClsRmTeachingCaseRelaInfoObjLst_Cache = await clsvClsRmTeachingCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvClsRmTeachingCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvClsRmTeachingCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvClsRmTeachingCaseRelaInfoEN._CurrTabName_S);
List<clsvClsRmTeachingCaseRelaInfoEN> arrvClsRmTeachingCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClsRmTeachingCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvClsRmTeachingCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.Id_ClsRmTeachingCase, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convClsRmTeachingCaseRelaInfo.Memo, Type.GetType("System.String"));
foreach (clsvClsRmTeachingCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convClsRmTeachingCaseRelaInfo.id_MicroteachCase] = objInFor[convClsRmTeachingCaseRelaInfo.id_MicroteachCase];
objDR[convClsRmTeachingCaseRelaInfo.Id_ClsRmTeachingCase] = objInFor[convClsRmTeachingCaseRelaInfo.Id_ClsRmTeachingCase];
objDR[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName] = objInFor[convClsRmTeachingCaseRelaInfo.ClsRmTeachingCaseName];
objDR[convClsRmTeachingCaseRelaInfo.id_Resource] = objInFor[convClsRmTeachingCaseRelaInfo.id_Resource];
objDR[convClsRmTeachingCaseRelaInfo.IsVisible] = objInFor[convClsRmTeachingCaseRelaInfo.IsVisible];
objDR[convClsRmTeachingCaseRelaInfo.id_File] = objInFor[convClsRmTeachingCaseRelaInfo.id_File];
objDR[convClsRmTeachingCaseRelaInfo.FileName] = objInFor[convClsRmTeachingCaseRelaInfo.FileName];
objDR[convClsRmTeachingCaseRelaInfo.FileType] = objInFor[convClsRmTeachingCaseRelaInfo.FileType];
objDR[convClsRmTeachingCaseRelaInfo.SaveDate] = objInFor[convClsRmTeachingCaseRelaInfo.SaveDate];
objDR[convClsRmTeachingCaseRelaInfo.FileSize] = objInFor[convClsRmTeachingCaseRelaInfo.FileSize];
objDR[convClsRmTeachingCaseRelaInfo.SaveTime] = objInFor[convClsRmTeachingCaseRelaInfo.SaveTime];
objDR[convClsRmTeachingCaseRelaInfo.id_FtpResource] = objInFor[convClsRmTeachingCaseRelaInfo.id_FtpResource];
objDR[convClsRmTeachingCaseRelaInfo.FtpResourceID] = objInFor[convClsRmTeachingCaseRelaInfo.FtpResourceID];
objDR[convClsRmTeachingCaseRelaInfo.FileOriginalName] = objInFor[convClsRmTeachingCaseRelaInfo.FileOriginalName];
objDR[convClsRmTeachingCaseRelaInfo.FileDirName] = objInFor[convClsRmTeachingCaseRelaInfo.FileDirName];
objDR[convClsRmTeachingCaseRelaInfo.FileRename] = objInFor[convClsRmTeachingCaseRelaInfo.FileRename];
objDR[convClsRmTeachingCaseRelaInfo.FileUpDate] = objInFor[convClsRmTeachingCaseRelaInfo.FileUpDate];
objDR[convClsRmTeachingCaseRelaInfo.FileUpTime] = objInFor[convClsRmTeachingCaseRelaInfo.FileUpTime];
objDR[convClsRmTeachingCaseRelaInfo.ResourceID] = objInFor[convClsRmTeachingCaseRelaInfo.ResourceID];
objDR[convClsRmTeachingCaseRelaInfo.SaveMode] = objInFor[convClsRmTeachingCaseRelaInfo.SaveMode];
objDR[convClsRmTeachingCaseRelaInfo.id_ResourceType] = objInFor[convClsRmTeachingCaseRelaInfo.id_ResourceType];
objDR[convClsRmTeachingCaseRelaInfo.ResourceTypeID] = objInFor[convClsRmTeachingCaseRelaInfo.ResourceTypeID];
objDR[convClsRmTeachingCaseRelaInfo.ResourceTypeName] = objInFor[convClsRmTeachingCaseRelaInfo.ResourceTypeName];
objDR[convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convClsRmTeachingCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = objInFor[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
objDR[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convClsRmTeachingCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convClsRmTeachingCaseRelaInfo.BrowseCount] = objInFor[convClsRmTeachingCaseRelaInfo.BrowseCount];
objDR[convClsRmTeachingCaseRelaInfo.ResourceOwner] = objInFor[convClsRmTeachingCaseRelaInfo.ResourceOwner];
objDR[convClsRmTeachingCaseRelaInfo.ftpFileType] = objInFor[convClsRmTeachingCaseRelaInfo.ftpFileType];
objDR[convClsRmTeachingCaseRelaInfo.ftpFileSize] = objInFor[convClsRmTeachingCaseRelaInfo.ftpFileSize];
objDR[convClsRmTeachingCaseRelaInfo.ftpResourceOwner] = objInFor[convClsRmTeachingCaseRelaInfo.ftpResourceOwner];
objDR[convClsRmTeachingCaseRelaInfo.FileOriginName] = objInFor[convClsRmTeachingCaseRelaInfo.FileOriginName];
objDR[convClsRmTeachingCaseRelaInfo.IsExistFile] = objInFor[convClsRmTeachingCaseRelaInfo.IsExistFile];
objDR[convClsRmTeachingCaseRelaInfo.Flag] = objInFor[convClsRmTeachingCaseRelaInfo.Flag];
objDR[convClsRmTeachingCaseRelaInfo.FuncModuleName] = objInFor[convClsRmTeachingCaseRelaInfo.FuncModuleName];
objDR[convClsRmTeachingCaseRelaInfo.FuncModuleId] = objInFor[convClsRmTeachingCaseRelaInfo.FuncModuleId];
objDR[convClsRmTeachingCaseRelaInfo.FileNewName] = objInFor[convClsRmTeachingCaseRelaInfo.FileNewName];
objDR[convClsRmTeachingCaseRelaInfo.FileOldName] = objInFor[convClsRmTeachingCaseRelaInfo.FileOldName];
objDR[convClsRmTeachingCaseRelaInfo.UpdDate] = objInFor[convClsRmTeachingCaseRelaInfo.UpdDate];
objDR[convClsRmTeachingCaseRelaInfo.UpdUser] = objInFor[convClsRmTeachingCaseRelaInfo.UpdUser];
objDR[convClsRmTeachingCaseRelaInfo.Memo] = objInFor[convClsRmTeachingCaseRelaInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}