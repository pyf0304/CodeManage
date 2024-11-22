
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseWithResourceRelWApi
 表名:vCourseLearningCaseWithResourceRel(01120472)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:36
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvCourseLearningCaseWithResourceRelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetId_CourseLearningCase(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strId_CourseLearningCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CourseLearningCase, 8, convCourseLearningCaseWithResourceRel.Id_CourseLearningCase);
clsCheckSql.CheckFieldForeignKey(strId_CourseLearningCase, 8, convCourseLearningCaseWithResourceRel.Id_CourseLearningCase);
objvCourseLearningCaseWithResourceRelEN.Id_CourseLearningCase = strId_CourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.Id_CourseLearningCase) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.Id_CourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.Id_CourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_MicroteachCase_Resource_Rel(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, long lngid_MicroteachCase_Resource_Rel, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.id_MicroteachCase_Resource_Rel = lngid_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_MicroteachCase_Resource_Rel) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_MicroteachCase_Resource_Rel, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_MicroteachCase_Resource_Rel] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetFuncModuleId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningCaseWithResourceRel.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningCaseWithResourceRel.FuncModuleId);
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.FuncModuleId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetFuncModuleName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningCaseWithResourceRel.FuncModuleName);
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.FuncModuleName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_Resource(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Resource, 8, convCourseLearningCaseWithResourceRel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convCourseLearningCaseWithResourceRel.id_Resource);
objvCourseLearningCaseWithResourceRelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_Resource) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_Resource, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_Resource] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetResourceID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convCourseLearningCaseWithResourceRel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convCourseLearningCaseWithResourceRel.ResourceID);
objvCourseLearningCaseWithResourceRelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ResourceID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ResourceID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetResourceName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convCourseLearningCaseWithResourceRel.ResourceName);
objvCourseLearningCaseWithResourceRelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ResourceName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ResourceName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_FtpResource(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convCourseLearningCaseWithResourceRel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convCourseLearningCaseWithResourceRel.id_FtpResource);
objvCourseLearningCaseWithResourceRelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_FtpResource) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_FtpResource, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_FtpResource] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_File(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convCourseLearningCaseWithResourceRel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convCourseLearningCaseWithResourceRel.id_File);
objvCourseLearningCaseWithResourceRelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_File) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_File, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_File] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetFileSize(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convCourseLearningCaseWithResourceRel.FileSize);
objvCourseLearningCaseWithResourceRelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.FileSize) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.FileSize, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileSize] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetSaveTime(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convCourseLearningCaseWithResourceRel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convCourseLearningCaseWithResourceRel.SaveTime);
objvCourseLearningCaseWithResourceRelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.SaveTime) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.SaveTime, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SaveTime] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_ResourceType(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convCourseLearningCaseWithResourceRel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convCourseLearningCaseWithResourceRel.id_ResourceType);
objvCourseLearningCaseWithResourceRelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_ResourceType) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_ResourceType, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_ResourceType] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetResourceTypeID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convCourseLearningCaseWithResourceRel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convCourseLearningCaseWithResourceRel.ResourceTypeID);
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ResourceTypeID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ResourceTypeID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceTypeID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetResourceTypeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convCourseLearningCaseWithResourceRel.ResourceTypeName);
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ResourceTypeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ResourceTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetResourceOwner(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convCourseLearningCaseWithResourceRel.ResourceOwner);
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ResourceOwner) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ResourceOwner, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceOwner] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsExistFile(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsExistFile) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsExistFile, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsExistFile] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetFileNewName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convCourseLearningCaseWithResourceRel.FileNewName);
objvCourseLearningCaseWithResourceRelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.FileNewName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.FileNewName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileNewName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsMain(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsMain, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsMain) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsMain, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsMain] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, convCourseLearningCaseWithResourceRel.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseID);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseID);
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningCaseWithResourceRel.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCaseWithResourceRel.CourseLearningCaseName);
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseText(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseText, 8000, convCourseLearningCaseWithResourceRel.CourseLearningCaseText);
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = strCourseLearningCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseText) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseText, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseTheme(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme);
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseDate(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseDate);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseDate);
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseDate) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseDate, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseTime(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningCaseWithResourceRel.CourseLearningCaseTime);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningCaseWithResourceRel.CourseLearningCaseTime);
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseTime) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTime, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseDateIn(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn);
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseTimeIn(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn);
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetId_CaseType(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convCourseLearningCaseWithResourceRel.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convCourseLearningCaseWithResourceRel.Id_CaseType);
objvCourseLearningCaseWithResourceRelEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.Id_CaseType) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.Id_CaseType, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.Id_CaseType] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_CourseLearningCaseType(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_CourseLearningCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CourseLearningCaseType, convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType);
clsCheckSql.CheckFieldLen(strid_CourseLearningCaseType, 4, convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseLearningCaseType, 4, convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType);
objvCourseLearningCaseWithResourceRelEN.id_CourseLearningCaseType = strid_CourseLearningCaseType; //课程学习案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseLearningCaseTypeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName);
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = strCourseLearningCaseTypeName; //课程学习案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetOwnerId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCourseLearningCaseWithResourceRel.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCourseLearningCaseWithResourceRel.OwnerId);
objvCourseLearningCaseWithResourceRelEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.OwnerId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.OwnerId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_StudyLevel(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convCourseLearningCaseWithResourceRel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convCourseLearningCaseWithResourceRel.id_StudyLevel);
objvCourseLearningCaseWithResourceRelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_StudyLevel) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_StudyLevel, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_StudyLevel] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetStudyLevelName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convCourseLearningCaseWithResourceRel.StudyLevelName);
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.StudyLevelName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.StudyLevelName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.StudyLevelName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_TeachingPlan(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convCourseLearningCaseWithResourceRel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convCourseLearningCaseWithResourceRel.id_TeachingPlan);
objvCourseLearningCaseWithResourceRelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_TeachingPlan) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_TeachingPlan, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_TeachingPlan] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_Discipline(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convCourseLearningCaseWithResourceRel.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convCourseLearningCaseWithResourceRel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convCourseLearningCaseWithResourceRel.id_Discipline);
objvCourseLearningCaseWithResourceRelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_Discipline) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_Discipline, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_Discipline] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetDisciplineID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convCourseLearningCaseWithResourceRel.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convCourseLearningCaseWithResourceRel.DisciplineID);
objvCourseLearningCaseWithResourceRelEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.DisciplineID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.DisciplineID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DisciplineID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetDisciplineName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convCourseLearningCaseWithResourceRel.DisciplineName);
objvCourseLearningCaseWithResourceRelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.DisciplineName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.DisciplineName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DisciplineName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetBrowseCount(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int intBrowseCount, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.BrowseCount) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.BrowseCount, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.BrowseCount] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_SenateGaugeVersion(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convCourseLearningCaseWithResourceRel.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convCourseLearningCaseWithResourceRel.id_SenateGaugeVersion);
objvCourseLearningCaseWithResourceRelEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_SenateGaugeVersion) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetsenateGaugeVersionID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convCourseLearningCaseWithResourceRel.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convCourseLearningCaseWithResourceRel.senateGaugeVersionID);
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.senateGaugeVersionID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.senateGaugeVersionID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetsenateGaugeVersionName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCourseLearningCaseWithResourceRel.senateGaugeVersionName);
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.senateGaugeVersionName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetsenateGaugeVersionTtlScore(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetVersionNo(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int intVersionNo, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.VersionNo) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.VersionNo, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.VersionNo] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_TeachSkill(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convCourseLearningCaseWithResourceRel.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convCourseLearningCaseWithResourceRel.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convCourseLearningCaseWithResourceRel.id_TeachSkill);
objvCourseLearningCaseWithResourceRelEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_TeachSkill) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_TeachSkill, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_TeachSkill] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetTeachSkillID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convCourseLearningCaseWithResourceRel.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convCourseLearningCaseWithResourceRel.TeachSkillID);
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.TeachSkillID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.TeachSkillID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetSkillTypeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convCourseLearningCaseWithResourceRel.SkillTypeName);
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.SkillTypeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.SkillTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SkillTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetTeachSkillName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convCourseLearningCaseWithResourceRel.TeachSkillName);
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.TeachSkillName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.TeachSkillName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetTeachSkillTheory(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convCourseLearningCaseWithResourceRel.TeachSkillTheory);
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.TeachSkillTheory) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.TeachSkillTheory, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillTheory] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetTeachSkillOperMethod(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convCourseLearningCaseWithResourceRel.TeachSkillOperMethod);
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.TeachSkillOperMethod) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_SkillType(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convCourseLearningCaseWithResourceRel.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convCourseLearningCaseWithResourceRel.id_SkillType);
objvCourseLearningCaseWithResourceRelEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_SkillType) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_SkillType, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_SkillType] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetSkillTypeID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convCourseLearningCaseWithResourceRel.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convCourseLearningCaseWithResourceRel.SkillTypeID);
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.SkillTypeID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.SkillTypeID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SkillTypeID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCaseLevelId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCaseLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCourseLearningCaseWithResourceRel.CaseLevelId);
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCourseLearningCaseWithResourceRel.CaseLevelId);
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CaseLevelId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CaseLevelId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseLevelId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCaseLevelName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCaseLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseLevelName, 30, convCourseLearningCaseWithResourceRel.CaseLevelName);
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = strCaseLevelName; //案例等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CaseLevelName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CaseLevelName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseLevelName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetDocFile(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strDocFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCourseLearningCaseWithResourceRel.DocFile);
objvCourseLearningCaseWithResourceRelEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.DocFile) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.DocFile, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DocFile] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsNeedGeneWord(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsNeedGeneWord) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetWordCreateDate(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strWordCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCourseLearningCaseWithResourceRel.WordCreateDate);
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.WordCreateDate) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.WordCreateDate, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.WordCreateDate] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsVisible(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsVisible) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsVisible, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsVisible] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsDualVideo(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsDualVideo) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsDualVideo, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsDualVideo] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_XzCollege(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, convCourseLearningCaseWithResourceRel.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCourseLearningCaseWithResourceRel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCourseLearningCaseWithResourceRel.id_XzCollege);
objvCourseLearningCaseWithResourceRelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_XzCollege) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_XzCollege, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_XzCollege] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCollegeID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningCaseWithResourceRel.CollegeID);
objvCourseLearningCaseWithResourceRelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CollegeID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CollegeID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCollegeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCaseWithResourceRel.CollegeName);
objvCourseLearningCaseWithResourceRelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CollegeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCollegeNameA(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningCaseWithResourceRel.CollegeNameA);
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CollegeNameA) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CollegeNameA, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeNameA] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN Setid_XzMajor(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convCourseLearningCaseWithResourceRel.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convCourseLearningCaseWithResourceRel.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convCourseLearningCaseWithResourceRel.id_XzMajor);
objvCourseLearningCaseWithResourceRelEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.id_XzMajor) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.id_XzMajor, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_XzMajor] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetMajorID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCaseWithResourceRel.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCaseWithResourceRel.MajorID);
objvCourseLearningCaseWithResourceRelEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.MajorID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.MajorID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.MajorID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetMajorName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCaseWithResourceRel.MajorName);
objvCourseLearningCaseWithResourceRelEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.MajorName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.MajorName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.MajorName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCourseLearningCaseWithResourceRel.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCaseWithResourceRel.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCaseWithResourceRel.CourseId);
objvCourseLearningCaseWithResourceRelEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseCode(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCaseWithResourceRel.CourseCode);
objvCourseLearningCaseWithResourceRelEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseCode) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCaseWithResourceRel.CourseName);
objvCourseLearningCaseWithResourceRelEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetTeachingSolutionId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionId, convCourseLearningCaseWithResourceRel.TeachingSolutionId);
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCourseLearningCaseWithResourceRel.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCourseLearningCaseWithResourceRel.TeachingSolutionId);
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.TeachingSolutionId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.TeachingSolutionId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachingSolutionId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseChapterId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCaseWithResourceRel.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCaseWithResourceRel.CourseChapterId);
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseChapterId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseChapterId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseChapterName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCourseLearningCaseWithResourceRel.CourseChapterName);
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseChapterName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseChapterName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetParentNodeID(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strParentNodeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeID, 8, convCourseLearningCaseWithResourceRel.ParentNodeID);
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = strParentNodeID; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ParentNodeID) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ParentNodeID, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeID] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetParentNodeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strParentNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeName, 50, convCourseLearningCaseWithResourceRel.ParentNodeName);
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = strParentNodeName; //父节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ParentNodeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ParentNodeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCourseChapterReferred(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCourseChapterReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, convCourseLearningCaseWithResourceRel.CourseChapterReferred);
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CourseChapterReferred) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CourseChapterReferred, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterReferred] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetParentNodeReferred(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strParentNodeReferred, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentNodeReferred, 10, convCourseLearningCaseWithResourceRel.ParentNodeReferred);
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = strParentNodeReferred; //章简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ParentNodeReferred) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ParentNodeReferred, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeReferred] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetViewCount(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int intViewCount, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.ViewCount) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.ViewCount, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ViewCount] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetIsShow(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, bool bolIsShow, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.IsShow) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.IsShow, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.IsShow] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetDownloadNumber(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int intDownloadNumber, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.DownloadNumber) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.DownloadNumber, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DownloadNumber] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetFileIntegration(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int intFileIntegration, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.FileIntegration) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.FileIntegration, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileIntegration] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetLikeCount(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, long lngLikeCount, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.LikeCount) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.LikeCount, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.LikeCount] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCollectionCount(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, long lngCollectionCount, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CollectionCount) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CollectionCount, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollectionCount] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetRecommendedDegreeId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCourseLearningCaseWithResourceRel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCourseLearningCaseWithResourceRel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCourseLearningCaseWithResourceRel.RecommendedDegreeId);
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.RecommendedDegreeId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetRecommendedDegreeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convCourseLearningCaseWithResourceRel.RecommendedDegreeName);
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.RecommendedDegreeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetMemo(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCaseWithResourceRel.Memo);
objvCourseLearningCaseWithResourceRelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.Memo) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.Memo, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.Memo] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetBrowseCount4Case(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.BrowseCount4Case) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.BrowseCount4Case, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.BrowseCount4Case] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetOwnerName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCourseLearningCaseWithResourceRel.OwnerName);
objvCourseLearningCaseWithResourceRelEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.OwnerName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.OwnerName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetOwnerNameWithId(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convCourseLearningCaseWithResourceRel.OwnerNameWithId);
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.OwnerNameWithId) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.OwnerNameWithId, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerNameWithId] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseWithResourceRelEN SetCaseTypeName(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN, string strCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseTypeName, 50, convCourseLearningCaseWithResourceRel.CaseTypeName);
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = strCaseTypeName; //案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseWithResourceRel.CaseTypeName) == false)
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp.Add(convCourseLearningCaseWithResourceRel.CaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseWithResourceRelEN.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseWithResourceRelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.Id_CourseLearningCase) == true)
{
string strComparisonOp_Id_CourseLearningCase = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.Id_CourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.Id_CourseLearningCase, objvCourseLearningCaseWithResourceRel_Cond.Id_CourseLearningCase, strComparisonOp_Id_CourseLearningCase);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_MicroteachCase_Resource_Rel) == true)
{
string strComparisonOp_id_MicroteachCase_Resource_Rel = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_MicroteachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.id_MicroteachCase_Resource_Rel, objvCourseLearningCaseWithResourceRel_Cond.id_MicroteachCase_Resource_Rel, strComparisonOp_id_MicroteachCase_Resource_Rel);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.FuncModuleId, objvCourseLearningCaseWithResourceRel_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.FuncModuleName, objvCourseLearningCaseWithResourceRel_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_Resource, objvCourseLearningCaseWithResourceRel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ResourceID, objvCourseLearningCaseWithResourceRel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ResourceName, objvCourseLearningCaseWithResourceRel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_FtpResource, objvCourseLearningCaseWithResourceRel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_File) == true)
{
string strComparisonOp_id_File = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_File, objvCourseLearningCaseWithResourceRel_Cond.id_File, strComparisonOp_id_File);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.FileSize) == true)
{
string strComparisonOp_FileSize = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.FileSize, objvCourseLearningCaseWithResourceRel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.SaveTime, objvCourseLearningCaseWithResourceRel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_ResourceType, objvCourseLearningCaseWithResourceRel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ResourceTypeID, objvCourseLearningCaseWithResourceRel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ResourceTypeName, objvCourseLearningCaseWithResourceRel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ResourceOwner, objvCourseLearningCaseWithResourceRel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.IsExistFile) == true)
{
if (objvCourseLearningCaseWithResourceRel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsExistFile);
}
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.FileNewName, objvCourseLearningCaseWithResourceRel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.IsMain) == true)
{
if (objvCourseLearningCaseWithResourceRel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsMain);
}
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseID) == true)
{
string strComparisonOp_CourseLearningCaseID = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseID, objvCourseLearningCaseWithResourceRel_Cond.CourseLearningCaseID, strComparisonOp_CourseLearningCaseID);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseName, objvCourseLearningCaseWithResourceRel_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseText) == true)
{
string strComparisonOp_CourseLearningCaseText = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseText, objvCourseLearningCaseWithResourceRel_Cond.CourseLearningCaseText, strComparisonOp_CourseLearningCaseText);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme) == true)
{
string strComparisonOp_CourseLearningCaseTheme = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme, objvCourseLearningCaseWithResourceRel_Cond.CourseLearningCaseTheme, strComparisonOp_CourseLearningCaseTheme);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseDate) == true)
{
string strComparisonOp_CourseLearningCaseDate = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseDate, objvCourseLearningCaseWithResourceRel_Cond.CourseLearningCaseDate, strComparisonOp_CourseLearningCaseDate);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseTime) == true)
{
string strComparisonOp_CourseLearningCaseTime = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseTime, objvCourseLearningCaseWithResourceRel_Cond.CourseLearningCaseTime, strComparisonOp_CourseLearningCaseTime);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn) == true)
{
string strComparisonOp_CourseLearningCaseDateIn = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn, objvCourseLearningCaseWithResourceRel_Cond.CourseLearningCaseDateIn, strComparisonOp_CourseLearningCaseDateIn);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn) == true)
{
string strComparisonOp_CourseLearningCaseTimeIn = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn, objvCourseLearningCaseWithResourceRel_Cond.CourseLearningCaseTimeIn, strComparisonOp_CourseLearningCaseTimeIn);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.Id_CaseType, objvCourseLearningCaseWithResourceRel_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType) == true)
{
string strComparisonOp_id_CourseLearningCaseType = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType, objvCourseLearningCaseWithResourceRel_Cond.id_CourseLearningCaseType, strComparisonOp_id_CourseLearningCaseType);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName) == true)
{
string strComparisonOp_CourseLearningCaseTypeName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName, objvCourseLearningCaseWithResourceRel_Cond.CourseLearningCaseTypeName, strComparisonOp_CourseLearningCaseTypeName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.OwnerId, objvCourseLearningCaseWithResourceRel_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_StudyLevel, objvCourseLearningCaseWithResourceRel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.StudyLevelName, objvCourseLearningCaseWithResourceRel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_TeachingPlan, objvCourseLearningCaseWithResourceRel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_Discipline, objvCourseLearningCaseWithResourceRel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.DisciplineID, objvCourseLearningCaseWithResourceRel_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.DisciplineName, objvCourseLearningCaseWithResourceRel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.BrowseCount, objvCourseLearningCaseWithResourceRel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_SenateGaugeVersion, objvCourseLearningCaseWithResourceRel_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.senateGaugeVersionID, objvCourseLearningCaseWithResourceRel_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.senateGaugeVersionName, objvCourseLearningCaseWithResourceRel_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore, objvCourseLearningCaseWithResourceRel_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.VersionNo, objvCourseLearningCaseWithResourceRel_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_TeachSkill, objvCourseLearningCaseWithResourceRel_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.TeachSkillID, objvCourseLearningCaseWithResourceRel_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.SkillTypeName, objvCourseLearningCaseWithResourceRel_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.TeachSkillName, objvCourseLearningCaseWithResourceRel_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.TeachSkillTheory, objvCourseLearningCaseWithResourceRel_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.TeachSkillOperMethod, objvCourseLearningCaseWithResourceRel_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_SkillType, objvCourseLearningCaseWithResourceRel_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.SkillTypeID, objvCourseLearningCaseWithResourceRel_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CaseLevelId) == true)
{
string strComparisonOp_CaseLevelId = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CaseLevelId, objvCourseLearningCaseWithResourceRel_Cond.CaseLevelId, strComparisonOp_CaseLevelId);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CaseLevelName) == true)
{
string strComparisonOp_CaseLevelName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CaseLevelName, objvCourseLearningCaseWithResourceRel_Cond.CaseLevelName, strComparisonOp_CaseLevelName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.DocFile) == true)
{
string strComparisonOp_DocFile = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.DocFile, objvCourseLearningCaseWithResourceRel_Cond.DocFile, strComparisonOp_DocFile);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.IsNeedGeneWord) == true)
{
if (objvCourseLearningCaseWithResourceRel_Cond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsNeedGeneWord);
}
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.WordCreateDate) == true)
{
string strComparisonOp_WordCreateDate = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.WordCreateDate, objvCourseLearningCaseWithResourceRel_Cond.WordCreateDate, strComparisonOp_WordCreateDate);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.IsVisible) == true)
{
if (objvCourseLearningCaseWithResourceRel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsVisible);
}
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.IsDualVideo) == true)
{
if (objvCourseLearningCaseWithResourceRel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsDualVideo);
}
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_XzCollege, objvCourseLearningCaseWithResourceRel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CollegeID, objvCourseLearningCaseWithResourceRel_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CollegeName, objvCourseLearningCaseWithResourceRel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CollegeNameA, objvCourseLearningCaseWithResourceRel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.id_XzMajor, objvCourseLearningCaseWithResourceRel_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.MajorID) == true)
{
string strComparisonOp_MajorID = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.MajorID, objvCourseLearningCaseWithResourceRel_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.MajorName) == true)
{
string strComparisonOp_MajorName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.MajorName, objvCourseLearningCaseWithResourceRel_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseId) == true)
{
string strComparisonOp_CourseId = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseId, objvCourseLearningCaseWithResourceRel_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseCode, objvCourseLearningCaseWithResourceRel_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseName) == true)
{
string strComparisonOp_CourseName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseName, objvCourseLearningCaseWithResourceRel_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.TeachingSolutionId, objvCourseLearningCaseWithResourceRel_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseChapterId, objvCourseLearningCaseWithResourceRel_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseChapterName, objvCourseLearningCaseWithResourceRel_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.ParentNodeID) == true)
{
string strComparisonOp_ParentNodeID = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ParentNodeID, objvCourseLearningCaseWithResourceRel_Cond.ParentNodeID, strComparisonOp_ParentNodeID);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.ParentNodeName) == true)
{
string strComparisonOp_ParentNodeName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ParentNodeName, objvCourseLearningCaseWithResourceRel_Cond.ParentNodeName, strComparisonOp_ParentNodeName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CourseChapterReferred) == true)
{
string strComparisonOp_CourseChapterReferred = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CourseChapterReferred, objvCourseLearningCaseWithResourceRel_Cond.CourseChapterReferred, strComparisonOp_CourseChapterReferred);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.ParentNodeReferred) == true)
{
string strComparisonOp_ParentNodeReferred = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ParentNodeReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.ParentNodeReferred, objvCourseLearningCaseWithResourceRel_Cond.ParentNodeReferred, strComparisonOp_ParentNodeReferred);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.ViewCount, objvCourseLearningCaseWithResourceRel_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.IsShow) == true)
{
if (objvCourseLearningCaseWithResourceRel_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseWithResourceRel.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseWithResourceRel.IsShow);
}
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.DownloadNumber, objvCourseLearningCaseWithResourceRel_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.FileIntegration) == true)
{
string strComparisonOp_FileIntegration = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.FileIntegration, objvCourseLearningCaseWithResourceRel_Cond.FileIntegration, strComparisonOp_FileIntegration);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.LikeCount, objvCourseLearningCaseWithResourceRel_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.CollectionCount, objvCourseLearningCaseWithResourceRel_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.RecommendedDegreeId, objvCourseLearningCaseWithResourceRel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.RecommendedDegreeName, objvCourseLearningCaseWithResourceRel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.Memo) == true)
{
string strComparisonOp_Memo = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.Memo, objvCourseLearningCaseWithResourceRel_Cond.Memo, strComparisonOp_Memo);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseWithResourceRel.BrowseCount4Case, objvCourseLearningCaseWithResourceRel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.OwnerName, objvCourseLearningCaseWithResourceRel_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.OwnerNameWithId, objvCourseLearningCaseWithResourceRel_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvCourseLearningCaseWithResourceRel_Cond.IsUpdated(convCourseLearningCaseWithResourceRel.CaseTypeName) == true)
{
string strComparisonOp_CaseTypeName = objvCourseLearningCaseWithResourceRel_Cond.dicFldComparisonOp[convCourseLearningCaseWithResourceRel.CaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseWithResourceRel.CaseTypeName, objvCourseLearningCaseWithResourceRel_Cond.CaseTypeName, strComparisonOp_CaseTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程学习案例With资源关系(vCourseLearningCaseWithResourceRel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCaseWithResourceRelWApi
{
private static readonly string mstrApiControllerName = "vCourseLearningCaseWithResourceRelApi";

 public clsvCourseLearningCaseWithResourceRelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseWithResourceRelEN GetObjById_CourseLearningCase(string strId_CourseLearningCase)
{
string strAction = "GetObjById_CourseLearningCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningCaseWithResourceRelEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseWithResourceRelEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseWithResourceRelEN;
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
 /// <param name = "strId_CourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseWithResourceRelEN GetObjById_CourseLearningCase_WA_Cache(string strId_CourseLearningCase)
{
string strAction = "GetObjById_CourseLearningCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningCaseWithResourceRelEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseWithResourceRelEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseWithResourceRelEN;
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
public static clsvCourseLearningCaseWithResourceRelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = null;
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
objvCourseLearningCaseWithResourceRelEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseWithResourceRelEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseWithResourceRelEN;
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
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCaseWithResourceRelEN GetObjById_CourseLearningCase_Cache(string strId_CourseLearningCase)
{
if (string.IsNullOrEmpty(strId_CourseLearningCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCaseWithResourceRelEN._CurrTabName_S);
List<clsvCourseLearningCaseWithResourceRelEN> arrvCourseLearningCaseWithResourceRelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseWithResourceRelEN> arrvCourseLearningCaseWithResourceRelObjLst_Sel =
from objvCourseLearningCaseWithResourceRelEN in arrvCourseLearningCaseWithResourceRelObjLst_Cache
where objvCourseLearningCaseWithResourceRelEN.Id_CourseLearningCase == strId_CourseLearningCase
select objvCourseLearningCaseWithResourceRelEN;
if (arrvCourseLearningCaseWithResourceRelObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCaseWithResourceRelEN obj = clsvCourseLearningCaseWithResourceRelWApi.GetObjById_CourseLearningCase(strId_CourseLearningCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCourseLearningCaseWithResourceRelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLst(string strWhereCond)
{
 List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseWithResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstById_CourseLearningCaseLst(List<string> arrId_CourseLearningCase)
{
 List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = null; 
string strAction = "GetObjLstById_CourseLearningCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CourseLearningCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseWithResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCourseLearningCaseWithResourceRelEN> GetObjLstById_CourseLearningCaseLst_Cache(List<string> arrId_CourseLearningCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCaseWithResourceRelEN._CurrTabName_S);
List<clsvCourseLearningCaseWithResourceRelEN> arrvCourseLearningCaseWithResourceRelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseWithResourceRelEN> arrvCourseLearningCaseWithResourceRelObjLst_Sel =
from objvCourseLearningCaseWithResourceRelEN in arrvCourseLearningCaseWithResourceRelObjLst_Cache
where arrId_CourseLearningCase.Contains(objvCourseLearningCaseWithResourceRelEN.Id_CourseLearningCase)
select objvCourseLearningCaseWithResourceRelEN;
return arrvCourseLearningCaseWithResourceRelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstById_CourseLearningCaseLst_WA_Cache(List<string> arrId_CourseLearningCase)
{
 List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = null; 
string strAction = "GetObjLstById_CourseLearningCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CourseLearningCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseWithResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseWithResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseWithResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseWithResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseWithResourceRelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strId_CourseLearningCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase
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
 /// <param name = "objvCourseLearningCaseWithResourceRelENS">源对象</param>
 /// <param name = "objvCourseLearningCaseWithResourceRelENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelENS, clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelENT)
{
try
{
objvCourseLearningCaseWithResourceRelENT.Id_CourseLearningCase = objvCourseLearningCaseWithResourceRelENS.Id_CourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseWithResourceRelENT.id_MicroteachCase_Resource_Rel = objvCourseLearningCaseWithResourceRelENS.id_MicroteachCase_Resource_Rel; //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelENT.FuncModuleId = objvCourseLearningCaseWithResourceRelENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseWithResourceRelENT.FuncModuleName = objvCourseLearningCaseWithResourceRelENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseWithResourceRelENT.id_Resource = objvCourseLearningCaseWithResourceRelENS.id_Resource; //资源流水号
objvCourseLearningCaseWithResourceRelENT.ResourceID = objvCourseLearningCaseWithResourceRelENS.ResourceID; //资源ID
objvCourseLearningCaseWithResourceRelENT.ResourceName = objvCourseLearningCaseWithResourceRelENS.ResourceName; //资源名称
objvCourseLearningCaseWithResourceRelENT.id_FtpResource = objvCourseLearningCaseWithResourceRelENS.id_FtpResource; //FTP资源流水号
objvCourseLearningCaseWithResourceRelENT.id_File = objvCourseLearningCaseWithResourceRelENS.id_File; //文件流水号
objvCourseLearningCaseWithResourceRelENT.FileSize = objvCourseLearningCaseWithResourceRelENS.FileSize; //文件大小
objvCourseLearningCaseWithResourceRelENT.SaveTime = objvCourseLearningCaseWithResourceRelENS.SaveTime; //创建时间
objvCourseLearningCaseWithResourceRelENT.id_ResourceType = objvCourseLearningCaseWithResourceRelENS.id_ResourceType; //资源类型流水号
objvCourseLearningCaseWithResourceRelENT.ResourceTypeID = objvCourseLearningCaseWithResourceRelENS.ResourceTypeID; //资源类型ID
objvCourseLearningCaseWithResourceRelENT.ResourceTypeName = objvCourseLearningCaseWithResourceRelENS.ResourceTypeName; //资源类型名称
objvCourseLearningCaseWithResourceRelENT.ResourceOwner = objvCourseLearningCaseWithResourceRelENS.ResourceOwner; //上传者
objvCourseLearningCaseWithResourceRelENT.IsExistFile = objvCourseLearningCaseWithResourceRelENS.IsExistFile; //是否存在文件
objvCourseLearningCaseWithResourceRelENT.FileNewName = objvCourseLearningCaseWithResourceRelENS.FileNewName; //新文件名
objvCourseLearningCaseWithResourceRelENT.IsMain = objvCourseLearningCaseWithResourceRelENS.IsMain; //是否主资源
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseID = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseName = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseText = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTheme = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseDate = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTime = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseDateIn = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTimeIn = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCaseWithResourceRelENT.Id_CaseType = objvCourseLearningCaseWithResourceRelENS.Id_CaseType; //案例类型流水号
objvCourseLearningCaseWithResourceRelENT.id_CourseLearningCaseType = objvCourseLearningCaseWithResourceRelENS.id_CourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTypeName = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelENT.OwnerId = objvCourseLearningCaseWithResourceRelENS.OwnerId; //拥有者Id
objvCourseLearningCaseWithResourceRelENT.id_StudyLevel = objvCourseLearningCaseWithResourceRelENS.id_StudyLevel; //id_StudyLevel
objvCourseLearningCaseWithResourceRelENT.StudyLevelName = objvCourseLearningCaseWithResourceRelENS.StudyLevelName; //学段名称
objvCourseLearningCaseWithResourceRelENT.id_TeachingPlan = objvCourseLearningCaseWithResourceRelENS.id_TeachingPlan; //教案流水号
objvCourseLearningCaseWithResourceRelENT.id_Discipline = objvCourseLearningCaseWithResourceRelENS.id_Discipline; //学科流水号
objvCourseLearningCaseWithResourceRelENT.DisciplineID = objvCourseLearningCaseWithResourceRelENS.DisciplineID; //学科ID
objvCourseLearningCaseWithResourceRelENT.DisciplineName = objvCourseLearningCaseWithResourceRelENS.DisciplineName; //学科名称
objvCourseLearningCaseWithResourceRelENT.BrowseCount = objvCourseLearningCaseWithResourceRelENS.BrowseCount; //浏览次数
objvCourseLearningCaseWithResourceRelENT.id_SenateGaugeVersion = objvCourseLearningCaseWithResourceRelENS.id_SenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionID = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionName = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionTtlScore = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCaseWithResourceRelENT.VersionNo = objvCourseLearningCaseWithResourceRelENS.VersionNo; //版本号
objvCourseLearningCaseWithResourceRelENT.id_TeachSkill = objvCourseLearningCaseWithResourceRelENS.id_TeachSkill; //教学技能流水号
objvCourseLearningCaseWithResourceRelENT.TeachSkillID = objvCourseLearningCaseWithResourceRelENS.TeachSkillID; //教学技能ID
objvCourseLearningCaseWithResourceRelENT.SkillTypeName = objvCourseLearningCaseWithResourceRelENS.SkillTypeName; //技能类型名称
objvCourseLearningCaseWithResourceRelENT.TeachSkillName = objvCourseLearningCaseWithResourceRelENS.TeachSkillName; //教学技能名称
objvCourseLearningCaseWithResourceRelENT.TeachSkillTheory = objvCourseLearningCaseWithResourceRelENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCaseWithResourceRelENT.TeachSkillOperMethod = objvCourseLearningCaseWithResourceRelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelENT.id_SkillType = objvCourseLearningCaseWithResourceRelENS.id_SkillType; //技能类型流水号
objvCourseLearningCaseWithResourceRelENT.SkillTypeID = objvCourseLearningCaseWithResourceRelENS.SkillTypeID; //技能类型ID
objvCourseLearningCaseWithResourceRelENT.CaseLevelId = objvCourseLearningCaseWithResourceRelENS.CaseLevelId; //课例等级Id
objvCourseLearningCaseWithResourceRelENT.CaseLevelName = objvCourseLearningCaseWithResourceRelENS.CaseLevelName; //案例等级名称
objvCourseLearningCaseWithResourceRelENT.DocFile = objvCourseLearningCaseWithResourceRelENS.DocFile; //生成的Word文件名
objvCourseLearningCaseWithResourceRelENT.IsNeedGeneWord = objvCourseLearningCaseWithResourceRelENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCaseWithResourceRelENT.WordCreateDate = objvCourseLearningCaseWithResourceRelENS.WordCreateDate; //Word生成日期
objvCourseLearningCaseWithResourceRelENT.IsVisible = objvCourseLearningCaseWithResourceRelENS.IsVisible; //是否显示
objvCourseLearningCaseWithResourceRelENT.IsDualVideo = objvCourseLearningCaseWithResourceRelENS.IsDualVideo; //是否双视频
objvCourseLearningCaseWithResourceRelENT.id_XzCollege = objvCourseLearningCaseWithResourceRelENS.id_XzCollege; //学院流水号
objvCourseLearningCaseWithResourceRelENT.CollegeID = objvCourseLearningCaseWithResourceRelENS.CollegeID; //学院ID
objvCourseLearningCaseWithResourceRelENT.CollegeName = objvCourseLearningCaseWithResourceRelENS.CollegeName; //学院名称
objvCourseLearningCaseWithResourceRelENT.CollegeNameA = objvCourseLearningCaseWithResourceRelENS.CollegeNameA; //学院名称简写
objvCourseLearningCaseWithResourceRelENT.id_XzMajor = objvCourseLearningCaseWithResourceRelENS.id_XzMajor; //专业流水号
objvCourseLearningCaseWithResourceRelENT.MajorID = objvCourseLearningCaseWithResourceRelENS.MajorID; //专业ID
objvCourseLearningCaseWithResourceRelENT.MajorName = objvCourseLearningCaseWithResourceRelENS.MajorName; //专业名称
objvCourseLearningCaseWithResourceRelENT.CourseId = objvCourseLearningCaseWithResourceRelENS.CourseId; //课程Id
objvCourseLearningCaseWithResourceRelENT.CourseCode = objvCourseLearningCaseWithResourceRelENS.CourseCode; //课程代码
objvCourseLearningCaseWithResourceRelENT.CourseName = objvCourseLearningCaseWithResourceRelENS.CourseName; //课程名称
objvCourseLearningCaseWithResourceRelENT.TeachingSolutionId = objvCourseLearningCaseWithResourceRelENS.TeachingSolutionId; //教学方案Id
objvCourseLearningCaseWithResourceRelENT.CourseChapterId = objvCourseLearningCaseWithResourceRelENS.CourseChapterId; //课程章节ID
objvCourseLearningCaseWithResourceRelENT.CourseChapterName = objvCourseLearningCaseWithResourceRelENS.CourseChapterName; //课程章节名称
objvCourseLearningCaseWithResourceRelENT.ParentNodeID = objvCourseLearningCaseWithResourceRelENS.ParentNodeID; //父节点编号
objvCourseLearningCaseWithResourceRelENT.ParentNodeName = objvCourseLearningCaseWithResourceRelENS.ParentNodeName; //父节点名称
objvCourseLearningCaseWithResourceRelENT.CourseChapterReferred = objvCourseLearningCaseWithResourceRelENS.CourseChapterReferred; //节简称
objvCourseLearningCaseWithResourceRelENT.ParentNodeReferred = objvCourseLearningCaseWithResourceRelENS.ParentNodeReferred; //章简称
objvCourseLearningCaseWithResourceRelENT.ViewCount = objvCourseLearningCaseWithResourceRelENS.ViewCount; //浏览量
objvCourseLearningCaseWithResourceRelENT.IsShow = objvCourseLearningCaseWithResourceRelENS.IsShow; //是否启用
objvCourseLearningCaseWithResourceRelENT.DownloadNumber = objvCourseLearningCaseWithResourceRelENS.DownloadNumber; //下载数目
objvCourseLearningCaseWithResourceRelENT.FileIntegration = objvCourseLearningCaseWithResourceRelENS.FileIntegration; //文件积分
objvCourseLearningCaseWithResourceRelENT.LikeCount = objvCourseLearningCaseWithResourceRelENS.LikeCount; //资源喜欢数量
objvCourseLearningCaseWithResourceRelENT.CollectionCount = objvCourseLearningCaseWithResourceRelENS.CollectionCount; //收藏数量
objvCourseLearningCaseWithResourceRelENT.RecommendedDegreeId = objvCourseLearningCaseWithResourceRelENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCaseWithResourceRelENT.RecommendedDegreeName = objvCourseLearningCaseWithResourceRelENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCaseWithResourceRelENT.Memo = objvCourseLearningCaseWithResourceRelENS.Memo; //备注
objvCourseLearningCaseWithResourceRelENT.BrowseCount4Case = objvCourseLearningCaseWithResourceRelENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCaseWithResourceRelENT.OwnerName = objvCourseLearningCaseWithResourceRelENS.OwnerName; //拥有者姓名
objvCourseLearningCaseWithResourceRelENT.OwnerNameWithId = objvCourseLearningCaseWithResourceRelENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCaseWithResourceRelENT.CaseTypeName = objvCourseLearningCaseWithResourceRelENS.CaseTypeName; //案例类型名称
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
public static DataTable ToDataTable(List<clsvCourseLearningCaseWithResourceRelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCourseLearningCaseWithResourceRelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCourseLearningCaseWithResourceRelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCourseLearningCaseWithResourceRelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCourseLearningCaseWithResourceRelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCourseLearningCaseWithResourceRelEN.AttributeName)
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
if (clsCourseLearningCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseWApi没有刷新缓存机制(clsCourseLearningCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseTypeWApi没有刷新缓存机制(clsCourseLearningCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseTypeWApi没有刷新缓存机制(clsCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by Id_CourseLearningCase");
//if (arrvCourseLearningCaseWithResourceRelObjLst_Cache == null)
//{
//arrvCourseLearningCaseWithResourceRelObjLst_Cache = await clsvCourseLearningCaseWithResourceRelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCourseLearningCaseWithResourceRelEN._CurrTabName_S);
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
public static List<clsvCourseLearningCaseWithResourceRelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCaseWithResourceRelEN._CurrTabName_S);
List<clsvCourseLearningCaseWithResourceRelEN> arrvCourseLearningCaseWithResourceRelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCaseWithResourceRelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.Id_CourseLearningCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_MicroteachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseText, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CaseLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CaseLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.DocFile, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.IsNeedGeneWord, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.WordCreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.ParentNodeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.ParentNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CourseChapterReferred, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.ParentNodeReferred, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.FileIntegration, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseWithResourceRel.CaseTypeName, Type.GetType("System.String"));
foreach (clsvCourseLearningCaseWithResourceRelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCourseLearningCaseWithResourceRel.Id_CourseLearningCase] = objInFor[convCourseLearningCaseWithResourceRel.Id_CourseLearningCase];
objDR[convCourseLearningCaseWithResourceRel.id_MicroteachCase_Resource_Rel] = objInFor[convCourseLearningCaseWithResourceRel.id_MicroteachCase_Resource_Rel];
objDR[convCourseLearningCaseWithResourceRel.FuncModuleId] = objInFor[convCourseLearningCaseWithResourceRel.FuncModuleId];
objDR[convCourseLearningCaseWithResourceRel.FuncModuleName] = objInFor[convCourseLearningCaseWithResourceRel.FuncModuleName];
objDR[convCourseLearningCaseWithResourceRel.id_Resource] = objInFor[convCourseLearningCaseWithResourceRel.id_Resource];
objDR[convCourseLearningCaseWithResourceRel.ResourceID] = objInFor[convCourseLearningCaseWithResourceRel.ResourceID];
objDR[convCourseLearningCaseWithResourceRel.ResourceName] = objInFor[convCourseLearningCaseWithResourceRel.ResourceName];
objDR[convCourseLearningCaseWithResourceRel.id_FtpResource] = objInFor[convCourseLearningCaseWithResourceRel.id_FtpResource];
objDR[convCourseLearningCaseWithResourceRel.id_File] = objInFor[convCourseLearningCaseWithResourceRel.id_File];
objDR[convCourseLearningCaseWithResourceRel.FileSize] = objInFor[convCourseLearningCaseWithResourceRel.FileSize];
objDR[convCourseLearningCaseWithResourceRel.SaveTime] = objInFor[convCourseLearningCaseWithResourceRel.SaveTime];
objDR[convCourseLearningCaseWithResourceRel.id_ResourceType] = objInFor[convCourseLearningCaseWithResourceRel.id_ResourceType];
objDR[convCourseLearningCaseWithResourceRel.ResourceTypeID] = objInFor[convCourseLearningCaseWithResourceRel.ResourceTypeID];
objDR[convCourseLearningCaseWithResourceRel.ResourceTypeName] = objInFor[convCourseLearningCaseWithResourceRel.ResourceTypeName];
objDR[convCourseLearningCaseWithResourceRel.ResourceOwner] = objInFor[convCourseLearningCaseWithResourceRel.ResourceOwner];
objDR[convCourseLearningCaseWithResourceRel.IsExistFile] = objInFor[convCourseLearningCaseWithResourceRel.IsExistFile];
objDR[convCourseLearningCaseWithResourceRel.FileNewName] = objInFor[convCourseLearningCaseWithResourceRel.FileNewName];
objDR[convCourseLearningCaseWithResourceRel.IsMain] = objInFor[convCourseLearningCaseWithResourceRel.IsMain];
objDR[convCourseLearningCaseWithResourceRel.CourseLearningCaseID] = objInFor[convCourseLearningCaseWithResourceRel.CourseLearningCaseID];
objDR[convCourseLearningCaseWithResourceRel.CourseLearningCaseName] = objInFor[convCourseLearningCaseWithResourceRel.CourseLearningCaseName];
objDR[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] = objInFor[convCourseLearningCaseWithResourceRel.CourseLearningCaseText];
objDR[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] = objInFor[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme];
objDR[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] = objInFor[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate];
objDR[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] = objInFor[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime];
objDR[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] = objInFor[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn];
objDR[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] = objInFor[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn];
objDR[convCourseLearningCaseWithResourceRel.Id_CaseType] = objInFor[convCourseLearningCaseWithResourceRel.Id_CaseType];
objDR[convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType] = objInFor[convCourseLearningCaseWithResourceRel.id_CourseLearningCaseType];
objDR[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] = objInFor[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName];
objDR[convCourseLearningCaseWithResourceRel.OwnerId] = objInFor[convCourseLearningCaseWithResourceRel.OwnerId];
objDR[convCourseLearningCaseWithResourceRel.id_StudyLevel] = objInFor[convCourseLearningCaseWithResourceRel.id_StudyLevel];
objDR[convCourseLearningCaseWithResourceRel.StudyLevelName] = objInFor[convCourseLearningCaseWithResourceRel.StudyLevelName];
objDR[convCourseLearningCaseWithResourceRel.id_TeachingPlan] = objInFor[convCourseLearningCaseWithResourceRel.id_TeachingPlan];
objDR[convCourseLearningCaseWithResourceRel.id_Discipline] = objInFor[convCourseLearningCaseWithResourceRel.id_Discipline];
objDR[convCourseLearningCaseWithResourceRel.DisciplineID] = objInFor[convCourseLearningCaseWithResourceRel.DisciplineID];
objDR[convCourseLearningCaseWithResourceRel.DisciplineName] = objInFor[convCourseLearningCaseWithResourceRel.DisciplineName];
objDR[convCourseLearningCaseWithResourceRel.BrowseCount] = objInFor[convCourseLearningCaseWithResourceRel.BrowseCount];
objDR[convCourseLearningCaseWithResourceRel.id_SenateGaugeVersion] = objInFor[convCourseLearningCaseWithResourceRel.id_SenateGaugeVersion];
objDR[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] = objInFor[convCourseLearningCaseWithResourceRel.senateGaugeVersionID];
objDR[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] = objInFor[convCourseLearningCaseWithResourceRel.senateGaugeVersionName];
objDR[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] = objInFor[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore];
objDR[convCourseLearningCaseWithResourceRel.VersionNo] = objInFor[convCourseLearningCaseWithResourceRel.VersionNo];
objDR[convCourseLearningCaseWithResourceRel.id_TeachSkill] = objInFor[convCourseLearningCaseWithResourceRel.id_TeachSkill];
objDR[convCourseLearningCaseWithResourceRel.TeachSkillID] = objInFor[convCourseLearningCaseWithResourceRel.TeachSkillID];
objDR[convCourseLearningCaseWithResourceRel.SkillTypeName] = objInFor[convCourseLearningCaseWithResourceRel.SkillTypeName];
objDR[convCourseLearningCaseWithResourceRel.TeachSkillName] = objInFor[convCourseLearningCaseWithResourceRel.TeachSkillName];
objDR[convCourseLearningCaseWithResourceRel.TeachSkillTheory] = objInFor[convCourseLearningCaseWithResourceRel.TeachSkillTheory];
objDR[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] = objInFor[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod];
objDR[convCourseLearningCaseWithResourceRel.id_SkillType] = objInFor[convCourseLearningCaseWithResourceRel.id_SkillType];
objDR[convCourseLearningCaseWithResourceRel.SkillTypeID] = objInFor[convCourseLearningCaseWithResourceRel.SkillTypeID];
objDR[convCourseLearningCaseWithResourceRel.CaseLevelId] = objInFor[convCourseLearningCaseWithResourceRel.CaseLevelId];
objDR[convCourseLearningCaseWithResourceRel.CaseLevelName] = objInFor[convCourseLearningCaseWithResourceRel.CaseLevelName];
objDR[convCourseLearningCaseWithResourceRel.DocFile] = objInFor[convCourseLearningCaseWithResourceRel.DocFile];
objDR[convCourseLearningCaseWithResourceRel.IsNeedGeneWord] = objInFor[convCourseLearningCaseWithResourceRel.IsNeedGeneWord];
objDR[convCourseLearningCaseWithResourceRel.WordCreateDate] = objInFor[convCourseLearningCaseWithResourceRel.WordCreateDate];
objDR[convCourseLearningCaseWithResourceRel.IsVisible] = objInFor[convCourseLearningCaseWithResourceRel.IsVisible];
objDR[convCourseLearningCaseWithResourceRel.IsDualVideo] = objInFor[convCourseLearningCaseWithResourceRel.IsDualVideo];
objDR[convCourseLearningCaseWithResourceRel.id_XzCollege] = objInFor[convCourseLearningCaseWithResourceRel.id_XzCollege];
objDR[convCourseLearningCaseWithResourceRel.CollegeID] = objInFor[convCourseLearningCaseWithResourceRel.CollegeID];
objDR[convCourseLearningCaseWithResourceRel.CollegeName] = objInFor[convCourseLearningCaseWithResourceRel.CollegeName];
objDR[convCourseLearningCaseWithResourceRel.CollegeNameA] = objInFor[convCourseLearningCaseWithResourceRel.CollegeNameA];
objDR[convCourseLearningCaseWithResourceRel.id_XzMajor] = objInFor[convCourseLearningCaseWithResourceRel.id_XzMajor];
objDR[convCourseLearningCaseWithResourceRel.MajorID] = objInFor[convCourseLearningCaseWithResourceRel.MajorID];
objDR[convCourseLearningCaseWithResourceRel.MajorName] = objInFor[convCourseLearningCaseWithResourceRel.MajorName];
objDR[convCourseLearningCaseWithResourceRel.CourseId] = objInFor[convCourseLearningCaseWithResourceRel.CourseId];
objDR[convCourseLearningCaseWithResourceRel.CourseCode] = objInFor[convCourseLearningCaseWithResourceRel.CourseCode];
objDR[convCourseLearningCaseWithResourceRel.CourseName] = objInFor[convCourseLearningCaseWithResourceRel.CourseName];
objDR[convCourseLearningCaseWithResourceRel.TeachingSolutionId] = objInFor[convCourseLearningCaseWithResourceRel.TeachingSolutionId];
objDR[convCourseLearningCaseWithResourceRel.CourseChapterId] = objInFor[convCourseLearningCaseWithResourceRel.CourseChapterId];
objDR[convCourseLearningCaseWithResourceRel.CourseChapterName] = objInFor[convCourseLearningCaseWithResourceRel.CourseChapterName];
objDR[convCourseLearningCaseWithResourceRel.ParentNodeID] = objInFor[convCourseLearningCaseWithResourceRel.ParentNodeID];
objDR[convCourseLearningCaseWithResourceRel.ParentNodeName] = objInFor[convCourseLearningCaseWithResourceRel.ParentNodeName];
objDR[convCourseLearningCaseWithResourceRel.CourseChapterReferred] = objInFor[convCourseLearningCaseWithResourceRel.CourseChapterReferred];
objDR[convCourseLearningCaseWithResourceRel.ParentNodeReferred] = objInFor[convCourseLearningCaseWithResourceRel.ParentNodeReferred];
objDR[convCourseLearningCaseWithResourceRel.ViewCount] = objInFor[convCourseLearningCaseWithResourceRel.ViewCount];
objDR[convCourseLearningCaseWithResourceRel.IsShow] = objInFor[convCourseLearningCaseWithResourceRel.IsShow];
objDR[convCourseLearningCaseWithResourceRel.DownloadNumber] = objInFor[convCourseLearningCaseWithResourceRel.DownloadNumber];
objDR[convCourseLearningCaseWithResourceRel.FileIntegration] = objInFor[convCourseLearningCaseWithResourceRel.FileIntegration];
objDR[convCourseLearningCaseWithResourceRel.LikeCount] = objInFor[convCourseLearningCaseWithResourceRel.LikeCount];
objDR[convCourseLearningCaseWithResourceRel.CollectionCount] = objInFor[convCourseLearningCaseWithResourceRel.CollectionCount];
objDR[convCourseLearningCaseWithResourceRel.RecommendedDegreeId] = objInFor[convCourseLearningCaseWithResourceRel.RecommendedDegreeId];
objDR[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] = objInFor[convCourseLearningCaseWithResourceRel.RecommendedDegreeName];
objDR[convCourseLearningCaseWithResourceRel.Memo] = objInFor[convCourseLearningCaseWithResourceRel.Memo];
objDR[convCourseLearningCaseWithResourceRel.BrowseCount4Case] = objInFor[convCourseLearningCaseWithResourceRel.BrowseCount4Case];
objDR[convCourseLearningCaseWithResourceRel.OwnerName] = objInFor[convCourseLearningCaseWithResourceRel.OwnerName];
objDR[convCourseLearningCaseWithResourceRel.OwnerNameWithId] = objInFor[convCourseLearningCaseWithResourceRel.OwnerNameWithId];
objDR[convCourseLearningCaseWithResourceRel.CaseTypeName] = objInFor[convCourseLearningCaseWithResourceRel.CaseTypeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}