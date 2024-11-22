
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCaseRelaInfoWApi
 表名:vCoursewareResCaseRelaInfo(01120395)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:34
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库
 模块英文名:CoursewareResLib
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
public static class clsvCoursewareResCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvCoursewareResCaseRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFuncModuleId(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCoursewareResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCoursewareResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCoursewareResCaseRelaInfo.FuncModuleId);
objvCoursewareResCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FuncModuleId) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFuncModuleName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCoursewareResCaseRelaInfo.FuncModuleName);
objvCoursewareResCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FuncModuleName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN Setid_MicroteachCase(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convCoursewareResCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCoursewareResCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCoursewareResCaseRelaInfo.id_MicroteachCase);
objvCoursewareResCaseRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.id_MicroteachCase) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetId_CoursewareResCase(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strId_CoursewareResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CoursewareResCase, 8, convCoursewareResCaseRelaInfo.Id_CoursewareResCase);
clsCheckSql.CheckFieldForeignKey(strId_CoursewareResCase, 8, convCoursewareResCaseRelaInfo.Id_CoursewareResCase);
objvCoursewareResCaseRelaInfoEN.Id_CoursewareResCase = strId_CoursewareResCase; //课件资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.Id_CoursewareResCase) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.Id_CoursewareResCase, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.Id_CoursewareResCase] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetCoursewareResCaseName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strCoursewareResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoursewareResCaseName, 100, convCoursewareResCaseRelaInfo.CoursewareResCaseName);
objvCoursewareResCaseRelaInfoEN.CoursewareResCaseName = strCoursewareResCaseName; //课件资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.CoursewareResCaseName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.CoursewareResCaseName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CoursewareResCaseName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
objvCoursewareResCaseRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
objvCoursewareResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetIsVisible(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCoursewareResCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.IsVisible) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN Setid_File(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convCoursewareResCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convCoursewareResCaseRelaInfo.id_File);
objvCoursewareResCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.id_File) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFileName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convCoursewareResCaseRelaInfo.FileName);
objvCoursewareResCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FileName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFileType(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convCoursewareResCaseRelaInfo.FileType);
objvCoursewareResCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FileType) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetSaveDate(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convCoursewareResCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convCoursewareResCaseRelaInfo.SaveDate);
objvCoursewareResCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.SaveDate) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFileSize(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convCoursewareResCaseRelaInfo.FileSize);
objvCoursewareResCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FileSize) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetSaveTime(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convCoursewareResCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convCoursewareResCaseRelaInfo.SaveTime);
objvCoursewareResCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.SaveTime) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN Setid_FtpResource(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convCoursewareResCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convCoursewareResCaseRelaInfo.id_FtpResource);
objvCoursewareResCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.id_FtpResource) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFtpResourceID(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convCoursewareResCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convCoursewareResCaseRelaInfo.FtpResourceID);
objvCoursewareResCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FtpResourceID) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFileOriginalName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convCoursewareResCaseRelaInfo.FileOriginalName);
objvCoursewareResCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FileOriginalName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFileDirName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convCoursewareResCaseRelaInfo.FileDirName);
objvCoursewareResCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FileDirName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFileRename(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convCoursewareResCaseRelaInfo.FileRename);
objvCoursewareResCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FileRename) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFileUpDate(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convCoursewareResCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convCoursewareResCaseRelaInfo.FileUpDate);
objvCoursewareResCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FileUpDate) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFileUpTime(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convCoursewareResCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convCoursewareResCaseRelaInfo.FileUpTime);
objvCoursewareResCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FileUpTime) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN Setid_Resource(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convCoursewareResCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convCoursewareResCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convCoursewareResCaseRelaInfo.id_Resource);
objvCoursewareResCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.id_Resource) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetResourceID(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convCoursewareResCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convCoursewareResCaseRelaInfo.ResourceID);
objvCoursewareResCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.ResourceID) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetSaveMode(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvCoursewareResCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.SaveMode) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN Setid_ResourceType(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convCoursewareResCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convCoursewareResCaseRelaInfo.id_ResourceType);
objvCoursewareResCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.id_ResourceType) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetResourceTypeID(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convCoursewareResCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convCoursewareResCaseRelaInfo.ResourceTypeID);
objvCoursewareResCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.ResourceTypeID) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetResourceTypeName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convCoursewareResCaseRelaInfo.ResourceTypeName);
objvCoursewareResCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.ResourceTypeName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetMajorID(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCoursewareResCaseRelaInfo.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCoursewareResCaseRelaInfo.MajorID);
objvCoursewareResCaseRelaInfoEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.MajorID) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.MajorID, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.MajorID] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetMajorName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCoursewareResCaseRelaInfo.MajorName);
objvCoursewareResCaseRelaInfoEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.MajorName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.MajorName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.MajorName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN Setid_XzCollege(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCoursewareResCaseRelaInfo.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCoursewareResCaseRelaInfo.id_XzCollege);
objvCoursewareResCaseRelaInfoEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.id_XzCollege) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.id_XzCollege, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_XzCollege] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetCollegeID(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCoursewareResCaseRelaInfo.CollegeID);
objvCoursewareResCaseRelaInfoEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.CollegeID) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.CollegeID, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CollegeID] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetCollegeName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCoursewareResCaseRelaInfo.CollegeName);
objvCoursewareResCaseRelaInfoEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.CollegeName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.CollegeName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CollegeName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetCourseId(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCoursewareResCaseRelaInfo.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCoursewareResCaseRelaInfo.CourseId);
objvCoursewareResCaseRelaInfoEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.CourseId) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.CourseId, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CourseId] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetCourseCode(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCoursewareResCaseRelaInfo.CourseCode);
objvCoursewareResCaseRelaInfoEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.CourseCode) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.CourseCode, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CourseCode] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetCourseName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCoursewareResCaseRelaInfo.CourseName);
objvCoursewareResCaseRelaInfoEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.CourseName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.CourseName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CourseName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetBrowseCount(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvCoursewareResCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.BrowseCount) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetResourceOwner(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convCoursewareResCaseRelaInfo.ResourceOwner);
objvCoursewareResCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.ResourceOwner) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetftpFileType(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCoursewareResCaseRelaInfo.ftpFileType);
objvCoursewareResCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.ftpFileType) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetftpFileSize(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convCoursewareResCaseRelaInfo.ftpFileSize);
objvCoursewareResCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.ftpFileSize) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetftpResourceOwner(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convCoursewareResCaseRelaInfo.ftpResourceOwner);
objvCoursewareResCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.ftpResourceOwner) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFileOriginName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convCoursewareResCaseRelaInfo.FileOriginName);
objvCoursewareResCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FileOriginName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetIsExistFile(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvCoursewareResCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.IsExistFile) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFlag(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convCoursewareResCaseRelaInfo.Flag);
objvCoursewareResCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.Flag) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFileNewName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convCoursewareResCaseRelaInfo.FileNewName);
objvCoursewareResCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FileNewName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetFileOldName(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convCoursewareResCaseRelaInfo.FileOldName);
objvCoursewareResCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.FileOldName) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetUpdUser(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCoursewareResCaseRelaInfo.UpdUser);
objvCoursewareResCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.UpdUser) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetUpdDate(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCoursewareResCaseRelaInfo.UpdDate);
objvCoursewareResCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.UpdDate) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetMemo(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCoursewareResCaseRelaInfo.Memo);
objvCoursewareResCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.Memo) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCoursewareResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCoursewareResCaseRelaInfoEN SetCollegeNameA(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCoursewareResCaseRelaInfo.CollegeNameA);
objvCoursewareResCaseRelaInfoEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCoursewareResCaseRelaInfo.CollegeNameA) == false)
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp.Add(convCoursewareResCaseRelaInfo.CollegeNameA, strComparisonOp);
}
else
{
objvCoursewareResCaseRelaInfoEN.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CollegeNameA] = strComparisonOp;
}
}
return objvCoursewareResCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfo, objvCoursewareResCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FuncModuleId, objvCoursewareResCaseRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FuncModuleName, objvCoursewareResCaseRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.id_MicroteachCase, objvCoursewareResCaseRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.Id_CoursewareResCase) == true)
{
string strComparisonOp_Id_CoursewareResCase = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.Id_CoursewareResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.Id_CoursewareResCase, objvCoursewareResCaseRelaInfo_Cond.Id_CoursewareResCase, strComparisonOp_Id_CoursewareResCase);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.CoursewareResCaseName) == true)
{
string strComparisonOp_CoursewareResCaseName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CoursewareResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.CoursewareResCaseName, objvCoursewareResCaseRelaInfo_Cond.CoursewareResCaseName, strComparisonOp_CoursewareResCaseName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfoType, objvCoursewareResCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeID = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, objvCoursewareResCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeID, strComparisonOp_MicroTeachCaseRelaInfoTypeID);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvCoursewareResCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.IsVisible) == true)
{
if (objvCoursewareResCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCaseRelaInfo.IsVisible);
}
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.id_File, objvCoursewareResCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FileName, objvCoursewareResCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FileType, objvCoursewareResCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.SaveDate, objvCoursewareResCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FileSize, objvCoursewareResCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.SaveTime, objvCoursewareResCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.id_FtpResource, objvCoursewareResCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FtpResourceID, objvCoursewareResCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FileOriginalName, objvCoursewareResCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FileDirName, objvCoursewareResCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FileRename, objvCoursewareResCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FileUpDate, objvCoursewareResCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FileUpTime, objvCoursewareResCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.id_Resource, objvCoursewareResCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.ResourceID, objvCoursewareResCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.SaveMode) == true)
{
if (objvCoursewareResCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCaseRelaInfo.SaveMode);
}
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.id_ResourceType, objvCoursewareResCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.ResourceTypeID, objvCoursewareResCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.ResourceTypeName, objvCoursewareResCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.MajorID) == true)
{
string strComparisonOp_MajorID = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.MajorID, objvCoursewareResCaseRelaInfo_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.MajorName) == true)
{
string strComparisonOp_MajorName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.MajorName, objvCoursewareResCaseRelaInfo_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.id_XzCollege, objvCoursewareResCaseRelaInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.CollegeID, objvCoursewareResCaseRelaInfo_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.CollegeName, objvCoursewareResCaseRelaInfo_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.CourseId) == true)
{
string strComparisonOp_CourseId = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.CourseId, objvCoursewareResCaseRelaInfo_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.CourseCode, objvCoursewareResCaseRelaInfo_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.CourseName) == true)
{
string strComparisonOp_CourseName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.CourseName, objvCoursewareResCaseRelaInfo_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCoursewareResCaseRelaInfo.BrowseCount, objvCoursewareResCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.ResourceOwner, objvCoursewareResCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.ftpFileType, objvCoursewareResCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.ftpFileSize, objvCoursewareResCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.ftpResourceOwner, objvCoursewareResCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FileOriginName, objvCoursewareResCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.IsExistFile) == true)
{
if (objvCoursewareResCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCoursewareResCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCoursewareResCaseRelaInfo.IsExistFile);
}
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.Flag, objvCoursewareResCaseRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FileNewName, objvCoursewareResCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.FileOldName, objvCoursewareResCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.UpdUser, objvCoursewareResCaseRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.UpdDate, objvCoursewareResCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.Memo, objvCoursewareResCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
if (objvCoursewareResCaseRelaInfo_Cond.IsUpdated(convCoursewareResCaseRelaInfo.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCoursewareResCaseRelaInfo_Cond.dicFldComparisonOp[convCoursewareResCaseRelaInfo.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCoursewareResCaseRelaInfo.CollegeNameA, objvCoursewareResCaseRelaInfo_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课件资源案例相关信息(vCoursewareResCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCoursewareResCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vCoursewareResCaseRelaInfoApi";

 public clsvCoursewareResCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCoursewareResCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN = null;
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
objvCoursewareResCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCoursewareResCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCaseRelaInfoEN;
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
public static clsvCoursewareResCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN = null;
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
objvCoursewareResCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCoursewareResCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCaseRelaInfoEN;
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
public static clsvCoursewareResCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoEN = null;
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
objvCoursewareResCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCoursewareResCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCoursewareResCaseRelaInfoEN;
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
public static clsvCoursewareResCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareResCaseRelaInfoEN._CurrTabName_S);
List<clsvCoursewareResCaseRelaInfoEN> arrvCoursewareResCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareResCaseRelaInfoEN> arrvCoursewareResCaseRelaInfoObjLst_Sel =
from objvCoursewareResCaseRelaInfoEN in arrvCoursewareResCaseRelaInfoObjLst_Cache
where objvCoursewareResCaseRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvCoursewareResCaseRelaInfoEN;
if (arrvCoursewareResCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvCoursewareResCaseRelaInfoEN obj = clsvCoursewareResCaseRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCoursewareResCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareResCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvCoursewareResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvCoursewareResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCoursewareResCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCoursewareResCaseRelaInfoEN._CurrTabName_S);
List<clsvCoursewareResCaseRelaInfoEN> arrvCoursewareResCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCoursewareResCaseRelaInfoEN> arrvCoursewareResCaseRelaInfoObjLst_Sel =
from objvCoursewareResCaseRelaInfoEN in arrvCoursewareResCaseRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvCoursewareResCaseRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvCoursewareResCaseRelaInfoEN;
return arrvCoursewareResCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCoursewareResCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvCoursewareResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCoursewareResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCoursewareResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCoursewareResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCoursewareResCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCoursewareResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCoursewareResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCoursewareResCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCoursewareResCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoENS, clsvCoursewareResCaseRelaInfoEN objvCoursewareResCaseRelaInfoENT)
{
try
{
objvCoursewareResCaseRelaInfoENT.id_MicroTeachCaseRelaInfo = objvCoursewareResCaseRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvCoursewareResCaseRelaInfoENT.FuncModuleId = objvCoursewareResCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvCoursewareResCaseRelaInfoENT.FuncModuleName = objvCoursewareResCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvCoursewareResCaseRelaInfoENT.id_MicroteachCase = objvCoursewareResCaseRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvCoursewareResCaseRelaInfoENT.Id_CoursewareResCase = objvCoursewareResCaseRelaInfoENS.Id_CoursewareResCase; //课件资源案例流水号
objvCoursewareResCaseRelaInfoENT.CoursewareResCaseName = objvCoursewareResCaseRelaInfoENS.CoursewareResCaseName; //课件资源案例名称
objvCoursewareResCaseRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvCoursewareResCaseRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvCoursewareResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvCoursewareResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvCoursewareResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvCoursewareResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvCoursewareResCaseRelaInfoENT.IsVisible = objvCoursewareResCaseRelaInfoENS.IsVisible; //是否显示
objvCoursewareResCaseRelaInfoENT.id_File = objvCoursewareResCaseRelaInfoENS.id_File; //文件流水号
objvCoursewareResCaseRelaInfoENT.FileName = objvCoursewareResCaseRelaInfoENS.FileName; //文件名称
objvCoursewareResCaseRelaInfoENT.FileType = objvCoursewareResCaseRelaInfoENS.FileType; //文件类型
objvCoursewareResCaseRelaInfoENT.SaveDate = objvCoursewareResCaseRelaInfoENS.SaveDate; //创建日期
objvCoursewareResCaseRelaInfoENT.FileSize = objvCoursewareResCaseRelaInfoENS.FileSize; //文件大小
objvCoursewareResCaseRelaInfoENT.SaveTime = objvCoursewareResCaseRelaInfoENS.SaveTime; //创建时间
objvCoursewareResCaseRelaInfoENT.id_FtpResource = objvCoursewareResCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvCoursewareResCaseRelaInfoENT.FtpResourceID = objvCoursewareResCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvCoursewareResCaseRelaInfoENT.FileOriginalName = objvCoursewareResCaseRelaInfoENS.FileOriginalName; //文件原名
objvCoursewareResCaseRelaInfoENT.FileDirName = objvCoursewareResCaseRelaInfoENS.FileDirName; //文件目录名
objvCoursewareResCaseRelaInfoENT.FileRename = objvCoursewareResCaseRelaInfoENS.FileRename; //文件新名
objvCoursewareResCaseRelaInfoENT.FileUpDate = objvCoursewareResCaseRelaInfoENS.FileUpDate; //创建日期
objvCoursewareResCaseRelaInfoENT.FileUpTime = objvCoursewareResCaseRelaInfoENS.FileUpTime; //创建时间
objvCoursewareResCaseRelaInfoENT.id_Resource = objvCoursewareResCaseRelaInfoENS.id_Resource; //资源流水号
objvCoursewareResCaseRelaInfoENT.ResourceID = objvCoursewareResCaseRelaInfoENS.ResourceID; //资源ID
objvCoursewareResCaseRelaInfoENT.SaveMode = objvCoursewareResCaseRelaInfoENS.SaveMode; //文件存放方式
objvCoursewareResCaseRelaInfoENT.id_ResourceType = objvCoursewareResCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvCoursewareResCaseRelaInfoENT.ResourceTypeID = objvCoursewareResCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvCoursewareResCaseRelaInfoENT.ResourceTypeName = objvCoursewareResCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvCoursewareResCaseRelaInfoENT.MajorID = objvCoursewareResCaseRelaInfoENS.MajorID; //专业ID
objvCoursewareResCaseRelaInfoENT.MajorName = objvCoursewareResCaseRelaInfoENS.MajorName; //专业名称
objvCoursewareResCaseRelaInfoENT.id_XzCollege = objvCoursewareResCaseRelaInfoENS.id_XzCollege; //学院流水号
objvCoursewareResCaseRelaInfoENT.CollegeID = objvCoursewareResCaseRelaInfoENS.CollegeID; //学院ID
objvCoursewareResCaseRelaInfoENT.CollegeName = objvCoursewareResCaseRelaInfoENS.CollegeName; //学院名称
objvCoursewareResCaseRelaInfoENT.CourseId = objvCoursewareResCaseRelaInfoENS.CourseId; //课程Id
objvCoursewareResCaseRelaInfoENT.CourseCode = objvCoursewareResCaseRelaInfoENS.CourseCode; //课程代码
objvCoursewareResCaseRelaInfoENT.CourseName = objvCoursewareResCaseRelaInfoENS.CourseName; //课程名称
objvCoursewareResCaseRelaInfoENT.BrowseCount = objvCoursewareResCaseRelaInfoENS.BrowseCount; //浏览次数
objvCoursewareResCaseRelaInfoENT.ResourceOwner = objvCoursewareResCaseRelaInfoENS.ResourceOwner; //上传者
objvCoursewareResCaseRelaInfoENT.ftpFileType = objvCoursewareResCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvCoursewareResCaseRelaInfoENT.ftpFileSize = objvCoursewareResCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvCoursewareResCaseRelaInfoENT.ftpResourceOwner = objvCoursewareResCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvCoursewareResCaseRelaInfoENT.FileOriginName = objvCoursewareResCaseRelaInfoENS.FileOriginName; //原文件名
objvCoursewareResCaseRelaInfoENT.IsExistFile = objvCoursewareResCaseRelaInfoENS.IsExistFile; //是否存在文件
objvCoursewareResCaseRelaInfoENT.Flag = objvCoursewareResCaseRelaInfoENS.Flag; //标志
objvCoursewareResCaseRelaInfoENT.FileNewName = objvCoursewareResCaseRelaInfoENS.FileNewName; //新文件名
objvCoursewareResCaseRelaInfoENT.FileOldName = objvCoursewareResCaseRelaInfoENS.FileOldName; //旧文件名
objvCoursewareResCaseRelaInfoENT.UpdUser = objvCoursewareResCaseRelaInfoENS.UpdUser; //修改人
objvCoursewareResCaseRelaInfoENT.UpdDate = objvCoursewareResCaseRelaInfoENS.UpdDate; //修改日期
objvCoursewareResCaseRelaInfoENT.Memo = objvCoursewareResCaseRelaInfoENS.Memo; //备注
objvCoursewareResCaseRelaInfoENT.CollegeNameA = objvCoursewareResCaseRelaInfoENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvCoursewareResCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCoursewareResCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCoursewareResCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCoursewareResCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCoursewareResCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCoursewareResCaseRelaInfoEN.AttributeName)
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
if (clsCoursewareResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareResCaseWApi没有刷新缓存机制(clsCoursewareResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCoursewareResCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCoursewareResCaseTypeWApi没有刷新缓存机制(clsCoursewareResCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvCoursewareResCaseRelaInfoObjLst_Cache == null)
//{
//arrvCoursewareResCaseRelaInfoObjLst_Cache = await clsvCoursewareResCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCoursewareResCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvCoursewareResCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCoursewareResCaseRelaInfoEN._CurrTabName_S);
List<clsvCoursewareResCaseRelaInfoEN> arrvCoursewareResCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCoursewareResCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCoursewareResCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.Id_CoursewareResCase, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.CoursewareResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCoursewareResCaseRelaInfo.CollegeNameA, Type.GetType("System.String"));
foreach (clsvCoursewareResCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convCoursewareResCaseRelaInfo.FuncModuleId] = objInFor[convCoursewareResCaseRelaInfo.FuncModuleId];
objDR[convCoursewareResCaseRelaInfo.FuncModuleName] = objInFor[convCoursewareResCaseRelaInfo.FuncModuleName];
objDR[convCoursewareResCaseRelaInfo.id_MicroteachCase] = objInFor[convCoursewareResCaseRelaInfo.id_MicroteachCase];
objDR[convCoursewareResCaseRelaInfo.Id_CoursewareResCase] = objInFor[convCoursewareResCaseRelaInfo.Id_CoursewareResCase];
objDR[convCoursewareResCaseRelaInfo.CoursewareResCaseName] = objInFor[convCoursewareResCaseRelaInfo.CoursewareResCaseName];
objDR[convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convCoursewareResCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = objInFor[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
objDR[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convCoursewareResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convCoursewareResCaseRelaInfo.IsVisible] = objInFor[convCoursewareResCaseRelaInfo.IsVisible];
objDR[convCoursewareResCaseRelaInfo.id_File] = objInFor[convCoursewareResCaseRelaInfo.id_File];
objDR[convCoursewareResCaseRelaInfo.FileName] = objInFor[convCoursewareResCaseRelaInfo.FileName];
objDR[convCoursewareResCaseRelaInfo.FileType] = objInFor[convCoursewareResCaseRelaInfo.FileType];
objDR[convCoursewareResCaseRelaInfo.SaveDate] = objInFor[convCoursewareResCaseRelaInfo.SaveDate];
objDR[convCoursewareResCaseRelaInfo.FileSize] = objInFor[convCoursewareResCaseRelaInfo.FileSize];
objDR[convCoursewareResCaseRelaInfo.SaveTime] = objInFor[convCoursewareResCaseRelaInfo.SaveTime];
objDR[convCoursewareResCaseRelaInfo.id_FtpResource] = objInFor[convCoursewareResCaseRelaInfo.id_FtpResource];
objDR[convCoursewareResCaseRelaInfo.FtpResourceID] = objInFor[convCoursewareResCaseRelaInfo.FtpResourceID];
objDR[convCoursewareResCaseRelaInfo.FileOriginalName] = objInFor[convCoursewareResCaseRelaInfo.FileOriginalName];
objDR[convCoursewareResCaseRelaInfo.FileDirName] = objInFor[convCoursewareResCaseRelaInfo.FileDirName];
objDR[convCoursewareResCaseRelaInfo.FileRename] = objInFor[convCoursewareResCaseRelaInfo.FileRename];
objDR[convCoursewareResCaseRelaInfo.FileUpDate] = objInFor[convCoursewareResCaseRelaInfo.FileUpDate];
objDR[convCoursewareResCaseRelaInfo.FileUpTime] = objInFor[convCoursewareResCaseRelaInfo.FileUpTime];
objDR[convCoursewareResCaseRelaInfo.id_Resource] = objInFor[convCoursewareResCaseRelaInfo.id_Resource];
objDR[convCoursewareResCaseRelaInfo.ResourceID] = objInFor[convCoursewareResCaseRelaInfo.ResourceID];
objDR[convCoursewareResCaseRelaInfo.SaveMode] = objInFor[convCoursewareResCaseRelaInfo.SaveMode];
objDR[convCoursewareResCaseRelaInfo.id_ResourceType] = objInFor[convCoursewareResCaseRelaInfo.id_ResourceType];
objDR[convCoursewareResCaseRelaInfo.ResourceTypeID] = objInFor[convCoursewareResCaseRelaInfo.ResourceTypeID];
objDR[convCoursewareResCaseRelaInfo.ResourceTypeName] = objInFor[convCoursewareResCaseRelaInfo.ResourceTypeName];
objDR[convCoursewareResCaseRelaInfo.MajorID] = objInFor[convCoursewareResCaseRelaInfo.MajorID];
objDR[convCoursewareResCaseRelaInfo.MajorName] = objInFor[convCoursewareResCaseRelaInfo.MajorName];
objDR[convCoursewareResCaseRelaInfo.id_XzCollege] = objInFor[convCoursewareResCaseRelaInfo.id_XzCollege];
objDR[convCoursewareResCaseRelaInfo.CollegeID] = objInFor[convCoursewareResCaseRelaInfo.CollegeID];
objDR[convCoursewareResCaseRelaInfo.CollegeName] = objInFor[convCoursewareResCaseRelaInfo.CollegeName];
objDR[convCoursewareResCaseRelaInfo.CourseId] = objInFor[convCoursewareResCaseRelaInfo.CourseId];
objDR[convCoursewareResCaseRelaInfo.CourseCode] = objInFor[convCoursewareResCaseRelaInfo.CourseCode];
objDR[convCoursewareResCaseRelaInfo.CourseName] = objInFor[convCoursewareResCaseRelaInfo.CourseName];
objDR[convCoursewareResCaseRelaInfo.BrowseCount] = objInFor[convCoursewareResCaseRelaInfo.BrowseCount];
objDR[convCoursewareResCaseRelaInfo.ResourceOwner] = objInFor[convCoursewareResCaseRelaInfo.ResourceOwner];
objDR[convCoursewareResCaseRelaInfo.ftpFileType] = objInFor[convCoursewareResCaseRelaInfo.ftpFileType];
objDR[convCoursewareResCaseRelaInfo.ftpFileSize] = objInFor[convCoursewareResCaseRelaInfo.ftpFileSize];
objDR[convCoursewareResCaseRelaInfo.ftpResourceOwner] = objInFor[convCoursewareResCaseRelaInfo.ftpResourceOwner];
objDR[convCoursewareResCaseRelaInfo.FileOriginName] = objInFor[convCoursewareResCaseRelaInfo.FileOriginName];
objDR[convCoursewareResCaseRelaInfo.IsExistFile] = objInFor[convCoursewareResCaseRelaInfo.IsExistFile];
objDR[convCoursewareResCaseRelaInfo.Flag] = objInFor[convCoursewareResCaseRelaInfo.Flag];
objDR[convCoursewareResCaseRelaInfo.FileNewName] = objInFor[convCoursewareResCaseRelaInfo.FileNewName];
objDR[convCoursewareResCaseRelaInfo.FileOldName] = objInFor[convCoursewareResCaseRelaInfo.FileOldName];
objDR[convCoursewareResCaseRelaInfo.UpdUser] = objInFor[convCoursewareResCaseRelaInfo.UpdUser];
objDR[convCoursewareResCaseRelaInfo.UpdDate] = objInFor[convCoursewareResCaseRelaInfo.UpdDate];
objDR[convCoursewareResCaseRelaInfo.Memo] = objInFor[convCoursewareResCaseRelaInfo.Memo];
objDR[convCoursewareResCaseRelaInfo.CollegeNameA] = objInFor[convCoursewareResCaseRelaInfo.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}