
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseRelaInfoWApi
 表名:vCourseLearningCaseRelaInfo(01120270)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:20
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
public static class clsvCourseLearningCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvCourseLearningCaseRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFuncModuleId(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCourseLearningCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningCaseRelaInfo.FuncModuleId);
objvCourseLearningCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FuncModuleId) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFuncModuleName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningCaseRelaInfo.FuncModuleName);
objvCourseLearningCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FuncModuleName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetId_CourseLearningCase(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strId_CourseLearningCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CourseLearningCase, 8, convCourseLearningCaseRelaInfo.Id_CourseLearningCase);
clsCheckSql.CheckFieldForeignKey(strId_CourseLearningCase, 8, convCourseLearningCaseRelaInfo.Id_CourseLearningCase);
objvCourseLearningCaseRelaInfoEN.Id_CourseLearningCase = strId_CourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.Id_CourseLearningCase) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.Id_CourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.Id_CourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN Setid_MicroteachCase(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convCourseLearningCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCourseLearningCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCourseLearningCaseRelaInfo.id_MicroteachCase);
objvCourseLearningCaseRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.id_MicroteachCase) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCourseLearningCaseName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCaseRelaInfo.CourseLearningCaseName);
objvCourseLearningCaseRelaInfoEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CourseLearningCaseName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
objvCourseLearningCaseRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
objvCourseLearningCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN Setid_File(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convCourseLearningCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convCourseLearningCaseRelaInfo.id_File);
objvCourseLearningCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.id_File) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convCourseLearningCaseRelaInfo.FileName);
objvCourseLearningCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileType(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convCourseLearningCaseRelaInfo.FileType);
objvCourseLearningCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileType) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetSaveDate(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convCourseLearningCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convCourseLearningCaseRelaInfo.SaveDate);
objvCourseLearningCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.SaveDate) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileSize(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convCourseLearningCaseRelaInfo.FileSize);
objvCourseLearningCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileSize) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetSaveTime(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convCourseLearningCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convCourseLearningCaseRelaInfo.SaveTime);
objvCourseLearningCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.SaveTime) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN Setid_FtpResource(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convCourseLearningCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convCourseLearningCaseRelaInfo.id_FtpResource);
objvCourseLearningCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.id_FtpResource) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFtpResourceID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convCourseLearningCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convCourseLearningCaseRelaInfo.FtpResourceID);
objvCourseLearningCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FtpResourceID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileOriginalName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convCourseLearningCaseRelaInfo.FileOriginalName);
objvCourseLearningCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileOriginalName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileDirName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convCourseLearningCaseRelaInfo.FileDirName);
objvCourseLearningCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileDirName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileRename(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convCourseLearningCaseRelaInfo.FileRename);
objvCourseLearningCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileRename) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileUpDate(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convCourseLearningCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convCourseLearningCaseRelaInfo.FileUpDate);
objvCourseLearningCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileUpDate) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileUpTime(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convCourseLearningCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convCourseLearningCaseRelaInfo.FileUpTime);
objvCourseLearningCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileUpTime) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN Setid_Resource(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convCourseLearningCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convCourseLearningCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convCourseLearningCaseRelaInfo.id_Resource);
objvCourseLearningCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.id_Resource) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetResourceID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convCourseLearningCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convCourseLearningCaseRelaInfo.ResourceID);
objvCourseLearningCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ResourceID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetSaveMode(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvCourseLearningCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.SaveMode) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN Setid_ResourceType(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convCourseLearningCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convCourseLearningCaseRelaInfo.id_ResourceType);
objvCourseLearningCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.id_ResourceType) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetResourceTypeID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convCourseLearningCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convCourseLearningCaseRelaInfo.ResourceTypeID);
objvCourseLearningCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ResourceTypeID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetResourceTypeName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convCourseLearningCaseRelaInfo.ResourceTypeName);
objvCourseLearningCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ResourceTypeName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetMajorID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningCaseRelaInfo.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningCaseRelaInfo.MajorID);
objvCourseLearningCaseRelaInfoEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.MajorID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.MajorID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MajorID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetMajorName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningCaseRelaInfo.MajorName);
objvCourseLearningCaseRelaInfoEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.MajorName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.MajorName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MajorName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN Setid_XzCollege(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCourseLearningCaseRelaInfo.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCourseLearningCaseRelaInfo.id_XzCollege);
objvCourseLearningCaseRelaInfoEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.id_XzCollege) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.id_XzCollege, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_XzCollege] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCollegeID(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningCaseRelaInfo.CollegeID);
objvCourseLearningCaseRelaInfoEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CollegeID) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CollegeID, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CollegeID] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCollegeName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningCaseRelaInfo.CollegeName);
objvCourseLearningCaseRelaInfoEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CollegeName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCourseId(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCaseRelaInfo.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCaseRelaInfo.CourseId);
objvCourseLearningCaseRelaInfoEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CourseId) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCourseCode(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCaseRelaInfo.CourseCode);
objvCourseLearningCaseRelaInfoEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CourseCode) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetCourseName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCaseRelaInfo.CourseName);
objvCourseLearningCaseRelaInfoEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.CourseName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetBrowseCount(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvCourseLearningCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.BrowseCount) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetResourceOwner(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convCourseLearningCaseRelaInfo.ResourceOwner);
objvCourseLearningCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ResourceOwner) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetftpFileType(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convCourseLearningCaseRelaInfo.ftpFileType);
objvCourseLearningCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ftpFileType) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetftpFileSize(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convCourseLearningCaseRelaInfo.ftpFileSize);
objvCourseLearningCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ftpFileSize) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetftpResourceOwner(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convCourseLearningCaseRelaInfo.ftpResourceOwner);
objvCourseLearningCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.ftpResourceOwner) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileOriginName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convCourseLearningCaseRelaInfo.FileOriginName);
objvCourseLearningCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileOriginName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIsExistFile(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvCourseLearningCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IsExistFile) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFlag(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convCourseLearningCaseRelaInfo.Flag);
objvCourseLearningCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.Flag) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileNewName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convCourseLearningCaseRelaInfo.FileNewName);
objvCourseLearningCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileNewName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetFileOldName(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convCourseLearningCaseRelaInfo.FileOldName);
objvCourseLearningCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.FileOldName) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetIsVisible(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCourseLearningCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.IsVisible) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetUpdDate(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCourseLearningCaseRelaInfo.UpdDate);
objvCourseLearningCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.UpdDate) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetUpdUser(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCourseLearningCaseRelaInfo.UpdUser);
objvCourseLearningCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.UpdUser) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseRelaInfoEN SetMemo(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCaseRelaInfo.Memo);
objvCourseLearningCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseRelaInfo.Memo) == false)
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp.Add(convCourseLearningCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvCourseLearningCaseRelaInfoEN.dicFldComparisonOp[convCourseLearningCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvCourseLearningCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfo, objvCourseLearningCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FuncModuleId, objvCourseLearningCaseRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FuncModuleName, objvCourseLearningCaseRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.Id_CourseLearningCase) == true)
{
string strComparisonOp_Id_CourseLearningCase = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.Id_CourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.Id_CourseLearningCase, objvCourseLearningCaseRelaInfo_Cond.Id_CourseLearningCase, strComparisonOp_Id_CourseLearningCase);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.id_MicroteachCase, objvCourseLearningCaseRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CourseLearningCaseName, objvCourseLearningCaseRelaInfo_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfoType, objvCourseLearningCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeID = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, objvCourseLearningCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeID, strComparisonOp_MicroTeachCaseRelaInfoTypeID);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvCourseLearningCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.id_File, objvCourseLearningCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileName, objvCourseLearningCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileType, objvCourseLearningCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.SaveDate, objvCourseLearningCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileSize, objvCourseLearningCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.SaveTime, objvCourseLearningCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.id_FtpResource, objvCourseLearningCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FtpResourceID, objvCourseLearningCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileOriginalName, objvCourseLearningCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileDirName, objvCourseLearningCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileRename, objvCourseLearningCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileUpDate, objvCourseLearningCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileUpTime, objvCourseLearningCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.id_Resource, objvCourseLearningCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ResourceID, objvCourseLearningCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.SaveMode) == true)
{
if (objvCourseLearningCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseRelaInfo.SaveMode);
}
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.id_ResourceType, objvCourseLearningCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ResourceTypeID, objvCourseLearningCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ResourceTypeName, objvCourseLearningCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.MajorID) == true)
{
string strComparisonOp_MajorID = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.MajorID, objvCourseLearningCaseRelaInfo_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.MajorName) == true)
{
string strComparisonOp_MajorName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.MajorName, objvCourseLearningCaseRelaInfo_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.id_XzCollege, objvCourseLearningCaseRelaInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CollegeID, objvCourseLearningCaseRelaInfo_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CollegeName, objvCourseLearningCaseRelaInfo_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.CourseId) == true)
{
string strComparisonOp_CourseId = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CourseId, objvCourseLearningCaseRelaInfo_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CourseCode, objvCourseLearningCaseRelaInfo_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.CourseName) == true)
{
string strComparisonOp_CourseName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.CourseName, objvCourseLearningCaseRelaInfo_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseRelaInfo.BrowseCount, objvCourseLearningCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ResourceOwner, objvCourseLearningCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ftpFileType, objvCourseLearningCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ftpFileSize, objvCourseLearningCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.ftpResourceOwner, objvCourseLearningCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileOriginName, objvCourseLearningCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.IsExistFile) == true)
{
if (objvCourseLearningCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseRelaInfo.IsExistFile);
}
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.Flag, objvCourseLearningCaseRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileNewName, objvCourseLearningCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.FileOldName, objvCourseLearningCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.IsVisible) == true)
{
if (objvCourseLearningCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCaseRelaInfo.IsVisible);
}
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.UpdDate, objvCourseLearningCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.UpdUser, objvCourseLearningCaseRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCourseLearningCaseRelaInfo_Cond.IsUpdated(convCourseLearningCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvCourseLearningCaseRelaInfo_Cond.dicFldComparisonOp[convCourseLearningCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseRelaInfo.Memo, objvCourseLearningCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程学习案例相关信息(vCourseLearningCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vCourseLearningCaseRelaInfoApi";

 public clsvCourseLearningCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = null;
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
objvCourseLearningCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseRelaInfoEN;
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
public static clsvCourseLearningCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = null;
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
objvCourseLearningCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseRelaInfoEN;
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
public static clsvCourseLearningCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoEN = null;
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
objvCourseLearningCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseRelaInfoEN;
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
public static clsvCourseLearningCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCaseRelaInfoEN._CurrTabName_S);
List<clsvCourseLearningCaseRelaInfoEN> arrvCourseLearningCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseRelaInfoEN> arrvCourseLearningCaseRelaInfoObjLst_Sel =
from objvCourseLearningCaseRelaInfoEN in arrvCourseLearningCaseRelaInfoObjLst_Cache
where objvCourseLearningCaseRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvCourseLearningCaseRelaInfoEN;
if (arrvCourseLearningCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCaseRelaInfoEN obj = clsvCourseLearningCaseRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCourseLearningCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCourseLearningCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCaseRelaInfoEN._CurrTabName_S);
List<clsvCourseLearningCaseRelaInfoEN> arrvCourseLearningCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseRelaInfoEN> arrvCourseLearningCaseRelaInfoObjLst_Sel =
from objvCourseLearningCaseRelaInfoEN in arrvCourseLearningCaseRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvCourseLearningCaseRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvCourseLearningCaseRelaInfoEN;
return arrvCourseLearningCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCourseLearningCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCourseLearningCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoENS, clsvCourseLearningCaseRelaInfoEN objvCourseLearningCaseRelaInfoENT)
{
try
{
objvCourseLearningCaseRelaInfoENT.id_MicroTeachCaseRelaInfo = objvCourseLearningCaseRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvCourseLearningCaseRelaInfoENT.FuncModuleId = objvCourseLearningCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseRelaInfoENT.FuncModuleName = objvCourseLearningCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseRelaInfoENT.Id_CourseLearningCase = objvCourseLearningCaseRelaInfoENS.Id_CourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseRelaInfoENT.id_MicroteachCase = objvCourseLearningCaseRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvCourseLearningCaseRelaInfoENT.CourseLearningCaseName = objvCourseLearningCaseRelaInfoENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvCourseLearningCaseRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvCourseLearningCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvCourseLearningCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvCourseLearningCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvCourseLearningCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvCourseLearningCaseRelaInfoENT.id_File = objvCourseLearningCaseRelaInfoENS.id_File; //文件流水号
objvCourseLearningCaseRelaInfoENT.FileName = objvCourseLearningCaseRelaInfoENS.FileName; //文件名称
objvCourseLearningCaseRelaInfoENT.FileType = objvCourseLearningCaseRelaInfoENS.FileType; //文件类型
objvCourseLearningCaseRelaInfoENT.SaveDate = objvCourseLearningCaseRelaInfoENS.SaveDate; //创建日期
objvCourseLearningCaseRelaInfoENT.FileSize = objvCourseLearningCaseRelaInfoENS.FileSize; //文件大小
objvCourseLearningCaseRelaInfoENT.SaveTime = objvCourseLearningCaseRelaInfoENS.SaveTime; //创建时间
objvCourseLearningCaseRelaInfoENT.id_FtpResource = objvCourseLearningCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvCourseLearningCaseRelaInfoENT.FtpResourceID = objvCourseLearningCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvCourseLearningCaseRelaInfoENT.FileOriginalName = objvCourseLearningCaseRelaInfoENS.FileOriginalName; //文件原名
objvCourseLearningCaseRelaInfoENT.FileDirName = objvCourseLearningCaseRelaInfoENS.FileDirName; //文件目录名
objvCourseLearningCaseRelaInfoENT.FileRename = objvCourseLearningCaseRelaInfoENS.FileRename; //文件新名
objvCourseLearningCaseRelaInfoENT.FileUpDate = objvCourseLearningCaseRelaInfoENS.FileUpDate; //创建日期
objvCourseLearningCaseRelaInfoENT.FileUpTime = objvCourseLearningCaseRelaInfoENS.FileUpTime; //创建时间
objvCourseLearningCaseRelaInfoENT.id_Resource = objvCourseLearningCaseRelaInfoENS.id_Resource; //资源流水号
objvCourseLearningCaseRelaInfoENT.ResourceID = objvCourseLearningCaseRelaInfoENS.ResourceID; //资源ID
objvCourseLearningCaseRelaInfoENT.SaveMode = objvCourseLearningCaseRelaInfoENS.SaveMode; //文件存放方式
objvCourseLearningCaseRelaInfoENT.id_ResourceType = objvCourseLearningCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvCourseLearningCaseRelaInfoENT.ResourceTypeID = objvCourseLearningCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvCourseLearningCaseRelaInfoENT.ResourceTypeName = objvCourseLearningCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvCourseLearningCaseRelaInfoENT.MajorID = objvCourseLearningCaseRelaInfoENS.MajorID; //专业ID
objvCourseLearningCaseRelaInfoENT.MajorName = objvCourseLearningCaseRelaInfoENS.MajorName; //专业名称
objvCourseLearningCaseRelaInfoENT.id_XzCollege = objvCourseLearningCaseRelaInfoENS.id_XzCollege; //学院流水号
objvCourseLearningCaseRelaInfoENT.CollegeID = objvCourseLearningCaseRelaInfoENS.CollegeID; //学院ID
objvCourseLearningCaseRelaInfoENT.CollegeName = objvCourseLearningCaseRelaInfoENS.CollegeName; //学院名称
objvCourseLearningCaseRelaInfoENT.CourseId = objvCourseLearningCaseRelaInfoENS.CourseId; //课程Id
objvCourseLearningCaseRelaInfoENT.CourseCode = objvCourseLearningCaseRelaInfoENS.CourseCode; //课程代码
objvCourseLearningCaseRelaInfoENT.CourseName = objvCourseLearningCaseRelaInfoENS.CourseName; //课程名称
objvCourseLearningCaseRelaInfoENT.BrowseCount = objvCourseLearningCaseRelaInfoENS.BrowseCount; //浏览次数
objvCourseLearningCaseRelaInfoENT.ResourceOwner = objvCourseLearningCaseRelaInfoENS.ResourceOwner; //上传者
objvCourseLearningCaseRelaInfoENT.ftpFileType = objvCourseLearningCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvCourseLearningCaseRelaInfoENT.ftpFileSize = objvCourseLearningCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvCourseLearningCaseRelaInfoENT.ftpResourceOwner = objvCourseLearningCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvCourseLearningCaseRelaInfoENT.FileOriginName = objvCourseLearningCaseRelaInfoENS.FileOriginName; //原文件名
objvCourseLearningCaseRelaInfoENT.IsExistFile = objvCourseLearningCaseRelaInfoENS.IsExistFile; //是否存在文件
objvCourseLearningCaseRelaInfoENT.Flag = objvCourseLearningCaseRelaInfoENS.Flag; //标志
objvCourseLearningCaseRelaInfoENT.FileNewName = objvCourseLearningCaseRelaInfoENS.FileNewName; //新文件名
objvCourseLearningCaseRelaInfoENT.FileOldName = objvCourseLearningCaseRelaInfoENS.FileOldName; //旧文件名
objvCourseLearningCaseRelaInfoENT.IsVisible = objvCourseLearningCaseRelaInfoENS.IsVisible; //是否显示
objvCourseLearningCaseRelaInfoENT.UpdDate = objvCourseLearningCaseRelaInfoENS.UpdDate; //修改日期
objvCourseLearningCaseRelaInfoENT.UpdUser = objvCourseLearningCaseRelaInfoENS.UpdUser; //修改人
objvCourseLearningCaseRelaInfoENT.Memo = objvCourseLearningCaseRelaInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvCourseLearningCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCourseLearningCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCourseLearningCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCourseLearningCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCourseLearningCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCourseLearningCaseRelaInfoEN.AttributeName)
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
//if (arrvCourseLearningCaseRelaInfoObjLst_Cache == null)
//{
//arrvCourseLearningCaseRelaInfoObjLst_Cache = await clsvCourseLearningCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCourseLearningCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvCourseLearningCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCaseRelaInfoEN._CurrTabName_S);
List<clsvCourseLearningCaseRelaInfoEN> arrvCourseLearningCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCourseLearningCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.Id_CourseLearningCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.CourseLearningCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseRelaInfo.Memo, Type.GetType("System.String"));
foreach (clsvCourseLearningCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convCourseLearningCaseRelaInfo.FuncModuleId] = objInFor[convCourseLearningCaseRelaInfo.FuncModuleId];
objDR[convCourseLearningCaseRelaInfo.FuncModuleName] = objInFor[convCourseLearningCaseRelaInfo.FuncModuleName];
objDR[convCourseLearningCaseRelaInfo.Id_CourseLearningCase] = objInFor[convCourseLearningCaseRelaInfo.Id_CourseLearningCase];
objDR[convCourseLearningCaseRelaInfo.id_MicroteachCase] = objInFor[convCourseLearningCaseRelaInfo.id_MicroteachCase];
objDR[convCourseLearningCaseRelaInfo.CourseLearningCaseName] = objInFor[convCourseLearningCaseRelaInfo.CourseLearningCaseName];
objDR[convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convCourseLearningCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = objInFor[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
objDR[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convCourseLearningCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convCourseLearningCaseRelaInfo.id_File] = objInFor[convCourseLearningCaseRelaInfo.id_File];
objDR[convCourseLearningCaseRelaInfo.FileName] = objInFor[convCourseLearningCaseRelaInfo.FileName];
objDR[convCourseLearningCaseRelaInfo.FileType] = objInFor[convCourseLearningCaseRelaInfo.FileType];
objDR[convCourseLearningCaseRelaInfo.SaveDate] = objInFor[convCourseLearningCaseRelaInfo.SaveDate];
objDR[convCourseLearningCaseRelaInfo.FileSize] = objInFor[convCourseLearningCaseRelaInfo.FileSize];
objDR[convCourseLearningCaseRelaInfo.SaveTime] = objInFor[convCourseLearningCaseRelaInfo.SaveTime];
objDR[convCourseLearningCaseRelaInfo.id_FtpResource] = objInFor[convCourseLearningCaseRelaInfo.id_FtpResource];
objDR[convCourseLearningCaseRelaInfo.FtpResourceID] = objInFor[convCourseLearningCaseRelaInfo.FtpResourceID];
objDR[convCourseLearningCaseRelaInfo.FileOriginalName] = objInFor[convCourseLearningCaseRelaInfo.FileOriginalName];
objDR[convCourseLearningCaseRelaInfo.FileDirName] = objInFor[convCourseLearningCaseRelaInfo.FileDirName];
objDR[convCourseLearningCaseRelaInfo.FileRename] = objInFor[convCourseLearningCaseRelaInfo.FileRename];
objDR[convCourseLearningCaseRelaInfo.FileUpDate] = objInFor[convCourseLearningCaseRelaInfo.FileUpDate];
objDR[convCourseLearningCaseRelaInfo.FileUpTime] = objInFor[convCourseLearningCaseRelaInfo.FileUpTime];
objDR[convCourseLearningCaseRelaInfo.id_Resource] = objInFor[convCourseLearningCaseRelaInfo.id_Resource];
objDR[convCourseLearningCaseRelaInfo.ResourceID] = objInFor[convCourseLearningCaseRelaInfo.ResourceID];
objDR[convCourseLearningCaseRelaInfo.SaveMode] = objInFor[convCourseLearningCaseRelaInfo.SaveMode];
objDR[convCourseLearningCaseRelaInfo.id_ResourceType] = objInFor[convCourseLearningCaseRelaInfo.id_ResourceType];
objDR[convCourseLearningCaseRelaInfo.ResourceTypeID] = objInFor[convCourseLearningCaseRelaInfo.ResourceTypeID];
objDR[convCourseLearningCaseRelaInfo.ResourceTypeName] = objInFor[convCourseLearningCaseRelaInfo.ResourceTypeName];
objDR[convCourseLearningCaseRelaInfo.MajorID] = objInFor[convCourseLearningCaseRelaInfo.MajorID];
objDR[convCourseLearningCaseRelaInfo.MajorName] = objInFor[convCourseLearningCaseRelaInfo.MajorName];
objDR[convCourseLearningCaseRelaInfo.id_XzCollege] = objInFor[convCourseLearningCaseRelaInfo.id_XzCollege];
objDR[convCourseLearningCaseRelaInfo.CollegeID] = objInFor[convCourseLearningCaseRelaInfo.CollegeID];
objDR[convCourseLearningCaseRelaInfo.CollegeName] = objInFor[convCourseLearningCaseRelaInfo.CollegeName];
objDR[convCourseLearningCaseRelaInfo.CourseId] = objInFor[convCourseLearningCaseRelaInfo.CourseId];
objDR[convCourseLearningCaseRelaInfo.CourseCode] = objInFor[convCourseLearningCaseRelaInfo.CourseCode];
objDR[convCourseLearningCaseRelaInfo.CourseName] = objInFor[convCourseLearningCaseRelaInfo.CourseName];
objDR[convCourseLearningCaseRelaInfo.BrowseCount] = objInFor[convCourseLearningCaseRelaInfo.BrowseCount];
objDR[convCourseLearningCaseRelaInfo.ResourceOwner] = objInFor[convCourseLearningCaseRelaInfo.ResourceOwner];
objDR[convCourseLearningCaseRelaInfo.ftpFileType] = objInFor[convCourseLearningCaseRelaInfo.ftpFileType];
objDR[convCourseLearningCaseRelaInfo.ftpFileSize] = objInFor[convCourseLearningCaseRelaInfo.ftpFileSize];
objDR[convCourseLearningCaseRelaInfo.ftpResourceOwner] = objInFor[convCourseLearningCaseRelaInfo.ftpResourceOwner];
objDR[convCourseLearningCaseRelaInfo.FileOriginName] = objInFor[convCourseLearningCaseRelaInfo.FileOriginName];
objDR[convCourseLearningCaseRelaInfo.IsExistFile] = objInFor[convCourseLearningCaseRelaInfo.IsExistFile];
objDR[convCourseLearningCaseRelaInfo.Flag] = objInFor[convCourseLearningCaseRelaInfo.Flag];
objDR[convCourseLearningCaseRelaInfo.FileNewName] = objInFor[convCourseLearningCaseRelaInfo.FileNewName];
objDR[convCourseLearningCaseRelaInfo.FileOldName] = objInFor[convCourseLearningCaseRelaInfo.FileOldName];
objDR[convCourseLearningCaseRelaInfo.IsVisible] = objInFor[convCourseLearningCaseRelaInfo.IsVisible];
objDR[convCourseLearningCaseRelaInfo.UpdDate] = objInFor[convCourseLearningCaseRelaInfo.UpdDate];
objDR[convCourseLearningCaseRelaInfo.UpdUser] = objInFor[convCourseLearningCaseRelaInfo.UpdUser];
objDR[convCourseLearningCaseRelaInfo.Memo] = objInFor[convCourseLearningCaseRelaInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}