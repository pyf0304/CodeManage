
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachCaseRelaInfoBL
 表名:vTeachCaseRelaInfo(01120399)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:55
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
public static class  clsvTeachCaseRelaInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCaseRelaInfoEN GetObj(this K_IdTeachCaseRelaInfo_vTeachCaseRelaInfo myKey)
{
clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = clsvTeachCaseRelaInfoBL.vTeachCaseRelaInfoDA.GetObjByIdTeachCaseRelaInfo(myKey.Value);
return objvTeachCaseRelaInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetIdTeachCaseRelaInfo(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, long lngIdTeachCaseRelaInfo, string strComparisonOp="")
	{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = lngIdTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.IdTeachCaseRelaInfo) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.IdTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.IdTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetIdTeachCase(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strIdTeachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachCase, convTeachCaseRelaInfo.IdTeachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachCase, 8, convTeachCaseRelaInfo.IdTeachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachCase, 8, convTeachCaseRelaInfo.IdTeachCase);
}
objvTeachCaseRelaInfoEN.IdTeachCase = strIdTeachCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.IdTeachCase) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.IdTeachCase, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.IdTeachCase] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetTeachCaseName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strTeachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseName, convTeachCaseRelaInfo.TeachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseName, 200, convTeachCaseRelaInfo.TeachCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetIdResource(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convTeachCaseRelaInfo.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convTeachCaseRelaInfo.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convTeachCaseRelaInfo.IdResource);
}
objvTeachCaseRelaInfoEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.IdResource) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.IdResource, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.IdResource] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetResourceID(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convTeachCaseRelaInfo.ResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convTeachCaseRelaInfo.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convTeachCaseRelaInfo.ResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetIdFtpResource(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convTeachCaseRelaInfo.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convTeachCaseRelaInfo.IdFtpResource);
}
objvTeachCaseRelaInfoEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.IdFtpResource) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.IdFtpResource, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.IdFtpResource] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFtpResourceID(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convTeachCaseRelaInfo.FtpResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convTeachCaseRelaInfo.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convTeachCaseRelaInfo.FtpResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileOriginalName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convTeachCaseRelaInfo.FileOriginalName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileDirName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convTeachCaseRelaInfo.FileDirName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileRename(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convTeachCaseRelaInfo.FileRename);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileUpDate(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convTeachCaseRelaInfo.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convTeachCaseRelaInfo.FileUpDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileUpTime(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convTeachCaseRelaInfo.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convTeachCaseRelaInfo.FileUpTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileSize(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convTeachCaseRelaInfo.FileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileType(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convTeachCaseRelaInfo.FileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetResourceOwner(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convTeachCaseRelaInfo.ResourceOwner);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convTeachCaseRelaInfo.ResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetIdFile(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convTeachCaseRelaInfo.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convTeachCaseRelaInfo.IdFile);
}
objvTeachCaseRelaInfoEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.IdFile) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.IdFile, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.IdFile] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convTeachCaseRelaInfo.FileName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetSaveDate(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convTeachCaseRelaInfo.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convTeachCaseRelaInfo.SaveDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetSaveTime(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convTeachCaseRelaInfo.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convTeachCaseRelaInfo.SaveTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileOriginName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convTeachCaseRelaInfo.FileOriginName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetIdResourceType(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, convTeachCaseRelaInfo.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convTeachCaseRelaInfo.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convTeachCaseRelaInfo.IdResourceType);
}
objvTeachCaseRelaInfoEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.IdResourceType) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.IdResourceType, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.IdResourceType] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetResourceTypeID(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convTeachCaseRelaInfo.ResourceTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convTeachCaseRelaInfo.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convTeachCaseRelaInfo.ResourceTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetResourceTypeName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convTeachCaseRelaInfo.ResourceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convTeachCaseRelaInfo.ResourceTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileNewName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convTeachCaseRelaInfo.FileNewName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetFileOldName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convTeachCaseRelaInfo.FileOldName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetftpFileType(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachCaseRelaInfo.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetftpFileSize(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convTeachCaseRelaInfo.ftpFileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetftpResourceOwner(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convTeachCaseRelaInfo.ftpResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetIdTeachCaseRelaInfoType(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strIdTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachCaseRelaInfoType, convTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachCaseRelaInfoType, 4, convTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachCaseRelaInfoType, 4, convTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
}
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = strIdTeachCaseRelaInfoType; //案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachCaseRelaInfo.IdTeachCaseRelaInfoType) == false)
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachCaseRelaInfo.IdTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvTeachCaseRelaInfoEN.dicFldComparisonOp[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetTeachCaseRelaInfoTypeID(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseRelaInfoTypeID, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseRelaInfoTypeID, 4, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachCaseRelaInfoTypeID, 4, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetTeachCaseRelaInfoTypeName(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseRelaInfoTypeName, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseRelaInfoTypeName, 50, convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetBrowseCount(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, int? intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseRelaInfoEN SetMemo(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachCaseRelaInfo.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoENS, clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoENT)
{
try
{
objvTeachCaseRelaInfoENT.IdTeachCaseRelaInfo = objvTeachCaseRelaInfoENS.IdTeachCaseRelaInfo; //案例相关信息流水号
objvTeachCaseRelaInfoENT.IdTeachCase = objvTeachCaseRelaInfoENS.IdTeachCase; //案例流水号
objvTeachCaseRelaInfoENT.TeachCaseName = objvTeachCaseRelaInfoENS.TeachCaseName; //案例名称
objvTeachCaseRelaInfoENT.IdResource = objvTeachCaseRelaInfoENS.IdResource; //资源流水号
objvTeachCaseRelaInfoENT.ResourceID = objvTeachCaseRelaInfoENS.ResourceID; //资源ID
objvTeachCaseRelaInfoENT.SaveMode = objvTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvTeachCaseRelaInfoENT.IdFtpResource = objvTeachCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvTeachCaseRelaInfoENT.FtpResourceID = objvTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvTeachCaseRelaInfoENT.FileOriginalName = objvTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvTeachCaseRelaInfoENT.FileDirName = objvTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvTeachCaseRelaInfoENT.FileRename = objvTeachCaseRelaInfoENS.FileRename; //文件新名
objvTeachCaseRelaInfoENT.FileUpDate = objvTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvTeachCaseRelaInfoENT.FileUpTime = objvTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvTeachCaseRelaInfoENT.FileSize = objvTeachCaseRelaInfoENS.FileSize; //文件大小
objvTeachCaseRelaInfoENT.FileType = objvTeachCaseRelaInfoENS.FileType; //文件类型
objvTeachCaseRelaInfoENT.ResourceOwner = objvTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvTeachCaseRelaInfoENT.IdFile = objvTeachCaseRelaInfoENS.IdFile; //文件流水号
objvTeachCaseRelaInfoENT.FileName = objvTeachCaseRelaInfoENS.FileName; //文件名称
objvTeachCaseRelaInfoENT.SaveDate = objvTeachCaseRelaInfoENS.SaveDate; //创建日期
objvTeachCaseRelaInfoENT.SaveTime = objvTeachCaseRelaInfoENS.SaveTime; //创建时间
objvTeachCaseRelaInfoENT.FileOriginName = objvTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvTeachCaseRelaInfoENT.IdResourceType = objvTeachCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvTeachCaseRelaInfoENT.ResourceTypeID = objvTeachCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvTeachCaseRelaInfoENT.ResourceTypeName = objvTeachCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvTeachCaseRelaInfoENT.FileNewName = objvTeachCaseRelaInfoENS.FileNewName; //新文件名
objvTeachCaseRelaInfoENT.FileOldName = objvTeachCaseRelaInfoENS.FileOldName; //旧文件名
objvTeachCaseRelaInfoENT.ftpFileType = objvTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvTeachCaseRelaInfoENT.ftpFileSize = objvTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvTeachCaseRelaInfoENT.ftpResourceOwner = objvTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvTeachCaseRelaInfoENT.IdTeachCaseRelaInfoType = objvTeachCaseRelaInfoENS.IdTeachCaseRelaInfoType; //案例相关信息类型流水号
objvTeachCaseRelaInfoENT.TeachCaseRelaInfoTypeID = objvTeachCaseRelaInfoENS.TeachCaseRelaInfoTypeID; //案例相关信息类型ID
objvTeachCaseRelaInfoENT.TeachCaseRelaInfoTypeName = objvTeachCaseRelaInfoENS.TeachCaseRelaInfoTypeName; //案例相关信息类型名称
objvTeachCaseRelaInfoENT.IsVisible = objvTeachCaseRelaInfoENS.IsVisible; //是否显示
objvTeachCaseRelaInfoENT.BrowseCount = objvTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvTeachCaseRelaInfoENT.Memo = objvTeachCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objvTeachCaseRelaInfoENS">源对象</param>
 /// <returns>目标对象=>clsvTeachCaseRelaInfoEN:objvTeachCaseRelaInfoENT</returns>
 public static clsvTeachCaseRelaInfoEN CopyTo(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoENS)
{
try
{
 clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoENT = new clsvTeachCaseRelaInfoEN()
{
IdTeachCaseRelaInfo = objvTeachCaseRelaInfoENS.IdTeachCaseRelaInfo, //案例相关信息流水号
IdTeachCase = objvTeachCaseRelaInfoENS.IdTeachCase, //案例流水号
TeachCaseName = objvTeachCaseRelaInfoENS.TeachCaseName, //案例名称
IdResource = objvTeachCaseRelaInfoENS.IdResource, //资源流水号
ResourceID = objvTeachCaseRelaInfoENS.ResourceID, //资源ID
SaveMode = objvTeachCaseRelaInfoENS.SaveMode, //文件存放方式
IdFtpResource = objvTeachCaseRelaInfoENS.IdFtpResource, //FTP资源流水号
FtpResourceID = objvTeachCaseRelaInfoENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvTeachCaseRelaInfoENS.FileOriginalName, //文件原名
FileDirName = objvTeachCaseRelaInfoENS.FileDirName, //文件目录名
FileRename = objvTeachCaseRelaInfoENS.FileRename, //文件新名
FileUpDate = objvTeachCaseRelaInfoENS.FileUpDate, //创建日期
FileUpTime = objvTeachCaseRelaInfoENS.FileUpTime, //创建时间
FileSize = objvTeachCaseRelaInfoENS.FileSize, //文件大小
FileType = objvTeachCaseRelaInfoENS.FileType, //文件类型
ResourceOwner = objvTeachCaseRelaInfoENS.ResourceOwner, //上传者
IdFile = objvTeachCaseRelaInfoENS.IdFile, //文件流水号
FileName = objvTeachCaseRelaInfoENS.FileName, //文件名称
SaveDate = objvTeachCaseRelaInfoENS.SaveDate, //创建日期
SaveTime = objvTeachCaseRelaInfoENS.SaveTime, //创建时间
FileOriginName = objvTeachCaseRelaInfoENS.FileOriginName, //原文件名
IdResourceType = objvTeachCaseRelaInfoENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvTeachCaseRelaInfoENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvTeachCaseRelaInfoENS.ResourceTypeName, //资源类型名称
FileNewName = objvTeachCaseRelaInfoENS.FileNewName, //新文件名
FileOldName = objvTeachCaseRelaInfoENS.FileOldName, //旧文件名
ftpFileType = objvTeachCaseRelaInfoENS.ftpFileType, //ftp文件类型
ftpFileSize = objvTeachCaseRelaInfoENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvTeachCaseRelaInfoENS.ftpResourceOwner, //Ftp资源拥有者
IdTeachCaseRelaInfoType = objvTeachCaseRelaInfoENS.IdTeachCaseRelaInfoType, //案例相关信息类型流水号
TeachCaseRelaInfoTypeID = objvTeachCaseRelaInfoENS.TeachCaseRelaInfoTypeID, //案例相关信息类型ID
TeachCaseRelaInfoTypeName = objvTeachCaseRelaInfoENS.TeachCaseRelaInfoTypeName, //案例相关信息类型名称
IsVisible = objvTeachCaseRelaInfoENS.IsVisible, //是否显示
BrowseCount = objvTeachCaseRelaInfoENS.BrowseCount, //浏览次数
Memo = objvTeachCaseRelaInfoENS.Memo, //备注
};
 return objvTeachCaseRelaInfoENT;
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
public static void CheckProperty4Condition(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN)
{
 clsvTeachCaseRelaInfoBL.vTeachCaseRelaInfoDA.CheckProperty4Condition(objvTeachCaseRelaInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.IdTeachCaseRelaInfo) == true)
{
string strComparisonOpIdTeachCaseRelaInfo = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.IdTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCaseRelaInfo.IdTeachCaseRelaInfo, objvTeachCaseRelaInfoCond.IdTeachCaseRelaInfo, strComparisonOpIdTeachCaseRelaInfo);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.IdTeachCase) == true)
{
string strComparisonOpIdTeachCase = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.IdTeachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.IdTeachCase, objvTeachCaseRelaInfoCond.IdTeachCase, strComparisonOpIdTeachCase);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.TeachCaseName) == true)
{
string strComparisonOpTeachCaseName = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.TeachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.TeachCaseName, objvTeachCaseRelaInfoCond.TeachCaseName, strComparisonOpTeachCaseName);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.IdResource) == true)
{
string strComparisonOpIdResource = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.IdResource, objvTeachCaseRelaInfoCond.IdResource, strComparisonOpIdResource);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.ResourceID) == true)
{
string strComparisonOpResourceID = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ResourceID, objvTeachCaseRelaInfoCond.ResourceID, strComparisonOpResourceID);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.SaveMode) == true)
{
if (objvTeachCaseRelaInfoCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCaseRelaInfo.SaveMode);
}
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.IdFtpResource, objvTeachCaseRelaInfoCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FtpResourceID, objvTeachCaseRelaInfoCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileOriginalName, objvTeachCaseRelaInfoCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FileDirName) == true)
{
string strComparisonOpFileDirName = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileDirName, objvTeachCaseRelaInfoCond.FileDirName, strComparisonOpFileDirName);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FileRename) == true)
{
string strComparisonOpFileRename = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileRename, objvTeachCaseRelaInfoCond.FileRename, strComparisonOpFileRename);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileUpDate, objvTeachCaseRelaInfoCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileUpTime, objvTeachCaseRelaInfoCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FileSize) == true)
{
string strComparisonOpFileSize = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileSize, objvTeachCaseRelaInfoCond.FileSize, strComparisonOpFileSize);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FileType) == true)
{
string strComparisonOpFileType = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileType, objvTeachCaseRelaInfoCond.FileType, strComparisonOpFileType);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ResourceOwner, objvTeachCaseRelaInfoCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.IdFile) == true)
{
string strComparisonOpIdFile = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.IdFile, objvTeachCaseRelaInfoCond.IdFile, strComparisonOpIdFile);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FileName) == true)
{
string strComparisonOpFileName = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileName, objvTeachCaseRelaInfoCond.FileName, strComparisonOpFileName);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.SaveDate) == true)
{
string strComparisonOpSaveDate = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.SaveDate, objvTeachCaseRelaInfoCond.SaveDate, strComparisonOpSaveDate);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.SaveTime) == true)
{
string strComparisonOpSaveTime = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.SaveTime, objvTeachCaseRelaInfoCond.SaveTime, strComparisonOpSaveTime);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileOriginName, objvTeachCaseRelaInfoCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.IdResourceType, objvTeachCaseRelaInfoCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ResourceTypeID, objvTeachCaseRelaInfoCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ResourceTypeName, objvTeachCaseRelaInfoCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FileNewName) == true)
{
string strComparisonOpFileNewName = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileNewName, objvTeachCaseRelaInfoCond.FileNewName, strComparisonOpFileNewName);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.FileOldName) == true)
{
string strComparisonOpFileOldName = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.FileOldName, objvTeachCaseRelaInfoCond.FileOldName, strComparisonOpFileOldName);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ftpFileType, objvTeachCaseRelaInfoCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ftpFileSize, objvTeachCaseRelaInfoCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.ftpResourceOwner, objvTeachCaseRelaInfoCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.IdTeachCaseRelaInfoType) == true)
{
string strComparisonOpIdTeachCaseRelaInfoType = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.IdTeachCaseRelaInfoType, objvTeachCaseRelaInfoCond.IdTeachCaseRelaInfoType, strComparisonOpIdTeachCaseRelaInfoType);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID) == true)
{
string strComparisonOpTeachCaseRelaInfoTypeID = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID, objvTeachCaseRelaInfoCond.TeachCaseRelaInfoTypeID, strComparisonOpTeachCaseRelaInfoTypeID);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName) == true)
{
string strComparisonOpTeachCaseRelaInfoTypeName = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName, objvTeachCaseRelaInfoCond.TeachCaseRelaInfoTypeName, strComparisonOpTeachCaseRelaInfoTypeName);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.IsVisible) == true)
{
if (objvTeachCaseRelaInfoCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCaseRelaInfo.IsVisible);
}
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCaseRelaInfo.BrowseCount, objvTeachCaseRelaInfoCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvTeachCaseRelaInfoCond.IsUpdated(convTeachCaseRelaInfo.Memo) == true)
{
string strComparisonOpMemo = objvTeachCaseRelaInfoCond.dicFldComparisonOp[convTeachCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCaseRelaInfo.Memo, objvTeachCaseRelaInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeachCaseRelaInfo
{
public virtual bool UpdRelaTabDate(long lngIdTeachCaseRelaInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 案例相关信息表视图(vTeachCaseRelaInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeachCaseRelaInfoBL
{
public static RelatedActions_vTeachCaseRelaInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeachCaseRelaInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeachCaseRelaInfoDA vTeachCaseRelaInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeachCaseRelaInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeachCaseRelaInfoBL()
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
if (string.IsNullOrEmpty(clsvTeachCaseRelaInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachCaseRelaInfoEN._ConnectString);
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
public static DataTable GetDataTable_vTeachCaseRelaInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachCaseRelaInfoDA.GetDataTable_vTeachCaseRelaInfo(strWhereCond);
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
objDT = vTeachCaseRelaInfoDA.GetDataTable(strWhereCond);
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
objDT = vTeachCaseRelaInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTeachCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTeachCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTeachCaseRelaInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vTeachCaseRelaInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTeachCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTeachCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTeachCaseRelaInfoEN> GetObjLstByIdTeachCaseRelaInfoLst(List<long> arrIdTeachCaseRelaInfoLst)
{
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeachCaseRelaInfoLst);
 string strWhereCond = string.Format("IdTeachCaseRelaInfo in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeachCaseRelaInfoEN> GetObjLstByIdTeachCaseRelaInfoLstCache(List<long> arrIdTeachCaseRelaInfoLst)
{
string strKey = string.Format("{0}", clsvTeachCaseRelaInfoEN._CurrTabName);
List<clsvTeachCaseRelaInfoEN> arrvTeachCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCaseRelaInfoEN> arrvTeachCaseRelaInfoObjLst_Sel =
arrvTeachCaseRelaInfoObjLstCache
.Where(x => arrIdTeachCaseRelaInfoLst.Contains(x.IdTeachCaseRelaInfo));
return arrvTeachCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
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
public static List<clsvTeachCaseRelaInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeachCaseRelaInfoEN> GetSubObjLstCache(clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoCond)
{
List<clsvTeachCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachCaseRelaInfo.AttributeName)
{
if (objvTeachCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvTeachCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvTeachCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachCaseRelaInfoCond[strFldName]));
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
public static List<clsvTeachCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
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
public static List<clsvTeachCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
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
List<clsvTeachCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTeachCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTeachCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
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
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
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
public static List<clsvTeachCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTeachCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
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
public static List<clsvTeachCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCaseRelaInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeachCaseRelaInfoEN> arrObjLst = new List<clsvTeachCaseRelaInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = new clsvTeachCaseRelaInfoEN();
try
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachCaseRelaInfoEN.IdTeachCase = objRow[convTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseRelaInfoEN.TeachCaseName = objRow[convTeachCaseRelaInfo.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseRelaInfoEN.IdResource = objRow[convTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachCaseRelaInfoEN.ResourceID = objRow[convTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCaseRelaInfoEN.IdFtpResource = objRow[convTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCaseRelaInfoEN.FtpResourceID = objRow[convTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCaseRelaInfoEN.FileOriginalName = objRow[convTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCaseRelaInfoEN.FileDirName = objRow[convTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachCaseRelaInfoEN.FileRename = objRow[convTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachCaseRelaInfoEN.FileUpDate = objRow[convTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.FileUpTime = objRow[convTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileSize = objRow[convTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachCaseRelaInfoEN.FileType = objRow[convTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachCaseRelaInfoEN.ResourceOwner = objRow[convTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachCaseRelaInfoEN.IdFile = objRow[convTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachCaseRelaInfoEN.FileName = objRow[convTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachCaseRelaInfoEN.SaveDate = objRow[convTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachCaseRelaInfoEN.SaveTime = objRow[convTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachCaseRelaInfoEN.FileOriginName = objRow[convTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachCaseRelaInfoEN.IdResourceType = objRow[convTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCaseRelaInfoEN.ResourceTypeID = objRow[convTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCaseRelaInfoEN.ResourceTypeName = objRow[convTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCaseRelaInfoEN.FileNewName = objRow[convTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachCaseRelaInfoEN.FileOldName = objRow[convTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachCaseRelaInfoEN.ftpFileType = objRow[convTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseRelaInfoEN.ftpFileSize = objRow[convTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[convTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID].ToString().Trim(); //案例相关信息类型ID
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objRow[convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseRelaInfoEN.BrowseCount = objRow[convTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCaseRelaInfoEN.Memo = objRow[convTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseRelaInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeachCaseRelaInfo(ref clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN)
{
bool bolResult = vTeachCaseRelaInfoDA.GetvTeachCaseRelaInfo(ref objvTeachCaseRelaInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCaseRelaInfoEN GetObjByIdTeachCaseRelaInfo(long lngIdTeachCaseRelaInfo)
{
clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = vTeachCaseRelaInfoDA.GetObjByIdTeachCaseRelaInfo(lngIdTeachCaseRelaInfo);
return objvTeachCaseRelaInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeachCaseRelaInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = vTeachCaseRelaInfoDA.GetFirstObj(strWhereCond);
 return objvTeachCaseRelaInfoEN;
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
public static clsvTeachCaseRelaInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = vTeachCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvTeachCaseRelaInfoEN;
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
public static clsvTeachCaseRelaInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN = vTeachCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvTeachCaseRelaInfoEN;
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
 /// <param name = "lngIdTeachCaseRelaInfo">所给的关键字</param>
 /// <param name = "lstvTeachCaseRelaInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachCaseRelaInfoEN GetObjByIdTeachCaseRelaInfoFromList(long lngIdTeachCaseRelaInfo, List<clsvTeachCaseRelaInfoEN> lstvTeachCaseRelaInfoObjLst)
{
foreach (clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN in lstvTeachCaseRelaInfoObjLst)
{
if (objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo == lngIdTeachCaseRelaInfo)
{
return objvTeachCaseRelaInfoEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngIdTeachCaseRelaInfo;
 try
 {
 lngIdTeachCaseRelaInfo = new clsvTeachCaseRelaInfoDA().GetFirstID(strWhereCond);
 return lngIdTeachCaseRelaInfo;
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
 arrList = vTeachCaseRelaInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vTeachCaseRelaInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdTeachCaseRelaInfo)
{
//检测记录是否存在
bool bolIsExist = vTeachCaseRelaInfoDA.IsExist(lngIdTeachCaseRelaInfo);
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
 bolIsExist = clsvTeachCaseRelaInfoDA.IsExistTable();
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
 bolIsExist = vTeachCaseRelaInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoENS, clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoENT)
{
try
{
objvTeachCaseRelaInfoENT.IdTeachCaseRelaInfo = objvTeachCaseRelaInfoENS.IdTeachCaseRelaInfo; //案例相关信息流水号
objvTeachCaseRelaInfoENT.IdTeachCase = objvTeachCaseRelaInfoENS.IdTeachCase; //案例流水号
objvTeachCaseRelaInfoENT.TeachCaseName = objvTeachCaseRelaInfoENS.TeachCaseName; //案例名称
objvTeachCaseRelaInfoENT.IdResource = objvTeachCaseRelaInfoENS.IdResource; //资源流水号
objvTeachCaseRelaInfoENT.ResourceID = objvTeachCaseRelaInfoENS.ResourceID; //资源ID
objvTeachCaseRelaInfoENT.SaveMode = objvTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvTeachCaseRelaInfoENT.IdFtpResource = objvTeachCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvTeachCaseRelaInfoENT.FtpResourceID = objvTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvTeachCaseRelaInfoENT.FileOriginalName = objvTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvTeachCaseRelaInfoENT.FileDirName = objvTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvTeachCaseRelaInfoENT.FileRename = objvTeachCaseRelaInfoENS.FileRename; //文件新名
objvTeachCaseRelaInfoENT.FileUpDate = objvTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvTeachCaseRelaInfoENT.FileUpTime = objvTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvTeachCaseRelaInfoENT.FileSize = objvTeachCaseRelaInfoENS.FileSize; //文件大小
objvTeachCaseRelaInfoENT.FileType = objvTeachCaseRelaInfoENS.FileType; //文件类型
objvTeachCaseRelaInfoENT.ResourceOwner = objvTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvTeachCaseRelaInfoENT.IdFile = objvTeachCaseRelaInfoENS.IdFile; //文件流水号
objvTeachCaseRelaInfoENT.FileName = objvTeachCaseRelaInfoENS.FileName; //文件名称
objvTeachCaseRelaInfoENT.SaveDate = objvTeachCaseRelaInfoENS.SaveDate; //创建日期
objvTeachCaseRelaInfoENT.SaveTime = objvTeachCaseRelaInfoENS.SaveTime; //创建时间
objvTeachCaseRelaInfoENT.FileOriginName = objvTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvTeachCaseRelaInfoENT.IdResourceType = objvTeachCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvTeachCaseRelaInfoENT.ResourceTypeID = objvTeachCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvTeachCaseRelaInfoENT.ResourceTypeName = objvTeachCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvTeachCaseRelaInfoENT.FileNewName = objvTeachCaseRelaInfoENS.FileNewName; //新文件名
objvTeachCaseRelaInfoENT.FileOldName = objvTeachCaseRelaInfoENS.FileOldName; //旧文件名
objvTeachCaseRelaInfoENT.ftpFileType = objvTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvTeachCaseRelaInfoENT.ftpFileSize = objvTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvTeachCaseRelaInfoENT.ftpResourceOwner = objvTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvTeachCaseRelaInfoENT.IdTeachCaseRelaInfoType = objvTeachCaseRelaInfoENS.IdTeachCaseRelaInfoType; //案例相关信息类型流水号
objvTeachCaseRelaInfoENT.TeachCaseRelaInfoTypeID = objvTeachCaseRelaInfoENS.TeachCaseRelaInfoTypeID; //案例相关信息类型ID
objvTeachCaseRelaInfoENT.TeachCaseRelaInfoTypeName = objvTeachCaseRelaInfoENS.TeachCaseRelaInfoTypeName; //案例相关信息类型名称
objvTeachCaseRelaInfoENT.IsVisible = objvTeachCaseRelaInfoENS.IsVisible; //是否显示
objvTeachCaseRelaInfoENT.BrowseCount = objvTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvTeachCaseRelaInfoENT.Memo = objvTeachCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objvTeachCaseRelaInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN)
{
try
{
objvTeachCaseRelaInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeachCaseRelaInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeachCaseRelaInfo.IdTeachCaseRelaInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfo; //案例相关信息流水号
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.IdTeachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.IdTeachCase = objvTeachCaseRelaInfoEN.IdTeachCase; //案例流水号
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.TeachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.TeachCaseName = objvTeachCaseRelaInfoEN.TeachCaseName; //案例名称
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.IdResource = objvTeachCaseRelaInfoEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.ResourceID = objvTeachCaseRelaInfoEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.SaveMode = objvTeachCaseRelaInfoEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.IdFtpResource = objvTeachCaseRelaInfoEN.IdFtpResource == "[null]" ? null :  objvTeachCaseRelaInfoEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FtpResourceID = objvTeachCaseRelaInfoEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FileOriginalName = objvTeachCaseRelaInfoEN.FileOriginalName == "[null]" ? null :  objvTeachCaseRelaInfoEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FileDirName = objvTeachCaseRelaInfoEN.FileDirName == "[null]" ? null :  objvTeachCaseRelaInfoEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FileRename = objvTeachCaseRelaInfoEN.FileRename == "[null]" ? null :  objvTeachCaseRelaInfoEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FileUpDate = objvTeachCaseRelaInfoEN.FileUpDate == "[null]" ? null :  objvTeachCaseRelaInfoEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FileUpTime = objvTeachCaseRelaInfoEN.FileUpTime == "[null]" ? null :  objvTeachCaseRelaInfoEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FileSize = objvTeachCaseRelaInfoEN.FileSize == "[null]" ? null :  objvTeachCaseRelaInfoEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FileType = objvTeachCaseRelaInfoEN.FileType == "[null]" ? null :  objvTeachCaseRelaInfoEN.FileType; //文件类型
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.ResourceOwner = objvTeachCaseRelaInfoEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.IdFile = objvTeachCaseRelaInfoEN.IdFile == "[null]" ? null :  objvTeachCaseRelaInfoEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FileName = objvTeachCaseRelaInfoEN.FileName == "[null]" ? null :  objvTeachCaseRelaInfoEN.FileName; //文件名称
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.SaveDate = objvTeachCaseRelaInfoEN.SaveDate == "[null]" ? null :  objvTeachCaseRelaInfoEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.SaveTime = objvTeachCaseRelaInfoEN.SaveTime == "[null]" ? null :  objvTeachCaseRelaInfoEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FileOriginName = objvTeachCaseRelaInfoEN.FileOriginName == "[null]" ? null :  objvTeachCaseRelaInfoEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.IdResourceType = objvTeachCaseRelaInfoEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.ResourceTypeID = objvTeachCaseRelaInfoEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.ResourceTypeName = objvTeachCaseRelaInfoEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FileNewName = objvTeachCaseRelaInfoEN.FileNewName == "[null]" ? null :  objvTeachCaseRelaInfoEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.FileOldName = objvTeachCaseRelaInfoEN.FileOldName == "[null]" ? null :  objvTeachCaseRelaInfoEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.ftpFileType = objvTeachCaseRelaInfoEN.ftpFileType == "[null]" ? null :  objvTeachCaseRelaInfoEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.ftpFileSize = objvTeachCaseRelaInfoEN.ftpFileSize == "[null]" ? null :  objvTeachCaseRelaInfoEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.ftpResourceOwner = objvTeachCaseRelaInfoEN.ftpResourceOwner == "[null]" ? null :  objvTeachCaseRelaInfoEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.IdTeachCaseRelaInfoType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objvTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType; //案例相关信息类型流水号
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID = objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeID; //案例相关信息类型ID
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.TeachCaseRelaInfoTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName = objvTeachCaseRelaInfoEN.TeachCaseRelaInfoTypeName; //案例相关信息类型名称
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.IsVisible = objvTeachCaseRelaInfoEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.BrowseCount = objvTeachCaseRelaInfoEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convTeachCaseRelaInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseRelaInfoEN.Memo = objvTeachCaseRelaInfoEN.Memo == "[null]" ? null :  objvTeachCaseRelaInfoEN.Memo; //备注
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
 /// <param name = "objvTeachCaseRelaInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN)
{
try
{
if (objvTeachCaseRelaInfoEN.IdFtpResource == "[null]") objvTeachCaseRelaInfoEN.IdFtpResource = null; //FTP资源流水号
if (objvTeachCaseRelaInfoEN.FileOriginalName == "[null]") objvTeachCaseRelaInfoEN.FileOriginalName = null; //文件原名
if (objvTeachCaseRelaInfoEN.FileDirName == "[null]") objvTeachCaseRelaInfoEN.FileDirName = null; //文件目录名
if (objvTeachCaseRelaInfoEN.FileRename == "[null]") objvTeachCaseRelaInfoEN.FileRename = null; //文件新名
if (objvTeachCaseRelaInfoEN.FileUpDate == "[null]") objvTeachCaseRelaInfoEN.FileUpDate = null; //创建日期
if (objvTeachCaseRelaInfoEN.FileUpTime == "[null]") objvTeachCaseRelaInfoEN.FileUpTime = null; //创建时间
if (objvTeachCaseRelaInfoEN.FileSize == "[null]") objvTeachCaseRelaInfoEN.FileSize = null; //文件大小
if (objvTeachCaseRelaInfoEN.FileType == "[null]") objvTeachCaseRelaInfoEN.FileType = null; //文件类型
if (objvTeachCaseRelaInfoEN.IdFile == "[null]") objvTeachCaseRelaInfoEN.IdFile = null; //文件流水号
if (objvTeachCaseRelaInfoEN.FileName == "[null]") objvTeachCaseRelaInfoEN.FileName = null; //文件名称
if (objvTeachCaseRelaInfoEN.SaveDate == "[null]") objvTeachCaseRelaInfoEN.SaveDate = null; //创建日期
if (objvTeachCaseRelaInfoEN.SaveTime == "[null]") objvTeachCaseRelaInfoEN.SaveTime = null; //创建时间
if (objvTeachCaseRelaInfoEN.FileOriginName == "[null]") objvTeachCaseRelaInfoEN.FileOriginName = null; //原文件名
if (objvTeachCaseRelaInfoEN.FileNewName == "[null]") objvTeachCaseRelaInfoEN.FileNewName = null; //新文件名
if (objvTeachCaseRelaInfoEN.FileOldName == "[null]") objvTeachCaseRelaInfoEN.FileOldName = null; //旧文件名
if (objvTeachCaseRelaInfoEN.ftpFileType == "[null]") objvTeachCaseRelaInfoEN.ftpFileType = null; //ftp文件类型
if (objvTeachCaseRelaInfoEN.ftpFileSize == "[null]") objvTeachCaseRelaInfoEN.ftpFileSize = null; //ftp文件大小
if (objvTeachCaseRelaInfoEN.ftpResourceOwner == "[null]") objvTeachCaseRelaInfoEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvTeachCaseRelaInfoEN.Memo == "[null]") objvTeachCaseRelaInfoEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoEN)
{
 vTeachCaseRelaInfoDA.CheckProperty4Condition(objvTeachCaseRelaInfoEN);
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
if (clsTeachCaseRelaInfoTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCaseRelaInfoTypeBL没有刷新缓存机制(clsTeachCaseRelaInfoTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachCaseRelaInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCaseRelaInfoBL没有刷新缓存机制(clsTeachCaseRelaInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceBL没有刷新缓存机制(clsResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerBL没有刷新缓存机制(clsFileServerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceBL没有刷新缓存机制(clsFtpResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCaseBL没有刷新缓存机制(clsTeachCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeBL没有刷新缓存机制(clsSkillTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillBL没有刷新缓存机制(clsTeachSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeachCaseRelaInfo");
//if (arrvTeachCaseRelaInfoObjLstCache == null)
//{
//arrvTeachCaseRelaInfoObjLstCache = vTeachCaseRelaInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachCaseRelaInfoEN GetObjByIdTeachCaseRelaInfoCache(long lngIdTeachCaseRelaInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTeachCaseRelaInfoEN._CurrTabName);
List<clsvTeachCaseRelaInfoEN> arrvTeachCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCaseRelaInfoEN> arrvTeachCaseRelaInfoObjLst_Sel =
arrvTeachCaseRelaInfoObjLstCache
.Where(x=> x.IdTeachCaseRelaInfo == lngIdTeachCaseRelaInfo 
);
if (arrvTeachCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvTeachCaseRelaInfoEN obj = clsvTeachCaseRelaInfoBL.GetObjByIdTeachCaseRelaInfo(lngIdTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTeachCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachCaseRelaInfoEN> GetAllvTeachCaseRelaInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsvTeachCaseRelaInfoEN> arrvTeachCaseRelaInfoObjLstCache = GetObjLstCache(); 
return arrvTeachCaseRelaInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachCaseRelaInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTeachCaseRelaInfoEN._CurrTabName);
List<clsvTeachCaseRelaInfoEN> arrvTeachCaseRelaInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachCaseRelaInfoObjLstCache;
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
string strKey = string.Format("{0}", clsvTeachCaseRelaInfoEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdTeachCaseRelaInfo)
{
if (strInFldName != convTeachCaseRelaInfo.IdTeachCaseRelaInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeachCaseRelaInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeachCaseRelaInfo.AttributeName));
throw new Exception(strMsg);
}
var objvTeachCaseRelaInfo = clsvTeachCaseRelaInfoBL.GetObjByIdTeachCaseRelaInfoCache(lngIdTeachCaseRelaInfo);
if (objvTeachCaseRelaInfo == null) return "";
return objvTeachCaseRelaInfo[strOutFldName].ToString();
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
int intRecCount = clsvTeachCaseRelaInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvTeachCaseRelaInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeachCaseRelaInfoDA.GetRecCount();
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
int intRecCount = clsvTeachCaseRelaInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeachCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeachCaseRelaInfoEN objvTeachCaseRelaInfoCond)
{
List<clsvTeachCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachCaseRelaInfo.AttributeName)
{
if (objvTeachCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvTeachCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvTeachCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachCaseRelaInfoCond[strFldName]));
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
 List<string> arrList = clsvTeachCaseRelaInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTeachCaseRelaInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTeachCaseRelaInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}