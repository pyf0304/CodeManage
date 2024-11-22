
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFtpResourceBL
 表名:vFtpResource(01120500)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvFtpResourceBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdFtpResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFtpResourceEN GetObj(this K_IdFtpResource_vFtpResource myKey)
{
clsvFtpResourceEN objvFtpResourceEN = clsvFtpResourceBL.vFtpResourceDA.GetObjByIdFtpResource(myKey.Value);
return objvFtpResourceEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetIdFtpResource(this clsvFtpResourceEN objvFtpResourceEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convFtpResource.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convFtpResource.IdFtpResource);
}
objvFtpResourceEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.IdFtpResource) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.IdFtpResource, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.IdFtpResource] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFtpResourceID(this clsvFtpResourceEN objvFtpResourceEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convFtpResource.FtpResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convFtpResource.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convFtpResource.FtpResourceID);
}
objvFtpResourceEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FtpResourceID) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FtpResourceID, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FtpResourceID] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFileOriginalName(this clsvFtpResourceEN objvFtpResourceEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convFtpResource.FileOriginalName);
}
objvFtpResourceEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileOriginalName) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileOriginalName, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileOriginalName] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFileDirName(this clsvFtpResourceEN objvFtpResourceEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convFtpResource.FileDirName);
}
objvFtpResourceEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileDirName) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileDirName, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileDirName] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFileRename(this clsvFtpResourceEN objvFtpResourceEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convFtpResource.FileRename);
}
objvFtpResourceEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileRename) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileRename, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileRename] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFileNameBak(this clsvFtpResourceEN objvFtpResourceEN, string strFileNameBak, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNameBak, 500, convFtpResource.FileNameBak);
}
objvFtpResourceEN.FileNameBak = strFileNameBak; //FileName_Bak
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileNameBak) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileNameBak, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileNameBak] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFileUpDate(this clsvFtpResourceEN objvFtpResourceEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convFtpResource.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convFtpResource.FileUpDate);
}
objvFtpResourceEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileUpDate) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileUpDate, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileUpDate] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFileUpTime(this clsvFtpResourceEN objvFtpResourceEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convFtpResource.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convFtpResource.FileUpTime);
}
objvFtpResourceEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileUpTime) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileUpTime, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileUpTime] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFileSize(this clsvFtpResourceEN objvFtpResourceEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convFtpResource.FileSize);
}
objvFtpResourceEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileSize) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileSize, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileSize] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFileType(this clsvFtpResourceEN objvFtpResourceEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convFtpResource.FileType);
}
objvFtpResourceEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileType) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileType, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileType] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFuncModuleId(this clsvFtpResourceEN objvFtpResourceEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convFtpResource.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convFtpResource.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convFtpResource.FuncModuleId);
}
objvFtpResourceEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FuncModuleId) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FuncModuleId, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FuncModuleId] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFuncModuleName(this clsvFtpResourceEN objvFtpResourceEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convFtpResource.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convFtpResource.FuncModuleName);
}
objvFtpResourceEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FuncModuleName) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FuncModuleName, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FuncModuleName] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFuncModuleNameSim(this clsvFtpResourceEN objvFtpResourceEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convFtpResource.FuncModuleNameSim);
}
objvFtpResourceEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FuncModuleNameSim) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FuncModuleNameSim, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FuncModuleNameSim] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetOrderNum(this clsvFtpResourceEN objvFtpResourceEN, int? intOrderNum, string strComparisonOp="")
	{
objvFtpResourceEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.OrderNum) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.OrderNum, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.OrderNum] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetCheckDateTime(this clsvFtpResourceEN objvFtpResourceEN, string strCheckDateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDateTime, 30, convFtpResource.CheckDateTime);
}
objvFtpResourceEN.CheckDateTime = strCheckDateTime; //CheckDateTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.CheckDateTime) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.CheckDateTime, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.CheckDateTime] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetResourceOwner(this clsvFtpResourceEN objvFtpResourceEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convFtpResource.ResourceOwner);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convFtpResource.ResourceOwner);
}
objvFtpResourceEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.ResourceOwner) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.ResourceOwner, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.ResourceOwner] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetIsExistFile(this clsvFtpResourceEN objvFtpResourceEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvFtpResourceEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.IsExistFile) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.IsExistFile, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.IsExistFile] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetFileResourceID(this clsvFtpResourceEN objvFtpResourceEN, long lngFileResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngFileResourceID, convFtpResource.FileResourceID);
objvFtpResourceEN.FileResourceID = lngFileResourceID; //FileResourceID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.FileResourceID) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.FileResourceID, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.FileResourceID] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetUpdDate(this clsvFtpResourceEN objvFtpResourceEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFtpResource.UpdDate);
}
objvFtpResourceEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.UpdDate) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.UpdDate, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.UpdDate] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetUpdUser(this clsvFtpResourceEN objvFtpResourceEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFtpResource.UpdUser);
}
objvFtpResourceEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.UpdUser) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.UpdUser, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.UpdUser] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceEN SetMemo(this clsvFtpResourceEN objvFtpResourceEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFtpResource.Memo);
}
objvFtpResourceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceEN.dicFldComparisonOp.ContainsKey(convFtpResource.Memo) == false)
{
objvFtpResourceEN.dicFldComparisonOp.Add(convFtpResource.Memo, strComparisonOp);
}
else
{
objvFtpResourceEN.dicFldComparisonOp[convFtpResource.Memo] = strComparisonOp;
}
}
return objvFtpResourceEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFtpResourceENS">源对象</param>
 /// <param name = "objvFtpResourceENT">目标对象</param>
 public static void CopyTo(this clsvFtpResourceEN objvFtpResourceENS, clsvFtpResourceEN objvFtpResourceENT)
{
try
{
objvFtpResourceENT.IdFtpResource = objvFtpResourceENS.IdFtpResource; //FTP资源流水号
objvFtpResourceENT.FtpResourceID = objvFtpResourceENS.FtpResourceID; //FTP资源ID
objvFtpResourceENT.FileOriginalName = objvFtpResourceENS.FileOriginalName; //文件原名
objvFtpResourceENT.FileDirName = objvFtpResourceENS.FileDirName; //文件目录名
objvFtpResourceENT.FileRename = objvFtpResourceENS.FileRename; //文件新名
objvFtpResourceENT.FileNameBak = objvFtpResourceENS.FileNameBak; //FileName_Bak
objvFtpResourceENT.FileUpDate = objvFtpResourceENS.FileUpDate; //创建日期
objvFtpResourceENT.FileUpTime = objvFtpResourceENS.FileUpTime; //创建时间
objvFtpResourceENT.FileSize = objvFtpResourceENS.FileSize; //文件大小
objvFtpResourceENT.FileType = objvFtpResourceENS.FileType; //文件类型
objvFtpResourceENT.FuncModuleId = objvFtpResourceENS.FuncModuleId; //功能模块Id
objvFtpResourceENT.FuncModuleName = objvFtpResourceENS.FuncModuleName; //功能模块名称
objvFtpResourceENT.FuncModuleNameSim = objvFtpResourceENS.FuncModuleNameSim; //功能模块简称
objvFtpResourceENT.OrderNum = objvFtpResourceENS.OrderNum; //序号
objvFtpResourceENT.CheckDateTime = objvFtpResourceENS.CheckDateTime; //CheckDateTime
objvFtpResourceENT.ResourceOwner = objvFtpResourceENS.ResourceOwner; //上传者
objvFtpResourceENT.IsExistFile = objvFtpResourceENS.IsExistFile; //是否存在文件
objvFtpResourceENT.FileResourceID = objvFtpResourceENS.FileResourceID; //FileResourceID
objvFtpResourceENT.UpdDate = objvFtpResourceENS.UpdDate; //修改日期
objvFtpResourceENT.UpdUser = objvFtpResourceENS.UpdUser; //修改人
objvFtpResourceENT.Memo = objvFtpResourceENS.Memo; //备注
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvFtpResourceENS">源对象</param>
 /// <returns>目标对象=>clsvFtpResourceEN:objvFtpResourceENT</returns>
 public static clsvFtpResourceEN CopyTo(this clsvFtpResourceEN objvFtpResourceENS)
{
try
{
 clsvFtpResourceEN objvFtpResourceENT = new clsvFtpResourceEN()
{
IdFtpResource = objvFtpResourceENS.IdFtpResource, //FTP资源流水号
FtpResourceID = objvFtpResourceENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvFtpResourceENS.FileOriginalName, //文件原名
FileDirName = objvFtpResourceENS.FileDirName, //文件目录名
FileRename = objvFtpResourceENS.FileRename, //文件新名
FileNameBak = objvFtpResourceENS.FileNameBak, //FileName_Bak
FileUpDate = objvFtpResourceENS.FileUpDate, //创建日期
FileUpTime = objvFtpResourceENS.FileUpTime, //创建时间
FileSize = objvFtpResourceENS.FileSize, //文件大小
FileType = objvFtpResourceENS.FileType, //文件类型
FuncModuleId = objvFtpResourceENS.FuncModuleId, //功能模块Id
FuncModuleName = objvFtpResourceENS.FuncModuleName, //功能模块名称
FuncModuleNameSim = objvFtpResourceENS.FuncModuleNameSim, //功能模块简称
OrderNum = objvFtpResourceENS.OrderNum, //序号
CheckDateTime = objvFtpResourceENS.CheckDateTime, //CheckDateTime
ResourceOwner = objvFtpResourceENS.ResourceOwner, //上传者
IsExistFile = objvFtpResourceENS.IsExistFile, //是否存在文件
FileResourceID = objvFtpResourceENS.FileResourceID, //FileResourceID
UpdDate = objvFtpResourceENS.UpdDate, //修改日期
UpdUser = objvFtpResourceENS.UpdUser, //修改人
Memo = objvFtpResourceENS.Memo, //备注
};
 return objvFtpResourceENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvFtpResourceEN objvFtpResourceEN)
{
 clsvFtpResourceBL.vFtpResourceDA.CheckProperty4Condition(objvFtpResourceEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFtpResourceEN objvFtpResourceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFtpResourceCond.IsUpdated(convFtpResource.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.IdFtpResource, objvFtpResourceCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FtpResourceID, objvFtpResourceCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileOriginalName, objvFtpResourceCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FileDirName) == true)
{
string strComparisonOpFileDirName = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileDirName, objvFtpResourceCond.FileDirName, strComparisonOpFileDirName);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FileRename) == true)
{
string strComparisonOpFileRename = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileRename, objvFtpResourceCond.FileRename, strComparisonOpFileRename);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FileNameBak) == true)
{
string strComparisonOpFileNameBak = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FileNameBak];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileNameBak, objvFtpResourceCond.FileNameBak, strComparisonOpFileNameBak);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileUpDate, objvFtpResourceCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileUpTime, objvFtpResourceCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FileSize) == true)
{
string strComparisonOpFileSize = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileSize, objvFtpResourceCond.FileSize, strComparisonOpFileSize);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FileType) == true)
{
string strComparisonOpFileType = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FileType, objvFtpResourceCond.FileType, strComparisonOpFileType);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FuncModuleId, objvFtpResourceCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FuncModuleName, objvFtpResourceCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.FuncModuleNameSim, objvFtpResourceCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResource.OrderNum, objvFtpResourceCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.CheckDateTime) == true)
{
string strComparisonOpCheckDateTime = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.CheckDateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.CheckDateTime, objvFtpResourceCond.CheckDateTime, strComparisonOpCheckDateTime);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.ResourceOwner, objvFtpResourceCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.IsExistFile) == true)
{
if (objvFtpResourceCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFtpResource.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFtpResource.IsExistFile);
}
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.FileResourceID) == true)
{
string strComparisonOpFileResourceID = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.FileResourceID];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResource.FileResourceID, objvFtpResourceCond.FileResourceID, strComparisonOpFileResourceID);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.UpdDate, objvFtpResourceCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.UpdUser, objvFtpResourceCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFtpResourceCond.IsUpdated(convFtpResource.Memo) == true)
{
string strComparisonOpMemo = objvFtpResourceCond.dicFldComparisonOp[convFtpResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResource.Memo, objvFtpResourceCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFtpResource
{
public virtual bool UpdRelaTabDate(string strIdFtpResource, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vFTP资源(vFtpResource)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFtpResourceBL
{
public static RelatedActions_vFtpResource relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFtpResourceDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFtpResourceDA vFtpResourceDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFtpResourceDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFtpResourceBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvFtpResourceEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFtpResourceEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vFtpResource(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFtpResourceDA.GetDataTable_vFtpResource(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFtpResourceDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vFtpResourceDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vFtpResourceDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vFtpResourceDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vFtpResourceDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vFtpResourceDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vFtpResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vFtpResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrIdFtpResourceLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLstByIdFtpResourceLst(List<string> arrIdFtpResourceLst)
{
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdFtpResourceLst, true);
 string strWhereCond = string.Format("IdFtpResource in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = Int32.Parse(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdFtpResourceLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFtpResourceEN> GetObjLstByIdFtpResourceLstCache(List<string> arrIdFtpResourceLst)
{
string strKey = string.Format("{0}", clsvFtpResourceEN._CurrTabName);
List<clsvFtpResourceEN> arrvFtpResourceObjLstCache = GetObjLstCache();
IEnumerable <clsvFtpResourceEN> arrvFtpResourceObjLst_Sel =
arrvFtpResourceObjLstCache
.Where(x => arrIdFtpResourceLst.Contains(x.IdFtpResource));
return arrvFtpResourceObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLst(string strWhereCond)
{
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = Int32.Parse(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = Int32.Parse(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFtpResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFtpResourceEN> GetSubObjLstCache(clsvFtpResourceEN objvFtpResourceCond)
{
List<clsvFtpResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFtpResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFtpResource.AttributeName)
{
if (objvFtpResourceCond.IsUpdated(strFldName) == false) continue;
if (objvFtpResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFtpResourceCond[strFldName].ToString());
}
else
{
if (objvFtpResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFtpResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFtpResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFtpResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFtpResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFtpResourceCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = Int32.Parse(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = Int32.Parse(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvFtpResourceEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFtpResourceEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = Int32.Parse(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = Int32.Parse(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = Int32.Parse(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = Int32.Parse(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = Int32.Parse(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceEN.IdFtpResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFtpResourceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFtpResource(ref clsvFtpResourceEN objvFtpResourceEN)
{
bool bolResult = vFtpResourceDA.GetvFtpResource(ref objvFtpResourceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdFtpResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFtpResourceEN GetObjByIdFtpResource(string strIdFtpResource)
{
if (strIdFtpResource.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdFtpResource]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdFtpResource) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdFtpResource]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFtpResourceEN objvFtpResourceEN = vFtpResourceDA.GetObjByIdFtpResource(strIdFtpResource);
return objvFtpResourceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFtpResourceEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFtpResourceEN objvFtpResourceEN = vFtpResourceDA.GetFirstObj(strWhereCond);
 return objvFtpResourceEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvFtpResourceEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFtpResourceEN objvFtpResourceEN = vFtpResourceDA.GetObjByDataRow(objRow);
 return objvFtpResourceEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvFtpResourceEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFtpResourceEN objvFtpResourceEN = vFtpResourceDA.GetObjByDataRow(objRow);
 return objvFtpResourceEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strIdFtpResource">所给的关键字</param>
 /// <param name = "lstvFtpResourceObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFtpResourceEN GetObjByIdFtpResourceFromList(string strIdFtpResource, List<clsvFtpResourceEN> lstvFtpResourceObjLst)
{
foreach (clsvFtpResourceEN objvFtpResourceEN in lstvFtpResourceObjLst)
{
if (objvFtpResourceEN.IdFtpResource == strIdFtpResource)
{
return objvFtpResourceEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdFtpResource;
 try
 {
 strIdFtpResource = new clsvFtpResourceDA().GetFirstID(strWhereCond);
 return strIdFtpResource;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vFtpResourceDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vFtpResourceDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdFtpResource">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdFtpResource)
{
if (string.IsNullOrEmpty(strIdFtpResource) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdFtpResource]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFtpResourceDA.IsExist(strIdFtpResource);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvFtpResourceDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vFtpResourceDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvFtpResourceENS">源对象</param>
 /// <param name = "objvFtpResourceENT">目标对象</param>
 public static void CopyTo(clsvFtpResourceEN objvFtpResourceENS, clsvFtpResourceEN objvFtpResourceENT)
{
try
{
objvFtpResourceENT.IdFtpResource = objvFtpResourceENS.IdFtpResource; //FTP资源流水号
objvFtpResourceENT.FtpResourceID = objvFtpResourceENS.FtpResourceID; //FTP资源ID
objvFtpResourceENT.FileOriginalName = objvFtpResourceENS.FileOriginalName; //文件原名
objvFtpResourceENT.FileDirName = objvFtpResourceENS.FileDirName; //文件目录名
objvFtpResourceENT.FileRename = objvFtpResourceENS.FileRename; //文件新名
objvFtpResourceENT.FileNameBak = objvFtpResourceENS.FileNameBak; //FileName_Bak
objvFtpResourceENT.FileUpDate = objvFtpResourceENS.FileUpDate; //创建日期
objvFtpResourceENT.FileUpTime = objvFtpResourceENS.FileUpTime; //创建时间
objvFtpResourceENT.FileSize = objvFtpResourceENS.FileSize; //文件大小
objvFtpResourceENT.FileType = objvFtpResourceENS.FileType; //文件类型
objvFtpResourceENT.FuncModuleId = objvFtpResourceENS.FuncModuleId; //功能模块Id
objvFtpResourceENT.FuncModuleName = objvFtpResourceENS.FuncModuleName; //功能模块名称
objvFtpResourceENT.FuncModuleNameSim = objvFtpResourceENS.FuncModuleNameSim; //功能模块简称
objvFtpResourceENT.OrderNum = objvFtpResourceENS.OrderNum; //序号
objvFtpResourceENT.CheckDateTime = objvFtpResourceENS.CheckDateTime; //CheckDateTime
objvFtpResourceENT.ResourceOwner = objvFtpResourceENS.ResourceOwner; //上传者
objvFtpResourceENT.IsExistFile = objvFtpResourceENS.IsExistFile; //是否存在文件
objvFtpResourceENT.FileResourceID = objvFtpResourceENS.FileResourceID; //FileResourceID
objvFtpResourceENT.UpdDate = objvFtpResourceENS.UpdDate; //修改日期
objvFtpResourceENT.UpdUser = objvFtpResourceENS.UpdUser; //修改人
objvFtpResourceENT.Memo = objvFtpResourceENS.Memo; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvFtpResourceEN">源简化对象</param>
 public static void SetUpdFlag(clsvFtpResourceEN objvFtpResourceEN)
{
try
{
objvFtpResourceEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFtpResourceEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFtpResource.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.IdFtpResource = objvFtpResourceEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convFtpResource.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FtpResourceID = objvFtpResourceEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convFtpResource.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FileOriginalName = objvFtpResourceEN.FileOriginalName == "[null]" ? null :  objvFtpResourceEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convFtpResource.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FileDirName = objvFtpResourceEN.FileDirName == "[null]" ? null :  objvFtpResourceEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convFtpResource.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FileRename = objvFtpResourceEN.FileRename == "[null]" ? null :  objvFtpResourceEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convFtpResource.FileNameBak, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FileNameBak = objvFtpResourceEN.FileNameBak == "[null]" ? null :  objvFtpResourceEN.FileNameBak; //FileName_Bak
}
if (arrFldSet.Contains(convFtpResource.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FileUpDate = objvFtpResourceEN.FileUpDate == "[null]" ? null :  objvFtpResourceEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convFtpResource.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FileUpTime = objvFtpResourceEN.FileUpTime == "[null]" ? null :  objvFtpResourceEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convFtpResource.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FileSize = objvFtpResourceEN.FileSize == "[null]" ? null :  objvFtpResourceEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convFtpResource.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FileType = objvFtpResourceEN.FileType == "[null]" ? null :  objvFtpResourceEN.FileType; //文件类型
}
if (arrFldSet.Contains(convFtpResource.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FuncModuleId = objvFtpResourceEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convFtpResource.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FuncModuleName = objvFtpResourceEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convFtpResource.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FuncModuleNameSim = objvFtpResourceEN.FuncModuleNameSim == "[null]" ? null :  objvFtpResourceEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convFtpResource.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.OrderNum = objvFtpResourceEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFtpResource.CheckDateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.CheckDateTime = objvFtpResourceEN.CheckDateTime == "[null]" ? null :  objvFtpResourceEN.CheckDateTime; //CheckDateTime
}
if (arrFldSet.Contains(convFtpResource.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.ResourceOwner = objvFtpResourceEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convFtpResource.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.IsExistFile = objvFtpResourceEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convFtpResource.FileResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.FileResourceID = objvFtpResourceEN.FileResourceID; //FileResourceID
}
if (arrFldSet.Contains(convFtpResource.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.UpdDate = objvFtpResourceEN.UpdDate == "[null]" ? null :  objvFtpResourceEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFtpResource.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.UpdUser = objvFtpResourceEN.UpdUser == "[null]" ? null :  objvFtpResourceEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convFtpResource.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceEN.Memo = objvFtpResourceEN.Memo == "[null]" ? null :  objvFtpResourceEN.Memo; //备注
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvFtpResourceEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFtpResourceEN objvFtpResourceEN)
{
try
{
if (objvFtpResourceEN.FileOriginalName == "[null]") objvFtpResourceEN.FileOriginalName = null; //文件原名
if (objvFtpResourceEN.FileDirName == "[null]") objvFtpResourceEN.FileDirName = null; //文件目录名
if (objvFtpResourceEN.FileRename == "[null]") objvFtpResourceEN.FileRename = null; //文件新名
if (objvFtpResourceEN.FileNameBak == "[null]") objvFtpResourceEN.FileNameBak = null; //FileName_Bak
if (objvFtpResourceEN.FileUpDate == "[null]") objvFtpResourceEN.FileUpDate = null; //创建日期
if (objvFtpResourceEN.FileUpTime == "[null]") objvFtpResourceEN.FileUpTime = null; //创建时间
if (objvFtpResourceEN.FileSize == "[null]") objvFtpResourceEN.FileSize = null; //文件大小
if (objvFtpResourceEN.FileType == "[null]") objvFtpResourceEN.FileType = null; //文件类型
if (objvFtpResourceEN.FuncModuleNameSim == "[null]") objvFtpResourceEN.FuncModuleNameSim = null; //功能模块简称
if (objvFtpResourceEN.CheckDateTime == "[null]") objvFtpResourceEN.CheckDateTime = null; //CheckDateTime
if (objvFtpResourceEN.UpdDate == "[null]") objvFtpResourceEN.UpdDate = null; //修改日期
if (objvFtpResourceEN.UpdUser == "[null]") objvFtpResourceEN.UpdUser = null; //修改人
if (objvFtpResourceEN.Memo == "[null]") objvFtpResourceEN.Memo = null; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvFtpResourceEN objvFtpResourceEN)
{
 vFtpResourceDA.CheckProperty4Condition(objvFtpResourceEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceBL没有刷新缓存机制(clsFtpResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdFtpResource");
//if (arrvFtpResourceObjLstCache == null)
//{
//arrvFtpResourceObjLstCache = vFtpResourceDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdFtpResource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFtpResourceEN GetObjByIdFtpResourceCache(string strIdFtpResource)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFtpResourceEN._CurrTabName);
List<clsvFtpResourceEN> arrvFtpResourceObjLstCache = GetObjLstCache();
IEnumerable <clsvFtpResourceEN> arrvFtpResourceObjLst_Sel =
arrvFtpResourceObjLstCache
.Where(x=> x.IdFtpResource == strIdFtpResource 
);
if (arrvFtpResourceObjLst_Sel.Count() == 0)
{
   clsvFtpResourceEN obj = clsvFtpResourceBL.GetObjByIdFtpResource(strIdFtpResource);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFtpResourceObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFtpResourceEN> GetAllvFtpResourceObjLstCache()
{
//获取缓存中的对象列表
List<clsvFtpResourceEN> arrvFtpResourceObjLstCache = GetObjLstCache(); 
return arrvFtpResourceObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFtpResourceEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFtpResourceEN._CurrTabName);
List<clsvFtpResourceEN> arrvFtpResourceObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFtpResourceObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvFtpResourceEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdFtpResource)
{
if (strInFldName != convFtpResource.IdFtpResource)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFtpResource.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFtpResource.AttributeName));
throw new Exception(strMsg);
}
var objvFtpResource = clsvFtpResourceBL.GetObjByIdFtpResourceCache(strIdFtpResource);
if (objvFtpResource == null) return "";
return objvFtpResource[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvFtpResourceDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvFtpResourceDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFtpResourceDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvFtpResourceDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFtpResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFtpResourceEN objvFtpResourceCond)
{
List<clsvFtpResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFtpResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFtpResource.AttributeName)
{
if (objvFtpResourceCond.IsUpdated(strFldName) == false) continue;
if (objvFtpResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFtpResourceCond[strFldName].ToString());
}
else
{
if (objvFtpResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFtpResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFtpResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFtpResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFtpResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFtpResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFtpResourceCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvFtpResourceDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vFtpResourceDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vFtpResourceDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}